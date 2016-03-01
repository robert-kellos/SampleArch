using SampleArch.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("IrdUnit")]
    public class IrdUnit : AuditableEntity<long>
    {

        public int PartitionNumber { get; set; }
        public string AffiliateName { get; set; }
        public string LocationName { get; set; }
        public int OperatorGroupId { get; set; }
        public int RegionNumber { get; set; }
        public string UnitAddress { get; set; }
        public string DecoderModel { get; set; }
        public int TemplateId { get; set; }
        public List<Tier> Tiers { get; set; }

        public IrdUnit() { }

        public IrdUnit(int partitionNumber, string affiliateName, string locationName, int operatorGroupID,
                int regionNumber, string unitAddress, string decoderModel, int templateId, List<Tier> tiers)
        {
            PartitionNumber = partitionNumber;
            AffiliateName = affiliateName;
            LocationName = locationName;
            OperatorGroupId = operatorGroupID;
            RegionNumber = regionNumber;
            UnitAddress = unitAddress;
            DecoderModel = decoderModel;
            TemplateId = templateId;
            Tiers = tiers;
        }

        #region Old
        //int _partitionNumber;
        //string _affiliateName;
        //string _locationName;
        //int _operatorGroupId;
        //int _regionNumber;
        //string _unitAddress;
        //string _decoderModel;
        //int _templateId;
        //List<Tier> _tiers;

        //public IrdUnit(int partitionNumber, string affiliateName, string locationName, int operatorGroupID,
        //        int regionNumber, string unitAddress, string decoderModel, int templateId, List<Tier> tiers)
        //{
        //    //super();
        //    _partitionNumber = partitionNumber;
        //    _affiliateName = affiliateName;
        //    _locationName = locationName;
        //    _operatorGroupId = operatorGroupID;
        //    _regionNumber = regionNumber;
        //    _unitAddress = unitAddress;
        //    _decoderModel = decoderModel;
        //    _templateId = templateId;
        //    _tiers = tiers;
        //}

        //public int getPartitionNumber()
        //{
        //    return _partitionNumber;
        //}
        //public void setPartitionNumber(int partitionNumber)
        //{
        //    _partitionNumber = partitionNumber;
        //}
        //public string getAffiliateName()
        //{
        //    return _affiliateName;
        //}
        //public void setAffiliateName(string affiliateName)
        //{
        //    _affiliateName = affiliateName;
        //}
        //public string getLocationName()
        //{
        //    return _locationName;
        //}
        //public void setLocationName(string locationName)
        //{
        //    _locationName = locationName;
        //}
        //public int getOperatorGroupID()
        //{
        //    return _operatorGroupId;
        //}
        //public void setOperatorGroupID(int operatorGroupId)
        //{
        //    _operatorGroupId = operatorGroupId;
        //}
        //public int getRegionNumber()
        //{
        //    return _regionNumber;
        //}
        //public void setRegionNumber(int regionNumber)
        //{
        //    _regionNumber = regionNumber;
        //}
        //public string getUnitAddress()
        //{
        //    return _unitAddress;
        //}
        //public void setUnitAddress(string unitAddress)
        //{
        //    _unitAddress = unitAddress;
        //}
        //public string getDecoderModel()
        //{
        //    return _decoderModel;
        //}
        //public void setDecoderModel(string decoderModel)
        //{
        //    _decoderModel = decoderModel;
        //}
        //public int getTemplateID()
        //{
        //    return _templateId;
        //}
        //public void setTemplateID(int templateId)
        //{
        //    _templateId = templateId;
        //}
        //public List<Tier> getTiers()
        //{
        //    return _tiers;
        //}
        //public void setTiers(List<Tier> tiers)
        //{
        //    _tiers = tiers;
        //}
        #endregion Old
    }
}
