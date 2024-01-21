using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        // Creates a list and gets each number from the user before putting it through sum, avg, etc

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = -1;
        while (userNumber != 0)
        { 
            //gets user number and adds it to the list
            Console.Write("Enter number: ");
            string addedNumber = Console.ReadLine();
            userNumber = int.Parse(addedNumber);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }


        //Gets the sum of the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of your numbers is: {sum}");



        //gets the average of your list
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");



        //gets the highest integer from your list.
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}