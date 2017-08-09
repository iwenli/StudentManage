
/* **********************************************************************
 *                   类【RewardsPunishmentInformation.cs】信息
 *                    
 * 所属项目：SM.Base       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：RewardsPunishmentInformation
 * 功    能：奖惩信息
 * 来    历：HUCSD 创建于 2013-08-12 16:26:06 
 * 
 * **********************************************************************/

namespace SM.Base
{
    /// <summary>
    /// 奖惩信息类
    /// </summary>
    public class RewardsPunishmentInformation : Student
    {
        private string rpName = "";
        /// <summary>
        /// 奖惩名称
        /// </summary>
        public string RPName
        {
            set { rpName = value; }
            get { return rpName; }
        }
        private string rpType = "";
        /// <summary>
        /// 奖惩类型
        /// </summary>
        public string RPType
        {
            set { rpType = value; }
            get { return rpType; }
        }
        private string rpTprivate = "";
        /// <summary>
        /// 奖惩时间
        /// </summary>
        public string RPTprivate
        {
            set { rpTprivate = value; }
            get { return rpTprivate; }
        }
        private string rpRank = "";
        /// <summary>
        /// 奖惩级别
        /// </summary>
        public string RPRank
        {
            set { rpRank = value; }
            get { return rpRank; }
        }
    }
}
