using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class JokeData
{
	public bool error { get; set; }
	public string category { get; set; }
	public string type { get; set; }
	public string setup { get; set; }
	public string delivery { get; set; }
	public JObject flags { get; set; }
	public int id { get; set; }
	public bool safe { get; set; }
	public string lang { get; set; }
}

class Program
{
	static async Task Main(string[] args)
	{
		string url = "https://v2.jokeapi.dev/joke/Any?safe-mode";

		// Create a new HttpClient and fetch the API content asynchronously
		using (HttpClient client = new HttpClient())
		{
			string apiContent = await client.GetStringAsync(url);

			// Deserialize the API content to an AJoke object using JSON serialization
			JokeData joke = JsonConvert.DeserializeObject<JokeData>(apiContent);

			// Print the joke content based on its type
				Console.WriteLine($"Joke id: {joke.id}");
				Console.WriteLine($"Joke category: {joke.category}");
			if (joke.type == "twopart")
			{
				Console.WriteLine($"{joke.setup}");
				Console.WriteLine($"{joke.delivery}");
			}
			else if (joke.type == "single")
			{
				Console.WriteLine(joke);
			}
		}
	}
}