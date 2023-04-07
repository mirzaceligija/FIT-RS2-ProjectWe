namespace ProjectWe.Desktop.Forms.Projects
{
    partial class frmActivityDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivityDetails));
            label1 = new Label();
            label10 = new Label();
            txtDescription = new TextBox();
            cmbOutputs = new ComboBox();
            dtpStartDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dtpEndDate = new DateTimePicker();
            label4 = new Label();
            txtDirBenef = new TextBox();
            label5 = new Label();
            txtIndirBenef = new TextBox();
            btnSave = new Button();
            errorProvider = new ErrorProvider(components);
            txtLocations = new Label();
            txtLocation = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(354, 89);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 10;
            label1.Text = "Output:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(14, 89);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 9;
            label10.Text = "Activity:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(14, 112);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(296, 27);
            txtDescription.TabIndex = 8;
            txtDescription.Validating += txtDescription_Validating;
            // 
            // cmbOutputs
            // 
            cmbOutputs.FormattingEnabled = true;
            cmbOutputs.Location = new Point(354, 112);
            cmbOutputs.Name = "cmbOutputs";
            cmbOutputs.Size = new Size(296, 28);
            cmbOutputs.TabIndex = 7;
            cmbOutputs.Validating += cmbOutputs_Validating;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(14, 174);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(296, 27);
            dtpStartDate.TabIndex = 11;
            dtpStartDate.Validating += dtpStartDate_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(14, 151);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 12;
            label2.Text = "Start Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(354, 151);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 14;
            label3.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(354, 174);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(296, 27);
            dtpEndDate.TabIndex = 13;
            dtpEndDate.Validating += dtpEndDate_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(14, 216);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 16;
            label4.Text = "Direct Benef...";
            // 
            // txtDirBenef
            // 
            txtDirBenef.Location = new Point(14, 239);
            txtDirBenef.Name = "txtDirBenef";
            txtDirBenef.Size = new Size(296, 27);
            txtDirBenef.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(354, 216);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 18;
            label5.Text = "Indirect Bene...";
            // 
            // txtIndirBenef
            // 
            txtIndirBenef.Location = new Point(354, 239);
            txtIndirBenef.Name = "txtIndirBenef";
            txtIndirBenef.Size = new Size(296, 27);
            txtIndirBenef.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 122, 255);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(556, 392);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // txtLocations
            // 
            txtLocations.AutoSize = true;
            txtLocations.ForeColor = SystemColors.ControlText;
            txtLocations.Location = new Point(14, 277);
            txtLocations.Name = "txtLocations";
            txtLocations.Size = new Size(72, 20);
            txtLocations.TabIndex = 32;
            txtLocations.Text = "Locations";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(14, 300);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(296, 27);
            txtLocation.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(50, 9);
            label6.Name = "label6";
            label6.Size = new Size(192, 37);
            label6.TabIndex = 33;
            label6.Text = "Activity Details";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(14, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // frmActivityDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(662, 433);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(txtLocations);
            Controls.Add(txtLocation);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(txtIndirBenef);
            Controls.Add(label4);
            Controls.Add(txtDirBenef);
            Controls.Add(label3);
            Controls.Add(dtpEndDate);
            Controls.Add(label2);
            Controls.Add(dtpStartDate);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(txtDescription);
            Controls.Add(cmbOutputs);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmActivityDetails";
            Text = "Activity Details";
            Load += frmActivityDetails_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label10;
        private TextBox txtDescription;
        private ComboBox cmbOutputs;
        private DateTimePicker dtpStartDate;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpEndDate;
        private Label label4;
        private TextBox txtDirBenef;
        private Label label5;
        private TextBox txtIndirBenef;
        private Button btnSave;
        private ErrorProvider errorProvider;
        private Label txtLocations;
        private TextBox txtLocation;
        private Label label6;
        private PictureBox pictureBox1;
    }
}