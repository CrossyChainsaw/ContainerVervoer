using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Logic
{
    public enum ContainerTypes
    {
        Null,
        Normal,
        Cool,
        Valuable
    }

    public class Container
    {
        List<Container> containersAboveMe = new List<Container>();

        public Container()
        {

        }

        public Container(int weight)
        {
            Weight = weight;
        }

        public List<Container> ContainersAboveMe { get; private set; }
        public int Weight { get; private set; }
        public string Name { get; private set; }
        public bool ContainerAboveMeAllowed { get; private set; } // interface?
        public bool MustBeFirstRow { get; private set; } // interface?

        internal void SetWeight(int weight)
        {
            Weight = weight;
        }
        internal void SetName(string name)
        {
            Name = name;
        }
        internal void SetContnainerAboveMeAllowed(bool containerAboveMeAllowed)
        {
            ContainerAboveMeAllowed = containerAboveMeAllowed;
        } // interface van maken?
        internal void SetMustBeFirstRow(bool mustBeFirstRow)
        {
            MustBeFirstRow = mustBeFirstRow;
        } // interface van maken?
    }

    public class ContainerStatic
    {
        public const int MaxWeight = 30000;
        public const int MinWeight = 4000;
    }
}
