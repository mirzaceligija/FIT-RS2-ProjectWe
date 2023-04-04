namespace ProjectWe.Desktop.Forms.Authentication
{
    partial class frmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignIn));
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnSignIn = new Button();
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = SystemColors.ButtonHighlight;
            lblUsername.Location = new Point(369, 232);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "*Username";
            lblUsername.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(272, 255);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(274, 27);
            txtUsername.TabIndex = 1;
            txtUsername.Validating += txtUsername_Validating;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = SystemColors.ButtonHighlight;
            lblPassword.Location = new Point(369, 285);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "*Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(272, 308);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(274, 27);
            txtPassword.TabIndex = 3;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.Gold;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.ForeColor = SystemColors.ActiveCaptionText;
            btnSignIn.Location = new Point(272, 350);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(274, 29);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(324, 134);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(170, 41);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Project We";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(384, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(354, 185);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 7;
            label1.Text = "Welcome back!";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmSignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSignIn";
            Text = "ProjectWe - Sign In";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnSignIn;
        private Label lblTitle;
        private PictureBox pictureBox1;
        private Label label1;
        private ErrorProvider errorProvider;
    }
}