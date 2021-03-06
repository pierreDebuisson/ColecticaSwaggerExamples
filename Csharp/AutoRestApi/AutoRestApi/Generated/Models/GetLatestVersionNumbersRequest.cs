// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApiRestColectica.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class GetLatestVersionNumbersRequest
    {
        /// <summary>
        /// Initializes a new instance of the GetLatestVersionNumbersRequest
        /// class.
        /// </summary>
        public GetLatestVersionNumbersRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetLatestVersionNumbersRequest
        /// class.
        /// </summary>
        public GetLatestVersionNumbersRequest(IList<IdentifierInRequest> identifiers = default(IList<IdentifierInRequest>))
        {
            Identifiers = identifiers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Identifiers")]
        public IList<IdentifierInRequest> Identifiers { get; set; }

    }
}
