using System.ComponentModel;

namespace OtoparkOtomasyonu
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.user_loginName = new System.Windows.Forms.TextBox();
            this.user_LoginPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // user_loginName
            // 
            this.user_loginName.Location = new System.Drawing.Point(245, 132);
            this.user_loginName.Name = "user_loginName";
            this.user_loginName.Size = new System.Drawing.Size(155, 22);
            this.user_loginName.TabIndex = 0;
            // 
            // user_LoginPass
            // 
            this.user_LoginPass.Location = new System.Drawing.Point(245, 192);
            this.user_LoginPass.Name = "user_LoginPass";
            this.user_LoginPass.PasswordChar = '*';
            this.user_LoginPass.Size = new System.Drawing.Size(155, 22);
            this.user_LoginPass.TabIndex = 1;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 379);
            this.Controls.Add(this.user_LoginPass);
            this.Controls.Add(this.user_loginName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox user_loginName;
        private System.Windows.Forms.TextBox user_LoginPass;

        #endregion
    }
}