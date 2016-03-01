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
    public class AffiliateService : EntityService<Affiliate>, IAffiliateService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IAffiliateRepository _repository;

        public AffiliateService(IUnitOfWork unitOfWork, IAffiliateRepository repository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }
}
