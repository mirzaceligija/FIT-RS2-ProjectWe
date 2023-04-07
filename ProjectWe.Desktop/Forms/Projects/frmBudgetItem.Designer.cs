namespace ProjectWe.Desktop.Forms.Projects
{
    partial class frmBudgetItem
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBudgetItem));
            cmbActivities = new ComboBox();
            txtDescription = new TextBox();
            label10 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
            numItemCost = new NumericUpDown();
            numQty = new NumericUpDown();
            numTotalCost = new NumericUpDown();
            errorProvider = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numItemCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTotalCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbActivities
            // 
            cmbActivities.FormattingEnabled = true;
            cmbActivities.Location = new Point(354, 112);
            cmbActivities.Name = "cmbActivities";
            cmbActivities.Size = new Size(296, 28);
            cmbActivities.TabIndex = 0;
            cmbActivities.Validating += cmbActivities_Validating;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(14, 112);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(296, 27);
            txtDescription.TabIndex = 1;
            txtDescription.Validating += txtDescription_Validating;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(14, 89);
            label10.Name = "label10";
            label10.Size = new Size(86, 20);
            label10.TabIndex = 5;
            label10.Text = "Item Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(354, 89);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 6;
            label1.Text = "Activity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(14, 151);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 7;
            label2.Text = "Item Cost:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(354, 151);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 8;
            label3.Text = "Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(354, 216);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 9;
            label4.Text = "Total Cost:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 122, 255);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ControlLight;
            btnSave.Location = new Point(556, 392);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // numItemCost
            // 
            numItemCost.DecimalPlaces = 2;
            numItemCost.Location = new Point(14, 174);
            numItemCost.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numItemCost.Name = "numItemCost";
            numItemCost.Size = new Size(296, 27);
            numItemCost.TabIndex = 30;
            numItemCost.ValueChanged += numItemCost_ValueChanged;
            // 
            // numQty
            // 
            numQty.Location = new Point(354, 174);
            numQty.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQty.Name = "numQty";
            numQty.Size = new Size(296, 27);
            numQty.TabIndex = 31;
            numQty.ValueChanged += numQty_ValueChanged;
            // 
            // numTotalCost
            // 
            numTotalCost.DecimalPlaces = 2;
            numTotalCost.Enabled = false;
            numTotalCost.Location = new Point(354, 239);
            numTotalCost.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numTotalCost.Name = "numTotalCost";
            numTotalCost.ReadOnly = true;
            numTotalCost.Size = new Size(296, 27);
            numTotalCost.TabIndex = 32;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(48, 8);
            label6.Name = "label6";
            label6.Size = new Size(162, 37);
            label6.TabIndex = 37;
            label6.Text = "Budget Item";
            // 
            // frmBudgetItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(662, 433);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(numTotalCost);
            Controls.Add(numQty);
            Controls.Add(numItemCost);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(txtDescription);
            Controls.Add(cmbActivities);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBudgetItem";
            Text = "Budget Item";
            Load += frmBudgetItem_Load;
            ((System.ComponentModel.ISupportInitialize)numItemCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTotalCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbActivities;
        private TextBox txtDescription;
        private Label label10;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSave;
        private NumericUpDown numItemCost;
        private NumericUpDown numQty;
        private NumericUpDown numTotalCost;
        private ErrorProvider errorProvider;
        private PictureBox pictureBox1;
        private Label label6;
    }
}