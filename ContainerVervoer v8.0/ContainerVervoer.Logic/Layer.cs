using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// kijk overal zoek styartpoint shit kan wss weg

namespace ContainerVervoer.Logic
{
    public class Layer
    {
        public ReadOnlyCollection<Column> ColList { get { return new ReadOnlyCollection<Column>(_colList); } }
        public ReadOnlyCollection<Row> RowList { get { return new ReadOnlyCollection<Row>(_rowList); } }
        private readonly List<Column> _colList = new List<Column>();
        private readonly List<Row> _rowList = new List<Row>();
        private int _startPoint;
        private int nRow;
        private int nCol;

        public Layer(int length, int width)
        {
            CreateRows(length, width);
            CreateColumns(width);
        }

        //void AddContainerToNextFreeColumnInRow(ContainerClass container) // entire row
        //{
        //    _rowList[nRow].PlaceContainer(container, nCol++);
        //    if (nCol > _colList.Count)
        //    {
        //        nCol = 0;
        //        nRow++;
        //    }
        //}

        public void AddContainerToNextFreeColumnLeft(ContainerClass container, List<Layer> layerList)
        {
            if (GetTotalWeightSpecificSpot(layerList, nRow, nCol) + container.Weight <= 150000)
            {
                _rowList[nRow].PlaceContainer(container, nCol++);
                if (nCol == _colList.Count / 2)
                {
                    nCol = 0;
                    nRow++;
                }
            }
        }

        public void AddContainerToNextFreeColumnRight(ContainerClass container, List<Layer> layerList)
        {
            if (GetTotalWeightSpecificSpot(layerList, nRow, nCol) + container.Weight <= 150000)
            {
                _rowList[nRow].PlaceContainer(container, nCol++);
                if (nCol == _colList.Count)
                {
                    nCol = _startPoint;
                    nRow++;
                }
            }
        }

        public void SetStartPoint(int startPoint)
        {
            _startPoint = startPoint;
            nCol = _startPoint;
            nRow = 0;
        }

        void CreateRows(int length, int width)
        {
            for (int i = 0; i < length; i++)
            {
                _rowList.Add(new Row(width));
            }
        }

        void CreateColumns(int width)
        {
            for (int i = 0; i < width; i++)
            {
                _colList.Add(new Column(width));
            }
        }

        bool ThereIsEmptySpot()
        {
            foreach (Row row in _rowList)
            {
                foreach (var item in row.ContainerArray)
                {
                    if (item == null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ThereIsEmptySpotLeft()
        {
            foreach (Row row in _rowList)
            {
                for (int i = 0; i < row.ContainerArray.Count / 2; i++)
                {
                    if (row.ContainerArray[i] == null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ThereIsEmptySpotRight(int startpoint)
        {
            foreach (Row row in _rowList)
            {
                for (int i = startpoint; i < row.ContainerArray.Count; i++)
                {
                    if (row.ContainerArray[i] == null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int GetTotalWeightSpecificSpot(List<Layer> layerList, int nRow, int nContainerSpot)
        {
            int totalWeight = 0;
            foreach (Layer layer in layerList)
            {
                if (layer.RowList[nRow].ContainerArray[nContainerSpot] != null)
                {
                    totalWeight += layer.RowList[nRow].ContainerArray[nContainerSpot].Weight;
                }
            }
            return totalWeight;
        }

        public int GetTotalWeightSpecificSpot(ReadOnlyCollection<Layer> layerList, int nRow, int nContainerSpot)
        {
            int totalWeight = 0;
            foreach (Layer layer in layerList)
            {
                if (layer.RowList[nRow].ContainerArray[nContainerSpot] != null)
                {
                    totalWeight += layer.RowList[nRow].ContainerArray[nContainerSpot].Weight;
                }
            }
            return totalWeight;
        }
    }
}
