using SampleArch.Model;
using SampleArch.Repository;
using SampleArch.WebApi.Controllers.Base;

namespace SampleArch.WebApi.Controllers
{
    /// <summary>
    /// SatTransponderController using base controller
    /// </summary>
    /// <seealso cref="BaseApiController{SatTransponder}" />
    /// <seealso cref="System.Web.Http.ApiController" />
    public class SatTransponderController : BaseApiController<SatTransponder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SatTransponderController" /> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public SatTransponderController(ISatTransponderService service) : base(service)
        {
        }
    }
}