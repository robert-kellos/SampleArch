using SampleArch.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Model
{
    [Table("Affiliate")]
    public class Affiliate : AuditableEntity<long>
    {
        public int AffiliateId { get; set; }
        public string AffiliateName { get; set; }

        public Affiliate() { }
        public Affiliate(int id, string name)
        {
            AffiliateId = id;
            AffiliateName = name;
        }


        #region Old
        //int _affiliateId;
        //string _affiliateName;

        //public Affiliate(int id, string name)
        //{
        //    _affiliateId = id;
        //    _affiliateName = name;
        //}

        //public int getAffiliateId()
        //{
        //    return _affiliateId;
        //}

        //public void setAffiliateId(int affiliateId)
        //{
        //    _affiliateId = affiliateId;
        //}

        //public string getAffiliateName()
        //{
        //    return _affiliateName;
        //}

        //public void setAffiliateName(string affiliateName)
        //{
        //    _affiliateName = affiliateName;
        //}
        #endregion Old
    }
}
