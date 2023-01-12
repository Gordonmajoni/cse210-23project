using System;

class Program
{
    static void Main(string[] args)
    {   static void DisplayWelcome()
        {
            Console.WriteLine($"Welcome to the programe!{DisplayWelcome}");
        }
        static void PromptUserName()
        {
            Console.Write("Please enter your name? ");
            Console.WriteLine($"Your name is:{PromptUserName}");
        }
}
}