using System;

class Program
{
    static void Main(string[] args)
    {
        Job job =new Job();
        job._jobTitle = "Software Engineer";
        job._company = "Microsoftr";
        job._startYear ="2019";
        job._endYear ="2022";


        job =new Job();
        job._jobTitle = "Manager";
        job._company = "Apple";
        job._startYear ="2022";
        job._endYear ="2023";

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";


        myResume._jobs.Add(job);
        myResume._jobs.Add(job);

        myResume.Display();

    }
}