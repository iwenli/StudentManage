using System;
using FineUI;
using SM.BaseControls;

namespace SM.StudentUI.page
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (PageMange.IsFirstPage())
                {
                    LoadData();
                    btnFindPwd.OnClientClick = Window2.GetShowReference("FindPwd.aspx", "找回密码");
                    bindErrorMessage();

                    //tbxUserName.Text = "20128277";
                    //tbxPassword.Text = "111111";
                    //tbxCaptcha.Text = Session["CaptchaImageText"].ToString();
                    //btnLogin.Enabled = true;
                }
                else
                {
                    Response.Redirect(Request.ApplicationPath + SString.PAGE_DEFAULT);
                }
            }
        }
        #region 验证码
        /// <summary>
        /// 加载验证码
        /// </summary>
        private void LoadData()
        {
            // 创建一个 6 位的随机数并保存在 Session 对象中
            Session["CaptchaImageText"] = DHelper.RandChar(6);   //GenerateRandomCode();
            this.Image1.ImageUrl = "Captcha/captcha.ashx?w=150&h=30&t=" + DateTime.Now.Ticks;

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

        #region 登陆
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Base.User u =new Base.User(tbxUserName.Text.Trim(), tbxPassword.Text.Trim());
            if (tbxCaptcha.Text.ToUpper() != Session["CaptchaImageText"].ToString().ToUpper())
            {
                Alert.ShowInTop("验证码错误！");
                return;
            }

            if (u.uLogin())
            {
                DHelper.SetSession(SColumn.U_NAME, u.Account);
                DHelper.SetCookie(SColumn.U_NAME, 0, u.Account); //一周有效
                DHelper.SetCookie(SColumn.U_PASSWD, 0, u.PassWord);
                Response.Redirect(SString.PAGE_M);
                //记录日志
            }
            else
            {
                Alert.ShowInTop("用户名或密码错误！", MessageBoxIcon.Error);
            }
        }

        #endregion

        /// <summary>
        /// 是否启用登陆按钮和文本框是否存在空格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btmEnabled(object sender, EventArgs e)
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
            if (!(tbxUserName.Text.Trim().IsEmpty() || tbxPassword.Text.Trim().IsEmpty()))
            {
                this.btnLogin.Enabled = true;
            }
            else
            {
                this.btnLogin.Enabled = false;
            }
        }

        /// <summary>
        /// 绑定控件的提示信息
        /// </summary>
        private void bindErrorMessage()
        {
            tbxUserName.RequiredMessage = SMessage.ERR_STU_ID;
            tbxUserName.MinLengthMessage = SMessage.ERR_STU_ID;
            tbxUserName.MaxLengthMessage = SMessage.ERR_STU_ID;
            tbxCaptcha.RequiredMessage = SMessage.ERR_CAPTCHA;
            tbxCaptcha.MaxLengthMessage = SMessage.ERR_CAPTCHA;
            tbxCaptcha.MinLengthMessage = SMessage.ERR_CAPTCHA;
            tbxPassword.RequiredMessage = SMessage.ERR_PWD;
            tbxPassword.MaxLengthMessage = SMessage.ERR_PWD;
            tbxPassword.MinLengthMessage = SMessage.ERR_PWD;
        }
    }
}