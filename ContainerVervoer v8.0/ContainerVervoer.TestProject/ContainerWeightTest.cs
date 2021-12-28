using ContainerVervoer.Logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// FR-02: Een volle container weegt maximaal 30 ton. Een lege container weegt 4000 kg.

namespace ContainerVervoer.TestProject
{
    class ContainerWeightTest
    {
        [TestCase(ContainerClass.MinWeight)]
        [TestCase(ContainerClass.MaxWeight)]
        public void CreateContainerWithLegalWeight(int weight)
        {
            // Arrange
            ContainerCollection containerCollection = new ContainerCollection();

            // Act
            containerCollection.CreateContainer(ContainerTypes.Normal, weight);

            // Asser
            Assert.IsTrue(containerCollection.AllContainers.Count > 0);
        }

        [TestCase(ContainerClass.MinWeight - 1)]
        [TestCase(ContainerClass.MaxWeight + 1)]
        public void CreateContainerWithIllegalWeight(int weight)
        {
            // Arrange
            ContainerCollection containerCollection = new ContainerCollection();

            // Act
            containerCollection.CreateContainer(ContainerTypes.Normal, weight);

            // Asser
            Assert.IsTrue(containerCollection.AllContainers.Count == 0);
        }
    }
}
