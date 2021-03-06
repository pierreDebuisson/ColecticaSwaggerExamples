// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApiRestColectica.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class RepositoryItem
    {
        /// <summary>
        /// Initializes a new instance of the RepositoryItem class.
        /// </summary>
        public RepositoryItem()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RepositoryItem class.
        /// </summary>
        public RepositoryItem(IDictionary<string, string> versionRationale = default(IDictionary<string, string>), System.Guid? itemType = default(System.Guid?), string agencyId = default(string), long? version = default(long?), System.Guid? identifier = default(System.Guid?), string item = default(string), IList<Note> notes = default(IList<Note>), System.DateTime? versionDate = default(System.DateTime?), string versionResponsibility = default(string), bool? isPublished = default(bool?), bool? isDeprecated = default(bool?), bool? isProvisional = default(bool?), System.Guid? itemFormat = default(System.Guid?))
        {
            VersionRationale = versionRationale;
            ItemType = itemType;
            AgencyId = agencyId;
            Version = version;
            Identifier = identifier;
            Item = item;
            Notes = notes;
            VersionDate = versionDate;
            VersionResponsibility = versionResponsibility;
            IsPublished = isPublished;
            IsDeprecated = isDeprecated;
            IsProvisional = isProvisional;
            ItemFormat = itemFormat;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "VersionRationale")]
        public IDictionary<string, string> VersionRationale { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ItemType")]
        public System.Guid? ItemType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AgencyId")]
        public string AgencyId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Version")]
        public long? Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Identifier")]
        public System.Guid? Identifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Item")]
        public string Item { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Notes")]
        public IList<Note> Notes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "VersionDate")]
        public System.DateTime? VersionDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "VersionResponsibility")]
        public string VersionResponsibility { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsPublished")]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDeprecated")]
        public bool? IsDeprecated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsProvisional")]
        public bool? IsProvisional { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ItemFormat")]
        public System.Guid? ItemFormat { get; set; }

    }
}
