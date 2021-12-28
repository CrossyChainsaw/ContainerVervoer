using ContainerVervoer.Logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// FR-01: Het maximum gewicht bovenop een container is 120 ton.

namespace ContainerVervoer.TestProject
{
    class MaxWeightOnContainerTest
    {
        Random rnd = new Random();

        [TestCase]
        public void Test()
        {
            // Arrange
            CargoShip cargoShip = new CargoShip(1, 2);

            // Act
            AddNormalContainers(cargoShip, 100);
            cargoShip.Distribute();
            int weightFirstBottomSpot = cargoShip.LayerList[0].GetTotalWeightSpecificSpot(cargoShip.LayerList, 0, 0);

            // Assert
            Assert.IsTrue(weightFirstBottomSpot <= 150000);
        }

        void AddNormalContainers(CargoShip cargoship, int n)
        {
            for (int i = 0; i < n; i++)
            {
                cargoship.ContainerCollection.CreateContainer(ContainerTypes.Normal, rnd.Next(ContainerClass.MinWeight, ContainerClass.MaxWeight + 1));
            }
        }
    }
}
