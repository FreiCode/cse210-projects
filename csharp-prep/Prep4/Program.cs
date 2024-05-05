using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        //Console.WriteLine("Hello Prep4 World!");
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userRespones = Console.ReadLine();
            userNumber = int.Parse(userRespones);

            //add number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        //compute the sum of the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }  
        Console.WriteLine($"The sum is: {sum}");

        //compute the average of the list
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Find the max number in the list

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }  
        Console.Write($"The max is: {max}");
        
    }
}