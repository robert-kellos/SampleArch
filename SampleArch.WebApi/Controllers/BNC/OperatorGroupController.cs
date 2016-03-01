using SampleArch.Model;
using SampleArch.Repository;
using SampleArch.WebApi.Controllers.Base;

namespace SampleArch.WebApi.Controllers
{
    /// <summary>
    /// OperatorGroupController using base controller
    /// </summary>
    /// <seealso cref="BaseApiController{OperatorGroup}" />
    /// <seealso cref="System.Web.Http.ApiController" />
    public class OperatorGroupController : BaseApiController<OperatorGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperatorGroupController" /> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public OperatorGroupController(IOperatorGroupService service) : base(service)
        {
        }
    }
}