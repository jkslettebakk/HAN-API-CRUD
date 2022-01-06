

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    string name = builder.Configuration.GetConnectionString("Name");
    Console.WriteLine(name);
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
var jsonSerializerOptions = new JsonSerializerOptions
{
    WriteIndented = true
};

app.UseHttpsRedirection();

app.MapGet("/help", () =>
{
    string name = builder.Configuration.GetSection("Position:Name").Value;
    string help = "https://han.slettebakk.com" +
                                "\n* /swagger/v1/swagger.json" +
                                "\n* /api/HANdata" +
                                "\n* /api/HANData/id/{id}" +
                                "\n* /api/HANData/Delete/{id} *) uder development" +
                                "\n\n* for /POST'ing to this endpoint use curl, postman or similar tools you like" +
                                "\n* " + name;
    return Results.Ok(help);
});

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

// The GET department
app.MapGet("/api/List1/", async (DataContext data) =>
{
    var resultList = await data.List1
                            .Include(x => x.ActivePowerQ1Q4)
                            .OrderByDescending(x => x.DateTimePoll)
                            .ToListAsync();

    var Json = JsonSerializer.Serialize(resultList, jsonSerializerOptions);
    return Json;
});

app.MapGet("/api/List2/", async (DataContext data) =>
{
     var resultList = await data.List2
                            .Include(x => x.ActivePowerQ1Q4)
                            .Include(x => x.ActivePowerQ2Q3)
                            .Include(x => x.ReactivePowerQ1Q2)
                            .Include(x => x.ReactivePowerQ3Q4)
                            .Include(x => x.AmpereIL1)
                            .Include(x => x.AmpereIL3)
                            .Include(x => x.VoltUL1)
                            .Include(x => x.VoltUL2)
                            .Include(x => x.VoltUL3)
                            .OrderByDescending(x => x.DateTimePoll)
                            .ToListAsync();

    var Json = JsonSerializer.Serialize(resultList, jsonSerializerOptions);
    return Json;
});

app.MapGet("/api/List3/", async (DataContext data) =>
{
    var resultList = await data.List3
                            .Include(x => x.ActivePowerQ1Q4)
                            .Include(x => x.ActivePowerQ2Q3)
                            .Include(x => x.ReactivePowerQ1Q2)
                            .Include(x => x.ReactivePowerQ3Q4)
                            .Include(x => x.AmpereIL1)
                            .Include(x => x.AmpereIL3)
                            .Include(x => x.VoltUL1)
                            .Include(x => x.VoltUL2)
                            .Include(x => x.VoltUL3)
                            .Include(x => x.ActivePowerAQ1Q4)
                            .Include(x => x.ActivePowerAQ2Q3)
                            .Include(x => x.ReactivePowerRQ1Q2)
                            .Include(x => x.ReactivePowerRQ3Q4)
                            .OrderByDescending(x => x.DateTimePoll)
                            .ToListAsync();

    var Json = JsonSerializer.Serialize(resultList, jsonSerializerOptions);
    return Json;
});
// GET number
app.MapGet("/api/List1/number/{number}", async (DataContext data, int number) =>
{
    var resultList = await data.List1
                            .Include(x => x.ActivePowerQ1Q4)
                            .OrderByDescending(x => x.DateTimePoll)
                            .Take(number)
                            .ToListAsync();

    var Json = JsonSerializer.Serialize(resultList, jsonSerializerOptions);
    return Json;
});

app.MapGet("/api/List2/number/{number}", async (DataContext data, int number) =>
{
    var resultList = await data.List2
                           .Include(x => x.ActivePowerQ1Q4)
                           .Include(x => x.ActivePowerQ2Q3)
                           .Include(x => x.ReactivePowerQ1Q2)
                           .Include(x => x.ReactivePowerQ3Q4)
                           .Include(x => x.AmpereIL1)
                           .Include(x => x.AmpereIL3)
                           .Include(x => x.VoltUL1)
                           .Include(x => x.VoltUL2)
                           .Include(x => x.VoltUL3)
                           .OrderByDescending(x => x.DateTimePoll)
                           .Take(number)
                           .ToListAsync();

    var Json = JsonSerializer.Serialize(resultList, jsonSerializerOptions);
    return Json;
});

app.MapGet("/api/List3/number/{number}", async (DataContext data, int number) =>
{
    var resultList = await data.List3
                            .Include(x => x.ActivePowerQ1Q4)
                            .Include(x => x.ActivePowerQ2Q3)
                            .Include(x => x.ReactivePowerQ1Q2)
                            .Include(x => x.ReactivePowerQ3Q4)
                            .Include(x => x.AmpereIL1)
                            .Include(x => x.AmpereIL3)
                            .Include(x => x.VoltUL1)
                            .Include(x => x.VoltUL2)
                            .Include(x => x.VoltUL3)
                            .Include(x => x.ActivePowerAQ1Q4)
                            .Include(x => x.ActivePowerAQ2Q3)
                            .Include(x => x.ReactivePowerRQ1Q2)
                            .Include(x => x.ReactivePowerRQ3Q4)
                            .OrderByDescending(x => x.DateTimePoll)
                            .Take(number)
                            .ToListAsync();

    var Json = JsonSerializer.Serialize(resultList, jsonSerializerOptions);
    return Json;
});

