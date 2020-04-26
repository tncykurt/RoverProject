using System;
using System.Collections.Generic;
using System.Text;

namespace RoverProject.Core.Business.Interfaces
{
    public interface IPlateau
    {
        IList<IRover> PlateauRovers { get; set; }
        int LimitX { get; set; }
        int LimitY { get; set; }

        bool FirstRunControls(string gridSizes);

        void RunAllRovers();

    }
}
