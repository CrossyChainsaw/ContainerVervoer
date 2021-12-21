using ContainerVervoer.Logic;
using NUnit.Framework;

namespace ContainerVervoer.TestProject
{
    public class ContainerVervoer
    {
        [Test]
        public void Test1()
        {
            // Arrange
            int shipLength = 4;
            int shipWidth = 2;
            CargoShip cargoship = new CargoShip(shipLength, shipWidth);
            cargoship.ContainerCollection.CreateContainer(ContainerClass.MaxWeight);
            cargoship.ContainerCollection.CreateContainer(ContainerClass.MaxWeight);
            cargoship.ContainerCollection.CreateContainer(ContainerClass.MaxWeight);
            cargoship.ContainerCollection.CreateContainer(ContainerClass.MaxWeight);

            // Act
            cargoship.Distribute();

            // Assert
            Assert.Pass();
        }
    }
}