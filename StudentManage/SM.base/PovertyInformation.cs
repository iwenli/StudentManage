
/* **********************************************************************
 *                   类【PovertyInformation.cs】信息
 *                    
 * 所属项目：SM.Base       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：PovertyInformation
 * 功    能：贫困信息
 * 来    历：HUCSD 创建于 2013-08-12 10:48:13 
 * 
 * **********************************************************************/

namespace SM.Base
{
    /// <summary>
    /// 贫困信息类
    /// </summary>
    public class PovertyInformation
    {
        private string povertyProve = "";
        /// <summary>
        /// 贫困证明/等级
        /// </summary>
        public string PovertyProve
        {
            set { povertyProve = value; }
            get { return povertyProve; }
        }
        private string povertyCause = "";
        /// <summary>
        /// 贫困原因
        /// </summary>
        public string PovertyCause
        {
            set { povertyCause = value; }
            get { return povertyCause; }
        }
    }
}
