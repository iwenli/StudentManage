
/* **********************************************************************
 *                   类【DHelper.cs】信息
 *                    
 * 所属项目：SM.Control       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：DHelper
 * 功    能：常用操作
 * 来    历：HUCSD 创建于 2013-08-13 09:15:26 
 * 
 * **********************************************************************/
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;  //MD5加密
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Linq;

namespace SM.BaseControls
{
    /// <summary>
    /// 常用操作
    /// </summary>
    public static class DHelper
    {
        #region 常用处理
        /// <summary>
        /// 对象是否为NULL
        /// </summary>
        /// <param name="str">对象</param>
        /// <returns>是否为NULL</returns>
        public static bool IsNull(this object obj)
        {
            if (obj == null)
            {
                return true;
            }
            if (obj is DateTime && obj.ToDateTime().Equals(DateTime.MinValue))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 字符串是否为空
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>是否为空</returns>
        public static bool IsEmpty(this string str)
        {
            if (IsNull(str))
            {
                return true;
            }
            if (str.Equals(String.Empty))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 字符串不为NULL
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>返回字符串</returns>
        public static string IfNull(this object str)
        {
            if (str == null)
            {
                return String.Empty;
            }
            return str.ToString();
        }

        /// <summary>
        /// 字符串不为NULL
        /// </summary>
        /// <param name="str">要验证字符串</param>
        /// <param name="val">为空返回字符串</param>
        /// <returns>返回字符串</returns>
        public static string IfNull(this string str, string retStr)
        {
            if (str == null)
            {
                return retStr;
            }
            return str;
        }

        /// <summary>
        /// 字符串数组转换成数字
        /// </summary>
        /// <param name="strs">字符串</param>
        /// <returns>数字</returns>
        public static int[] StrsToInts(this string[] strs)
        {
            int[] ints = new int[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                ints[i] = Convert.ToInt32(strs[i]);
            }
            return ints;
        }

        /// <summary>
        /// 取得自定义长度的字符串
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="lenght">长度</param>
        /// <returns>截取后字符串</returns>
        public static string CutChar(this string str, int lenght)
        {
            if (str.Length > lenght)
            {
                return str.Substring(0, lenght) + SString.OMITTED;
            }
            else
            {
                return str;
            }
        }

        /// <summary>
        /// 取得自定义长度的字符串  中文123456789           
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="lenght">长度</param>
        /// <returns>截取后字符串</returns>
        public static string CutCNChar(this string str, int lenght)
        {
            string ret = String.Empty;
            if (str.Length > lenght)
            {
                int tempnum1 = 0;
                int tempnum2 = 0;
                byte[] byitem = System.Text.ASCIIEncoding.ASCII.GetBytes(str);
                for (int i = 0; i < str.Length; i++)
                {
                    if ((int)byitem[i] != 63)
                    {
                        tempnum1++;
                    }
                    else
                    {
                        tempnum2++;
                    }
                    if (tempnum2 * 2 + tempnum1 >= lenght * 2)
                    {
                        break;
                    }

                }
                ret = str.Substring(0, tempnum2 + tempnum1) + SString.OMITTED;
            }
            else
            {
                ret = str;
            }
            return ret;
        }

        /// <summary>
        /// 返回字符串真实长度 1个汉字长度为2
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>实际字符串长度</returns>
        public static int GetCharLength(this string str)
        {
            return Encoding.Default.GetBytes(str).Length;
        }

        /// <summary>
        /// 替换字符串
        /// </summary>
        /// <param name="Str">要替换的字符型</param>
        /// <returns>替换后的字符串</returns>
        public static string ReplaceW(this string str)
        {
            return Regex.Replace(str, SString.W, String.Empty).ToString();
        }

        /// <summary>
        /// SHA1加密字符串
        /// </summary>
        /// <param name="str">要加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string EncryptSHA1(this string str)
        {
            if (!str.IsEmpty())
            {
                return FormsAuthentication.HashPasswordForStoringInConfigFile(ReplaceW(str), SConfig.SHA1);
            }
            return str;
        }

        /// <summary>
        /// MD5加密字符串
        /// </summary>
        /// <param name="strName">要加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string EncryptMD5(this string strName)
        {
            string newPwd = "";
            if (!strName.IsEmpty())
            {
                string str = "tianShangKeJi" + strName + "GaoZhi" + strName + "XinXiGuanLi";
                MD5 md5 = MD5.Create();
                byte[] strC = md5.ComputeHash(System.Text.Encoding.UTF7.GetBytes(str));
                strC.Reverse();
                for (int i = 3; i < 15; i++)
                {
                    newPwd = newPwd + (strC[i] < 198 ? strC[i] + 28 : strC[i]).ToString("X");
                }
            }
            return newPwd; 
        }

        /// <summary> 
        /// DES加密字符串 
        /// </summary> 
        /// <param name="encryptString">待加密的字符串</param>
        /// <param name="encryptKey">加密密钥,要求为8位</param> 
        /// <returns>加密成功返回加密后的字符串，失败返回源串</returns>
        public static string EncryptDES(this string encryptString, string encryptKey)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
                byte[] rgbIV = ASCIIEncoding.ASCII.GetBytes(EncryptMD5(encryptKey).Substring(1, 8));
                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
            return encryptString;
        }

        /// <summary> 
        /// DES解密字符串
        /// </summary> 
        /// <param name="decryptString">待解密的字符串</param>
        /// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>
        /// <returns>解密成功返回解密后的字符串，失败返源串</returns>
        public static string DecryptDES(this string decryptString, string decryptKey)
        {

            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey);
                byte[] rgbIV = ASCIIEncoding.ASCII.GetBytes(EncryptMD5(decryptKey).Substring(1, 8));
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
            return decryptString;
        }

