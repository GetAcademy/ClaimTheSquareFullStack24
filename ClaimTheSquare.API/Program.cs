using WebApplication6;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
app.MapGet("/numbers", () => new[] { 1, 2, 3 });
app.MapGet("/people", DataManager.GetPeople);
//app.MapGet("/weatherforecast", () =>
//{
//    return new Person[]
//    {
//        new Person{Name = "Per", BirthYear = 1980},
//        new Person{Name = "Pål", BirthYear = 1981},
//    };
//});
app.Run();
