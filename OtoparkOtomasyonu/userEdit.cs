using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Drawing;

namespace OtoparkOtomasyonu
{
    public partial class UserEdit : Form
    {

        private string _connectionString;
        
        public UserEdit()
        {
            InitializeComponent();
            
            
            userEditBack.FlatAppearance.BorderSize = 0; 
            userEditBack.FlatStyle = FlatStyle.Flat; 
            userEditBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            userEditBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            update_customer.FlatAppearance.BorderSize = 0; 
            update_customer.FlatStyle = FlatStyle.Flat; 
            update_customer.FlatAppearance.MouseDownBackColor = Color.Transparent;
            update_customer.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            delete_record.FlatAppearance.BorderSize = 0; 
            delete_record.FlatStyle = FlatStyle.Flat; 
            delete_record.FlatAppearance.MouseDownBackColor = Color.Transparent;
            delete_record.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            
            
            _connectionString = ReadConnectionStringFromSettings();
            ShowCustomerData();

        }
    
        public void ShowCustomerData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
    
                    string query = "SELECT customer_name, customer_phone, customer_plate, customer_join_date FROM customer";
    
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            // Verileri bir DataTable'e yükleme
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
    
                            dataTable.Columns["customer_name"].ColumnName = "Ad Soyad";
                            dataTable.Columns["customer_phone"].ColumnName = "Telefon";
                            dataTable.Columns["customer_plate"].ColumnName = "Plaka";
                            dataTable.Columns["customer_join_date"].ColumnName = "Kayıt Tarihi";
                            
                            user_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    
                            user_view.DataSource = dataTable;
                            user_view.EditMode = DataGridViewEditMode.EditProgrammatically;
                            user_view.AllowUserToResizeRows = false;
                            user_view.AllowUserToResizeColumns = false;
    
                            user_view.RowHeadersVisible = false;
                            user_view.CellDoubleClick += user_view_CellDoubleClick;
    
    
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yükleme hatası: " + ex.Message);
            }
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
        
        private void update_customer_Click(object sender, EventArgs e)
        {
            
            
        }
    
        private void userEditBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginInfo userAddFrom = new LoginInfo();
            userAddFrom.Show();
            this.Hide();
        }
    
        private void user_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = user_view.Rows[e.RowIndex];
    
                // Seçili satırdaki verileri al
                string customerName = selectedRow.Cells["Ad Soyad"].Value.ToString();
                string customerPhone = selectedRow.Cells["Telefon"].Value.ToString();
                string customerPlate = selectedRow.Cells["Plaka"].Value.ToString();
    
                // Diğer forma aktar
                UpdateForm updateForm = new UpdateForm(customerName, customerPhone, customerPlate);
                updateForm.Show();
            }
            
        }
    
        private void delete_record_Click(object sender, EventArgs e)
        {
            if (user_view.CurrentRow != null)
            {
                DataGridViewRow selectedRow = user_view.CurrentRow;
    
                // Seçili satırdaki verileri al
                string customerName = selectedRow.Cells["Ad Soyad"].Value.ToString();
                string customerPhone = selectedRow.Cells["Telefon"].Value.ToString();
                string customerPlate = selectedRow.Cells["Plaka"].Value.ToString();
    
                // Veritabanından satırı silme işlemi
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(_connectionString))
                    {
                        connection.Open();
    
                        string deleteQuery =
                            "DELETE FROM customer WHERE customer_name = @customerName AND customer_phone = @customerPhone AND customer_plate = @customerPlate";
    
                        using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@customerName", customerName);
                            command.Parameters.AddWithValue("@customerPhone", customerPhone);
                            command.Parameters.AddWithValue("@customerPlate", customerPlate);
                            command.ExecuteNonQuery();
    
                            MessageBox.Show("Kayıt Silindi");
                            ShowCustomerData(); // Verilerin güncellenmesi için yeniden yükleme yapılıyor
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
        }
    
    
        private void find_customer_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = find_customer.Text;
    
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
    
                    string query = "SELECT customer_name, customer_phone, customer_plate, customer_join_date FROM customer WHERE customer_name LIKE @searchKeyword";
    
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@searchKeyword", "%" + searchKeyword + "%");
    
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
    
                            dataTable.Columns["customer_name"].ColumnName = "Ad Soyad";
                            dataTable.Columns["customer_phone"].ColumnName = "Telefon";
                            dataTable.Columns["customer_plate"].ColumnName = "Plaka";
                            dataTable.Columns["customer_join_date"].ColumnName = "Kayıt Tarihi";
    
                            user_view.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yükleme hatası: " + ex.Message);
            }
        }
    
        private void userEditBack_Click_1(object sender, EventArgs e)
        {
            LoginInfo loginInfo = new LoginInfo();
            loginInfo.Show();
            this.Hide();
        }
    
        private void user_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = user_view.Rows[e.RowIndex];
    
                // Seçili satırdaki verileri al
                string customerPlate = selectedRow.Cells["Plaka"].Value.ToString();
    
                // Dosya yolu oluşturma
                string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cars");
    
                string imagePath = Path.Combine(directoryPath, customerPlate + ".png");
    
                // Resmi çekme işlemi veya kullanma
                if (File.Exists(imagePath))
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                //else
                //{
                //    MessageBox.Show("Dosya bulunamadı");
                //}
            }
        }
}
}