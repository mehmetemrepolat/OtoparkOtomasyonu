using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OtoparkOtomasyonu
{
    public partial class update_form : Form
    {
        string connectionString = "server=localhost;user=root;database=otopark-otomasyonu;password=413508;";

        private string customerId;
        private string oldName;
        private string oldPhone;
        
        public update_form(string customerName, string customerPhone, string customerPlate)
        {
            InitializeComponent();
            
            text_name.Text = customerName;
            text_phone.Text = customerPhone;
            text_plate.Text = customerPlate;
            
            
            text_name.KeyPress += textBox1_KeyPress;    // Sadece harf girişi
            text_phone.KeyPress += textBox3_KeyPress;   // Sadece sayı girişi

            oldName = customerName;
            oldPhone = customerPhone;
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
            string newPhone = text_plate.Text;
            string newPlate = text_phone.Text;

            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newPhone) || string.IsNullOrEmpty(newPlate))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // Değişiklik kontrolü
            if (newName == oldName || newPhone == oldPhone)
            {
                MessageBox.Show("Değişiklik yapılmadı.");
                return;
            }

            // Veritabanı güncelleme işlemi
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE customer SET customer_name = @newName, customer_phone = @newPhone, customer_plate = @newPlate WHERE customer_name = @oldName AND customer_phone = @oldPhone";

                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@newName", newName);
                    command.Parameters.AddWithValue("@newPhone", newPhone);
                    command.Parameters.AddWithValue("@newPlate", newPlate);
                    command.Parameters.AddWithValue("@oldName", oldName);
                    command.Parameters.AddWithValue("@oldPhone", oldPhone);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Müşteri bilgileri güncellendi.");
                    this.Hide();
                    userEdit userEdit = new userEdit();
                    userEdit.Show();
                    this.Hide();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userEdit userEdit = new userEdit();
            userEdit.Show();
            this.Hide();
        }
    }
}
