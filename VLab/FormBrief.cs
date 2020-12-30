using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VLab.Forms.MFK1;
using VLab.Models;

namespace VLab
{
    public partial class FormBrief : Form
    {
        public Device mDevice { get; set; }
        public FormBrief(Device device )
        {
            InitializeComponent();
            mDevice = device;
            this.Load += new System.EventHandler(this.FormBrief_Load);
            btnPurpose.Click += new EventHandler(btn_Click);
            btnMaterial.Click += new EventHandler(btn_Click);
            btnSteps.Click += new EventHandler(btn_Click);
            btnStart.Click += new EventHandler(btn_Click);
        }
        private void FormBrief_Load(object sender, EventArgs e)
        {
            labelTitle.Text = mDevice.DeviceName;
            btnPurpose.PerformClick();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            try
            {
                if (btn == btnPurpose)
                {
                    rtbBrief.Clear();
                    rtbBrief.LoadFile(Path.Combine(mDevice.DataFolder, @"Doc\purpose.rtf"));
                }
                else if (btn == btnMaterial)
                {
                    rtbBrief.Clear();
                    rtbBrief.LoadFile(Path.Combine(mDevice.DataFolder, @"Doc\material.rtf"));
                }
                else if (btn == btnSteps)
                {
                    rtbBrief.Clear();
                    rtbBrief.LoadFile(Path.Combine(mDevice.DataFolder, @"Doc\steps.rtf"));
                }
                else if (btn == btnStart)
                {
                    FormSteps steps = new FormSteps(mDevice);
                    steps.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("实验数据丢失");
            }
        }


    }
}