        /// <summary>
        /// 生成随机字符串
        /// </summary>
        /// <param name="length">字符串长度</param>
        /// <returns>随机字符串</returns>
        public static string RandChar(int length)
        {
            string strSep = SString.COMMA;
            char[] chrSep = strSep.ToCharArray();

            //因1与l不容易分清楚，所以去除
            //因0与O不容易分清楚，所以去除 
            string strChar = SString.CHAR;
            string[] aryChar = strChar.Split(chrSep, strChar.Length);
            string strRandom = string.Empty;
            Random Rnd = new Random();
            //生成随机字符串 
            for (int i = 0; i < length; i++)
            {
                strRandom += aryChar[Rnd.Next(aryChar.Length)];
            }
            return strRandom;
        }

        /// <summary>
        /// 生成随机数字字符串
        /// </summary>
        /// <param name="length">字符串长度</param>
        /// <returns>随机字符串</returns>
        public static string RandNum(int length)
        {
            string strSep = SString.COMMA;
            char[] chrSep = strSep.ToCharArray();

            //因1与l不容易分清楚，所以去除
            //因0与O不容易分清楚，所以去除 
            string strChar = SString.NUM;
            string[] aryChar = strChar.Split(chrSep, strChar.Length);
            string strRandom = string.Empty;
            Random rnd = new Random();
            //生成随机字符串 
            for (int i = 0; i < length; i++)
            {
                strRandom += aryChar[rnd.Next(aryChar.Length)];
            }
            return strRandom;
        }

