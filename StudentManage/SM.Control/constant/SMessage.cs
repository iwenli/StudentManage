
/* **********************************************************************
 *                   类【SQLCommand.cs】信息
 *                    
 * 所属项目：SM.Control       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：SQLCommand
 * 功    能：常量类之提示信息常量
 * 来    历：HUCSD 创建于 2013-08-12 16:54:43 
 * 
 * **********************************************************************/

namespace SM.BaseControls
{
    /// <summary>
    /// 提示信息常量类
    /// </summary>
    public static class SMessage
    {
        public const string ERR = "\r\n服务器运行错误;";

        public const string APP_START = "\r\n服务器开启时间:";

        public const string APP_END = "\r\n服务器关闭时间:";

        public const string USER_HOST_ADDR = "\r\n客户机IP:";

        public const string URL = "\r\n访问地址:";

        public const string TIME = "\r\n访问时间:";

        public const string DELETE_SUCCESS = "删除成功！";

        public const string DELETE_FAIL = "删除失败，请与管理员联系……";

        public const string ADD_SUCCESS = "添加成功！";

        public const string ADD_FAIL = "添加失败，请与管理员联系……";

        public const string UPDATE_SUCCESS = "更新成功！";

        public const string UPDATE_FAIL = "更新失败，请与管理员联系……";

        public const string SELECT_NO_ROW = "请至少选择一行……";

        public const string SELECT_PROMPT = "提示对话框";

        public const string ALREADY_USED = "'{0} '已经被使用，请换个！";

        public const string NO_FOUND = "暂无资源";

        #region 控件验证出错时提示信息
        /// <summary>
        /// 请输入正确的学号
        /// </summary>
        public const string ERR_STU_ID = "请输入正确的学号";
        /// <summary>
        /// 请输入正确的身份证号
        /// </summary>
        public const string ERR_ID_DATE = "请输入正确的身份证号";
        /// <summary>
        /// 请输入正确的姓名
        /// </summary>
        public const string ERR_NAME = "请输入正确的姓名";
        /// <summary>
        /// 两次密码不一致
        /// </summary>
        public const string ERR_PWD_SURE = "两次密码不一致";
        /// <summary>
        /// 请输入正确的验证码
        /// </summary>
        public const string ERR_CAPTCHA = "请输入正确的验证码";
        /// <summary>
        /// 请输入正确的密码，密码为6~18位的任意字符组合
        /// </summary>
        public const string ERR_PWD = "请输入正确的密码，密码为6~18位的除空格外任意字符组合";
        #endregion
    }
}
