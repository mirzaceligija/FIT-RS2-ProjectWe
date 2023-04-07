namespace ProjectWe.Desktop.Forms.Projects
{
    partial class frmOutputDetails
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
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label1 = new Label();
            label10 = new Label();
            txtDescription = new TextBox();
            cmbObjectives = new ComboBox();
            label5 = new Label();
            txtMeansOfVerification = new TextBox();
            label4 = new Label();
            txtIndicators = new TextBox();
            btnSave = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(48, 9);
            label6.Name = "label6";
            label6.Size = new Size(189, 37);
            label6.TabIndex = 34;
            label6.Text = "Output Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(352, 68);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 38;
            label1.Text = "*Objective:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(12, 68);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 37;
            label10.Text = "*Output:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 91);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(296, 27);
            txtDescription.TabIndex = 36;
            txtDescription.Validating += txtDescription_Validating;
            // 
            // cmbObjectives
            // 
            cmbObjectives.FormattingEnabled = true;
            cmbObjectives.Location = new Point(352, 91);
            cmbObjectives.Name = "cmbObjectives";
            cmbObjectives.Size = new Size(296, 28);
            cmbObjectives.TabIndex = 35;
            cmbObjectives.Validating += cmbObjectives_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(352, 136);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 42;
            label5.Text = "Means Of Verification:";
            // 
            // txtMeansOfVerification
            // 
            txtMeansOfVerification.Location = new Point(352, 159);
            txtMeansOfVerification.Name = "txtMeansOfVerification";
            txtMeansOfVerification.Size = new Size(296, 27);
            txtMeansOfVerification.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(12, 136);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 40;
            label4.Text = "Indicators:";
            // 
            // txtIndicators
            // 
            txtIndicators.Location = new Point(12, 159);
            txtIndicators.Name = "txtIndicators";
            txtIndicators.Size = new Size(296, 27);
            txtIndicators.TabIndex = 39;
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
            btnSave.TabIndex = 43;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmOutputDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(662, 433);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(txtMeansOfVerification);
            Controls.Add(label4);
            Controls.Add(txtIndicators);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(txtDescription);
            Controls.Add(cmbObjectives);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Name = "frmOutputDetails";
            Text = "Output Details";
            Load += frmOutputDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label6;
        private Label label1;
        private Label label10;
        private TextBox txtDescription;
        private ComboBox cmbObjectives;
        private Label label5;
        private TextBox txtMeansOfVerification;
        private Label label4;
        private TextBox txtIndicators;
        private Button btnSave;
        private ErrorProvider errorProvider;
    }
}