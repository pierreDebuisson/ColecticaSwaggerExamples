// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApiRestColectica.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SetSearchFacet
    {
        /// <summary>
        /// Initializes a new instance of the SetSearchFacet class.
        /// </summary>
        public SetSearchFacet()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SetSearchFacet class.
        /// </summary>
        public SetSearchFacet(IList<System.Guid?> itemTypes = default(IList<System.Guid?>), IList<System.Guid?> leafItemTypes = default(IList<System.Guid?>), System.Guid? predicate = default(System.Guid?), bool? reverseTraversal = default(bool?))
        {
            ItemTypes = itemTypes;
            LeafItemTypes = leafItemTypes;
            Predicate = predicate;
            ReverseTraversal = reverseTraversal;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ItemTypes")]
        public IList<System.Guid?> ItemTypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LeafItemTypes")]
        public IList<System.Guid?> LeafItemTypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Predicate")]
        public System.Guid? Predicate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReverseTraversal")]
        public bool? ReverseTraversal { get; set; }

    }
}
