public class Program
{
	public static async Task Main()
	{
		try
		{
			Task seed = Task.Run(() =>
			{
			int errorIndex = int.Parse(Console.ReadLine());
				for (int i = 0; i < 16; i++)
				{
					Console.WriteLine($"Seeding {i} plot.");
					if (i == errorIndex)
					{
						throw new Exception("Something went wrong with seeding.");
					}
				}
			});

			await seed;
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Stop seeding and notify: {ex.Message}.");
		}
	}
}