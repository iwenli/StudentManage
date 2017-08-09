using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;

namespace SM.ManageUI
{
    public partial class FrmBox : CCSkinMain
    {
         /// <summary>
        /// 提示信息
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="msg">内容</param>
        /// <param name="Icon">图标</param>
        public FrmBox(string title, string msg, Image Icon)
        {
            InitializeComponent();
            this.Text = title;
            this.lblMsg.Text = msg;
            this.iconBox.BackgroundImage = Icon;
            
        }

        //倒计时三秒关闭弹出窗
        private void timerHide_Tick(object sender, EventArgs e)
        {
            //如果鼠标在窗体上
            if(!this.Bounds.Contains(Cursor.Position))
            {
                this.Close();
            }
        }
    }
}
