
/* **********************************************************************
 *                   类【SQLCommand.cs】信息
 *                    
 * 所属项目：SM.Control       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：SQLCommand
 * 功    能：常量类之对象常量
 * 来    历：HUCSD 创建于 2013-08-12 16:54:43 
 * 
 * **********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web;

namespace SM.BaseControls
{
    /// <summary>
    /// 常用对象常量类
    /// </summary>
    public static class SObject
    {
        /// <summary>
        /// 当前页面
        /// </summary>
        public static Page CURRECT_PAGE
        {
            get
            {
                return (Page)HttpContext.Current.Handler;
            }
        }

        /// <summary>
        /// 当前时间字符串
        /// </summary>
        public static string DATE_TIME
        {
            get
            {
                return DateTime.Now.ToString("yyyyMMddhhmmss");
            }
        }

        /// <summary>
        /// 当前时间字符串
        /// </summary>
        public static DateTime EMPTY_DATE_TIME
        {
            get
            {
                return Convert.ToDateTime("1800-1-1 00:00:00");
            }
        }

       
    }
}