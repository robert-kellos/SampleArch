using SampleArch.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Model
{
    [Table("About")]
    public class About : AuditableEntity<long>
    {
        public string ServerName { get; set; }
        public string VersionName { get; set; }
        public string VersionReleaseDate { get; set; }
        public string VersionCopyright { get; set; }
        public string ServerTime { get; set; }
        public int BncId { get; set; }
        public string BncType { get; set; }

        public About() { }

        #region Old
        //string _serverName;
        //string _versionName;
        //string _versionRelaseDate;
        //string _versionCopyright;
        //string _serverTime;
        //int _bncId;
        //string _bncType;

        //public string getServerName() { return _serverName; }
        //public void setServerName(string value) { _serverName = value; }

        //public string getVersionName() { return _versionName; }
        //public void setVersionName(string value) { _versionName = value; }

        //public string getVersionReleaseDate() { return _versionRelaseDate; }
        //public void setVersionReleaseDate(string input) { _versionRelaseDate = input; }

        //public string getVersionCopyright() { return _versionCopyright; }
        //public void setVersionCopyright(string value) { _versionCopyright = value; }

        //public string getServerTime() { return _serverTime; }
        //public void setServerTime(string value) { _serverTime = value; }

        //public int getBNCId() { return _bncId; }
        //public void setBNCId(int value) { _bncId = value; }

        //public string getBNCType() { return _bncType; }
        //public void setBNCType(string value) { _bncType = value; }
        #endregion Old
    }
}
