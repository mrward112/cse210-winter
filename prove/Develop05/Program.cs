using System;

// class Program
// {
//     private List<Goal> _goals = new List<Goal>();
//     private int _score;
//     private int _count = 0;
//     private string _save = "saves/";




//     static void Main(string[] args)
//     {
//         Console.WriteLine("Welcome to the Eternal Goal advancment app!");
//     }


//         int option = 0;
//         bool programRuns = true;

//         do
//         {
//             Console.WriteLine("Please select one of the following options:\n" +
//                               "1. Create a New Goal\n" +
//                               "2. List all Goals\n" +
//                               "3. Save Goals\n" +
//                               "4. Load Goals\n" +
//                               "5. Record Event\n" +
//                               "6. Quit\n");

//             option = Convert.ToInt32(Console.ReadLine());

//             switch (option)
//             {
//                 case 1: CreateGoal(); 
                
//                 break;
//                 case 2: ListGoal(); 
                
//                 break;
//                 case 3: SaveGoal(); 
                
//                 break;
//                 case 4:  LoadGoal();
                
//                 return;

//                 case 5: RecordEvent();
                
//                 break;

//                 case 6: 
//                     programRuns = false;
//                 break;

//                 default: Console.WriteLine("Invalid Option"); break;
//             }
//         } while (bool programRuns == true);

//     private void DisplayPlayerPoints()
//     {
//         Console.WriteLine($"Your total points is: {_score}");
//     }
// }


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Goal Setting Quest App");
        GoalManager goalManager = new();
        goalManager.Start();
    }
}