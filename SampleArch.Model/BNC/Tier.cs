using SampleArch.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Tier")]
    public class Tier : AuditableEntity<long>
    {
        public int OperatorGroupId { get; set; }
        public string TierName { get; set; }
        public int TierNumber { get; set; }

        public Tier() { }
        public Tier(int num, string name, int id)
        {
            TierNumber = num;
            TierName = name;
            OperatorGroupId = id;
        }


        #region Old
        //int _tierNumber;
        //string _tierName;
        //int _operatorGroupId;

        //public Tier(int num, string name, int id)
        //{
        //    _tierNumber = num;
        //    _tierName = name;
        //    _operatorGroupId = id;
        //}

        //public int getTierNumber() { return _tierNumber; }
        //public void setTierNumber(int value) { _tierNumber = value; }

        //public string getTierName() { return _tierName; }
        //public void setTierName(string value) { _tierName = value; }

        //public int getOperatorGroupId() { return _operatorGroupId; }
        //public void setOperatorGroupId(int value) { _operatorGroupId = value; }
        #endregion Old
    }
}
