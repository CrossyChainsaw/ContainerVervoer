using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Logic
{
    public class CargoShip
    {
        public ContainerCollection ContainerCollection { get { return _containerCollection; } }

        private readonly int _length;
        private readonly int _width;
        private readonly List<Layer> _layerList;
        private ContainerCollection _containerCollection;

        public CargoShip(int length, int width)
        {
            _length = length;
            _width = width;
            _layerList = new List<Layer>();
            _containerCollection = new ContainerCollection();
        }

        public void Distribute()
        {
            CreateLayer();
            if (_width % 2 == 0)
            {
                // even
            }
            else
            {
                // odd
            }

            FillNextEmptySpotInLayer0();
        }

        public void CreateLayer()
        {
            int amountOfContainersLeft = _containerCollection.AllContainers.Count;
            if (amountOfContainersLeft > 0)
            {
                _layerList.Add(new Layer(_length, _width));
            }
        }

        public void FillNextEmptySpotInLayer0() // (in layer 0)
        {
            var myStack = new Stack<ContainerClass>(ContainerCollection.AllContainers);
            while (myStack.Count > 0 && ThereIsEmptySpotInLayer0())
            {
                PlaceContainerInLayer0(myStack.Pop()); // get last, remove last
            }
        }

        public void PlaceContainerInLayer0(ContainerClass container)
        {
            _layerList[0].AddContainerToNextFreeSpot(container);
        }

        public bool ThereIsEmptySpotInLayer0()
        {
            return _layerList[0].ThereIsEmptySpot();
        }
    }
}
