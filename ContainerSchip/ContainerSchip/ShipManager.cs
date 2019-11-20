using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip
{
    public class ShipManager
    {
        private Ship ship;

        public void AddShip(int width, int length, int maxiumumWeight, int ratioMinimumWeight, int[] chilledRows)
        {
            ship = new Ship(width, length, maxiumumWeight, ratioMinimumWeight, chilledRows);
        }
    }
}
