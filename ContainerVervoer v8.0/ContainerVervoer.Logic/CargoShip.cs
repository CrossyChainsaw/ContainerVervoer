using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// to do: check weight above container

namespace ContainerVervoer.Logic
{
    public class CargoShip
    {
        public ReadOnlyCollection<Layer> LayerList { get { return new ReadOnlyCollection<Layer>(_layerList); } }
        public ContainerCollection ContainerCollection { get { return _containerCollection; } }
        public int Length { get { return _length; } }
        public int Width { get { return _width; } }

        private readonly int _length;
        private readonly int _width;
        private readonly List<Layer> _layerList;
        private ContainerCollection _containerCollection;
        private Stack<ContainerClass> _containerStackLeft;
        private Stack<ContainerClass> _containerStackRight;

        public CargoShip(int length, int width)
        {
            _length = length;
            _width = width;
            _layerList = new List<Layer>();
            _containerCollection = new ContainerCollection();
        }

        // main method kan niet kort bro
        public void Distribute()
        {
            if (ThereIsEnoughWeightToMakeTheShipNotTurnTurtle())
            {
                if (_width % 2 == 0) // even
                {
                    _containerCollection.SplitContainersIntoLeftAndRight();
                    GetStacks();

                    int nLayer = 0;
                    while (true) // while er nog containers zijn en while er containers bij zijn gezet, dus als er helemaal niets is vernaderd moet je ook breaken
                    {
                        CreateLayer();
                        DistributeLayerLeft(nLayer);
                        DistributeLayerRight(nLayer);
                        nLayer++;
                        if (BreakIfNoContainerGotAdded())
                        {
                            RemoveLastLayer();
                            break;
                        }
                    }
                }
                else
                {
                    // odd
                }
                TwentyPercentageRuleCheck();
            }
            else
            {
                Exception NotEnoughWeightException = new Exception("There is not enough weight to safely send of the cargo ship");
                throw NotEnoughWeightException;
            }
        }

        // // // // // // // // // // // // // // // // 
        // // // // // //  METHODS // // // // // // //
        // // // // // // // // // // // // // // // //

        void RemoveLastLayer()
        {
            _layerList.RemoveAt(_layerList.Count - 1);
        }

        bool BreakIfNoContainerGotAdded()
        {
            Layer lastAddedLayer = _layerList[_layerList.Count - 1];
            foreach (ContainerClass containerSpot in lastAddedLayer.RowList[0].ContainerArray)
            {
                if (containerSpot != null)
                {
                    return false;
                }
            }
            return true;
        }

        public bool TwentyPercentageRuleCheck()
        {
            decimal totalWeight = GetTotalWeight();
            decimal percentageLeft = GetTotalWeightLeftSide() / totalWeight * 100;
            decimal percentageRight = GetTotalWeightRightSide() / totalWeight * 100;
            decimal percentageDifference = Math.Abs(percentageLeft - percentageRight);
            if (percentageDifference > 20)
            {
                Exception PercentageDifferenceTooHighException = new Exception("Percentage difference is " + percentageDifference + " but it should be 20 or lower");
                throw PercentageDifferenceTooHighException;
            }
            else
            {
                return true;
            }
        }

        void CreateLayer()
        {
            int amountOfContainersLeft = _containerCollection.AllContainers.Count;
            if (amountOfContainersLeft > 0)
            {
                _layerList.Add(new Layer(_length, _width));
            }
        }

        public bool ThereIsEnoughWeightToMakeTheShipNotTurnTurtle()
        {
            int amountOfContainersPossibleOnFirstLayer = _width * _length;
            int maxWeightPossibleOnALayer = amountOfContainersPossibleOnFirstLayer * ContainerClass.MaxWeight;
            int maxWeightPossibleOnShip = maxWeightPossibleOnALayer * 5; // because max weight on top of a container is 120.000kg
            int halfOfMaxWeightPossibleOnShip = maxWeightPossibleOnShip / 2;
            if (_containerCollection.GetTotalWeight(_containerCollection.AllContainers) >= halfOfMaxWeightPossibleOnShip)
            {
                return true;
            }
            return false;
        }

