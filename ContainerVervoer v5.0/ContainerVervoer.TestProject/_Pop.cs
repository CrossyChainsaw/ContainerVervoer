using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.TestProject
{
    class _Pop
    {
        [TestCase]
        public void TestPop()
        {
            // Arrange
            List<string> nameList = new List<string>();
            List<string> newNameList = new List<string>();
            nameList.Add("a");
            nameList.Add("b");
            nameList.Add("c");
            nameList.Add("d");

            // Act
            var myStack = new Stack<string>(nameList);
            newNameList.Add(myStack.Pop());
            newNameList.Add(myStack.Pop());
            newNameList.Add(myStack.Pop());
            newNameList.Add(myStack.Pop());

            // Assert
        }
    }
}
