using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Logic.DifferentTypesOfContainers
{
    public class CoolContainer : Container
    {
        public CoolContainer(int weight)
        {
            SetWeight(weight);
            SetName(ContainerTypes.Cool.ToString());
            SetContnainerAboveMeAllowed(true);
            SetMustBeFirstRow(true);
        }
    }
}
