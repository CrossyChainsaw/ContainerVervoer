using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Logic
{
    class Layer
    {
        public ReadOnlyCollection<Column> ColList { get { return new ReadOnlyCollection<Column>(_colList); } }
        public ReadOnlyCollection<Row> RowList { get { return new ReadOnlyCollection<Row>(_rowList); } }
        private readonly List<Column> _colList = new List<Column>();
        private readonly List<Row> _rowList = new List<Row>();
        private int nRow = 0;
        private int nCol = 0;

        public Layer(int length, int width)
        {
            CreateRows(length);
            CreateColumns(width);
        }

        public void AddContainerToNextFreeSpot(ContainerClass container)
        {
            _rowList[nRow].PlaceContainer(container, nCol++);
            if (nCol > _colList.Count)
            {
                nCol = 0;
                nRow++;
            } // go to next row
        }

        private void CreateRows(int length)
        {
            for (int i = 0; i < length; i++)
            {
                _rowList.Add(new Row(length));
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
    }
}
