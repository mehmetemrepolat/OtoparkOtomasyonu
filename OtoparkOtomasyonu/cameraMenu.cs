using System;
using System.Windows.Forms;
using System.Drawing;
using AForge.Video;
using System.Net.Sockets;
using System.Text;
using System.Net;
using System.IO;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace OtoparkOtomasyonu
{
    public partial class CameraMenu : Form
    {
     
        private TcpListener tcpListener;
        private TcpListener tcpListener2;
        private MJPEGStream _frontCameraStream, _rearCameraStream;
        private string frontCamURL, rearCamURL;
        private string _connectionString;
        
        
        private bool isTcpListenerRunning; // Yeni bir değişken tanımlayın


        
        public CameraMenu()
        {
            
            //tcpListener.Stop();
            InitializeComponent();
            
            isTcpListenerRunning = false; // TcpListener'ın başlangıçta çalışmadığını belirtmek için değişkeni false olarak ayarlayın

            
            _connectionString = ReadConnectionStringFromSettings();
            rearCamURL = ReadRearCam_FromSettings();
            frontCamURL = ReadFrontCam_FromSettings();
            ReadFrontCam_FromSettings();
            //MessageBox.Show(_connectionString);
            loginInfoBack.FlatAppearance.BorderSize = 0; 
            loginInfoBack.FlatStyle = FlatStyle.Flat; 
            loginInfoBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            loginInfoBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            

            _frontCameraStream = new MJPEGStream(frontCamURL);  //Temp source
            _frontCameraStream.NewFrame += new NewFrameEventHandler(frontCameraStream_NewFrame);
            _frontCameraStream.Start();
            //_rearCameraStream = new MJPEGStream("http://127.0.0.1:5000/video_feed");
            _rearCameraStream = new MJPEGStream(rearCamURL);
            _rearCameraStream.NewFrame += new NewFrameEventHandler(rearCameraStream_NewFrame);
            _rearCameraStream.Start();
            
            
            frontCam_button_1.FlatAppearance.BorderSize = 0; 
            frontCam_button_1.FlatStyle = FlatStyle.Flat; 
            frontCam_button_1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            frontCam_button_1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            
            
            rearCam_button_1.FlatAppearance.BorderSize = 0; 
            rearCam_button_1.FlatStyle = FlatStyle.Flat; 
            rearCam_button_1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            rearCam_button_1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            
            button1.FlatAppearance.BorderSize = 0; 
            button1.FlatStyle = FlatStyle.Flat; 
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            
            

            tcpListener = new TcpListener(IPAddress.Any, 1234);
            
            if (!tcpListener.Server.IsBound)
            {
                tcpListener.Stop();
                tcpListener.Start();
                tcpListener.BeginAcceptTcpClient(OnClientConnected, null);

            }
            else
            {
                MessageBox.Show("Çalışmıyor");
            }
            
            
            tcpListener2 = new TcpListener(IPAddress.Any, 1235);
            tcpListener2.Start();
            tcpListener2.BeginAcceptTcpClient(OnClientConnected2, null);
        }
        
        private bool CheckCarExists(string plateNumber)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    
                    command.CommandText = "SELECT COUNT(*) FROM customer WHERE customer_plate = @plateNumber";
                    command.Parameters.AddWithValue("@plateNumber", plateNumber);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                    
                    return count > 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                    return false;
                }
            }
        }

        private bool CheckCarInside(string plateNumber)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    
                    command.CommandText = "SELECT COUNT(*) FROM parkinghistory WHERE customer_plate = @plateNumber AND is_it_inside = '1'";
                    command.Parameters.AddWithValue("@plateNumber", plateNumber);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                    
                    return count > 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                    return false;
                }
            }
        }
        
        private void entered_Car_TextChanged(object sender, EventArgs e)
        {
            string entered_Car = this.entered_Car.Text;
            
            if(!string.IsNullOrEmpty(entered_Car))
            {
                if (CheckCarExists(entered_Car))
                {
                    if (!CheckCarInside(entered_Car))
                    {
                        
                        using (MySqlConnection connection = new MySqlConnection(_connectionString))
                        {
                            try
                            {
                                connection.Open();
                                MySqlCommand command = new MySqlCommand();
                                command.Connection = connection;
                                DateTime currentDate = DateTime.Now.Date;
                                DateTime currentDateTime = DateTime.Now;
                                string datetime = currentDate.ToString("yyyy-MM-dd") + " " +
                                                  currentDateTime.ToString("HH:mm:ss");
                                string deneme = "1";
                                command.CommandText =
                                    "INSERT INTO parkinghistory(customer_plate, parking_date, left_date, is_it_inside) VALUES (@plateNumber, @parkingDate, @leftDate, '1')";
                                command.Parameters.AddWithValue("@plateNumber", entered_Car);
                                command.Parameters.AddWithValue("@parkingDate", datetime);
                                command.Parameters.AddWithValue("@leftDate", deneme);
                                command.ExecuteNonQuery();
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show("Veritabanı hatası: " + exception.Message);
                                Console.WriteLine(exception);
                                throw;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Araba Veritabanında yok");
                    MessageBox.Show("Mevcut araç kayıtlı değil!");

                }
            }
        }
        
        
        private void left_car_TextChanged(object sender, EventArgs e)
        {

            string lefted_car = left_car.Text;
            if (!string.IsNullOrEmpty(lefted_car))
            {
                if (CheckCarInside(lefted_car))
                {
                    using (MySqlConnection connection = new MySqlConnection(_connectionString))
                    {
                        try
                        {
                            DateTime currentDate = DateTime.Now.Date;
                            DateTime currentDateTime = DateTime.Now;
                            string datetime = currentDate.ToString("yyyy-MM-dd") + " " +
                                              currentDateTime.ToString("HH:mm:ss");
                            //update gerçekleşecek parking_history'de is_it_inside = 2 olacak, çıkış yapmış sayılacak
                            connection.Open();
                            MySqlCommand command = new MySqlCommand();
                            command.Connection = connection;
                            command.CommandText =
                                "UPDATE parkinghistory SET is_it_inside = '2', left_date = @leftDate WHERE customer_plate = @plateNumber AND is_it_inside = '1'";
                            
                            command.Parameters.AddWithValue("@plateNumber", lefted_car);
                            command.Parameters.AddWithValue("@leftDate", datetime);


                            command.ExecuteNonQuery();

                        }
                        catch (Exception exception)
                        {
                            string mesaj = Convert.ToString(exception); 
                            MessageBox.Show(mesaj);
                            throw;
                        }
                        
                        
                    }
                }
            }


        }

        private void guest_car_add(string plate)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    DateTime currentDate = DateTime.Now.Date;
                    DateTime currentDateTime = DateTime.Now;
                    string datetime = currentDate.ToString("yyyy-MM-dd") + " " +
                                      currentDateTime.ToString("HH:mm:ss");
                    string deneme = "1";
                    //command.CommandText = "INSERT INTO parkinghistory(customer_plate, parking_date, parked_time, is_it_inside) VALUES (@plateNumber, @parkingDate, @parkedTime, '1')";

                    command.CommandText =
                        "INSERT INTO customer(customer_name, customer_phone, customer_plate, customer_join_date) VALUES(@customerName, @customerPhone, @customerPlate, @customerJoinDate)";
                    command.Parameters.AddWithValue("@customerName", "Bilinmeyen Müşteri");
                    command.Parameters.AddWithValue("@customerPhone", "Bilinmeyen");
                    command.Parameters.AddWithValue("@customerPlate", plate);
                    command.Parameters.AddWithValue("@customerJoinDate", datetime);
                    
                    command.ExecuteNonQuery();
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Veritabanı hatası: " + exception.Message);
                }
            }
        }
        
        private void OnClientConnected(IAsyncResult ar)
        {
            TcpClient client = tcpListener.EndAcceptTcpClient(ar);
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            this.Invoke(new Action(() =>
            {
                entered_Car.Text = message;
            }));

            //client.Close();
            tcpListener.BeginAcceptTcpClient(OnClientConnected, null);
        }
        
        
        private void OnClientConnected2(IAsyncResult ar)
        {
            TcpClient client = tcpListener2.EndAcceptTcpClient(ar);
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            // İkinci TcpListener için gelen mesajı işleyin
            this.Invoke(new Action(() =>
            {
                left_car.Text = message;
            }));
            
            client.Close();
            tcpListener2.BeginAcceptTcpClient(OnClientConnected2, null);
        }

        private string ReadFrontCam_FromSettings()
        {
            string dosyaYolu = "settings.ini";
            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                if (satirlar.Length >= 5)
                {
                    return satirlar[2];
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
        
        private string ReadRearCam_FromSettings()
        {
            string dosyaYolu = "settings.ini";
            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                if (satirlar.Length >= 5)
                {
                    return satirlar[3];
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
        
        private void frontCameraStream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frameFront = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = frameFront;
        }

        private void rearCameraStream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frameRear = (Bitmap)eventArgs.Frame.Clone();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = frameRear;
        }
        
        


        
        public void RestartVideoStream()
        {
            _frontCameraStream.Start(); // frontCameraStream'i yeniden başlat   
            _rearCameraStream.Start(); // rearCameraStream'i yeniden başlat
        }

        private void frontCam_button_1_Click(object sender, EventArgs e)
        {


        }
        
        private void rearCam_button_Click(object sender, EventArgs e)
        {

        }



        private void loginInfoBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            this.Close();
        }

        private void parking_history_Click(object sender, EventArgs e)
        {
            
            ParkingHistory parkingHistory = new ParkingHistory();
            parkingHistory.Show();
        }

        public void RestartTcpListeners()
        {
            StopTcpListener();
            tcpListener.Start();
            tcpListener.BeginAcceptTcpClient(OnClientConnected, null);
    
            tcpListener2.Stop();
            tcpListener2.Start();
            tcpListener2.BeginAcceptTcpClient(OnClientConnected2, null);
        }

        private void StartTcpListener()
        {
            if (!isTcpListenerRunning)
            {
                tcpListener.Start();
                tcpListener.BeginAcceptTcpClient(OnClientConnected, null);
                isTcpListenerRunning = true;
            }
        }
        
        
        private void StopTcpListener()
        {
            if (isTcpListenerRunning)
            {
                tcpListener.Stop();
                isTcpListenerRunning = false;
            }
        }
        
        private void frontCam_button_1_Click_1(object sender, EventArgs e)
        {
        }

        private void frontCam_button_1_Click_2(object sender, EventArgs e)
        {
            _frontCameraStream.Stop();
            //string frontCameraUrl = "http://192.168.137.60"; // frontCameraStream URL'si
            
            if (!string.IsNullOrEmpty(frontCamURL)) // rearCamURL değeri boş değilse devam et
            {
                FullSizeCameraDisplay fullSizeFormRear = new FullSizeCameraDisplay(this, frontCamURL);
                fullSizeFormRear.ShowDialog();
            }
            else
            {
                MessageBox.Show("Video kaynağı belirtilmemiş.");
            }        }

        private void rearCam_button_1_Click(object sender, EventArgs e)
        {
            _rearCameraStream.Stop();

            if (!string.IsNullOrEmpty(rearCamURL)) // rearCamURL değeri boş değilse devam et
            {
                FullSizeCameraDisplay fullSizeFormRear = new FullSizeCameraDisplay(this, rearCamURL);
                fullSizeFormRear.ShowDialog();
            }
            else
            {
                MessageBox.Show("Video kaynağı belirtilmemiş.");
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParkingHistory parkingHistory = new ParkingHistory();
            parkingHistory.Show();
        }
    }
}