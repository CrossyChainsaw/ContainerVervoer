using ContainerVervoer.Logic;
using ContainerVervoer.Logic.DifferentTypesOfContainers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Requirement 5/8: Alle containers die gekoeld moeten blijven moeten in de eerste rij worden geplaatst
// vanwege de stroomvoorziening die aan de voorkant van elk schip zit.

namespace ContainerVervoer.Tests
{
    [TestClass]
    public class CoolContainerFirstRow
    {
        int shipLength = 1;
        int shipWidth = 2;

        [TestMethod]
        public void DistributeContainers()
        {
            // Expected
            CargoShip cargoShip = new CargoShip(shipLength, shipWidth);
            FillShipWithContaiers(cargoShip);
            cargoShip.DistributeContainersInShip();

            foreach (Container container in cargoShip.LayerList[0].ColumnList[0].ContainerList)
            {

            }

            // Zitten er cool containers in de eerste column
            Assert.IsTrue(cargoShip.LayerList[0].ColumnList[0].ContainerList[0].Name == new CoolContainer(ContainerStatic.MaxWeight).Name);

            // Check of er geen zit in elke andere column
            for (int i = 1; i < cargoShip.LayerList[0].ColumnList.Count; i++)
            {
                foreach (Container container in cargoShip.LayerList[0].ColumnList[i].ContainerList)
                {
                    Assert.IsTrue(container.Name != ContainerTypes.Cool.ToString());
                } 
            }
        }

        void FillShipWithContaiers(CargoShip cargoShip)
        {
            int nContainers = 5;
            for (int i = 0; i < nContainers; i++)
            {
                cargoShip.ContainerCollection.CreateContainer(ContainerTypes.Cool, ContainerStatic.MaxWeight);
            }
        }
    }
}

/*

Dit gebeurt er in de test

   |R1 |R2 |R3 |
---+---+---+---+
C1 | K | K | K | <- Zijn deze allemaal KoelContainers? (Assert per vakje)
---+---+---+---+
C2 |   |   |   |
---+---+---+---+
C3 |   |   |   |
---+---+---+---+
C4 |   |   |   |
---+---+---+---+
C5 |   |   |   |
---+---+---+---+
C6 |   |   |   |
---+---+---+---+
C7 |   |   |   |
*/