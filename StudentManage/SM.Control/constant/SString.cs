
/* **********************************************************************
 *                   类【SQLCommand.cs】信息
 *                    
 * 所属项目：SM.Control       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：SQLCommand
 * 功    能：常量类之字符创常量
 * 来    历：HUCSD 创建于 2013-08-12 16:54:43 
 * 
 * **********************************************************************/

namespace SM.BaseControls
{
    /// <summary>
    /// 常用字符串常量类
    /// </summary>
    public static class SString
    {
        #region CHAR

        public const char CHAR_COMMA = ',';

        public const char CHAR_POINT = '.';

        public const char CHAR_QM = '?';

        public const char CHAR_EQ = '=';

        public const char CHAR_UNDERLINE = '_';

        #endregion

        #region 符号

        /// <summary>
        /// 省略号
        /// </summary>
        public const string OMITTED = "...";

        /// <summary>
        /// 点
        /// </summary>
        public const string POINT = ".";

        /// <summary>
        /// 替换点
        /// </summary>
        public const string POINT_R = @"\.";

        /// <summary>
        /// W
        /// </summary>
        public const string W = @"\W";

        /// <summary>
        /// 逗号
        /// </summary>
        public const string COMMA = ",";

        /// <summary>
        /// 问号
        /// </summary>
        public const string QM = "?";

        /// <summary>
        /// 等号
        /// </summary>
        public const string EQ = "=";

        /// <summary>
        /// 且
        /// </summary>
        public const string AMP = "&";

        /// <summary>
        /// 两个下滑线
        /// </summary>
        public const string UNDERLINE_T = "__";

        /// <summary>
        /// 三个下滑线
        /// </summary>
        public const string UNDERLINE_TH = "___";

        /// <summary>
        /// 分割线
        /// </summary>
        public const string SPLIT = "|";

        /// <summary>
        /// 错误
        /// </summary>
        public const string ERROR = "×";

        /// <summary>
        /// 正确
        /// </summary>
        public const string RIGHT = "√";

        #endregion

        #region SQL
        /// <summary>
        ///　SQL ='{0}'
        /// </summary>
        public const string SQL_EQ = " = '{0}' ";
        /// <summary>
        /// ＳＱＬ　ａｎｄ
        /// </summary>
        public const string SQL_AND = " AND ";
        /// <summary>
        /// ＳＱＬ　ｏｒ
        /// </summary>
        public const string SQL_OR = " OR ";

        /// <summary>
        /// SQL相似
        /// </summary>
        public const string SQL_LIKE = " LIKE '%{0}%' ";

        /// <summary>
        /// 删除指定表指定字段值的数据
        /// </summary>
        public const string SQL_DELETE_DATA = "DELETE FROM {0} WHERE {1}='{2}' ";

        /// <summary>
        /// 提取指定表指定字段的数据
        /// </summary>
        public const string SQL_GET_VALUE = "SELECT {0} FROM {1} WHERE {2}='{3}' ";

        /// <summary>
        /// 根据条件提取表
        /// </summary>
        public const string SQL_GET_TABLE = "SELECT * FROM {0} WHERE {1}='{2}' ";

        /// <summary>
        /// 更新数据
        /// </summary>
        public const string SQL_UPDATE_DATA = "UPDATE {0} SET {1}='{2}' WHERE {3}='{4}' ";

        ///// <summary>
        ///// 提取文章
        ///// </summary>
        //public const string SQL_GET_ARTICLE = @"SELECT TOP {0} * FROM ArticleD WHERE TypeD='{1}' AND StatusD=1 ORDER BY ReleaseTimeD DESC,IsTopD DESC,SortD ASC,ClickNumD DESC,UpdateTimeD DESC";

        ///// <summary>
        ///// 提取图文
        ///// </summary>
        //public const string SQL_GET_PIC_ARTICLE = @"SELECT TOP {0} * FROM ArticleD WHERE TypeD='{1}' AND StatusD=1 And PicD<>'~/UpImages/Pic/Pic.jpg' ORDER BY ReleaseTimeD DESC,IsTopD DESC,SortD ASC,ClickNumD DESC,UpdateTimeD DESC";

