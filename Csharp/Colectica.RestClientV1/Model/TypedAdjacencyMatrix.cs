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
    /// TypedAdjacencyMatrix
    /// </summary>
    [DataContract]
    public partial class TypedAdjacencyMatrix :  IEquatable<TypedAdjacencyMatrix>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypedAdjacencyMatrix" /> class.
        /// </summary>
        /// <param name="Edges">Edges.</param>
        /// <param name="Roots">Roots.</param>
        /// <param name="ReverseTraversal">ReverseTraversal.</param>
        /// <param name="Predicate">Predicate.</param>
        public TypedAdjacencyMatrix(List<TypedRelationship> Edges = default(List<TypedRelationship>), List<IdentifierTriple> Roots = default(List<IdentifierTriple>), bool? ReverseTraversal = default(bool?), Guid? Predicate = default(Guid?))
        {
            this.Edges = Edges;
            this.Roots = Roots;
            this.ReverseTraversal = ReverseTraversal;
            this.Predicate = Predicate;
        }
        
        /// <summary>
        /// Gets or Sets Edges
        /// </summary>
        [DataMember(Name="Edges", EmitDefaultValue=false)]
        public List<TypedRelationship> Edges { get; set; }
        /// <summary>
        /// Gets or Sets Roots
        /// </summary>
        [DataMember(Name="Roots", EmitDefaultValue=false)]
        public List<IdentifierTriple> Roots { get; set; }
        /// <summary>
        /// Gets or Sets ReverseTraversal
        /// </summary>
        [DataMember(Name="ReverseTraversal", EmitDefaultValue=false)]
        public bool? ReverseTraversal { get; set; }
        /// <summary>
        /// Gets or Sets Predicate
        /// </summary>
        [DataMember(Name="Predicate", EmitDefaultValue=false)]
        public Guid? Predicate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TypedAdjacencyMatrix {\n");
            sb.Append("  Edges: ").Append(Edges).Append("\n");
            sb.Append("  Roots: ").Append(Roots).Append("\n");
            sb.Append("  ReverseTraversal: ").Append(ReverseTraversal).Append("\n");
            sb.Append("  Predicate: ").Append(Predicate).Append("\n");
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
            return this.Equals(obj as TypedAdjacencyMatrix);
        }

        /// <summary>
        /// Returns true if TypedAdjacencyMatrix instances are equal
        /// </summary>
        /// <param name="other">Instance of TypedAdjacencyMatrix to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TypedAdjacencyMatrix other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Edges == other.Edges ||
                    this.Edges != null &&
                    this.Edges.SequenceEqual(other.Edges)
                ) && 
                (
                    this.Roots == other.Roots ||
                    this.Roots != null &&
                    this.Roots.SequenceEqual(other.Roots)
                ) && 
                (
                    this.ReverseTraversal == other.ReverseTraversal ||
                    this.ReverseTraversal != null &&
                    this.ReverseTraversal.Equals(other.ReverseTraversal)
                ) && 
                (
                    this.Predicate == other.Predicate ||
                    this.Predicate != null &&
                    this.Predicate.Equals(other.Predicate)
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
                if (this.Edges != null)
                    hash = hash * 59 + this.Edges.GetHashCode();
                if (this.Roots != null)
                    hash = hash * 59 + this.Roots.GetHashCode();
                if (this.ReverseTraversal != null)
                    hash = hash * 59 + this.ReverseTraversal.GetHashCode();
                if (this.Predicate != null)
                    hash = hash * 59 + this.Predicate.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
