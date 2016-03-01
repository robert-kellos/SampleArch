using SampleArch.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Location")]
    public class Location : AuditableEntity<long>
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int DbuId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }

        public Location() { }
        public Location(int dbuId, string name, string address1, string city, string state, string country)
        {
            Address1 = address1;
            City = city;
            Country = country;
            DbuId = dbuId;
            Name = name;
            State = state;
        }
        
        #region Old
        //string _address1;
        //string _city;
        //string _country;
        //int _dBUId;
        //string _name;
        //string _state;

        //public Location(
        //        int dBUID,
        //        string name,
        //        string address1,
        //        string city,
        //        string state,
        //        string country
        //        )
        //{
        //    _address1 = address1;
        //    _city = city;
        //    _country = country;
        //    _dBUId = dBUID;
        //    _name = name;
        //    _state = state;
        //}

        //public string getAddress1()
        //{
        //    return _address1;
        //}
        //public void setAddress1(string address1)
        //{
        //    _address1 = address1;
        //}
        //public string getCity()
        //{
        //    return _city;
        //}
        //public void setCity(string city)
        //{
        //    _city = city;
        //}
        //public string getCountry()
        //{
        //    return _country;
        //}
        //public void setCountry(string country)
        //{
        //    _country = country;
        //}
        //public int getdBUID()
        //{
        //    return _dBUId;
        //}
        //public void setdBUID(int dBUId)
        //{
        //    _dBUId = dBUId;
        //}
        //public string getName()
        //{
        //    return _name;
        //}
        //public void setName(string name)
        //{
        //    _name = name;
        //}
        //public string getState()
        //{
        //    return _state;
        //}
        //public void setState(string state)
        //{
        //    _state = state;
        //}
        #endregion Old
    }
}
