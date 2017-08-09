using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using CCWin.Win32;
using CCWin.Win32.Const;
using SM.BaseControls;

namespace SM.ManageUI
{
    public partial class FrmPopup : CCSkinMain
    {
        static int H = DateTime.Now.Hour;
        static string tempHello = (H > 5 & H <= 8 ? "早上好：" : H > 8 & H <= 12 ? "上午好：" : H > 12 & H <= 14 ? "中午好：" : H > 14 & H <= 20 ? "下午好：" : "晚上好：") + "\n\r    ";

        #region  构造函数
        /// <summary>
        /// 弹窗提示
        /// </summary>
        /// <param name="title">标题信息</param>
        /// <param name="content">内容信息</param>
        /// <param name="image">图像</param>
        public FrmPopup(string title, string content,Image image)
        {
            InitializeComponent();
            this.Text = title;
            pnlImgTx.BackgroundImage = image;
            skinLabel2.Text = tempHello + content;
        }
        /// <summary>
        /// 弹窗提示
        /// </summary>
        /// <param name="title">标题信息</param>
        /// <param name="content">内容信息</param>
        public FrmPopup(string title, string content)
        {
            InitializeComponent();
            this.Text = title;
            skinLabel2.Text = tempHello + content;
        }
        /// <summary>
        /// 弹窗提示
        /// </summary>
        /// <param name="content">内容</param>
        public FrmPopup(string content)
        {
            InitializeComponent();
            skinLabel2.Text = tempHello + content;
        }
        /// <summary>
        /// 弹窗提示
        /// </summary>
        public FrmPopup()
        {
            InitializeComponent();
        }
        #endregion

        //窗口加载时
        private void FrmInformation_Load(object sender, EventArgs e)
        {
            skinLabel1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //初始化窗口出现位置
            Point p = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            this.PointToScreen(p);
            this.Location = p;
            NativeMethods.AnimateWindow(this.Handle, 130, AW.AW_SLIDE + AW.AW_VER_NEGATIVE);//开始窗体动画
        }

        //倒计时三秒关闭弹出窗
        private void timShow_Tick(object sender, EventArgs e)
        {
            //鼠标不在窗体内时
            if (!this.Bounds.Contains(Cursor.Position))
            {
                this.Close();
            }
        }

        private void skinButtom1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IEXPLORE.exe", SString.Author);
        }
    }
}
