using ContainerVervoer.Logic.DifferentTypesOfContainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Logic
{
    public class ContainerCollection
    {
        public const int MaxWeight = 120000;
        public const int MinWeight = 4000;

        public void CreateContainer(ContainerTypes containerType, int weight)
        {
            if (weight >= 4000 && weight <= 120000)
            {
                switch (containerType)
                {
                    case ContainerTypes.Normal:
                        CreateAndAddNormalContainer(weight, normalContainerList);
                        break;
                    case ContainerTypes.Cool:
                        CreateAndAddCoolContainer(weight, coolContainerList);
                        break;
                    case ContainerTypes.Valuable:
                        CreateAndAddValueableContainer(weight, valuableContainerList);
                        break;
                }
                CreateAndAddContainer(weight, allContainerList);
            }
            else
            {
                // error: weight too much or too low
            }
        }

        void CreateAndAddNormalContainer(int weight, List<NormalContainer> normalContainerList)
        {
            NormalContainer normalContainer = new NormalContainer(weight);
            normalContainerList.Add(normalContainer);
        }
        void CreateAndAddCoolContainer(int weight, List<CoolContainer> coolContainerList)
        {
            coolContainerList.Add(new CoolContainer(weight));
        }
        void CreateAndAddValueableContainer(int weight, List<ValuableContainer> valuableContainerList)
        {
            ValuableContainer valuableContainer = new ValuableContainer(weight);
            valuableContainerList.Add(valuableContainer);
        }
        void CreateAndAddContainer(int weight, List<Container> containerList)
        {
            Container container = new Container(weight);
            containerList.Add(container);
        }

        public Container ContainerType { get; private set; }

        List<Container> allContainerList = new List<Container>();

        public List<Container> AllContainerList { get { return allContainerList; } }
        List<Container> AllContainerListRight = new List<Container>();
        List<Container> AllContainerListLeft = new List<Container>();

        List<CoolContainer> coolContainerList = new List<CoolContainer>();
        public List<CoolContainer> CoolContainerList { get { return coolContainerList; } }
        List<Container> CoolContainerListRight = new List<Container>();
        List<Container> CoolContainerListLeft = new List<Container>();

        List<NormalContainer> normalContainerList = new List<NormalContainer>();
        public List<NormalContainer> NormalContainerList { get { return normalContainerList; } }
        List<Container> NormalContainerListRight = new List<Container>();
        List<Container> NormalContainerListLeft = new List<Container>();

        List<ValuableContainer> valuableContainerList = new List<ValuableContainer>();
        public List<ValuableContainer> ValuableContainerList { get { return valuableContainerList; } }
        List<Container> ValuableContainerListRight = new List<Container>();
        List<Container> ValuableContainerListLeft = new List<Container>();

        public Container GetLastFrom(List<Container> someContainerList)
        {
            return someContainerList.Last();
        }
        public void RemoveLastFrom(List<Container> someContainerList)
        {
            someContainerList.RemoveAt(someContainerList.Count() - 1);
        }
        public Container MoveLastContainer(List<Container> containerList)
        {
            Container container = GetLastFrom(containerList);
            RemoveLastFrom(containerList);
            return container;
        }

        public int GetWeight(List<Container> containerList)
        {
            int totalWeight = 0;
            foreach (Container container in containerList)
            {
                totalWeight += container.Weight;
            }
            return totalWeight;
        }
        public void SplitContainersIntoListLeftAndRight(List<Container> containerList, List<Container> containerListLeft, List<Container> containerListRight)
        {
            containerListLeft.Add(MoveLastContainer(containerList));
            int amountOfContainers = containerList.Count();

            for (int i = 0; i < amountOfContainers; i++)
            {
                if (GetWeight(containerListRight) < GetWeight(containerListLeft))
                {
                    containerListRight.Add(MoveLastContainer(containerList));
                }
                else
                {
                    containerListLeft.Add(MoveLastContainer(containerList));
                }
            }
        }

        public void SortAllLists()
        {
            SplitContainersIntoListLeftAndRight(AllContainerList, AllContainerListLeft, AllContainerListRight);
            GetWeight(AllContainerListLeft);
            GetWeight(AllContainerListRight);
            GetWeight(AllContainerList);
            //SplitContainersIntoListLeftAndRight(coolContainerList, CoolContainerListLeft, CoolContainerListRight);
            //SplitContainersIntoListLeftAndRight(normalContainerList, NormalContainerListLeft, NormalContainerListRight);
            //SplitContainersIntoListLeftAndRight(valuableContainerList, ValuableContainerListLeft, ValuableContainerListRight);
        }
        public void RandomContainers(int shipLength, int shipWidth)
        {
            Random rnd = new Random();
            int amountOfContainersPossible = shipLength * shipWidth * 5;

            for (int i = 0; i < amountOfContainersPossible; i++)
            {
                CreateContainer(ContainerTypes.Normal, rnd.Next(ContainerStatic.MinWeight, ContainerStatic.MaxWeight + 1));
                CreateContainer(ContainerTypes.Cool, rnd.Next(ContainerStatic.MinWeight, ContainerStatic.MaxWeight + 1));
            }
        }
    }
}
