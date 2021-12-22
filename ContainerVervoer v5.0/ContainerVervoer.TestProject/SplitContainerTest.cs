using ContainerVervoer.Logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.TestProject
{
    class SplitContainerTest
    {
        Random rnd = new Random();

        [Test]
        public void SplitContainerLeftRight()
        {
            // Arrange
            CargoShip cargoShip = new CargoShip(6, 2);
            AddNormalContainers(cargoShip, 67);
            AddCoolContainers(cargoShip, 14);

            // Act
            cargoShip.Distribute();

            // Assertje
        }

        [Test]
        public void SplitContainerMidRightLeft()
        {

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
                cargoship.ContainerCollection.CreateContainer(ContainerTypes.Cool, rnd.Next(ContainerClass.MinWeight, ContainerClass.MaxWeight + 1));
            }
        }
    }
}
