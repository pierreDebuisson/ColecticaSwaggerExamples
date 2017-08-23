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
 * GetLatestVersionNumbersRequest
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-08-17T15:59:17.406-05:00")
public class GetLatestVersionNumbersRequest {
  @SerializedName("Identifiers")
  private List<IdentifierInRequest> identifiers = null;

  public GetLatestVersionNumbersRequest identifiers(List<IdentifierInRequest> identifiers) {
    this.identifiers = identifiers;
    return this;
  }

  public GetLatestVersionNumbersRequest addIdentifiersItem(IdentifierInRequest identifiersItem) {
    if (this.identifiers == null) {
      this.identifiers = new ArrayList<IdentifierInRequest>();
    }
    this.identifiers.add(identifiersItem);
    return this;
  }

   /**
   * Get identifiers
   * @return identifiers
  **/
  @ApiModelProperty(value = "")
  public List<IdentifierInRequest> getIdentifiers() {
    return identifiers;
  }

  public void setIdentifiers(List<IdentifierInRequest> identifiers) {
    this.identifiers = identifiers;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    GetLatestVersionNumbersRequest getLatestVersionNumbersRequest = (GetLatestVersionNumbersRequest) o;
    return Objects.equals(this.identifiers, getLatestVersionNumbersRequest.identifiers);
  }

  @Override
  public int hashCode() {
    return Objects.hash(identifiers);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GetLatestVersionNumbersRequest {\n");
    
    sb.append("    identifiers: ").append(toIndentedString(identifiers)).append("\n");
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

