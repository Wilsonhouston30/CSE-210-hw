using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // For Part 3, where we use a random number
        Random random = new Random();
        int magicNum = random.Next(1, 101);

        int user = -1;

        // We could also use a do-while loop here...
        while (user != magicNum)
        {
            Console.Write("What is your guess? ");
            user = int.Parse(Console.ReadLine());

            if (magicNum > user)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < user)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}