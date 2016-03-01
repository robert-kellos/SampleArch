using SampleArch.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("SatTransponder")]
    public class SatTransponder : AuditableEntity<long>
    {
        public int SatelliteId { get; set; }
        public string SatelliteName { get; set; }
        public int TransponderId { get; set; }
        public string TransponderName { get; set; }
        public string Polarity { get; set; }

        public SatTransponder() { }
        public SatTransponder(int satelliteId, int transponderId, string satellineName, string transponderName, string polarity)
        {
            SatelliteId = satelliteId;
            TransponderId = transponderId;
            SatelliteName = satellineName;
            TransponderName = transponderName;
            Polarity = polarity;
        }
        

        #region Old
        //int _satelliteId;
        //int _transponderId;
        //string _satelliteName;
        //string _transponderName;
        //string _polarity;

        //public SatTransponder(int satelliteId,
        //                            int transponderId,
        //                            string satellineName,
        //                            string transponderName,
        //                            string polarity)
        //{
        //    _satelliteId = satelliteId;
        //    _transponderId = transponderId;
        //    _satelliteName = satellineName;
        //    _transponderName = transponderName;
        //    _polarity = polarity;
        //}

        //public int getSatelliteId() { return _satelliteId; }
        //public void setSatelliteId(int value) { _satelliteId = value; }

        //public int getTransponderId() { return _transponderId; }
        //public void setTransponderId(int value) { _transponderId = value; }

        //public string getSatelliteName() { return _satelliteName; }
        //public void setSatelliteName(string value) { _satelliteName = value; }

        //public string getTransponderName() { return _transponderName; }
        //public void setTransponderName(string value) { _transponderName = value; }

        //public string getPolarity() { return _polarity; }
        //public void setPolarity(string value) { _polarity = value; }
        #endregion Old
    }
}
