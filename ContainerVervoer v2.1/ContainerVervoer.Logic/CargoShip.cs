using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Logic
{
    public class CargoShip
    {
        public CargoShip(int length, int width)
        {
            Width = width;
            Length = length;
        }

        public int Width { get; private set; }
        public int Length { get; private set; }
        List<Layer> layerList = new List<Layer>();
        public List<Layer> LayerList { get { return layerList; } }

        ContainerCollection containerCollection = new ContainerCollection();
        public ContainerCollection ContainerCollection { get { return containerCollection; } }

        public void CreateLayer()
        {
            layerList.Add(new Layer(Width, Length));
        }
        public void DistributeContainersInShip()
        {
            if (ThereIsEnoughWeightToMakeTheShipNotTurnTurtle())
            {
                SortLists();
                DistributeCoolAndNormal();
                // distribute special
            }
            else
            {
                Error.ErrorMessage = "Er zijn te weinig containers, zo loop je risico dat het schip zal kapseizen";
            }
        }

        public void SortLists()
        {
            containerCollection.SortAllLists();
        }

        public void RandomContainers()
        {
            containerCollection.RandomContainers(Length, Width);
        }

        public void DistributeCoolAndNormal()
        {
            if (ThereAreNormalContainersLeft() || ThereAreCoolContainersLeft())
            {
                CreateLayer();

                if (ThereAreCoolContainersLeft())
                {
                    if (ThereAreEnoughCoolContainersToFillFirstColumn())
                    {
                        FillTheFirstColumnWithCoolContainers();
                    }
                    else
                    {
                        // container voor container koel containers vullen in eerste rij
                    }
                }
                if (ThereAreNormalContainersLeft())
                {
                    if (ThereAreEnoughNormalContainersToFillTheRestOfTheLayer())
                    {
                        FillTheRestOfTheLayerWithNormalContainers();
                    }
                    else if (ThereAreEnoughNormalContainersToFillSkipFill())
                    {
                        // always start from col[1] or 4, 7, 10 etc.
                        FillSkipFillStartingFromSpecifiedColumnWithNormalContainers(1);
                    }
                    else if (ThereAreEnoughNormalContainersToFillColumn())
                    {
                        // LET OP WEL GOEDE COLUMN
                        FillSpecifiedColumnWithNormalContainers(NextEmptyColumn());
                    }
                    else
                    {
                        // LET OP WEL GOEDE COLUMN
                        // Place container in spot
                    }
                }
            }
        }



        bool ThereIsEnoughWeightToMakeTheShipNotTurnTurtle()
        {
            int amountOfContainersPossibleOnFirstLayer = Width * Length;
            int maxWeightPossibleOnALayer = amountOfContainersPossibleOnFirstLayer * ContainerStatic.MaxWeight;
            int maxWeightPossibleOnShip = maxWeightPossibleOnALayer * 5; // because max weight on top of a container is 120.000kg
            int halfOfMaxWeightPossibleOnShip = maxWeightPossibleOnShip / 2;
            if (containerCollection.GetWeight(containerCollection.AllContainerList) >= halfOfMaxWeightPossibleOnShip)
            {
                return true;
            }
            return false;
        }
        int NextEmptyColumn()
        {
            for (int i = 0; i < layerList[0].ColumnList.Count; i++)
            {
                if (layerList[0].ColumnList[i].ContainerList == null)
                {
                    return i; // geeft eerstvolgende lege column
                }
            }
            return 69696969;
        }
        int NextFillSkipFillColumn()
        {
            return 0; // geeft eerstvolgende column waar nog 2 lege columns achter zitten
        }

        // Methods - Fill...
        void FillTheFirstColumnWithCoolContainers()
        {
            for (int i = 0; i < Width; i++)
            {
                // eerste layer drm 0                                                      eerste column drm 0 moet voorin ja toch
                LayerList[0].AddContainerToSpecificLocation(containerCollection.CoolContainerList.Last(), i, 0); // voeg toe aan nieuwe plek
                containerCollection.CoolContainerList.RemoveAt(containerCollection.CoolContainerList.Count - 1); // verwijder uit oude plek
            }
        }
        void FillSpecifiedColumnWithNormalContainers(int nColumn)
        {
            for (int i = 0; i < Width; i++)
            {
                // eerste layer drm 0                                                      eerste column drm 0 moet voorin ja toch
                LayerList[0].AddContainerToSpecificLocation(containerCollection.NormalContainerList.Last(), i, nColumn); // voeg toe aan nieuwe plek
                containerCollection.NormalContainerList.RemoveAt(containerCollection.NormalContainerList.Count - 1); // verwijder uit oude plek
            }
        }
        void FillTheRestOfTheLayerWithNormalContainers()
        {
            for (int i = 1; i < Length; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    layerList[0].AddContainerToSpecificLocation(containerCollection.NormalContainerList.Last(), j, i);
                    containerCollection.NormalContainerList.RemoveAt(containerCollection.NormalContainerList.Count - 1);
                }
            }
        }
        void FillSkipFillStartingFromSpecifiedColumnWithNormalContainers(int nColumn)
        {
            for (int i = 0; i < Width; i++)
            {
                LayerList[0].AddContainerToSpecificLocation(containerCollection.NormalContainerList.Last(), i, nColumn);
                containerCollection.NormalContainerList.RemoveAt(containerCollection.NormalContainerList.Count - 1);
            }
            nColumn += 2;
            for (int i = 0; i < Width; i++)
            {
                LayerList[0].AddContainerToSpecificLocation(containerCollection.NormalContainerList.Last(), i, nColumn);
                containerCollection.NormalContainerList.RemoveAt(containerCollection.NormalContainerList.Count - 1);
            }
        }

        // Methods - ThereAre...
        bool ThereAreContainersLeft()
        {
            return containerCollection.AllContainerList.Count > 0;
        }
        bool ThereAreCoolContainersLeft()
        {
            return containerCollection.CoolContainerList.Count > 0;
        }
        bool ThereAreNormalContainersLeft()
        {
            return containerCollection.NormalContainerList.Count > 0;
        }
        bool ThereAreEnoughNormalContainersToFillColumn()
        {
            return containerCollection.NormalContainerList.Count >= Width;
        }
        bool ThereAreEnoughNormalContainersToFillSkipFill()
        {
            return containerCollection.NormalContainerList.Count >= Width * 2;
        }
        bool ThereAreEnoughCoolContainersToFillFirstColumn()
        {
            return containerCollection.CoolContainerList.Count >= Width;
        }
        bool ThereAreEnoughNormalContainersToFillTheRestOfTheLayer()
        {
            return (containerCollection.NormalContainerList.Count >= (layerList[0].ColumnList.Count - 1) * (layerList[0].RowList.Count));
        }
        bool ThereAreEnoughNormalContainersToFillTheRestOfTheLayerTakingIntoAccountThatTheNextLayerHasEnoughNormalContainersToFillSkipFill()
        {
            // begin hier niet aan ga gwn weg nu het nog kan
            // maar wat er gebeurt is, hij zegt dat je genoeg containers moet hebben om de laag te vullen waar je nu op zit, + de volgende laag op manier van fill skip fill
            bool enoughToFillRestOfLayer = (containerCollection.NormalContainerList.Count >= (layerList[0].ColumnList.Count - 1) * (layerList[0].RowList.Count));
            if (layerList[0].ColumnList.Count % 3 == 1)
            {
                return (containerCollection.NormalContainerList.Count >= ((layerList[0].ColumnList.Count - 1) * (layerList[0].RowList.Count) + ((layerList[0].ColumnList.Count - 1) * 2 / 3))); // (current layer + fix next layer)
            }
            else
            {
                int amountOfColumns = layerList[0].ColumnList.Count;
                if (layerList[0].ColumnList.Count % 3 == 0)
                {
                    amountOfColumns -= 1;
                }
                int amountOfColumnsThatHaveToBeSkipped = 0;
                while (amountOfColumns > 2)
                {
                    amountOfColumns -= 3;
                    amountOfColumnsThatHaveToBeSkipped++;
                }
                int amountOfGoodColumns = layerList[0].ColumnList.Count - amountOfColumnsThatHaveToBeSkipped;
                return (containerCollection.NormalContainerList.Count >= amountOfGoodColumns);
            }
        }
    }
}






/*
       Row1Row2Row3       

Column1    /\
Column2   /  \
Column3  /    \
Column4 |      |
Column5 |   B  | 
Column6 |   O  |
Column7 |   A  |
Column8 |   T  | 
Column9 |      |
Colum10 |      |
Colum11 |      | 
Colum12 |______|
*/

/*
 *         // Fill Methods
        public void FillTheFirstColumnWithNormalContainers()
        {
            for (int i = 0; i < Width; i++)
            {
                MoveContainer(ContainerCollection.NormalContainerList, i, 0);
            }
        }

        public void MoveContainer(List<Container> list, int nRow, int nColumn)
        {
            LayerList[0].AddContainerToSpecificLocation(list.Last(), nRow, nColumn);
            list.RemoveAt(list.Count - 1);
        }
*/