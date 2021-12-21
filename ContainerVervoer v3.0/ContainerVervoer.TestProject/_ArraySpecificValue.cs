using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.TestProject
{
    class _ArraySpecificValue
    {
        [Test]
        public void Test()
        {
            // Arrange
            string[] stringArray = new string[10];

            // Act
            stringArray[7] = "test";
            if (stringArray.Length > 10)
            {

            }

            // Assert
        }
    }
}
