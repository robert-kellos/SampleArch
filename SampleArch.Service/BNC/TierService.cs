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
    public class TierService : EntityService<Tier>, ITierService
    {
        private IUnitOfWork _unitOfWork;
        private readonly ITierRepository _repository;

        public TierService(IUnitOfWork unitOfWork, ITierRepository repository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }
}
