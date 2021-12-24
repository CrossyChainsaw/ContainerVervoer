using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// kijk overal zoek styartpoint shit kan wss weg

namespace ContainerVervoer.Logic
{
    class Layer
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

        public void AddContainerToNextFreeColumnInRow(ContainerClass container) // entire row
        {
            _rowList[nRow].PlaceContainer(container, nCol++);
            if (nCol > _colList.Count)
            {
                nCol = 0;
                nRow++;
            }
        }

        public void AddContainerToNextFreeColumnLeft(ContainerClass container)
        {
            _rowList[nRow].PlaceContainer(container, nCol++);
            if (nCol == _colList.Count / 2)
            {
                nCol = 0;
                nRow++;
            }
        }

        public void AddContainerToNextFreeColumnRight(ContainerClass container)
        {
            _rowList[nRow].PlaceContainer(container, nCol++);
            if (nCol == _colList.Count)
            {
                nCol = _startPoint;
                nRow++;
            }
        }

        public void SetStartPoint(int startPoint)
        {
            _startPoint = startPoint;
            nCol = _startPoint;
            nRow = 0;
        }

        //public void AddContainerToNextFreeColumnRight(ContainerClass container, int startpoint)
        //{
        //    _rowList[nRow].PlaceContainer(container, nCol++);
        //    if (nCol > _colList.Count)
        //    {
        //        nCol = 0;
        //        nRow++;
        //    }
        //}

        private void CreateRows(int length, int width)
        {
            for (int i = 0; i < length; i++)
            {
                _rowList.Add(new Row(width));
            }
        }

        private void CreateColumns(int width)
        {
            for (int i = 0; i < width; i++)
            {
                _colList.Add(new Column(width));
            }
        }

        public bool ThereIsEmptySpot()
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
    }
}
