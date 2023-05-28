using System;
using System.Windows.Forms;
using System.Drawing;

namespace OtoparkOtomasyonu
{
    public partial class cameraMenu : Form
    {
        public cameraMenu()
        {
            InitializeComponent();
            loginInfoBack.FlatAppearance.BorderSize = 0; 
            loginInfoBack.FlatStyle = FlatStyle.Flat; 
            loginInfoBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            loginInfoBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void loginInfoBack_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}