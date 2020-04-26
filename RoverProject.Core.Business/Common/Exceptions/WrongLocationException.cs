using System;
using System.Collections.Generic;
using System.Text;

namespace RoverProject.Core.Business.Common.Exceptions
{
    public class WrongLocationException:Exception
    {
        public WrongLocationException(string strLocation) : base($"Location format must be like X Y Direction(E,S,W,N)..")
        {

        }
    }
}
