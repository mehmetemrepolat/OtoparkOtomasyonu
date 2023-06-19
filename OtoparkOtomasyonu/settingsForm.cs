using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;


namespace OtoparkOtomasyonu
{
    public partial class settingsForm : Form
    {
        private string userName;
        private string passWord;
        private string frontCamIP;
        private string rearCamIP;
        private string server;
        private string user;
        private string database;
        private string password;
        
        public settingsForm()
        {
            InitializeComponent();
            settings_save.FlatAppearance.BorderSize = 0; 
            settings_save.FlatStyle = FlatStyle.Flat; 
            settings_save.FlatAppearance.MouseDownBackColor = Color.Transparent; 
            settings_save.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ReadSettings();

            textBox1.Text = userName;
            textBox2.Text = passWord;
            textBox3.Text = frontCamIP;
            textBox4.Text = rearCamIP;
            textBox5.Text = database;
            textBox6.Text = server;
            textBox7.Text = user;
            textBox8.Text = password;
        }

        
        private void ReadSettings()
        {
            string settingsFile = "settings.ini";
            try
            {
                string[] lines = File.ReadAllLines(settingsFile);
                if (lines.Length >= 2)
                {
                    userName = lines[0];
                    passWord = lines[1];
                    frontCamIP = lines[2];
                    rearCamIP = lines[3];

                    string connectionString = lines[4];
                    string[] parts = connectionString.Split(';');

                    server  =   parts[0].Substring(parts[0].IndexOf('=') + 1);
                    user = parts[1].Substring(parts[1].IndexOf('=') + 1);
                    database = parts[2].Substring(parts[2].IndexOf('=') + 1);
                    password = parts[3].Substring(parts[3].IndexOf('=') + 1);

                }
                else
                {
                    MessageBox.Show("settings.ini dosyası eksik veya hatalı.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("settings.ini dosyası okunurken bir hata oluştu: " + ex.Message);
            }
        }
        
        
        private void settings_save_Click(object sender, EventArgs e)
        {
            // Yazmak istediğiniz metinleri TextBox'lardan alın
            string user_name        = textBox1.Text;
            string user_password    = textBox2.Text;
            string frontCam_ip      = textBox3.Text;
            string rearCam_ip       = textBox4.Text;
            string database_name    = textBox5.Text;
            string server_adress    = textBox6.Text;
            string server_userName  = textBox7.Text;
            string server_userPass  = textBox8.Text;

            // Dosya yolunu belirleyin
            string dosyaYolu = "settings.ini";
            
            //server=localhost;user=root;database=otopark-otomasyonu;password=413508
            
            // Dosyayı açın veya oluşturun
            using (StreamWriter dosya = new StreamWriter(dosyaYolu))
            {
                // Metinleri dosyaya yazın
                dosya.WriteLine(user_name);
                dosya.WriteLine(user_password);
                dosya.WriteLine(frontCam_ip);
                dosya.WriteLine(rearCam_ip);

                string server = "server=" + server_adress + ";";
                string username = "user=" + server_userName + ";";
                string database = "database="+database_name + ";";
                string password = "password=" + server_userPass + ";";
                
                dosya.WriteLine(server + username + database + password);

            }

            // İşlem tamamlandı mesajını gösterin
            MessageBox.Show("Bilgiler dosyaya yazıldı.");
        }
    }
}