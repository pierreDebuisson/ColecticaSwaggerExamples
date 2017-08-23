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
import java.io.IOException;

/**
 * Note
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-08-17T15:59:17.406-05:00")
public class Note {
  @SerializedName("Item1")
  private IdentifierTriple item1 = null;

  /**
   * Gets or Sets item2
   */
  @JsonAdapter(Item2Enum.Adapter.class)
  public enum Item2Enum {
    PROCESSING("Processing"),
    
    FOOTNOTE("Footnote"),
    
    ADDENDUM("Addendum"),
    
    SYSTEM("System"),
    
    PROBLEM("Problem"),
    
    COMMENT("Comment"),
    
    OTHER("Other");

    private String value;

    Item2Enum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static Item2Enum fromValue(String text) {
      for (Item2Enum b : Item2Enum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<Item2Enum> {
      @Override
      public void write(final JsonWriter jsonWriter, final Item2Enum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public Item2Enum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return Item2Enum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("Item2")
  private Item2Enum item2 = null;

  @SerializedName("Item3")
  private String item3 = null;

  @SerializedName("Item4")
  private String item4 = null;

  public Note item1(IdentifierTriple item1) {
    this.item1 = item1;
    return this;
  }

   /**
   * Get item1
   * @return item1
  **/
  @ApiModelProperty(value = "")
  public IdentifierTriple getItem1() {
    return item1;
  }

  public void setItem1(IdentifierTriple item1) {
    this.item1 = item1;
  }

   /**
   * Get item2
   * @return item2
  **/
  @ApiModelProperty(value = "")
  public Item2Enum getItem2() {
    return item2;
  }

   /**
   * Get item3
   * @return item3
  **/
  @ApiModelProperty(value = "")
  public String getItem3() {
    return item3;
  }

   /**
   * Get item4
   * @return item4
  **/
  @ApiModelProperty(value = "")
  public String getItem4() {
    return item4;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Note note = (Note) o;
    return Objects.equals(this.item1, note.item1) &&
        Objects.equals(this.item2, note.item2) &&
        Objects.equals(this.item3, note.item3) &&
        Objects.equals(this.item4, note.item4);
  }

  @Override
  public int hashCode() {
    return Objects.hash(item1, item2, item3, item4);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Note {\n");
    
    sb.append("    item1: ").append(toIndentedString(item1)).append("\n");
    sb.append("    item2: ").append(toIndentedString(item2)).append("\n");
    sb.append("    item3: ").append(toIndentedString(item3)).append("\n");
    sb.append("    item4: ").append(toIndentedString(item4)).append("\n");
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
