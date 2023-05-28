using System.ComponentModel;

namespace OtoparkOtomasyonu
{
    partial class LoginInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginInfo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginInfoBack = new System.Windows.Forms.Button();
            this.customerName = new System.Windows.Forms.TextBox();
            this.customerPhone = new System.Windows.Forms.TextBox();
            this.customerPlate = new System.Windows.Forms.TextBox();
            this.customerRegDate = new System.Windows.Forms.TextBox();
            this.addReg = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.userList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(739, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 229);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // loginInfoBack
            // 
            this.loginInfoBack.BackColor = System.Drawing.Color.Transparent;
            this.loginInfoBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginInfoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginInfoBack.ForeColor = System.Drawing.Color.Transparent;
            this.loginInfoBack.Location = new System.Drawing.Point(0, 1);
            this.loginInfoBack.Name = "loginInfoBack";
            this.loginInfoBack.Size = new System.Drawing.Size(59, 40);
            this.loginInfoBack.TabIndex = 1;
            this.loginInfoBack.UseVisualStyleBackColor = false;
            this.loginInfoBack.Click += new System.EventHandler(this.loginInfoBack_Click);
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(316, 204);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(202, 22);
            this.customerName.TabIndex = 2;
            // 
            // customerPhone
            // 
            this.customerPhone.Location = new System.Drawing.Point(316, 236);
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.Size = new System.Drawing.Size(202, 22);
            this.customerPhone.TabIndex = 3;
            // 
            // customerPlate
            // 
            this.customerPlate.Location = new System.Drawing.Point(316, 268);
            this.customerPlate.Name = "customerPlate";
            this.customerPlate.Size = new System.Drawing.Size(202, 22);
            this.customerPlate.TabIndex = 4;
            // 
            // customerRegDate
            // 
            this.customerRegDate.Location = new System.Drawing.Point(316, 300);
            this.customerRegDate.Name = "customerRegDate";
            this.customerRegDate.Size = new System.Drawing.Size(202, 22);
            this.customerRegDate.TabIndex = 5;
            // 
            // addReg
            // 
            this.addReg.BackColor = System.Drawing.Color.Transparent;
            this.addReg.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReg.ForeColor = System.Drawing.Color.Transparent;
            this.addReg.Location = new System.Drawing.Point(77, 368);
            this.addReg.Name = "addReg";
            this.addReg.Size = new System.Drawing.Size(128, 40);
            this.addReg.TabIndex = 6;
            this.addReg.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Transparent;
            this.update.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.ForeColor = System.Drawing.Color.Transparent;
            this.update.Location = new System.Drawing.Point(211, 368);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(128, 40);
            this.update.TabIndex = 7;
            this.update.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.Color.Transparent;
            this.clearButton.Location = new System.Drawing.Point(211, 439);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(114, 40);
            this.clearButton.TabIndex = 8;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // userList
            // 
            this.userList.BackColor = System.Drawing.Color.Transparent;
            this.userList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.userList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userList.ForeColor = System.Drawing.Color.Transparent;
            this.userList.Location = new System.Drawing.Point(77, 426);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(56, 40);
            this.userList.TabIndex = 9;
            this.userList.UseVisualStyleBackColor = false;
            // 
            // LoginInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 685);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.update);
            this.Controls.Add(this.addReg);
            this.Controls.Add(this.customerRegDate);
            this.Controls.Add(this.customerPlate);
            this.Controls.Add(this.customerPhone);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.loginInfoBack);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginInfo";
            this.Text = "LoginInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addReg;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button userList;

        private System.Windows.Forms.TextBox customerRegDate;

        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox customerPhone;
        private System.Windows.Forms.TextBox customerPlate;

        private System.Windows.Forms.Button loginInfoBack;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}