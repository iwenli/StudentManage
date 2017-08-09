

/* **********************************************************************
 *                   类【SQLCommand.cs】信息
 *                    
 * 所属项目：SM.Control       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：SQLCommand
 * 功    能：常量类之列名常量
 * 来    历：HUCSD 创建于 2013-08-12 16:54:43 
 * 
 * **********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BaseControls
{
    /// <summary>
    /// 列名常量类
    /// </summary>
    public static class SColumn
    {
        #region 学生登陆表 student_login
        /// <summary>
        /// 学生登陆
        /// </summary>
        public const string U_LOGIN = "student_login";
        /// <summary>
        /// 用户名
        /// </summary>
        public const string U_NAME = "account";
        /// <summary>
        /// 密码
        /// </summary>
        public const string U_PASSWD = "pass_word";
        #endregion

        #region 管理登陆表 manage_login
        /// <summary>
        /// 管理登陆表
        /// </summary>
        public const string M_LOGIN = "manage_login";
        /// <summary>
        /// 用户名
        /// </summary>
        public const string M_NAME = "account";
        /// <summary>
        /// 密码
        /// </summary>
        public const string M_PASSWD = "pass_word";
        /// <summary>
        /// 权限
        /// </summary>
        public const string M_ROLE = "role";
        /// <summary>
        /// 所属班级
        /// </summary>
        public const string M_CLASS = "belong_class";
        #endregion

        #region 学生基本信息表 basic_information
        /// <summary>
        /// 基本信息表
        /// </summary>
        public const string BASIC_INFO = "basic_information";
        /// <summary>
        /// 学号 student_id
        /// </summary>
        public const string STUDENT_ID = "student_id";
        /// <summary>
        /// 姓名 name
        /// </summary>
        public const string STUDENT_NAME = "name";
        /// <summary>
        /// 身份证号 identification
        /// </summary>
        public const string STUDENT_ID_DATE = "identification";
        /// <summary>
        /// 考生号 examinee_id
        /// </summary>
        public const string BASIC_INFO_EXAM_ID = "examinee_id";
        /// <summary>
        ///  入学前学校 last_school
        /// </summary>
        public const string BASIC_INFO_LAST_SCHOOL = "last_school";
        /// <summary>
        ///  性别 sex
        /// </summary>
        public const string BASIC_INFO_SEX = "sex";
        /// <summary>
        /// 出生年月 birthdate
        /// </summary>
        public const string BASIC_INFO_BIRTH = "birthdate";
        /// <summary>
        /// 名族 nation
        /// </summary>
        public const string BASIC_INFO_NATION = "nation";
        /// <summary>
        /// 籍贯 origin
        /// </summary>
        public const string BASIC_INFO_ORIGIN = "origin";
        /// <summary>
        /// 政治面貌 politics_status
        /// </summary>
        public const string BASIC_INFO_POLITICS_STATUS = "politics_status";
        /// <summary>
        /// 现户籍所在地  domicile_place
        /// </summary>
        public const string BASIC_INFO_DOMICILE_PLACE = "domicile_place";
        /// <summary>
        /// 户籍类型 domicile_type
        /// </summary>
        public const string BASIC_INFO_DOMICILE_TYPE = "domicile_type";
        /// <summary>
        /// 入学年份 entrance_year
        /// </summary>
        public const string BASIC_INFO_ENTRANCE_YEAR = "entrance_year";
        /// <summary>
        /// 学制 school_system
        /// </summary>
        public const string BASIC_INFO_SCHOOL_SYSTEM = "school_system";
        /// <summary>
        /// 院系 department_id
        /// </summary>
        public const string BASIC_INFO_DEPARTMENT = "department_id";
        /// <summary>
        /// 专业 specialty_id
        /// </summary>
        public const string BASIC_INFO_SPECIALTY = "specialty_id";
        /// <summary>
        /// 班级 class_id
        /// </summary>
        public const string BASIC_INFO_CLASS = "class_id";
        /// <summary>
        /// 公寓 apartment
        /// </summary>
        public const string BASIC_INFO_APARTMENT = "apartment";
        /// <summary>
        /// 联系电话 tel
        /// </summary>
        public const string BASIC_INFO_TEL = "tel";
        /// <summary>
        /// 健康状况 health_condition
        /// </summary>
        public const string BASIC_INFO_HEALTH_CONDITION = "health_condition";
        /// <summary>
        /// 特长 speciality
        /// </summary>
        public const string BASIC_INFO_SPECIALITY = "speciality";
        /// <summary>
        /// 外语水平 foreign_language_level
        /// </summary>
        public const string BASIC_INFO_FOREIGN_LANG_LEVEL = "foreign_language_level";
        /// <summary>
        /// 计算机水平 computer_skills
        /// </summary>
        public const string BASIC_INFO_COMPUTER_SKILLS = "computer_skills";
        /// <summary>
        /// 头像 head_portrait
        /// </summary>
        public const string BASIC_INFO_HEAD_PORTRAIT = "head_portrait";
        /// <summary>
        /// 家庭条件 home_condition
        /// </summary>
        public const string BASIC_INFO_HOME_CONDITION = "home_condition";
        
       
        #endregion



    }
}