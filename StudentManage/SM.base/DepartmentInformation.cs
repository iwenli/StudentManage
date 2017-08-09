
/* **********************************************************************
 *                   类【DepartmentInformation.cs】信息
 *                    
 * 所属项目：SM.Base       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：DepartmentInformation
 * 功    能： 院系信息
 * 来    历：HUCSD 创建于 2013-08-12 11:05:47 
 * 
 * **********************************************************************/

namespace SM.Base
{
    /// <summary>
    /// 院系信息类
    /// </summary>
    public class DepartmentInformation
    {
        private string depId = "";
        /// <summary>
        /// 院系编号
        /// </summary>
        public string DepID
        {
            set { depId = value; }
            get { return depId; }
        }
        private string depName = "";
        /// <summary>
        /// 院系名称
        /// </summary>
        public string DepName
        {
            set { depName = value; }
            get { return depName; }
        }
        private string depDirector = "";
        /// <summary>
        /// 院系负责人
        /// </summary>
        public string DepDirector
        {
            set { depDirector = value; }
            get { return depDirector; }
        }
        private string dirTel = "";
        /// <summary>
        /// 负责人联系方式
        /// </summary>
        public string DirTel
        {
            set { dirTel = value; }
            get { return dirTel; }
        }
    }
}
