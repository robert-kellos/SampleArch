using SampleArch.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("OperatorGroup")]
    public class OperatorGroup : AuditableEntity<long>
    {
        public int OgId { get; set; }
        public string OgName { get; set; }

        public OperatorGroup() { }
        public OperatorGroup(int id, string name)
        {
            OgId = id;
            OgName = name;
        }

        #region Old
        //int _oGId;
        //string _oGName;

        //public OperatorGroup(int id, string name)
        //{
        //    _oGId = id;
        //    _oGName = name;
        //}

        //public int getOGId() { return _oGId; }
        //public void setOGId(int value) { _oGId = value; }

        //public string getOGName() { return _oGName; }
        //public void setOGName(string value) { _oGName = value; }
        #endregion Old
    }
}
