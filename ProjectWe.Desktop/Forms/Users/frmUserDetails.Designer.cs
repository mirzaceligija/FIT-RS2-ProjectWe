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
            btnSave.Location = new Point(486, 294);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(13, 179);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 23);
            txtEmail.TabIndex = 3;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(13, 162);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(13, 130);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(259, 23);
            txtLastName.TabIndex = 2;
            txtLastName.Validating += txtLastName_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Last name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 84);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(260, 23);
            txtFirstName.TabIndex = 1;
            txtFirstName.Validating += txtFirstName_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "First name:";
            // 
            // txtConfirmation
            // 
            txtConfirmation.Location = new Point(310, 179);
            txtConfirmation.Margin = new Padding(3, 2, 3, 2);
            txtConfirmation.Name = "txtConfirmation";
            txtConfirmation.PasswordChar = '*';
            txtConfirmation.Size = new Size(260, 23);
            txtConfirmation.TabIndex = 6;
            txtConfirmation.Validating += txtConfirmation_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(310, 162);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 6;
            label5.Text = "Confirmation:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(310, 130);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(260, 23);
            txtPassword.TabIndex = 5;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(310, 113);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 2;
            label6.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(310, 84);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(260, 23);
            txtUserName.TabIndex = 4;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(310, 67);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 0;
            label7.Text = "Username:";
            // 
            // chkRoles
            // 
            chkRoles.FormattingEnabled = true;
            chkRoles.Location = new Point(310, 219);
            chkRoles.Margin = new Padding(3, 2, 3, 2);
            chkRoles.Name = "chkRoles";
            chkRoles.Size = new Size(260, 58);
            chkRoles.TabIndex = 11;
            chkRoles.ItemCheck += chkRoles_ItemCheck;
            // 
            // ck2FA
            // 
            ck2FA.AutoSize = true;
            ck2FA.Enabled = false;
            ck2FA.ForeColor = SystemColors.ControlText;
            ck2FA.Location = new Point(13, 270);
            ck2FA.Margin = new Padding(3, 2, 3, 2);
            ck2FA.Name = "ck2FA";
            ck2FA.Size = new Size(90, 19);
            ck2FA.TabIndex = 10;
            ck2FA.Text = "2FA Enabled";
            ck2FA.UseVisualStyleBackColor = true;
            // 
            // ckPhone
            // 
            ckPhone.AutoSize = true;
            ckPhone.Enabled = false;
            ckPhone.ForeColor = SystemColors.ControlText;
            ckPhone.Location = new Point(13, 244);
            ckPhone.Margin = new Padding(3, 2, 3, 2);
            ckPhone.Name = "ckPhone";
            ckPhone.Size = new Size(120, 19);
            ckPhone.TabIndex = 9;
            ckPhone.Text = "Phone Confirmed";
            ckPhone.UseVisualStyleBackColor = true;
            // 
            // ckEmail
            // 
            ckEmail.AutoSize = true;
            ckEmail.Enabled = false;
            ckEmail.ForeColor = SystemColors.ControlText;
            ckEmail.Location = new Point(13, 219);
            ckEmail.Margin = new Padding(3, 2, 3, 2);
            ckEmail.Name = "ckEmail";
            ckEmail.Size = new Size(115, 19);
            ckEmail.TabIndex = 8;
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
            lblTitle.Location = new Point(42, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(136, 30);
            lblTitle.TabIndex = 36;
            lblTitle.Text = "Users Details";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(10, 9);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // frmUserDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(579, 325);
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
            Margin = new Padding(3, 2, 3, 2);
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