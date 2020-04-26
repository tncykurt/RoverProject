using RoverProject.Core.Business.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RoverProject.Core.Business.Interfaces
{
    public interface IRoverCommand
    {
        IRoverLocation DoIt(CommandType commandType, IRoverLocation roverLocation);
        IRoverLocation TurnLeft(IRoverLocation roverLocation);
        IRoverLocation TurnRight(IRoverLocation roverLocation);
        IRoverLocation Go(IRoverLocation roverLocation);
    }
}
