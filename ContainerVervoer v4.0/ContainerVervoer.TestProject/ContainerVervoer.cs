using ContainerVervoer.Logic;
using NUnit.Framework;
using System;

namespace ContainerVervoer.TestProject
{
    public class ContainerVervoer
    {
        Random rnd = new Random();

        [Test]
        public void Test1()
        {
            // Arrange
            int shipLength = 3;
            int shipWidth = 4;
            CargoShip cargoship = new CargoShip(shipLength, shipWidth);
            AddNormalContainers(cargoship, 60);

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