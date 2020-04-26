using RoverProject.Core.Business.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoverProject.Core.Business.Interfaces
{
    public interface IRover
    {
        string Name { get; set; }
        IPlateau Plateau { get; set; }
        IRoverLocation Location { get; set; }
        IList<CommandType> RoverCommands { get; set; }
        IRoverCommand command { get; set; }
        void FirstRunSettings(string strLocation, string strCommands);

    }
}
