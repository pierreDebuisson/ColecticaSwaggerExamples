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
import io.swagger.client.model.Note;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.UUID;
import org.joda.time.DateTime;

/**
 * SearchResult
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-08-17T15:59:17.406-05:00")
public class SearchResult {
  @SerializedName("Summary")
  private Map<String, String> summary = null;

  @SerializedName("ItemName")
  private Map<String, String> itemName = null;

  @SerializedName("Label")
  private Map<String, String> label = null;

  @SerializedName("Description")
  private Map<String, String> description = null;

  @SerializedName("VersionRationale")
  private Map<String, String> versionRationale = null;

  @SerializedName("MetadataRank")
  private Long metadataRank = null;

  @SerializedName("RepositoryName")
  private String repositoryName = null;

  @SerializedName("IsAuthoritative")
  private Boolean isAuthoritative = null;

  @SerializedName("Tags")
  private List<String> tags = null;

  @SerializedName("ItemType")
  private UUID itemType = null;

  @SerializedName("AgencyId")
  private String agencyId = null;

  @SerializedName("Version")
  private Long version = null;

  @SerializedName("Identifier")
  private UUID identifier = null;

  @SerializedName("Item")
  private String item = null;

  @SerializedName("Notes")
  private List<Note> notes = null;

  @SerializedName("VersionDate")
  private DateTime versionDate = null;

  @SerializedName("VersionResponsibility")
  private String versionResponsibility = null;

  @SerializedName("IsPublished")
  private Boolean isPublished = null;

  @SerializedName("IsDeprecated")
  private Boolean isDeprecated = null;

  @SerializedName("IsProvisional")
  private Boolean isProvisional = null;

  @SerializedName("ItemFormat")
  private UUID itemFormat = null;

  public SearchResult summary(Map<String, String> summary) {
    this.summary = summary;
    return this;
  }

  public SearchResult putSummaryItem(String key, String summaryItem) {
    if (this.summary == null) {
      this.summary = new HashMap<String, String>();
    }
    this.summary.put(key, summaryItem);
    return this;
  }

   /**
   * Get summary
   * @return summary
  **/
  @ApiModelProperty(value = "")
  public Map<String, String> getSummary() {
    return summary;
  }

  public void setSummary(Map<String, String> summary) {
    this.summary = summary;
  }

  public SearchResult itemName(Map<String, String> itemName) {
    this.itemName = itemName;
    return this;
  }

  public SearchResult putItemNameItem(String key, String itemNameItem) {
    if (this.itemName == null) {
      this.itemName = new HashMap<String, String>();
    }
    this.itemName.put(key, itemNameItem);
    return this;
  }

   /**
   * Get itemName
   * @return itemName
  **/
  @ApiModelProperty(value = "")
  public Map<String, String> getItemName() {
    return itemName;
  }

  public void setItemName(Map<String, String> itemName) {
    this.itemName = itemName;
  }

  public SearchResult label(Map<String, String> label) {
    this.label = label;
    return this;
  }

  public SearchResult putLabelItem(String key, String labelItem) {
    if (this.label == null) {
      this.label = new HashMap<String, String>();
    }
    this.label.put(key, labelItem);
    return this;
  }

   /**
   * Get label
   * @return label
  **/
  @ApiModelProperty(value = "")
  public Map<String, String> getLabel() {
    return label;
  }

  public void setLabel(Map<String, String> label) {
    this.label = label;
  }

  public SearchResult description(Map<String, String> description) {
    this.description = description;
    return this;
  }

  public SearchResult putDescriptionItem(String key, String descriptionItem) {
    if (this.description == null) {
      this.description = new HashMap<String, String>();
    }
    this.description.put(key, descriptionItem);
    return this;
  }

   /**
   * Get description
   * @return description
  **/
  @ApiModelProperty(value = "")
  public Map<String, String> getDescription() {
    return description;
  }

  public void setDescription(Map<String, String> description) {
    this.description = description;
  }

  public SearchResult versionRationale(Map<String, String> versionRationale) {
    this.versionRationale = versionRationale;
    return this;
  }

  public SearchResult putVersionRationaleItem(String key, String versionRationaleItem) {
    if (this.versionRationale == null) {
      this.versionRationale = new HashMap<String, String>();
    }
    this.versionRationale.put(key, versionRationaleItem);
    return this;
  }

   /**
   * Get versionRationale
   * @return versionRationale
  **/
  @ApiModelProperty(value = "")
  public Map<String, String> getVersionRationale() {
    return versionRationale;
  }

  public void setVersionRationale(Map<String, String> versionRationale) {
    this.versionRationale = versionRationale;
  }

  public SearchResult metadataRank(Long metadataRank) {
    this.metadataRank = metadataRank;
    return this;
  }

   /**
   * Get metadataRank
   * @return metadataRank
  **/
  @ApiModelProperty(value = "")
  public Long getMetadataRank() {
    return metadataRank;
  }

  public void setMetadataRank(Long metadataRank) {
    this.metadataRank = metadataRank;
  }

  public SearchResult repositoryName(String repositoryName) {
    this.repositoryName = repositoryName;
    return this;
  }

   /**
   * Get repositoryName
   * @return repositoryName
  **/
  @ApiModelProperty(value = "")
  public String getRepositoryName() {
    return repositoryName;
  }

  public void setRepositoryName(String repositoryName) {
    this.repositoryName = repositoryName;
  }

  public SearchResult isAuthoritative(Boolean isAuthoritative) {
    this.isAuthoritative = isAuthoritative;
    return this;
  }

   /**
   * Get isAuthoritative
   * @return isAuthoritative
  **/
  @ApiModelProperty(value = "")
  public Boolean getIsAuthoritative() {
    return isAuthoritative;
  }

  public void setIsAuthoritative(Boolean isAuthoritative) {
    this.isAuthoritative = isAuthoritative;
  }

  public SearchResult tags(List<String> tags) {
    this.tags = tags;
    return this;
  }

  public SearchResult addTagsItem(String tagsItem) {
    if (this.tags == null) {
      this.tags = new ArrayList<String>();
    }
    this.tags.add(tagsItem);
    return this;
  }

   /**
   * Get tags
   * @return tags
  **/
  @ApiModelProperty(value = "")
  public List<String> getTags() {
    return tags;
  }

  public void setTags(List<String> tags) {
    this.tags = tags;
  }

  public SearchResult itemType(UUID itemType) {
    this.itemType = itemType;
    return this;
  }

   /**
   * Get itemType
   * @return itemType
  **/
  @ApiModelProperty(value = "")
  public UUID getItemType() {
    return itemType;
  }

  public void setItemType(UUID itemType) {
    this.itemType = itemType;
  }

  public SearchResult agencyId(String agencyId) {
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

  public SearchResult version(Long version) {
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

  public SearchResult identifier(UUID identifier) {
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

  public SearchResult item(String item) {
    this.item = item;
    return this;
  }

   /**
   * Get item
   * @return item
  **/
  @ApiModelProperty(value = "")
  public String getItem() {
    return item;
  }

  public void setItem(String item) {
    this.item = item;
  }

  public SearchResult notes(List<Note> notes) {
    this.notes = notes;
    return this;
  }

  public SearchResult addNotesItem(Note notesItem) {
    if (this.notes == null) {
      this.notes = new ArrayList<Note>();
    }
    this.notes.add(notesItem);
    return this;
  }

   /**
   * Get notes
   * @return notes
  **/
  @ApiModelProperty(value = "")
  public List<Note> getNotes() {
    return notes;
  }

  public void setNotes(List<Note> notes) {
    this.notes = notes;
  }

  public SearchResult versionDate(DateTime versionDate) {
    this.versionDate = versionDate;
    return this;
  }

   /**
   * Get versionDate
   * @return versionDate
  **/
  @ApiModelProperty(value = "")
  public DateTime getVersionDate() {
    return versionDate;
  }

  public void setVersionDate(DateTime versionDate) {
    this.versionDate = versionDate;
  }

  public SearchResult versionResponsibility(String versionResponsibility) {
    this.versionResponsibility = versionResponsibility;
    return this;
  }

   /**
   * Get versionResponsibility
   * @return versionResponsibility
  **/
  @ApiModelProperty(value = "")
  public String getVersionResponsibility() {
    return versionResponsibility;
  }

  public void setVersionResponsibility(String versionResponsibility) {
    this.versionResponsibility = versionResponsibility;
  }

  public SearchResult isPublished(Boolean isPublished) {
    this.isPublished = isPublished;
    return this;
  }

   /**
   * Get isPublished
   * @return isPublished
  **/
  @ApiModelProperty(value = "")
  public Boolean getIsPublished() {
    return isPublished;
  }

  public void setIsPublished(Boolean isPublished) {
    this.isPublished = isPublished;
  }

  public SearchResult isDeprecated(Boolean isDeprecated) {
    this.isDeprecated = isDeprecated;
    return this;
  }

   /**
   * Get isDeprecated
   * @return isDeprecated
  **/
  @ApiModelProperty(value = "")
  public Boolean getIsDeprecated() {
    return isDeprecated;
  }

  public void setIsDeprecated(Boolean isDeprecated) {
    this.isDeprecated = isDeprecated;
  }

  public SearchResult isProvisional(Boolean isProvisional) {
    this.isProvisional = isProvisional;
    return this;
  }

   /**
   * Get isProvisional
   * @return isProvisional
  **/
  @ApiModelProperty(value = "")
  public Boolean getIsProvisional() {
    return isProvisional;
  }

  public void setIsProvisional(Boolean isProvisional) {
    this.isProvisional = isProvisional;
  }

  public SearchResult itemFormat(UUID itemFormat) {
    this.itemFormat = itemFormat;
    return this;
  }

   /**
   * Get itemFormat
   * @return itemFormat
  **/
  @ApiModelProperty(value = "")
  public UUID getItemFormat() {
    return itemFormat;
  }

  public void setItemFormat(UUID itemFormat) {
    this.itemFormat = itemFormat;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SearchResult searchResult = (SearchResult) o;
    return Objects.equals(this.summary, searchResult.summary) &&
        Objects.equals(this.itemName, searchResult.itemName) &&
        Objects.equals(this.label, searchResult.label) &&
        Objects.equals(this.description, searchResult.description) &&
        Objects.equals(this.versionRationale, searchResult.versionRationale) &&
        Objects.equals(this.metadataRank, searchResult.metadataRank) &&
        Objects.equals(this.repositoryName, searchResult.repositoryName) &&
        Objects.equals(this.isAuthoritative, searchResult.isAuthoritative) &&
        Objects.equals(this.tags, searchResult.tags) &&
        Objects.equals(this.itemType, searchResult.itemType) &&
        Objects.equals(this.agencyId, searchResult.agencyId) &&
        Objects.equals(this.version, searchResult.version) &&
        Objects.equals(this.identifier, searchResult.identifier) &&
        Objects.equals(this.item, searchResult.item) &&
        Objects.equals(this.notes, searchResult.notes) &&
        Objects.equals(this.versionDate, searchResult.versionDate) &&
        Objects.equals(this.versionResponsibility, searchResult.versionResponsibility) &&
        Objects.equals(this.isPublished, searchResult.isPublished) &&
        Objects.equals(this.isDeprecated, searchResult.isDeprecated) &&
        Objects.equals(this.isProvisional, searchResult.isProvisional) &&
        Objects.equals(this.itemFormat, searchResult.itemFormat);
  }

  @Override
  public int hashCode() {
    return Objects.hash(summary, itemName, label, description, versionRationale, metadataRank, repositoryName, isAuthoritative, tags, itemType, agencyId, version, identifier, item, notes, versionDate, versionResponsibility, isPublished, isDeprecated, isProvisional, itemFormat);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SearchResult {\n");
    
    sb.append("    summary: ").append(toIndentedString(summary)).append("\n");
    sb.append("    itemName: ").append(toIndentedString(itemName)).append("\n");
    sb.append("    label: ").append(toIndentedString(label)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    versionRationale: ").append(toIndentedString(versionRationale)).append("\n");
    sb.append("    metadataRank: ").append(toIndentedString(metadataRank)).append("\n");
    sb.append("    repositoryName: ").append(toIndentedString(repositoryName)).append("\n");
    sb.append("    isAuthoritative: ").append(toIndentedString(isAuthoritative)).append("\n");
    sb.append("    tags: ").append(toIndentedString(tags)).append("\n");
    sb.append("    itemType: ").append(toIndentedString(itemType)).append("\n");
    sb.append("    agencyId: ").append(toIndentedString(agencyId)).append("\n");
    sb.append("    version: ").append(toIndentedString(version)).append("\n");
    sb.append("    identifier: ").append(toIndentedString(identifier)).append("\n");
    sb.append("    item: ").append(toIndentedString(item)).append("\n");
    sb.append("    notes: ").append(toIndentedString(notes)).append("\n");
    sb.append("    versionDate: ").append(toIndentedString(versionDate)).append("\n");
    sb.append("    versionResponsibility: ").append(toIndentedString(versionResponsibility)).append("\n");
    sb.append("    isPublished: ").append(toIndentedString(isPublished)).append("\n");
    sb.append("    isDeprecated: ").append(toIndentedString(isDeprecated)).append("\n");
    sb.append("    isProvisional: ").append(toIndentedString(isProvisional)).append("\n");
    sb.append("    itemFormat: ").append(toIndentedString(itemFormat)).append("\n");
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

