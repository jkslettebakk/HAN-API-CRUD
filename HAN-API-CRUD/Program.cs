
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

app.UseHttpsRedirection();

app.MapGet("/api/HANData", async (DataContext data) =>
{
    /*
    await data.HANData
                    .Include(p => p.activePowerQ1Q4)
                    .Include(p => p.activePowerQ2Q3)
                    .Include(p => p.reactivePowerQ1Q2)
                    .Include(p => p.reactivePowerQ3Q4)
                    .Include(p => p.ampereIL1)
                    .Include(p => p.ampereIL3)
                    .Include(p => p.voltUL1)
                    .Include(p => p.voltUL2)
                    .Include(p => p.voltUL3)
                    .ToListAsync();
    */
    // await data.HANData.ToListAsync();
    await data.HANData.FindAsync();
    if ( data.HANData.Count() > 0 )
    {
        return Task.FromResult(data.HANData);
    }
    else
    {
        return null;
    }
});
/*
app.MapGet("/api/HANData/{id}", async (DataContext data, Guid id) =>
{
    return await data.HANData.FindAsync(id);
});

app.MapPost("/api/HANData", async (DataContext data, HANDataClasses hanDataSet) =>
{
    var dataAdd = await data.HANData.AddAsync(hanDataSet);
    Console.WriteLine("adding data to database:{0}\n", dataAdd);
    int res = await data.SaveChangesAsync();
    Console.WriteLine("SaveChangesAsync result = {0}",res);
    Results.Accepted();
    // return await data.HANData.ToListAsync();
    return hanDataSet;
});

app.MapDelete("/api/HANData/Delete/{id}", async (DataContext data, Guid id) =>
{
    var deleteData = await data.HANData.FindAsync(id);
    
    if (deleteData is null) return Results.NotFound();

    return Results.Ok();

});
*/

app.Run();
