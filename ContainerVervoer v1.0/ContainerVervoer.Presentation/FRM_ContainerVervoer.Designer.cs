
namespace ContainerVervoer.Presentation
{
    partial class FRM_ContainerVervoer
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
            this.GB_AddContainers = new System.Windows.Forms.GroupBox();
            this.BTN_AddContainer = new System.Windows.Forms.Button();
            this.NUD_Weight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB_Valuable = new System.Windows.Forms.RadioButton();
            this.RB_Cool = new System.Windows.Forms.RadioButton();
            this.RB_Normal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_Amount = new System.Windows.Forms.NumericUpDown();
            this.LB_EventTracker = new System.Windows.Forms.ListBox();
            this.GB_ShipSize = new System.Windows.Forms.GroupBox();
            this.BTN_ConfirmShipSize = new System.Windows.Forms.Button();
            this.NUD_Width = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NUD_Length = new System.Windows.Forms.NumericUpDown();
            this.BTN_Distribute = new System.Windows.Forms.Button();
            this.GB_AddContainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Weight)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Amount)).BeginInit();
            this.GB_ShipSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Length)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_AddContainers
            // 
            this.GB_AddContainers.Controls.Add(this.BTN_AddContainer);
            this.GB_AddContainers.Controls.Add(this.NUD_Weight);
            this.GB_AddContainers.Controls.Add(this.label2);
            this.GB_AddContainers.Controls.Add(this.groupBox2);
            this.GB_AddContainers.Controls.Add(this.label1);
            this.GB_AddContainers.Controls.Add(this.NUD_Amount);
            this.GB_AddContainers.Enabled = false;
            this.GB_AddContainers.Location = new System.Drawing.Point(246, 12);
            this.GB_AddContainers.Name = "GB_AddContainers";
            this.GB_AddContainers.Size = new System.Drawing.Size(228, 242);
            this.GB_AddContainers.TabIndex = 2;
            this.GB_AddContainers.TabStop = false;
            this.GB_AddContainers.Text = "Container toevoegen";
            // 
            // BTN_AddContainer
            // 
            this.BTN_AddContainer.Location = new System.Drawing.Point(9, 205);
            this.BTN_AddContainer.Name = "BTN_AddContainer";
            this.BTN_AddContainer.Size = new System.Drawing.Size(208, 31);
            this.BTN_AddContainer.TabIndex = 5;
            this.BTN_AddContainer.Text = "Voeg toe";
            this.BTN_AddContainer.UseVisualStyleBackColor = true;
            this.BTN_AddContainer.Click += new System.EventHandler(this.BTN_AddContainer_Click);
            // 
            // NUD_Weight
            // 
            this.NUD_Weight.Location = new System.Drawing.Point(114, 56);
            this.NUD_Weight.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.NUD_Weight.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.NUD_Weight.Name = "NUD_Weight";
            this.NUD_Weight.Size = new System.Drawing.Size(103, 22);
            this.NUD_Weight.TabIndex = 4;
            this.NUD_Weight.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Totaal Gewicht:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB_Valuable);
            this.groupBox2.Controls.Add(this.RB_Cool);
            this.groupBox2.Controls.Add(this.RB_Normal);
            this.groupBox2.Location = new System.Drawing.Point(9, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Soort container";
            // 
            // RB_Valuable
            // 
            this.RB_Valuable.AutoSize = true;
            this.RB_Valuable.Location = new System.Drawing.Point(6, 75);
            this.RB_Valuable.Name = "RB_Valuable";
            this.RB_Valuable.Size = new System.Drawing.Size(97, 21);
            this.RB_Valuable.TabIndex = 4;
            this.RB_Valuable.TabStop = true;
            this.RB_Valuable.Text = "Waardevol";
            this.RB_Valuable.UseVisualStyleBackColor = true;
            // 
            // RB_Cool
            // 
            this.RB_Cool.AutoSize = true;
            this.RB_Cool.Location = new System.Drawing.Point(6, 48);
            this.RB_Cool.Name = "RB_Cool";
            this.RB_Cool.Size = new System.Drawing.Size(57, 21);
            this.RB_Cool.TabIndex = 3;
            this.RB_Cool.TabStop = true;
            this.RB_Cool.Text = "Koel";
            this.RB_Cool.UseVisualStyleBackColor = true;
            // 
            // RB_Normal
            // 
            this.RB_Normal.AutoSize = true;
            this.RB_Normal.Location = new System.Drawing.Point(6, 21);
            this.RB_Normal.Name = "RB_Normal";
            this.RB_Normal.Size = new System.Drawing.Size(82, 21);
            this.RB_Normal.TabIndex = 2;
            this.RB_Normal.TabStop = true;
            this.RB_Normal.Text = "Normaal";
            this.RB_Normal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoeveelheid:";
            // 
            // NUD_Amount
            // 
            this.NUD_Amount.Location = new System.Drawing.Point(114, 27);
            this.NUD_Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Amount.Name = "NUD_Amount";
            this.NUD_Amount.Size = new System.Drawing.Size(103, 22);
            this.NUD_Amount.TabIndex = 0;
            this.NUD_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LB_EventTracker
            // 
            this.LB_EventTracker.FormattingEnabled = true;
            this.LB_EventTracker.ItemHeight = 16;
            this.LB_EventTracker.Location = new System.Drawing.Point(12, 260);
            this.LB_EventTracker.Name = "LB_EventTracker";
            this.LB_EventTracker.Size = new System.Drawing.Size(462, 228);
            this.LB_EventTracker.TabIndex = 3;
            // 
            // GB_ShipSize
            // 
            this.GB_ShipSize.Controls.Add(this.BTN_ConfirmShipSize);
            this.GB_ShipSize.Controls.Add(this.NUD_Width);
            this.GB_ShipSize.Controls.Add(this.label3);
            this.GB_ShipSize.Controls.Add(this.label4);
            this.GB_ShipSize.Controls.Add(this.NUD_Length);
            this.GB_ShipSize.Location = new System.Drawing.Point(12, 12);
            this.GB_ShipSize.Name = "GB_ShipSize";
            this.GB_ShipSize.Size = new System.Drawing.Size(228, 124);
            this.GB_ShipSize.TabIndex = 6;
            this.GB_ShipSize.TabStop = false;
            this.GB_ShipSize.Text = "Schip afmetingen (in containers)";
            // 
            // BTN_ConfirmShipSize
            // 
            this.BTN_ConfirmShipSize.Location = new System.Drawing.Point(6, 84);
            this.BTN_ConfirmShipSize.Name = "BTN_ConfirmShipSize";
            this.BTN_ConfirmShipSize.Size = new System.Drawing.Size(216, 31);
            this.BTN_ConfirmShipSize.TabIndex = 5;
            this.BTN_ConfirmShipSize.Text = "Opslaan";
            this.BTN_ConfirmShipSize.UseVisualStyleBackColor = true;
            this.BTN_ConfirmShipSize.Click += new System.EventHandler(this.BTN_ConfirmShipSize_Click);
            // 
            // NUD_Width
            // 
            this.NUD_Width.Location = new System.Drawing.Point(68, 56);
            this.NUD_Width.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.NUD_Width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Width.Name = "NUD_Width";
            this.NUD_Width.Size = new System.Drawing.Size(103, 22);
            this.NUD_Width.TabIndex = 4;
            this.NUD_Width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Breedte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lengte:";
            // 
            // NUD_Length
            // 
            this.NUD_Length.Location = new System.Drawing.Point(68, 27);
            this.NUD_Length.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.NUD_Length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Length.Name = "NUD_Length";
            this.NUD_Length.Size = new System.Drawing.Size(103, 22);
            this.NUD_Length.TabIndex = 0;
            this.NUD_Length.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BTN_Distribute
            // 
            this.BTN_Distribute.Enabled = false;
            this.BTN_Distribute.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Distribute.Location = new System.Drawing.Point(12, 142);
            this.BTN_Distribute.Name = "BTN_Distribute";
            this.BTN_Distribute.Size = new System.Drawing.Size(228, 112);
            this.BTN_Distribute.TabIndex = 6;
            this.BTN_Distribute.Text = "LETSGO";
            this.BTN_Distribute.UseVisualStyleBackColor = true;
            this.BTN_Distribute.Click += new System.EventHandler(this.BTN_Distribute_Click);
            // 
            // FRM_ContainerVervoer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 553);
            this.Controls.Add(this.BTN_Distribute);
            this.Controls.Add(this.GB_ShipSize);
            this.Controls.Add(this.LB_EventTracker);
            this.Controls.Add(this.GB_AddContainers);
            this.Name = "FRM_ContainerVervoer";
            this.Text = "Form1";
            this.GB_AddContainers.ResumeLayout(false);
            this.GB_AddContainers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Weight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Amount)).EndInit();
            this.GB_ShipSize.ResumeLayout(false);
            this.GB_ShipSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Length)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_AddContainers;
        private System.Windows.Forms.NumericUpDown NUD_Weight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB_Valuable;
        private System.Windows.Forms.RadioButton RB_Cool;
        private System.Windows.Forms.RadioButton RB_Normal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_Amount;
        private System.Windows.Forms.Button BTN_AddContainer;
        private System.Windows.Forms.ListBox LB_EventTracker;
        private System.Windows.Forms.GroupBox GB_ShipSize;
        private System.Windows.Forms.Button BTN_ConfirmShipSize;
        private System.Windows.Forms.NumericUpDown NUD_Width;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUD_Length;
        private System.Windows.Forms.Button BTN_Distribute;
    }
}

