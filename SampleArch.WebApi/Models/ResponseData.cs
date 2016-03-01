using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SampleArch.WebApi.Models
{
    /// <summary>
    /// ResponseData
    /// </summary>
    public class ResponseData
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ResponseData"/> is success.
        /// </summary>
        /// <value>
        ///   <c>true</c> if success; otherwise, <c>false</c>.
        /// </value>
        public bool Success { get; set; }
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public IHttpActionResult Message { get; set; }
    }
}