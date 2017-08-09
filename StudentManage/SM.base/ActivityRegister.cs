
/* **********************************************************************
 *                   类【ActivityRegister.cs】信息
 *                    
 * 所属项目：SM.Base       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：ActivityRegister
 * 功    能：活动记录
 * 来    历：HUCSD 创建于 2013-08-12 16:37:57 
 * 
 * **********************************************************************/


namespace SM.Base
{
    /// <summary>
    /// 活动记录类
    /// </summary>
    public class ActivityRegister
    {
        private string activityId = "";
        /// <summary>
        /// 活动编号
        /// </summary>
        public string ActivityId
        {
            set { activityId = value; }
            get { return activityId; }
        }
        private string activityTheme = "";
        /// <summary>
        /// 活动主题
        /// </summary>
        public string ActivityTheme
        {
            set { activityTheme = value; }
            get { return activityTheme; }
        }
        private string activityTime = "";
        /// <summary>
        /// 活动时间
        /// </summary>
        public string ActivityTime
        {
            set { activityTime = value; }
            get { return activityTime; }
        }
        private string activityIntroduction = "";
        /// <summary>
        /// 活动介绍
        /// </summary>
        public string ActivityIntroduction
        {
            set { activityIntroduction = value; }
            get { return activityIntroduction; }
        }
        private string activityDirector = "";
        /// <summary>
        /// 活动负责人
        /// </summary>
        public string ActivityDirector
        {
            set { activityDirector = value; }
            get { return activityDirector; }
        }
        private string activityParticipant = "";
        /// <summary>
        /// 活动参与人
        /// </summary>
        public string ActivityParticipant
        {
            set { activityParticipant = value; }
            get { return activityParticipant; }
        }
    }
}
