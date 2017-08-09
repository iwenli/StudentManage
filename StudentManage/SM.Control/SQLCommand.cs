
/* **********************************************************************
 *                   类【SQLCommand.cs】信息
 *                    
 * 所属项目：SM.Control       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：SQLCommand
 * 功    能：SQL数据库基础操作类
 * 来    历：HUCSD 创建于 2013-08-12 16:54:43 
 * 
 * **********************************************************************/

using System.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.ServiceProcess;

namespace SM.BaseControls
{
    /// <summary>
    /// SQL执行工具
    /// </summary>
    public class SQLCommand
    {
        private string SqlServerName = "";
        /// <summary>
        /// SQL链接字符串
        /// </summary>
        static string conString = SString.SQL_CONN_STR_PWD;

        private static readonly object _lockObject = new object();
        /// <summary>
        /// 数据库链接
        /// </summary>
        private static SqlConnection m_con;

        /// <summary>
        /// 用指定的服务名称初始化服务对象
        /// </summary>
        /// <param name="serverName">服务名称</param>
        public SQLCommand(string serverName)
        {
            this.SqlServerName = serverName;
        }

        /// <summary>
        /// 自定义数据库链接
        /// </summary>
        /// <returns>数据链接</returns>
        public static SqlConnection getSqlConn()
        {
            if (m_con.IsNull())
            {
                lock (_lockObject)
                {
                    if (m_con.IsNull())
                    {
                        try
                        {
                            m_con = new SqlConnection(conString);
                        }
                        catch(Exception excep)
                        {
                            LogHelper.WriteLog(SMessage.ERR, excep);
                        }
                    }
                }
            }
            return m_con;
        }

        /// <summary>
        /// 根据查询语句查询数据  返回DataSet
        /// </summary>
        /// <param name="str">查询语句</param>
        /// <returns>数据</returns>
        public static DataSet ExecuteSelectSql(string sql)
        {

            SqlConnection con = getSqlConn();
            
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            try
            {
                sda.Fill(ds);
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(SMessage.ERR, ex);
            }
            finally
            {
                con.Close();
                sda.Dispose();
            }
            return ds;
        }

        /// <summary>
        /// 根据查询语句查询数据  返回DataTable
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <returns>数据</returns>
        public static DataTable ExecuteSelectSqlTable(string sql)
        {
            DataSet ds = ExecuteSelectSql(sql);
            if (!ds.Tables.Count.Equals(0) && !ds.Tables[0].Rows.Count.Equals(0))
            {
                return ds.Tables[0];
            }
            return new DataTable();
        }

        /// <summary>
        /// 根据查询语句查询数据  返回SqlDataAdapter
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <returns>数据</returns>
        public static SqlDataAdapter ExecuteSelectSqlPager(string sql)
        {
            SqlConnection con = getSqlConn();
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            con.Close();
            return sda;
        }

        public static SqlDataReader ExecuteSelectSqlReader(string sql)
        {
            SqlConnection con = getSqlConn();
            SqlDataReader sdr;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return sdr;
            }
            catch (Exception ex)
            {
                //write log
                return null;
            }
        }
        /// <summary>
        /// 根据SQL语句更新数据
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>是否更新成功</returns>
        public static bool ExcuteData(string sql)
        {
            int action = -1;
            SqlConnection con = getSqlConn();
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                action = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(SMessage.ERR, ex);
                return false;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return action>0;
        }

