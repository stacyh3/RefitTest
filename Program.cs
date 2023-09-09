using Refit;
using Swapi;

var swapi = RestService.For<IStarWarsApi>("https://swapi.dev/api");
var luke = await swapi.GetPerson(1);

Console.WriteLine(luke.ToString());

namespace Swapi
{
    public interface IStarWarsApi
    {
        [Get("/people/{personId}")]
        Task<Person> GetPerson(int personId);

        // Can also implement POST/PUT/PATCH/etc. if suported by the service.
    }
    
    public record class Person
    {
        public string? Name { get; set; }
        public string? Height { get; set; }
        public string? Mass { get; set; }
        public string? Hair_color { get; set; }
        public string? Skin_Color { get; set; }
        public string? Eye_Color { get; set; }
        public string? Birth_Year { get; set; }
        public string? Gender { get; set; }
        public string? Homeworld { get; set; }
        public List<string>? Films { get; set; }
        public List<string>? Species { get; set; }
        public List<string>? Vehicles { get; set; }
        public List<string>? Starships { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string? Url { get; set; }
    }

}