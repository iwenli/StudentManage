
/* **********************************************************************
 *                   类【IniHelper.cs】信息
 *                    
 * 所属项目：SM.BaseControls.util       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：IniHelper
 * 功    能： 
 * 来    历：HUCSD 创建于 2013-08-26 07:49:32 
 * 
 * **********************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace SM.BaseControls
{
    /// <summary>
    /// INI文件读写类。
    /// </summary>
    public class IniHelper
    {
        public string path;

        public IniHelper(string INIPath)
		{
			path = INIPath;
		}

		[DllImport("kernel32")]
		private static extern long WritePrivateProfileString(string section,string key,string val,string filePath);

		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string section,string key,string def, StringBuilder retVal,int size,string filePath);

	
		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string section, string key, string defVal, Byte[] retVal, int size, string filePath);


		/// <summary>
		/// 写INI文件
		/// </summary>
		/// <param name="Section">写入到片段</param>
		/// <param name="Key">写入的关键字</param>
		/// <param name="Value">写入的键值</param>
		public void IniWriteValue(string Section,string Key,string Value)
		{
			WritePrivateProfileString(Section,Key,Value,this.path);
		}

		/// <summary>
		/// 读取INI文件
		/// </summary>
		/// <param name="Section"></param>
		/// <param name="Key"></param>
		/// <returns></returns>
		public string IniReadValue(string Section,string Key)
		{
			StringBuilder temp = new StringBuilder(255);
			int i = GetPrivateProfileString(Section,Key,"",temp, 255, this.path);
			return temp.ToString();
		}
		public byte[] IniReadValues(string section, string key)
		{
			byte[] temp = new byte[255];
			int i = GetPrivateProfileString(section, key, "", temp, 255, this.path);
			return temp;

		}


		/// <summary>
		/// 删除ini文件下所有段落
		/// </summary>
		public void ClearAllSection()
		{
			IniWriteValue(null,null,null);
		}
		/// <summary>
		/// 删除ini文件下personal段落下的所有键
		/// </summary>
		/// <param name="Section"></param>
		public void ClearSection(string Section)
		{
			IniWriteValue(Section,null,null);
		}
    }
}
