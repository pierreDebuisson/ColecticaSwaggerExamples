// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApiRestColectica.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IdentifierInRequest
    {
        /// <summary>
        /// Initializes a new instance of the IdentifierInRequest class.
        /// </summary>
        public IdentifierInRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdentifierInRequest class.
        /// </summary>
        public IdentifierInRequest(string agencyId = default(string), System.Guid? identifier = default(System.Guid?), long? version = default(long?))
        {
            AgencyId = agencyId;
            Identifier = identifier;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AgencyId")]
        public string AgencyId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Identifier")]
        public System.Guid? Identifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Version")]
        public long? Version { get; set; }

    }
}