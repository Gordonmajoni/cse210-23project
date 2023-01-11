using System;

class Program
{
    static void Main(string[] args)
    {


        Console.Write("What is the magic number? "); 
        int magicNumber = int.Parse (Console.ReadLine());

        Console.Write("What is your guess? ");
        int guessNumber = int.Parse (Console.ReadLine());

        Random randomGenerator = new Random();
        int Number = randomGenerator.Next(1, 11);




    }
}