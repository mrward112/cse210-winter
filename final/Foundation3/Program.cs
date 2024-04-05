using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("1081 South Center St.", "Moscow", "Idaho", "1081", "United States");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("NeXt Lecture", "Conference on Neuroinformatics", "April 5, 2024", "5:00 - 7:00", $"{lectureAddress}", "Lecture", "Bian Kemper", 200);

        //display lecture event details
        Console.WriteLine("---------------------------------------------------------------------------");
        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayLectureFullDetails();


        Address address2 = new Address ("Port Royal", "Uppingham", "Rutland", "2A7-200", "England");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Will & Elizabeth", "William Turner and Elizabeth Swan's wedding ceremony and reception", "June 15, 2007, 2022", "4:00 pm - 12:00am", $"{receptionAddress}", "Reception", "greatmovies@example.com");
        //display reception event details
        Console.WriteLine("---------------------------------------------------------------------------");
        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayReceptionsFullDetails();


        Address address3 = new Address ("123 Park Lane", "Columbus", "Colorado", "50122", "United States");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("Neighborhood BBQ", "Residential neighborhood BBQ, all residents welcome", "August 1, 2024", "5:00 pm", $"{outdoorAddress}", "Outdoor", "Sunny");
        //display outdoor event details
        Console.WriteLine("---------------------------------------------------------------------------");
         
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorFullDetails();
        Console.WriteLine("---------------------------------------------------------------------------");
        
    }
}