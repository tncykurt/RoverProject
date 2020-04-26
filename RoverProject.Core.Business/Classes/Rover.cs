using RoverProject.Core.Business.Common.Enums;
using RoverProject.Core.Business.Common.Exceptions;
using RoverProject.Core.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverProject.Core.Business.Classes
{
    public class Rover : IRover
    {
        public Rover()
        {
            this.RoverCommands = new List<CommandType>();
            this.command = new RoverCommand();
        }
        public string Name { get; set; }
        public IPlateau Plateau { get; set; }
        public IRoverLocation Location { get; set; }
        public IList<CommandType> RoverCommands { get; set; }
        public IRoverCommand command { get; set; }

        public void FirstRunSettings(string strLocation, string strCommands)
        {
            string[] arrLocation = strLocation.Split(' ');
            this.Location = new RoverLocation()
            {
                xCoordinat = Convert.ToInt32(arrLocation[0]),
                yCoordinat = Convert.ToInt32(arrLocation[1]),
            };
            switch (arrLocation[2].ToUpper())
            {
                case "W":
                    this.Location.RoverDirection = Direction.W;
                    break;
                case "S":
                    this.Location.RoverDirection = Direction.S;
                    break;
                case "N":
                    this.Location.RoverDirection = Direction.N;
                    break;
                case "E":
                    this.Location.RoverDirection = Direction.E;
                    break;
                default:
                    throw new WrongCommandException(arrLocation[2]);

            }


            foreach (char item in strCommands.ToUpper().ToCharArray())
            {
                switch (item)
                {
                    case 'L':
                        this.RoverCommands.Add(CommandType.L);
                        break;
                    case 'R':
                        this.RoverCommands.Add(CommandType.R);
                        break;
                    case 'M':
                        this.RoverCommands.Add(CommandType.M);
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
