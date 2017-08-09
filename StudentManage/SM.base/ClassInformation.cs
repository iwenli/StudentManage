
/* **********************************************************************
 *                   类【ClassInformation.cs】信息
 *                    
 * 所属项目：SM.Base       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：ClassInformation
 * 功    能： 班级信息
 * 来    历：HUCSD 创建于 2013-08-12 11:02:46 
 * 
 * **********************************************************************/

namespace SM.Base
{
    /// <summary>
    /// 班级信息类
    /// </summary>
    public class ClassInformation
    {
        /// <summary>
        /// 所属专业
        /// </summary>
        public SpecialtyInformation spe = new SpecialtyInformation();
        private string classId = "";
        /// <summary>
        /// 班级编号
        /// </summary>
        public string ClassID
        {
            set { classId = value; }
            get { return classId; }
        }
        private string className = "";
        /// <summary>
        /// 班级名称
        /// </summary>
        public string ClassName
        {
            set { className = value; }
            get { return className; }
        }
        private string headTeacher = "";
        /// <summary>
        /// 班主任
        /// </summary>
        public string HeadTeacher
        {
            set { headTeacher = value; }
            get { return headTeacher; }
        }
        private string teacherTel = "";
        /// <summary>
        /// 班主任电话
        /// </summary>
        public string TeacherTel
        {
            set { teacherTel = value; }
            get { return teacherTel; }
        }
        private string monitor = "";
        /// <summary>
        /// 班长
        /// </summary>
        public string Monitor
        {
            set { monitor = value; }
            get { return monitor; }
        }
        private string studySecretary = "";
        /// <summary>
        /// 学习委员
        /// </summary>
        public string StudySecretary
        {
            set { studySecretary = value; }
            get { return studySecretary; }
        }
        private string lifeSecretary = "";
        /// <summary>
        /// 生活委员
        /// </summary>
        public string LifeSecretary
        {
            set { lifeSecretary = value; }
            get { return lifeSecretary; }
        }
        private string leagueSecretary = "";
        /// <summary>
        /// 团支书
        /// </summary>
        public string LeagueSecretary
        {
            set { leagueSecretary = value; }
            get { return leagueSecretary; }
        }
        private string organizationCommissary = "";
        /// <summary>
        /// 组织委员
        /// </summary>
        public string OrganizationCommissary
        {
            set { organizationCommissary = value; }
            get { return organizationCommissary; }
        }
        private string publicityEcretary = "";
        /// <summary>
        /// 宣传委员
        /// </summary>
        public string PublicityEcretary
        {
            set { publicityEcretary = value; }
            get { return publicityEcretary; }
        }
        private string styleMembers = "";
        /// <summary>
        /// 文体委员
        /// </summary>
        public string StyleMembers
        {
            set { styleMembers = value; }
            get { return styleMembers; }
        }
    }
}
