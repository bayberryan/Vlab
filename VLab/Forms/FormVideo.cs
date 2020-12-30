using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VLab.Forms
{
    public partial class FormVideo : Form
    {
        public String VideoUrl{get;set;}
         
        public FormVideo()
        {
            InitializeComponent();
        }
        public FormVideo(String url)
        {
            VideoUrl = url;
            InitializeComponent();
        }

        private void FormVideo_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer.close();
        }

        private void FormVideo_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL=VideoUrl;
        }

    }
}
