
/* **********************************************************************
 *                   类【SQLCommand.cs】信息
 *                    
 * 所属项目：SM.Control       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：SQLCommand
 * 功    能：常量类之配置常量
 * 来    历：HUCSD 创建于 2013-08-12 16:54:43 
 * 
 * **********************************************************************/
using System.Web;

namespace SM.BaseControls
{
    /// <summary>
    /// 配置常量类
    /// </summary>
    public static class SConfig
    {
        /// <summary>
        /// DES加密密钥
        /// </summary>
        public const string DESKEY = "ZhangWen";

        /// <summary>
        /// EXT提取函数命名空间
        /// </summary>
        public const string D_X = "D_X";

        /// <summary>
        /// SHA1
        /// </summary>
        public const string SHA1 = "SHA1";

        /// <summary>
        /// MD5
        /// </summary>
        public const string MD5 = "MD5";

        /// <summary>
        /// LOGINFO 
        /// </summary>
        public const string LOG_INFO = "logInfo";

        /// <summary>
        /// LOGERROR
        /// </summary>
        public const string LOG_ERROR = "logError";

        /// <summary>
        /// LOGVISIT
        /// </summary>
        public const string LOG_VISIT = "logVisit";

        /// <summary>
        /// 密钥向量 
        /// </summary>
        public static readonly byte[] KEYS = { 0x01, 0x11, 0x00, 0x10, 0x10, 0x00, 0x11, 0x01 };

        /// <summary>
        /// 日志配置
        /// </summary>
        public static readonly string LOG_CONFIG = HttpRuntime.AppDomainAppPath + "/log.config";

        /// <summary>
        /// Nhibernate配置
        /// </summary>
        public static readonly string NHI_CONFIG = HttpRuntime.AppDomainAppPath + "/nhibernate.config";

        /// <summary>
        /// 缓存文件夹
        /// </summary>
        public static readonly string CACHE_PATH = HttpRuntime.AppDomainAppPath + "/UpFile/Cache";

        /// <summary>
        /// 缓存文件夹
        /// </summary>
        public const string CACHE_PAGE_PATH = "~/UpFile/Cache/";

        /// <summary>
        /// 主目录
        /// </summary>
        public const string PAGE_MAIN = "~/";

        /// <summary>
        /// 用户图标
        /// </summary>
        public const string USERPIC_PAGE_PATH = "~/UpFile/UserPic/";

        /// <summary>
        /// 图片文件
        /// </summary>
        public const string PIC_PAGE_PATH = "~/UpFile/Pic/";

        /// <summary>
        /// 网页错误
        /// </summary>
        public const string PAGE_ERROR = "~/Error/ErrorPage.htm";

        /// <summary>
        /// 无访问权限
        /// </summary>
        public const string PAGE_NOACCESS = "~/Error/NoAccess.htm";

        /// <summary>
        /// 无此文件
        /// </summary>
        public const string PAGE_NOFOUND = "~/Error/FileNotFound.htm";

        /// <summary>
        /// 网站维护中
        /// </summary>
        public const string PAGE_MAINTENANCE = "~/Error/Maintenance.htm";

        /// <summary>
        /// 图片不存在
        /// </summary>
        public const string NO_IMG = "~/UpFile/NoImg.jpg";
    }
}
