using SampleArch.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("DecoderModel")]
    public class DecoderModel : AuditableEntity<long>
    {
        public int DbuId { get; set; }
        public int HealthStatus { get; set; }
        public string Info { get; set; }
        public string Key { get; set; }
        public string ModelNumber { get; set; }
        public long TxnId { get; set; }

        public DecoderModel() { }
        public DecoderModel(int dBUId, int healthStatus, string info, string key, string modelNumber, long txnId)
        {
            DbuId = dBUId;
            HealthStatus = healthStatus;
            Info = info;
            Key = key;
            ModelNumber = modelNumber;
            TxnId = txnId;
        }

        #region Old
        //int _dBUId;
        //int _healthStatus;
        //string _info;
        //string _key;
        //string _modelNumber;
        //long _txnId;

        //public WSDecoderModel(int dBUId,
        //        int healthStatus,
        //                        string info,
        //                        string key,
        //                        string modelNumber,
        //                        long txnId)
        //{
        //    _dBUId = dBUId;
        //    _healthStatus = healthStatus;
        //    _info = info;
        //    _key = key;
        //    _modelNumber = modelNumber;
        //    _txnId = txnId;
        //}

        //public int getDBUId() { return _dBUId; }
        //public void setDBUId(int value) { _dBUId = value; }

        //public int getHealthStatus() { return _healthStatus; }
        //public void setHealthStatus(int value) { _healthStatus = value; }

        //public string getInfo() { return _info; }
        //public void setInfo(string value) { _info = value; }

        //public string getKey() { return _key; }
        //public void setKey(string value) { _key = value; }

        //public string getModelNumber() { return _modelNumber; }
        //public void setModelNumber(string value) { _modelNumber = value; }

        //public long getTxnId() { return _txnId; }
        //public void setTxnId(long value) { _txnId = value; }
        #endregion Old
    }

}
