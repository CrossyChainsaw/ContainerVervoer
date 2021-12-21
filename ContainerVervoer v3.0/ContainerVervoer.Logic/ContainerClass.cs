using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Logic
{
    public class ContainerClass
    {
        public int Weight { get { return _weight; } }
        private readonly int _weight;

        public ContainerClass(int weight)
        {
            _weight = weight;
        }

        public const int MaxWeight = 30000;
        public const int MinWeight = 4000;
    }
}
