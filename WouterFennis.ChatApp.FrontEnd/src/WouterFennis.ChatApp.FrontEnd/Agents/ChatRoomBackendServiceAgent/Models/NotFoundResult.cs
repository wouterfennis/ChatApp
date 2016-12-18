// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace WouterFennis.ChatApp.FrontEnd.Agents.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class NotFoundResult
    {
        /// <summary>
        /// Initializes a new instance of the NotFoundResult class.
        /// </summary>
        public NotFoundResult() { }

        /// <summary>
        /// Initializes a new instance of the NotFoundResult class.
        /// </summary>
        public NotFoundResult(int? statusCode = default(int?))
        {
            StatusCode = statusCode;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public int? StatusCode { get; private set; }

    }
}
