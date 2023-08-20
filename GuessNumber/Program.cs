using System;

class Program

{
    //Create a simple number guessing game where the computer generates a random number, and the user has to guess it
    static void Main(string[] args)
    {
        Console.WriteLine( );

        Random random = new Random();
        int targetNumber =random.Next(1,101);
        int guess = 0;
        int attempts = 0;

        while (guess!=targetNumber ) 
        {
            Console.WriteLine("Guess a number between 1 and 100");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if( guess < targetNumber) 
            {
                Console.WriteLine( "To low, guess again");
            }
            else if (guess > targetNumber){

                Console.WriteLine( "To high, guess again");
            }
        }

        Console.WriteLine($" Congatulations! You guessed {targetNumber} in {attempts} attempts");
    }
}