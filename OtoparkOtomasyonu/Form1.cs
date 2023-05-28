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
        private MJPEGStream ipCamStream;

        public Form1()
        {
            InitializeComponent();
        }

        private void ip_cam_Click(object sender, EventArgs e)
        {
            ipCamStream = new MJPEGStream("http://192.168.137.60");
            ipCamStream.NewFrame += new NewFrameEventHandler(ipCamStream_NewFrame);
            ipCamStream.Start();
        }

        private void ipCamStream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = frame;
        }
        
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.Stop();
            }
            if (ipCamStream != null && ipCamStream.IsRunning)
            {
                ipCamStream.Stop();
            }
        }


        private void pc_cam_Click(object sender, EventArgs e)
        {

            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.Stop();
            }

            // Get the list of available video devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
            }
        }
        

    }
}
