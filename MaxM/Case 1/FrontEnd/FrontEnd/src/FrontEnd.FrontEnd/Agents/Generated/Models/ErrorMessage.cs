// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace FrontEnd.Agents.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class ErrorMessage
    {
        /// <summary>
        /// Initializes a new instance of the ErrorMessage class.
        /// </summary>
        public ErrorMessage() { }

        /// <summary>
        /// Initializes a new instance of the ErrorMessage class.
        /// </summary>
        public ErrorMessage(int? errorType = default(int?), string errorDescription = default(string), string remedy = default(string))
        {
            ErrorType = errorType;
            ErrorDescription = errorDescription;
            Remedy = remedy;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorType")]
        public int? ErrorType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorDescription")]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "remedy")]
        public string Remedy { get; set; }

    }
}
