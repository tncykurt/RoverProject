using RoverProject.Core.Business.Common.Enums;
using RoverProject.Core.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverProject.Core.Business.Classes
{
    public class RoverLocation : IRoverLocation
    {
        public int xCoordinat { get;set; }
        public int yCoordinat { get; set; }
        public Direction RoverDirection { get; set; }
    }
}
