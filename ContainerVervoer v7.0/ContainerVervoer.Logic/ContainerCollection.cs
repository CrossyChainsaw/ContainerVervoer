using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Logic
{
    public class ContainerCollection
    {
        public ReadOnlyCollection<ContainerClass> AllContainers { get { return new ReadOnlyCollection<ContainerClass>(_allContainers); } }
        public ReadOnlyCollection<ContainerClass> AllContainersLeft { get { return new ReadOnlyCollection<ContainerClass>(_allContainersLeft); } }
        public ReadOnlyCollection<ContainerClass> AllContainersRight { get { return new ReadOnlyCollection<ContainerClass>(_allContainersRight); } }
        private readonly List<ContainerClass> _allContainers = new List<ContainerClass>();
        private readonly List<ContainerClass> _allContainersLeft = new List<ContainerClass>();
        private readonly List<ContainerClass> _allContainersRight = new List<ContainerClass>();

        public void CreateContainer(ContainerTypes containerType, int weight)
        {
            if (weight >= ContainerClass.MinWeight && weight <= ContainerClass.MaxWeight)
            {
                ContainerClass container = new ContainerClass(containerType, weight);
                _allContainers.Add(container);
            }
            else
            {
                // Return some error
            }
        }

        public void SplitContainersIntoLeftAndRight()
        {
            // Vul de lijsten eerst met alle koel containers, doe vervolgens normale containers
            var containerStack = new Stack<ContainerClass>(_allContainers);
            _allContainersLeft.Add(containerStack.Pop());
            int amountOfContainers = containerStack.Count();

            for (int i = 0; i < amountOfContainers; i++)
            {
                if (GetTotalWeight(_allContainersLeft) > GetTotalWeight(_allContainersRight))
                {
                    _allContainersRight.Add(containerStack.Pop());
                }
                else
                {
                    _allContainersLeft.Add(containerStack.Pop());
                }
            }
        }

        public int GetTotalWeight(List<ContainerClass> containerList)
        {
            int totalWeight = 0;
            foreach (ContainerClass container in containerList)
            {
                totalWeight += container.Weight;
            }
            return totalWeight;
        }
        public int GetTotalWeight(ReadOnlyCollection<ContainerClass> containerList)
        {
            int totalWeight = 0;
            foreach (ContainerClass container in containerList)
            {
                totalWeight += container.Weight;
            }
            return totalWeight;
        }

        public void RemoveLast(ReadOnlyCollection<ContainerClass> containerList)
        {
            
        }
    }
}
