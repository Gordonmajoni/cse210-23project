using System;

class Program
{
    static void Main(string[] args)
    {
        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;
        
    
        
        Console.Write("What is your grade?");
        string grade = Console.ReadLine();
        if(A  >=  B )
        {
            Console.WriteLine($"Congratulation your passed with{grade} percent");
        }
        else if(C >= D  )
        {
            Console.WriteLine($"You passed this time with{grade} percent grade");
        }
        else 
        {
            Console.WriteLine("Try again");
        }
    }
}