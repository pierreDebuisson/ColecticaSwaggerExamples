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
import io.swagger.client.model.TypedIdTriple;
import java.io.IOException;

/**
 * TypedRelationship
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-08-17T15:59:17.406-05:00")
public class TypedRelationship {
  @SerializedName("Subject")
  private TypedIdTriple subject = null;

  @SerializedName("Object")
  private TypedIdTriple object = null;

  public TypedRelationship subject(TypedIdTriple subject) {
    this.subject = subject;
    return this;
  }

   /**
   * Get subject
   * @return subject
  **/
  @ApiModelProperty(value = "")
  public TypedIdTriple getSubject() {
    return subject;
  }

  public void setSubject(TypedIdTriple subject) {
    this.subject = subject;
  }

  public TypedRelationship object(TypedIdTriple object) {
    this.object = object;
    return this;
  }

   /**
   * Get object
   * @return object
  **/
  @ApiModelProperty(value = "")
  public TypedIdTriple getObject() {
    return object;
  }

  public void setObject(TypedIdTriple object) {
    this.object = object;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TypedRelationship typedRelationship = (TypedRelationship) o;
    return Objects.equals(this.subject, typedRelationship.subject) &&
        Objects.equals(this.object, typedRelationship.object);
  }

  @Override
  public int hashCode() {
    return Objects.hash(subject, object);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TypedRelationship {\n");
    
    sb.append("    subject: ").append(toIndentedString(subject)).append("\n");
    sb.append("    object: ").append(toIndentedString(object)).append("\n");
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

