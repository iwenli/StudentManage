
/* **********************************************************************
 *                   类【OutPutData.cs】信息
 *                    
 * 所属项目：SM.BaseControls.util       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：OutPutData
 * 功    能：自定义导出数据
 * 来    历：HUCSD 创建于 2013-08-23 11:13:25 
 * 
 * **********************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace SM.BaseControls
{
    /// <summary>
    /// 数据导出集合（字节流方式）  适用于winForm
    /// </summary>
    public class OutPutData
    {
        /// <summary>
        /// 从listbox中导出数据
        /// </summary>
        /// <param name="lbox">listbox控件</param>
        /// <param name="txtTitle">导出数据的标题</param>
        /// <param name="filter">导出数据的格式(拓展名)</param>
        public static  void outPutListBoxData(ListBox lbox, string txtTitle, string filter)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "user files(" + filter + ")|" + filter;
            save.Title = "导出文件到";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Stream myStream = save.OpenFile();
                StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding("GB2312"));
                try
                {
                    //写标题
                    sw.WriteLine(txtTitle);
                    //循环写内容
                    for (int i = 0; i < lbox.Items.Count; i++)
                    {
                        string tempStr = "";
                        tempStr += lbox.Items[i].ToString();
                        tempStr += "\t";
                        sw.WriteLine(tempStr);
                    }
                    MessageBox.Show("导出数据成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sw.Close();
                    myStream.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                finally
                {
                    sw.Close();
                    myStream.Close();
                }
            }
        }

        /// <summary>
        /// 导出DataSet数据 
        /// </summary>
        /// <param name="ds">数据源</param>
        /// <param name="txtTitle">导出数据的标题</param>
        /// <param name="filter">导出数据的格式</param>
        public static void outPutDataSet(DataSet ds, string txtTitle, string filter)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "user files(" + filter + ")|" + filter;
            save.Title = "导出文件到";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Stream myStream = save.OpenFile();
                StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding("GB2312"));
                try
                {
                    //写标题
                    sw.WriteLine(txtTitle);
                    //写数据字段
                    string tempTitle = "";
                    for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                    {
                        if (i > 0)
                        {
                            tempTitle += "\t";
                        }
                        tempTitle += ds.Tables[0].Columns[i].ColumnName;
                    }
                    sw.WriteLine(tempTitle);

                    //循环写内容
                    for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                    {
                        string tempStr = "";
                        for (int k = 0; k < ds.Tables[0].Columns.Count; k++)
                        {
                            if (k > 0)
                            {
                                tempStr += "\t";
                            }
                            if (ds.Tables[0].Rows[j][k].GetType().ToString().Equals("System.String") &&
                                ds.Tables[0].Rows[j][k].ToString().IsInt())
                            {
                                tempStr += "'";
                            }

                            tempStr += ds.Tables[0].Rows[j][k].ToString();
                        }
                        sw.WriteLine(tempStr);
                    }
                    MessageBox.Show("导出数据成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sw.Close();
                    myStream.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                finally
                {
                    sw.Close();
                    myStream.Close();
                }
            }
        }

        /// <summary>
        /// 导出DataSet数据 无标题
        /// </summary>
        /// <param name="ds">数据源</param>
        /// <param name="filter">导出数据的格式</param>
        public static void outPutDataSet(DataSet ds, string filter)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "user files(" + filter + ")|" + filter;
            save.Title = "导出文件到";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Stream myStream = save.OpenFile();
                StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding("GB2312"));
                try
                {
                    //写数据字段
                    string tempTitle = "";
                    for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                    {
                        if (i > 0)
                        {
                            tempTitle += "\t";
                        }
                        tempTitle += ds.Tables[0].Columns[i].ColumnName;
                    }
                    sw.WriteLine(tempTitle);

                    //循环写内容
                    for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                    {
                        string tempStr = "";
                        for (int k = 0; k < ds.Tables[0].Columns.Count; k++)
                        {
                            if (k > 0)
                            {
                                tempStr += "\t";
                            }

                            if (ds.Tables[0].Rows[j][k].GetType().ToString().Equals("System.String") &&
                                ds.Tables[0].Rows[j][k].ToString().IsInt())
                            {
                                tempStr += "'";
                            }
                            tempStr += ds.Tables[0].Rows[j][k].ToString();
                        }
                        sw.WriteLine(tempStr);
                    }
                    MessageBox.Show("导出数据成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sw.Close();
                    myStream.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                finally
                {
                    sw.Close();
                    myStream.Close();
                }
            }
        }


        /// <summary>
        /// 导出DataGridView数据
        /// </summary>
        /// <param name="dgv">DataGridView控件</param>
        /// <param name="txtTitle">导出数据标题</param>
        /// <param name="filter">导出数据格式</param>
        public static void outPutDataGridViewData(DataGridView dgv, string txtTitle, string filter)
        {
            DataSet myds = (DataSet)dgv.DataSource;
            outPutDataSet(myds, txtTitle, filter);
        }

        /// <summary>
        /// 导出DataGridView数据
        /// </summary>
        /// <param name="dgv">DataGridView控件</param>        
        /// <param name="filter">导出数据格式</param>

        public static void outPutDataGridViewData(DataGridView dgv, string filter)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "user files(" + filter + ")|" + filter;
            save.Title = "导出文件到";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Stream myStream = save.OpenFile();
                StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding("GB2312"));
                try
                {
                    //写数据字段
                    string tempTitle = "";
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        if (i > 0)
                        {
                            tempTitle += "\t";
                        }
                        tempTitle += dgv.Columns[i].Name;
                        //tempTitle += ds.Tables[0].Columns[i].ColumnName;
                    }
                    sw.WriteLine(tempTitle);

                    //循环写内容
                    for (int j = 0; j < dgv.Rows.Count; j++)
                    {
                        string tempStr = "";
                        for (int k = 0; k < dgv.Columns.Count; k++)
                        {
                            if (k > 0)
                            { tempStr += "\t"; }
                            tempStr += dgv.Rows[j].Cells[k].Value.ToString();
                        }
                        sw.WriteLine(tempStr);
                    }
                    MessageBox.Show("导出数据成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sw.Close();
                    myStream.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                finally
                {
                    sw.Close();
                    myStream.Close();
                }
            }
        }

    }
}