        ///// <summary>
        ///// 根据父类提取商品分类
        ///// </summary>
        //public const string SQL_GET_GOODSTYPE = @"SELECT TOP {0} * FROM GoodsTypeD WHERE ParentD='{1}' AND StatusD=1 ORDER BY SortD ASC,UpdateTimeD DESC";

        ///// <summary>
        ///// 根据大类提取商品
        ///// </summary>
        //public const string SQL_GET_BGOODS = @"SELECT TOP {0} * FROM GoodsD WHERE  StatusD=1 AND BigTypeD='{1}' ORDER BY ReleaseTimeD DESC,IsTopD DESC,UpdateTimeD DESC,ClickNumD DESC";

        /// <summary>
        /// SQL链接字符串  sa口令登陆
        /// </summary>
        public const string SQL_CONN_STR_PWD="Data Source=BOSS007\\SA_2005;Initial Catalog=stu;Persist Security Info=True;User ID=sa;pwd=123456";

        /// <summary>
        /// SQL链接字符串  Windows身份验证
        /// </summary>
        public const string SQL_CONN_STR = "Data Source=boss007\\SA_2005;Initial Catalog=stu;Integrated Security=True";
        #endregion

        #region 页面转换

        /// <summary>
        /// 网址
        /// </summary>
        public const string STRING_URL = "http://{0}{1}?{2}";

        /// <summary>
        /// HOST
        /// </summary>
        public const string STRING_HOST = "HTTP_HOST";

        /// <summary>
        /// PATH_INFO
        /// </summary>
        public const string STRING_PATH_INFO = "PATH_INFO";

        /// <summary>
        /// QUERY_STRING
        /// </summary>
        public const string STRING_QUERY_STRING = "QUERY_STRING";

        /// <summary>
        /// ASPX
        /// </summary>
        public const string STRING_ASPX = ".aspx";

        /// <summary>
        /// ASPX
        /// </summary>
        public const string STRING_ASPX0 = "{0}.aspx";

        /// <summary>
        /// ASPX
        /// </summary>
        public const string STRING_ASPX01 = "{0}.aspx?{1}";

        /// <summary>
        /// HTML
        /// </summary>
        public const string STRING_HTML = ".html";

        /// <summary>
        /// HTML
        /// </summary>
        public const string STRING_HTML0 = "{0}.html";

        /// <summary>
        /// HTML
        /// </summary>
        public const string STRING_HTML01 = "{0}___{1}.html";

        #endregion

        #region 防HTML注入

        /// <summary>
        /// 防止注入
        /// </summary>
        public const string STRING_SCRIPT = @"<script[\s\S]+</script *>";

        /// <summary>
        /// 防止注入
        /// </summary>
        public const string STRING_HREFSCRIPT = @" href *= *[\s\S]*script *:";

        /// <summary>
        /// 防止注入
        /// </summary>
        public const string HTML_EVEN = @" on[\s\S]*=";

        /// <summary>
        /// 防止注入
        /// </summary>
        public const string STRING_IFRAME = @"<iframe[\s\S]+</iframe *>";

        /// <summary>
        /// 防止注入
        /// </summary>
        public const string HTML_IFRAMESET = @"<frameset[\s\S]+</frameset *>";

        /// <summary>
        /// 防止注入
        /// </summary>
        public const string HTML_EVEN_R = " _disibledevent=";

        #endregion

        #region 字符串

        /// <summary>
        /// 提示
        /// </summary>
        public const string ALERT = "提示";

        /// <summary>
        /// 升序
        /// </summary>
        public const string ASC = "ASC";

        /// <summary>
        /// 降序
        /// </summary>
        public const string DESC = "DESC";

        /// <summary>
        /// 提取NHI配置用
        /// </summary>
        public const string PROPERTY = "property";

        /// <summary>
        /// 小文件名
        /// </summary>
        public const string MIN = "Min";

