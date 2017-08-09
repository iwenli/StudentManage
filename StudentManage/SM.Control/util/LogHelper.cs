
/* **********************************************************************
 *                   类【LogHelper.cs】信息
 *                    
 * 所属项目：SM.BaseControls.util       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：LogHelper
 * 功    能：日志记录
 * 来    历：HUCSD 创建于 2013-08-13 11:05:48 
 * 
 * **********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using log4net;
using log4net.Config;

namespace SM.BaseControls 
{
    /// <summary>
    /// 记录日志类
    /// </summary>
    public static class LogHelper
    {
        #region Properties属性

        /// <summary>
        /// 基本日志
        /// </summary>
        private static ILog logInfo = LogManager.GetLogger(SConfig.LOG_INFO);

        /// <summary>
        /// 错误日志
        /// </summary>
        private static ILog logError = LogManager.GetLogger(SConfig.LOG_ERROR);

        /// <summary>
        /// 访问日志
        /// </summary>
        private static ILog logVisit = LogManager.GetLogger(SConfig.LOG_VISIT);

        /// <summary>
        /// 是否配置
        /// </summary>
        private static bool isConfig = false;

        #endregion

        #region Methods方法

        /// <summary>
        /// 日志配置初始化
        /// </summary>
        public static void SetConfig()
        {
            SetConfig(SConfig.LOG_CONFIG);
        }

        /// <summary>
        /// 根据文件配置日志
        /// </summary>
        /// <param name="configFile">配置文件路径</param>
        public static void SetConfig(string configFile)
        {
            FileInfo file = new FileInfo(configFile);
            XmlConfigurator.Configure(file);
            isConfig = true;
        }

        /// <summary>
        /// 写入信息日志
        /// </summary>
        /// <param name="info">信息</param>
        public static void WriteLog(string info)
        {
            if (!isConfig)
            {
                SetConfig();
            }
            if (logInfo.IsInfoEnabled)
            {
                logInfo.Info(info);
            }
        }

        /// <summary>
        /// 写入错误日志
        /// </summary>
        /// <param name="info">信息</param>
        /// <param name="ex">错误</param>
        public static void WriteLog(string info, Exception ex)
        {
            if (!isConfig)
            {
                SetConfig();
            }
            if (logError.IsErrorEnabled)
            {
                logError.Error(info, ex);
            }
        }

        /// <summary>
        /// 写入访问日志
        /// </summary>
        /// <param name="info">信息</param>
        public static void WriteLogVisit(string info)
        {
            if (!isConfig)
            {
                SetConfig();
            }
            if (logVisit.IsInfoEnabled)
            {
                logVisit.Info(info);
            }
        }

        #endregion
    }
}
