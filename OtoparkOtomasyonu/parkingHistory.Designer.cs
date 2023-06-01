using System.ComponentModel;

namespace OtoparkOtomasyonu
{
    partial class parkingHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parkingHistory));
            this.parking_view = new System.Windows.Forms.DataGridView();
            this.customer_phone = new System.Windows.Forms.TextBox();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.customer_car = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.parking_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_car)).BeginInit();
            this.SuspendLayout();
            // 
            // parking_view
            // 
            this.parking_view.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.parking_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.parking_view.Location = new System.Drawing.Point(70, 66);
            this.parking_view.Name = "parking_view";
            this.parking_view.RowTemplate.Height = 24;
            this.parking_view.Size = new System.Drawing.Size(561, 541);
            this.parking_view.TabIndex = 0;
            // 
            // customer_phone
            // 
            this.customer_phone.Location = new System.Drawing.Point(948, 264);
            this.customer_phone.Name = "customer_phone";
            this.customer_phone.Size = new System.Drawing.Size(166, 22);
            this.customer_phone.TabIndex = 3;
            // 
            // customer_name
            // 
            this.customer_name.Location = new System.Drawing.Point(948, 220);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(166, 22);
            this.customer_name.TabIndex = 5;
            // 
            // customer_car
            // 
            this.customer_car.Location = new System.Drawing.Point(676, 357);
            this.customer_car.Name = "customer_car";
            this.customer_car.Size = new System.Drawing.Size(480, 250);
            this.customer_car.TabIndex = 6;
            this.customer_car.TabStop = false;
            // 
            // parkingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.customer_car);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.customer_phone);
            this.Controls.Add(this.parking_view);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "parkingHistory";
            this.Text = "parkingHistory";
            ((System.ComponentModel.ISupportInitialize)(this.parking_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox customer_car;

        private System.Windows.Forms.TextBox customer_name;

        private System.Windows.Forms.TextBox customer_phone;

        private System.Windows.Forms.DataGridView parking_view;

        #endregion
    }
}