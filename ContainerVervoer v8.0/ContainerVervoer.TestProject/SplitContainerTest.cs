using ContainerVervoer.Logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// FR-07: Het schip moet in evenwicht zijn: het volledige gewicht van de containers
//  voor iedere helft mag niet meer dan 20% van de totale lading verschillen.

namespace ContainerVervoer.TestProject
{
    class SplitContainerTest
    {
        Random rnd = new Random();

        [TestCase(104)]
        [TestCase(207)]
        public void SplitContainerLeftRight(int containerAmoount)
        {
            // Arrange
            CargoShip cargoShip = new CargoShip(6, 2);
            AddNormalContainers(cargoShip, containerAmoount);

            // Act
            cargoShip.Distribute();
            bool result = cargoShip.TwentyPercentageRuleCheck();

            // Assertje
            Assert.IsTrue(result);
        }

        [Test]
        public void SplitContainerMidRightLeft()
        {
            // fuck this shit
        }

        void AddNormalContainers(CargoShip cargoship, int n)
        {
            for (int i = 0; i < n; i++)
            {
                cargoship.ContainerCollection.CreateContainer(ContainerTypes.Normal, rnd.Next(ContainerClass.MinWeight, ContainerClass.MaxWeight + 1));
            }
        }

        //void AddCoolContainers(CargoShip cargoship, int n)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        cargoship.ContainerCollection.CreateContainer(ContainerTypes.Cool, rnd.Next(ContainerClass.MinWeight, ContainerClass.MaxWeight + 1));
        //    }
        //}
    }
}
