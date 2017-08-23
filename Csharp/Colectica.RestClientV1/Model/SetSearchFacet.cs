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
    /// SetSearchFacet
    /// </summary>
    [DataContract]
    public partial class SetSearchFacet :  IEquatable<SetSearchFacet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetSearchFacet" /> class.
        /// </summary>
        /// <param name="ItemTypes">ItemTypes.</param>
        /// <param name="LeafItemTypes">LeafItemTypes.</param>
        /// <param name="Predicate">Predicate.</param>
        /// <param name="ReverseTraversal">ReverseTraversal.</param>
        public SetSearchFacet(List<Guid?> ItemTypes = default(List<Guid?>), List<Guid?> LeafItemTypes = default(List<Guid?>), Guid? Predicate = default(Guid?), bool? ReverseTraversal = default(bool?))
        {
            this.ItemTypes = ItemTypes;
            this.LeafItemTypes = LeafItemTypes;
            this.Predicate = Predicate;
            this.ReverseTraversal = ReverseTraversal;
        }
        
        /// <summary>
        /// Gets or Sets ItemTypes
        /// </summary>
        [DataMember(Name="ItemTypes", EmitDefaultValue=false)]
        public List<Guid?> ItemTypes { get; set; }
        /// <summary>
        /// Gets or Sets LeafItemTypes
        /// </summary>
        [DataMember(Name="LeafItemTypes", EmitDefaultValue=false)]
        public List<Guid?> LeafItemTypes { get; set; }
        /// <summary>
        /// Gets or Sets Predicate
        /// </summary>
        [DataMember(Name="Predicate", EmitDefaultValue=false)]
        public Guid? Predicate { get; set; }
        /// <summary>
        /// Gets or Sets ReverseTraversal
        /// </summary>
        [DataMember(Name="ReverseTraversal", EmitDefaultValue=false)]
        public bool? ReverseTraversal { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetSearchFacet {\n");
            sb.Append("  ItemTypes: ").Append(ItemTypes).Append("\n");
            sb.Append("  LeafItemTypes: ").Append(LeafItemTypes).Append("\n");
            sb.Append("  Predicate: ").Append(Predicate).Append("\n");
            sb.Append("  ReverseTraversal: ").Append(ReverseTraversal).Append("\n");
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
            return this.Equals(obj as SetSearchFacet);
        }

        /// <summary>
        /// Returns true if SetSearchFacet instances are equal
        /// </summary>
        /// <param name="other">Instance of SetSearchFacet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetSearchFacet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ItemTypes == other.ItemTypes ||
                    this.ItemTypes != null &&
                    this.ItemTypes.SequenceEqual(other.ItemTypes)
                ) && 
                (
                    this.LeafItemTypes == other.LeafItemTypes ||
                    this.LeafItemTypes != null &&
                    this.LeafItemTypes.SequenceEqual(other.LeafItemTypes)
                ) && 
                (
                    this.Predicate == other.Predicate ||
                    this.Predicate != null &&
                    this.Predicate.Equals(other.Predicate)
                ) && 
                (
                    this.ReverseTraversal == other.ReverseTraversal ||
                    this.ReverseTraversal != null &&
                    this.ReverseTraversal.Equals(other.ReverseTraversal)
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
                if (this.ItemTypes != null)
                    hash = hash * 59 + this.ItemTypes.GetHashCode();
                if (this.LeafItemTypes != null)
                    hash = hash * 59 + this.LeafItemTypes.GetHashCode();
                if (this.Predicate != null)
                    hash = hash * 59 + this.Predicate.GetHashCode();
                if (this.ReverseTraversal != null)
                    hash = hash * 59 + this.ReverseTraversal.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
