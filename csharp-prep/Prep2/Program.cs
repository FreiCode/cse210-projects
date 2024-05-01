using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        //Ask the user for their grade percentage.
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        //Convert string to int
        int grade = int.Parse(gradePercentage);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter ="B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        //print a pass/fail message 
        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

        //Print percentage to terminal
        //Console.WriteLine($"{gradePercentage}");
    }
}