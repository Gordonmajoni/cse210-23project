using System;

class Program
{
    static void Main(string[] args)
    {
    
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letter = "";
        if(percent >= 90 )
        {
            letter = "A";      
        }
        else if ( percent >= 80  )
        {
            letter ="B";
        }
        else if(percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else (percent < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is{letter}");
        if(percent >= 70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("Try again!");
        }
    }
}