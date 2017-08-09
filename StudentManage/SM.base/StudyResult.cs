
/* **********************************************************************
 *                   类【StudyResult.cs】信息
 *                    
 * 所属项目：SM.Base       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：StudyResult
 * 功    能：学习成绩
 * 来    历：HUCSD 创建于 2013-08-12 11:28:22 
 * 
 * **********************************************************************/
using System;

namespace SM.Base
{
    /// <summary>
    /// 每一个学期综合成绩类
    /// </summary>
    public class StudyResult : Student
    {
        private Boolean isFail = false;
        /// <summary>
        /// 是否挂科
        /// </summary>
        public Boolean IsFail
        {
            set { isFail = value; }
            get { return isFail; }
        }
        private float semesterOneTotalGrade = -1;
        /// <summary>
        /// 第一个学期综合成绩
        /// </summary>
        public float SemesterOneTotalGrade
        {
            set { semesterOneTotalGrade = value; }
            get { return semesterOneTotalGrade; }
        }
        private float semesterWwoTotalGrade = -1;
        /// <summary>
        /// 第二个学期综合成绩
        /// </summary>
        public float SemesterWwoTotalGrade
        {
            set { semesterWwoTotalGrade = value; }
            get { return semesterWwoTotalGrade; }
        }
        private float semesterThreeTotalGrade = -1;
        /// <summary>
        /// 第三个学期综合成绩
        /// </summary>
        public float SemesterThreeTotalGrade
        {
            set { semesterThreeTotalGrade = value; }
            get { return semesterThreeTotalGrade; }
        }
        private float semesterFourTotalGrade = -1;
        /// <summary>
        /// 第四个学期综合成绩
        /// </summary>
        public float SemesterFourTotalGrade
        {
            set { semesterFourTotalGrade = value; }
            get { return semesterFourTotalGrade; }
        }
        private float semesterFiveTotalGrade = -1;
        /// <summary>
        /// 第五个学期综合成绩
        /// </summary>
        public float SemesterFiveTotalGrade
        {
            set { semesterFiveTotalGrade = value; }
            get { return semesterFiveTotalGrade; }
        }
        private float semesterSixTotalGrade = -1;
        /// <summary>
        /// 第六个学期综合成绩
        /// </summary>
        public float SemesterSixTotalGrade
        {
            set { semesterSixTotalGrade = value; }
            get { return semesterSixTotalGrade; }
        }
        private float semesterSevenTotalGrade = -1;
        /// <summary>
        /// 第七个学期综合成绩
        /// </summary>
        public float SemesterSevenTotalGrade
        {
            set { semesterSevenTotalGrade = value; }
            get { return semesterSevenTotalGrade; }
        }
        private float semesterEightTotalGrade = -1;
        /// <summary>
        /// 第八个学期综合成绩
        /// </summary>
        public float SemesterEightTotalGrade
        {
            set { semesterEightTotalGrade = value; }
            get { return semesterEightTotalGrade; }
        }
    }
}
