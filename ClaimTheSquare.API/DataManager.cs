namespace WebApplication6
{
    public class DataManager
    {
        public static Person[] GetPeople()
        {
            return new Person[]
            {
                new Person{Name = "Per", BirthYear = 1980},
                new Person{Name = "Pål", BirthYear = 1981},
            };
        }
    }
}
