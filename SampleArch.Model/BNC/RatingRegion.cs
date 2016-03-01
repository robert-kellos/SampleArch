using SampleArch.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("RatingRegion")]
    public class RatingRegion : AuditableEntity<long>
    {
        public int RatingId { get; set; }
        public string Name { get; set; }
        public string RatingText { get; set; }

        public RatingRegion() { }
        public RatingRegion(int id, string name, string text)
        {
            RatingId = id;
            Name = name;
            RatingText = text;
        }
        

        #region Old
        //int _id;
        //string _name;
        //string _ratingText;

        //public RatingRegion(int id, string name, string text)
        //{
        //    _id = id;
        //    _name = name;
        //    _ratingText = text;
        //}

        //public int getId()
        //{
        //    return _id;
        //}

        //public void setId(int id)
        //{
        //    _id = id;
        //}

        //public string getName()
        //{
        //    return _name;
        //}

        //public void setName(string name)
        //{
        //    _name = name;
        //}

        //public string getRatingText()
        //{
        //    return _ratingText;
        //}

        //public void setRatingText(string ratingText)
        //{
        //    _ratingText = ratingText;
        //}
        #endregion Old
    }
}
