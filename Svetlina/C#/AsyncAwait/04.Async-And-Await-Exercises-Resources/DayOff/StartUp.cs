using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DayOff
{
	class StartUp
	{

		static async Task Main()
		{
			Console.WriteLine("Good morning! " +
				"Your plans for today are: " +
				"making breakfast and listening to music, " +
				"eating breakfast and reading the news.");

			Breakfast breakfast = new Breakfast();
			Radio radio = new Radio();
			Newspaper newspaper = new Newspaper();

			//// TODO: 
			//// Instantiate the objects from the classes and run the methods.
			//// You have to cook breakfast and listen to music at the same time.


			Task<Breakfast> eatingTask = MakingBreakfastAsync(breakfast);
			Task<Radio> radioTask = ListeningMusicAsync(radio);

			await Task.WhenAll(eatingTask, radioTask);

			Task<Newspaper> reading = ReadingNewsAsync(newspaper);
			Task<Breakfast> eatingBreakfastAsync = EatingBreakfastAsync(breakfast);

			await Task.WhenAll(reading, eatingBreakfastAsync);

			//await MakingBreakfastAsync(breakfast);
			//await ListeningMusicAsync(radio);

			////// When you finish preparing the breakfast, you should start eating the prepared breakfast.
			////// The state of the breakfast should be cooked and eaten.
			//EatingBreakfastAsync(breakfast);

			////// When you finish listening to the music, you should turn off the radio and start reading the newspaper.
			//ReadingNewsAsync(newspaper);
			//// The newspaper status should be Readed.
		
			Console.WriteLine($"Breakfast was cooked: {breakfast.IsReady}");
			Console.WriteLine($"Breakfast was eaten: {breakfast.IsEaten}");
			Console.WriteLine($"The radio is on: {radio.IsOn}");
			Console.WriteLine($"The newspaper was read: {newspaper.IsReaded}");
		}

		static async Task<Breakfast> MakingBreakfastAsync(Breakfast breakfast)
		{
			// TODO: The method should:
			// take a Breakfast object as a parameter

			// print "Making breakfast."
			Console.WriteLine("Making breakfast.");

			// then it should sleep the task for 1000 milliseconds
			await Task.Delay(1000);

			// change the state of the breakfast object to cooked
			// print the message  from the object’s method
			string isReady = breakfast.Cooked();
			Console.WriteLine(isReady);


			// finally return the Breakfast object
			return breakfast;
		}
		static async Task<Radio> ListeningMusicAsync(Radio radio)
		{
			// TODO: The method should:
			// take a Radio object as a parameter
			// turn on the radio and print the message  from the object’s method
			Console.WriteLine(radio.RadioOn());

			// then it should sleep the task for 1000 milliseconds
			await Task.Delay(1000);

			// turn off the radio and print the message  from the object’s method
			Console.WriteLine(radio.RadioOf());

			// finally return the Radio object
			return radio;
		}
		static async Task<Breakfast> EatingBreakfastAsync(Breakfast breakfast)
		{
			// TODO: The method should:
			// take a Breakfast object as a parameter
			// print "Eating breakfast."
			Console.WriteLine("Eating breakfast.");

			// then it should sleep the task for 1700 milliseconds
			await Task.Delay(1700);

			// change the state of the breakfast object to eaten
			string isEaten = breakfast.Eaten();

			// print the message  from the object’s method
			Console.WriteLine(isEaten);

			// finally return the Breakfast object
			return breakfast;
		}
		static async Task<Newspaper> ReadingNewsAsync(Newspaper newspaper)
		{
			// TODO: The method should:
			// take a Newspaper object as a parameter
			// read the newspaper and print the message from the object’s method
			Console.WriteLine(newspaper.Reading());

			// then it should sleep the task for 1700 milliseconds
			await Task.Delay(1700);

			// finally return the Newspaper object
			return newspaper;
		}

	}
}
