
/* **********************************************************************
 *                   类【User.cs】信息
 *                    
 * 所属项目：SM.Base       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：User
 * 功    能：登陆信息
 * 来    历：HUCSD 创建于 2013-08-13 09:14:55 
 * 
 * **********************************************************************/
using System;
using System.Data.SqlClient;
using SM.BaseControls;


namespace SM.Base
{
    /// <summary>
    /// 用户权限
    /// </summary>
    public enum RootUser { root = 1, admin = 2, classAdmin = 3 };
    
    /// <summary>
    /// 登陆信息类
    /// </summary>
    [Serializable]
    public class User
    {
        public User()
        { 
        }

        public User(string ac, string pwd)
        {
            this.account = ac;
            this.passWord = pwd;
        }

        /// <summary>
        /// 权限
        /// </summary>
        public static string[] Root = { "非法账户", "超级管理员", "一般管理员", "班级管理员" };

        private string account;
        /// <summary>
        /// 账号
        /// </summary>
        public string Account
        {
            get { return account; }
            set { account = value; }
        }
        private string passWord;
        /// <summary>
        /// 口令 
        /// </summary>
        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        private int role = 0;
        /// <summary>
        /// 权限
        /// </summary>
        public string Role
        {
            get { return Root[role]; }
        }
        private string belongClass;
        /// <summary>
        /// 所属班级编号
        /// </summary>
        public string BelongClass
        {
            get { return belongClass; }
        }

 
        /// <summary>
        /// 学生登陆
        /// </summary>
        /// <returns>成功返回true</returns>
        public bool uLogin()
        {
            string _sql = String.Format(SString.SQL_GET_TABLE, SColumn.U_LOGIN, SColumn.U_NAME, this.account)
            + SString.SQL_AND + SColumn.U_PASSWD + String.Format(SString.SQL_EQ, DHelper.EncryptMD5(this.passWord));
            return SQLCommand.isExist(_sql);
        }

        /// <summary>
        /// 管理登陆
        /// </summary>
        /// <returns> 成功返回true</returns>
        public bool mLogin()
        {
            return true;
            //bool bz = false;
            //string _sql = String.Format(SString.SQL_GET_TABLE, SColumn.M_LOGIN, SColumn.M_NAME, this.account)
            //    + SString.SQL_AND + SColumn.M_PASSWD + String.Format(SString.SQL_EQ, DHelper.EncryptMD5(this.passWord));
            //SqlDataReader sdr = SQLCommand.ExecuteSelectSqlReader(_sql);
            //if (sdr.IsNull())
            //{
            //    return false;
            //}
            //sdr.Read();
            //if (sdr.HasRows)
            //{
            //    this.role = sdr[SColumn.M_ROLE].ToInt();
            //    this.belongClass = sdr[SColumn.M_CLASS].ToString();
            //    return true;
            //}
            //sdr.Close();
            //return bz;
        }

        /// <summary>
        /// 判断用户是否可以更改密码
        /// </summary>
        /// <param name="id">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="idDate">身份证号</param>
        /// <returns>true 可以更改</returns>
        public static bool checkUserExist(string id, string name, string idDate)
        {
            string _sql = String.Format(SString.SQL_GET_TABLE, SColumn.BASIC_INFO, SColumn.STUDENT_ID, id) + SString.SQL_AND + SColumn.STUDENT_NAME + String.Format(SString.SQL_EQ, name) + SString.SQL_AND + SColumn.STUDENT_ID_DATE + String.Format(SString.SQL_EQ, idDate);
            return SQLCommand.isExist(_sql);
        }

        /// <summary>
        /// 学生重置密码
        /// </summary>
        /// <param name="id">学号</param>
        /// <param name="pwd">新密码</param>
        /// <returns>true 重置成功</returns>
        public static bool uChangePwd(string id, string pwd)
        {
            string _sql = String.Format(SString.SQL_UPDATE_DATA, SColumn.U_LOGIN, SColumn.U_PASSWD, DHelper.EncryptMD5(pwd), SColumn.U_NAME, id);
            return SQLCommand.ExcuteData(_sql);
        }
        
        /// <summary>
        /// 学生更改密码
        /// </summary>
        /// <param name="id">学号</param>
        /// <param name="oldPwd">旧密码</param>
        /// <param name="newPwd">新密码</param>
        /// <returns>true 更改成功</returns>
        public static bool uChangePwd(string id, string oldPwd, string newPwd)
        {
            string _sql = String.Format(SString.SQL_UPDATE_DATA, SColumn.U_LOGIN, SColumn.U_PASSWD, DHelper.EncryptMD5(newPwd), SColumn.U_NAME, id) + SString.SQL_AND + SColumn.U_PASSWD + String.Format(SString.SQL_EQ, DHelper.EncryptMD5(oldPwd));
            return SQLCommand.ExcuteData(_sql);
        }
    }
}
