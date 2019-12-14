using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip
{
    class Ship
    {
        private int Width { get; } //in containers
        private int Length { get; } // in containers
        private int Height { get; } // in containers
        private int MaximumWeight { get; } // in tonnes
        private int MinimumWeight { get; } // in tonnes
        private int[] ChilledRows { get; } // each row is x in the xyz notation for position
        private Container[,,] Containers { get; } // container array for position, xyz notation

        private ContainerCollection ContainerCollection = new ContainerCollection();

        public Ship(int width, int length, int maxiumumWeight, int ratioMinimumWeight, int[] chilledRows)
        {
            Width = 10;//width;
            Length =  100//length;
            Height = 100; //100 for z is an arbitrary maximum that should never be reached
            MaximumWeight = maxiumumWeight;
            MinimumWeight = maxiumumWeight * ratioMinimumWeight;
            ChilledRows = chilledRows;
            Container[,,] Containers = new Container[Length, Width, Height];
        }
    }
}
