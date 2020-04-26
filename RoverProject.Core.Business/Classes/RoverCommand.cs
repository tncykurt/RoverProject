using RoverProject.Core.Business.Common.Enums;
using RoverProject.Core.Business.Common.Exceptions;
using RoverProject.Core.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverProject.Core.Business.Classes
{
    public class RoverCommand : IRoverCommand
    {
        public IRoverLocation Go(IRoverLocation _roverLocation)
        {
            IRoverLocation newLocation = _roverLocation;
            switch (_roverLocation.RoverDirection)
            {
                case Direction.W:
                    newLocation.xCoordinat = _roverLocation.xCoordinat - 1;
                    break;
                case Direction.N:
                    newLocation.yCoordinat = _roverLocation.yCoordinat + 1;
                    break;
                case Direction.E:
                    newLocation.xCoordinat = _roverLocation.xCoordinat + 1;
                    break;
                case Direction.S:
                    newLocation.yCoordinat = _roverLocation.yCoordinat - 1;
                    break;
                default:
                    break;
            }
            return newLocation;
        }

        public IRoverLocation TurnLeft(IRoverLocation _roverLocation)
        {
            IRoverLocation newLocation = _roverLocation;
            switch (_roverLocation.RoverDirection)
            {
                case Direction.W:
                    newLocation.RoverDirection = Direction.S;
                    break;
                case Direction.N:
                    newLocation.RoverDirection = Direction.W;
                    break;
                case Direction.E:
                    newLocation.RoverDirection = Direction.N;
                    break;
                case Direction.S:
                    newLocation.RoverDirection = Direction.E;
                    break;
                default:
                    break;
            }
            return newLocation;
        }

        public IRoverLocation TurnRight(IRoverLocation _roverLocation)
        {
            IRoverLocation newLocation = _roverLocation;
            switch (_roverLocation.RoverDirection)
            {
                case Direction.W:
                    newLocation.RoverDirection = Direction.N;
                    break;
                case Direction.N:
                    newLocation.RoverDirection = Direction.E;
                    break;
                case Direction.E:
                    newLocation.RoverDirection = Direction.S;
                    break;
                case Direction.S:
                    newLocation.RoverDirection = Direction.W;
                    break;
                default:
                    break;
            }
            return newLocation;
        }

        public IRoverLocation DoIt(CommandType commandType, IRoverLocation roverLocation)
        {
            switch (commandType)
            {
                case CommandType.L:
                    return TurnLeft(roverLocation);

                case CommandType.R:
                    return TurnRight(roverLocation);

                case CommandType.M:
                    return Go(roverLocation);

                default:
                    throw new WrongCommandException(commandType.ToString());

            }
        }

    }
}
