using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace OtoparkOtomasyonu
{
    public partial class Form1 : Form
    {
        private MJPEGStream _ipCamStream;

        public Form1()
        {
            InitializeComponent();
        }

        private void ip_cam_Click(object sender, EventArgs e)
        {
            _ipCamStream = new MJPEGStream("http://192.168.137.60");
            _ipCamStream.NewFrame += new NewFrameEventHandler(ipCamStream_NewFrame);
            _ipCamStream.Start();
        }

        private void ipCamStream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = frame;
        }
        
        private FilterInfoCollection _videoDevices;
        private VideoCaptureDevice _videoSource;

        

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_videoSource != null && _videoSource.IsRunning)
            {
                _videoSource.Stop();
            }
            if (_ipCamStream != null && _ipCamStream.IsRunning)
            {
                _ipCamStream.Stop();
            }
        }


        private void pc_cam_Click(object sender, EventArgs e)
        {

            if (_videoSource != null && _videoSource.IsRunning)
            {
                _videoSource.Stop();
            }

            // Get the list of available video devices
            _videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (_videoDevices.Count > 0)
            {
                _videoSource = new VideoCaptureDevice(_videoDevices[0].MonikerString);
                _videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                _videoSource.Start();
            }
        }
        

    }
}
