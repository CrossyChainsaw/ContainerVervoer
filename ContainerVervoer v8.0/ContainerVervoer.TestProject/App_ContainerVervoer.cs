using ContainerVervoer.Logic;
using NUnit.Framework;
using System;

namespace ContainerVervoer.TestProject
{
    public class App_ContainerVervoer
    {
        Random rnd = new Random();

        [TestCase(1, 2, 30)]
        [TestCase(1, 2, 10)]
        [TestCase(3, 2, 30)]
        public void Test1(int length, int width, int containerAmount)
        {
            // Arrange
            int shipLength = length;
            int shipWidth = width;
            CargoShip cargoship = new CargoShip(shipLength, shipWidth);
            AddNormalContainers(cargoship, containerAmount);

            // Act
            cargoship.Distribute();

            // Assert
            Assert.Pass();
        }

        void AddNormalContainers(CargoShip cargoship, int n)
        {
            for (int i = 0; i < n; i++)
            {
                cargoship.ContainerCollection.CreateContainer(ContainerTypes.Normal, rnd.Next(ContainerClass.MinWeight, ContainerClass.MaxWeight + 1));
            }
        }

        void AddCoolContainers(CargoShip cargoship, int n)
        {
            for (int i = 0; i < n; i++)
            {
                cargoship.ContainerCollection.CreateContainer(ContainerTypes.Cool, ContainerClass.MaxWeight);
            }
        }
    }
}

// TO DO
// add multiple layers