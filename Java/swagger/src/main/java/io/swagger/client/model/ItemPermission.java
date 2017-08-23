/*
 * Colectica Repository REST API
 * Colectica Repository REST API
 *
 * OpenAPI spec version: v1
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package io.swagger.client.model;

import java.util.Objects;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.UUID;

/**
 * ItemPermission
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-08-17T15:59:17.406-05:00")
public class ItemPermission {
  @SerializedName("PermissionId")
  private Long permissionId = null;

  @SerializedName("RoleName")
  private String roleName = null;

  /**
   * Gets or Sets permission
   */
  @JsonAdapter(PermissionEnum.Adapter.class)
  public enum PermissionEnum {
    DENIEDREAD("DeniedRead"),
    
    DENIEDWRITE("DeniedWrite"),
    
    DENIED("Denied"),
    
    EXCLUSIVEREAD("ExclusiveRead"),
    
    EXCLUSIVEWRITE("ExclusiveWrite"),
    
    EXCLUSIVE("Exclusive");

    private String value;

    PermissionEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static PermissionEnum fromValue(String text) {
      for (PermissionEnum b : PermissionEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<PermissionEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final PermissionEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public PermissionEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return PermissionEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("Permission")
  private PermissionEnum permission = null;

  @SerializedName("Identifier")
  private UUID identifier = null;

  @SerializedName("AgencyId")
  private String agencyId = null;

  @SerializedName("Version")
  private Long version = null;

  public ItemPermission permissionId(Long permissionId) {
    this.permissionId = permissionId;
    return this;
  }

   /**
   * Get permissionId
   * @return permissionId
  **/
  @ApiModelProperty(value = "")
  public Long getPermissionId() {
    return permissionId;
  }

  public void setPermissionId(Long permissionId) {
    this.permissionId = permissionId;
  }

  public ItemPermission roleName(String roleName) {
    this.roleName = roleName;
    return this;
  }

   /**
   * Get roleName
   * @return roleName
  **/
  @ApiModelProperty(value = "")
  public String getRoleName() {
    return roleName;
  }

  public void setRoleName(String roleName) {
    this.roleName = roleName;
  }

  public ItemPermission permission(PermissionEnum permission) {
    this.permission = permission;
    return this;
  }

   /**
   * Get permission
   * @return permission
  **/
  @ApiModelProperty(value = "")
  public PermissionEnum getPermission() {
    return permission;
  }

  public void setPermission(PermissionEnum permission) {
    this.permission = permission;
  }

  public ItemPermission identifier(UUID identifier) {
    this.identifier = identifier;
    return this;
  }

   /**
   * Get identifier
   * @return identifier
  **/
  @ApiModelProperty(value = "")
  public UUID getIdentifier() {
    return identifier;
  }

  public void setIdentifier(UUID identifier) {
    this.identifier = identifier;
  }

  public ItemPermission agencyId(String agencyId) {
    this.agencyId = agencyId;
    return this;
  }

   /**
   * Get agencyId
   * @return agencyId
  **/
  @ApiModelProperty(value = "")
  public String getAgencyId() {
    return agencyId;
  }

  public void setAgencyId(String agencyId) {
    this.agencyId = agencyId;
  }

  public ItemPermission version(Long version) {
    this.version = version;
    return this;
  }

   /**
   * Get version
   * @return version
  **/
  @ApiModelProperty(value = "")
  public Long getVersion() {
    return version;
  }

  public void setVersion(Long version) {
    this.version = version;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ItemPermission itemPermission = (ItemPermission) o;
    return Objects.equals(this.permissionId, itemPermission.permissionId) &&
        Objects.equals(this.roleName, itemPermission.roleName) &&
        Objects.equals(this.permission, itemPermission.permission) &&
        Objects.equals(this.identifier, itemPermission.identifier) &&
        Objects.equals(this.agencyId, itemPermission.agencyId) &&
        Objects.equals(this.version, itemPermission.version);
  }

  @Override
  public int hashCode() {
    return Objects.hash(permissionId, roleName, permission, identifier, agencyId, version);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ItemPermission {\n");
    
    sb.append("    permissionId: ").append(toIndentedString(permissionId)).append("\n");
    sb.append("    roleName: ").append(toIndentedString(roleName)).append("\n");
    sb.append("    permission: ").append(toIndentedString(permission)).append("\n");
    sb.append("    identifier: ").append(toIndentedString(identifier)).append("\n");
    sb.append("    agencyId: ").append(toIndentedString(agencyId)).append("\n");
    sb.append("    version: ").append(toIndentedString(version)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
  
}
