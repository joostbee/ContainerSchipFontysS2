using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip
{
    class Container : IContainer
    {
        private int Weight { get; } // in tonnes
        private int Load { get; } // in tonnes
        private int MaxLoad { get; } // in tonnes
        private int MaxWeightOnTop { get; } // in tonnes
        private int[,,] Position { get; }

        public bool CheckWeightOnTopSafe()
        {

        }

        public void PlaceContainer(int[,,] position)
        {
            Position = position;
        }
    }
}
