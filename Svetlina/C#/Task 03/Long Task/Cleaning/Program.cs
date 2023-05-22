public class Program
{
	public static void Main()
	{
		double square = double.Parse(Console.ReadLine());

		Task<double> vacuuming = Task.Run(() =>  square * 0.5 );
		Task<double> washing = Task.Run(() => square * 1.5);

		Task<double> cleaning = Task.Run(() => vacuuming.Result + washing.Result);

		int hours = (int)(cleaning.Result / 60);
		var minutes = cleaning.Result % 60;

		Console.WriteLine($"Cleaning for {hours} hours and {minutes} minutes");
	}

}