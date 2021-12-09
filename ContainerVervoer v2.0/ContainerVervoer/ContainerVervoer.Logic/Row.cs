using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Logic
{
    public class Row
    {
        List<Container> containerList = new List<Container>();
        public List<Container> ContainerList { get { return containerList; } }
    }
}
