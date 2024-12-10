using System.Text.Json;
using ClaimTheSquare.API.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
List<TextObject> textObjects;
if (File.Exists("textobjects.json"))
{
    var json = File.ReadAllText("textobjects.json");
    textObjects = JsonSerializer.Deserialize<List<TextObject>>(json);
}
else
{
    textObjects = new List<TextObject>();
}
app.MapGet("/textobjects", () =>
{
    return textObjects;
});
app.MapPost("/textobjects", (TextObject textObject) =>
{
    textObjects.Add(textObject);
    var json = JsonSerializer.Serialize(textObjects);
    File.WriteAllText("textobjects.json", json);
});
app.Run();

