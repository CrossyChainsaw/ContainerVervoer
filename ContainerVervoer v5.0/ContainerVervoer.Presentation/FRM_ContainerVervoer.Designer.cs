
namespace ContainerVervoer.Presentation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_ResetEverything = new System.Windows.Forms.Button();
            this.LBL_StartDistribution = new System.Windows.Forms.Button();
            this.LBL_TotalContainerWeight = new System.Windows.Forms.Label();
            this.LBL_AmountValuebaleContainer = new System.Windows.Forms.Label();
            this.LBL_AmountNormalContainers = new System.Windows.Forms.Label();
            this.LBL_AmountCoolContainers = new System.Windows.Forms.Label();
            this.LBL_TotalAmountContainers = new System.Windows.Forms.Label();
            this.LBL_ShipLength = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.RB_NormalContainer = new System.Windows.Forms.RadioButton();
            this.BTN_AddRandomContainers = new System.Windows.Forms.Button();
            this.BTN_AddContainer = new System.Windows.Forms.Button();
            this.RB_CoolContainer = new System.Windows.Forms.RadioButton();
            this.GB_CargoShipInfo = new System.Windows.Forms.GroupBox();
            this.LBL_ShipWidth = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GB_Containers = new System.Windows.Forms.GroupBox();
            this.NUD_ModifierAmount = new System.Windows.Forms.NumericUpDown();
            this.BTN_RandomLengthAndWidth = new System.Windows.Forms.Button();
            this.BTN_SaveLengthAndWidth = new System.Windows.Forms.Button();
            this.NUD_Width = new System.Windows.Forms.NumericUpDown();
            this.NUD_Length = new System.Windows.Forms.NumericUpDown();
            this.LBL_Breedte = new System.Windows.Forms.Label();
            this.LBL_Length = new System.Windows.Forms.Label();
            this.GB_CargoShip = new System.Windows.Forms.GroupBox();
            this.GB_CargoShipInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.GB_Containers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ModifierAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Length)).BeginInit();
            this.GB_CargoShip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_ResetEverything
            // 
            this.BTN_ResetEverything.Location = new System.Drawing.Point(9, 172);
            this.BTN_ResetEverything.Name = "BTN_ResetEverything";
            this.BTN_ResetEverything.Size = new System.Drawing.Size(367, 26);
            this.BTN_ResetEverything.TabIndex = 11;
            this.BTN_ResetEverything.Text = "Reset alle waarden";
            this.BTN_ResetEverything.UseVisualStyleBackColor = true;
            // 
            // LBL_StartDistribution
            // 
            this.LBL_StartDistribution.Location = new System.Drawing.Point(9, 140);
            this.LBL_StartDistribution.Name = "LBL_StartDistribution";
            this.LBL_StartDistribution.Size = new System.Drawing.Size(367, 26);
            this.LBL_StartDistribution.TabIndex = 10;
            this.LBL_StartDistribution.Text = "Begin met verdelen";
            this.LBL_StartDistribution.UseVisualStyleBackColor = true;
            this.LBL_StartDistribution.Click += new System.EventHandler(this.LBL_StartDistribution_Click);
            // 
            // LBL_TotalContainerWeight
            // 
            this.LBL_TotalContainerWeight.AutoSize = true;
            this.LBL_TotalContainerWeight.Location = new System.Drawing.Point(6, 120);
            this.LBL_TotalContainerWeight.Name = "LBL_TotalContainerWeight";
            this.LBL_TotalContainerWeight.Size = new System.Drawing.Size(166, 17);
            this.LBL_TotalContainerWeight.TabIndex = 6;
            this.LBL_TotalContainerWeight.Text = "Totaal container gewicht:";
            // 
            // LBL_AmountValuebaleContainer
            // 
            this.LBL_AmountValuebaleContainer.AutoSize = true;
            this.LBL_AmountValuebaleContainer.Location = new System.Drawing.Point(6, 103);
            this.LBL_AmountValuebaleContainer.Name = "LBL_AmountValuebaleContainer";
            this.LBL_AmountValuebaleContainer.Size = new System.Drawing.Size(201, 17);
            this.LBL_AmountValuebaleContainer.TabIndex = 5;
            this.LBL_AmountValuebaleContainer.Text = "Aantal waardevolle containers:";
            // 
            // LBL_AmountNormalContainers
            // 
            this.LBL_AmountNormalContainers.AutoSize = true;
            this.LBL_AmountNormalContainers.Location = new System.Drawing.Point(6, 86);
            this.LBL_AmountNormalContainers.Name = "LBL_AmountNormalContainers";
            this.LBL_AmountNormalContainers.Size = new System.Drawing.Size(177, 17);
            this.LBL_AmountNormalContainers.TabIndex = 4;
            this.LBL_AmountNormalContainers.Text = "Aantal normale containers:";
            // 
            // LBL_AmountCoolContainers
            // 
            this.LBL_AmountCoolContainers.AutoSize = true;
            this.LBL_AmountCoolContainers.Location = new System.Drawing.Point(6, 69);
            this.LBL_AmountCoolContainers.Name = "LBL_AmountCoolContainers";
            this.LBL_AmountCoolContainers.Size = new System.Drawing.Size(152, 17);
            this.LBL_AmountCoolContainers.TabIndex = 3;
            this.LBL_AmountCoolContainers.Text = "Aantal koel containers:";
            // 
            // LBL_TotalAmountContainers
            // 
            this.LBL_TotalAmountContainers.AutoSize = true;
            this.LBL_TotalAmountContainers.Location = new System.Drawing.Point(6, 52);
            this.LBL_TotalAmountContainers.Name = "LBL_TotalAmountContainers";
            this.LBL_TotalAmountContainers.Size = new System.Drawing.Size(165, 17);
            this.LBL_TotalAmountContainers.TabIndex = 2;
            this.LBL_TotalAmountContainers.Text = "Totaal aantal containers:";
            // 
            // LBL_ShipLength
            // 
            this.LBL_ShipLength.AutoSize = true;
            this.LBL_ShipLength.Location = new System.Drawing.Point(6, 18);
            this.LBL_ShipLength.Name = "LBL_ShipLength";
            this.LBL_ShipLength.Size = new System.Drawing.Size(90, 17);
            this.LBL_ShipLength.TabIndex = 0;
            this.LBL_ShipLength.Text = "Schip lengte:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 126);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 21);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Waardevol";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // RB_NormalContainer
            // 
            this.RB_NormalContainer.AutoSize = true;
            this.RB_NormalContainer.Location = new System.Drawing.Point(9, 99);
            this.RB_NormalContainer.Name = "RB_NormalContainer";
            this.RB_NormalContainer.Size = new System.Drawing.Size(82, 21);
            this.RB_NormalContainer.TabIndex = 8;
            this.RB_NormalContainer.TabStop = true;
            this.RB_NormalContainer.Text = "Normaal";
            this.RB_NormalContainer.UseVisualStyleBackColor = true;
            // 
            // BTN_AddRandomContainers
            // 
            this.BTN_AddRandomContainers.Location = new System.Drawing.Point(3, 181);
            this.BTN_AddRandomContainers.Name = "BTN_AddRandomContainers";
            this.BTN_AddRandomContainers.Size = new System.Drawing.Size(181, 26);
            this.BTN_AddRandomContainers.TabIndex = 5;
            this.BTN_AddRandomContainers.Text = "Random";
            this.BTN_AddRandomContainers.UseVisualStyleBackColor = true;
            this.BTN_AddRandomContainers.Click += new System.EventHandler(this.BTN_AddRandomContainers_Click);
            // 
            // BTN_AddContainer
            // 
            this.BTN_AddContainer.Location = new System.Drawing.Point(3, 153);
            this.BTN_AddContainer.Name = "BTN_AddContainer";
            this.BTN_AddContainer.Size = new System.Drawing.Size(181, 26);
            this.BTN_AddContainer.TabIndex = 4;
            this.BTN_AddContainer.Text = "Voeg toe";
            this.BTN_AddContainer.UseVisualStyleBackColor = true;
            // 
            // RB_CoolContainer
            // 
            this.RB_CoolContainer.AutoSize = true;
            this.RB_CoolContainer.Location = new System.Drawing.Point(9, 72);
            this.RB_CoolContainer.Name = "RB_CoolContainer";
            this.RB_CoolContainer.Size = new System.Drawing.Size(57, 21);
            this.RB_CoolContainer.TabIndex = 7;
            this.RB_CoolContainer.TabStop = true;
            this.RB_CoolContainer.Text = "Koel";
            this.RB_CoolContainer.UseVisualStyleBackColor = true;
            // 
            // GB_CargoShipInfo
            // 
            this.GB_CargoShipInfo.Controls.Add(this.BTN_ResetEverything);
            this.GB_CargoShipInfo.Controls.Add(this.LBL_StartDistribution);
            this.GB_CargoShipInfo.Controls.Add(this.LBL_TotalContainerWeight);
            this.GB_CargoShipInfo.Controls.Add(this.LBL_AmountValuebaleContainer);
            this.GB_CargoShipInfo.Controls.Add(this.LBL_AmountNormalContainers);
            this.GB_CargoShipInfo.Controls.Add(this.LBL_AmountCoolContainers);
            this.GB_CargoShipInfo.Controls.Add(this.LBL_TotalAmountContainers);
            this.GB_CargoShipInfo.Controls.Add(this.LBL_ShipWidth);
            this.GB_CargoShipInfo.Controls.Add(this.LBL_ShipLength);
            this.GB_CargoShipInfo.Location = new System.Drawing.Point(12, 231);
            this.GB_CargoShipInfo.Name = "GB_CargoShipInfo";
            this.GB_CargoShipInfo.Size = new System.Drawing.Size(382, 207);
            this.GB_CargoShipInfo.TabIndex = 10;
            this.GB_CargoShipInfo.TabStop = false;
            this.GB_CargoShipInfo.Text = "Vracht Schip Informatie";
            // 
            // LBL_ShipWidth
            // 
            this.LBL_ShipWidth.AutoSize = true;
            this.LBL_ShipWidth.Location = new System.Drawing.Point(6, 35);
            this.LBL_ShipWidth.Name = "LBL_ShipWidth";
            this.LBL_ShipWidth.Size = new System.Drawing.Size(100, 17);
            this.LBL_ShipWidth.TabIndex = 1;
            this.LBL_ShipWidth.Text = "Schip breedte:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(70, 44);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(114, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gewicht";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aantal";
            // 
            // GB_Containers
            // 
            this.GB_Containers.Controls.Add(this.radioButton1);
            this.GB_Containers.Controls.Add(this.RB_NormalContainer);
            this.GB_Containers.Controls.Add(this.BTN_AddRandomContainers);
            this.GB_Containers.Controls.Add(this.BTN_AddContainer);
            this.GB_Containers.Controls.Add(this.RB_CoolContainer);
            this.GB_Containers.Controls.Add(this.numericUpDown1);
            this.GB_Containers.Controls.Add(this.NUD_ModifierAmount);
            this.GB_Containers.Controls.Add(this.label1);
            this.GB_Containers.Controls.Add(this.label2);
            this.GB_Containers.Enabled = false;
            this.GB_Containers.Location = new System.Drawing.Point(206, 12);
            this.GB_Containers.Name = "GB_Containers";
            this.GB_Containers.Size = new System.Drawing.Size(188, 213);
            this.GB_Containers.TabIndex = 9;
            this.GB_Containers.TabStop = false;
            this.GB_Containers.Text = "Containers";
            // 
            // NUD_ModifierAmount
            // 
            this.NUD_ModifierAmount.Location = new System.Drawing.Point(70, 16);
            this.NUD_ModifierAmount.Name = "NUD_ModifierAmount";
            this.NUD_ModifierAmount.Size = new System.Drawing.Size(114, 22);
            this.NUD_ModifierAmount.TabIndex = 2;
            // 
            // BTN_RandomLengthAndWidth
            // 
            this.BTN_RandomLengthAndWidth.Location = new System.Drawing.Point(3, 99);
            this.BTN_RandomLengthAndWidth.Name = "BTN_RandomLengthAndWidth";
            this.BTN_RandomLengthAndWidth.Size = new System.Drawing.Size(181, 26);
            this.BTN_RandomLengthAndWidth.TabIndex = 5;
            this.BTN_RandomLengthAndWidth.Text = "Random";
            this.BTN_RandomLengthAndWidth.UseVisualStyleBackColor = true;
            this.BTN_RandomLengthAndWidth.Click += new System.EventHandler(this.BTN_RandomLengthAndWidth_Click);
            // 
            // BTN_SaveLengthAndWidth
            // 
            this.BTN_SaveLengthAndWidth.Location = new System.Drawing.Point(3, 69);
            this.BTN_SaveLengthAndWidth.Name = "BTN_SaveLengthAndWidth";
            this.BTN_SaveLengthAndWidth.Size = new System.Drawing.Size(181, 26);
            this.BTN_SaveLengthAndWidth.TabIndex = 4;
            this.BTN_SaveLengthAndWidth.Text = "Opslaan";
            this.BTN_SaveLengthAndWidth.UseVisualStyleBackColor = true;
            this.BTN_SaveLengthAndWidth.Click += new System.EventHandler(this.BTN_SaveLengthAndWidth_Click);
            // 
            // NUD_Width
            // 
            this.NUD_Width.Location = new System.Drawing.Point(70, 44);
            this.NUD_Width.Name = "NUD_Width";
            this.NUD_Width.Size = new System.Drawing.Size(114, 22);
            this.NUD_Width.TabIndex = 3;
            // 
            // NUD_Length
            // 
            this.NUD_Length.Location = new System.Drawing.Point(70, 16);
            this.NUD_Length.Name = "NUD_Length";
            this.NUD_Length.Size = new System.Drawing.Size(114, 22);
            this.NUD_Length.TabIndex = 2;
            // 
            // LBL_Breedte
            // 
            this.LBL_Breedte.AutoSize = true;
            this.LBL_Breedte.Location = new System.Drawing.Point(6, 46);
            this.LBL_Breedte.Name = "LBL_Breedte";
            this.LBL_Breedte.Size = new System.Drawing.Size(58, 17);
            this.LBL_Breedte.TabIndex = 1;
            this.LBL_Breedte.Text = "Breedte";
            // 
            // LBL_Length
            // 
            this.LBL_Length.AutoSize = true;
            this.LBL_Length.Location = new System.Drawing.Point(6, 18);
            this.LBL_Length.Name = "LBL_Length";
            this.LBL_Length.Size = new System.Drawing.Size(52, 17);
            this.LBL_Length.TabIndex = 0;
            this.LBL_Length.Text = "Lengte";
            // 
            // GB_CargoShip
            // 
            this.GB_CargoShip.Controls.Add(this.BTN_RandomLengthAndWidth);
            this.GB_CargoShip.Controls.Add(this.BTN_SaveLengthAndWidth);
            this.GB_CargoShip.Controls.Add(this.NUD_Width);
            this.GB_CargoShip.Controls.Add(this.NUD_Length);
            this.GB_CargoShip.Controls.Add(this.LBL_Breedte);
            this.GB_CargoShip.Controls.Add(this.LBL_Length);
            this.GB_CargoShip.Location = new System.Drawing.Point(12, 12);
            this.GB_CargoShip.Name = "GB_CargoShip";
            this.GB_CargoShip.Size = new System.Drawing.Size(188, 132);
            this.GB_CargoShip.TabIndex = 8;
            this.GB_CargoShip.TabStop = false;
            this.GB_CargoShip.Text = "Vracht Schip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.GB_CargoShipInfo);
            this.Controls.Add(this.GB_Containers);
            this.Controls.Add(this.GB_CargoShip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GB_CargoShipInfo.ResumeLayout(false);
            this.GB_CargoShipInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.GB_Containers.ResumeLayout(false);
            this.GB_Containers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ModifierAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Length)).EndInit();
            this.GB_CargoShip.ResumeLayout(false);
            this.GB_CargoShip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_ResetEverything;
        private System.Windows.Forms.Button LBL_StartDistribution;
        private System.Windows.Forms.Label LBL_TotalContainerWeight;
        private System.Windows.Forms.Label LBL_AmountValuebaleContainer;
        private System.Windows.Forms.Label LBL_AmountNormalContainers;
        private System.Windows.Forms.Label LBL_AmountCoolContainers;
        private System.Windows.Forms.Label LBL_TotalAmountContainers;
        private System.Windows.Forms.Label LBL_ShipLength;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton RB_NormalContainer;
        private System.Windows.Forms.Button BTN_AddRandomContainers;
        private System.Windows.Forms.Button BTN_AddContainer;
        private System.Windows.Forms.RadioButton RB_CoolContainer;
        private System.Windows.Forms.GroupBox GB_CargoShipInfo;
        private System.Windows.Forms.Label LBL_ShipWidth;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GB_Containers;
        private System.Windows.Forms.NumericUpDown NUD_ModifierAmount;
        private System.Windows.Forms.Button BTN_RandomLengthAndWidth;
        private System.Windows.Forms.Button BTN_SaveLengthAndWidth;
        private System.Windows.Forms.NumericUpDown NUD_Width;
        private System.Windows.Forms.NumericUpDown NUD_Length;
        private System.Windows.Forms.Label LBL_Breedte;
        private System.Windows.Forms.Label LBL_Length;
        private System.Windows.Forms.GroupBox GB_CargoShip;
    }
}

