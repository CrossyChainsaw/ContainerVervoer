using ContainerVervoer.Logic;
using ContainerVervoer.Logic.DifferentTypesOfContainers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Requirement 2: Een volle container weegt maximaal 30 ton. Een lege container weegt 4000 kg.

namespace ContainerVervoer.Tests
{
    [TestClass]
    public class CreateContainer // parameterized tests
    {
        [TestMethod]
        public void CreateCoolContainer()
        {
            ContainerCollection containerCollection = new ContainerCollection();
            int containerWeight = 10321;
            containerCollection.CreateContainer(ContainerTypes.Cool, containerWeight);
            Assert.IsTrue(containerCollection.CoolContainerList.Count == 1);
        }

        [TestMethod]
        public void CreateValuableContainerTooHeavy()
        {
            ContainerCollection containerCollection = new ContainerCollection();
            int containerWeight = 1321;
            containerCollection.CreateContainer(ContainerTypes.Valuable, containerWeight);
            Assert.IsTrue(containerCollection.ValuableContainerList.Count == 0);
        }

        [TestMethod]
        public void CreateNormalContainerTooLight()
        {
            ContainerCollection containerCollection = new ContainerCollection();
            int containerWeight = 121321;
            containerCollection.CreateContainer(ContainerTypes.Normal, containerWeight);
            Assert.IsTrue(containerCollection.NormalContainerList.Count == 0);
        }
    }
}
