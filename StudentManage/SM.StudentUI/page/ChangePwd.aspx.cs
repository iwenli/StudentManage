using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FineUI;
using SM.BaseControls;

namespace SM.StudentUI.page
{
    public partial class ChangePwd : System.Web.UI.Page
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
                LinkButtonExit.OnClientClick = ActiveWindow.GetHideReference();

                //tbxStuId.Text = "20128277";
                ////tbxStuName.Text = "张龙";
                ////tbxStuIdDate.Text = "142226199001143117";
                //tbxCaptcha.Text = Session["CaptchaImageText"].ToString();
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

            tbxStuOldPwd.RequiredMessage = SMessage.ERR_PWD;
            tbxStuOldPwd.MaxLengthMessage = SMessage.ERR_PWD;
            tbxStuOldPwd.MinLengthMessage = SMessage.ERR_PWD;
            tbxStuNewPwd.RequiredMessage = SMessage.ERR_PWD;
            tbxStuNewPwd.MaxLengthMessage = SMessage.ERR_PWD;
            tbxStuNewPwd.MinLengthMessage = SMessage.ERR_PWD;
            tbxStuPwdSure.RequiredMessage = SMessage.ERR_PWD_SURE;
            tbxStuPwdSure.CompareMessage = SMessage.ERR_PWD_SURE;

            tbxCaptcha.RequiredMessage = SMessage.ERR_CAPTCHA;
            tbxCaptcha.MaxLengthMessage = SMessage.ERR_CAPTCHA;
            tbxCaptcha.MinLengthMessage = SMessage.ERR_CAPTCHA;
        }

        /// <summary>
        /// 判断是否启用提交按钮和文本框是否存在空格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void tbx_Event(object sender, EventArgs e)
        {
            if (!sender.GetType().ToString().Equals("FineUI.NumberBox"))
            {
                if (((TextBox)sender).ID.Equals("tbxStuNewPwd") || ((TextBox)sender).ID.Equals("tbxStuOldPwd") || ((TextBox)sender).ID.Equals("tbxCaptcha")) 
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
            if (!(tbxStuId.Text.Trim().IsEmpty() || tbxStuOldPwd.Text.Trim().IsEmpty() || tbxStuNewPwd.Text.Trim().IsEmpty()))
            {
                this.btnChangePwd.Enabled = true;
            }
            else
            {
                this.btnChangePwd.Enabled = false;
            }
        }

        protected void btnChangePwd_click(object sender, EventArgs e)
        {
            if (tbxCaptcha.Text.ToUpper() != Session["CaptchaImageText"].ToString().ToUpper())
            {
                Alert.ShowInTop("验证码错误！");
            }
            else if (Base.User.uChangePwd(tbxStuId.Text,tbxStuOldPwd.Text,tbxStuPwdSure.Text))
            {
                Alert.Show("密码修改成功", "系统提示", MessageBoxIcon.Information);

                Image2.ImageUrl = "~/page/images/love.jpg";
                labResult.Text = "密码修改【成功】 \n 新密码为：【" + tbxStuPwdSure.Text + "】";
            }
            else
            {
                Alert.Show("密码修改失败，请查看学号和旧密码是否错误", "系统提示", MessageBoxIcon.Error);
                
                Image2.ImageUrl = "~/page/images/love.jpg";
                labResult.Text = "密码修改【失败】";
            }
            Panel2.Hidden = true;
            Panel4.Hidden = false;
        }
    }
}