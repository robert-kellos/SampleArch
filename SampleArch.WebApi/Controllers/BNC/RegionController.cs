using SampleArch.Model;
using SampleArch.Repository;
using SampleArch.WebApi.Controllers.Base;

namespace SampleArch.WebApi.Controllers
{
    /// <summary>
    /// RegionController using base controller
    /// </summary>
    /// <seealso cref="BaseApiController{Region}" />
    /// <seealso cref="System.Web.Http.ApiController" />
    public class RegionController : BaseApiController<Region>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionController" /> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public RegionController(IRegionService service) : base(service)
        {
        }
    }
}