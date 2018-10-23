namespace HackManchester
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.emailValidationLbl = new System.Windows.Forms.Label();
            this.passwordValidationLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(158, 278);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(214, 38);
            this.passwordTextBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(158, 185);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(214, 38);
            this.emailTextBox.TabIndex = 13;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(29, 191);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(72, 32);
            this.emailLbl.TabIndex = 12;
            this.emailLbl.Text = "Email";
            this.emailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(29, 284);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(112, 32);
            this.passwordLbl.TabIndex = 11;
            this.passwordLbl.Text = "Password";
            this.passwordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(1, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(55, 51);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "<";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.SystemColors.Window;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.titleLbl.Location = new System.Drawing.Point(114, 34);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(129, 59);
            this.titleLbl.TabIndex = 16;
            this.titleLbl.Text = "Login";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Location = new System.Drawing.Point(259, 476);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(113, 64);
            this.exitBtn.TabIndex = 21;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Lime;
            this.loginBtn.Location = new System.Drawing.Point(259, 334);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(113, 69);
            this.loginBtn.TabIndex = 22;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // emailValidationLbl
            // 
            this.emailValidationLbl.AutoSize = true;
            this.emailValidationLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailValidationLbl.ForeColor = System.Drawing.Color.Red;
            this.emailValidationLbl.Location = new System.Drawing.Point(161, 152);
            this.emailValidationLbl.Name = "emailValidationLbl";
            this.emailValidationLbl.Size = new System.Drawing.Size(0, 25);
            this.emailValidationLbl.TabIndex = 23;
            // 
            // passwordValidationLbl
            // 
            this.passwordValidationLbl.AutoSize = true;
            this.passwordValidationLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordValidationLbl.ForeColor = System.Drawing.Color.Red;
            this.passwordValidationLbl.Location = new System.Drawing.Point(161, 238);
            this.passwordValidationLbl.Name = "passwordValidationLbl";
            this.passwordValidationLbl.Size = new System.Drawing.Size(0, 25);
            this.passwordValidationLbl.TabIndex = 24;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 607);
            this.Controls.Add(this.passwordValidationLbl);
            this.Controls.Add(this.emailValidationLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.passwordLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label emailValidationLbl;
        private System.Windows.Forms.Label passwordValidationLbl;
    }
}