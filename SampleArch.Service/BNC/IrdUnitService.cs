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
    public class IrdUnitService : EntityService<IrdUnit>, IIrdUnitService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IIrdUnitRepository _repository;

        public IrdUnitService(IUnitOfWork unitOfWork, IIrdUnitRepository repository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }
}
