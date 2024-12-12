using ClaimTheSquare.API.Model;
using Dapper;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
var connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ClaimTheSquare;Integrated Security=True";
app.MapGet("/textobjects", async () =>
{
    var sql = "SELECT * FROM TextObject";
    var conn = new SqlConnection(connStr);
    var textObjects = await conn.QueryAsync<TextObject>(sql);
    return textObjects;
});
app.MapPost("/textobjects", async (TextObject textObject) =>
{
    var sql = "INSERT INTO TextObject VALUES (@Index, @Text, @ForeColor, @BackColor)";
    var conn = new SqlConnection(connStr);
    var rowsAffected = await conn.ExecuteAsync(sql, textObject);
    return rowsAffected;
});
app.Run();