        /// <summary>
        /// 生成随机汉子字符串
        /// </summary>
        /// <param name="length">字符串长度</param>
        /// <returns>随机字符串</returns>
        public static string RandCN(int length)
        {
            string strSep = SString.COMMA;
            char[] chrSep = strSep.ToCharArray();

            string strChar = SString.CN;

            //定义一个字符串数组储存汉字编码的组成元素
            string[] rBase = strChar.Split(chrSep, strChar.Length);

            Random rnd = new Random();

            //定义一个object数组用来
            object[] bytes = new object[length];

            /*每循环一次产生一个含两个元素的十六进制字节数组，并将其放入bject数组中
             每个汉字有四个区位码组成
             区位码第1位和区位码第2位作为字节数组第一个元素
             区位码第3位和区位码第4位作为字节数组第二个元素
             */
            for (int i = 0; i < length; i++)
            {
                //区位码第1位
                int r1 = rnd.Next(11, 14);
                string str_r1 = rBase[r1].Trim();

                //区位码第2位
                rnd = new Random(r1 * unchecked((int)DateTime.Now.Ticks) + i);//更换随机数发生器的种子避免产生重复值

                int r2;
                if (r1 == 13)
                {
                    r2 = rnd.Next(0, 7);
                }
                else
                {
                    r2 = rnd.Next(0, 16);
                }
                string str_r2 = rBase[r2].Trim();

                //区位码第3位
                rnd = new Random(r2 * unchecked((int)DateTime.Now.Ticks) + i);
                int r3 = rnd.Next(10, 16);
                string str_r3 = rBase[r3].Trim();

                //区位码第4位
                rnd = new Random(r3 * unchecked((int)DateTime.Now.Ticks) + i);
                int r4;
                if (r3 == 10)
                {
                    r4 = rnd.Next(1, 16);
                }
                else if (r3 == 15)
                {
                    r4 = rnd.Next(0, 15);
                }
                else
                {
                    r4 = rnd.Next(0, 16);
                }
                string str_r4 = rBase[r4].Trim();

                //定义两个字节变量存储产生的随机汉字区位码
                byte byte1 = Convert.ToByte(str_r1 + str_r2, 16);
                byte byte2 = Convert.ToByte(str_r3 + str_r4, 16);
                //将两个字节变量存储在字节数组中
                byte[] str_r = new byte[] { byte1, byte2 };

                //将产生的一个汉字的字节数组放入object数组中
                bytes.SetValue(str_r, i);

            }
            Encoding gb = Encoding.GetEncoding(SString.GBK);
            string[] str = new string[length];
            string chars = String.Empty;
            for (int i = 0; i < length; i++)
            {
                str[i] = gb.GetString((byte[])Convert.ChangeType(bytes[i], typeof(byte[])));
                chars = chars + str[i];
            }
            return chars;
        }

        /// <summary>
        /// 生成随机文件名
        /// </summary>
        /// <param name="filename">文件名</param>
        /// <returns>随机文件名</returns>
        public static string RandFileName()
        {
            return SObject.DATE_TIME + RandChar(5);
        }

        /// <summary>
        /// 生成随机订单号
        /// </summary>
        /// <returns>随机文件名</returns>
        public static string RandOrder()
        {
            return SObject.DATE_TIME + RandNum(8);
        }

        /// <summary>
        /// 生成小文件名
        /// </summary>
        /// <returns>原文件名</returns>
        public static string GetMin(this string filename)
        {
            return filename.Substring(0, filename.LastIndexOf(SString.POINT)) + SString.MIN + filename.Substring(filename.LastIndexOf(SString.POINT), filename.Length - filename.LastIndexOf(SString.POINT));
        }

        /// <summary>
        /// 生成缩略图
        /// </summary>
        /// <param name="originalImagePath">源图路径（物理路径）</param>
        /// <param name="thumbnailPath">缩略图路径（物理路径）</param>
        /// <param name="width">缩略图宽度</param>
        /// <param name="height">缩略图高度</param>
        /// <param name="mode">生成缩略图的方式 3:指定高宽缩放（可能变形）2:指定宽，高按比例 1:指定高，宽按比例0:指定高宽裁减（不变形）</param>    
        public static bool MakeThumbnail(string originalImagePath, string thumbnailPath, int width, int height, int mode)
        {
            bool isSuccess = true;
            Image originalImage = Image.FromFile(originalImagePath);

            int towidth = width;
            int toheight = height;

            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;

            switch (mode)
            {
                case 3://指定高宽缩放（可能变形）                
                    break;
                case 2://指定宽，高按比例                    
                    toheight = originalImage.Height * width / originalImage.Width;
                    break;
                case 1://指定高，宽按比例
                    towidth = originalImage.Width * height / originalImage.Height;
                    break;
                case 0://指定高宽裁减（不变形）                
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    break;
                default:
                    break;
            }

            //新建一个bmp图片
            Image bitmap = new Bitmap(towidth, toheight);

            //新建一个画板
            Graphics g = Graphics.FromImage(bitmap);

            //设置高质量插值法
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //设置高质量,低速度呈现平滑程度
            g.SmoothingMode = SmoothingMode.HighQuality;

            //清空画布并以透明背景色填充
            g.Clear(Color.White);

            //在指定位置并且按指定大小绘制原图片的指定部分
            g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight),
                new Rectangle(x, y, ow, oh),
                GraphicsUnit.Pixel);

