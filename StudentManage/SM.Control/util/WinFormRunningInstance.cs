
/* **********************************************************************
 *                   类【WinFormRunningInstance.cs】信息
 *                    
 * 所属项目：SM.BaseControls.util       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：WinFormRunningInstance
 * 功    能： WinForm运行实例类
 * 来    历：HUCSD 创建于 2013-08-22 14:08:42 
 * 
 * **********************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Reflection;

namespace SM.BaseControls
{
    /// <summary>
    /// WinForm运行实例类
    /// </summary>
    public class WinFormRunningInstance
    {
        public static Process RunningInstance()
        {
            Process currnet = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(currnet.ProcessName);
            foreach (Process process in processes)
            {
                if (process.Id != currnet.Id)
                {
                    if(Assembly.GetExecutingAssembly().Location.Replace("/","\\")==currnet.MainModule.FileName)
                    {
                        return process;
                    }
                }
            } 
            return null;
        }
    }
}
