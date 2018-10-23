namespace HackManchester
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.nameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.cPasswordLbl = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.cPasswordTextBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(12, 124);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(79, 32);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(12, 289);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(112, 32);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Password";
            this.passwordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(12, 234);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(72, 32);
            this.emailLbl.TabIndex = 3;
            this.emailLbl.Text = "Email";
            this.emailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emailLbl.Click += new System.EventHandler(this.emailLbl_Click);
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(12, 181);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(57, 32);
            this.ageLbl.TabIndex = 4;
            this.ageLbl.Text = "Age";
            this.ageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cPasswordLbl
            // 
            this.cPasswordLbl.AutoSize = true;
            this.cPasswordLbl.Location = new System.Drawing.Point(12, 342);
            this.cPasswordLbl.Name = "cPasswordLbl";
            this.cPasswordLbl.Size = new System.Drawing.Size(205, 32);
            this.cPasswordLbl.TabIndex = 5;
            this.cPasswordLbl.Text = "Confirm Password";
            this.cPasswordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(214, 118);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(158, 38);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(214, 175);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(158, 38);
            this.ageTextBox.TabIndex = 7;
            this.ageTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(214, 228);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(158, 38);
            this.emailTextBox.TabIndex = 8;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(214, 283);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(158, 38);
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // cPasswordTextBox
            // 
            this.cPasswordTextBox.Location = new System.Drawing.Point(214, 336);
            this.cPasswordTextBox.Name = "cPasswordTextBox";
            this.cPasswordTextBox.Size = new System.Drawing.Size(158, 38);
            this.cPasswordTextBox.TabIndex = 10;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(-1, -1);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(55, 51);
            this.backBtn.TabIndex = 11;
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
            this.titleLbl.Location = new System.Drawing.Point(129, 22);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(129, 59);
            this.titleLbl.TabIndex = 17;
            this.titleLbl.Text = "Login";
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.Lime;
            this.registerBtn.Location = new System.Drawing.Point(18, 448);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(174, 69);
            this.registerBtn.TabIndex = 19;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Location = new System.Drawing.Point(259, 453);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(113, 64);
            this.exitBtn.TabIndex = 21;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 607);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.cPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cPasswordLbl);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.nameLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label cPasswordLbl;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox cPasswordTextBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}