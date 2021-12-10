using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Logic
{
    public class Layer
    {
        public Layer(int width, int length)
        {
            CreateRows(width);
            CreateColumns(length);
        }

        List<Row> rowList = new List<Row>();
        public List<Row> RowList { get { return rowList; } }
        List<Column> columnList = new List<Column>();
        public List<Column> ColumnList { get { return columnList; } }

        void CreateRows(int width)
        {
            for (int i = 0; i < width; i++)
            {
                rowList.Add(new Row());
            }
        }
        void CreateColumns(int length)
        {
            for (int i = 0; i < length; i++)
            {
                columnList.Add(new Column());
            }
        }

        public void AddContainerToSpecificLocation(Container container, int nRow, int nColumn)
        {
            rowList[nRow].ContainerList.Add(container);
            columnList[nColumn].ContainerList.Add(container);
        }
    }
}
