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
        public List<Container> ContainerList { get { return allContainerList; } }
        List<CoolContainer> coolContainerList = new List<CoolContainer>();
        public List<CoolContainer> CoolContainerList { get { return coolContainerList; } }
        List<NormalContainer> normalContainerList = new List<NormalContainer>();
        public List<NormalContainer> NormalContainerList { get { return normalContainerList; } }
        List<ValuableContainer> valuableContainerList = new List<ValuableContainer>();
        public List<ValuableContainer> ValuableContainerList { get { return valuableContainerList; } }

        public Container GetLastFrom(List<Container> someContainerList)
        {
            return someContainerList.Last();
        } // werkt niet ik doet iets fout?
        public void RemoveLastFrom(List<Container> someContainerList)
        {
            someContainerList.RemoveAt(someContainerList.Count() - 1);
        } // waarom???

        public int GetTotalWeight()
        {
            int totalWeight = 0;
            foreach (Container container in allContainerList)
            {
                totalWeight += container.Weight;
            }
            return totalWeight;
        }
        public void SortContainersFromLightToHeavy(List<Container> containerList)
        {
            List<Container> sortedContainerList = new List<Container>();

            // zoek de lichtste en zet hem voorop
            for (int i = 0; i < containerList.Count; i++)
            {

            }
        }
    }
}
