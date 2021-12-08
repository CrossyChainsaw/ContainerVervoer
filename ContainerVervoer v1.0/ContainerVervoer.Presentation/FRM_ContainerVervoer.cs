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
        void DistributeContainers()
        {
            /////
            List<int> intlinst = new List<int>();
            intlinst.Add(5);
            intlinst[0] = 6;
            ///////////
            cargoShip.DistributeContainers();
        }

        private void BTN_Distribute_Click(object sender, EventArgs e)
        {
            DistributeContainers();
            BTN_Distribute.Enabled = false;
        }

        public bool ThereAreContainersLeft()
        {
            return cargoShip.ContainerCollection.ContainerList.Count > 0;
        }
        public bool ThereAreCoolContainersLeft()
        {
            return cargoShip.ContainerCollection.CoolContainerList.Count > 0;
        }
        public bool ThereAreEnoughCoolContainersToFillFirstColumn()
        {
            return cargoShip.ContainerCollection.CoolContainerList.Count >= cargoShip.Width;
        }

        // Stupid form bs
        public bool LegalWeight(int weight)
        {
            return weight >= ContainerStatic.MinWeight && weight <= ContainerStatic.MaxWeight;
        }
        public void LogActionInListbox(ContainerTypes containerType, int weight)
        {
            LB_EventTracker.Items.Add("[" + ++i + "] " + containerType + " container toegevoegd! (" + weight + "kg)");
        }
        public ContainerTypes GetTheCorrectContainerType()
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
        public bool AnyRadioButtonChecked()
        {
            return (RB_Cool.Checked || RB_Normal.Checked || RB_Valuable.Checked);
        }
        private void BTN_AddContainer_Click(object sender, EventArgs e)
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
        private void BTN_ConfirmShipSize_Click(object sender, EventArgs e)
        {
            cargoShip = new CargoShip((int)NUD_Length.Value, (int)NUD_Width.Value);

            GB_ShipSize.Enabled = false;
            GB_AddContainers.Enabled = true;
        }

    }
}
