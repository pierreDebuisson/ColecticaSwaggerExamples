# swagger-java-client

## Requirements

Building the API client library requires [Maven](https://maven.apache.org/) to be installed.

## Installation

To install the API client library to your local Maven repository, simply execute:

```shell
mvn install
```

To deploy it to a remote Maven repository instead, configure the settings of the repository and execute:

```shell
mvn deploy
```

Refer to the [official documentation](https://maven.apache.org/plugins/maven-deploy-plugin/usage.html) for more information.

### Maven users

Add this dependency to your project's POM:

```xml
<dependency>
    <groupId>io.swagger</groupId>
    <artifactId>swagger-java-client</artifactId>
    <version>1.0.0</version>
    <scope>compile</scope>
</dependency>
```

### Gradle users

Add this dependency to your project's build file:

```groovy
compile "io.swagger:swagger-java-client:1.0.0"
```

### Others

At first generate the JAR by executing:

    mvn package

Then manually install the following JARs:

* target/swagger-java-client-1.0.0.jar
* target/lib/*.jar

## Getting Started

Please follow the [installation](#installation) instruction and execute the following Java code:

```java

import io.swagger.client.*;
import io.swagger.client.auth.*;
import io.swagger.client.model.*;
import io.swagger.client.api.AgencyApi;

import java.io.File;
import java.util.*;

public class AgencyApiExample {

    public static void main(String[] args) {
        
        AgencyApi apiInstance = new AgencyApi();
        String agency = "agency_example"; // String | 
        try {
            apiInstance.apiV1AgencyByAgencyDelete(agency);
        } catch (ApiException e) {
            System.err.println("Exception when calling AgencyApi#apiV1AgencyByAgencyDelete");
            e.printStackTrace();
        }
    }
}

```

## Documentation for API Endpoints

All URIs are relative to *https://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AgencyApi* | [**apiV1AgencyByAgencyDelete**](docs/AgencyApi.md#apiV1AgencyByAgencyDelete) | **DELETE** /api/v1/agency/{agency} | 
*AgencyApi* | [**apiV1AgencyPost**](docs/AgencyApi.md#apiV1AgencyPost) | **POST** /api/v1/agency | 
*CommentApi* | [**apiV1ItemByAgencyByIdByVersionCommentPost**](docs/CommentApi.md#apiV1ItemByAgencyByIdByVersionCommentPost) | **POST** /api/v1/item/{agency}/{id}/{version}/comment | 
*CommentApi* | [**apiV1ItemByAgencyByIdCommentGet**](docs/CommentApi.md#apiV1ItemByAgencyByIdCommentGet) | **GET** /api/v1/item/{agency}/{id}/comment | 
*EventApi* | [**apiV1EventPost**](docs/EventApi.md#apiV1EventPost) | **POST** /api/v1/event | 
*ItemApi* | [**apiV1ItemByAgencyByIdByVersionDescriptionGet**](docs/ItemApi.md#apiV1ItemByAgencyByIdByVersionDescriptionGet) | **GET** /api/v1/item/{agency}/{id}/{version}/description | 
*ItemApi* | [**apiV1ItemByAgencyByIdByVersionGet**](docs/ItemApi.md#apiV1ItemByAgencyByIdByVersionGet) | **GET** /api/v1/item/{agency}/{id}/{version} | 
*ItemApi* | [**apiV1ItemByAgencyByIdGet**](docs/ItemApi.md#apiV1ItemByAgencyByIdGet) | **GET** /api/v1/item/{agency}/{id} | 
*ItemApi* | [**apiV1ItemByAgencyByIdHistoryGet**](docs/ItemApi.md#apiV1ItemByAgencyByIdHistoryGet) | **GET** /api/v1/item/{agency}/{id}/history | 
*ItemApi* | [**apiV1ItemGetDescriptionsPost**](docs/ItemApi.md#apiV1ItemGetDescriptionsPost) | **POST** /api/v1/item/_getDescriptions | 
*ItemApi* | [**apiV1ItemGetListLatestPost**](docs/ItemApi.md#apiV1ItemGetListLatestPost) | **POST** /api/v1/item/_getListLatest | 
*ItemApi* | [**apiV1ItemGetListPost**](docs/ItemApi.md#apiV1ItemGetListPost) | **POST** /api/v1/item/_getList | 
*ItemApi* | [**apiV1ItemPost**](docs/ItemApi.md#apiV1ItemPost) | **POST** /api/v1/item | 
*ItemApi* | [**apiV1ItemUpdateStatePost**](docs/ItemApi.md#apiV1ItemUpdateStatePost) | **POST** /api/v1/item/_updateState | 
*PermissionApi* | [**apiV1PermissionDeletePost**](docs/PermissionApi.md#apiV1PermissionDeletePost) | **POST** /api/v1/permission/_delete | 
*PermissionApi* | [**apiV1PermissionGetPost**](docs/PermissionApi.md#apiV1PermissionGetPost) | **POST** /api/v1/permission/_get | 
*PermissionApi* | [**apiV1PermissionPost**](docs/PermissionApi.md#apiV1PermissionPost) | **POST** /api/v1/permission | 
*QueryApi* | [**apiV1QueryPost**](docs/QueryApi.md#apiV1QueryPost) | **POST** /api/v1/_query | 
*QueryApi* | [**apiV1QueryRelationshipByobjectDescriptionsPost**](docs/QueryApi.md#apiV1QueryRelationshipByobjectDescriptionsPost) | **POST** /api/v1/_query/relationship/byobject/descriptions | 
*QueryApi* | [**apiV1QueryRelationshipByobjectPost**](docs/QueryApi.md#apiV1QueryRelationshipByobjectPost) | **POST** /api/v1/_query/relationship/byobject | 
*QueryApi* | [**apiV1QueryRelationshipBysubjectDescriptionsPost**](docs/QueryApi.md#apiV1QueryRelationshipBysubjectDescriptionsPost) | **POST** /api/v1/_query/relationship/bysubject/descriptions | 
*QueryApi* | [**apiV1QueryRelationshipBysubjectPost**](docs/QueryApi.md#apiV1QueryRelationshipBysubjectPost) | **POST** /api/v1/_query/relationship/bysubject | 
*QueryApi* | [**apiV1QueryRelationshipMatrixPost**](docs/QueryApi.md#apiV1QueryRelationshipMatrixPost) | **POST** /api/v1/_query/relationship/matrix | 
*QueryApi* | [**apiV1QueryRelationshipMatrixTypedPost**](docs/QueryApi.md#apiV1QueryRelationshipMatrixTypedPost) | **POST** /api/v1/_query/relationship/matrix/typed | 
*QueryApi* | [**apiV1QuerySetPost**](docs/QueryApi.md#apiV1QuerySetPost) | **POST** /api/v1/_query/set | 
*RatingApi* | [**apiV1ItemByAgencyByIdByVersionRatingGet**](docs/RatingApi.md#apiV1ItemByAgencyByIdByVersionRatingGet) | **GET** /api/v1/item/{agency}/{id}/{version}/rating | 
*RatingApi* | [**apiV1ItemByAgencyByIdByVersionRatingPost**](docs/RatingApi.md#apiV1ItemByAgencyByIdByVersionRatingPost) | **POST** /api/v1/item/{agency}/{id}/{version}/rating | 
*RepositoryApi* | [**apiV1RepositoryInfoGet**](docs/RepositoryApi.md#apiV1RepositoryInfoGet) | **GET** /api/v1/repository/info | 
*RepositoryApi* | [**apiV1RepositoryStatisticsGet**](docs/RepositoryApi.md#apiV1RepositoryStatisticsGet) | **GET** /api/v1/repository/statistics | 
*SetApi* | [**apiV1SetByAgencyByIdByVersionGet**](docs/SetApi.md#apiV1SetByAgencyByIdByVersionGet) | **GET** /api/v1/set/{agency}/{id}/{version} | 
*SetApi* | [**apiV1SetByAgencyByIdByVersionTypedGet**](docs/SetApi.md#apiV1SetByAgencyByIdByVersionTypedGet) | **GET** /api/v1/set/{agency}/{id}/{version}/typed | 
*SetApi* | [**apiV1SetByAgencyByIdGet**](docs/SetApi.md#apiV1SetByAgencyByIdGet) | **GET** /api/v1/set/{agency}/{id} | 
*SettingApi* | [**apiV1SettingBySettingDelete**](docs/SettingApi.md#apiV1SettingBySettingDelete) | **DELETE** /api/v1/setting/{setting} | 
*SettingApi* | [**apiV1SettingBySettingGet**](docs/SettingApi.md#apiV1SettingBySettingGet) | **GET** /api/v1/setting/{setting} | 
*SettingApi* | [**apiV1SettingGet**](docs/SettingApi.md#apiV1SettingGet) | **GET** /api/v1/setting | 
*SettingApi* | [**apiV1SettingPost**](docs/SettingApi.md#apiV1SettingPost) | **POST** /api/v1/setting | 
*TagApi* | [**apiV1ItemByAgencyByIdByVersionTagByTagDelete**](docs/TagApi.md#apiV1ItemByAgencyByIdByVersionTagByTagDelete) | **DELETE** /api/v1/item/{agency}/{id}/{version}/tag/{tag} | 
*TagApi* | [**apiV1ItemByAgencyByIdByVersionTagByTagPut**](docs/TagApi.md#apiV1ItemByAgencyByIdByVersionTagByTagPut) | **PUT** /api/v1/item/{agency}/{id}/{version}/tag/{tag} | 
*TagApi* | [**apiV1ItemByAgencyByIdByVersionTagGet**](docs/TagApi.md#apiV1ItemByAgencyByIdByVersionTagGet) | **GET** /api/v1/item/{agency}/{id}/{version}/tag | 
*VersionNumberApi* | [**apiV1ItemByAgencyByIdByTagVersionsLatestGet**](docs/VersionNumberApi.md#apiV1ItemByAgencyByIdByTagVersionsLatestGet) | **GET** /api/v1/item/{agency}/{id}/{tag}/versions/_latest | 
*VersionNumberApi* | [**apiV1ItemByAgencyByIdVersionsGet**](docs/VersionNumberApi.md#apiV1ItemByAgencyByIdVersionsGet) | **GET** /api/v1/item/{agency}/{id}/versions | 
*VersionNumberApi* | [**apiV1ItemByAgencyByIdVersionsLatestGet**](docs/VersionNumberApi.md#apiV1ItemByAgencyByIdVersionsLatestGet) | **GET** /api/v1/item/{agency}/{id}/versions/_latest | 
*VersionNumberApi* | [**apiV1ItemGetLatestVersionNumbersPost**](docs/VersionNumberApi.md#apiV1ItemGetLatestVersionNumbersPost) | **POST** /api/v1/item/_getLatestVersionNumbers | 


## Documentation for Models

 - [AdjacencyMatrix](docs/AdjacencyMatrix.md)
 - [CodeValue](docs/CodeValue.md)
 - [CommitOptions](docs/CommitOptions.md)
 - [CreateAgencyRequest](docs/CreateAgencyRequest.md)
 - [CreateCommentRequest](docs/CreateCommentRequest.md)
 - [DublinCore](docs/DublinCore.md)
 - [GetItemsRequest](docs/GetItemsRequest.md)
 - [GetLatestItemsRequest](docs/GetLatestItemsRequest.md)
 - [GetLatestVersionNumbersRequest](docs/GetLatestVersionNumbersRequest.md)
 - [GetPermissionsRequest](docs/GetPermissionsRequest.md)
 - [GetRelationshipsRequest](docs/GetRelationshipsRequest.md)
 - [GetRepositoryItemDescriptionsRequest](docs/GetRepositoryItemDescriptionsRequest.md)
 - [GetTypedRelationshipsRequest](docs/GetTypedRelationshipsRequest.md)
 - [GraphSearchRequest](docs/GraphSearchRequest.md)
 - [IdentifierInRequest](docs/IdentifierInRequest.md)
 - [IdentifierTriple](docs/IdentifierTriple.md)
 - [InternationalIdentifier](docs/InternationalIdentifier.md)
 - [ItemPermission](docs/ItemPermission.md)
 - [ItemTypePermission](docs/ItemTypePermission.md)
 - [LoggedEvent](docs/LoggedEvent.md)
 - [Note](docs/Note.md)
 - [RegisterItemsRequest](docs/RegisterItemsRequest.md)
 - [Relationship](docs/Relationship.md)
 - [RelationshipFacet](docs/RelationshipFacet.md)
 - [RemovePermissionsRequest](docs/RemovePermissionsRequest.md)
 - [RepositoryConflict](docs/RepositoryConflict.md)
 - [RepositoryInfo](docs/RepositoryInfo.md)
 - [RepositoryItem](docs/RepositoryItem.md)
 - [RepositoryItemMetadata](docs/RepositoryItemMetadata.md)
 - [RepositorySecurityContext](docs/RepositorySecurityContext.md)
 - [RepositorySetting](docs/RepositorySetting.md)
 - [RepositoryStatistics](docs/RepositoryStatistics.md)
 - [SearchRequest](docs/SearchRequest.md)
 - [SearchResponse](docs/SearchResponse.md)
 - [SearchResult](docs/SearchResult.md)
 - [SearchTypedSetRequest](docs/SearchTypedSetRequest.md)
 - [SetSearchFacet](docs/SetSearchFacet.md)
 - [TypedAdjacencyMatrix](docs/TypedAdjacencyMatrix.md)
 - [TypedIdTriple](docs/TypedIdTriple.md)
 - [TypedRelationship](docs/TypedRelationship.md)
 - [UpdateStateRequest](docs/UpdateStateRequest.md)
 - [UserComment](docs/UserComment.md)
 - [UserRating](docs/UserRating.md)


## Documentation for Authorization

Authentication schemes defined for the API:
### apiKey

- **Type**: API key
- **API key parameter name**: apiKey
- **Location**: HTTP header


## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issues.

## Author



