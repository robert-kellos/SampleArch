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
    public class OperatorGroupService : EntityService<OperatorGroup>, IOperatorGroupService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IOperatorGroupRepository _repository;

        public OperatorGroupService(IUnitOfWork unitOfWork, IOperatorGroupRepository repository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }
}