        /// <summary>
        /// 字符串
        /// </summary>
        public const string CHAR = "2,3,4,5,6,7,8,9,a,b,c,d,e,f,g,h,i,j,k,m,n,o,p,q,r,s,t,u,v,w,x,y,z,A,B,C,D,E,F,G,H,I,J,K,L,M,N,P,Q,R,S,T,U,V,W,X,Y,Z";

        /// <summary>
        /// 数字
        /// </summary>
        public const string NUM = "0,1,2,3,4,5,6,7,8,9";

        /// <summary>
        /// 汉字码
        /// </summary>
        public const string CN = "0,1,2,3,4,5,6,7,8,9,a,b,c,d,e,f";

        /// <summary>
        /// 汉字编码
        /// </summary>
        public const string GBK = "gb2312";

        /// <summary>
        /// 验证码
        /// </summary>
        public const string VAL_CODE = "ValCode";

        /// <summary>
        /// 字体
        /// </summary>
        public const string FONT_ARIAL = "Arial";

        /// <summary>
        /// 图像类型
        /// </summary>
        public const string IMAGE_GIF = "image/Gif";

        /// <summary>
        /// 图像类型
        /// </summary>
        public const string IMAGE_JPG = "image/jpeg";

        /// <summary>
        /// 文件
        /// </summary>
        public const string FILE_INFO = "file_info";

        /// <summary>
        /// 图像类型是否存在
        /// </summary>
        public const string IMAGE_TYPE_LIST = ".gif.jpg.bmp.png";

        /// <summary>
        /// 日期格式
        /// </summary>
        public const string DATE = "yyyy年MM月dd日";

        /// <summary>
        /// 日期格式分钟
        /// </summary>
        public const string DATE_TIME_MINUTE = "yyyy/MM/dd HH:mm";

        /// <summary>
        /// 排序字段
        /// </summary>
        public const string SORT_EXPRESSION = "SortExpression";

        /// <summary>
        /// 排序方向
        /// </summary>
        public const string SORT_DIRECTION = "SortDirection";

        /// <summary>
        /// 文件
        /// </summary>
        public const string FILEDATA = "Filedata";

        /// <summary>
        /// Id
        /// </summary>
        public const string ID = "Id";

        /// <summary>
        /// 是否有权限
        /// </summary>
        public const string HAVE_POWER = "HavePower";

        /// <summary>
        /// 版权信息
        /// </summary>
        public const string LOGO_INFO = "版权：天津商业大学&高职学院 by:HUCSD";
        /// <summary>
        /// 系统名称
        /// </summary>
        public const string LOGO = "学生信息管理系统";

        /// <summary>
        /// 首页显示问候信息格式
        /// </summary>
        public const string LOGO_SHOW = "：【{0}】&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;今天是：{1}&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;欢迎登陆本系统！";

        /// <summary>
        /// 作者网站
        /// </summary>
        public const string Author = "http://user.qzone.qq.com/234486036/main";
       
        #endregion

        #region 表格绑定

        /// <summary>
        /// 新增
        /// </summary>
        public const string ADD_TITLE = "新增";

        /// <summary>
        /// 编辑
        /// </summary>
        public const string EDIT_TITLE = "编辑";

        /// <summary>
        /// 编辑
        /// </summary>
        public const string EDIT = "Edit";

        /// <summary>
        /// 添加
        /// </summary>
        public const string ADD = "Add";

        /// <summary>
        /// 删除
        /// </summary>
        public const string DELETE = "Delete";

        /// <summary>
        /// 编辑
        /// </summary>
        public const string LBF_EDIT = "lbf_Edit";

        /// <summary>
        /// 删除
        /// </summary>
        public const string LBF_DELETE = "lbf_Delete";

        /// <summary>
        /// 置顶
        /// </summary>
        public const string CB_ISTOP = "cb_IsTopD";

        /// <summary>
        /// 状态
        /// </summary>
        public const string CB_STATUSD = "cb_StatusD";

        /// <summary>
        /// 编辑地址
        /// </summary>
        public const string LBF_EDIT_URL = "Edit.aspx?IsReturn=1&Id=";

