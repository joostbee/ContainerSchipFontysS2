using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip
{
    class Container
    {
        public int Weight { get; } // in tonnes
        public int Load { get; } // in tonnes
        private int MaxLoad { get; } // in tonnes
        private int MaxWeightOnTop { get; } // in tonnes
        public int[] Position { get; } = new int[3]; // position in xyz format

        public Container(int weight, int load, int[] position) // alleen in derived classes een constructor
        {
            Weight = weight;
            Load = load;
            MaxLoad = 100; //nog opzoeken
            MaxWeightOnTop = 100; // nog opzoeken
            Position = position;
        }

        public virtual bool CheckWeightOnTopSafe(List<Container> containersOnTop)
        {
            int weightOnTop = 0;

            foreach(Container containerOnTop in containersOnTop)
            {
                weightOnTop += containerOnTop.Weight;
                weightOnTop += containerOnTop.Load;
            }

            if(weightOnTop < MaxWeightOnTop)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PlaceContainer(int[] position)
        {
            Position = position;
        }
    }
}
