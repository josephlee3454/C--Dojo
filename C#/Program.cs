using System;
using System.Collections.Generic;
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
        //     int[] arrayOfInts = {1, 2, 3, 4, 5};
        //         Console.WriteLine(arrayOfInts[0]);    // The first number lives at index 0.
        //         Console.WriteLine(arrayOfInts[1]);    // The second number lives at index 1.
        //         Console.WriteLine(arrayOfInts[2]);    // The third number lives at index 2.
        //         Console.WriteLine(arrayOfInts[3]);    // The fourth number lives at index 3.
        //         Console.WriteLine(arrayOfInts[4]);    // The fifth and final number lives at index 4.
                    // int[] arr = {1, 2, 3, 4};
                    //     Console.WriteLine($"The first number of the arr is {arr[0]}"); 
                    //     arr[0] = 8;
                    //     Console.WriteLine($"The first number of the arr is now {arr[0]}");
                // Initializing an empty list of Motorcycle Manufacturers
                    List<string> bikes = new List<string>();
                    //Use the Add function in a similar fashion to push
                    bikes.Add("Kawasaki");
                    bikes.Add("Triumph");
                    bikes.Add("BMW");
                    bikes.Add("Moto Guzzi");
                    bikes.Add("Harley Davidson");
                    bikes.Add("Suzuki");
                    //Accessing a generic list value is the same as you would an array
                    Console.WriteLine(bikes[5]); //Prints "BMW"
                    Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");


                Console.WriteLine("The current manufacturers we have seen are:");
                    for (var idx = 0; idx < bikes.Count; idx++)
                        {
                            Console.WriteLine("-" + bikes[idx]);
                        }
                        // Insert a new item between a specific index
                        bikes.Insert(2, "Yamaha");
                        //Removal from Generic List
                        //Remove is a lot like Javascript array pop, but searches for a specified value
                        //In this case we are removing all manufacturers located in Japan
                        bikes.Remove("Suzuki");
                        bikes.Remove("Yamaha");
                        bikes.RemoveAt(0); //RemoveAt has no return value however
                        //The updated list can then be iterated through using a foreach loop
                        Console.WriteLine("List of Non-Japanese Manufacturers:");
                        foreach (string manu in bikes)
                        {
                            Console.WriteLine("-" + manu);
                        }
                                                
        }
    }
}
