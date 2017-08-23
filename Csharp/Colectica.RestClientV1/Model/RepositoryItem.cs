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
    /// RepositoryItem
    /// </summary>
    [DataContract]
    public partial class RepositoryItem :  IEquatable<RepositoryItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryItem" /> class.
        /// </summary>
        /// <param name="VersionRationale">VersionRationale.</param>
        /// <param name="ItemType">ItemType.</param>
        /// <param name="AgencyId">AgencyId.</param>
        /// <param name="Version">Version.</param>
        /// <param name="Identifier">Identifier.</param>
        /// <param name="Item">Item.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="VersionDate">VersionDate.</param>
        /// <param name="VersionResponsibility">VersionResponsibility.</param>
        /// <param name="IsPublished">IsPublished.</param>
        /// <param name="IsDeprecated">IsDeprecated.</param>
        /// <param name="IsProvisional">IsProvisional.</param>
        /// <param name="ItemFormat">ItemFormat.</param>
        public RepositoryItem(Dictionary<string, string> VersionRationale = default(Dictionary<string, string>), Guid? ItemType = default(Guid?), string AgencyId = default(string), long? Version = default(long?), Guid? Identifier = default(Guid?), string Item = default(string), List<Note> Notes = default(List<Note>), DateTime? VersionDate = default(DateTime?), string VersionResponsibility = default(string), bool? IsPublished = default(bool?), bool? IsDeprecated = default(bool?), bool? IsProvisional = default(bool?), Guid? ItemFormat = default(Guid?))
        {
            this.VersionRationale = VersionRationale;
            this.ItemType = ItemType;
            this.AgencyId = AgencyId;
            this.Version = Version;
            this.Identifier = Identifier;
            this.Item = Item;
            this.Notes = Notes;
            this.VersionDate = VersionDate;
            this.VersionResponsibility = VersionResponsibility;
            this.IsPublished = IsPublished;
            this.IsDeprecated = IsDeprecated;
            this.IsProvisional = IsProvisional;
            this.ItemFormat = ItemFormat;
        }
        
        /// <summary>
        /// Gets or Sets VersionRationale
        /// </summary>
        [DataMember(Name="VersionRationale", EmitDefaultValue=false)]
        public Dictionary<string, string> VersionRationale { get; set; }
        /// <summary>
        /// Gets or Sets ItemType
        /// </summary>
        [DataMember(Name="ItemType", EmitDefaultValue=false)]
        public Guid? ItemType { get; set; }
        /// <summary>
        /// Gets or Sets AgencyId
        /// </summary>
        [DataMember(Name="AgencyId", EmitDefaultValue=false)]
        public string AgencyId { get; set; }
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public long? Version { get; set; }
        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name="Identifier", EmitDefaultValue=false)]
        public Guid? Identifier { get; set; }
        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name="Item", EmitDefaultValue=false)]
        public string Item { get; set; }
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="Notes", EmitDefaultValue=false)]
        public List<Note> Notes { get; set; }
        /// <summary>
        /// Gets or Sets VersionDate
        /// </summary>
        [DataMember(Name="VersionDate", EmitDefaultValue=false)]
        public DateTime? VersionDate { get; set; }
        /// <summary>
        /// Gets or Sets VersionResponsibility
        /// </summary>
        [DataMember(Name="VersionResponsibility", EmitDefaultValue=false)]
        public string VersionResponsibility { get; set; }
        /// <summary>
        /// Gets or Sets IsPublished
        /// </summary>
        [DataMember(Name="IsPublished", EmitDefaultValue=false)]
        public bool? IsPublished { get; set; }
        /// <summary>
        /// Gets or Sets IsDeprecated
        /// </summary>
        [DataMember(Name="IsDeprecated", EmitDefaultValue=false)]
        public bool? IsDeprecated { get; set; }
        /// <summary>
        /// Gets or Sets IsProvisional
        /// </summary>
        [DataMember(Name="IsProvisional", EmitDefaultValue=false)]
        public bool? IsProvisional { get; set; }
        /// <summary>
        /// Gets or Sets ItemFormat
        /// </summary>
        [DataMember(Name="ItemFormat", EmitDefaultValue=false)]
        public Guid? ItemFormat { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryItem {\n");
            sb.Append("  VersionRationale: ").Append(VersionRationale).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
            sb.Append("  AgencyId: ").Append(AgencyId).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  VersionDate: ").Append(VersionDate).Append("\n");
            sb.Append("  VersionResponsibility: ").Append(VersionResponsibility).Append("\n");
            sb.Append("  IsPublished: ").Append(IsPublished).Append("\n");
            sb.Append("  IsDeprecated: ").Append(IsDeprecated).Append("\n");
            sb.Append("  IsProvisional: ").Append(IsProvisional).Append("\n");
            sb.Append("  ItemFormat: ").Append(ItemFormat).Append("\n");
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
            return this.Equals(obj as RepositoryItem);
        }

        /// <summary>
        /// Returns true if RepositoryItem instances are equal
        /// </summary>
        /// <param name="other">Instance of RepositoryItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepositoryItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.VersionRationale == other.VersionRationale ||
                    this.VersionRationale != null &&
                    this.VersionRationale.SequenceEqual(other.VersionRationale)
                ) && 
                (
                    this.ItemType == other.ItemType ||
                    this.ItemType != null &&
                    this.ItemType.Equals(other.ItemType)
                ) && 
                (
                    this.AgencyId == other.AgencyId ||
                    this.AgencyId != null &&
                    this.AgencyId.Equals(other.AgencyId)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Identifier == other.Identifier ||
                    this.Identifier != null &&
                    this.Identifier.Equals(other.Identifier)
                ) && 
                (
                    this.Item == other.Item ||
                    this.Item != null &&
                    this.Item.Equals(other.Item)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.SequenceEqual(other.Notes)
                ) && 
                (
                    this.VersionDate == other.VersionDate ||
                    this.VersionDate != null &&
                    this.VersionDate.Equals(other.VersionDate)
                ) && 
                (
                    this.VersionResponsibility == other.VersionResponsibility ||
                    this.VersionResponsibility != null &&
                    this.VersionResponsibility.Equals(other.VersionResponsibility)
                ) && 
                (
                    this.IsPublished == other.IsPublished ||
                    this.IsPublished != null &&
                    this.IsPublished.Equals(other.IsPublished)
                ) && 
                (
                    this.IsDeprecated == other.IsDeprecated ||
                    this.IsDeprecated != null &&
                    this.IsDeprecated.Equals(other.IsDeprecated)
                ) && 
                (
                    this.IsProvisional == other.IsProvisional ||
                    this.IsProvisional != null &&
                    this.IsProvisional.Equals(other.IsProvisional)
                ) && 
                (
                    this.ItemFormat == other.ItemFormat ||
                    this.ItemFormat != null &&
                    this.ItemFormat.Equals(other.ItemFormat)
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
                if (this.VersionRationale != null)
                    hash = hash * 59 + this.VersionRationale.GetHashCode();
                if (this.ItemType != null)
                    hash = hash * 59 + this.ItemType.GetHashCode();
                if (this.AgencyId != null)
                    hash = hash * 59 + this.AgencyId.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.Identifier != null)
                    hash = hash * 59 + this.Identifier.GetHashCode();
                if (this.Item != null)
                    hash = hash * 59 + this.Item.GetHashCode();
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                if (this.VersionDate != null)
                    hash = hash * 59 + this.VersionDate.GetHashCode();
                if (this.VersionResponsibility != null)
                    hash = hash * 59 + this.VersionResponsibility.GetHashCode();
                if (this.IsPublished != null)
                    hash = hash * 59 + this.IsPublished.GetHashCode();
                if (this.IsDeprecated != null)
                    hash = hash * 59 + this.IsDeprecated.GetHashCode();
                if (this.IsProvisional != null)
                    hash = hash * 59 + this.IsProvisional.GetHashCode();
                if (this.ItemFormat != null)
                    hash = hash * 59 + this.ItemFormat.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
