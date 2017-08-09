
/* **********************************************************************
 *                   类【PartyInfomation.cs】信息
 *                    
 * 所属项目：SM.Base       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：PartyInfomation
 * 功    能：党团信息
 * 来    历：HUCSD 创建于 2013-08-12 10:20:04 
 * 
 * **********************************************************************/

namespace SM.Base
{
    /// <summary>
    /// 党团信息类
    /// 版    权：HUCSD @Copy Right 2008+
    /// 联系ＱＱ：234486036
    /// </summary>
    public class PartyInfomation : Student
    {
        private string date0 = "";
        /// <summary>
        /// 入团日期
        /// </summary>
        public string Date0
        {
            set { date0 = value; }
            get { return date0; }
        }
        private string date1 = "";
        /// <summary>
        /// 申请入党日期
        /// </summary>
        public string Date1
        {
            set { date1 = value; }
            get { return date1; }
        }
        private string date2 = "";
        /// <summary>
        /// 列为积极分子日期
        /// </summary>
        public string Date2
        {
            set { date2 = value; }
            get { return date2; }
        }
        private string date3 = "";
        /// <summary>
        /// 列为发展对象日期
        /// </summary>
        public string Date3
        {
            set { date3 = value; }
            get { return date3; }
        }
        private string joinPartyIntroducer = "";
        /// <summary>
        /// 入党介绍人
        /// </summary>
        public string JoinPartyIntroducer
        {
            set { joinPartyIntroducer = value; }
            get { return joinPartyIntroducer; }
        }
        private string meetingDate = "";
        /// <summary>
        /// 支部大会日期
        /// </summary>
        public string MeetingDate
        {
            set { meetingDate = value; }
            get { return meetingDate; }
        }
        private string date4 = "";
        /// <summary>
        /// 转正日期
        /// </summary>
        public string Date4
        {
            set { date4 = value; }
            get { return date4; }
        }

    }
}
