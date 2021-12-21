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
        [Test]
        public void SplitContainerLeftRight()
        {
            // Arrange
            CargoShip cargoShip = new CargoShip(6, 2);
            cargoShip.ContainerCollection.CreateContainer(12000);
            cargoShip.ContainerCollection.CreateContainer(16000);
            cargoShip.ContainerCollection.CreateContainer(30000);
            cargoShip.ContainerCollection.CreateContainer(28000);
            cargoShip.ContainerCollection.CreateContainer(6000);
            cargoShip.ContainerCollection.CreateContainer(19000);
            cargoShip.ContainerCollection.CreateContainer(4000);

            // Act
            cargoShip.Distribute();

            // Assertje
        }

        [Test]
        public void SplitContainerMidRightLeft()
        {

        }
    }
}
