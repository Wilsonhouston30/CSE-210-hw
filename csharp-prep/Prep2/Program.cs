using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage: ");
        string gradePercentage = Console.ReadLine();

        int numb = int.Parse(gradePercentage);

        string letter = "";

        if (numb >= 90)
        {
            letter = "A";
        }
        else if (numb >= 80)
        {
            letter = "B";
        }
        else if (numb >= 70)
        {
            letter = "C";
        }
        else if (numb >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade was a {letter}");

        if (numb <= 70)
        {
            Console.WriteLine("You failed the class");
        }
        else
        {
            Console.WriteLine("You Passed the class");
        }
    }
}