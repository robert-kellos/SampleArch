using SampleArch.Model;
using SampleArch.Repository;
using SampleArch.WebApi.Controllers.Base;

namespace SampleArch.WebApi.Controllers
{
    /// <summary>
    /// LocationController using base controller
    /// </summary>
    /// <seealso cref="BaseApiController{Location}" />
    /// <seealso cref="System.Web.Http.ApiController" />
    public class LocationController : BaseApiController<Location>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationController" /> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public LocationController(ILocationService service) : base(service)
        {
        }
    }
}