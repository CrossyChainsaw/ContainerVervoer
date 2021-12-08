using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Logic.DifferentTypesOfContainers
{
    public class ValuableContainer : Container
    {
        public ValuableContainer(int weight)
        {
            SetWeight(weight);
            SetName(ContainerTypes.Valuable.ToString());
            SetContnainerAboveMeAllowed(false);
            SetMustBeFirstRow(false);
        }
    }
}
