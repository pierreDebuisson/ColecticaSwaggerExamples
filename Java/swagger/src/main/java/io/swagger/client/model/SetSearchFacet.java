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
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;

/**
 * SetSearchFacet
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-08-17T15:59:17.406-05:00")
public class SetSearchFacet {
  @SerializedName("ItemTypes")
  private List<UUID> itemTypes = null;

  @SerializedName("LeafItemTypes")
  private List<UUID> leafItemTypes = null;

  @SerializedName("Predicate")
  private UUID predicate = null;

  @SerializedName("ReverseTraversal")
  private Boolean reverseTraversal = null;

  public SetSearchFacet itemTypes(List<UUID> itemTypes) {
    this.itemTypes = itemTypes;
    return this;
  }

  public SetSearchFacet addItemTypesItem(UUID itemTypesItem) {
    if (this.itemTypes == null) {
      this.itemTypes = new ArrayList<UUID>();
    }
    this.itemTypes.add(itemTypesItem);
    return this;
  }

   /**
   * Get itemTypes
   * @return itemTypes
  **/
  @ApiModelProperty(value = "")
  public List<UUID> getItemTypes() {
    return itemTypes;
  }

  public void setItemTypes(List<UUID> itemTypes) {
    this.itemTypes = itemTypes;
  }

  public SetSearchFacet leafItemTypes(List<UUID> leafItemTypes) {
    this.leafItemTypes = leafItemTypes;
    return this;
  }

  public SetSearchFacet addLeafItemTypesItem(UUID leafItemTypesItem) {
    if (this.leafItemTypes == null) {
      this.leafItemTypes = new ArrayList<UUID>();
    }
    this.leafItemTypes.add(leafItemTypesItem);
    return this;
  }

   /**
   * Get leafItemTypes
   * @return leafItemTypes
  **/
  @ApiModelProperty(value = "")
  public List<UUID> getLeafItemTypes() {
    return leafItemTypes;
  }

  public void setLeafItemTypes(List<UUID> leafItemTypes) {
    this.leafItemTypes = leafItemTypes;
  }

  public SetSearchFacet predicate(UUID predicate) {
    this.predicate = predicate;
    return this;
  }

   /**
   * Get predicate
   * @return predicate
  **/
  @ApiModelProperty(value = "")
  public UUID getPredicate() {
    return predicate;
  }

  public void setPredicate(UUID predicate) {
    this.predicate = predicate;
  }

  public SetSearchFacet reverseTraversal(Boolean reverseTraversal) {
    this.reverseTraversal = reverseTraversal;
    return this;
  }

   /**
   * Get reverseTraversal
   * @return reverseTraversal
  **/
  @ApiModelProperty(value = "")
  public Boolean getReverseTraversal() {
    return reverseTraversal;
  }

  public void setReverseTraversal(Boolean reverseTraversal) {
    this.reverseTraversal = reverseTraversal;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SetSearchFacet setSearchFacet = (SetSearchFacet) o;
    return Objects.equals(this.itemTypes, setSearchFacet.itemTypes) &&
        Objects.equals(this.leafItemTypes, setSearchFacet.leafItemTypes) &&
        Objects.equals(this.predicate, setSearchFacet.predicate) &&
        Objects.equals(this.reverseTraversal, setSearchFacet.reverseTraversal);
  }

  @Override
  public int hashCode() {
    return Objects.hash(itemTypes, leafItemTypes, predicate, reverseTraversal);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SetSearchFacet {\n");
    
    sb.append("    itemTypes: ").append(toIndentedString(itemTypes)).append("\n");
    sb.append("    leafItemTypes: ").append(toIndentedString(leafItemTypes)).append("\n");
    sb.append("    predicate: ").append(toIndentedString(predicate)).append("\n");
    sb.append("    reverseTraversal: ").append(toIndentedString(reverseTraversal)).append("\n");
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

