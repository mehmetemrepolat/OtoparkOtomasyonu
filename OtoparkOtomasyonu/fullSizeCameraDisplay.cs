using System.Windows.Forms;
using System.Drawing;
using AForge.Video;
using AForge.Video.DirectShow;
using System;
namespace OtoparkOtomasyonu
{
    public partial class fullSizeCameraDisplay : Form
    {

        private MJPEGStream cameraStream;
        public event EventHandler CameraFormClosed;
        private cameraMenu parentForm; // cameraMenu formuna referans

        
        public Image FullSizeImage
        {
            get { return full_sizeBox.Image; }
            set { full_sizeBox.Image = value; }
        }
        private void CameraStream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            full_sizeBox.SizeMode = PictureBoxSizeMode.StretchImage;
            full_sizeBox.Image = frame;
        }
        
        public fullSizeCameraDisplay(cameraMenu parent, string streamUrl)
        {
            InitializeComponent();
            parentForm = parent; // cameraMenu formuna referansı atayın
            cameraStream = new MJPEGStream(streamUrl);
            cameraStream.NewFrame += CameraStream_NewFrame;
            cameraStream.Start();
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            cameraStream.Stop();
            parentForm.RestartVideoStream(); // cameraMenu formundaki video yayınını yeniden başlatın
        }

    }
}