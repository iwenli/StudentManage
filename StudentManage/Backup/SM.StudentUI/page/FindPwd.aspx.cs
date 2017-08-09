using System;
using FineUI;
using SM.BaseControls;
using SM.Base;
 

namespace SM.StudentUI.page
{
    public partial class FindPwd : PageBase 
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!PageMange.IsFirstPage())
            {
                Response.Redirect(Request.ApplicationPath + SString.PAGE_DEFAULT);
            }
            if (!IsPostBack)
            {
                LoadData();
                bindErrorMessage();
                //tbxStuId.Text = "20128277";
                //tbxStuName.Text = "张龙";
                //tbxStuIdDate.Text = "142226199001143117";
                //tbxCaptcha.Text = Session["CaptchaImageText"].ToString();
                LinkButtonExit.OnClientClick = ActiveWindow.GetHideReference();
            } 
        }

        #region 验证码
        private void LoadData()
        {
            // 创建一个 6 位的随机数并保存在 Session 对象中
            Session["CaptchaImageText"] = DHelper.RandChar(6);   //GenerateRandomCode();
            this.Image1.ImageUrl = "Captcha/captcha.ashx?w=130&h=25&t=" + DateTime.Now.Ticks;

        }

        /// <summary>
        /// 刷新验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        #endregion

        /// <summary>
        /// 绑定控件的提示信息
        /// </summary>
        private void bindErrorMessage()
        {
            tbxStuId.RequiredMessage = SMessage.ERR_STU_ID;
            tbxStuId.MinLengthMessage = SMessage.ERR_STU_ID;
            tbxStuId.MaxLengthMessage = SMessage.ERR_STU_ID;
            tbxStuName.RequiredMessage = SMessage.ERR_NAME;
            tbxStuIdDate.RequiredMessage = SMessage.ERR_ID_DATE;
            tbxStuIdDate.RegexMessage = SMessage.ERR_ID_DATE;
            tbxCaptcha.RequiredMessage = SMessage.ERR_CAPTCHA;
            tbxCaptcha.MaxLengthMessage = SMessage.ERR_CAPTCHA;
            tbxCaptcha.MinLengthMessage = SMessage.ERR_CAPTCHA;

            tbxStuNewPwd.RequiredMessage = SMessage.ERR_PWD;
            tbxStuNewPwd.MaxLengthMessage = SMessage.ERR_PWD;
            tbxStuNewPwd.MinLengthMessage = SMessage.ERR_PWD;
            tbxStuPwdSure.RequiredMessage = SMessage.ERR_PWD_SURE;
            tbxStuPwdSure.CompareMessage = SMessage.ERR_PWD_SURE;
            
        }

        protected void findPwd_click(object sender, EventArgs e)
        {
            if (tbxCaptcha.Text.ToUpper() != Session["CaptchaImageText"].ToString().ToUpper())
            {
                Alert.ShowInTop("验证码错误！");
            }
            else if (Base.User.checkUserExist(tbxStuId.Text, tbxStuName.Text, tbxStuIdDate.Text))
            {
                GroupPanel1.Hidden = true;
                GroupPanel2.Hidden = false;
                GroupPanel3.Hidden = true;
                //write log
            }
            else
            {
                Alert.Show("您提供的信息不正确，无法找回密码..\n您可以尝试使用初始密码登陆\n如果初始密码仍然无法登陆请联系管理员", "系统提示", MessageBoxIcon.Error);
                labResult.Text = "由于您的信息填写有误，密码没有找回。请联系管理员！";
                GroupPanel1.Hidden = true;
                GroupPanel2.Hidden = true;
                GroupPanel3.Hidden = false;
                Image2.ImageUrl = "~/page/images/love.jpg";
                //write log
            } 
        }

        protected void btnSubmint_click(object sender, EventArgs e)
        {
            if (Base.User.uChangePwd(tbxStuId.Text, tbxStuPwdSure.Text))
            {
                Alert.ShowInTop("您的密码已被更改为【" + tbxStuPwdSure.Text + "】请注意保管", "系统提示", MessageBoxIcon.Information);
                labResult.Text = "密码设置【成功】";
                Image2.ImageUrl = "~/page/images/love.jpg";
            }
            else
            {
                Alert.ShowInTop("密码更改失败，请联系管理员！", "系统提示", MessageBoxIcon.Error);
                Image2.ImageUrl = "~/page/images/love.jpg";
                labResult.Text = "密码设置【失败】";
            }
            GroupPanel2.Hidden = true;
            GroupPanel3.Hidden = false;
        }

        /// <summary>
        /// 判断是否启用下一步按钮和文本框是否存在空格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void tbx_Event(object sender, EventArgs e)
        {
            if (!sender.GetType().ToString().Equals("FineUI.NumberBox"))
            {
                if (((TextBox)sender).ID.Equals("tbxStuNewPwd") || ((TextBox)sender).ID.Equals("tbxStuName"))
                {
                    string Stemp = ((TextBox)sender).Text.ToString();
                    for (int i = Stemp.Length - 1; i > -1; i--)
                    {
                        if (Stemp[i] == 32)
                        {
                            ((TextBox)sender).Text = "";
                            Alert.ShowInTop(((TextBox)sender).Label + " 不能包含空格");
                            return;
                        }
                    }
                }
            }
            if (!(tbxStuId.Text.Trim().IsEmpty() || tbxStuName.Text.Trim().IsEmpty()||tbxStuIdDate.Text.Trim().IsEmpty())) 
            {
                this.btnFindPwd.Enabled = true;
            }
            else
            {
                this.btnFindPwd.Enabled = false;
            }
        }

       
    }
}