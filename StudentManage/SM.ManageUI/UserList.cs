
/* **********************************************************************
 *                   类【UserList.cs】信息
 *                    
 * 所属项目：SM.ManageUI       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：UserList
 * 功    能：登陆用户类表
 * 来    历：HUCSD 创建于 2013-08-22 17:11:52 
 * 
 * **********************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using SM.Base;

namespace SM.ManageUI
{
    /// <summary>
    /// 登陆用户类表
    /// </summary>
    [Serializable]
    public class UserList
    {
        /// <summary>
        /// 文件头
        /// </summary>
        private const string HUCSD = "101001010100101001010101010100101100000000000000000000000000000000000000000000000000000000000000001111111111111111111111110100100010101010010101010010101010101010010101010101010101010101111100000000000000000000000000000000000000000111111111111111111111111110000000000000000000000000000000000000000000000000000000000000000011111";

        private List<User> listU = new List<User>();

        /// <summary>
        /// 最后登陆的用户信息
        /// </summary>
        public User LastLoginUser
        {
            get { return listU[listU.Count - 1]; }
        }
        /// <summary>
        /// 登陆用户列表
        /// </summary>
        public List<User> ListU
        {
            set { this.listU = value; }
            get { return this.listU; }
        }

        /// <summary>
        /// 元素索引值
        /// </summary>
        public int Index
        {
            get { return listU.Count - 1; }
        }

        /// <summary>
        /// 查看指定账户是否存在，若存在返回索引  否则返回-1
        /// </summary>
        /// <param name="_user">账户</param>
        /// <returns>存在则为Index  否则为-1</returns>
        public int userIsExists(string  _user)
        {
            for (int i = 0; i <=this.Index; i++)
            {
                if(this.ListU[i].Account.Equals(_user))
                {
                    return i;
                }
            }
            return -1;

        }
    }
}
