using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score for the class? ");
        string finalGrade = Console.ReadLine();

        int finalScore = int.Parse(finalGrade);

        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;


        if (finalScore >= a)
        {
            Console.WriteLine("Great job, your final grade is an A.");

        }
        else if (finalScore >= b)
        {
            Console.WriteLine("your grade is an B");

        }
        else if (finalScore >= c)
        {
            Console.WriteLine("your grade is an C");
            
        }
        else if (finalScore >= d)
        {
            Console.WriteLine("your grade is an D");

        }
        else
        {
            Console.WriteLine("your grade is an F");
        }

    }
}