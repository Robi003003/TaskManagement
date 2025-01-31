namespace TaskManagement
{
    partial class LoginForm
    {

        private System.ComponentModel.IContainer components = null;

        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            checkBoxShowPassword = new CheckBox();
            SuspendLayout();
            
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 16);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 73);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 16);
            label2.TabIndex = 1;
            label2.Text = "Password";
            
            txtUsername.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(22, 36);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(178, 22);
            txtUsername.TabIndex = 2;
            
            txtPassword.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(22, 95);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(178, 22);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
             
            btnLogin.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(80, 175);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(67, 27);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxShowPassword.Location = new Point(22, 137);
            checkBoxShowPassword.Margin = new Padding(2);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(110, 20);
            checkBoxShowPassword.TabIndex = 5;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBox1_CheckedChanged;
             
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(226, 221);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private CheckBox checkBoxShowPassword;
    }
}
