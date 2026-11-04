namespace Lab2
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(200, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(85, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.Location = new Point(70, 110);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(88, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(180, 107);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(220, 30);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.Location = new Point(70, 165);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(180, 162);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(220, 30);
            txtPassword.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.Location = new Point(110, 225);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 38);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.Location = new Point(265, 225);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 38);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 320);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnLogin;
    }
}

