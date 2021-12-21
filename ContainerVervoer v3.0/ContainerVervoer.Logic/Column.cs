using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Logic
{
    public class Column
    {
        private readonly ContainerClass[] _containerArray;

        public Column(int width)
        {
            _containerArray = new ContainerClass[width];
        }
    }
}

// Eigenlijk slaat het nergens op dat col en row aparte classes zijn, identieke behaviour