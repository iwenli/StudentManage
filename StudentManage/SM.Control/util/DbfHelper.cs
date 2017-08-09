
/* **********************************************************************
 *                   类【DbfHelper.cs】信息
 *                    
 * 所属项目：SM.BaseControls.util       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：DbfHelper
 * 功    能：bdf文件操作
 * 来    历：HUCSD 创建于 2013-09-03 20:50:14 
 * 
 * **********************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace SM.BaseControls 
{
    /// <summary>
    /// bdf文件操作类
    /// </summary>
    public class DbfHelper
    {
        #region 读取DBF文件
        /// <summary>
        /// 读取DBF文件
        /// </summary>
        /// <param name="filepath">DBF文件路径</param>
        /// <param name="dataGridView">DataGridView控件</param>
        /// <returns>成功返回true</returns>
        public static bool ReadDBFFile(string filepath, DataGridView dataGridView)
        {
            bool flag = false;
            try
            {
                dataGridView.DataSource = null;
                //dataGridView.Rows.Clear();
                //dataGridView.Columns.Clear();

                //打开文件
                FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                //跳过前面4个
                br.ReadBytes(4);
                //文件中的记录条数,即行数
                int rowCount = br.ReadInt32();//4
                //文件头的长度
                int headLength = br.ReadInt16();//2           
                //每行的长度
                int rowLength = br.ReadInt16();//2
                //计算字段数目
                int columnCount = (headLength - 33) / 32;
                //跳过32-4-4-2-2=20个，直接到32
                br.ReadBytes(20);

                int i, j;
                byte[] tempBytes = null;
                byte tempByte;
                int[] fieldLength = null;
                //添加表格的列
                if (columnCount > 0)
                {
                    string tempColumnName;
                    fieldLength = new int[columnCount];
                    for (i = 0; i < columnCount; i++)
                    {
                        //读取前11个，为列名称
                        tempBytes = br.ReadBytes(11);
                        tempColumnName = ConvertBytesToString(tempBytes);
                        dataGridView.Columns.Add(tempColumnName, tempColumnName);
                        //跳过5个
                        br.ReadBytes(5);
                        //获取字段长度
                        tempByte = br.ReadByte();
                        fieldLength[i] = (int)tempByte;
                        //跳过剩下的字节，有32-11-5-1=15个
                        br.ReadBytes(15);
                    }
                }
                //获取文件头的最后一个字节，值应该为0D
                tempByte = br.ReadByte();
                if (tempByte == 0x0D)
                {
                    //添加表格的行及数据
                    if (rowCount > 0)
                    {
                        string tempStr;
                        for (i = 0; i < rowCount; i++)
                        {
                            dataGridView.Rows.Add();
                            //每行数据中第一个20，跳过
                            br.ReadByte();
                            for (j = 0; j < columnCount; j++)
                            {
                                tempBytes = br.ReadBytes(fieldLength[j]);
                                tempStr = ConvertBytesToString(tempBytes);
                                dataGridView[j, i].Value = tempStr;
                            }
                        }
                        flag = true;
                    }
                }
                else
                {
                    MessageBox.Show("文件头定义出现错误！",
                    "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //write log
                    flag = false;
                }
                br.Close();
                fs.Close();
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message,
                    "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //write log
                flag = false;
            }
            return flag;
        }
        #endregion

        #region 保存DBF文件
        /// <summary>
        /// 保存DBF文件       
        /// </summary>
        /// <param name="filepath">文件全路径</param>
        /// <param name="ds">DataSet对象</param>
        /// <returns>成功返回true</returns>
        public static bool WriteDBFFile(string filepath, DataSet ds)
        {
            bool flag = false;
            try
            {
                int rowCount = ds.Tables[0].Rows.Count;
                int columnCount = ds.Tables[0].Columns.Count;
                if (rowCount > 0 && columnCount > 0)
                {
                    FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);

                    byte tempByte;
                    byte[] tempBytes;
                    int i, j, tempInt;

                    int[] fieldLength = new int[columnCount];
                    int tempMax = 0;
                    for (i = 0; i < columnCount; i++)
                    {
                        tempMax = 0;
                        for (j = 0; j < rowCount; j++)
                        {
                            if (ds.Tables[0].Rows[j][i] != null && ds.Tables[0].Rows[j][i].ToString() != "")
                            { 
                                if (ds.Tables[0].Rows[j][i].ToString().Length > tempMax)
                                {
                                    tempMax = ds.Tables[0].Rows[j][i].ToString().Length;
                                }
                            }
                        }
                        fieldLength[i] = tempMax * 2; 
                    }
                   
                    //写入文件头                                                                       
                    {
                        //第0个字节为数据库类型                                                        
                        tempByte = 0x03;
                        bw.Write(tempByte);

                        tempBytes = new byte[3];
                        //第1个字节为保存时的年份-2000                                                 
                        tempInt = DateTime.Now.Year - 2000;
                        tempBytes[0] = System.Convert.ToByte(tempInt);
                        //第2个字节为保存时的月份                                                      
                        tempBytes[1] = System.Convert.ToByte(DateTime.Now.Month);
                        //第3个字节为保存时的日                                                        
                        tempBytes[2] = (byte)(DateTime.Now.Day);
                        bw.Write(tempBytes);

                        //第4-7个字节为行数                                                            
                        bw.Write(rowCount);

                        //第8-9字节为文件头的长度                                                      
                        tempInt = 33 + columnCount * 32;
                        bw.Write((Int16)tempInt);

                        //第10-11为每行数据所占长度                                                    
                        tempInt = 1;
                        for (i = 0; i < columnCount; i++)
                        {
                            tempInt += fieldLength[i];
                        }
                        bw.Write((Int16)tempInt);

                        //第12-31为保留字段，默认为0                                                   
                        tempBytes = new byte[20];
                        bw.Write(tempBytes);

                        string tempColumnName;  
                        //开始写字段                                                                   
                        for (i = 0; i < columnCount; i++)
                        {
                            tempColumnName = ds.Tables[0].Columns[i].ColumnName;
                             
                            tempBytes = ConvertStringToBytes(tempColumnName, 11);
                            bw.Write(tempBytes);
                            //第11个字节为数据类型  
                            tempByte = (byte)('C');//数据类型为字符串
                            bw.Write(tempByte);
                            //第12-15为保留字节 
                            tempBytes = new byte[4];
                            bw.Write(tempBytes);
                            //第16个字节为字段长度 
                            tempByte = (byte)fieldLength[i];
                            bw.Write(tempByte);
                            //接着第17-31都为保留字节 
                            tempBytes = new byte[15];
                            bw.Write(tempBytes);
                            
                        }
                        
                        //最后以0D结尾                                                                 
                        tempByte = 0x0D;
                        bw.Write(tempByte);
                    }
                    
                    object tempValue;
                    //写入单元格数据                                                                   
                    for (i = 0; i < rowCount; i++)
                    {
                        //每一行第一个字节默认为20                                                     
                        tempByte = 0x20;
                        bw.Write(tempByte);
                        for (j = 0; j < columnCount; j++)
                        {
                            tempValue = ds.Tables[0].Rows[i][j];

                            if (!tempValue.ToString ().Trim().IsNull())
                            { 
                                tempBytes = ConvertStringToBytes(tempValue.ToString(), fieldLength[j]);
                                bw.Write(tempBytes);
                            }
                            else
                            { 
                                tempBytes = ConvertStringToBytes("", fieldLength[j]);
                                bw.Write(tempBytes);
                            }
                            
                        }
                    } 
                    bw.Close();
                    fs.Close();
                    flag = true;
                }
                else
                {
                    MessageBox.Show("表格中没有数据",
                     "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //write log
                    flag = false;
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message+"\n\t"+except.Source,
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //write log
                flag = false;
            }
            return flag;
        }

        /// <summary>
        /// /// <summary>                                                                                  
        /// 保存DBF文件                                                                                
        /// </summary>                                                                                 
        /// <param name="filepath">DBF文件保存路径</param>                                             
        /// <param name="dataGridView">表格对象</param> 
        /// <returns>成功返回true</returns>                                      
        public static bool WriteDBFFile(string filepath, DataGridView dataGridView)
        {
            bool flag = false;
            try
            {
                int rowCount = dataGridView.RowCount;
                int columnCount = dataGridView.ColumnCount;
                if (rowCount > 0 && columnCount > 0)
                {
                    FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);

                    byte tempByte;
                    byte[] tempBytes;
                    int i, j, tempInt;

                    int[] fieldLength = new int[columnCount];
                    int tempMax = 0;
                    for (i = 0; i < columnCount; i++)
                    {
                        tempMax = 0;
                        for (j = 0; j < rowCount; j++)
                        {
                            if (dataGridView[i, j].Value != null
                                && dataGridView[i, j].Value.ToString() != "")
                            {
                                if (dataGridView[i, j].Value.ToString().Length > tempMax)
                                {
                                    tempMax = dataGridView[i, j].Value.ToString().Length;
                                }
                            }
                        }
                        fieldLength[i] = tempMax * 2;
                    }

                    //写入文件头                                                                       
                    {
                        //第0个字节为数据库类型                                                        
                        tempByte = 0x03;
                        bw.Write(tempByte);

                        tempBytes = new byte[3];
                        //第1个字节为保存时的年份-1990                                                 
                        tempInt = DateTime.Now.Year - 2000;
                        tempBytes[0] = System.Convert.ToByte(tempInt);
                        //第2个字节为保存时的月份                                                      
                        tempBytes[1] = System.Convert.ToByte(DateTime.Now.Month);
                        //第3个字节为保存时的日                                                        
                        tempBytes[2] = (byte)(DateTime.Now.Day);
                        bw.Write(tempBytes);

                        //第4-7个字节为行数                                                            
                        bw.Write(rowCount);

                        //第8-9字节为文件头的长度                                                      
                        tempInt = 33 + columnCount * 32;
                        bw.Write((Int16)tempInt);

                        //第10-11为每行数据所占长度                                                    
                        tempInt = 1;
                        for (i = 0; i < columnCount; i++)
                        {
                            tempInt += fieldLength[i];
                        }
                        bw.Write((Int16)tempInt);

                        //第12-31为保留字段，默认为0                                                   
                        tempBytes = new byte[20];
                        bw.Write(tempBytes);

                        string tempColumnName;
                        //开始写字段                                                                   
                        for (i = 0; i < columnCount; i++)
                        {
                            tempColumnName = dataGridView.Columns[i].Name;
                            tempBytes = ConvertStringToBytes(tempColumnName, 11);
                            bw.Write(tempBytes);
                            //第11个字节为数据类型                                                     
                            tempByte = (byte)('C');//数据类型为字符串                                  
                            bw.Write(tempByte);
                            //第12-15为保留字节                                                        
                            tempBytes = new byte[4];
                            bw.Write(tempBytes);
                            //第16个字节为字段长度                                                     
                            tempByte = (byte)fieldLength[i];
                            bw.Write(tempByte);
                            //接着第17-31都为保留字节                                                  
                            tempBytes = new byte[15];
                            bw.Write(tempBytes);
                        }

                        //最后以0D结尾                                                                 
                        tempByte = 0x0D;
                        bw.Write(tempByte);
                    }

                    object tempValue;
                    //写入单元格数据                                                                   
                    for (i = 0; i < rowCount; i++)
                    {
                        //每一行第一个字节默认为20                                                     
                        tempByte = 0x20;
                        bw.Write(tempByte);
                        for (j = 0; j < columnCount; j++)
                        {
                            tempValue = dataGridView[j, i].Value;
                            if (tempValue != null)
                            {
                                tempBytes = ConvertStringToBytes(tempValue.ToString(), fieldLength[j]);
                                bw.Write(tempBytes);
                            }
                            else
                            {
                                tempBytes = ConvertStringToBytes("", fieldLength[j]);
                                bw.Write(tempBytes);
                            }
                        }
                    }

                    bw.Close();
                    fs.Close();
                    flag = true;
                }
                else
                {
                    MessageBox.Show("表格中没有数据",
                     "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //write log
                    flag = false;
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message,
                    "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //write log
                flag = false;
            }
            return flag;
        }
        #endregion

        #region private method
        /// <summary>                                                                                  
        /// 将字符串转换成为字节数组                                                                   
        /// </summary>                                                                                 
        /// <param name="tempStr"></param>                                                             
        /// <param name="limitLength"></param>                                                         
        /// <returns></returns>                                                                        
        private static byte[] ConvertStringToBytes(string tempStr, int limitLength)
        {
            byte[] result = new byte[limitLength];
            byte[] tempBytes = UTF8Encoding.GetEncoding("gb2312").GetBytes(tempStr);

            if (tempBytes.Length == limitLength)
            {
                result = tempBytes;
            }
            else if (tempBytes.Length > limitLength)
            {
                for (int i = 0; i < limitLength; i++)
                {
                    result[i] = tempBytes[i];
                }
                
            }
            else if (tempBytes.Length < limitLength)
            {
                result = new byte[limitLength];
                for (int i = 0; i < tempBytes.Length; i++)
                {
                    result[i] = tempBytes[i];
                }
            }
            return result;
        }

        /// <summary>
        /// 将字节组转换成为字符串
        /// </summary>
        /// <param name="tempBytes">字节数组</param>
        /// <returns>DataGridView控件</returns>
        private static  string ConvertBytesToString(byte[] tempBytes)
        {
            string result = System.Text.Encoding.GetEncoding("gb2312").GetString(tempBytes);
            return result;
        }

        /// <summary>
        /// 将字节组转换成为整型
        /// </summary>
        /// <param name="tempBytes">字节数组</param>
        /// <returns></returns>
        private static Int32 ConvertBytesToInt32(byte[] tempBytes)
        {
            Int32 result = System.BitConverter.ToInt32(tempBytes, 0);
            return result;
        }
        #endregion
    }
}