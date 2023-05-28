namespace OtoparkOtomasyonu
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cam_cikis = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pc_cam = new System.Windows.Forms.Button();
            this.ip_cam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cam_giris = new System.Windows.Forms.Button();
            this.text_giris = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 588);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(662, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 577);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(647, 571);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 577);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 571);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cam_cikis);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.cam_giris);
            this.panel4.Controls.Add(this.text_giris);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(12, 608);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1315, 99);
            this.panel4.TabIndex = 4;
            // 
            // cam_cikis
            // 
            this.cam_cikis.Location = new System.Drawing.Point(1183, 32);
            this.cam_cikis.Name = "cam_cikis";
            this.cam_cikis.Size = new System.Drawing.Size(129, 35);
            this.cam_cikis.TabIndex = 4;
            this.cam_cikis.Text = "Çıkış Kamerası";
            this.cam_cikis.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.pc_cam);
            this.panel6.Controls.Add(this.ip_cam);
            this.panel6.Location = new System.Drawing.Point(484, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(356, 30);
            this.panel6.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Geçmiş";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pc_cam
            // 
            this.pc_cam.Location = new System.Drawing.Point(120, 3);
            this.pc_cam.Name = "pc_cam";
            this.pc_cam.Size = new System.Drawing.Size(114, 23);
            this.pc_cam.TabIndex = 1;
            this.pc_cam.Text = "PC Cam";
            this.pc_cam.UseVisualStyleBackColor = true;
            this.pc_cam.Click += new System.EventHandler(this.pc_cam_Click);
            // 
            // ip_cam
            // 
            this.ip_cam.Location = new System.Drawing.Point(0, 3);
            this.ip_cam.Name = "ip_cam";
            this.ip_cam.Size = new System.Drawing.Size(114, 23);
            this.ip_cam.TabIndex = 0;
            this.ip_cam.Text = "IP Cam";
            this.ip_cam.UseVisualStyleBackColor = true;
            this.ip_cam.Click += new System.EventHandler(this.ip_cam_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(844, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çıkış Yapan Araç:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(987, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "41 PLT 41";
            // 
            // cam_giris
            // 
            this.cam_giris.Location = new System.Drawing.Point(339, 32);
            this.cam_giris.Name = "cam_giris";
            this.cam_giris.Size = new System.Drawing.Size(129, 35);
            this.cam_giris.TabIndex = 3;
            this.cam_giris.Text = "Giriş Kamerası";
            this.cam_giris.UseVisualStyleBackColor = true;
            // 
            // text_giris
            // 
            this.text_giris.Location = new System.Drawing.Point(143, 42);
            this.text_giris.Name = "text_giris";
            this.text_giris.Size = new System.Drawing.Size(190, 22);
            this.text_giris.TabIndex = 2;
            this.text_giris.Text = "35 PLT 35";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giriş Yapan Araç:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 8);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 719);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button ip_cam;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button pc_cam;

        private System.Windows.Forms.Button cam_cikis;

        private System.Windows.Forms.Button cam_giris;

        private System.Windows.Forms.TextBox text_giris;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}