using SampleArch.Model;
using SampleArch.Repository;
using SampleArch.WebApi.Controllers.Base;

namespace SampleArch.WebApi.Controllers
{
    /// <summary>
    /// AffiliateController using base controller
    /// </summary>
    /// <seealso cref="BaseApiController{Affiliate}" />
    /// <seealso cref="System.Web.Http.ApiController" />
    public class AffiliateController : BaseApiController<Affiliate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliateController"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public AffiliateController(IAffiliateService service) : base(service)
        {
        }
    }
}