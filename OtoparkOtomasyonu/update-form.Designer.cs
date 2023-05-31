using System.ComponentModel;

namespace OtoparkOtomasyonu
{
    partial class update_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_form));
            this.car_photo = new System.Windows.Forms.PictureBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_plate = new System.Windows.Forms.TextBox();
            this.text_phone = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.car_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // car_photo
            // 
            this.car_photo.Location = new System.Drawing.Point(321, 111);
            this.car_photo.Name = "car_photo";
            this.car_photo.Size = new System.Drawing.Size(286, 164);
            this.car_photo.TabIndex = 0;
            this.car_photo.TabStop = false;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(183, 147);
            this.text_name.MaxLength = 150;
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(132, 22);
            this.text_name.TabIndex = 1;
            // 
            // text_plate
            // 
            this.text_plate.Location = new System.Drawing.Point(183, 214);
            this.text_plate.Name = "text_plate";
            this.text_plate.Size = new System.Drawing.Size(132, 22);
            this.text_plate.TabIndex = 2;
            // 
            // text_phone
            // 
            this.text_phone.Location = new System.Drawing.Point(183, 180);
            this.text_phone.MaxLength = 11;
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(132, 22);
            this.text_phone.TabIndex = 3;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(199, 264);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(95, 35);
            this.update.TabIndex = 4;
            this.update.Text = "button1";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // update_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 379);
            this.Controls.Add(this.update);
            this.Controls.Add(this.text_phone);
            this.Controls.Add(this.text_plate);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.car_photo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "update_form";
            this.Text = "Kullanıcı Güncelle";
            ((System.ComponentModel.ISupportInitialize)(this.car_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button update;

        private System.Windows.Forms.TextBox text_phone;

        private System.Windows.Forms.PictureBox car_photo;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_plate;

        #endregion
    }
}