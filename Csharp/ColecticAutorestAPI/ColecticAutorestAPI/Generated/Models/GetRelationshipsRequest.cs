// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApiRestColectica.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class GetRelationshipsRequest
    {
        /// <summary>
        /// Initializes a new instance of the GetRelationshipsRequest class.
        /// </summary>
        public GetRelationshipsRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetRelationshipsRequest class.
        /// </summary>
        public GetRelationshipsRequest(IList<IdentifierInRequest> rootItems = default(IList<IdentifierInRequest>), RelationshipFacet facet = default(RelationshipFacet))
        {
            RootItems = rootItems;
            Facet = facet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RootItems")]
        public IList<IdentifierInRequest> RootItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Facet")]
        public RelationshipFacet Facet { get; set; }

    }
}
