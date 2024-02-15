using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");


        var job1 = new Job();
        job1._company = "Amazon";
        job1._jobTitle = "Shipping manager";
        job1._startYear = 2018;
        job1._endYear = 2024;

        var job2 = new Job();
        job2._company = "Walmart";
        job2._jobTitle = "Isle Manager";
        job2._startYear = 2015;
        job2._endYear = 2019;


        // Calls to the DisplayJobDeets function in job.cs
        // job2.DisplayJobDeets();

        //instance of the resume class
        Resume myResume = new Resume();
    // ^^^^^^^ ^^^^^^^^^   ^^^ ^^^^^^^^^
    // class    instance   syn class();

        myResume._name = "Merrick Ward";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.MyResume();
    }
}