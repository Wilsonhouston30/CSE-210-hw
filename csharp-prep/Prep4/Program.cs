using System;

class Program
{
    static void Main(string[] args)
    {
        //using System.Collections.Generic;

        List<int> numbers = new List<int>();

        int Unumber = -1;

        while (Unumber != 0)
        {

            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            Unumber = int.Parse(userInput);

            if (Unumber != 0)
            {
                numbers.Add(Unumber);
            }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
           sum += number;
        }

        int length = numbers.Count;

        float average = ((float)sum) / length;

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (max > number)
            {
                max = number;
            }
        }


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max number is {max}");






        Console.WriteLine("Hello Prep4 World!");
    }
}