using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SM.BaseControls;
using SM.Base;
 

namespace SM.StudentUI
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //User u = new User("12", "123");
            //Boolean s1 = u.mLogin();
            //if (s1 == true)
            //{
            //    JSUtility.Alert("用户信息为： role=" + u.Role + "Class=" + u.BelongClass);
            //}
            //else
            //{
            //    JSUtility.Alert(base.Page, "用户名或密码错误");
            //}
            PageMange.firstPage();
            //Response.Write(PageMange.getPath() + SString.PAGE_DEFAULT);
            //Response.Write(Request.ApplicationPath);
            Response.Redirect(SString.PAGE_LOGIN);
        }
    }
}