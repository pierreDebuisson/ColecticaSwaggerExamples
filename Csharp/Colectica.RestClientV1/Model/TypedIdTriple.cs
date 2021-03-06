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
    /// TypedIdTriple
    /// </summary>
    [DataContract]
    public partial class TypedIdTriple :  IEquatable<TypedIdTriple>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypedIdTriple" /> class.
        /// </summary>
        /// <param name="Item1">Item1.</param>
        public TypedIdTriple(IdentifierTriple Item1 = default(IdentifierTriple))
        {
            this.Item1 = Item1;
        }
        
        /// <summary>
        /// Gets or Sets Item1
        /// </summary>
        [DataMember(Name="Item1", EmitDefaultValue=false)]
        public IdentifierTriple Item1 { get; set; }
        /// <summary>
        /// Gets or Sets Item2
        /// </summary>
        [DataMember(Name="Item2", EmitDefaultValue=false)]
        public Guid? Item2 { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TypedIdTriple {\n");
            sb.Append("  Item1: ").Append(Item1).Append("\n");
            sb.Append("  Item2: ").Append(Item2).Append("\n");
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
            return this.Equals(obj as TypedIdTriple);
        }

        /// <summary>
        /// Returns true if TypedIdTriple instances are equal
        /// </summary>
        /// <param name="other">Instance of TypedIdTriple to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TypedIdTriple other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Item1 == other.Item1 ||
                    this.Item1 != null &&
                    this.Item1.Equals(other.Item1)
                ) && 
                (
                    this.Item2 == other.Item2 ||
                    this.Item2 != null &&
                    this.Item2.Equals(other.Item2)
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
                if (this.Item1 != null)
                    hash = hash * 59 + this.Item1.GetHashCode();
                if (this.Item2 != null)
                    hash = hash * 59 + this.Item2.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
