using System;

namespace myfirstdotnet
{
    class Program
    {
        static void Main(string[] args)
        {   
            // string place = "Coding Dojo";
            //     Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim");
            // for (int i = 1; i < 6; i = i + 1)
            //     {
            //         Console.WriteLine(i);
            //     }
            // int i = 1;
            // while (i < 6)
            //     {
            //         Console.WriteLine(i);
            //         i = i + 1;
            //     } 
            // int numRings = 3;
            // if (numRings >= 5)
            // {
            //     Console.WriteLine("You are welcome to join the party");
            // }
            // else
            // {
            //     Console.WriteLine("Go win some more rings");
            // }
            Random rand = new Random();
            for(int val = 0; val < 10; val++)
                {
                    //Prints the next random value between 2 and 8
                    Console.WriteLine(rand.Next(2,8));
                }
        }
    }
}