        /// <summary>
        /// 是否返回
        /// </summary>
        public const string IS_RETURN = "IsReturn";

        /// <summary>
        /// 是否更新
        /// </summary>
        public const string IS_UPDATE = "IsUpdate";

        /// <summary>
        /// 主类
        /// </summary>
        public const string MAIN_TYPE = "主类";

        /// <summary>
        /// 全部
        /// </summary>
        public const string MAIN_ALL = "全部";

        #endregion

        #region 导出表格

        public const string CONTENT_DIS = "content-disposition";

        public const string EXCLE_NAME = "attachment; filename=T_{0}.xls";

        public const string EXCLE_MINI = "application/excel";

        public const string TABLE_TOP = "<table cellspacing=\"0\" rules=\"all\" border=\"1\" style=\"border-collapse:collapse;\"><tr>";

        public const string TABLE_TD = "<td>{0}</td>";

        public const string TABLE_TR_END = "</tr>";

        public const string TABLE_TR_TOP = "<tr>";

        public const string TABLE_END = "</table>";

        public const string CHECKBOK_CHECK = "box-grid-static-checkbox";

        public const string CHECKBOK_UNCHECK = "box-grid-static-checkbox-uncheck";

        #endregion

        #region 脚本

        public const string SCRIPT_RELOAD = "location.href=location.href;";

        #endregion

        #region 配置索引

        /// <summary>
        /// 网站开关
        /// </summary>
        public const string SideSwitch = "SideSwitch";

        /// <summary>
        /// 静态开关
        /// </summary>
        public const string StaticSwitch = "StaticSwitch";

        /// <summary>
        /// 网站地址
        /// </summary>
        public const string SideUrl = "SideUrl";

        /// <summary>
        /// 网站标题
        /// </summary>
        public const string SideName = "SideName";

        /// <summary>
        /// 网站关键字
        /// </summary>
        public const string KeyWords = "KeyWords";

        /// <summary>
        /// 网站描述
        /// </summary>
        public const string Description = "Description";

        /// <summary>
        /// 版权
        /// </summary>
        public const string Copyright = "Copyright";

        /// <summary>
        /// 注册协议
        /// </summary>
        public const string RegistrationAgreement = "RegistrationAgreement";

        /// <summary>
        /// 支付宝账号
        /// </summary>
        public const string PayTreasureAccount = "PayTreasureAccount";

        /// <summary>
        /// 合作者省份证ID
        /// </summary>
        public const string PartnersIdentity = "PartnersIdentity";

        /// <summary>
        /// 安全效验码
        /// </summary>
        public const string SafetyCheckCode = "SafetyCheckCode";

        #endregion

        #region 数字

        public const string NUM_0 = "0";

        public const string NUM_1 = "1";

        #endregion

        #region ICON

        public const string ICON_PACKAGE = "~/Management/Icons/package.png";

        public const string ICON_FOLDER = "~/Management/Icons/folder.png";

        public const string ICON_USER = "~/Management/Icons/user.png";

        public const string ICON_IMAGE_EDIT = "~/Management/Icons/image_edit.png";

        public const string ICON_PALETTE = "~/Management/Icons/palette.png";

        public const string ICON_PAGE = "~/Management/Icons/images.png";

        public const string ICON_LINK = "~/Management/Icons/link.png";

        public const string ICON_CART_FULL = "~/Management/Icons/cart_full.png";

        public const string ICON_SHIELD = "~/Management/Icons/shield.png";

        public const string ICON_USER_SUIT_BLACK = "~/Management/Icons/user_suit_black.png";

        #endregion

        #region 地址

        /// <summary>
        /// 登陆地址
        /// </summary>
        public const string PAGE_LOGIN = "~/page/Login.aspx";

        /// <summary>
        /// 录入地址
        /// </summary>
        public const string PAGE_M = "~/page/Main.aspx";
        /// <summary>
        /// 启动页面
        /// </summary>
        public const string PAGE_DEFAULT = "Default.aspx";

        #endregion


    }
}