using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip
{
    class ValueableContainer : Container
    {
        public ValueableContainer(int weight, int load, int[] position) //moet alles in baseclass op set om constructor te kunnen gebruiken?
        {
            base.Weight = weight;
            Load = load;
            MaxLoad = 100; //nog opzoeken
            MaxWeightOnTop = 100; // nog opzoeken
            Position = position;
        }

        public bool Approachable(Container containerInFront, Container containerBehind) //container that is not placed at that position gets  position [-1,-1,-1]
        {
            if(containerInFront.Position[0] == -1 || containerBehind.Position[0] == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool CheckWeightOnTopSafe(List<Container> containersOnTop)
        {
            int weightOnTop = 0;

            foreach (Container containerOnTop in containersOnTop)
            {
                weightOnTop += containerOnTop.Weight;
                weightOnTop += containerOnTop.Load;
            }

            if (weightOnTop == 0) //dit kan toch ook met constructor zodat maxweightontop op 0 word gezet bij het maken van een value container?
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
