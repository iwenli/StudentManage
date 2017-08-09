using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using SM.ManageUI.Code;
using SM.BaseControls;
using SM.ManageUI.Controls;

namespace SM.ManageUI.Forms
{
    public partial class MainForm : Form
    {
        private Bitmap maxBitmap;
        private Bitmap resoreBitmap;
        private Bitmap menu01,menu02,menu03,menu04,menu05,menu06,menu07,menu08,menu09,menu10;
        //private Point _captionMouseUp;
        protected ContextMenuStrip SkinContextMenuStrip1;

       // Controls.Test[] t = new Controls.Test[10];
        
        public MainForm()
        {
            //绘制页面
            InitializeComponent();
            
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;

                if (lblTopText != null)
                    this.lblTopText.Text = value;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //初始化
            GCtimer.Start();
            this.lblTopText.Text = this.Text;
            this.ReSetFormBitmap();
            //弹窗
            //FrmPopup frm = new FrmPopup();
            //frm.Show();
        }

        # region 绘制窗体
        /// <summary>
        /// 绘制窗体
        /// </summary>
        public void ReSetFormBitmap()
        {
            
            this.pnlTop.BackgroundImage = Image.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Border.top_bg.png"));

            this.ptbTopLeft.BackgroundImage = Image.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Border.top_bg_left.png"));
            this.ptbTopMiddle.BackgroundImage = Image.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Border.top_bg.png"));
            this.ptbTopRightLogo.BackgroundImage = Image.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Border.top_bg_right_logo.png"));

            this.ptbTopRight.BackgroundImage = Image.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Border.top_bg_right.png"));

            this.ptbLeft.BackgroundImage = Image.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Border.border.png"));
            this.ptbRight.BackgroundImage = Image.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Border.border.png"));

            this.pnlBottom.BackgroundImage = Image.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Border.bottom_bg.png"));
            this.ptbBottomLeft.BackgroundImage = Image.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Border.bottom_left.png"));
            this.ptbBottomMiddle.BackgroundImage = Image.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Border.bottom_bg.png"));
            this.ptbBottomRight.BackgroundImage = Image.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Border.bottom_right.png"));

            //this.ptbBottomTitle.BackgroundImage = Image.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Border.bottom_title.png"));
            this.pnlBody.BackgroundImage = Image.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Border.body.png"));
            //this.pnlBackground.BackgroundImage = Image.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Border.bg.bmp"));
            //this.pnlBackGroup.BackColor = Color.FromArgb(163, 217, 254);

            this.ptbTopMenu.BackgroundImage = Image.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Transparent.png"));

            menu01 = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Menu.1.png")));
            this.btnMenu01.NormalImage = menu01.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu01.MouseMoveImage = menu01.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu01.MouseDownImage = menu01.Clone(new Rectangle(138, 0, 69, 79), PixelFormat.Format64bppPArgb);

            menu02 = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Menu.2.png")));
            this.btnMenu02.NormalImage = menu02.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu02.MouseMoveImage = menu02.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu02.MouseDownImage = menu02.Clone(new Rectangle(138, 0, 69, 79), PixelFormat.Format64bppPArgb);

            menu03 = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Menu.3.png")));
            this.btnMenu03.NormalImage = menu03.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu03.MouseMoveImage = menu03.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu03.MouseDownImage = menu03.Clone(new Rectangle(138, 0, 69, 79), PixelFormat.Format64bppPArgb);

            menu04 = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Menu.4.png")));
            this.btnMenu04.NormalImage = menu04.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu04.MouseMoveImage = menu04.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu04.MouseDownImage = menu04.Clone(new Rectangle(138, 0, 69, 79), PixelFormat.Format64bppPArgb);

            menu05 = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Menu.5.png")));
            this.btnMenu05.NormalImage = menu05.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu05.MouseMoveImage = menu05.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu05.MouseDownImage = menu05.Clone(new Rectangle(138, 0, 69, 79), PixelFormat.Format64bppPArgb);

            menu06 = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Menu.6.png")));
            this.btnMenu06.NormalImage = menu06.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu06.MouseMoveImage = menu06.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu06.MouseDownImage = menu06.Clone(new Rectangle(138, 0, 69, 79), PixelFormat.Format64bppPArgb);

            menu07 = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Menu.7.png")));
            this.btnMenu07.NormalImage = menu07.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu07.MouseMoveImage = menu07.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu07.MouseDownImage = menu07.Clone(new Rectangle(138, 0, 69, 79), PixelFormat.Format64bppPArgb);

            menu08 = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Menu.8.png")));
            this.btnMenu08.NormalImage = menu08.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu08.MouseMoveImage = menu08.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu08.MouseDownImage = menu08.Clone(new Rectangle(138, 0, 69, 79), PixelFormat.Format64bppPArgb);

            menu09 = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Menu.9.png")));
            this.btnMenu09.NormalImage = menu09.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu09.MouseMoveImage = menu09.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu09.MouseDownImage = menu09.Clone(new Rectangle(138, 0, 69, 79), PixelFormat.Format64bppPArgb);

            menu10 = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Menu.10.png")));
            this.btnMenu10.NormalImage = menu10.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu10.MouseMoveImage = menu10.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu10.MouseDownImage = menu10.Clone(new Rectangle(138, 0, 69, 79), PixelFormat.Format64bppPArgb);

            //设置
            Bitmap setBitmap = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Button.SetBtn.png")));
            this.btnSet.NormalImage = setBitmap.Clone(new Rectangle(0, 0, 33, 19), PixelFormat.Format64bppPArgb);
            this.btnSet.MouseMoveImage = setBitmap.Clone(new Rectangle(33, 0, 33, 19), PixelFormat.Format64bppPArgb);
            this.btnSet.MouseDownImage = setBitmap.Clone(new Rectangle(66, 0, 33, 19), PixelFormat.Format64bppPArgb);

            //最小化
            Bitmap minBitmap = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Button.MinBtn.png")));
            this.btnMin.NormalImage = minBitmap.Clone(new Rectangle(0, 0, 33, 19), PixelFormat.Format64bppPArgb);
            this.btnMin.MouseMoveImage = minBitmap.Clone(new Rectangle(33, 0, 33, 19), PixelFormat.Format64bppPArgb);
            this.btnMin.MouseDownImage = minBitmap.Clone(new Rectangle(66, 0, 33, 19), PixelFormat.Format64bppPArgb);

            //最大化/还原
            resoreBitmap = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Button.RestrBtn.png")));
            maxBitmap = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Button.MaxBtn.png")));
            this.btnMaxResore.NormalImage = maxBitmap.Clone(new Rectangle(0, 0, 33, 19), PixelFormat.Format64bppPArgb);
            this.btnMaxResore.MouseMoveImage = maxBitmap.Clone(new Rectangle(33, 0, 33, 19), PixelFormat.Format64bppPArgb);
            this.btnMaxResore.MouseDownImage = maxBitmap.Clone(new Rectangle(66, 0, 33, 19), PixelFormat.Format64bppPArgb);

            //关闭
            Bitmap closeBitmap = new Bitmap(Bitmap.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Button.CloseBtn.png")));
            this.btnClose.NormalImage = closeBitmap.Clone(new Rectangle(0, 0, 33, 19), PixelFormat.Format64bppPArgb);
            this.btnClose.MouseMoveImage = closeBitmap.Clone(new Rectangle(33, 0, 33, 19), PixelFormat.Format64bppPArgb);
            this.btnClose.MouseDownImage = closeBitmap.Clone(new Rectangle(66, 0, 33, 19), PixelFormat.Format64bppPArgb);


            Menu1 m1 = new Menu1();
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(m1);
            m1.Dock = DockStyle.Fill;
            m1.Show();
            OnMenuImages(1);
        }

        #endregion

        //#region 窗体向上拉伸
        ///// <summary>
        ///// 窗体向上拉伸
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Caption_MouseUp(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Right && ((Control)sender).Cursor == Cursors.Default && e.Y <= SystemInformation.CaptionHeight)
        //    {
        //        //  Win32.TrackPopupMenu(Win32.GetSystemMenu(Handle, 0).ToInt32(), 2, Cursor.Position.X, Cursor.Position.Y, 0, Handle, 0);
        //    }

        //    if (e.Y <= SystemInformation.CaptionHeight)
        //    {
        //        _captionMouseUp = e.Location;
        //    }
        //    else
        //    {
        //        _captionMouseUp = Point.Empty;
        //    }
        //}
        //#endregion

        #region 最大化/还原
        /// <summary>
        /// 最大化/还原
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Win_WindosMax(object sender, EventArgs e)
        {

            //if (this.WindowState == FormWindowState.Maximized)
            //{
            //    this.ptbTopMenu.BackgroundImage = Image.FromStream(Shared.AssemblyWinUI.GetManifestResourceStream("SM.ManageUI.Resources.MainWin.Transparent.png"));

            //    this.WindowState = FormWindowState.Normal;
            //    this.btnMaxResore.NormalImage = maxBitmap.Clone(new Rectangle(0, 0, 33, 19), PixelFormat.Format64bppPArgb);
            //    this.btnMaxResore.MouseMoveImage = maxBitmap.Clone(new Rectangle(33, 0, 33, 19), PixelFormat.Format64bppPArgb);
            //    this.btnMaxResore.MouseDownImage = maxBitmap.Clone(new Rectangle(66, 0, 33, 19), PixelFormat.Format64bppPArgb);
            //    this.btnMaxResore.ToolTip = "还原";
            //}
            //else
            //{
            //    this.ptbTopMenu.BackgroundImage = null;

            //    this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            //    this.WindowState = FormWindowState.Maximized;
            //    this.btnMaxResore.NormalImage = resoreBitmap.Clone(new Rectangle(0, 0, 33, 19), PixelFormat.Format64bppPArgb);
            //    this.btnMaxResore.MouseMoveImage = resoreBitmap.Clone(new Rectangle(33, 0, 33, 19), PixelFormat.Format64bppPArgb);
            //    this.btnMaxResore.MouseDownImage = resoreBitmap.Clone(new Rectangle(66, 0, 33, 19), PixelFormat.Format64bppPArgb);
            //    this.btnMaxResore.ToolTip = "最大化";

            //}
        }
        #endregion

        #region 移动窗体
        private void Win_MouseMove(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized) return;
            ((Control)sender).Cursor = Cursors.Default;
            if (e.Button == MouseButtons.Left && e.Y <= SystemInformation.CaptionHeight)
            {
                Win32.ReleaseCapture();
                Win32.SendMessage(Handle, 274, 61440 + 9, 0);
            }
        }
        #endregion

