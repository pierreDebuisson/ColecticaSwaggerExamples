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
import io.swagger.client.model.IdentifierInRequest;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

/**
 * UpdateStateRequest
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-08-17T15:59:17.406-05:00")
public class UpdateStateRequest {
  @SerializedName("Ids")
  private List<IdentifierInRequest> ids = null;

  @SerializedName("State")
  private Boolean state = null;

  @SerializedName("ApplyToAllVersions")
  private Boolean applyToAllVersions = null;

  public UpdateStateRequest ids(List<IdentifierInRequest> ids) {
    this.ids = ids;
    return this;
  }

  public UpdateStateRequest addIdsItem(IdentifierInRequest idsItem) {
    if (this.ids == null) {
      this.ids = new ArrayList<IdentifierInRequest>();
    }
    this.ids.add(idsItem);
    return this;
  }

   /**
   * Get ids
   * @return ids
  **/
  @ApiModelProperty(value = "")
  public List<IdentifierInRequest> getIds() {
    return ids;
  }

  public void setIds(List<IdentifierInRequest> ids) {
    this.ids = ids;
  }

  public UpdateStateRequest state(Boolean state) {
    this.state = state;
    return this;
  }

   /**
   * Get state
   * @return state
  **/
  @ApiModelProperty(value = "")
  public Boolean getState() {
    return state;
  }

  public void setState(Boolean state) {
    this.state = state;
  }

  public UpdateStateRequest applyToAllVersions(Boolean applyToAllVersions) {
    this.applyToAllVersions = applyToAllVersions;
    return this;
  }

   /**
   * Get applyToAllVersions
   * @return applyToAllVersions
  **/
  @ApiModelProperty(value = "")
  public Boolean getApplyToAllVersions() {
    return applyToAllVersions;
  }

  public void setApplyToAllVersions(Boolean applyToAllVersions) {
    this.applyToAllVersions = applyToAllVersions;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UpdateStateRequest updateStateRequest = (UpdateStateRequest) o;
    return Objects.equals(this.ids, updateStateRequest.ids) &&
        Objects.equals(this.state, updateStateRequest.state) &&
        Objects.equals(this.applyToAllVersions, updateStateRequest.applyToAllVersions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(ids, state, applyToAllVersions);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UpdateStateRequest {\n");
    
    sb.append("    ids: ").append(toIndentedString(ids)).append("\n");
    sb.append("    state: ").append(toIndentedString(state)).append("\n");
    sb.append("    applyToAllVersions: ").append(toIndentedString(applyToAllVersions)).append("\n");
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

