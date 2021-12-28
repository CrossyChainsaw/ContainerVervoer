using ContainerVervoer.Logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// FR-08: De afmeting van een schip moet instelbaar zijn in de applicatie,
// waarbij de hoogte en breedte in containers aangegeven kan worden.

namespace ContainerVervoer.TestProject
{
    class SetShipLengthAndWidthTest
    {
        [TestCase(10, 14)]
        [TestCase(30, 8)]
        [TestCase(2, 200)]
        public void SetShipLengthAndWidth(int length, int width)
        {
            // Arrange
            CargoShip cargoShip;

            // Act
            cargoShip = new CargoShip(length, width);

            // Assert
            Assert.IsTrue(cargoShip.Length == length);
            Assert.IsTrue(cargoShip.Width == width);
        }
    }
}
