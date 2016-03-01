using SampleArch.Model;
using SampleArch.Repository;
using SampleArch.WebApi.Controllers.Base;

namespace SampleArch.WebApi.Controllers
{
    /// <summary>
    /// PartitionController using base controller
    /// </summary>
    /// <seealso cref="BaseApiController{Partition}" />
    /// <seealso cref="System.Web.Http.ApiController" />
    public class PartitionController : BaseApiController<Partition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartitionController" /> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public PartitionController(IPartitionService service) : base(service)
        {
        }
    }
}