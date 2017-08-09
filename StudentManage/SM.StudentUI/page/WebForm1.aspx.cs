using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SM.BaseControls;

namespace SM.StudentUI.page
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Label1_Init(object sender, EventArgs e)
        {
            string s = "12312312";
            string ss = "nihao";
            string sss = DHelper.EncryptDES(ss, s);
            Response.Write(sss);
            Response.Write("----" + DHelper.DecryptDES(sss, s));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            JSUtility.AlertAndRedirect("是否退出系统？", Request.ApplicationPath + SString.PAGE_DEFAULT);
        }

 
    }
}