        /// <summary>
        /// 根据SQL语句更新多条数据
        /// </summary>
        /// <param name="sqls">SQL语句</param>
        /// <returns>是否更新成功</returns>
        public static bool ExcuteDatas(List<String> sqls)
        {
            int action = -1;
            SqlConnection con = getSqlConn();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction tran = null;
            try
            {
                con.Open();
                tran = con.BeginTransaction(IsolationLevel.ReadCommitted);
                cmd.Connection = con;
                cmd.Transaction = tran;
                foreach (string sql in sqls)
                {
                    cmd.CommandText = sql;
                    action = cmd.ExecuteNonQuery();
                    if (action.Equals(-1))
                    {
                        tran.Rollback();
                        return false;
                    }
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                LogHelper.WriteLog(SMessage.ERR, ex);
                return false;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return true;
        }

        /// <summary>
        /// 判断是否存在  
        /// </summary>
        public static bool isExist(string sql)   //判断是否存在
        {
            bool flag = false;
            SqlDataReader sdr = ExecuteSelectSqlReader(sql);
            sdr.Read();
            if (sdr.HasRows)    //存在
            {
                flag = true;
            }
            sdr.Close();
            return flag;
        }

        /// <summary>
        /// 删除指定表指定ID的数据
        /// </summary>
        /// <param name="Table">表名</param>
        /// <param name="key">字段名</param>
        /// <param name="value">值</param>
        /// <returns>是否删除成功</returns>
        public static bool DeleteData(string table, string key, string value)
        {
            string sql = String.Format(SString.SQL_DELETE_DATA, table, key, value);
            if (ExcuteData(sql))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 提取指定表指定字段的数据
        /// </summary>
        /// <param name="keyName">要查询的字段</param>
        /// <param name="tableName">要查询的表</param>
        /// <param name="checkName">要检索的字段</param>
        /// <param name="checkValue">检索的值</param>
        /// <returns>值</returns>
        public static string GetValue(string keyName, string tableName, string checkName, string checkValue)
        {
            string sql = String.Format(SString.SQL_GET_VALUE, keyName, tableName, checkName, checkValue);
            DataSet ds = new DataSet();
            ds = ExecuteSelectSql(sql);
            if (ds.Tables[0].Rows.Count.Equals(0))
            {
                return String.Empty;
            }
            return ds.Tables[0].Rows[0][0].ToString();
        }

        /// <summary>
        ///  根据指定条件提取数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="checkName">要检索的字段</param>
        /// <param name="checkValue">检索的值</param>
        /// <returns>值</returns>
        public static DataTable GetTable(string tableName, string checkName, string checkValue)
        {
            string sql = String.Format(SString.SQL_GET_TABLE, tableName, checkName, checkValue);
            DataSet ds = new DataSet();
            ds = ExecuteSelectSql(sql);
            if (ds.Tables.Count.Equals(0) || ds.Tables[0].Rows.Count.Equals(0))
            {
                return new DataTable();
            }
            return ds.Tables[0];
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="Table">表名</param>
        /// <param name="KeyName">字段名</param>
        /// <param name="Value">值</param>
        /// <param name="Id">ID</param>
        /// <returns>是否更新成功</returns>
        public static bool UpdateData(string Table, string KeyName, string Value, int Id)
        {
            string sql = String.Format(SString.SQL_UPDATE_DATA, Table, KeyName, Value, DateTime.Now, Id);
            if (ExcuteData(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 查看指定的SQL Server服务是否启动
        /// </summary>
        /// <returns>配置的服务不存在 返回-1; 停止返回0; 启动返回1</returns>
        public int  SQLServerIsStart()
        {
            int  flag = -1;
            try
            {
                ServiceController sc = new ServiceController(this.SqlServerName);
                if (sc.Status.Equals(ServiceControllerStatus.Stopped))
                {
                    flag = 0;
                }
                else
                {
                    flag = 1;
                }
            }
            catch (Exception ex)
            {
                //write log
                flag= -1;
            }
            return flag;
        }

        /// <summary>
        /// 启动该对象的SQL Server服务
        /// </summary>
        /// <returns></returns>
        public bool SQLServerStart()
        {
            ServiceController sc = new ServiceController(this.SqlServerName);
            bool flag = false;
            try
            {
                sc.Start();
                flag = true;
            }
            catch(Exception ex)
            {
                //write log
                flag = false;
            }
            return flag;
        }

        /// <summary>
        /// 停止该对象的SQL Server服务
        /// </summary>
        /// <returns></returns>
        public bool SQLServerStop()
        {
            ServiceController sc = new ServiceController(this.SqlServerName);
            bool flag = false;
            try
            {
                sc.Stop();
                flag = true;
            }
            catch (Exception ex)
            {
                //write log
                flag = false;
            }
            return flag;
        }
    }
}
