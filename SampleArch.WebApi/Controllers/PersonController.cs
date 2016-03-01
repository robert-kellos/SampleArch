using SampleArch.Model;
using SampleArch.Service;
using SampleArch.WebApi.Controllers.Base;

namespace SampleArch.WebApi.Controllers
{
    /// <summary>
    /// PersonController using base controller
    /// </summary>
    /// <seealso cref="BaseApiController{Person}" />
    /// <seealso cref="System.Web.Http.ApiController" />
    public class PersonController : BaseApiController<Person>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonController" /> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public PersonController(IPersonService service) : base(service)
        {
        }
    }
}