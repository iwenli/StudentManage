
/* **********************************************************************
 *                   类【JSUtility.cs】信息
 *                    
 * 所属项目：SM.Control       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：JSUtility
 * 功    能：JS执行工具
 * 来    历：HUCSD 创建于 2013-08-13 09:36:08 
 * 
 * **********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Windows.Forms;

namespace SM.BaseControls
{
    /// <summary>
    /// JS执行类
    /// </summary>
    public static class JSUtility
    {
        /// <summary>
        /// 显示消息提示对话框，并进行页面跳转
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="msg">提示信息</param>
        /// <param name="url">跳转的目标URL</param>
        public static void ShowAndRedirect(System.Web.UI.Page page, string msg, string url)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.Append("<script type=\"text/javascript\" defer>");//false需要标签
            Builder.AppendFormat("alert('{0}');", msg);
            Builder.AppendFormat("top.location.href='{0}'", url);
            Builder.Append("</script>");
            page.ClientScript.RegisterStartupScript(page.GetType(), "message", Builder.ToString(), false);

        }

        /// <summary>
        /// 弹出JavaScript小窗口,并转向指定的页面
        /// </summary>
        /// <param name="message">弹出信息</param>
        /// <param name="toURL">专转向的网页</param>
        public static void AlertAndRedirect(string msg, string toURL)
        {
            //处理\\
            string p = @"(\\)";
            Regex r = new Regex(p, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.RightToLeft);
            msg = r.Replace(msg, "\\\\");

            //处理\n
            p = @"(\n)";
            r = new Regex(p, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.RightToLeft);
            msg = r.Replace(msg, "\\n");

            //处理\t
            p = @"(\t)";
            r = new Regex(p, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.RightToLeft);
            msg = r.Replace(msg, "\\t");

            //处理\r
            p = @"(\r)";
            r = new Regex(p, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.RightToLeft);
            msg = r.Replace(msg, "\\r");

            ////处理\\[和\\\
            msg = msg.Replace("'", "\\[");
            msg = msg.Replace("\"", "\\\"");
            string js = "<script  type=\"text/javascript\" >alert('{0}');window.location.replace('{1}')</script>";
            HttpContext.Current.Response.Write(string.Format(js, msg, toURL));
        }

        /// <summary>
        /// 回到历史页面
        /// </summary>
        /// <param name="value">-1/1</param>
        public static void GoHistory(int value)
        {
            string js = @"<Script type='text/javascript'>
                    history.go({0});  
                  </Script>";
            HttpContext.Current.Response.Write(string.Format(js, value));
        }

        /// <summary>
        /// 关闭当前窗口
        /// </summary>
        public static void CloseWindow()
        {
            string js = @"<Script type='text/javascript'>
                    window.close();  
                  </Script>";
            HttpContext.Current.Response.Write(js);
            HttpContext.Current.Response.End();
        }

        public static void CloseTimeOut()
        {
            string js = @"<Script type='text/javascript'>
                    setTimeout('self.close()',500); 
                  </Script>";
            HttpContext.Current.Response.Write(js);
            HttpContext.Current.Response.End();
        }
        /// <summary>
        /// 刷新父窗口
        /// </summary>
        public static void RefreshParent()
        {
            string js = @"<Script type='text/javascript'>
                   window.opener.location.reload();
                  </Script>";
            HttpContext.Current.Response.Write(js);
        }

        /// <summary>
        /// 关闭当前窗口
        /// </summary>
        public static void CloseAndRefresh()
        {
            string js = @"<Script type='text/javascript'>
                    setTimeout('self.close()',100);   
                    window.opener.location.reload();
                  </Script>";
            HttpContext.Current.Response.Write(js);
            HttpContext.Current.Response.End();
        }


        #region 执行前台脚本相关

        /// <summary>
        /// 整个页面重定向到指定的URL
        /// </summary>
        /// <param name="pg">页面</param>
        /// <param name="url">URL</param>
        public static void ReDirURL(System.Web.UI.Page pg, string url)
        {
            string cmd = "<script for=document event=onreadystatechange type=\"text/javascript\" >\n"
                + "top.main.window.location='"
                + url
                + "'</script> ";
            pg.Response.Write(cmd);
        }

        /// <summary>
        /// 页面重定向到登录页
        /// </summary>
        /// <param name="pg">页面</param>
        public static void ReDirURL(System.Web.UI.Page pg)
        {
            string url = "Login.aspx";
            ReDirURL(pg, url);
        }

        public static void AddReset(System.Web.UI.WebControls.Button btn)
        { }
        /// <summary>
        /// 为按钮添加确认信息
        /// </summary>
        /// <param name="btn">按钮</param>
        /// <param name="msg">确认信息内容</param>
        public static void AddConfirm(System.Web.UI.WebControls.Button btn, string msg)
        {
            //为按钮添加确认信息
            btn.Attributes.Add("onclick", "return confirm('" + msg + "');");
        }

        public static void AddConfirm(LinkButton btn, string msg)
        {
            //为按钮添加确认信息
            btn.Attributes.Add("onclick", "return confirm('" + msg + "');");
        }

        /// <summary>
        /// MessageBox方式弹出提示框
        /// </summary>
        /// <param name="msg">提示信息</param>
        public static void Alert(string msg)
        {
            MessageBox.Show(msg);
        }
        /// <summary>
        /// MessageBox方式弹出提示框
        /// </summary>
        /// <param name="msg">提示信息</param>
        /// <param name="title">标题信息</param>
        public static void Alert(string msg,string title)
        {
            MessageBox.Show(msg,title);
        }
        /// <summary>
        /// 弹出提示框
        /// </summary>
        /// <param name="pg">页面</param>
        /// <param name="msg">提示信息</param>
        public static void Alert(Page pg, string msg)
        {
            //由于前后台处理特殊字符的方式不一致，需要转换

            //处理\\
            string p = @"(\\)";
            Regex r = new Regex(p, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.RightToLeft);
            msg = r.Replace(msg, "\\\\");

            //处理\n
            p = @"(\n)";
            r = new Regex(p, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.RightToLeft);
            msg = r.Replace(msg, "\\n");

            //处理\t
            p = @"(\t)";
            r = new Regex(p, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.RightToLeft);
            msg = r.Replace(msg, "\\t");

            //处理\r
            p = @"(\r)";
            r = new Regex(p, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.RightToLeft);
            msg = r.Replace(msg, "\\r");

            ////处理\\[和\\\
            msg = msg.Replace("'", "\\[");
            msg = msg.Replace("\"", "\\\"");

            //要向前台输出的提示命令
            string cmd = "<script  type=\"text/javascript\"  for=document event=onreadystatechange>"
                + "alert('"
                + msg + "');"
                + "</script>";

            //输出前台脚本
            pg.ClientScript.RegisterStartupScript(pg.GetType(), "", cmd, false);
            // pg.Response.Write(cmd);
            // pg.Response.End();
        }




        /// <summary>
        /// 执行前台脚本
        /// </summary>
        /// <param name="pg">页面</param>
        /// <param name="cmd">前台脚本</param>
        public static void ExeClient(Page page, string cmd)
        {
            cmd = "<script type=\"text/javascript\" >"
                + cmd
                + "</script>";

            //输出前台脚本
            page.ClientScript.RegisterStartupScript(page.GetType(), "", cmd, false);

        }

        #endregion
        #region 后台弹出窗口
        /// <summary>
        /// 打开一个.net窗口口，并且这个.net窗口位于最前面
        /// </summary>
        /// <param name="page">提用的页面</param>
        /// <param name="URL">要打开的URL</param>
        /// <param name="PageName">要打开页面的名称</param>
        /// <param name="Win_Width">窗口宽度</param>
        /// <param name="Win_Hight">窗口高度</param>
        /// <param name="Left">窗口左侧位置</param>
        /// <param name="Top">窗口右侧位置</param>
        /// <param name="CenterFlag">是否右中 yes/no</param>
        /// <param name="Status">是否显示状态栏 yes/no</param>
        /// <param name="ParentFlag">true:不关闭弹出窗口，将不能操作父窗口 false 可以操作父窗口</param>
        public static void OpenNewWinodw(Page page, string URL, string PageName, string Win_Width, string Win_Hight, string Left, string Top, string CenterFlag, string Status, bool ParentFlag)
        {

            string scriptstr = "";
            if (ParentFlag)
            {
                scriptstr = "<script language=javascript>showModalDialog('" + URL + "','" + PageName + "','dialogWidth:" + Win_Width + "px;"
                    + "dialogHeight:" + Win_Hight + "px;dialogLeft:" + Left + "px;dialogTop:" + Top + "px;center:" + CenterFlag.ToString() + ";help:no;resizeable:yes;status:" + Status + "')</script>";
            }
            else
            {
                scriptstr = "<script language=javascript>showModelessDialog('" + URL + "','" + PageName + "','dialogWidth:" + Win_Width + "px;"
                    + "dialogHeight:" + Win_Hight + "px;dialogLeft:" + Left + "px;dialogTop:" + Top + "px;center:" + CenterFlag.ToString() + ";help:no;resizeable:yes;status:" + Status + "')</script>";
            }
            page.ClientScript.RegisterStartupScript(page.GetType(), "", scriptstr, false);
            // page.Response.Write(scriptstr);
        }
        /// <summary>
        /// 打开一个窗口，并且这个窗口位于最前面，不关闭，将不能操作父窗口
        /// </summary>
        /// <param name="page">提用的页面</param>
        /// <param name="URL">要打开的URL</param>
        /// <param name="PageName">要打开页面的名称</param>
        /// <param name="Win_Width">窗口宽度</param>
        /// <param name="Win_Hight">窗口高度</param>
        /// <param name="Left">窗口左侧位置</param>
        /// <param name="Top">窗口右侧位置</param>
        /// <param name="CenterFlag">是否右中 yes/no</param>
        /// <param name="ParentFlag">true:不关闭弹出窗口，将不能操作父窗口 false 可以操作父窗口</param> 
        public static void OpenNewWinodw(Page page, string URL, string PageName, string Win_Width, string Win_Hight, string Left, string Top, string CenterFlag, bool ParentFlag)
        {
            string scriptstr = "";
            if (ParentFlag)
            {
                scriptstr = "<script language=javascript>showModalDialog('" + URL + "','" + PageName + "','dialogWidth:" + Win_Width + "px;"
                    + "dialogHeight:" + Win_Hight + "px;dialogLeft:" + Left + "px;dialogTop:" + Top + "px;center:" + CenterFlag + ";help:no;resizeable:yes;status:no')</script>";
            }
            else
            {
                scriptstr = "<script language=javascript>showModelessDialog('" + URL + "','" + PageName + "','dialogWidth:" + Win_Width + "px;"
                    + "dialogHeight:" + Win_Hight + "px;dialogLeft:" + Left + "px;dialogTop:" + Top + "px;center:" + CenterFlag + ";help:no;resizeable:yes;status:no')</script>";
            }
            page.ClientScript.RegisterStartupScript(page.GetType(), "", scriptstr, false);

            // page.Response.Write(scriptstr);
        }

        /// <summary>
        /// 打开一个窗口，并且这个窗口位于最前面，不关闭，将不能操作父窗口
        /// </summary>
        /// <param name="page">提用的页面</param>
        /// <param name="URL">要打开的URL</param>
        /// <param name="PageName">要打开页面的名称</param>
        /// <param name="Win_Width">窗口宽度</param>
        /// <param name="Win_Hight">窗口高度</param>
        /// <param name="Left">窗口左侧位置</param>
        /// <param name="Top">窗口右侧位置</param>
        /// <param name="ParentFlag">true:不关闭弹出窗口，将不能操作父窗口 false 可以操作父窗口</param>
        public static void OpenNewWinodw(Page page, string URL, string PageName, string Win_Width, string Win_Hight, string Left, string Top, bool ParentFlag)
        {
            string scriptstr = "";
            if (ParentFlag)
            {
                scriptstr = "<script language=javascript>showModalDialog('" + URL + "','" + PageName + "','dialogWidth:" + Win_Width + "px;"
                    + "dialogHeight:" + Win_Hight + "px;dialogLeft:" + Left + "px;dialogTop:" + Top + "px;center:no;help:no;resizeable:yes;status:no')</script>";
            }
            else
            {
                scriptstr = "<script language=javascript>showModelessDialog('" + URL + "','" + PageName + "','dialogWidth:" + Win_Width + "px;"
                    + "dialogHeight:" + Win_Hight + "px;dialogLeft:" + Left + "px;dialogTop:" + Top + "px;center:no;help:no;resizeable:yes;status:no')</script>";

            }
            page.ClientScript.RegisterStartupScript(page.GetType(), "", scriptstr, false);
            // page.Response.Write(scriptstr);
        }

        /// <summary>
        /// 打开一个窗口，并且这个窗口位于最前面，不关闭，将不能操作父窗口
        /// </summary>
        /// <param name="page">提用的页面</param>
        /// <param name="URL">要打开的URL</param>
        /// <param name="PageName">要打开页面的名称</param>
        /// <param name="Win_Width">窗口宽度</param>
        /// <param name="Win_Hight">窗口高度</param>
        /// <param name="ParentFlag">true:不关闭弹出窗口，将不能操作父窗口 false 可以操作父窗口</param>
        public static void OpenNewWinodw(Page page, string URL, string PageName, string Win_Width, string Win_Hight, bool ParentFlag)
        {
            string scriptstr = "";
            if (ParentFlag)
            {
                scriptstr = "<script language=javascript>showModalDialog('" + URL + "','" + PageName + "','dialogWidth:" + Win_Width + "px;"
                    + "dialogHeight:" + Win_Hight + "px;dialogLeft:0px;dialogTop:0px;center:no;help:no;resizeable:yes;status:no')</script>";
            }
            else
            {
                scriptstr = "<script language=javascript>showModelessDialog('" + URL + "','" + PageName + "','dialogWidth:" + Win_Width + "px;"
                    + "dialogHeight:" + Win_Hight + "px;dialogLeft:0px;dialogTop:0px;center:no;help:no;resizeable:yes;status:no')</script>";
            }
            page.ClientScript.RegisterStartupScript(page.GetType(), "", scriptstr, false);
            //  page.Response.Write(scriptstr);
        }
        /// <summary>
        /// 打开一个窗口，并且这个窗口位于最前面，不关闭，将不能操作父窗口
        /// </summary>
        /// <param name="page">提用的页面</param>
        /// <param name="URL">要打开的URL</param>
        /// <param name="Win_Width">窗口宽度</param>
        /// <param name="Win_Hight">窗口高度</param>
        /// <param name="ParentFlag">true:不关闭弹出窗口，将不能操作父窗口 false 可以操作父窗口</param>
        public static void OpenNewWinodw(Page page, string URL, string Win_Width, string Win_Hight, bool ParentFlag)
        {
            string scriptstr = "";
            if (ParentFlag)
            {
                scriptstr = "<script language=javascript>showModalDialog('" + URL + "','','dialogWidth:" + Win_Width + "px;"
                    + "dialogHeight:" + Win_Hight + "px;dialogLeft:0px;dialogTop:0px;center:no;help:no;resizeable:yes;status:no')</script>";
            }
            else
            {
                scriptstr = "<script language=javascript>showModelessDialog('" + URL + "','','dialogWidth:" + Win_Width + "px;"
                    + "dialogHeight:" + Win_Hight + "px;dialogLeft:0px;dialogTop:0px;center:no;help:no;resizeable:yes;status:no')</script>";
            }
            page.ClientScript.RegisterStartupScript(page.GetType(), "", scriptstr, false);
            // page.Response.Write(scriptstr);
        }
        #endregion
    }
}
