using ContainerVervoer.Logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.TestProject
{
    class _PlaceContainer
    {
        [Test]
        public void PlaceContainer()
        {
            // Arange
            CargoShip cargoShip = new CargoShip(10, 4);
            cargoShip.CreateLayer();

            // Act
            cargoShip.PlaceContainerInLayer0(new ContainerClass(ContainerTypes.Normal, 4000));
            cargoShip.PlaceContainerInLayer0(new ContainerClass(ContainerTypes.Normal, 4000));
            cargoShip.PlaceContainerInLayer0(new ContainerClass(ContainerTypes.Normal, 4000));

            // Assert
            Assert.Pass();
        }
    }
}
