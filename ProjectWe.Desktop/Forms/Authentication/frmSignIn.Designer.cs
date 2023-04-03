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
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnSignIn = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(257, 172);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(257, 195);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(274, 27);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(257, 238);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(257, 261);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(274, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.HotTrack;
            btnSignIn.ForeColor = SystemColors.ButtonHighlight;
            btnSignIn.Location = new Point(257, 317);
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
            lblTitle.Location = new Point(280, 84);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 41);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Welcome back";
            // 
            // frmSignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Name = "frmSignIn";
            Text = "ProjectWe - Sign In";
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
    }
}