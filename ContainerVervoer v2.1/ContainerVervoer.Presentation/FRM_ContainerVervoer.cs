using ContainerVervoer.Logic;
using ContainerVervoer.Logic.DifferentTypesOfContainers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerVervoer.Presentation
{
    public partial class FRM_ContainerVervoer : Form
    {
        public FRM_ContainerVervoer()
        {
            InitializeComponent();
        }
        CargoShip cargoShip;

        int i = 0;
        public void AddAndLogXAmountContainers(int amount, ContainerTypes containerType, int weight)
        {
            for (int i = 0; i < amount; i++)
            {
                cargoShip.ContainerCollection.CreateContainer(containerType, weight);
                LogActionInListbox(containerType, weight);
            }
        }
        private void BTN_Distribute_Click(object sender, EventArgs e)
        {
            DistributeContainers();
            VisualizeShip();
            BTN_Distribute.Enabled = false;
            GB_CargoShipVisualization.Enabled = true;
        }
        void DistributeContainers()
        {
            cargoShip.DistributeContainersInShip();
        }

        void AddRandomContainers()
        {
            cargoShip.RandomContainers();
        }

        // Presentation garbage starts here
        bool LegalWeight(int weight)
        {
            return weight >= ContainerStatic.MinWeight && weight <= ContainerStatic.MaxWeight;
        }
        void LogActionInListbox(ContainerTypes containerType, int weight)
        {
            LB_EventTracker.Items.Add("[" + ++i + "] " + containerType + " container toegevoegd! (" + weight + "kg)");
        }
        ContainerTypes GetTheCorrectContainerType()
        {
            ContainerTypes containerType;
            if (RB_Normal.Checked)
            {
                containerType = ContainerTypes.Normal;
            }
            else if (RB_Cool.Checked)
            {
                containerType = ContainerTypes.Cool;
            }
            else if (RB_Valuable.Checked)
            {
                containerType = ContainerTypes.Valuable;
            }
            else
            {
                containerType = ContainerTypes.Null;
            }
            return containerType;
        }
        bool AnyRadioButtonChecked()
        {
            return (RB_Cool.Checked || RB_Normal.Checked || RB_Valuable.Checked);
        }
        void BTN_AddContainer_Click(object sender, EventArgs e)
        {
            int weight = (int)NUD_Weight.Value;

            if (AnyRadioButtonChecked() && LegalWeight(weight))
            {
                int amount = (int)NUD_Amount.Value;
                ContainerTypes containerType = GetTheCorrectContainerType();
                AddAndLogXAmountContainers(amount, containerType, weight);
                BTN_Distribute.Enabled = true;
            }
            else if (!AnyRadioButtonChecked())
            {
                MessageBox.Show("Kies een type container");
            }
            else if (!LegalWeight(weight))
            {
                MessageBox.Show("Gewicht moet groter zijn dan 4000 en kleiner dan 120000");
            }
        }
        void BTN_ConfirmShipSize_Click(object sender, EventArgs e)
        {
            cargoShip = new CargoShip((int)NUD_Length.Value, (int)NUD_Width.Value);

            GB_ShipSize.Enabled = false;
            GB_AddContainers.Enabled = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            AddRandomContainers();
            BTN_Distribute.Enabled = true;
        }

        int xGrid = 12;
        int yGrid = 20;
        void VisualizeShip()
        {
            int xLocation = 1;
            int yLocation = 1;
            foreach (Layer layer in cargoShip.LayerList) // voor elke layer
            {
                foreach (Row row in layer.RowList)
                {
                    yLocation = 1;
                    foreach (Container container in row.ContainerList)
                    {
                        CreatePictureBox(container, xLocation, yLocation);
                        yLocation++;
                    }
                    xLocation++;
                }
                xLocation += 10;
            }
        }
        void CreatePictureBox(Container container, int xModifier, int yModifier)
        {
            PictureBox PB_Container = new PictureBox();
            PB_Container.Size = new Size(12, 20);
            PB_Container.Location = new Point(xGrid * xModifier, yGrid * yModifier);
            PB_Container.BorderStyle = BorderStyle.FixedSingle;
            PB_Container.BackColor = GoodContainerColor(container);
            GB_CargoShipVisualization.Controls.Add(PB_Container);
        }
        Color GoodContainerColor(Container container)
        {
            if (container.Name == ContainerTypes.Cool.ToString())
            {
                return Color.DeepSkyBlue;
            }
            else if (container.Name == ContainerTypes.Normal.ToString())
            {
                return Color.LimeGreen;
            }
            else
            {
                return Color.Khaki;
            }
        }
    }
}
