using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip
{
    class ChilledContainer : Container
    {
        
        
        public bool CheckPowered(int[] chilledRows, int[] position) //nog een constructor met inheritance position meegeven niet meer nodig? position zit al in deze klas tenslotte
        {
            foreach (int chilledRow in chilledRows)
            {
                if (position[0] == chilledRow)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
