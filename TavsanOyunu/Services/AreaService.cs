using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavsanOyunu.Services
{
    public static class AreaService
    {
        #region Definitions

        private static int[] AreaX { get; set; }
        private static int[] AreaY { get; set; }
        private static int X { get; set; }
        private static int Y { get; set; }

        #endregion Definitions

        #region ctor

        public static void SetArea(string areaSize)
        {
            try
            {
                if (areaSize.IndexOf('*') > 0)
                {
                    string[] splitString = areaSize.Split('*');

                    int x, y;

                    Int32.TryParse(splitString[0], out x);
                    Int32.TryParse(splitString[1], out y);

                    AreaX = new int[x];
                    AreaY = new int[y];
                }
                else
                {
                    throw new ArgumentException("parameter must contain * (example: 4*4)");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int GetArea


        #endregion ctor
    }
}