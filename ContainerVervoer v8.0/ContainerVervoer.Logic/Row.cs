using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Logic
{
    public class Row
    {
        public ReadOnlyCollection<ContainerClass> ContainerArray { get { return new ReadOnlyCollection<ContainerClass>(_containerArray); } }
        private readonly ContainerClass[] _containerArray;

        public Row(int width)
        {
            _containerArray = new ContainerClass[width];
        }

        public void PlaceContainer(ContainerClass container, int nCol)
        {
            if (_containerArray[nCol] == null)
            {
                _containerArray[nCol] = container;
            }
            else
            {
                Exception IllegalOverwriteException = new Exception("Can't overwrite value at given spot in list, list spot has to be empty");
                throw IllegalOverwriteException;
            }
        }
    }
}
