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
    public class SatTransponderService : EntityService<SatTransponder>, ISatTransponderService
    {
        private IUnitOfWork _unitOfWork;
        private readonly ISatTransponderRepository _repository;

        public SatTransponderService(IUnitOfWork unitOfWork, ISatTransponderRepository repository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }
}
