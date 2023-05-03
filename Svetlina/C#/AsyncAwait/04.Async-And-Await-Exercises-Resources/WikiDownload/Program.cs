public class Program
{
	public static async Task Main()
	{
		string url = "https://developer.wikimedia.org";
		string html = await DownloadHtmlAsync(url);
		Console.WriteLine(html);
	}

	public static async Task<string> DownloadHtmlAsync(string url)
	{
		using (HttpClient client = new HttpClient())
		{
			HttpResponseMessage response = await client.GetAsync(url);
			response.EnsureSuccessStatusCode();
			string html = await response.Content.ReadAsStringAsync();
			return html;
		}
	}
}
