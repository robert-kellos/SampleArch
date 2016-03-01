using SampleArch.Model;
using SampleArch.Repository;
using SampleArch.WebApi.Controllers.Base;

namespace SampleArch.WebApi.Controllers
{
    /// <summary>
    /// DecoderModelController using base controller
    /// </summary>
    /// <seealso cref="BaseApiController{DecoderModel}" />
    /// <seealso cref="System.Web.Http.ApiController" />
    public class DecoderModelController : BaseApiController<DecoderModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecoderModelController" /> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public DecoderModelController(IDecoderModelService service) : base(service)
        {
        }
    }
}