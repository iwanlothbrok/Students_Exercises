class Program
{
    const string password = "042";
    static void Main()
    {

        while (true)
        {
            Console.Write("Enter the password (3 digits): ");
            string guess = Console.ReadLine();

            if (guess == password)
            {
                Console.WriteLine("Congratulations! You guessed the password!");
                break;
            }
            else
            {
                int correctDigits = 0;
                int correctPositions = 0;

                for (int i = 0; i < 3; i++)
                {
                    if (guess[i] == password[i])
                    {
                        correctDigits++;
                        correctPositions++;
                    }
                    else if (password.Contains(guess[i].ToString()))
                    {
                        correctDigits++;
                    }
                }

                Console.WriteLine($"Your guess is close. {correctDigits} digits are correct, with {correctPositions} in the correct position.");
            }
        }

        Console.WriteLine("Game over. Thank you for playing!");
    }
}
