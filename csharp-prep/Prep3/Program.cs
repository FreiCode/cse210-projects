using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Ask user for a magic number
        //Console.Write("What is the magic number? ");
        //store number in a variable
        //string input = Console.ReadLine();
        //convert string to int
        //int number = int.Parse(input);

        //have computer generate the random number.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        //create the guess variable
        int guess = -1;

        //Create a loop to allow user to guess until they guess the magic number.
        while (guess != magicNumber)
        {
            //Ask the user to guess what the magic number is.
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}