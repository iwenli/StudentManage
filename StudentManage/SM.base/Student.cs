
/* **********************************************************************
 *                   类【Student.cs】信息
 *                    
 * 所属项目：SM.Base       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：Student
 * 功    能：学生
 * 来    历：HUCSD 创建于 2013-08-12 10:53:13 
 * 
 * **********************************************************************/

namespace SM.Base
{
    /// <summary>
    /// 学生
    /// </summary>
    public class Student
    {
        private string studentId = "";
        /// <summary>
        /// 学生学号
        /// </summary>
        public string StudentID
        {
            set { studentId = value; }
            get { return studentId; }
        }
    }
}
