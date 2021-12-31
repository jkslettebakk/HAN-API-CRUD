

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Prepere some Json/XML formatting
var options = new JsonSerializerOptions
{
    WriteIndented = true
};

app.UseHttpsRedirection();

app.MapGet("/api/HANData/", async (DataContext data) =>
{
     var resultList = await data.HANData
                            .Include(x => x.ActivePowerQ1Q4)
                            .Include(x => x.ActivePowerQ2Q3)
                            .Include(x => x.ReactivePowerQ1Q2)
                            .Include(x => x.ReactivePowerQ3Q4)
                            .Include(x => x.AmpereIL1)
                            .Include(x => x.AmpereIL3)
                            .Include(x => x.VoltUL1)
                            .Include(x => x.VoltUL2)
                            .Include(x => x.VoltUL3)
                            .ToListAsync();

    var Json = JsonSerializer.Serialize(resultList, options);
    return Json;
    // return resultList;
    //return await data.HANData.ToArrayAsync();
});

app.MapGet("/api/HANData/{id}", async (DataContext data, Guid id) =>
{
    var foundRecord = await data.HANData.FindAsync(id);
    // foundRecord.ActivePowerQ1Q4 = await data.HANData.ActivePowerQ1Q4.FindAsync(id);
    return foundRecord;
});

app.MapPost("/api/HANData", async (DataContext data, HANData hanDataSet) =>
{
    var dataAdd = await data.HANData.AddAsync(hanDataSet);
    Console.WriteLine(dataAdd);
    int res = await data.SaveChangesAsync();
    Results.Accepted();
    return hanDataSet;
});

/*
 * app.MapDelete("/api/HANData/Delete/{id}", async (DataContext data, Guid id) =>
{
    // Need to fix a problem where data in child tables does not get delete
    //
    var RemoveData = await data.HANData.FindAsync(id); // This gives Data from HAN data table only
    // var Key1 = await RemoveData.ActivePowerQ1Q4.Id;
/*
    var AllObjects = data.HANData
                           .Include(x => x.ActivePowerQ1Q4)
                           .Include(x => x.ActivePowerQ2Q3)
                           .Include(x => x.ReactivePowerQ1Q2)
                           .Include(x => x.ReactivePowerQ3Q4)
                           .Include(x => x.AmpereIL1)
                           .Include(x => x.AmpereIL3)
                           .Include(x => x.VoltUL1)
                           .Include(x => x.VoltUL2)
                           .Include(x => x.VoltUL3);
                           // .FindAsync(id);
                           // .FirstOrDefaultAsync(id);
                           // .ToListAsync();
*/

    if ( RemoveData is HANData hanDataSet)
    {
        // var ActivePowerQ1Q4Objectid = RemoveData.ActivePowerQ1Q4.Id;
        // var ActivePowerQ1Q4ObjectidRemove = await data.ActivePowerQ1Q4.FindAsync(ActivePowerQ1Q4Objectid);

        data.HANData.Remove(RemoveData);
        data.SaveChanges();
        return Results.Ok(RemoveData);
    }
    return Results.NotFound();
});
*/

app.Run();
