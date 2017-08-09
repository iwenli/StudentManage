using System;
using System.Windows.Forms;
using SM.Base;
using SM.BaseControls;


namespace SM.ManageUI
{
    public partial class MainWin : SM.ManageUI.Forms.MainForm
    {
        private User loginUser;

         public MainWin(User _user)
        {
            InitializeComponent();
            loginUser = _user;
            labUserName.Text =this.loginUser.Account.DecryptDES(SConfig.DESKEY);
            labUserGroup.Text = "111";//this.loginUser.Role;
            //if (loginUser.Role.Equals(User.Root[RootUser.classAdmin.ToInt()]))
            //{
            //    labUserGroup.Text += "[" + loginUser.BelongClass + "班]";
            //}
            labUserGroup.Text += "222";
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
           //this.btnMenu01.Visible=false;
            //string rote = loginUser.Role;
            //if (rote == User.Root[0])  //非法用户
            //{
            //    this.Dispose();
            //    this.Close();
            //    Application.Exit();
            //    Application.ExitThread();
            //    return;
            //}
            //else if (rote == User.Root[RootUser.classAdmin.ToInt()])  //班级录入员
            //{
            //    this.btnMenu04.Visible = false;
            //    this.btnMenu06.Visible = false;
            //    this.btnMenu07.Visible = false;
            //    this.btnMenu08.Visible = false;
            //    this.btnMenu09.Visible = false;
            //    return;
            //}
            //else if (rote == User.Root[RootUser.admin.ToInt()])  //一般管理员
            //{
            //    this.btnMenu09.Visible = false;
            //    return;
            //}
            //else                                            //  系统管理员
            //{
            //    return;  
            //}
            
        }

        
    }
}
