using System;
using System.Windows.Forms;
using System.IO;

namespace OtoparkOtomasyonu
{
    public partial class Login : Form
    {
        private string usernameS;
        private string passwordS;
        
        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Login_KeyDown;
            ReadSettings();

            
        }
        
        private void ReadSettings()
        {
            string settingsFile = "settings.ini";
            try
            {
                string[] lines = File.ReadAllLines(settingsFile);
                if (lines.Length >= 2)
                {
                    usernameS = lines[0];
                    passwordS = lines[1];
                }
                else
                {
                    MessageBox.Show("settings.ini dosyası eksik veya hatalı.");
                    // Varsayılan değerleri ata
                    usernameS = "admin";
                    passwordS = "1234";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("settings.ini dosyası okunurken bir hata oluştu: " + ex.Message);
                // Varsayılan değerleri ata
                usernameS = "admin";
                passwordS = "1234";
            }
        }
        
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string userName = user_loginName.Text;
                string userPass = user_LoginPass.Text;
                //string usernameS = "admin";
                //string passwordS = "1234";
                if (usernameS == userName && userPass == passwordS)
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
            
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            this.Hide();
            
        }
    


    }
}