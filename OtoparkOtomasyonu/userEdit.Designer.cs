using System.ComponentModel;

namespace OtoparkOtomasyonu
{
    partial class userEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userEdit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_view = new System.Windows.Forms.DataGridView();
            this.userEditBack = new System.Windows.Forms.Button();
            this.find_customer = new System.Windows.Forms.TextBox();
            this.update_customer = new System.Windows.Forms.Button();
            this.delete_record = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_view)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(784, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 249);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // user_view
            // 
            this.user_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_view.Location = new System.Drawing.Point(72, 93);
            this.user_view.Name = "user_view";
            this.user_view.RowTemplate.Height = 24;
            this.user_view.Size = new System.Drawing.Size(643, 326);
            this.user_view.TabIndex = 1;
            // 
            // userEditBack
            // 
            this.userEditBack.BackColor = System.Drawing.Color.Transparent;
            this.userEditBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.userEditBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userEditBack.ForeColor = System.Drawing.Color.Transparent;
            this.userEditBack.Location = new System.Drawing.Point(2, -1);
            this.userEditBack.Name = "userEditBack";
            this.userEditBack.Size = new System.Drawing.Size(54, 40);
            this.userEditBack.TabIndex = 2;
            this.userEditBack.UseVisualStyleBackColor = false;
            this.userEditBack.Click += new System.EventHandler(this.userEditBack_Click_1);
            // 
            // find_customer
            // 
            this.find_customer.Location = new System.Drawing.Point(301, 434);
            this.find_customer.Name = "find_customer";
            this.find_customer.Size = new System.Drawing.Size(136, 22);
            this.find_customer.TabIndex = 3;
            this.find_customer.TextChanged += new System.EventHandler(this.find_customer_TextChanged);
            // 
            // update_customer
            // 
            this.update_customer.BackColor = System.Drawing.Color.Transparent;
            this.update_customer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.update_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_customer.ForeColor = System.Drawing.Color.Transparent;
            this.update_customer.Location = new System.Drawing.Point(72, 425);
            this.update_customer.Name = "update_customer";
            this.update_customer.Size = new System.Drawing.Size(97, 40);
            this.update_customer.TabIndex = 4;
            this.update_customer.UseVisualStyleBackColor = false;
            this.update_customer.Click += new System.EventHandler(this.update_customer_Click);
            // 
            // delete_record
            // 
            this.delete_record.BackColor = System.Drawing.Color.Transparent;
            this.delete_record.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.delete_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_record.ForeColor = System.Drawing.Color.Transparent;
            this.delete_record.Location = new System.Drawing.Point(175, 425);
            this.delete_record.Name = "delete_record";
            this.delete_record.Size = new System.Drawing.Size(81, 40);
            this.delete_record.TabIndex = 5;
            this.delete_record.UseVisualStyleBackColor = false;
            this.delete_record.Click += new System.EventHandler(this.delete_record_Click);
            // 
            // userEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 685);
            this.Controls.Add(this.delete_record);
            this.Controls.Add(this.update_customer);
            this.Controls.Add(this.find_customer);
            this.Controls.Add(this.userEditBack);
            this.Controls.Add(this.user_view);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "userEdit";
            this.Text = "Kullanıcı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button delete_record;

        private System.Windows.Forms.Button update_customer;

        private System.Windows.Forms.TextBox find_customer;

        private System.Windows.Forms.Button userEditBack;

        private System.Windows.Forms.DataGridView user_view;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}