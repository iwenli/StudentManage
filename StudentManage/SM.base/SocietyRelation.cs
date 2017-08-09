
/* **********************************************************************
 *                   类【SocietyRelation.cs】信息
 *                    
 * 所属项目：SM.base       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：SocietyRelation
 * 功    能：社会关系
 * 来    历：HUCSD 创建于 2013-08-12 09:52:09 
 * 
 * **********************************************************************/

namespace SM.Base
{
    /// <summary>
    /// 社会关系类
    /// 版    权：HUCSD @Copy Right 2008+
    /// 联系ＱＱ：234486036
    /// </summary>
    public class SocietyRelation : Student
	{
        private string relation = "";
        /// <summary>
        /// 关系   
        /// 父子  母子  父女  母女  姊妹   兄弟  兄妹
        /// </summary>
        public string Relation
        {
            set { relation = value; }
            get { return relation; }
        }
        private string name = "";
        /// <summary>
        /// 关系人姓名
        /// </summary>
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        private string sex = "";
        /// <summary>
        /// 关系人性别
        /// </summary>
        public string Sex
        {
            set { sex = value; }
            get { return sex; }
        }
        private string tel = "";
        /// <summary>
        /// 关系人联系电话
        /// </summary>
        public string Tel
        {
            set { tel = value; }
            get { return tel; }
        }
        private string workUnit = "";
        /// <summary>
        /// 关系人工作单位
        /// </summary>
        public string WorkUnit
        {
            set { workUnit = value; }
            get { return workUnit; }
        }
        private string presentAddress = "";
        /// <summary>
        /// 关系人现住址
        /// </summary>
        public string PresentAddress
        {
            set { presentAddress = value; }
            get { return presentAddress; }
        }
	}
}
