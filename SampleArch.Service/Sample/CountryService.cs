using SampleArch.Logging;
using SampleArch.Model;
using SampleArch.Repository;
using SampleArch.Repository.Common;
using SampleArch.Service.Common;
using SampleArch.Validation.Validators;

namespace SampleArch.Service
{
    public class CountryService : EntityService<Country>, ICountryService
    {
        //private IUnitOfWork _unitOfWork;
        //private readonly ICountryRepository _countryRepository;
        
        public CountryService(IUnitOfWork unitOfWork, ICountryRepository countryRepository)
            : base(unitOfWork, countryRepository)
        {
            //_unitOfWork = unitOfWork;
            //_countryRepository = countryRepository;
        }
    }
}
