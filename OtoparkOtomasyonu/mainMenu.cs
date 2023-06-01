using System;
using System.Windows.Forms;
using System.Drawing;


namespace OtoparkOtomasyonu
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
            user_signup.FlatAppearance.BorderSize = 0; 
            user_signup.FlatStyle = FlatStyle.Flat; 
            user_signup.FlatAppearance.MouseDownBackColor = Color.Transparent; 
            user_signup.FlatAppearance.MouseOverBackColor = Color.Transparent; 
            
            parkingSystem.FlatAppearance.BorderSize = 0;
            parkingSystem.FlatStyle = FlatStyle.Flat; 
            parkingSystem.FlatAppearance.MouseDownBackColor = Color.Transparent; 
            parkingSystem.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            exit.FlatAppearance.BorderSize = 0; 
            exit.FlatStyle = FlatStyle.Flat; 
            exit.FlatAppearance.MouseDownBackColor = Color.Transparent; 
            exit.FlatAppearance.MouseOverBackColor = Color.Transparent; 
            
            exitButton.FlatAppearance.BorderSize = 0; 
            exitButton.FlatStyle = FlatStyle.Flat; 
            exitButton.FlatAppearance.MouseDownBackColor = Color.Transparent; 
            exitButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            LoginInfo user_addFrom = new LoginInfo();
            user_addFrom.Show();
            this.Hide();
        }

        private void parkingSystem_Click(object sender, EventArgs e)
        {

            cameraMenu cameraForm = new cameraMenu();
            cameraForm.Show();
            this.Hide();
            

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}