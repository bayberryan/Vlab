using Newtonsoft.Json;
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
using VLab.Controls;
using VLab.Models;

namespace VLab.Forms.MFK1
{
    public partial class FormSteps : Form
    {
        //步骤列表
        private List<Step> mSteps = new List<Step>();
        //热区控件
        private HotAreaControl mHotArea = new HotAreaControl();
        //热区定时
        private System.Timers.Timer mHotAreaTimer = new System.Timers.Timer();
        private int mHotAreaTick = 1000;
        //当前步骤序号
        private int mCurrentStep = 0;
        //当前步骤是否观看
        private bool mIsStepViewed = false;
        //当前设备类型
        public Device mDevice { get; set; }
        public FormSteps()
        {
            InitializeComponent();
            InitSteps();
            BindEvent();
        }
        public FormSteps(Device device)
        {
            mDevice = device;
            InitializeComponent();
            InitSteps();
            BindEvent();
        }

        private void InitSteps()
        {
            try
            {
                string stepFile = Path.Combine(mDevice.DataFolder, "media/steps.conf");
                mSteps = JsonConvert.DeserializeObject<List<Step>>(File.ReadAllText(stepFile));
            }
            catch (Exception ex) 
            {
                MessageBox.Show("加载实验步骤失败。");
            }
        }

        private void BindEvent() 
        {
            this.Load += new EventHandler(form_load);

            this.tabPageDevice.Click += new EventHandler(tabPageDevice_Click);

            mHotArea.Visible = true;
            mHotArea.Click += new EventHandler(HotArea_Click);

            mHotAreaTimer.AutoReset = false;
            mHotAreaTimer.Interval = mHotAreaTick;
            mHotAreaTimer.Enabled = true;

            this.btnNext.Click += new EventHandler(btnNext_Click);
        }

        private void form_load(object sender, EventArgs e)
        {
            LoadStep(mCurrentStep);
            mHotAreaTimer.Elapsed += new System.Timers.ElapsedEventHandler(HotAreaTimerOut);
        }
        /// <summary>
        /// 绘制带热区图片
        /// </summary>
        /// <param name="page"></param>
        /// <param name="hotPicture"></param>
        private void DrawHotPicture(Control page,HotPicture hotPicture) 
        {
            page.Controls.Clear();
            Console.WriteLine(page.Width);
            string picFile = Path.Combine(mDevice.DataFolder, hotPicture.Picture);
            Image picture = Image.FromFile(picFile);
            float xScale = (float)page.Width / picture.Width;
            float yScale = (float)page.Height / picture.Height;
            mHotArea.Width = (int)(hotPicture.HotArea.Width * xScale);
            mHotArea.Height = (int)(hotPicture.HotArea.Height * yScale);
            int scaleHotAreaX =  (int)(hotPicture.HotArea.X * xScale);
            int scaleHotAreaY = (int)(hotPicture.HotArea.Y * yScale);
            mHotArea.Location = new Point(scaleHotAreaX, scaleHotAreaY);
            mHotArea.BorderSize = 0;
            mHotArea.BorderColor = Color.Red;
            mHotArea.BorderStyle = BorderStyle.None;
            page.BackgroundImage = picture;
            page.BackgroundImageLayout = ImageLayout.Stretch;
            page.Controls.Add(mHotArea);
        }

        /// <summary>
        /// 加载步骤说明
        /// </summary>
        /// <param name="i"></param>
        private void LoadStep(int i)
        {
            Step step = mSteps[i];
            labelStep.Text = step.ID + "、" + step.Name;
            richTextBoxSteps.Text = step.Description;
            DrawHotPicture(tabPageDevice, step.PictureDefault);
        }

        /// <summary>
        /// 热区外点击提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPageDevice_Click(object sender, EventArgs e)
        {
            if (mHotArea != null)
            {
                this.toolTip1.Show("CLick me !", mHotArea, mHotAreaTick);
                mHotArea.BorderSize=2;
                mHotAreaTimer.Start();
            }
        }
        public void HotAreaTimerOut(object source, System.Timers.ElapsedEventArgs e)
        {
            if (mHotArea != null)
            {
                mHotArea.Invoke(new EventHandler(delegate
                {
                    mHotArea.BorderSize = 0;
                }));
            }
        }
        /// <summary>
        /// 热区点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HotArea_Click(object sender, EventArgs e)
        {
            String videdoFile = Path.Combine(mDevice.DataFolder, mSteps[mCurrentStep].PerformVideo);
            FormVideo frm = new FormVideo(videdoFile);
            frm.ShowDialog();
            mIsStepViewed = true;
        }
        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            new FormAboutSafyr().ShowDialog();
        }
        /// <summary>
        /// 下一步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (mIsStepViewed == false)
            {
                MessageBox.Show("请完成当前步骤！");
                return;
            }


            if (mCurrentStep < mSteps.Count - 1)
            {
                mCurrentStep++;
                mIsStepViewed = false;
                LoadStep(mCurrentStep);
            }
            else {

                MessageBox.Show("已完成全部步骤！");
                return;
            }
        }

    }
}
