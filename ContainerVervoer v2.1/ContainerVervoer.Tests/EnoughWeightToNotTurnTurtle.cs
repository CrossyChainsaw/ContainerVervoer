using ContainerVervoer.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Requirement 6/8: Om kapseizen te voorkomen moet ten minste 50% van het maximum gewicht van een schip zijn benut.

namespace ContainerVervoer.Tests
{
    [TestClass]
    public class EnoughWeightToNotTurnTurtle
    {
        [TestMethod]
        public void VeryBigShipButOnlyTwoContainers()
        {
            CargoShip cargoShip = new CargoShip(40, 10);
            for (int i = 0; i < 2; i++)
            {
                cargoShip.ContainerCollection.CreateContainer(ContainerTypes.Normal, 30000);
            }
            // to not fall we need at least
            // 40*10 = 400 (aantal containers op layer)
            // 400*30.000 = 12.000.000 (aantal kg op layer)
            // 12.000.000 * 5 = 60.000.000 (aantal kg totaal mogelijk)
            // 60.000.000 / 2 = 30.000.000kg of containers, now we only have 60.000kg so test should give a false outcome
            // verwijder deze shit na uitleg
            Assert.IsFalse(cargoShip.ThereIsEnoughWeightToMakeTheShipNotTurnTurtle());
        }

        [TestMethod]
        public void SmallShipLotsOfContainers()
        {
            CargoShip cargoShip = new CargoShip(5, 2);
            for (int i = 0; i < 30; i++)
            {
                cargoShip.ContainerCollection.CreateContainer(ContainerTypes.Normal, 30000);
            }
            Assert.IsTrue(cargoShip.ThereIsEnoughWeightToMakeTheShipNotTurnTurtle());
        }
    }
}
