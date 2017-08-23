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
import io.swagger.client.model.RelationshipFacet;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

/**
 * GetTypedRelationshipsRequest
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-08-17T15:59:17.406-05:00")
public class GetTypedRelationshipsRequest {
  @SerializedName("RootItems")
  private List<IdentifierInRequest> rootItems = null;

  @SerializedName("Facet")
  private RelationshipFacet facet = null;

  public GetTypedRelationshipsRequest rootItems(List<IdentifierInRequest> rootItems) {
    this.rootItems = rootItems;
    return this;
  }

  public GetTypedRelationshipsRequest addRootItemsItem(IdentifierInRequest rootItemsItem) {
    if (this.rootItems == null) {
      this.rootItems = new ArrayList<IdentifierInRequest>();
    }
    this.rootItems.add(rootItemsItem);
    return this;
  }

   /**
   * Get rootItems
   * @return rootItems
  **/
  @ApiModelProperty(value = "")
  public List<IdentifierInRequest> getRootItems() {
    return rootItems;
  }

  public void setRootItems(List<IdentifierInRequest> rootItems) {
    this.rootItems = rootItems;
  }

  public GetTypedRelationshipsRequest facet(RelationshipFacet facet) {
    this.facet = facet;
    return this;
  }

   /**
   * Get facet
   * @return facet
  **/
  @ApiModelProperty(value = "")
  public RelationshipFacet getFacet() {
    return facet;
  }

  public void setFacet(RelationshipFacet facet) {
    this.facet = facet;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    GetTypedRelationshipsRequest getTypedRelationshipsRequest = (GetTypedRelationshipsRequest) o;
    return Objects.equals(this.rootItems, getTypedRelationshipsRequest.rootItems) &&
        Objects.equals(this.facet, getTypedRelationshipsRequest.facet);
  }

  @Override
  public int hashCode() {
    return Objects.hash(rootItems, facet);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GetTypedRelationshipsRequest {\n");
    
    sb.append("    rootItems: ").append(toIndentedString(rootItems)).append("\n");
    sb.append("    facet: ").append(toIndentedString(facet)).append("\n");
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

