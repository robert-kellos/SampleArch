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
    public class RatingRegionService : EntityService<RatingRegion>, IRatingRegionService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IRatingRegionRepository _repository;

        public RatingRegionService(IUnitOfWork unitOfWork, IRatingRegionRepository repository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }
}
