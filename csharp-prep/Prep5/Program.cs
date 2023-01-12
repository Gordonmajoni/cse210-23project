using System;

class Program
{
    static void Main(string[] args)
    {   
        {DisplayWelcomeMessage();

        string UserName = PromptUserName();
        int UserNumber =  PromptUserNumber();
        
        int SquaredNumber = SquareNumber(UserNumber);

        DisplayResult(UserName, SquaredNumber);


        }
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
             
        }
        static string PromptUserName()
        {
            Console.WriteLine("What is your name?: ");
            string Name = Console.ReadLine();

            return Name;
        }
        static int PromptUserNumber()

        {
            Console.Write("Your Favourite number is: ");        
            int number = int.Parse(Console.ReadLine());

            return number;


        }
        static int SquareNumber(int number)

        {
            int square = number * number;
            return square;
        }
        static void DisplayResult(string Name, int square)
        {
            Console.WriteLine($"{Name}, the square of your number is{square} ");
        }


    }
}