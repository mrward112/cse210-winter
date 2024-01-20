using System;

class Program
{
    static void Main(string[] args)
    {

        //gets a random magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(0, 101);



        //manually sets a magic number to play the guessing game with
        // Console.Write("What is the magic number? ");
        // string userMagicNumber = Console.ReadLine();
        // int magicNumber = int.Parse(userMagicNumber);


        //gets users guess for the magic number

        int userGuess = 0;
        do
        {
            Console.Write("What is your guess? ");
            string userMagicNumberGuess = Console.ReadLine();
            userGuess = int.Parse(userMagicNumberGuess);
            if (userGuess > magicNumber)
            {
                Console.WriteLine("lower");
            }

            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }


        } while (magicNumber != userGuess);


    }
}