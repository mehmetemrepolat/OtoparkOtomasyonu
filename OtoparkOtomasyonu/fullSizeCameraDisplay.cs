using System.Windows.Forms;
using System.Drawing;
using AForge.Video;
using AForge.Video.DirectShow;
using System;
namespace OtoparkOtomasyonu
{
    public partial class FullSizeCameraDisplay : Form
    {

        private MJPEGStream _cameraStream;
        public event EventHandler CameraFormClosed;
        private CameraMenu _parentForm; // cameraMenu formuna referans

        
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
        
        public FullSizeCameraDisplay(CameraMenu parent, string streamUrl)
        {
            InitializeComponent();
            _parentForm = parent; // cameraMenu formuna referansı atayın
            _cameraStream = new MJPEGStream(streamUrl);
            _cameraStream.NewFrame += CameraStream_NewFrame;
            _cameraStream.Start();
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _cameraStream.Stop();
            _parentForm.RestartVideoStream(); // cameraMenu formundaki video yayınını yeniden başlatın
        }

    }
}