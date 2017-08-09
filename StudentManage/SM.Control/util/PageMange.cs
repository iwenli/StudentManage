
/* **********************************************************************
 *                   类【PageMange.cs】信息
 *                    
 * 所属项目：SM.BaseControls.util       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：PageMange
 * 功    能：页面管理
 * 来    历：HUCSD 创建于 2013-08-15 09:27:10 
 * 
 * **********************************************************************/
using System;
using System.Web;


namespace SM.BaseControls
{
    /// <summary>
    /// 页面管理类型
    /// </summary>
    public static class PageMange
    {
        /// <summary>
        /// 检测登陆
        /// </summary>
        /// <returns>是否已经登陆</returns>
        public static  bool IsLogin()
        {
            if (DHelper.GetStrSession(SColumn.U_NAME).IsEmpty())
            {
                return false;
            }
            else
                return true;
            //else if (!DHelper.GetCookie(SColumn.U_NAME).IsEmpty())
            //{
            //    DHelper.SetSession(SColumn.U_NAME, DHelper.GetCookie(SColumn.U_NAME));
            //}
            //else (DHelper.GetStrSession(SColumn.U_NAME).IsEmpty())
            //{
            //    string uName = DHelper.GetCookie(SColumn.U_NAME);
            //    string uPwd = DHelper.GetCookie(SColumn.U_PASSWD);
            //    if (uName.IsEmpty() || uPwd.IsEmpty())
            //    {
            //        return false;
            //    }
            //    DHelper.SetSession(SColumn.U_NAME, uName);
            //    DHelper.SetCookie(SColumn.U_NAME, 0, uName); //一周有效
            //    DHelper.SetCookie(SColumn.U_PASSWD, 0, uPwd);
            //    //记录日志
            //}
            //return false;
        }

        /// <summary>
        /// 系统入口执行处
        /// </summary>
        public static void firstPage()
        {
            DHelper.SetSession(SString.LOGO, SString.LOGO_INFO);
        }
        /// <summary>
        /// 判断是否非法请求
        /// </summary>
        /// <returns></returns>
        public static bool IsFirstPage()
        {
            if (!DHelper.GetStrSession(SString.LOGO).Equals(SString.LOGO_INFO))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 网站根目录的物理路径
        /// </summary>
        /// <returns>物理路径</returns>
        public static string getPath()
        {
            return HttpContext.Current.Server.MapPath("~/");
        }


        /// <summary>
        /// 获取问候语
        /// </summary>
        /// <returns></returns>
        public static string getRegardsChar()
        {
            int H = DateTime.Now.Hour;
            string tempS = H > 0 && H <= 4 ? "午夜好" : H > 4 && H <= 7 ? "早上好" : H > 7 && H <= 11 ? "上午好" : H > 11 && H <= 13 ? "中午好" : H > 13 && H <= 17 ? "下午好" : "晚上好";
            return tempS + SString.LOGO_SHOW;
        }
    }
}
