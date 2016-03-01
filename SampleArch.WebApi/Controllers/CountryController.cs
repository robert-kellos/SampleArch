﻿using SampleArch.Model;
using SampleArch.Service;
using SampleArch.WebApi.Controllers.Base;

namespace SampleArch.WebApi.Controllers
{
    /// <summary>
    /// CountryController using base controller
    /// </summary>
    /// <seealso cref="BaseApiController{Country}" />
    /// <seealso cref="System.Web.Http.ApiController" />
    public class CountryController : BaseApiController<Country>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryController" /> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public CountryController(ICountryService service) : base(service)
        {
        }
    }
}