using System;

class Program
{
    static void Main(string[] args)
    {

//user input number.
        Console.Write("What is the magic number? "); 
        int magicNumber = int.Parse (Console.ReadLine());
//user guess the number.
        Console.Write("What is your guess? ");
        int guessNumber = int.Parse (Console.ReadLine());
//random number generator.
        Random randomGenerator = new Random();
        int Number = randomGenerator.Next(1, 11);

        int guess = -1;
        
        while(guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

        }




    }
}