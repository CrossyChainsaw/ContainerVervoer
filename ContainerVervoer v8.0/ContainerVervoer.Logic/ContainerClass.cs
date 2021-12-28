using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Logic
{
    // gebruik nu nog enum, als alles klaar is pas inheritance
    public enum ContainerTypes
    {
        Normal,
        Cool
    }

    public class ContainerClass
    {
        public const int MaxWeight = 30000;
        public const int MinWeight = 4000;
        public int Weight { get { return _weight; } }
        public ContainerTypes ContainerType { get { return _containerType; } }
        private readonly int _weight;
        private readonly ContainerTypes _containerType;

        public ContainerClass(ContainerTypes containerType, int weight)
        {
            _weight = weight;
            _containerType = containerType;
        }

        public void CheckWeightAboveMe()
        {

        }
    }
}
