using SampleArch.Model;
using SampleArch.Repository;
using SampleArch.Repository.Common;
using SampleArch.Service.Common;

namespace SampleArch.Service
{
    public class AboutService : EntityService<About>, IAboutService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IAboutRepository _repository;
        
        public AboutService(IUnitOfWork unitOfWork, IAboutRepository repository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }
}
