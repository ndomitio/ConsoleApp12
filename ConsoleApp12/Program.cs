using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            //creat an interactive console window
            //prompt user to choose what to do with the fridge
            //call methods on the fridge object to do what the user wants
            int userChoice; 
            do
            {
                Console.WriteLine("Hello, welcome to the fridge app.");
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, press 1");
                Console.WriteLine("To change lightbulb, press 2");
                Console.WriteLine("To clean, type 3");
                Console.WriteLine("To take food, type 4");
                Console.WriteLine("To check food, type 5");
                Console.WriteLine("To see all fridge details, type 6");
                Console.WriteLine("To restart, type 7");
                Console.WriteLine("To quit,type 8");

                userChoice = int.Parse(Console.ReadLine());


            } while (userChoice != 8);




        }
    }
}
