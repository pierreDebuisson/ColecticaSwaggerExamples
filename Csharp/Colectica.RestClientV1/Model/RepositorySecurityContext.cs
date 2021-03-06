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
    /// RepositorySecurityContext
    /// </summary>
    [DataContract]
    public partial class RepositorySecurityContext :  IEquatable<RepositorySecurityContext>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositorySecurityContext" /> class.
        /// </summary>
        /// <param name="IdentifierPermissions">IdentifierPermissions.</param>
        /// <param name="TypePermissions">TypePermissions.</param>
        public RepositorySecurityContext(List<ItemPermission> IdentifierPermissions = default(List<ItemPermission>), List<ItemTypePermission> TypePermissions = default(List<ItemTypePermission>))
        {
            this.IdentifierPermissions = IdentifierPermissions;
            this.TypePermissions = TypePermissions;
        }
        
        /// <summary>
        /// Gets or Sets IdentifierPermissions
        /// </summary>
        [DataMember(Name="IdentifierPermissions", EmitDefaultValue=false)]
        public List<ItemPermission> IdentifierPermissions { get; set; }
        /// <summary>
        /// Gets or Sets TypePermissions
        /// </summary>
        [DataMember(Name="TypePermissions", EmitDefaultValue=false)]
        public List<ItemTypePermission> TypePermissions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositorySecurityContext {\n");
            sb.Append("  IdentifierPermissions: ").Append(IdentifierPermissions).Append("\n");
            sb.Append("  TypePermissions: ").Append(TypePermissions).Append("\n");
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
            return this.Equals(obj as RepositorySecurityContext);
        }

        /// <summary>
        /// Returns true if RepositorySecurityContext instances are equal
        /// </summary>
        /// <param name="other">Instance of RepositorySecurityContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepositorySecurityContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdentifierPermissions == other.IdentifierPermissions ||
                    this.IdentifierPermissions != null &&
                    this.IdentifierPermissions.SequenceEqual(other.IdentifierPermissions)
                ) && 
                (
                    this.TypePermissions == other.TypePermissions ||
                    this.TypePermissions != null &&
                    this.TypePermissions.SequenceEqual(other.TypePermissions)
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
                if (this.IdentifierPermissions != null)
                    hash = hash * 59 + this.IdentifierPermissions.GetHashCode();
                if (this.TypePermissions != null)
                    hash = hash * 59 + this.TypePermissions.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
