using SampleArch.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Partition")]
    public class Partition : AuditableEntity<long>
    {
        public string PtName { get; set; }
        public int PtNumber { get; set; }

        public Partition() { }
        public Partition(int num, string name)
        {
            PtNumber = num;
            PtName = name;
        }
        

        #region Old
        //int _pTNumber;
        //string _pTName;

        //public Partition(int num, string name)
        //{
        //    _pTNumber = num;
        //    _pTName = name;
        //}

        //public int getPTNumber() { return _pTNumber; }
        //public void setPTNumber(int value) { _pTNumber = value; }

        //public string getPTName() { return _pTName; }
        //public void setPTName(string value) { _pTName = value; }
        #endregion Old
    }
}
