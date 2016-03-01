using SampleArch.Model;
using SampleArch.Repository;
using SampleArch.WebApi.Controllers.Base;

namespace SampleArch.WebApi.Controllers
{
    /// <summary>
    /// TierController using base controller
    /// </summary>
    /// <seealso cref="BaseApiController{Tier}" />
    /// <seealso cref="System.Web.Http.ApiController" />
    public class TierController : BaseApiController<Tier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TierController" /> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public TierController(ITierService service) : base(service)
        {
        }
    }
}