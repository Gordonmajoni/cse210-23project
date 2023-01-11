using System;

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {       
        List<int> numbers = new List<int>();

        int inputNumber= -1;
        while(inputNumber != 0)
    {
        Console.Write("Enter a number(0 to quit)");

        string userResponse = Console.ReadLine();
        inputNumber = int.Parse(userResponse);
//add the number to thwe list if it not 0
        if (inputNumber != 0)
        {
            numbers.Add(inputNumber);
        }
        //sum the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sumis:{sum}");

        //calculate the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //finding the max
        int max = numbers[0];
        foreach(int number in numbers)
        {
            if(number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is:{max}");




    }

      

        

        Console.WriteLine("The numbers in the list: ");

    
        {

        }

    }
}