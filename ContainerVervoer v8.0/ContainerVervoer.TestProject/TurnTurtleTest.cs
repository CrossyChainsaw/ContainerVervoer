using ContainerVervoer.Logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// FR-06: Om kapseizen te voorkomen moet ten minste 50% van het maximum gewicht van een schip zijn benut.

namespace ContainerVervoer.TestProject
{
    class TurnTurtleTest
    {
        [TestCase(40)]
        [TestCase(162)]
        public void TrueTest(int containerAmount)
        {
            // Arrange
            CargoShip cargoShip = new CargoShip(8, 2);

            // Act
            AddNormalContainers(cargoShip, containerAmount);

            // Assert
            Assert.IsTrue(cargoShip.ThereIsEnoughWeightToMakeTheShipNotTurnTurtle());
        }

        [TestCase(39)]
        [TestCase(5)]
        public void FalseTest(int containerAmount)
        {
            // Arrange
            CargoShip cargoShip = new CargoShip(8, 2);

            // Act
            AddNormalContainers(cargoShip, containerAmount);

            // Assert
            Assert.IsFalse(cargoShip.ThereIsEnoughWeightToMakeTheShipNotTurnTurtle());
        }

        void AddNormalContainers(CargoShip cargoship, int n)
        {
            for (int i = 0; i < n; i++)
            {
                cargoship.ContainerCollection.CreateContainer(ContainerTypes.Normal, ContainerClass.MaxWeight);
            }
        }
    }
}
