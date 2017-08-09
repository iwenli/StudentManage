
/* **********************************************************************
 *                   类【StudentBasicInfo.cs】信息
 *                    
 * 所属项目：SM.Base       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：StudentBasicInfo
 * 功    能：学生基本信息 
 * 来    历：HUCSD 创建于 2013-08-11 13:09:16 
 * 
 * **********************************************************************/
using System;
using System.Data.SqlClient;
using SM.BaseControls;

namespace SM.Base
{
    /// <summary>
    /// 学生基本信息类  
    /// <br>版    权：HUCSD @Copy Right 2008+   </br>
    /// <br>联系ＱＱ：234486036</br>
    /// </summary>
    public class StudentBasicInfo : Student
    {
        public StudentBasicInfo()
        {

        }

        public StudentBasicInfo(string sId)
        {
            StudentID = sId;
        }


        #region 属性
        private string examineeId = "";
        /// <summary>
        /// 考生号
        /// </summary>
        public string ExamineeID
        {
            set { examineeId = value; }
            get { return examineeId; }
        }
        private string lastSchool = "";
        /// <summary>
        /// 入学前学校
        /// </summary>
        public string LastSchool 
        {
            set { lastSchool = value; }
            get { return lastSchool; }
        }
        private string name = "";
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        private string sex = "";
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            set { sex = value; }
            get { return sex; }
        }
        private string identification = "";
        /// <summary>
        /// 身份证号
        /// </summary>
        public string Identification
        {
            set { identification = value; }
            get { return identification; }
        }
        private DateTime birthdate;
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Birthdate
        {
            set { birthdate = value; }
            get { return birthdate; }
        }
        private string nation = "";
        /// <summary>
        /// 名族
        /// </summary>
        public string Nation
        {
            set { nation = value; }
            get { return nation; }
        }
        private string origin = "";
        /// <summary>
        /// 籍贯
        /// </summary>
        public string Origin
        {
            set { origin = value; }
            get { return origin; }
        }
        private string politicsStatus = "";
        /// <summary>
        /// 政治面貌
        /// </summary>
        public string PoliticsStatus
        {
            set { politicsStatus = value; }
            get { return politicsStatus; }
        }
        private string domicilePlace = "";
        /// <summary>
        /// 现户籍所在地
        /// </summary>
        public string DomicilePlace
        {
            set { domicilePlace = value; }
            get { return domicilePlace; }
        }
        private string domicileType = "";
        /// <summary>
        /// 户籍类型
        /// </summary>
        public string DomicileType
        {
            set { domicileType = value; }
            get { return domicileType; }
        }
        private string entranceYear = "";
        /// <summary>
        /// 入学年份
        /// </summary>
        public string EntranceYear
        {
            set { entranceYear = value; }
            get { return entranceYear; }
        }
        private string schoolSystem = "";
        /// <summary>
        /// 学制
        /// </summary>
        public string SchoolSystem
        {
            set { schoolSystem = value; }
            get { return schoolSystem; }
        }
        private string departmentId = "";
        /// <summary>
        /// 院系
        /// </summary>
        public string DepartmentId
        {
            set { departmentId = value; }
            get { return departmentId; }
        }
        private string specialtyId = "";
        /// <summary>
        /// 专业
        /// </summary>
        public string SpecialtyId
        {
            set { specialtyId = value; }
            get { return specialtyId; }
        }
        private string classId = "";
        /// <summary>
        /// 班级
        /// </summary>
        public string ClassId
        {
            set { classId = value; }
            get { return classId; }
        }
        private string apartment = "";
        /// <summary>
        /// 公寓
        /// </summary>
        public string Apartment
        {
            set { apartment = value; }
            get { return apartment; }
        }
        private string tel = "";
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Tel
        {
            set { tel = value; }
            get { return tel; }
        }
        private string healthCondition = "";
        /// <summary>
        /// 健康状况
        /// </summary>
        public string HealthCondition
        {
            set { healthCondition = value; }
            get { return healthCondition; }
        }
        private string speciality = "";
        /// <summary>
        /// 特长
        /// </summary>
        public string Speciality
        {
            set { speciality = value; }
            get { return speciality; }
        }
        private string foreignLanguageLevel = "";
        /// <summary>
        /// 外语水平
        /// </summary>
        public string ForeignLanguageLevel
        {
            set { foreignLanguageLevel = value; }
            get { return foreignLanguageLevel; }
        }
        private string computerSkills = "";
        /// <summary>
        /// 计算机水平
        /// </summary>
        public string ComputerSkills
        {
            set { computerSkills = value; }
            get { return computerSkills; }
        }
        private string headPortrait = "";
        /// <summary>
        /// 头像
        /// </summary>
        public string HeadPortrait
        {
            set { headPortrait = value; }
            get { return headPortrait; }
        }
        private string homeCondition = "";
        /// <summary>
        /// 家庭条件
        /// </summary>
        public string HomeCondition
        {
            set { homeCondition = value; }
            get { return homeCondition; }
        }
        #endregion


