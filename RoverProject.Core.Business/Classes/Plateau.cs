using RoverProject.Core.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverProject.Core.Business.Classes
{
    public class Plateau : IPlateau
    {
        public Plateau()
        {
            this.PlateauRovers = new List<IRover>();
        }
        public IList<IRover> PlateauRovers { get; set; }
        public int LimitX { get; set; }
        public int LimitY { get; set; }

        public bool FirstRunControls(string gridSizes)
        {
            if (Common.Common.CoordinatesIsValid(gridSizes))
            {
                string[] arrGridSize = gridSizes.Split(' ');
                this.LimitX = Convert.ToInt32(arrGridSize[0]);
                this.LimitY = Convert.ToInt32(arrGridSize[1]);
                return true;
            }
            return false;
        }

        public void RunAllRovers()
        {
            foreach (Rover rover in PlateauRovers)
                foreach (var cmd in rover.RoverCommands)
                    rover.Location = rover.command.DoIt(cmd, rover.Location);

        }
    }
}
