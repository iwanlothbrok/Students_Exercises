public class Program
{
	static void Main(string[] args)
	{
		var timer = new Timer();

		var thread = new Thread(timer.IncreaseTimer);

		thread.Start();
		timer.CurrentTime();
	}
}
class Timer
{
	private int hours = 4;
	private int minutes = 59;
	private int seconds = 59;


	public void IncreaseTimer()
	{
		lock (this)
		{
			this.seconds++;
			if (this.seconds == 60)
			{
				this.seconds = 0;
				this.minutes++;

				if (this.minutes == 60)
				{
					this.minutes = 0;
					// check if you should do the same for the hours
					Thread.Sleep(1000);
					this.hours++;
				}
			}
		}
	}

	public void CurrentTime()
	{
		lock (this)
		{
			Console.WriteLine($"Current Time =  hours: {this.hours} minutes: {this.minutes} seconds: {this.seconds}");
		}
	}
}