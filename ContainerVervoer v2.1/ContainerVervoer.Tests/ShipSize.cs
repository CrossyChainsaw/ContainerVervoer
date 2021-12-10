using ContainerVervoer.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Requirement 8/8: De afmeting van een schip moet instelbaar zijn in de applicatie, waarbij de hoogte en breedte in containers aangegeven kan worden.

namespace ContainerVervoer.Tests
{
    [TestClass]
    public class ShipSize
    {
        [TestMethod]
        public void ShipWidth()
        {
            CargoShip cargoShip = new CargoShip(10, 20);
            Assert.IsNotNull(cargoShip.Width);
        }

        public void ShipLength()
        {
            CargoShip cargoShip = new CargoShip(10, 20);
            Assert.IsNotNull(cargoShip.Length);
        }
    }
}
