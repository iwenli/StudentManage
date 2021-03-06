﻿
/* **********************************************************************
 *                   类【Class1.cs】信息
 *                    
 * 所属项目：ConsoleApplication1       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：Class1
 * 功    能： 
 * 来    历：HUCSD 创建于 2013-12-02 19:18:48 
 * 
 * **********************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {



        /// <summary〉 
        /// 汉字转拼音缩写 
        /// Code By MuseStudio@hotmail.com 
        /// 2004-11-30 
        /// </summary〉 
        /// <param name="str"〉要转换的汉字字符串</param〉 
        /// <returns〉拼音缩写</returns〉 
        public string GetPYString(string str)
        {

            string tempStr = "";

            foreach (char c in str)
            {

                if (Convert.ToInt32(c) >= 33 && Convert.ToInt32(c) <= 126)
                {//字母和符号原样保留 

                    tempStr += c.ToString();

                }

                else
                {//累加拼音声母 

                    tempStr += GetPYChar(c.ToString());

                }

            }

            return tempStr;
        }

        /// <summary〉 
        /// /// Code By MuseStudio@hotmail.com 
        /// 2004-11-30 
        /// </summary〉 
        /// <param name="c"〉要转换的单个汉字</param〉 
        /// <returns〉拼音声母</returns〉 
        public string GetPYChar(string c)
        {

            byte[] array = new byte[2];

            array = System.Text.Encoding.Default.GetBytes(c);

            int i = (short)(array[0] - '\0') * 256 + ((short)(array[1] - '\0'));


            if (i < 0xB0A1) return "*";

            if (i < 0xB0C5) return "a";

            if (i < 0xB2C1) return "b";

            if (i < 0xB4EE) return "c";

            if (i < 0xB6EA) return "d";

            if (i < 0xB7A2) return "e";

            if (i < 0xB8C1) return "f";

            if (i < 0xB9FE) return "g";

            if (i < 0xBBF7) return "h";

            if (i < 0xBFA6) return "g";

            if (i < 0xC0AC) return "k";

            if (i < 0xC2E8) return "l";

            if (i < 0xC4C3) return "m";

            if (i < 0xC5B6) return "n";

            if (i < 0xC5BE) return "o";

            if (i < 0xC6DA) return "p";

            if (i < 0xC8BB) return "q";

            if (i < 0xC8F6) return "r";

            if (i < 0xCBFA) return "s";

            if (i < 0xCDDA) return "t";

            if (i < 0xCEF4) return "w";

            if (i < 0xD1B9) return "x";

            if (i < 0xD4D1) return "y";

            if (i < 0xD7FA) return "z";

            return "*";
        }
    }
}
