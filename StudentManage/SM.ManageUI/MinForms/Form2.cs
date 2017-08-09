using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SM.ManageUI
{
    public partial class Form2 : Form
    {
        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {
            E_WaveInit(this.Handle, Application.StartupPath + "\\frmImage\\copyright_bg.bmp");
            E_AutoEffects(2, 0, 0, 0);
        }
    }
}
