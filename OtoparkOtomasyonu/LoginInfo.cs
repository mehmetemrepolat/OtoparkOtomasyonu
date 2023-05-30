using System;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.IO;

namespace OtoparkOtomasyonu
{
    public partial class LoginInfo : Form
    {
        private string connectionString = "server=localhost;user=root;database=otopark-otomasyonu;password=413508;";

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
            
            clearButton.FlatAppearance.BorderSize = 0; 
            clearButton.FlatStyle = FlatStyle.Flat; 
            clearButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            clearButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            userList.FlatAppearance.BorderSize = 0; 
            userList.FlatStyle = FlatStyle.Flat; 
            userList.FlatAppearance.MouseDownBackColor = Color.Transparent;
            userList.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            customerName.KeyPress += customerName_KeyPress;
            customerPhone.KeyPress += customerPhone_KeyPress;
            
            car_img.Click += car_img_Click;
            car_img.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void loginInfoBack_Click(object sender, EventArgs e)
        {
            mainMenu mainMenuForm = new mainMenu();
            mainMenuForm.Show();
            this.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            customerName.Clear();
            customerPhone.Clear();
            customerPlate.Clear();
            customerRegDate.Clear();
            car_img.Image = null;
        }

        private void car_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                car_img.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void addReg_Click(object sender, EventArgs e)
        {
            string userName = customerName.Text;
            string userPhone = customerPhone.Text;
            string userPlate = customerPlate.Text;
            string userRegDate = customerRegDate.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO customer (customer_name, customer_phone, customer_plate, customer_join_date) " +
                                   "VALUES (@Name, @Phone, @Plate, @RegDate)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", userName);
                        command.Parameters.AddWithValue("@Phone", userPhone);
                        command.Parameters.AddWithValue("@Plate", userPlate);
                        command.Parameters.AddWithValue("@RegDate", userRegDate);
                        
                        command.ExecuteNonQuery();

                        MessageBox.Show("Kullanıcı Başarıyla Eklendi");
                        
                        if (car_img.Image != null)
                        {
                            string directoryPath = Application.StartupPath + "\\Cars";
                            if (!Directory.Exists(directoryPath))
                                Directory.CreateDirectory(directoryPath);

                            string imagePath = Path.Combine(directoryPath, userPlate + ".png");
                            car_img.Image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png);
                        }

                        customerName.Clear();
                        customerPhone.Clear();
                        customerPlate.Clear();
                        customerRegDate.Clear();
                        car_img.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata! Kullanıcı eklenemedi: " + ex.Message);
                }
            }
        }

        private void customerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece harf girişi
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        
        private void customerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam girişi
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void userList_Click(object sender, EventArgs e)
        {
            userEdit userEditForm = new userEdit();
            userEditForm.Show();
            this.Hide();
        }
    }
}