// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DemoClient.Agents.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class FunctionalError
    {
        /// <summary>
        /// Initializes a new instance of the FunctionalError class.
        /// </summary>
        public FunctionalError() { }

        /// <summary>
        /// Initializes a new instance of the FunctionalError class.
        /// </summary>
        public FunctionalError(string errorCode = default(string), string errorMessage = default(string))
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

    }
}
