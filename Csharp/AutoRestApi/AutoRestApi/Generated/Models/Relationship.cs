// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApiRestColectica.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Relationship
    {
        /// <summary>
        /// Initializes a new instance of the Relationship class.
        /// </summary>
        public Relationship()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Relationship class.
        /// </summary>
        public Relationship(IdentifierTriple subject = default(IdentifierTriple), IdentifierTriple objectProperty = default(IdentifierTriple))
        {
            Subject = subject;
            ObjectProperty = objectProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Subject")]
        public IdentifierTriple Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Object")]
        public IdentifierTriple ObjectProperty { get; set; }

    }
}