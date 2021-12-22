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
            if (ThereIsEnoughWeightToMakeTheShipNotTurnTurtle())
            {
                CreateLayer();
                if (_width % 2 == 0)
                {
                    _containerCollection.SplitContainersIntoLeftAndRight();
                    DistributeLeft();
                    DistributeRight();
                }
                CreateLayer();
                if (_width % 2 == 0)
                {
                    _containerCollection.SplitContainersIntoLeftAndRight();
                    DistributeLeft();
                    DistributeRight();
                }
                else
                {
                    // odd
                }

                // ending method
                TwentyPercentageRuleCheck();
            }
            else
            {
                Exception NotEnoughWeightException = new Exception("There is not enough weight to safely send of the cargo ship");
                throw NotEnoughWeightException;
            }
        }

        private void TwentyPercentageRuleCheck()
        {
            decimal totalWeight = GetTotalWeight();
            decimal totalWeightLeft = GetTotalWeightLeftSide();
            decimal totalWeightRight = GetTotalWeightRightSide();
            decimal percentageLeft = totalWeightLeft / totalWeight * 100;
            decimal percentageRight = totalWeightRight / totalWeight * 100;
            decimal percentageDifference = Math.Abs(percentageLeft - percentageRight);
            if (percentageDifference > 20)
            {
                Exception PercentageDifferenceTooHighException = new Exception("Percentage difference is " + percentageDifference + " but it should be 20 or lower");
                throw PercentageDifferenceTooHighException;
            }
        }

        public void CreateLayer()
        {
            int amountOfContainersLeft = _containerCollection.AllContainers.Count;
            if (amountOfContainersLeft > 0)
            {
                _layerList.Add(new Layer(_length, _width));
            }
        }

        // // // // // // // //  // // // // // // // //
        // // // // // // LEFT METHODS // // // // // //
        // // // // // // // //  // // // // // // // //

        public void DistributeLeft()
        {
            int startPoint = 0;
            _layerList[0].SetStartPoint(startPoint);
            FillNextEmptySpotInLayer0Left();
        }

        public void FillNextEmptySpotInLayer0Left() // (in layer 0)
        {
            var myStack = new Stack<ContainerClass>(ContainerCollection.AllContainersLeft);
            while (myStack.Count > 0 && ThereIsEmptySpotInLayer0Left())
            {
                PlaceContainerInLayer0Left(myStack.Pop());
            }
        }

        public void PlaceContainerInLayer0Left(ContainerClass container)
        {
            _layerList[0].AddContainerToNextFreeColumnLeft(container);
        }

        // // // // // // // // //  //  // // // // // //
        // // // // // // RIGHT METHODS // // // // // //
        // // // // // // // // //  //  // // // // // //

        public void DistributeRight()
        {
            int startPoint = _width / 2;
            _layerList[0].SetStartPoint(startPoint);
            FillNextEmptySpotInLayer0Right(startPoint);
        }

        public void FillNextEmptySpotInLayer0Right(int startPoint) // (in layer 0)
        {
            var myStack = new Stack<ContainerClass>(ContainerCollection.AllContainersRight);
            while (myStack.Count > 0 && ThereIsEmptySpotInLayer0Right(startPoint))
            {
                PlaceContainerInLayer0Right(myStack.Pop());
            }
        }

        public void PlaceContainerInLayer0Right(ContainerClass container)
        {
            _layerList[0].AddContainerToNextFreeColumnRight(container);
        }

        // // // // // //  // // // //  // // // // // // 
        // // // // // // OTHER METHODS // // // // // //
        // // // // // //  // // // //  // // // // // //

        public void FillNextEmptySpotInLayer0() // (in layer 0)
        {
            var myStack = new Stack<ContainerClass>(ContainerCollection.AllContainers);
            while (myStack.Count > 0 && ThereIsEmptySpotInLayer0Left())
            {
                PlaceContainerInLayer0(myStack.Pop());
            }
        }

        public void PlaceContainerInLayer0(ContainerClass container)
        {
            _layerList[0].AddContainerToNextFreeColumnInRow(container);
        }

        public bool ThereIsEmptySpotInLayer0Left()
        {
            return _layerList[0].ThereIsEmptySpotLeft();
        }

        public bool ThereIsEmptySpotInLayer0Right(int startPoint)
        {
            return _layerList[0].ThereIsEmptySpotRight(startPoint);
        }

        bool ThereIsEnoughWeightToMakeTheShipNotTurnTurtle()
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
                        totalWeightLeftSide += row.ContainerArray[ii].Weight;
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
                        totalWeightRightSide += row.ContainerArray[ii].Weight;
                    }
                }
            }
            return totalWeightRightSide;
        }

        int GetTotalWeight()
        {
            return GetTotalWeightLeftSide() + GetTotalWeightRightSide();
        }
    }
}