        /// <summary>
        /// 根据学号初始化学生基本信息
        /// </summary>
        /// <param name="_stuBaseInfo">对象</param>
        /// <param name="sId">学号</param>
        public static void getStudentBaseInfo(out StudentBasicInfo _stuBaseInfo,string sId)
        {
            _stuBaseInfo = new StudentBasicInfo(sId);
            string _sql = String.Format(SString.SQL_GET_TABLE, SColumn.BASIC_INFO, SColumn.STUDENT_ID, sId);
            SqlDataReader sdr = SQLCommand.ExecuteSelectSqlReader(_sql);
            sdr.Read();
            if (sdr.HasRows)
            {
                _stuBaseInfo.ExamineeID = sdr[SColumn.BASIC_INFO_EXAM_ID].ToString();
                _stuBaseInfo.LastSchool = sdr[SColumn.BASIC_INFO_LAST_SCHOOL].ToString();
                _stuBaseInfo.Name = sdr[SColumn.STUDENT_NAME].ToString();
                _stuBaseInfo.Sex = sdr[SColumn.BASIC_INFO_SEX].ToString();
                _stuBaseInfo.Identification = sdr[SColumn.STUDENT_ID_DATE].ToString();
                _stuBaseInfo.Birthdate = sdr[SColumn.BASIC_INFO_BIRTH].ToDateTime();
                _stuBaseInfo.Nation = sdr[SColumn.BASIC_INFO_NATION].ToString();
                _stuBaseInfo.Origin = sdr[SColumn.BASIC_INFO_ORIGIN].ToString();
                _stuBaseInfo.PoliticsStatus = sdr[SColumn.BASIC_INFO_POLITICS_STATUS].ToString();
                _stuBaseInfo.DomicilePlace = sdr[SColumn.BASIC_INFO_DOMICILE_PLACE].ToString();
                _stuBaseInfo.DomicileType = sdr[SColumn.BASIC_INFO_DOMICILE_TYPE].ToString();
                _stuBaseInfo.EntranceYear = sdr[SColumn.BASIC_INFO_ENTRANCE_YEAR].ToString();
                _stuBaseInfo.SchoolSystem = sdr[SColumn.BASIC_INFO_SCHOOL_SYSTEM].ToString();
                _stuBaseInfo.DepartmentId = sdr[SColumn.BASIC_INFO_DEPARTMENT].ToString();
                _stuBaseInfo.SpecialtyId = sdr[SColumn.BASIC_INFO_SPECIALTY].ToString();
                _stuBaseInfo.ClassId = sdr[SColumn.BASIC_INFO_CLASS].ToString();
                _stuBaseInfo.Apartment = sdr[SColumn.BASIC_INFO_APARTMENT].ToString();
                _stuBaseInfo.Tel = sdr[SColumn.BASIC_INFO_TEL].ToString();
                _stuBaseInfo.HealthCondition = sdr[SColumn.BASIC_INFO_HEALTH_CONDITION].ToString();
                _stuBaseInfo.Speciality = sdr[SColumn.BASIC_INFO_SPECIALITY].ToString();
                _stuBaseInfo.ForeignLanguageLevel = sdr[SColumn.BASIC_INFO_FOREIGN_LANG_LEVEL].ToString();
                _stuBaseInfo.ComputerSkills = sdr[SColumn.BASIC_INFO_COMPUTER_SKILLS].ToString();
                _stuBaseInfo.HeadPortrait = sdr[SColumn.BASIC_INFO_HEAD_PORTRAIT].ToString();
                _stuBaseInfo.HomeCondition = sdr[SColumn.BASIC_INFO_HOME_CONDITION].ToString();
            }
            else
            {
                JSUtility.Alert("数据加载出错，请尝试刷新页面");
                //write log
            }
            sdr.Close();
        }
    }
}