        int GetTotalWeightLeftSide()
        {
            int totalWeightLeftSide = 0;
            foreach (Layer layer in _layerList)
            {
                foreach (Row row in layer.RowList)
                {
                    for (int ii = 0; ii < layer.ColList.Count / 2; ii++)
                    {
                        if (row.ContainerArray[ii] != null)
                        {
                            totalWeightLeftSide += row.ContainerArray[ii].Weight;
                        }
                    }
                }
            }
            return totalWeightLeftSide;
        }

        int GetTotalWeightRightSide()
        {
            int startPoint = _width / 2;
            int totalWeightRightSide = 0;
            foreach (Layer layer in _layerList)
            {
                foreach (Row row in layer.RowList)
                {
                    for (int ii = startPoint; ii < layer.ColList.Count; ii++)
                    {
                        if (row.ContainerArray[ii] != null)
                        {
                            totalWeightRightSide += row.ContainerArray[ii].Weight;
                        }
                    }
                }
            }
            return totalWeightRightSide;
        }

        int GetTotalWeight()
        {
            return GetTotalWeightLeftSide() + GetTotalWeightRightSide();
        }

        void GetStacks()
        {
            _containerStackLeft = new Stack<ContainerClass>(ContainerCollection.AllContainersLeft);
            _containerStackRight = new Stack<ContainerClass>(ContainerCollection.AllContainersRight);
        }

        void GetTotalWeightSpecificSpot(int nRow, int nContainerSpot)
        {
            int totalWeight = 0;
            foreach (Layer layer in _layerList)
            {
                totalWeight += layer.RowList[nRow].ContainerArray[nContainerSpot].Weight;
            }
        } // Do this method before adding container to array

        // // // // // // // //  // // // // // // // //
        // // // // // // LEFT METHODS // // // // // //
        // // // // // // // //  // // // // // // // //

        public void DistributeLayerLeft(int nLayer)
        {
            int startPoint = 0;
            _layerList[nLayer].SetStartPoint(startPoint);
            FillNextEmptySpotInLayerLeft(nLayer);
        }

        public void FillNextEmptySpotInLayerLeft(int nLayer)
        {
            while (_containerStackLeft.Count > 0 && ThereIsEmptySpotInLayerLeft(nLayer))
            {
                PlaceContainerInLayerLeft(nLayer, _containerStackLeft.Pop());
            }
        }

        public bool ThereIsEmptySpotInLayerLeft(int nLayer)
        {
            return _layerList[nLayer].ThereIsEmptySpotLeft();
        }

        public void PlaceContainerInLayerLeft(int nLayer, ContainerClass container)
        {
            _layerList[nLayer].AddContainerToNextFreeColumnLeft(container, _layerList);
        }

        // // // // // // // // //  //  // // // // // //
        // // // // // // RIGHT METHODS // // // // // //
        // // // // // // // // //  //  // // // // // //

        public void DistributeLayerRight(int nLayer)
        {
            int startPoint = _width / 2;
            _layerList[nLayer].SetStartPoint(startPoint);
            FillNextEmptySpotInLayerRight(nLayer, startPoint);
        }

        public void FillNextEmptySpotInLayerRight(int nLayer, int startPoint)
        {
            while (_containerStackRight.Count > 0 && ThereIsEmptySpotInLayerRight(nLayer, startPoint))
            {
                PlaceContainerInLayerRight(nLayer, _containerStackRight.Pop());
            }
        }

        public bool ThereIsEmptySpotInLayerRight(int nLayer, int startPoint)
        {
            return _layerList[nLayer].ThereIsEmptySpotRight(startPoint);
        }

        public void PlaceContainerInLayerRight(int nLayer, ContainerClass container)
        {
            _layerList[nLayer].AddContainerToNextFreeColumnRight(container, _layerList);
        }
    }
}
