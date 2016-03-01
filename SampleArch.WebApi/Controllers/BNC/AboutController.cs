using SampleArch.Model;
using SampleArch.Service;
using SampleArch.WebApi.Controllers.Base;

namespace SampleArch.WebApi.Controllers
{
    /// <summary>
    /// AboutController using base controller
    /// </summary>
    /// <seealso cref="BaseApiController{About}" />
    /// <seealso cref="System.Web.Http.ApiController" />
    public class AboutController : BaseApiController<About>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AboutController"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public AboutController(IAboutService service) : base(service)
        {
        }
    }
}