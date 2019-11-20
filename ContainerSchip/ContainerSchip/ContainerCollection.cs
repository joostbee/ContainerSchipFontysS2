using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip
{
    class ContainerCollection
    {
        private List<IContainer> ContainerList { get; } = new List<IContainer>();

        public void AddContainer(IContainer container)
        {
            ContainerList.Add(container);
        }

    }
}
