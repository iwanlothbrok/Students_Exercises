using System.Reflection.Metadata;

public class Program
{
	public static void Main()
	{

		int n = int.Parse(Console.ReadLine());

		Task<int> task = Task.Run(() => FindFactorial(n)) ;
		Console.WriteLine($"Factorial of {n} is: {task.Result}");
	}

	public static int FindFactorial(int number)
	{
		int result = 1;
		for (int i = 2; i <= number; i++)
		{
			result *= i;
		}
		return result;
	}
}