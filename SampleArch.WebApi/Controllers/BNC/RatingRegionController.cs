using SampleArch.Model;
using SampleArch.Repository;
using SampleArch.WebApi.Controllers.Base;

namespace SampleArch.WebApi.Controllers
{
    /// <summary>
    /// RatingRegionController using base controller
    /// </summary>
    /// <seealso cref="BaseApiController{RatingRegion}" />
    /// <seealso cref="System.Web.Http.ApiController" />
    public class RatingRegionController : BaseApiController<RatingRegion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RatingRegionController" /> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public RatingRegionController(IRatingRegionService service) : base(service)
        {
        }
    }
}