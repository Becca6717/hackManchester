namespace HackManchester
{
    partial class homePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePage));
            this.addTripBtn = new RoundButton();
            this.viewTripBtn = new RoundButton();
            this.roundButton3 = new RoundButton();
            this.roundButton4 = new RoundButton();
            this.titleText = new System.Windows.Forms.Label();
            this.dtLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sunriseLbl = new System.Windows.Forms.Label();
            this.sunsetLbl = new System.Windows.Forms.Label();
            this.sunriseTimeLbl = new System.Windows.Forms.Label();
            this.sunsetTimeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addTripBtn
            // 
            this.addTripBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addTripBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addTripBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.addTripBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addTripBtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTripBtn.ForeColor = System.Drawing.Color.White;
            this.addTripBtn.Location = new System.Drawing.Point(12, 83);
            this.addTripBtn.Name = "addTripBtn";
            this.addTripBtn.Size = new System.Drawing.Size(119, 130);
            this.addTripBtn.TabIndex = 0;
            this.addTripBtn.Text = "Add Trip";
            this.addTripBtn.UseVisualStyleBackColor = false;
            // 
            // viewTripBtn
            // 
            this.viewTripBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.viewTripBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.viewTripBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.viewTripBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewTripBtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTripBtn.ForeColor = System.Drawing.Color.White;
            this.viewTripBtn.Location = new System.Drawing.Point(153, 83);
            this.viewTripBtn.Name = "viewTripBtn";
            this.viewTripBtn.Size = new System.Drawing.Size(119, 130);
            this.viewTripBtn.TabIndex = 1;
            this.viewTripBtn.Text = "View Trips";
            this.viewTripBtn.UseVisualStyleBackColor = false;
            this.viewTripBtn.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.SystemColors.Highlight;
            this.roundButton3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundButton3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton3.ForeColor = System.Drawing.Color.White;
            this.roundButton3.Location = new System.Drawing.Point(12, 243);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(119, 130);
            this.roundButton3.TabIndex = 2;
            this.roundButton3.Text = "roundButton3";
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.SystemColors.Highlight;
            this.roundButton4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundButton4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton4.ForeColor = System.Drawing.Color.White;
            this.roundButton4.Location = new System.Drawing.Point(153, 243);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(119, 130);
            this.roundButton4.TabIndex = 3;
            this.roundButton4.Text = "roundButton4";
            this.roundButton4.UseVisualStyleBackColor = false;
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(4, 9);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(280, 45);
            this.titleText.TabIndex = 4;
            this.titleText.Text = "Beat the jet-lag";
            this.titleText.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtLabel
            // 
            this.dtLabel.AutoSize = true;
            this.dtLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLabel.ForeColor = System.Drawing.Color.Red;
            this.dtLabel.Location = new System.Drawing.Point(5, 438);
            this.dtLabel.Name = "dtLabel";
            this.dtLabel.Size = new System.Drawing.Size(93, 38);
            this.dtLabel.TabIndex = 5;
            this.dtLabel.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sunriseLbl
            // 
            this.sunriseLbl.AutoSize = true;
            this.sunriseLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunriseLbl.Location = new System.Drawing.Point(8, 488);
            this.sunriseLbl.Name = "sunriseLbl";
            this.sunriseLbl.Size = new System.Drawing.Size(66, 23);
            this.sunriseLbl.TabIndex = 6;
            this.sunriseLbl.Text = "Sunrise";
            this.sunriseLbl.Click += new System.EventHandler(this.sunriseLbl_Click);
            // 
            // sunsetLbl
            // 
            this.sunsetLbl.AutoSize = true;
            this.sunsetLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunsetLbl.Location = new System.Drawing.Point(8, 520);
            this.sunsetLbl.Name = "sunsetLbl";
            this.sunsetLbl.Size = new System.Drawing.Size(62, 23);
            this.sunsetLbl.TabIndex = 7;
            this.sunsetLbl.Text = "Sunset";
            this.sunsetLbl.Click += new System.EventHandler(this.sunsetLbl_Click);
            // 
            // sunriseTimeLbl
            // 
            this.sunriseTimeLbl.AutoSize = true;
            this.sunriseTimeLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunriseTimeLbl.ForeColor = System.Drawing.Color.Lime;
            this.sunriseTimeLbl.Location = new System.Drawing.Point(80, 488);
            this.sunriseTimeLbl.Name = "sunriseTimeLbl";
            this.sunriseTimeLbl.Size = new System.Drawing.Size(57, 23);
            this.sunriseTimeLbl.TabIndex = 8;
            this.sunriseTimeLbl.Text = "06:27";
            this.sunriseTimeLbl.Click += new System.EventHandler(this.sunriseTimeLbl_Click);
            // 
            // sunsetTimeLbl
            // 
            this.sunsetTimeLbl.AutoSize = true;
            this.sunsetTimeLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunsetTimeLbl.ForeColor = System.Drawing.Color.Lime;
            this.sunsetTimeLbl.Location = new System.Drawing.Point(80, 520);
            this.sunsetTimeLbl.Name = "sunsetTimeLbl";
            this.sunsetTimeLbl.Size = new System.Drawing.Size(57, 23);
            this.sunsetTimeLbl.TabIndex = 9;
            this.sunsetTimeLbl.Text = "19:14";
            this.sunsetTimeLbl.Click += new System.EventHandler(this.sunsetTimeLbl_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 561);
            this.Controls.Add(this.sunsetTimeLbl);
            this.Controls.Add(this.sunriseTimeLbl);
            this.Controls.Add(this.sunsetLbl);
            this.Controls.Add(this.sunriseLbl);
            this.Controls.Add(this.dtLabel);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.viewTripBtn);
            this.Controls.Add(this.addTripBtn);
            this.Name = "homePage";
            this.Text = "homePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton addTripBtn;
        private RoundButton viewTripBtn;
        private RoundButton roundButton3;
        private RoundButton roundButton4;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label dtLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label sunriseLbl;
        private System.Windows.Forms.Label sunsetLbl;
        private System.Windows.Forms.Label sunriseTimeLbl;
        private System.Windows.Forms.Label sunsetTimeLbl;
    }
}