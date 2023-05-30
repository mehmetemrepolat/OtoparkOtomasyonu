using System;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Net.Sockets;
using System.Text;
using System.Net;


namespace OtoparkOtomasyonu
{
    public partial class cameraMenu : Form
    {
        
        private MJPEGStream frontCameraStream, rearCameraStream;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        
        private TcpListener tcpListener;

        
        public cameraMenu()
        {
            //tcpListener.Stop();
            InitializeComponent();
            loginInfoBack.FlatAppearance.BorderSize = 0; 
            loginInfoBack.FlatStyle = FlatStyle.Flat; 
            loginInfoBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            loginInfoBack.FlatAppearance.MouseOverBackColor = Color.Transparent;

            frontCameraStream = new MJPEGStream("http://192.168.137.60");  //Temp source
            frontCameraStream.NewFrame += new NewFrameEventHandler(frontCameraStream_NewFrame);
            frontCameraStream.Start();

            rearCameraStream = new MJPEGStream("http://127.0.0.1:5000/video_feed");
            rearCameraStream.NewFrame += new NewFrameEventHandler(rearCameraStream_NewFrame);
            rearCameraStream.Start();
            
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, 1234); // 1234 portunu kullanarak TCP sunucusunu başlatın
                tcpListener.Start();
                tcpListener.BeginAcceptTcpClient(OnClientConnected, null); // Bağlantı beklemek için asenkron bir işlem başlatın
            }
            catch (Exception ex)
            {
                //MessageBox.Show("TCP sunucusu başlatılırken bir hata oluştu: " + ex.Message);
            }
            
        }
        
        private void frontCameraStream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame_front = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = frame_front;
        }

        private void rearCameraStream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame_rear = (Bitmap)eventArgs.Frame.Clone();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = frame_rear;
        }
        
        

        private void frontCam_button_Click(object sender, EventArgs e)
        {
            frontCameraStream.Stop();
            string frontCameraUrl = "http://192.168.137.60"; // frontCameraStream URL'si
            fullSizeCameraDisplay fullSizeForm = new fullSizeCameraDisplay(this, frontCameraUrl);
            fullSizeForm.ShowDialog();
        }
        
        public void RestartVideoStream()
        {
            frontCameraStream.Start(); // frontCameraStream'i yeniden başlat
            rearCameraStream.Start(); // rearCameraStream'i yeniden başlat
        }

        private void rearCam_button_Click(object sender, EventArgs e)
        {
            rearCameraStream.Stop();
            string rearCameraUrl = "http://127.0.0.1:5000/video_feed";
            fullSizeCameraDisplay fullSizeFormRear = new fullSizeCameraDisplay(this, rearCameraUrl);
            fullSizeFormRear.ShowDialog();
        }

        private void OnClientConnected(IAsyncResult ar)
        {
            TcpClient client = tcpListener.EndAcceptTcpClient(ar);
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            //string message = Encoding.Default.GetString(buffer, 0, bytesRead);

            this.Invoke(new Action(() =>
            {
                entered_Car.Text = message; 
            }));
    
            
            tcpListener.BeginAcceptTcpClient(OnClientConnected, null);
        }

        private void loginInfoBack_Click(object sender, EventArgs e)
        {
            
            mainMenu mainMenuForm = new mainMenu();
            mainMenuForm.Show();
            this.Close();
        }

    }
}