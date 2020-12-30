using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VLab.Models;

namespace VLab
{
    public partial class FormMain : Form
    {
        private Device mDevice = new Device();
        public FormMain()
        {
            InitializeComponent();

            btnMFK1.MouseEnter += new EventHandler(btn_MouseEnter);
            btnMFK1.MouseLeave += new EventHandler(btn_MouseLeave);
            btnCAMSIZER.MouseEnter += new EventHandler(btn_MouseEnter);
            btnCAMSIZER.MouseLeave += new EventHandler(btn_MouseLeave);
            btnMFK1.Click += new EventHandler(btn_Click);
            btnCAMSIZER.Click += new EventHandler(btn_Click);
        }


        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == btnMFK1)
            {
                this.pictureBox1.Image = Properties.Resources.bg_mfk1;
            }
            else if (btn == btnCAMSIZER)
            {
            }

        }
        private void btn_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.bg;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == btnMFK1)
            {

                mDevice.DeviceName = "MFK1-FA型卡帕桥磁化率仪操作实验";
                mDevice.DataFolder = Path.Combine(Application.StartupPath, "Data/MFK1");
            }
            else if (btn == btnCAMSIZER)
            {
                mDevice.DeviceName = "动态图像粒度粒形分析仪CAMSIZERX2操作实验";
                mDevice.DataFolder = Path.Combine(Application.StartupPath, "Data/CAMSIZER");
            }
            new FormBrief(mDevice).ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
