using System;
using System.Collections.Generic;
using System.Text;

namespace RoverProject.Core.Business.Common.Exceptions
{
    public class WrongCommandException:InvalidOperationException
    {
        public WrongCommandException(string WrongCommands):base($"Commands have to be one of L, R or M letters. Wrong Commands: '{string.Join('-',WrongCommands.ToCharArray())}'.")
        {            
        }
    }
}
