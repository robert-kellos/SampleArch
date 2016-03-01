using SampleArch.Model;
using SampleArch.Repository.Common;
using SampleArch.Service.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Repository
{
    public class LocationService : EntityService<Location>, ILocationService
    {
        private IUnitOfWork _unitOfWork;
        private readonly ILocationRepository _repository;

        public LocationService(IUnitOfWork unitOfWork, ILocationRepository repository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }
}
