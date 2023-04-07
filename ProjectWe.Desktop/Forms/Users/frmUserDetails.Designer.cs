namespace ProjectWe.Desktop.Forms.Users
{
    partial class frmUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDetails));
            btnSave = new Button();
            txtEmail = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            txtConfirmation = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            txtUserName = new TextBox();
            label7 = new Label();
            chkRoles = new CheckedListBox();
            ck2FA = new CheckBox();
            ckPhone = new CheckBox();
            ckEmail = new CheckBox();
            errorProvider = new ErrorProvider(components);
            lblTitle = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 122, 255);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(556, 392);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(15, 239);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(295, 27);
            txtEmail.TabIndex = 7;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(15, 216);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(15, 174);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(295, 27);
            txtLastName.TabIndex = 3;
            txtLastName.Validating += txtLastName_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(14, 151);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Last name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(14, 112);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(296, 27);
            txtFirstName.TabIndex = 1;
            txtFirstName.Validating += txtFirstName_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(14, 89);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First name:";
            // 
            // txtConfirmation
            // 
            txtConfirmation.Location = new Point(354, 239);
            txtConfirmation.Name = "txtConfirmation";
            txtConfirmation.PasswordChar = '*';
            txtConfirmation.Size = new Size(296, 27);
            txtConfirmation.TabIndex = 7;
            txtConfirmation.Validating += txtConfirmation_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(354, 216);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 6;
            label5.Text = "Confirmation:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(354, 174);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(296, 27);
            txtPassword.TabIndex = 3;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(354, 151);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 2;
            label6.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(354, 112);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(296, 27);
            txtUserName.TabIndex = 1;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(354, 89);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 0;
            label7.Text = "Username:";
            // 
            // chkRoles
            // 
            chkRoles.FormattingEnabled = true;
            chkRoles.Location = new Point(354, 292);
            chkRoles.Name = "chkRoles";
            chkRoles.Size = new Size(296, 92);
            chkRoles.TabIndex = 7;
            chkRoles.ItemCheck += chkRoles_ItemCheck;
            // 
            // ck2FA
            // 
            ck2FA.AutoSize = true;
            ck2FA.Enabled = false;
            ck2FA.ForeColor = SystemColors.ControlText;
            ck2FA.Location = new Point(15, 360);
            ck2FA.Name = "ck2FA";
            ck2FA.Size = new Size(113, 24);
            ck2FA.TabIndex = 11;
            ck2FA.Text = "2FA Enabled";
            ck2FA.UseVisualStyleBackColor = true;
            // 
            // ckPhone
            // 
            ckPhone.AutoSize = true;
            ckPhone.Enabled = false;
            ckPhone.ForeColor = SystemColors.ControlText;
            ckPhone.Location = new Point(15, 325);
            ckPhone.Name = "ckPhone";
            ckPhone.Size = new Size(146, 24);
            ckPhone.TabIndex = 11;
            ckPhone.Text = "Phone Confirmed";
            ckPhone.UseVisualStyleBackColor = true;
            // 
            // ckEmail
            // 
            ckEmail.AutoSize = true;
            ckEmail.Enabled = false;
            ckEmail.ForeColor = SystemColors.ControlText;
            ckEmail.Location = new Point(15, 292);
            ckEmail.Name = "ckEmail";
            ckEmail.Size = new Size(142, 24);
            ckEmail.TabIndex = 0;
            ckEmail.Text = "Email Confirmed";
            ckEmail.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(48, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(169, 37);
            lblTitle.TabIndex = 36;
            lblTitle.Text = "Users Details";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // frmUserDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(662, 433);
            Controls.Add(ck2FA);
            Controls.Add(txtConfirmation);
            Controls.Add(ckPhone);
            Controls.Add(ckEmail);
            Controls.Add(label5);
            Controls.Add(chkRoles);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtUserName);
            Controls.Add(lblTitle);
            Controls.Add(label7);
            Controls.Add(txtLastName);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUserDetails";
            Text = "User Details";
            Load += frmUserDetails_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
        private TextBox txtConfirmation;
        private Label label5;
        private TextBox txtPassword;
        private Label label6;
        private TextBox txtUserName;
        private Label label7;
        private CheckedListBox chkRoles;
        private CheckBox ckEmail;
        private CheckBox ckPhone;
        private CheckBox ck2FA;
        private ErrorProvider errorProvider;
        private PictureBox pictureBox2;
        private Label lblTitle;
    }
}