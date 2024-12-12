using ClaimTheSquare.API.Model;

namespace ClaimTheSquare.API
{
    public class InMemoryProgram
    {
        public static void Run(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            var textObjects = new List<TextObject>
            {
                new TextObject{Index = 1, Text = "Per", ForeColor = "white", BackColor = "blue"},
                new TextObject{Index = 60, Text = "Pål", ForeColor = "yellow", BackColor = "red"},
            };
            app.MapGet("/textobjects", () =>
            {
                return textObjects;
            });
            app.MapPost("/textobjects", (TextObject textObject) =>
            {
                textObjects.Add(textObject);
            });
            app.Run();


/*

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


 */
        }
    }
}
