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
    public class RegionService : EntityService<Region>, IRegionService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IRegionRepository _repository;

        public RegionService(IUnitOfWork unitOfWork, IRegionRepository repository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }
}
