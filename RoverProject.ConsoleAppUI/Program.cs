using RoverProject.Core.Business.Classes;
using RoverProject.Core.Business.Common;
using RoverProject.Core.Business.Common.Exceptions;
using System;


namespace RoverProject.ConsoleAppUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string gridAreas = "";
            Console.WriteLine("Welcome To The Mars Rover Project!");
            Plateau plateau = new Plateau();
            do
            {
                Console.WriteLine("Please enter plateau grid X and Y length: ");
                gridAreas = Console.ReadLine();
            } while (!plateau.FirstRunControls(gridAreas));
            ConsoleKeyInfo AddNewRoverKey;
            do
            {
                Console.WriteLine("Please enter rover location (X Y Direction(W N E S)): ");
                string roverLocation = Console.ReadLine();

                if (!Common.LocationIsValid(roverLocation))
                    throw new WrongLocationException(roverLocation);

                Console.WriteLine("Please enter commands for Rover (LRM): ");
                string roverCommands = Console.ReadLine();

                Rover rover = new Rover();
                rover.Name = $"Rover {plateau.PlateauRovers.Count + 1}";
                rover.FirstRunSettings(roverLocation, roverCommands);

                plateau.PlateauRovers.Add(rover);
                Console.WriteLine("\n\n\nPress enter for add new Rover, for exit press another key..");
                AddNewRoverKey = Console.ReadKey();



            } while (AddNewRoverKey.Key == ConsoleKey.Enter);

            if (plateau.PlateauRovers.Count>0)
            {
                Console.WriteLine("Rover Reports");
                plateau.RunAllRovers();


                foreach (var item in plateau.PlateauRovers)
                {
                    Console.WriteLine($"{item.Name}\t\t{item.Location.xCoordinat}\t{item.Location.yCoordinat}\t{item.Location.RoverDirection.ToString()}");
                }

            }

            Console.WriteLine("Good Bye");
            System.Threading.Thread.Sleep(3000);            
        }
    }
}
