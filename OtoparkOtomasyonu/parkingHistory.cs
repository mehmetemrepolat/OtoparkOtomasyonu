using System.Windows.Forms;
using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace OtoparkOtomasyonu
{
    public partial class ParkingHistory : Form
    {
        //private string _connectionString = "server=localhost;user=root;database=otopark-otomasyonu;password=413508;";
        private string _carsFolderPath = "Cars/";

        private string _connectionString;

        public ParkingHistory()
        {
            InitializeComponent();
            
            
            
            loginInfoBack.FlatAppearance.BorderSize = 0; 
            loginInfoBack.FlatStyle = FlatStyle.Flat; 
            loginInfoBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            loginInfoBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            
            
            _connectionString = ReadConnectionStringFromSettings();

            ShowHistoryData();
            parking_view.SelectionChanged += Parking_view_SelectionChanged;
            
            customer_car.SizeMode = PictureBoxSizeMode.StretchImage;


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

        private void Parking_view_SelectionChanged(object sender, EventArgs e)
        {
            if (parking_view.SelectedCells.Count > 0)
            {
                int selectedRowIndex = parking_view.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = parking_view.Rows[selectedRowIndex];
                string customerPlate = selectedRow.Cells["customer_plate"].Value.ToString();
                
                // Bu kısım kullanılabilir.
                string imagePath = Path.Combine(_carsFolderPath, customerPlate + ".png");

                if (File.Exists(imagePath))
                {
                    customer_car.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // İlgili dosya bulunamazsa varsayılan bir görüntü atanabilir veya boş bırakılabilir.
                    customer_car.Image = null;
                }
                GetCustomerDetails(customerPlate);

            }
        }

        private void GetCustomerDetails(string customerPlate)
        {
             try
             {
               using (MySqlConnection connection = new MySqlConnection(_connectionString))
               {
                   connection.Open();
                   string query = "SELECT customer_name, customer_phone FROM customer WHERE customer_plate = @customerPlate";
                   using (MySqlCommand command = new MySqlCommand(query, connection))
                   {
                       command.Parameters.AddWithValue("@customerPlate", customerPlate);
                       using (MySqlDataReader reader = command.ExecuteReader())
                       {
                           if (reader.Read())
                           {
                               string customerName = reader["customer_name"].ToString();
                               string customerPhone = reader["customer_phone"].ToString();
                               customer_name.Text = customerName;
                               customer_phone.Text = customerPhone;
                           }
                           else
                           {
                               customer_name.Text = string.Empty;
                               customer_phone.Text = string.Empty;
                           }
                       }
                   }
               }
             }
             catch (Exception e)
             {
                    Console.WriteLine(e);
                    throw;
             }
        }

        private void ShowHistoryData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT customer_plate, parking_date, left_date FROM parkinghistory";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            
                            parking_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            parking_view.DataSource = dataTable;
                            parking_view.EditMode = DataGridViewEditMode.EditProgrammatically;
                            parking_view.AllowUserToResizeRows = false;
                            parking_view.AllowUserToResizeColumns = false;
                            parking_view.RowHeadersVisible = false;
                            customer_car.BackColor = Color.Transparent;


                            parking_view.Columns[0].HeaderText = "Müşteri Plakası";
                            parking_view.Columns[1].HeaderText = "Park Etme Tarihi";
                            parking_view.Columns[2].HeaderText = "Ayrılış Tarihi";



                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void loginInfoBack_Click(object sender, EventArgs e)
        {
            CameraMenu cameraMenu = new CameraMenu();
            cameraMenu.RestartTcpListeners(); // TcpListener'ları yeniden başlat
            this.Close();
        }
    }
}