using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Logic.DifferentTypesOfContainers
{
    public class NormalContainer : Container
    {
        public NormalContainer(int weight)
        {
            SetWeight(weight);
            SetName(ContainerTypes.Normal.ToString());
            SetContnainerAboveMeAllowed(true);
            SetMustBeFirstRow(false);
        }
    }
}
