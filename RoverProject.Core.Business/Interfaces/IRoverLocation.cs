using RoverProject.Core.Business.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverProject.Core.Business.Interfaces
{
    public interface IRoverLocation
    {
        public int xCoordinat { get; set; }
        public int yCoordinat { get; set; }
        public Direction RoverDirection { get; set; }        
    }
}
