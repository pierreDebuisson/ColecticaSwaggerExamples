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
import io.swagger.client.model.IdentifierTriple;
import io.swagger.client.model.Relationship;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;

/**
 * AdjacencyMatrix
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-08-17T15:59:17.406-05:00")
public class AdjacencyMatrix {
  @SerializedName("Edges")
  private List<Relationship> edges = null;

  @SerializedName("Roots")
  private List<IdentifierTriple> roots = null;

  @SerializedName("ReverseTraversal")
  private Boolean reverseTraversal = null;

  @SerializedName("Predicate")
  private UUID predicate = null;

  public AdjacencyMatrix edges(List<Relationship> edges) {
    this.edges = edges;
    return this;
  }

  public AdjacencyMatrix addEdgesItem(Relationship edgesItem) {
    if (this.edges == null) {
      this.edges = new ArrayList<Relationship>();
    }
    this.edges.add(edgesItem);
    return this;
  }

   /**
   * Get edges
   * @return edges
  **/
  @ApiModelProperty(value = "")
  public List<Relationship> getEdges() {
    return edges;
  }

  public void setEdges(List<Relationship> edges) {
    this.edges = edges;
  }

  public AdjacencyMatrix roots(List<IdentifierTriple> roots) {
    this.roots = roots;
    return this;
  }

  public AdjacencyMatrix addRootsItem(IdentifierTriple rootsItem) {
    if (this.roots == null) {
      this.roots = new ArrayList<IdentifierTriple>();
    }
    this.roots.add(rootsItem);
    return this;
  }

   /**
   * Get roots
   * @return roots
  **/
  @ApiModelProperty(value = "")
  public List<IdentifierTriple> getRoots() {
    return roots;
  }

  public void setRoots(List<IdentifierTriple> roots) {
    this.roots = roots;
  }

  public AdjacencyMatrix reverseTraversal(Boolean reverseTraversal) {
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

  public AdjacencyMatrix predicate(UUID predicate) {
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


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AdjacencyMatrix adjacencyMatrix = (AdjacencyMatrix) o;
    return Objects.equals(this.edges, adjacencyMatrix.edges) &&
        Objects.equals(this.roots, adjacencyMatrix.roots) &&
        Objects.equals(this.reverseTraversal, adjacencyMatrix.reverseTraversal) &&
        Objects.equals(this.predicate, adjacencyMatrix.predicate);
  }

  @Override
  public int hashCode() {
    return Objects.hash(edges, roots, reverseTraversal, predicate);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AdjacencyMatrix {\n");
    
    sb.append("    edges: ").append(toIndentedString(edges)).append("\n");
    sb.append("    roots: ").append(toIndentedString(roots)).append("\n");
    sb.append("    reverseTraversal: ").append(toIndentedString(reverseTraversal)).append("\n");
    sb.append("    predicate: ").append(toIndentedString(predicate)).append("\n");
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

