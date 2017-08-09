
/* **********************************************************************
 *                   类【SpecialtyInformation.cs】信息
 *                    
 * 所属项目：SM.Base       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：SpecialtyInformation
 * 功    能：专业信息
 * 来    历：HUCSD 创建于 2013-08-12 11:15:39 
 * 
 * **********************************************************************/

namespace SM.Base
{
    /// <summary>
    /// 专业信息类
    /// </summary>
    public class SpecialtyInformation
    {
        /// <summary>
        /// 所属院系
        /// </summary>
        public DepartmentInformation dep = new DepartmentInformation();
        private string specialtyId = "";
        /// <summary>
        /// 专业编号
        /// </summary>
        public string SpecialtyId
        {
            set { specialtyId = value; }
            get { return specialtyId; }
        }
        private string specialtyName = "";
        /// <summary>
        /// 专业名称
        /// </summary>
        public string SpecialtyName
        {
            set { specialtyName = value; }
            get { return specialtyName; }
        }
    }
}
