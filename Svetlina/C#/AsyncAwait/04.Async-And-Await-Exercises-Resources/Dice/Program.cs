

class Program
{
	public static void Main()
	{
		var result = DiceRollAsync();

		Console.WriteLine($"Your dice roll result is {result}");
	}

	static async Task<int> DiceRollAsync()
	{
		Console.WriteLine("Dice rolling...");

		int roll1 = await RollAsync();
		int roll2 = await RollAsync();


		return roll1 + roll2;
	}

	static async Task<int> RollAsync()
	{
		await Task.Delay(500);

		return new Random().Next(1, 7);
	}
}