using System.ComponentModel;

namespace OtoparkOtomasyonu
{
    partial class cameraMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cameraMenu));
            this.loginInfoBack = new System.Windows.Forms.Button();
            this.entered_Car = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.frontCam_button = new System.Windows.Forms.Button();
            this.rearCam_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // loginInfoBack
            // 
            this.loginInfoBack.BackColor = System.Drawing.Color.Transparent;
            this.loginInfoBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginInfoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginInfoBack.ForeColor = System.Drawing.Color.Transparent;
            this.loginInfoBack.Location = new System.Drawing.Point(1, 1);
            this.loginInfoBack.Name = "loginInfoBack";
            this.loginInfoBack.Size = new System.Drawing.Size(59, 40);
            this.loginInfoBack.TabIndex = 2;
            this.loginInfoBack.UseVisualStyleBackColor = false;
            this.loginInfoBack.Click += new System.EventHandler(this.loginInfoBack_Click);
            // 
            // entered_Car
            // 
            this.entered_Car.Location = new System.Drawing.Point(233, 612);
            this.entered_Car.Name = "entered_Car";
            this.entered_Car.Size = new System.Drawing.Size(150, 22);
            this.entered_Car.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(815, 612);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 22);
            this.textBox2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(577, 351);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(661, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(577, 351);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // frontCam_button
            // 
            this.frontCam_button.BackColor = System.Drawing.Color.Transparent;
            this.frontCam_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.frontCam_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frontCam_button.ForeColor = System.Drawing.Color.Transparent;
            this.frontCam_button.Location = new System.Drawing.Point(402, 573);
            this.frontCam_button.Name = "frontCam_button";
            this.frontCam_button.Size = new System.Drawing.Size(126, 88);
            this.frontCam_button.TabIndex = 7;
            this.frontCam_button.UseVisualStyleBackColor = false;
            this.frontCam_button.Click += new System.EventHandler(this.frontCam_button_Click);
            // 
            // rearCam_button
            // 
            this.rearCam_button.BackColor = System.Drawing.Color.Transparent;
            this.rearCam_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rearCam_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rearCam_button.ForeColor = System.Drawing.Color.Transparent;
            this.rearCam_button.Location = new System.Drawing.Point(1051, 573);
            this.rearCam_button.Name = "rearCam_button";
            this.rearCam_button.Size = new System.Drawing.Size(126, 88);
            this.rearCam_button.TabIndex = 8;
            this.rearCam_button.UseVisualStyleBackColor = false;
            this.rearCam_button.Click += new System.EventHandler(this.rearCam_button_Click);
            // 
            // cameraMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.rearCam_button);
            this.Controls.Add(this.frontCam_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.entered_Car);
            this.Controls.Add(this.loginInfoBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "cameraMenu";
            this.Text = "cameraMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button frontCam_button;
        private System.Windows.Forms.Button rearCam_button;

        private System.Windows.Forms.TextBox entered_Car;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.Button loginInfoBack;

        #endregion
    }
}