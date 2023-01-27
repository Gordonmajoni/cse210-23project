using System.IO;

class Program
{
    public static List<string> RandomAccess { get; private set; }

    static void Main(string[] args)
    {
        //creating a list of prompts
        List<string> prompts =new List<string>();
        prompts.Add("how do you feel today?");
        prompts.Add("Were have you been today?");
        prompts.Add("What was your coolest moment today?");
        prompts.Add("What will you change if given a chance to relive this moment?");
        prompts.Add("Who did you meet?");
        foreach(string a in prompts)

        RandomAccess = new List<string>(prompts);
        Console.WriteLine(prompts);
    }
}