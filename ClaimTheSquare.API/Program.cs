using ClaimTheSquare.API.Model;
using Dapper;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.MapGet("/textobjects", async () =>
{
    var connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TextObjects;Integrated Security=True";
    var sql = "SELECT * FROM TextObject";
    var conn = new SqlConnection(connStr);
    var textObjects = await conn.QueryAsync<TextObject>(sql);
    return textObjects;
});
app.MapPost("/textobjects", (TextObject textObject) =>
{
    //textObjects.Add(textObject);
});
app.Run();

