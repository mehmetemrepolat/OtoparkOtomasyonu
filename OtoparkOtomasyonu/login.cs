using System;
using System.Windows.Forms;

namespace OtoparkOtomasyonu
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Login_KeyDown;
            
        }
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string userName = user_loginName.Text;
                string userPass = user_LoginPass.Text;
                string username_S = "admin";
                string password_S = "1234";
                if (username_S == userName && userPass == password_S)
                {
                    GirisYap();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                }
            }
        }
        
        private void GirisYap()
        {
            // Giriş yapma işlemlerini burada gerçekleştirin
            
            mainMenu mainMenuForm = new mainMenu();
            mainMenuForm.Show();
            this.Hide();
            
        }
    


    }
}