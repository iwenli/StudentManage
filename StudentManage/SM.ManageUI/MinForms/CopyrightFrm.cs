using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;
using SM.BaseControls;
using System.Runtime.InteropServices;

namespace SM.ManageUI
{
    public partial class CopyrightFrm: CCSkinMain
    {
        
        public CopyrightFrm()
        {
            InitializeComponent();    
        }

        [DllImport("Wave.dll")]
        public static extern int E_WaveInit(IntPtr hwnd, string bmpStr);//初始化对象
        [DllImport("Wave.dll")]
        public static extern int E_AutoEffects(int type, int type1, int type2, int type3);//效果类型
        [DllImport("Wave.dll")]
        public static extern int E_WaveDropStone(int x, int y, int dx, int zl);//仍石头
        [DllImport("Wave.dll")]
        public static extern void E_WaveFree();//释放对象

        Random r = new Random();//置随机数种子


        private void CopyrightFrm_Load(object sender, EventArgs e)
        {
            //this.Text = SString.LOGO;
            E_WaveInit(this.Handle, Application.StartupPath + "\\frmImage\\copyright_bg.bmp");
            E_AutoEffects(2, 0, 0, 0);
            E_AutoEffects(1, r.Next(3, 25), r.Next(0, 5), r.Next(50, 500));
            E_WaveDropStone(1, 1, r.Next(0, 5), r.Next(300, 800));
        }

        private void CopyrightFrm_MouseMove(object sender, MouseEventArgs e)
        {
            E_WaveDropStone(e.X, e.Y, r.Next(0, 5), r.Next(300, 800));
        }

        //倒计时3分关闭弹出窗
        private void timerHide_Tick(object sender, EventArgs e)
        {
            //如果鼠标在窗体上
            if (!this.Bounds.Contains(Cursor.Position))
            {
                E_WaveFree();
                this.Close();
            }
        }

        private void imageButton1_Click(object sender, EventArgs e)
        {
            E_WaveFree();
            this.Close();
        }

        private void qqGlassButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IEXPLORE.exe", SString.Author);
        }
    }
}
