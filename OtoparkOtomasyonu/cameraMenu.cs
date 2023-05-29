using System;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;


namespace OtoparkOtomasyonu
{
    public partial class cameraMenu : Form
    {
        
        private MJPEGStream frontCameraStream, rearCameraStream;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        
        public cameraMenu()
        {
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
        

        private void loginInfoBack_Click(object sender, EventArgs e)
        {
            
            
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


    }
}