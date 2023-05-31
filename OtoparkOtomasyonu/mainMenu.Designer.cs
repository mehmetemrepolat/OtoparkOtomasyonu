using System.ComponentModel;

namespace OtoparkOtomasyonu
{
    partial class mainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.user_signup = new System.Windows.Forms.Button();
            this.parkingSystem = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_signup
            // 
            this.user_signup.BackColor = System.Drawing.Color.Transparent;
            this.user_signup.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.user_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_signup.ForeColor = System.Drawing.Color.Silver;
            this.user_signup.Location = new System.Drawing.Point(198, 382);
            this.user_signup.Name = "user_signup";
            this.user_signup.Size = new System.Drawing.Size(211, 83);
            this.user_signup.TabIndex = 0;
            this.user_signup.UseVisualStyleBackColor = false;
            this.user_signup.Click += new System.EventHandler(this.button1_Click);
            // 
            // parkingSystem
            // 
            this.parkingSystem.BackColor = System.Drawing.Color.Transparent;
            this.parkingSystem.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.parkingSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingSystem.ForeColor = System.Drawing.Color.Silver;
            this.parkingSystem.Location = new System.Drawing.Point(670, 253);
            this.parkingSystem.Name = "parkingSystem";
            this.parkingSystem.Size = new System.Drawing.Size(305, 192);
            this.parkingSystem.TabIndex = 1;
            this.parkingSystem.UseVisualStyleBackColor = false;
            this.parkingSystem.Click += new System.EventHandler(this.parkingSystem_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.Silver;
            this.exit.Location = new System.Drawing.Point(879, 28);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(159, 61);
            this.exit.TabIndex = 2;
            this.exit.UseVisualStyleBackColor = false;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 685);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.parkingSystem);
            this.Controls.Add(this.user_signup);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "mainMenu";
            this.Text = "Ana Menü";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button parkingSystem;
        private System.Windows.Forms.Button exit;

        private System.Windows.Forms.Button user_signup;

        #endregion
    }
}