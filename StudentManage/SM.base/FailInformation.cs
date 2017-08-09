
/* **********************************************************************
 *                   类【FailInformation.cs】信息
 *                    
 * 所属项目：SM.Base       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：FailInformation
 * 功    能：挂科信息
 * 来    历：HUCSD 创建于 2013-08-12 16:15:47 
 * 
 * **********************************************************************/

namespace SM.Base
{
    /// <summary>
    /// 挂科信息类
    /// </summary>
    class FailInformation : Student
    {
        private string courseTitle = "";
        /// <summary>
        /// 科目名称
        /// </summary>
        public string CourseTitle
        {
            set { courseTitle = value; }
            get { return courseTitle; }
        }
        private float newGrade = -1;
        /// <summary>
        /// 补考成绩
        /// </summary>
        public float NewGrade
        {
            set { newGrade = value; }
            get { return newGrade; }
        }
        private float oldGrade = -1;
        /// <summary>
        /// 原成绩
        /// </summary>
        public float OldGrade
        {
            set { oldGrade = value; }
            get { return oldGrade; }
        }
    }
}
