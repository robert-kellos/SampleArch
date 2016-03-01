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
    public class DecoderModelService : EntityService<DecoderModel>, IDecoderModelService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IDecoderModelRepository _repository;

        public DecoderModelService(IUnitOfWork unitOfWork, IDecoderModelRepository repository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }
}
