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
            grpInfo = new GroupBox();
            txtEmail = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtConfirmation = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            txtUserName = new TextBox();
            label7 = new Label();
            chkRoles = new CheckedListBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ck2FA = new CheckBox();
            ckPhone = new CheckBox();
            ckEmail = new CheckBox();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            errorProvider = new ErrorProvider(components);
            grpInfo.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(694, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(txtEmail);
            grpInfo.Controls.Add(label4);
            grpInfo.Controls.Add(txtLastName);
            grpInfo.Controls.Add(label2);
            grpInfo.Controls.Add(txtFirstName);
            grpInfo.Controls.Add(label1);
            grpInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpInfo.ForeColor = SystemColors.ControlLightLight;
            grpInfo.Location = new Point(12, 71);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(384, 135);
            grpInfo.TabIndex = 1;
            grpInfo.TabStop = false;
            grpInfo.Text = "Personal Info";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(113, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 27);
            txtEmail.TabIndex = 7;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 95);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(113, 59);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(265, 27);
            txtLastName.TabIndex = 3;
            txtLastName.Validating += txtLastName_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "Last name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(113, 26);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(265, 27);
            txtFirstName.TabIndex = 1;
            txtFirstName.Validating += txtFirstName_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "First name:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtConfirmation);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(403, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 135);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Auth";
            // 
            // txtConfirmation
            // 
            txtConfirmation.Location = new Point(113, 92);
            txtConfirmation.Name = "txtConfirmation";
            txtConfirmation.PasswordChar = '*';
            txtConfirmation.Size = new Size(266, 27);
            txtConfirmation.TabIndex = 7;
            txtConfirmation.Validating += txtConfirmation_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 95);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 6;
            label5.Text = "Confirmation:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(113, 59);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(266, 27);
            txtPassword.TabIndex = 3;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(12, 62);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 2;
            label6.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(113, 26);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(266, 27);
            txtUserName.TabIndex = 1;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(12, 29);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 0;
            label7.Text = "Username:";
            // 
            // chkRoles
            // 
            chkRoles.FormattingEnabled = true;
            chkRoles.Location = new Point(12, 26);
            chkRoles.Name = "chkRoles";
            chkRoles.Size = new Size(367, 92);
            chkRoles.TabIndex = 7;
            chkRoles.ItemCheck += chkRoles_ItemCheck;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkRoles);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(403, 212);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 125);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Roles";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ck2FA);
            groupBox3.Controls.Add(ckPhone);
            groupBox3.Controls.Add(ckEmail);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.ControlLightLight;
            groupBox3.Location = new Point(13, 212);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(384, 125);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Account (read-only)";
            // 
            // ck2FA
            // 
            ck2FA.AutoSize = true;
            ck2FA.Enabled = false;
            ck2FA.ForeColor = SystemColors.ControlLightLight;
            ck2FA.Location = new Point(12, 86);
            ck2FA.Name = "ck2FA";
            ck2FA.Size = new Size(117, 24);
            ck2FA.TabIndex = 11;
            ck2FA.Text = "2FA Enabled";
            ck2FA.UseVisualStyleBackColor = true;
            // 
            // ckPhone
            // 
            ckPhone.AutoSize = true;
            ckPhone.Enabled = false;
            ckPhone.ForeColor = SystemColors.ControlLightLight;
            ckPhone.Location = new Point(12, 56);
            ckPhone.Name = "ckPhone";
            ckPhone.Size = new Size(153, 24);
            ckPhone.TabIndex = 11;
            ckPhone.Text = "Phone Confirmed";
            ckPhone.UseVisualStyleBackColor = true;
            // 
            // ckEmail
            // 
            ckEmail.AutoSize = true;
            ckEmail.Enabled = false;
            ckEmail.ForeColor = SystemColors.ControlLightLight;
            ckEmail.Location = new Point(12, 26);
            ckEmail.Name = "ckEmail";
            ckEmail.Size = new Size(147, 24);
            ckEmail.TabIndex = 0;
            ckEmail.Text = "Email Confirmed";
            ckEmail.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(58, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(95, 28);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "New User";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmUserDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grpInfo);
            Controls.Add(btnSave);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUserDetails";
            Text = "User Details";
            Load += frmUserDetails_Load;
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private GroupBox grpInfo;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtConfirmation;
        private Label label5;
        private TextBox txtPassword;
        private Label label6;
        private TextBox txtUserName;
        private Label label7;
        private CheckedListBox chkRoles;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private CheckBox ckEmail;
        private CheckBox ckPhone;
        private CheckBox ck2FA;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private ErrorProvider errorProvider;
    }
}