// Various option lists
app.MapGet("/api/List1/order/{order}", async (DataContext data, int order) =>
{

    if (order >= 0)
    {
        var resultList = await data.List1
                    .Include(x => x.ActivePowerQ1Q4)
                    .OrderBy(x => x.DateTimePoll)
                    .ToListAsync();
        var Json = JsonSerializer.Serialize(resultList, jsonSerializerOptions);
        return Json;
    }
    else
    {
        var resultList = await data.List1
                    .Include(x => x.ActivePowerQ1Q4)
                    .OrderByDescending(x => x.DateTimePoll)
                    .ToListAsync();
        var Json = JsonSerializer.Serialize(resultList, jsonSerializerOptions);
        return Json;
    }

}); 
app.MapGet("/api/List2/order/{order}", async (DataContext data, int order) =>
{

    if (order >= 0)
    {
        var resultList = await data.List2.Include(x => x.ActivePowerQ1Q4).Include(x => x.ActivePowerQ2Q3)
                    .Include(x => x.ReactivePowerQ1Q2).Include(x => x.ReactivePowerQ3Q4)
                    .Include(x => x.AmpereIL1).Include(x => x.AmpereIL3)
                    .Include(x => x.VoltUL1).Include(x => x.VoltUL2).Include(x => x.VoltUL3)
                    .OrderBy(x => x.DateTimePoll)
                    .ToListAsync();
        var Json = JsonSerializer.Serialize(resultList, jsonSerializerOptions);
        return Json;
    }
    else
    {
        var resultList = await data.List2
                    .Include(x => x.ActivePowerQ1Q4).Include(x => x.ActivePowerQ2Q3)
                    .Include(x => x.ReactivePowerQ1Q2).Include(x => x.ReactivePowerQ3Q4)
                    .Include(x => x.AmpereIL1).Include(x => x.AmpereIL3)
                    .Include(x => x.VoltUL1).Include(x => x.VoltUL2).Include(x => x.VoltUL3)
                    .OrderBy(x => x.DateTimePoll)
                    .OrderByDescending(x => x.HANDataId)
                    .ToListAsync();
        var Json = JsonSerializer.Serialize(resultList, jsonSerializerOptions);
        return Json;
    }

});

app.MapGet("/api/List2/id/{id}", async (DataContext data, Guid? id) =>
{
    if ( id == Guid.Empty)
        return Results.NotFound();
    var foundRecord = await data.List2.FindAsync(id);
    // foundRecord.ActivePowerQ1Q4 = await data.HANData.ActivePowerQ1Q4.FindAsync(id);
    if (foundRecord != null)
    {
        var Json = JsonSerializer.Serialize(foundRecord, jsonSerializerOptions);
        return Results.Ok(foundRecord);
    }
    return Results.NotFound();
});

// Counting
app.MapGet("/api/List1/number", async (DataContext data) =>
{
    int foundRecords = await data.List1.CountAsync();
    if (foundRecords != 0)
        return Results.Ok("List 1 total number of records: " + foundRecords);
    return Results.NotFound();
});
app.MapGet("/api/List2/number", async (DataContext data) =>
{
    int foundRecords = await data.List2.CountAsync();
    if (foundRecords != 0)
        return Results.Ok("List 2 total number of records: " + foundRecords);
    return Results.NotFound();
});
app.MapGet("/api/List3/number", async (DataContext data) =>
{
    int foundRecords = await data.List3.CountAsync();
    if (foundRecords != 0)
        return Results.Ok("List 3 total number of records: " + foundRecords);
    return Results.NotFound();
});

// The POST department
app.MapPost("/api/List1", async (DataContext data, List1 hanDataSet) =>
{
    var dataAdd = await data.List1.AddAsync(hanDataSet);
    // Console.WriteLine(dataAdd);
    int res = await data.SaveChangesAsync();
    Results.Accepted();
    return Results.Ok(hanDataSet);
});

app.MapPost("/api/List2", async (DataContext data, List2 hanDataSet) =>
{
    var dataAdd = await data.List2.AddAsync(hanDataSet);
    // Console.WriteLine(dataAdd);
    int res = await data.SaveChangesAsync();
    Results.Accepted();
    return Results.Ok(hanDataSet);
});

app.MapPost("/api/List3", async (DataContext data, List3 hanDataSet) =>
{
    var dataAdd = await data.List3.AddAsync(hanDataSet);
    // Console.WriteLine(dataAdd);
    int res = await data.SaveChangesAsync();
    Results.Accepted();
    return Results.Ok(hanDataSet);
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
