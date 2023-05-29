using System.ComponentModel;

namespace OtoparkOtomasyonu
{
    partial class fullSizeCameraDisplay
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.full_sizeBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.full_sizeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.full_sizeBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 673);
            this.panel1.TabIndex = 0;
            // 
            // full_sizeBox
            // 
            this.full_sizeBox.Location = new System.Drawing.Point(0, 0);
            this.full_sizeBox.Name = "full_sizeBox";
            this.full_sizeBox.Size = new System.Drawing.Size(1261, 673);
            this.full_sizeBox.TabIndex = 0;
            this.full_sizeBox.TabStop = false;
            // 
            // fullSizeCameraDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.Name = "fullSizeCameraDisplay";
            this.Text = "fullSizeCameraDisplay";
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fullSizeCameraDisplay_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.full_sizeBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.PictureBox full_sizeBox;

        #endregion
    }
}