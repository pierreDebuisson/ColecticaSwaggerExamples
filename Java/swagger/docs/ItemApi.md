# ItemApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV1ItemByAgencyByIdByVersionDescriptionGet**](ItemApi.md#apiV1ItemByAgencyByIdByVersionDescriptionGet) | **GET** /api/v1/item/{agency}/{id}/{version}/description | 
[**apiV1ItemByAgencyByIdByVersionGet**](ItemApi.md#apiV1ItemByAgencyByIdByVersionGet) | **GET** /api/v1/item/{agency}/{id}/{version} | 
[**apiV1ItemByAgencyByIdGet**](ItemApi.md#apiV1ItemByAgencyByIdGet) | **GET** /api/v1/item/{agency}/{id} | 
[**apiV1ItemByAgencyByIdHistoryGet**](ItemApi.md#apiV1ItemByAgencyByIdHistoryGet) | **GET** /api/v1/item/{agency}/{id}/history | 
[**apiV1ItemGetDescriptionsPost**](ItemApi.md#apiV1ItemGetDescriptionsPost) | **POST** /api/v1/item/_getDescriptions | 
[**apiV1ItemGetListLatestPost**](ItemApi.md#apiV1ItemGetListLatestPost) | **POST** /api/v1/item/_getListLatest | 
[**apiV1ItemGetListPost**](ItemApi.md#apiV1ItemGetListPost) | **POST** /api/v1/item/_getList | 
[**apiV1ItemPost**](ItemApi.md#apiV1ItemPost) | **POST** /api/v1/item | 
[**apiV1ItemUpdateStatePost**](ItemApi.md#apiV1ItemUpdateStatePost) | **POST** /api/v1/item/_updateState | 


<a name="apiV1ItemByAgencyByIdByVersionDescriptionGet"></a>
# **apiV1ItemByAgencyByIdByVersionDescriptionGet**
> RepositoryItemMetadata apiV1ItemByAgencyByIdByVersionDescriptionGet(agency, id, version)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ItemApi;


ItemApi apiInstance = new ItemApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
Long version = 789L; // Long | 
try {
    RepositoryItemMetadata result = apiInstance.apiV1ItemByAgencyByIdByVersionDescriptionGet(agency, id, version);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ItemApi#apiV1ItemByAgencyByIdByVersionDescriptionGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agency** | **String**|  |
 **id** | **UUID**|  |
 **version** | **Long**|  |

### Return type

[**RepositoryItemMetadata**](RepositoryItemMetadata.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1ItemByAgencyByIdByVersionGet"></a>
# **apiV1ItemByAgencyByIdByVersionGet**
> RepositoryItem apiV1ItemByAgencyByIdByVersionGet(agency, id, version)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ItemApi;


ItemApi apiInstance = new ItemApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
Long version = 789L; // Long | 
try {
    RepositoryItem result = apiInstance.apiV1ItemByAgencyByIdByVersionGet(agency, id, version);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ItemApi#apiV1ItemByAgencyByIdByVersionGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agency** | **String**|  |
 **id** | **UUID**|  |
 **version** | **Long**|  |

### Return type

[**RepositoryItem**](RepositoryItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1ItemByAgencyByIdGet"></a>
# **apiV1ItemByAgencyByIdGet**
> RepositoryItemMetadata apiV1ItemByAgencyByIdGet(agency, id)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ItemApi;


ItemApi apiInstance = new ItemApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
try {
    RepositoryItemMetadata result = apiInstance.apiV1ItemByAgencyByIdGet(agency, id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ItemApi#apiV1ItemByAgencyByIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agency** | **String**|  |
 **id** | **UUID**|  |

### Return type

[**RepositoryItemMetadata**](RepositoryItemMetadata.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1ItemByAgencyByIdHistoryGet"></a>
# **apiV1ItemByAgencyByIdHistoryGet**
> List&lt;RepositoryItemMetadata&gt; apiV1ItemByAgencyByIdHistoryGet(agency, id)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ItemApi;


ItemApi apiInstance = new ItemApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
try {
    List<RepositoryItemMetadata> result = apiInstance.apiV1ItemByAgencyByIdHistoryGet(agency, id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ItemApi#apiV1ItemByAgencyByIdHistoryGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agency** | **String**|  |
 **id** | **UUID**|  |

### Return type

[**List&lt;RepositoryItemMetadata&gt;**](RepositoryItemMetadata.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1ItemGetDescriptionsPost"></a>
# **apiV1ItemGetDescriptionsPost**
> List&lt;RepositoryItemMetadata&gt; apiV1ItemGetDescriptionsPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ItemApi;


ItemApi apiInstance = new ItemApi();
GetRepositoryItemDescriptionsRequest request = new GetRepositoryItemDescriptionsRequest(); // GetRepositoryItemDescriptionsRequest | 
try {
    List<RepositoryItemMetadata> result = apiInstance.apiV1ItemGetDescriptionsPost(request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ItemApi#apiV1ItemGetDescriptionsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GetRepositoryItemDescriptionsRequest**](GetRepositoryItemDescriptionsRequest.md)|  | [optional]

### Return type

[**List&lt;RepositoryItemMetadata&gt;**](RepositoryItemMetadata.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1ItemGetListLatestPost"></a>
# **apiV1ItemGetListLatestPost**
> List&lt;RepositoryItem&gt; apiV1ItemGetListLatestPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ItemApi;


ItemApi apiInstance = new ItemApi();
GetLatestItemsRequest request = new GetLatestItemsRequest(); // GetLatestItemsRequest | 
try {
    List<RepositoryItem> result = apiInstance.apiV1ItemGetListLatestPost(request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ItemApi#apiV1ItemGetListLatestPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GetLatestItemsRequest**](GetLatestItemsRequest.md)|  | [optional]

### Return type

[**List&lt;RepositoryItem&gt;**](RepositoryItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1ItemGetListPost"></a>
# **apiV1ItemGetListPost**
> List&lt;RepositoryItemMetadata&gt; apiV1ItemGetListPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ItemApi;


ItemApi apiInstance = new ItemApi();
GetItemsRequest request = new GetItemsRequest(); // GetItemsRequest | 
try {
    List<RepositoryItemMetadata> result = apiInstance.apiV1ItemGetListPost(request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ItemApi#apiV1ItemGetListPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GetItemsRequest**](GetItemsRequest.md)|  | [optional]

### Return type

[**List&lt;RepositoryItemMetadata&gt;**](RepositoryItemMetadata.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1ItemPost"></a>
# **apiV1ItemPost**
> List&lt;RepositoryConflict&gt; apiV1ItemPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ItemApi;


ItemApi apiInstance = new ItemApi();
RegisterItemsRequest request = new RegisterItemsRequest(); // RegisterItemsRequest | 
try {
    List<RepositoryConflict> result = apiInstance.apiV1ItemPost(request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ItemApi#apiV1ItemPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**RegisterItemsRequest**](RegisterItemsRequest.md)|  | [optional]

### Return type

[**List&lt;RepositoryConflict&gt;**](RepositoryConflict.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1ItemUpdateStatePost"></a>
# **apiV1ItemUpdateStatePost**
> apiV1ItemUpdateStatePost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ItemApi;


ItemApi apiInstance = new ItemApi();
UpdateStateRequest request = new UpdateStateRequest(); // UpdateStateRequest | 
try {
    apiInstance.apiV1ItemUpdateStatePost(request);
} catch (ApiException e) {
    System.err.println("Exception when calling ItemApi#apiV1ItemUpdateStatePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UpdateStateRequest**](UpdateStateRequest.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: Not defined

