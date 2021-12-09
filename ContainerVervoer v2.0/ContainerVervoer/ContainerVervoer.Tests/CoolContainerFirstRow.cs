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
        int shipLength = 7;
        int shipWidth = 3;

        [TestMethod]
        public void DistributeContainers()
        {
            CargoShip cargoShip = new CargoShip(shipLength, shipWidth);

            FillTestlistWithContainers(cargoShip);
            cargoShip.DistributeContainersInShip();

            List<Container> actualContainerList = new List<Container>();
            FillActualListWithContainers(actualContainerList);


            List<Container> expectedContainerList = cargoShip.LayerList[0].ColumnList[0].ContainerList;
            CollectionAssert.AreEqual(expectedContainerList, actualContainerList); // waarom de f werkt dit niet
        }

        void FillActualListWithContainers(List<Container> actualContainerList)
        {
            for (int i = 0; i < shipWidth; i++)
            {
                actualContainerList.Add(new CoolContainer(ContainerStatic.MinWeight));
            }
        }
        void FillTestlistWithContainers(CargoShip cargoShip)
        {
            int nContainers = 20;
            for (int i = 0; i < nContainers; i++)
            {
                cargoShip.ContainerCollection.CreateContainer(ContainerTypes.Cool, ContainerStatic.MinWeight);
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