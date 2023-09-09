using Refit;

var swapi = RestService.For<IStarWarsApi>("https://swapi.dev/api");
var luke = await swapi.GetPerson(1);

Console.WriteLine(luke.ToString());

public interface IStarWarsApi
{
	[Get("/people/{personId}")]
	Task<Person> GetPerson(int personId);
	
	// Can also implement POST/PUT/PATCH/etc. if suported by the service.
}


public record class Person
{
	public string name { get; set; }
	public string height { get; set; }
	public string mass { get; set; }
	public string hair_color { get; set; }
	public string skin_color { get; set; }
	public string eye_color { get; set; }
	public string birth_year { get; set; }
	public string gender { get; set; }
	public string homeworld { get; set; }
	public List<string> films { get; set; }
	public List<string> species { get; set; }
	public List<string> vehicles { get; set; }
	public List<string> starships { get; set; }
	public DateTime created { get; set; }
	public DateTime edited { get; set; }
	public string url { get; set; }
}

