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
    /// LoggedEvent
    /// </summary>
    [DataContract]
    public partial class LoggedEvent :  IEquatable<LoggedEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoggedEvent" /> class.
        /// </summary>
        /// <param name="Logged">Logged.</param>
        /// <param name="Application">Application.</param>
        /// <param name="Level">Level.</param>
        /// <param name="Number">Number.</param>
        /// <param name="Version">Version.</param>
        /// <param name="Username">Username.</param>
        /// <param name="EventData">EventData.</param>
        /// <param name="ItemId">ItemId.</param>
        /// <param name="ItemAgencyId">ItemAgencyId.</param>
        /// <param name="ItemVersion">ItemVersion.</param>
        public LoggedEvent(DateTime? Logged = default(DateTime?), string Application = default(string), int? Level = default(int?), int? Number = default(int?), int? Version = default(int?), string Username = default(string), string EventData = default(string), Guid? ItemId = default(Guid?), string ItemAgencyId = default(string), long? ItemVersion = default(long?))
        {
            this.Logged = Logged;
            this.Application = Application;
            this.Level = Level;
            this.Number = Number;
            this.Version = Version;
            this.Username = Username;
            this.EventData = EventData;
            this.ItemId = ItemId;
            this.ItemAgencyId = ItemAgencyId;
            this.ItemVersion = ItemVersion;
        }
        
        /// <summary>
        /// Gets or Sets Logged
        /// </summary>
        [DataMember(Name="Logged", EmitDefaultValue=false)]
        public DateTime? Logged { get; set; }
        /// <summary>
        /// Gets or Sets Application
        /// </summary>
        [DataMember(Name="Application", EmitDefaultValue=false)]
        public string Application { get; set; }
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="Level", EmitDefaultValue=false)]
        public int? Level { get; set; }
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="Number", EmitDefaultValue=false)]
        public int? Number { get; set; }
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="Username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// Gets or Sets EventData
        /// </summary>
        [DataMember(Name="EventData", EmitDefaultValue=false)]
        public string EventData { get; set; }
        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name="ItemId", EmitDefaultValue=false)]
        public Guid? ItemId { get; set; }
        /// <summary>
        /// Gets or Sets ItemAgencyId
        /// </summary>
        [DataMember(Name="ItemAgencyId", EmitDefaultValue=false)]
        public string ItemAgencyId { get; set; }
        /// <summary>
        /// Gets or Sets ItemVersion
        /// </summary>
        [DataMember(Name="ItemVersion", EmitDefaultValue=false)]
        public long? ItemVersion { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoggedEvent {\n");
            sb.Append("  Logged: ").Append(Logged).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  EventData: ").Append(EventData).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  ItemAgencyId: ").Append(ItemAgencyId).Append("\n");
            sb.Append("  ItemVersion: ").Append(ItemVersion).Append("\n");
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
            return this.Equals(obj as LoggedEvent);
        }

        /// <summary>
        /// Returns true if LoggedEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of LoggedEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoggedEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Logged == other.Logged ||
                    this.Logged != null &&
                    this.Logged.Equals(other.Logged)
                ) && 
                (
                    this.Application == other.Application ||
                    this.Application != null &&
                    this.Application.Equals(other.Application)
                ) && 
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.EventData == other.EventData ||
                    this.EventData != null &&
                    this.EventData.Equals(other.EventData)
                ) && 
                (
                    this.ItemId == other.ItemId ||
                    this.ItemId != null &&
                    this.ItemId.Equals(other.ItemId)
                ) && 
                (
                    this.ItemAgencyId == other.ItemAgencyId ||
                    this.ItemAgencyId != null &&
                    this.ItemAgencyId.Equals(other.ItemAgencyId)
                ) && 
                (
                    this.ItemVersion == other.ItemVersion ||
                    this.ItemVersion != null &&
                    this.ItemVersion.Equals(other.ItemVersion)
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
                if (this.Logged != null)
                    hash = hash * 59 + this.Logged.GetHashCode();
                if (this.Application != null)
                    hash = hash * 59 + this.Application.GetHashCode();
                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.EventData != null)
                    hash = hash * 59 + this.EventData.GetHashCode();
                if (this.ItemId != null)
                    hash = hash * 59 + this.ItemId.GetHashCode();
                if (this.ItemAgencyId != null)
                    hash = hash * 59 + this.ItemAgencyId.GetHashCode();
                if (this.ItemVersion != null)
                    hash = hash * 59 + this.ItemVersion.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
