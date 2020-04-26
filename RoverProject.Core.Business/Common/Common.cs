using RoverProject.Core.Business.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverProject.Core.Business.Common
{
    public class Common
    {
        public static bool LocationIsValid(string strLocation)
        {
            if (string.IsNullOrEmpty(strLocation))
                return false;

            string[] arrLocation = strLocation.TrimEnd().Split(' ');

            if (arrLocation.Length != 3)
                return false;


            if (CoordinatesIsValid(strLocation))
            {
               
                try
                {
                    var rslt = Enum.Parse(typeof(Direction), arrLocation[2]);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            return false;
        }

        public static bool CoordinatesIsValid(string coordinates)
        {
            if (string.IsNullOrEmpty(coordinates))
                return false;
            string[] arrGridSize = coordinates.Split(' ');
            if (arrGridSize.Length >= 2)
            {
                int tmpX, tmpY;
                if (int.TryParse(arrGridSize[0], out tmpX) && int.TryParse(arrGridSize[1], out tmpY))
                {
                    if (tmpX > 0 && tmpY > 0)
                        return true;
                }
            }
            return false;
        }
    }
}
