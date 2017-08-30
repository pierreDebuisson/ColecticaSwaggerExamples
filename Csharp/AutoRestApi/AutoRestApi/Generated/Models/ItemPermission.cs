// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApiRestColectica.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ItemPermission
    {
        /// <summary>
        /// Initializes a new instance of the ItemPermission class.
        /// </summary>
        public ItemPermission()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ItemPermission class.
        /// </summary>
        /// <param name="permission">Possible values include: 'DeniedRead',
        /// 'DeniedWrite', 'Denied', 'ExclusiveRead', 'ExclusiveWrite',
        /// 'Exclusive'</param>
        public ItemPermission(long? permissionId = default(long?), string roleName = default(string), string permission = default(string), System.Guid? identifier = default(System.Guid?), string agencyId = default(string), long? version = default(long?))
        {
            PermissionId = permissionId;
            RoleName = roleName;
            Permission = permission;
            Identifier = identifier;
            AgencyId = agencyId;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PermissionId")]
        public long? PermissionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RoleName")]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'DeniedRead', 'DeniedWrite',
        /// 'Denied', 'ExclusiveRead', 'ExclusiveWrite', 'Exclusive'
        /// </summary>
        [JsonProperty(PropertyName = "Permission")]
        public string Permission { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Identifier")]
        public System.Guid? Identifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AgencyId")]
        public string AgencyId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Version")]
        public long? Version { get; set; }

    }
}