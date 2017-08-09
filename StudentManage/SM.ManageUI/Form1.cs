using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SM.BaseControls;

namespace SM.ManageUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            
            OutPutData.outPutDataSet(SQLCommand.ExecuteSelectSql("select account as 账号, pass_word as 密码,role,belong_class from dbo.manage_login"), "账号信息", ".dbf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OutPutData.outPutDataSet(SQLCommand.ExecuteSelectSql("select account as 账号, pass_word as 密码,role,belong_class from dbo.manage_login"), "账号信息", ".doc");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OutPutData.outPutDataSet(SQLCommand.ExecuteSelectSql("select account as 账号, pass_word as 密码,role,belong_class from dbo.manage_login"), "账号信息", ".xls");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OutPutData.outPutDataSet(SQLCommand.ExecuteSelectSql("select account as 账号, pass_word as 密码,role,belong_class from dbo.manage_login"), "账号信息", ".txt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            FileDialog save = new SaveFileDialog();
            save.Filter = "Excel(.xls)|.xls";
            save.Title = "导出Excel文件  by:HUC_SD";
            
            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName.ToString();
                save.Dispose();
                if (SM.BaseControls.util.ExcelHelper.OutputToExcel(
                    SQLCommand.ExecuteSelectSqlTable("select account as 账号, pass_word as 密码,role,belong_class from dbo.manage_login"),
                    save.FileName))//"C:\\123.xls"
                {
                    MessageBox.Show("导出成功！");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileDialog save = new OpenFileDialog();
            save.Filter = "Excel(.xls)|.xls";
            save.Title = "导入Excel文件  by:HUC_SD";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName.ToString();
                save.Dispose();
                DataTable dt = SM.BaseControls.util.ExcelHelper.InputFromExcel(save.FileName, "user");//"C:\\123.xls"
              dataGridView1.DataSource=dt;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IniHelper ini = new IniHelper(Application.StartupPath + @"\config\SM_SQL_CONFIG.ini");
            ini.IniWriteValue("SQL", "SERVER_NAME", "MSSQL$SA_2005");
            ini.IniWriteValue("SQL","SQL_CONN_STR_PWD","Data Source=BOSS007\\SA_2005;Initial Catalog=stu;Persist Security Info=True;User ID=sa;pwd=123456"); 
            ini.IniWriteValue("SQL", "SQL_CONN_STR", "Data Source=boss007\\SA_2005;Initial Catalog=stu;Integrated Security=True");
            MessageBox.Show(ini.IniReadValue("SQL", "SQL_CONN_STR_PWD"));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FileDialog save = new SaveFileDialog();
            save.Filter = "VF(.dbf)|.dbf";
            save.Title = "导出VF文件  by:HUC_SD";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName.ToString();
                save.Dispose();
                //DataTable dt = SM.BaseControls.util.ExcelHelper.InputFromExcel(save.FileName, "user");//"C:\\123.xls"
                //dataGridView1.DataSource = dt;
                if (DbfHelper.WriteDBFFile(path, SQLCommand.ExecuteSelectSql(
                     "select account as 账号, pass_word as 密码,role,belong_class from dbo.manage_login")))
                {
                    MessageBox.Show("导出成功");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FileDialog save = new SaveFileDialog();
            save.Filter = "VF(.dbf)|.dbf";
            save.Title = "导出VF文件  by:HUC_SD";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName.ToString();
                save.Dispose();
                //DataTable dt = SM.BaseControls.util.ExcelHelper.InputFromExcel(save.FileName, "user");//"C:\\123.xls"
                //dataGridView1.DataSource = dt;
                if (DbfHelper.WriteDBFFile(path, dataGridView1))
                {
                    MessageBox.Show("导出成功");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FileDialog save = new OpenFileDialog();
            save.Filter = "VF(.dbf)|.dbf";
            save.Title = "导入VF文件  by:HUC_SD";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName.ToString();
                save.Dispose();
                //DataTable dt = SM.BaseControls.util.ExcelHelper.InputFromExcel(save.FileName, "user");//"C:\\123.xls"
                //dataGridView1.DataSource = dt;
                if (DbfHelper.ReadDBFFile(path, dataGridView1))
                {
                    MessageBox.Show("导入成功");
                }
            }
        }
    }
}