        #region 最小化
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
            this.ShowInTaskbar = false;
        }

        private void btnMaxResore_Click(object sender, EventArgs e)
        {

            Win_WindosMax(sender, e);
        }
        #endregion

        #region 退出系统
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出系统？",SString.LOGO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Close();
                this.Dispose();
                Application.Exit();//退出整个应用程序。（无法退出单独开启的线程）
                Application.ExitThread();//释放所有线程　
            }
        }
        #endregion
        
        

        #region 定时触发
        /// <summary>
        /// 定时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GCtimer_Tick(object sender, EventArgs e)
        {
            //ArtDiaglog();
        }

        #endregion


        #region 菜单事件

        private void btnMenu01_Click(object sender, EventArgs e)
        {
            MainWin winForm = (MainWin)this;
            Menu1 m1 = new Menu1();
            winForm.pnlBody.Controls.Clear();
            winForm.pnlBody.Controls.Add(m1);
            m1.Dock = DockStyle.Fill;
            m1.Show();
            
            OnMenuImages(1);
        }

        private void btnMenu02_Click(object sender, EventArgs e)
        {

            MainWin winForm = (MainWin)this;

            

            OnMenuImages(2);
        }

        private void btnMenu03_Click(object sender, EventArgs e)
        {
            MainWin winForm = (MainWin)this;

            Menu2 m2 = new Menu2();
            winForm.pnlBody.Controls.Clear();
            winForm.pnlBody.Controls.Add(m2);
            m2.Dock = DockStyle.Fill;
            m2.Show();

            OnMenuImages(3);
        }

        private void btnMenu04_Click(object sender, EventArgs e)
        {
            //MainWin winForm = (MainWin)this;

            Menu3 m3 = new Menu3();
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(m3);
            m3.Dock = DockStyle.Fill;
            m3.Show();
            
            OnMenuImages(4);
        }

        private void btnMenu05_Click(object sender, EventArgs e)
        {
            //MainWin winForm = (MainWin)this;

            Menu4 m4 = new Menu4();
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(m4);
            m4.Dock = DockStyle.Fill;
            m4.Show();

            OnMenuImages(5);
        }

        private void btnMenu06_Click(object sender, EventArgs e)
        {
            //MainWin winForm = (MainWin)this;

            Menu5 m5 = new Menu5();
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(m5);
            m5.Dock = DockStyle.Fill;
            m5.Show();
            OnMenuImages(6);
        }

        private void btnMenu07_Click(object sender, EventArgs e)
        {
            //MainWin winForm = (MainWin)this;
            Menu6 m6 = new Menu6();
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(m6);
            m6.Dock = DockStyle.Fill;
            m6.Show();

            OnMenuImages(7);
        }

        private void btnMenu08_Click(object sender, EventArgs e)
        {
            //MainWin winForm = (MainWin)this;


            Menu7 m7 = new Menu7();
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(m7);
            m7.Dock = DockStyle.Fill;
            m7.Show();


            OnMenuImages(8);
        }

        private void btnMenu09_Click(object sender, EventArgs e)
        {
            //MainWin winForm = (MainWin)this;

            Menu8 m8 = new Menu8();
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(m8);
            m8.Dock = DockStyle.Fill;
            m8.Show();

            OnMenuImages(9);
        }

        private void btnMenu10_Click(object sender, EventArgs e)
        {
            //MainWin winForm = (MainWin)this;

            Menu9 m9 = new Menu9();
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(m9);
            m9.Dock = DockStyle.Fill;
            m9.Show();

            OnMenuImages(10);
        }
        #endregion
        #region 菜单动态事件
        /// <summary>
        /// 菜单动态事件
        /// </summary>
        /// <param name="i">菜单编号</param>
        private void OnMenuImages(int i)
        {
            this.btnMenu01.NormalImage = menu01.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu02.NormalImage = menu02.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu03.NormalImage = menu03.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu04.NormalImage = menu04.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu05.NormalImage = menu05.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu06.NormalImage = menu06.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu07.NormalImage = menu07.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu08.NormalImage = menu08.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu09.NormalImage = menu09.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);
            this.btnMenu10.NormalImage = menu10.Clone(new Rectangle(0, 0, 69, 79), PixelFormat.Format64bppPArgb);

            switch(i)
            {
                case 1: this.btnMenu01.NormalImage = menu01.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb); break;
                case 2: this.btnMenu02.NormalImage = menu02.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb); break;
                case 3: this.btnMenu03.NormalImage = menu03.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb); break;
                case 4: this.btnMenu04.NormalImage = menu04.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb); break;
                case 5: this.btnMenu05.NormalImage = menu05.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb); break;
                case 6: this.btnMenu06.NormalImage = menu06.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb); break;
                case 7: this.btnMenu07.NormalImage = menu07.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb); break;
                case 8: this.btnMenu08.NormalImage = menu08.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb); break;
                case 9: this.btnMenu09.NormalImage = menu09.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb); break;
                case 10: this.btnMenu10.NormalImage = menu10.Clone(new Rectangle(69, 0, 69, 79), PixelFormat.Format64bppPArgb); break;
            }
        }
        #endregion

        private void labCopyRight_Click(object sender, EventArgs e)
        {
            CopyrightFrm copyFrm = new CopyrightFrm();
            copyFrm.ShowDialog();
        }

    }
}
