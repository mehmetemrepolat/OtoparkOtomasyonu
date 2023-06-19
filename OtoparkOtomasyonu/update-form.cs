using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;

namespace OtoparkOtomasyonu
{
    public partial class UpdateForm : Form
    {
        private string _connectionString;

        
        //string _connectionString = "server=localhost;user=root;database=otopark-otomasyonu;password=413508;";

        private string _customerId;
        private string _oldName;
        private string _oldPhone;
        
        public UpdateForm(string customerName, string customerPhone, string customerPlate)
        {
            InitializeComponent();
            _connectionString = ReadConnectionStringFromSettings();
            
            update_1.FlatAppearance.BorderSize = 0; 
            update_1.FlatStyle = FlatStyle.Flat; 
            update_1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            update_1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            

            
            
            
            
            
            text_name.Text = customerName;
            text_phone.Text = customerPhone;
            text_plate.Text = customerPlate;
            
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cars");
    
            string imagePath = Path.Combine(directoryPath, customerPlate + ".png");
    
            // Resmi çekme işlemi veya kullanma
            if (File.Exists(imagePath))
            {
                car_photo.SizeMode = PictureBoxSizeMode.Zoom;
                car_photo.Image = Image.FromFile(imagePath);
            }
            
            
            text_name.KeyPress += textBox1_KeyPress;    // Sadece harf girişi
            text_phone.KeyPress += textBox3_KeyPress;   // Sadece sayı girişi

            _oldName = customerName;
            _oldPhone = customerPhone;
        }
        private string ReadConnectionStringFromSettings()
        {
            string dosyaYolu = "settings.ini";

            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                if (satirlar.Length >= 5)
                {
                    return satirlar[4];
                }
                else
                {
                    MessageBox.Show("Dosya formatı hatalı.");
                }
            }
            else
            {
                MessageBox.Show("Dosya bulunamadı.");
            }

            return null;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void update_Click(object sender, EventArgs e)
        {
            string newName = text_name.Text;
            string newPhone = text_phone.Text;
            string plate = text_plate.Text;

            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newPhone) )
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // Değişiklik kontrolü
            if (newName == _oldName && newPhone == _oldPhone)
            {
                MessageBox.Show("Değişiklik yapılmadı.");
                return;
            }


            if (car_photo.Image != null)
            {
                string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cars");
                if (!Directory.Exists(directoryPath))
                    Directory.CreateDirectory(directoryPath);

                string relativePath = Path.Combine("Cars", plate + ".png");
                string imagePath = Path.Combine(directoryPath, plate + ".png");
                ///
                try
                {
                    car_photo.Image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png);
                    car_photo.Image.Dispose(); // Kaynakları serbest bırak

                }
                
                catch (Exception exception)
                {

                    MessageBox.Show(Convert.ToString(exception));
                }
            }


            // Veritabanı güncelleme işlemi
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE customer SET customer_name = @newName, customer_phone = @newPhone WHERE customer_plate = @customerPlate";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@newName", newName);
                        command.Parameters.AddWithValue("@newPhone", newPhone);
                        command.Parameters.AddWithValue("@customerPlate", plate);
                        //command.Parameters.AddWithValue("@oldName", _oldName);
                        //command.Parameters.AddWithValue("@oldPhone", _oldPhone);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Müşteri bilgileri güncellendi.");
                        this.Hide();
                        UserEdit userEdit = new UserEdit();
                        userEdit.Show();
                        this.Hide();
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserEdit userEdit = new UserEdit();
            userEdit.Show();
            this.Hide();
        }


        private void car_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                car_photo.Image = Image.FromFile(openFileDialog.FileName);
                car_photo.SizeMode = PictureBoxSizeMode.Zoom;

            }
            
        }

        private void update_1_Click(object sender, EventArgs e)
        {
            string newName = text_name.Text;
            string newPhone = text_phone.Text;
            string plate = text_plate.Text;

            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newPhone) )
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // Değişiklik kontrolü
            if (newName == _oldName && newPhone == _oldPhone)
            {
                MessageBox.Show("Değişiklik yapılmadı.");
                return;
            }


            if (car_photo.Image != null)
            {
                string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cars");
                if (!Directory.Exists(directoryPath))
                    Directory.CreateDirectory(directoryPath);

                string relativePath = Path.Combine("Cars", plate + ".png");
                string imagePath = Path.Combine(directoryPath, plate + ".png");
                ///
                try
                {
                    car_photo.Image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png);
                    car_photo.Image.Dispose(); // Kaynakları serbest bırak

                }
                
                catch (Exception exception)
                {

                    MessageBox.Show(Convert.ToString(exception));
                }
            }


            // Veritabanı güncelleme işlemi
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE customer SET customer_name = @newName, customer_phone = @newPhone WHERE customer_plate = @customerPlate";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@newName", newName);
                        command.Parameters.AddWithValue("@newPhone", newPhone);
                        command.Parameters.AddWithValue("@customerPlate", plate);
                        //command.Parameters.AddWithValue("@oldName", _oldName);
                        //command.Parameters.AddWithValue("@oldPhone", _oldPhone);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Müşteri bilgileri güncellendi.");
                        this.Hide();
                        UserEdit userEdit = new UserEdit();
                        userEdit.Show();
                        this.Hide();
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
                
            }
        }
    }
}
