using ContainerVervoer.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerVervoer.Presentation
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        CargoShip cargoShip;

        public Form1()
        {
            InitializeComponent();
        }

        void ChangeGroupBox()
        {
            GB_CargoShip.Enabled = false;
            GB_Containers.Enabled = true;
        }

        void UpdateCargoShipInfo(int length, int width)
        {
            LBL_ShipLength.Text += " " + length.ToString();
            LBL_ShipWidth.Text += " " + width.ToString();
        }

        void UpdateContainerInfo()
        {
            LBL_AmountNormalContainers.Text = "Totaal aantal containers: " + cargoShip.ContainerCollection.AllContainers.Count;
        }

        private void BTN_RandomLengthAndWidth_Click(object sender, EventArgs e)
        {
            int length = rnd.Next(4, 7);
            int width = rnd.Next(2, 5);
            cargoShip = new CargoShip(length, width);
            UpdateCargoShipInfo(length, width);
            ChangeGroupBox();
        }

        private void BTN_SaveLengthAndWidth_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(NUD_Length.Value);
            int width = Convert.ToInt32(NUD_Width.Value);
            CargoShip cargoShip = new CargoShip(length, width);
            ChangeGroupBox();
        }

        private void BTN_AddRandomContainers_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NUD_ModifierAmount.Value; i++)
            {
                cargoShip.ContainerCollection.CreateContainer(ContainerTypes.Normal, rnd.Next(Logic.ContainerClass.MinWeight, Logic.ContainerClass.MaxWeight));
            }
            UpdateContainerInfo();
        }

        private void LBL_StartDistribution_Click(object sender, EventArgs e)
        {
            cargoShip.Distribute();
        }
    }
}
