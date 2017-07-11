using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            // Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            
            // Create another List that contains that last two planet of our solar system.
            List<string> planetList2 = new List<string>(){"Neptune", "Uranus"};
            
            // Combine the two lists by using AddRange().
            planetList.AddRange(planetList2);
            
            // Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            
            // Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");

            Console.WriteLine();
            foreach(string planet in planetList){
                Console.WriteLine(planet);
            }

            Console.WriteLine();
            // Now that all the planets are in the list, slice the list using GetRange() 
            // in order to extract the rocky planets into a new list called rockyPlanets.
            List<string> rockyPlanets = planetList.GetRange(0, 4);

            foreach(string rock in rockyPlanets){
                Console.WriteLine(rock);
            }

            // Being good amateur astronomers, we know that Pluto is now a dwarf planet, so 
            // use the Remove() method to eliminate it from the end of planetList.
            planetList.RemoveAt(8);

            Console.WriteLine();
            foreach(string newPlanets in planetList){
                Console.WriteLine(newPlanets);
            }

        }
    }
}
