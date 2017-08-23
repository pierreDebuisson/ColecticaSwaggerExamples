/* 
 * Colectica Repository REST API
 *
 * Colectica Repository REST API
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Colectica.RestClientV1.Model
{
    /// <summary>
    /// GetRelationshipsRequest
    /// </summary>
    [DataContract]
    public partial class GetRelationshipsRequest :  IEquatable<GetRelationshipsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetRelationshipsRequest" /> class.
        /// </summary>
        /// <param name="RootItems">RootItems.</param>
        /// <param name="Facet">Facet.</param>
        public GetRelationshipsRequest(List<IdentifierInRequest> RootItems = default(List<IdentifierInRequest>), RelationshipFacet Facet = default(RelationshipFacet))
        {
            this.RootItems = RootItems;
            this.Facet = Facet;
        }
        
        /// <summary>
        /// Gets or Sets RootItems
        /// </summary>
        [DataMember(Name="RootItems", EmitDefaultValue=false)]
        public List<IdentifierInRequest> RootItems { get; set; }
        /// <summary>
        /// Gets or Sets Facet
        /// </summary>
        [DataMember(Name="Facet", EmitDefaultValue=false)]
        public RelationshipFacet Facet { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetRelationshipsRequest {\n");
            sb.Append("  RootItems: ").Append(RootItems).Append("\n");
            sb.Append("  Facet: ").Append(Facet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as GetRelationshipsRequest);
        }

        /// <summary>
        /// Returns true if GetRelationshipsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GetRelationshipsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetRelationshipsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RootItems == other.RootItems ||
                    this.RootItems != null &&
                    this.RootItems.SequenceEqual(other.RootItems)
                ) && 
                (
                    this.Facet == other.Facet ||
                    this.Facet != null &&
                    this.Facet.Equals(other.Facet)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.RootItems != null)
                    hash = hash * 59 + this.RootItems.GetHashCode();
                if (this.Facet != null)
                    hash = hash * 59 + this.Facet.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}