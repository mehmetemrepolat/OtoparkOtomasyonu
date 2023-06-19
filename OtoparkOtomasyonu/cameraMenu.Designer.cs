using System.ComponentModel;

namespace OtoparkOtomasyonu
{
    partial class CameraMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraMenu));
            this.loginInfoBack = new System.Windows.Forms.Button();
            this.entered_Car = new System.Windows.Forms.TextBox();
            this.left_car = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.frontCam_button_1 = new System.Windows.Forms.Button();
            this.rearCam_button_1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.entered_Car.TextChanged += new System.EventHandler(this.entered_Car_TextChanged);
            // 
            // left_car
            // 
            this.left_car.Location = new System.Drawing.Point(815, 612);
            this.left_car.Name = "left_car";
            this.left_car.Size = new System.Drawing.Size(150, 22);
            this.left_car.TabIndex = 4;
            this.left_car.TextChanged += new System.EventHandler(this.left_car_TextChanged);
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
            // frontCam_button_1
            // 
            this.frontCam_button_1.BackColor = System.Drawing.Color.Transparent;
            this.frontCam_button_1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.frontCam_button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frontCam_button_1.ForeColor = System.Drawing.Color.Transparent;
            this.frontCam_button_1.Location = new System.Drawing.Point(400, 579);
            this.frontCam_button_1.Name = "frontCam_button_1";
            this.frontCam_button_1.Size = new System.Drawing.Size(136, 88);
            this.frontCam_button_1.TabIndex = 10;
            this.frontCam_button_1.UseVisualStyleBackColor = false;
            this.frontCam_button_1.Click += new System.EventHandler(this.frontCam_button_1_Click_2);
            // 
            // rearCam_button_1
            // 
            this.rearCam_button_1.BackColor = System.Drawing.Color.Transparent;
            this.rearCam_button_1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.rearCam_button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rearCam_button_1.ForeColor = System.Drawing.Color.Transparent;
            this.rearCam_button_1.Location = new System.Drawing.Point(1048, 573);
            this.rearCam_button_1.Name = "rearCam_button_1";
            this.rearCam_button_1.Size = new System.Drawing.Size(136, 88);
            this.rearCam_button_1.TabIndex = 11;
            this.rearCam_button_1.UseVisualStyleBackColor = false;
            this.rearCam_button_1.Click += new System.EventHandler(this.rearCam_button_1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1119, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 50);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CameraMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rearCam_button_1);
            this.Controls.Add(this.frontCam_button_1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.left_car);
            this.Controls.Add(this.entered_Car);
            this.Controls.Add(this.loginInfoBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "CameraMenu";
            this.Text = "Kamera Menüsü";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button rearCam_button_1;

        private System.Windows.Forms.Button frontCam_button_1;

        private System.Windows.Forms.TextBox entered_Car;
        private System.Windows.Forms.TextBox left_car;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.Button loginInfoBack;

        #endregion
    }
}