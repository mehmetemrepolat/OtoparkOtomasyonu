using System;
using System.Windows.Forms;
using System.Drawing;

namespace OtoparkOtomasyonu
{
    public partial class LoginInfo : Form
    {
        public LoginInfo()
        {
            InitializeComponent();
            loginInfoBack.FlatAppearance.BorderSize = 0; 
            loginInfoBack.FlatStyle = FlatStyle.Flat; 
            loginInfoBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            loginInfoBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            
            addReg.FlatAppearance.BorderSize = 0; 
            addReg.FlatStyle = FlatStyle.Flat; 
            addReg.FlatAppearance.MouseDownBackColor = Color.Transparent;
            addReg.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            update.FlatAppearance.BorderSize = 0; 
            update.FlatStyle = FlatStyle.Flat; 
            update.FlatAppearance.MouseDownBackColor = Color.Transparent;
            update.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            clearButton.FlatAppearance.BorderSize = 0; 
            clearButton.FlatStyle = FlatStyle.Flat; 
            clearButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            clearButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            userList.FlatAppearance.BorderSize = 0; 
            userList.FlatStyle = FlatStyle.Flat; 
            userList.FlatAppearance.MouseDownBackColor = Color.Transparent;
            userList.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            
            
            string userName     =   customerName.Text;
            string userPhone    =   customerPhone.Text;
            string userPlate    =   customerPlate.Text;
            string userRegDate  =   customerRegDate.Text;

            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;



        }

        private void loginInfoBack_Click(object sender, EventArgs e)
        {
            
            mainMenu mainMenuForm = new mainMenu();
            mainMenuForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customerName.Clear();
            customerPhone.Clear();
            customerPlate.Clear();
            customerRegDate.Clear();
            pictureBox1.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}