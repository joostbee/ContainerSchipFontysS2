using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip
{
    class ContainerCollection
    {
        private List<Container> ContainerList { get; } = new List<Container>();

        public void AddContainer(Container container)
        {
            ContainerList.Add(container);
        }

    }
}