            try
            {
                //以jpg格式保存缩略图
                bitmap.Save(thumbnailPath, ImageFormat.Jpeg);
            }
            catch (System.Exception ex)
            {
                isSuccess = false;
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                g.Dispose();
            }
            return isSuccess;
        }

        /// <summary>
        /// 根据属性名提取属性值
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="obj">要提取的对象</param>
        /// <param name="name">属性名</param>
        /// <returns>提取出的属性值</returns>
        public static object GetPropertyByName<T>(T obj, string name)
        {
            try
            {
                Type t = obj.GetType();
                PropertyInfo pi = t.GetProperty(name);
                return pi.GetValue(obj, null);
            }
            catch (System.Exception ex)
            {
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
            return new Object();
        }

        /// <summary>
        /// 根据属性名设置值
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="obj">要设置的对象</param>
        /// <param name="name">属性名</param>
        /// <param name="val">属性值</param>
        /// <returns>设置值后的对象</returns>
        public static T SetPropertyByName<T>(T obj, string name, object val)
        {
            try
            {
                Type t = obj.GetType();
                PropertyInfo pi = t.GetProperty(name);
                pi.SetValue(obj, val, null);
            }
            catch (System.Exception ex)
            {
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
            return obj;
        }

        #endregion

        #region 网页

        public static void getIni(this string ini)
        {
            ini = "123";
        }

        #region 常用

        /// <summary>
        /// 提取网址
        /// </summary>
        /// <param name="url">地址</param>
        /// <returns>真实地址</returns>
        public static string GetResolvedUrl(this string url)
        {
            return SObject.CURRECT_PAGE.ResolveUrl(url);
        }

        #endregion

        #region 页面跳转

        /// <summary>
        /// 页面出错
        /// </summary>
        public static void GoError()
        {
            SObject.CURRECT_PAGE.Response.Redirect(SConfig.PAGE_ERROR);
        }

        /// <summary>
        /// 无访问权限
        /// </summary>
        public static void GoNoPower()
        {
            SObject.CURRECT_PAGE.Response.Redirect(SConfig.PAGE_NOACCESS);
        }

        /// <summary>
        /// 找不到页面
        /// </summary>
        public static void GoNoFound()
        {
            SObject.CURRECT_PAGE.Response.Redirect(SConfig.PAGE_NOFOUND);
        }

        /// <summary>
        /// 网站维护中
        /// </summary>
        public static void GoMaintenance()
        {
            SObject.CURRECT_PAGE.Response.Redirect(SConfig.PAGE_MAINTENANCE);
        }

        #endregion

        #region COOKIE

        /// <summary>
        /// 创建COOKIE对象并赋Value值，修改COOKIE的Value值也用此方法，因为对COOKIE修改必须重新设Expires
        /// </summary>
        /// <param name="strCookieName">COOKIE对象名</param>
        /// <param name="iExpires">COOKIE对象有效时间（秒数），0一周内有效，1表示永久有效，大于等于2表示具体有效秒数</param>
        /// <param name="strValue">COOKIE对象Value值</param>
        public static void SetCookie(string strCookieName, int iExpires, string strValue)
        {
            HttpCookie objCookie = new HttpCookie(strCookieName);
            objCookie.Value = UrlEncode(strValue.Trim());
            if (iExpires >= 0)
            {
                if (iExpires.Equals(0))
                {
                    objCookie.Expires = DateTime.Now.AddDays(7);
                }
                else if (iExpires.Equals(1))
                {
                    objCookie.Expires = DateTime.MaxValue;
                }
                else
                {
                    objCookie.Expires = DateTime.Now.AddSeconds(iExpires);
                }
            }
            SObject.CURRECT_PAGE.Response.Cookies.Add(objCookie);
        }

        /// <summary>
        /// 读取Cookie某个对象的Value值，返回Value值，如果对象本就不存在，则返回字符串"CookieNonexistence"
        /// </summary>
        /// <param name="strCookieName">Cookie对象名称</param>
        /// <returns>Value值，如果对象本就不存在，则返回字符串""</returns>
        public static string GetCookie(string strCookieName)
        {
            if (SObject.CURRECT_PAGE.Request.Cookies[strCookieName].IsNull())
            {
                return String.Empty;
            }
            else
            {
                return UrlDecode(SObject.CURRECT_PAGE.Request.Cookies[strCookieName].Value);
            }
        }

        /// <summary>
        /// URL解码
        /// </summary>
        /// <param name="str">要解码的字符串</param>
        /// <returns>解码后的字符串</returns>
        public static string UrlDecode(this string str)
        {
            try
            {
                return HttpUtility.UrlDecode(str);
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
            return str;
        }

        /// <summary>
        /// URL编码
        /// </summary>
        /// <param name="str">要编码的字符串</param>
        /// <returns>编码后的字符串</returns>
        public static string UrlEncode(this string str)
        {
            try
            {
                return HttpUtility.UrlEncode(str);
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
            return str;
        }

        /// <summary>
        /// HTML解码
        /// </summary>
        /// <param name="str">要解码的字符串</param>
        /// <returns>解码后的字符串</returns>
        public static string HtmlDecode(this string str)
        {
            try
            {
                return HttpUtility.HtmlDecode(str);
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
            return str;
        }

        /// <summary>
        /// HTML编码
        /// </summary>
        /// <param name="str">要编码的字符串</param>
        /// <returns>编码后的字符串</returns>
        public static string HtmlEncode(this string str)
        {
            try
            {
                return HttpUtility.HtmlEncode(str);
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
            return str;
        }

        #endregion

        #region Session

        /// <summary>
        /// 读取session值
        /// </summary>
        /// <param name="name">名称</param>
        /// <returns>值</returns>
        public static object GetSession(string name)
        {
            object Str_Value = null;
            try
            {
                Str_Value = SObject.CURRECT_PAGE.Session[name];
            }
            catch (Exception ex)
            {
                Str_Value = null;
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
            return Str_Value;
        }

        /// <summary>
        /// 读取session值
        /// </summary>
        /// <param name="name">名称</param>
        /// <returns>值</returns>
        public static string GetStrSession(string name)
        {
            string Str_Value = null;
            try
            {
                Str_Value = SObject.CURRECT_PAGE.Session[name].ToString();
            }
            catch (Exception ex)
            {
                Str_Value = String.Empty;
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
            return Str_Value;
        }

        /// <summary>
        /// 设置session值
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="pObj_Value">值</param>
        public static void SetSession(string name, object value)
        {
            try
            {
                SObject.CURRECT_PAGE.Session[name] = value;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
        }

        #endregion

        #region HTML

        /// <summary>
        /// 读取提交值
        /// </summary>
        /// <param name="name">名称</param>
        /// <returns>提交值</returns>
        public static string GetQueryString(string name)
        {
            if (SObject.CURRECT_PAGE.Request[name].IsNull())
            {
                return String.Empty;
            }
            return SObject.CURRECT_PAGE.Request[name];
        }

        /// <summary>
        /// 取得当前URL
        /// </summary>
        /// <returns>当前URL</returns>
        public static string GetPath()
        {
            string strPath = String.Format(SString.STRING_URL,
                             HttpContext.Current.Request.ServerVariables[SString.STRING_HOST],
                             HttpContext.Current.Request.ServerVariables[SString.STRING_PATH_INFO],
                             HttpContext.Current.Request.ServerVariables[SString.STRING_QUERY_STRING]);
            if (strPath.IndexOf(SString.QM) > 0)
            {
                strPath = strPath.Substring(0, strPath.IndexOf(SString.QM));
            }
            return strPath;
        }

        /// <summary>
        /// Aspx 转换到 Html
        /// </summary>
        /// <param name="url">地址</param>
        /// <returns>字符串</returns>
        public static string AspxToHtml(this string url)
        {
            //判断路径是否为空
            if (!url.IsEmpty())
            {
                //分割路径
                string[] temp = url.Split(SString.CHAR_QM);

                //路径不合法
                if (temp.Length != 1 && temp.Length != 2)
                {
                    return url;
                }

                //获取路径后缀
                string ext = Path.GetExtension(temp[0]);
                //后缀不为ASPX直接返回
                if (!(ext.Equals(SString.STRING_ASPX, StringComparison.OrdinalIgnoreCase)))
                {
                    return url;
                }

                //截取.aspx中前面的内容
                int offset = temp[0].LastIndexOf(SString.CHAR_POINT);
                string resource = temp[0].Substring(0, offset);

                //路径不带参数时
                if (temp.Length == 1 || string.IsNullOrEmpty(temp[1]))
                {
                    return string.Format(SString.STRING_HTML0, resource);
                }
                string aurl = temp[1].Replace(SString.CHAR_EQ, SString.CHAR_UNDERLINE);
                //路径带参数时
                return string.Format(SString.STRING_HTML01, resource, aurl.Replace(SString.AMP, SString.UNDERLINE_T));

            }
            return String.Empty;
        }

        /// <summary>
        /// Html 转换到 Aspx
        /// </summary>
        /// <param name="url">地址</param>
        /// <returns>字符串</returns>
        public static string HtmlToAspx(this string url)
        {
            //判断路径是否为空
            if (!url.IsEmpty())
            {
                string ext = Path.GetExtension(url);
                //路径不为HTML
                if (!(ext.Equals(SString.STRING_HTML, StringComparison.OrdinalIgnoreCase)))
                {
                    return url;
                }

                string[] temp = url.Split(new String[] { SString.UNDERLINE_TH, SString.POINT }, StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length == 2)
                {
                    return string.Format(SString.STRING_ASPX0, temp[0]);
                }

                if (temp.Length == 3)
                {
                    string aurl = temp[1].Replace(SString.UNDERLINE_T, SString.AMP);
                    return String.Format(SString.STRING_ASPX01, temp[0], aurl.Replace(SString.CHAR_UNDERLINE, SString.CHAR_EQ));
                }
            }

            return String.Empty;
        }

        /// <summary>
        /// 过滤HTML代码
        /// </summary>
        /// <param name="fieldValue">要过滤的数据</param>
        /// <returns>过滤后的数据</returns>
        public static string FilterHTML(this string str)
        {
            Regex regexScript = new Regex(SString.STRING_SCRIPT, RegexOptions.IgnoreCase);
            Regex regexHref = new Regex(SString.STRING_HREFSCRIPT, RegexOptions.IgnoreCase);
            Regex regexOn = new Regex(SString.HTML_EVEN, RegexOptions.IgnoreCase);
            Regex regexIframe = new Regex(SString.STRING_IFRAME, RegexOptions.IgnoreCase);
            Regex regexFrameset = new Regex(SString.HTML_IFRAMESET, RegexOptions.IgnoreCase);
            string html = str.Trim();
            html = regexScript.Replace(html, String.Empty); //过滤<script></script>标记
            html = regexHref.Replace(html, String.Empty); //过滤href=javascript: (<A>) 属性
            html = regexOn.Replace(html, SString.HTML_EVEN_R); //过滤其它控件的on事件
            html = regexIframe.Replace(html, String.Empty); //过滤iframe
            html = regexFrameset.Replace(html, String.Empty); //过滤frameset
            return html;
        }

        #endregion

        #endregion

        #region 类型转换
        /// <summary>
        /// 返回对象obj的String值,obj为null时返回空值。
        /// </summary>
        /// <param name="obj">对象。</param>
        /// <returns>字符串。</returns>
        public static string ToObjectString(object obj)
        {
            return null == obj ? String.Empty : obj.ToString();
        }

        /// <summary>
        /// 转换成INT
        /// </summary>
        /// <param name="obj">要转换的对象</param>
        /// <returns>转换结果</returns>
        public static int ToInt(this object obj)
        {
            try
            {
                if (obj.IsNull())
                {
                    return 0;
                }
                int ret = Convert.ToInt32(obj);
                return ret;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
            return 0;
        }

        /// <summary>
        /// 转换成INT
        /// </summary>
        /// <param name="obj">要转换的对象</param>
        /// <returns>转换结果</returns>
        public static decimal ToDec(this object obj)
        {
            try
            {
                if (obj.IsNull())
                {
                    return 0;
                }
                decimal ret = Convert.ToDecimal(obj);
                return ret;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
            return 0;
        }

        /// <summary>
        /// 转换成BOOL
        /// </summary>
        /// <param name="obj">要转换的对象</param>
        /// <returns>转换结果</returns>
        public static bool ToBool(this object obj)
        {
            try
            {
                if (obj.IsNull())
                {
                    return false;
                }
                bool ret = Convert.ToBoolean(obj);
                return ret;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
            return false;
        }

        /// <summary>
        /// 转换成DateTime
        /// </summary>
        /// <param name="obj">要转换的对象</param>
        /// <returns>转换结果</returns>
        public static DateTime ToDateTime(this object obj)
        {
            try
            {
                DateTime ret = Convert.ToDateTime(obj);
                return ret;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
            return SObject.EMPTY_DATE_TIME;
        }

        #endregion

        #region 数据判断
        /// <summary>
        /// 判断对象是否为正确的日期值。
        /// </summary>
        /// <param name="obj">对象。</param>
        /// <returns>Boolean。</returns>
        public static bool IsDateTime(this object obj)
        {
            try
            {
                DateTime dt = DateTime.Parse(ToObjectString(obj));
                if (dt > DateTime.MinValue && DateTime.MaxValue > dt)
                    return true;
                return false;
            }
            catch
            { return false; }
        }

        /// <summary>
        /// 判断对象是否为正确的Int32值。
        /// </summary>
        /// <param name="obj">对象。</param>
        /// <returns>Int32值。</returns>
        public static bool IsInt(this  object obj)
        {
            try
            {
                int.Parse(ToObjectString(obj));
                return true;
            }
            catch
            { return false; }
        }

        /// <summary>
        /// 判断对象是否为正确的Long值。
        /// </summary>
        /// <param name="obj">对象。</param>
        /// <returns>Long值。</returns>
        public static bool IsLong(this  object obj)
        {
            try
            {
                long.Parse(ToObjectString(obj));
                return true;
            }
            catch
            { return false; }
        }

        /// <summary>
        /// 判断对象是否为正确的Float值。
        /// </summary>
        /// <param name="obj">对象。</param>
        /// <returns>Float值。</returns>
        public static bool IsFloat(this object obj)
        {
            try
            {
                float.Parse(ToObjectString(obj));
                return true;
            }
            catch
            { return false; }
        }

        /// <summary>
        /// 判断对象是否为正确的Double值。
        /// </summary>
        /// <param name="obj">对象。</param>
        /// <returns>Double值。</returns>
        public static bool IsDouble(this  object obj)
        {
            try
            {
                double.Parse(ToObjectString(obj));
                return true;
            }
            catch
            { return false; }
        }

        /// <summary>
        /// 判断对象是否为正确的Decimal值。
        /// </summary>
        /// <param name="obj">对象。</param>
        /// <returns>Decimal值。</returns>
        public static bool IsDecimal(this  object obj)
        {
            try
            {
                decimal.Parse(ToObjectString(obj));
                return true;
            }
            catch
            { return false; }
        }
        #endregion
    }
}
