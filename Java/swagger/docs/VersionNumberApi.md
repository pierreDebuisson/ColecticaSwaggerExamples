# VersionNumberApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV1ItemByAgencyByIdByTagVersionsLatestGet**](VersionNumberApi.md#apiV1ItemByAgencyByIdByTagVersionsLatestGet) | **GET** /api/v1/item/{agency}/{id}/{tag}/versions/_latest | 
[**apiV1ItemByAgencyByIdVersionsGet**](VersionNumberApi.md#apiV1ItemByAgencyByIdVersionsGet) | **GET** /api/v1/item/{agency}/{id}/versions | 
[**apiV1ItemByAgencyByIdVersionsLatestGet**](VersionNumberApi.md#apiV1ItemByAgencyByIdVersionsLatestGet) | **GET** /api/v1/item/{agency}/{id}/versions/_latest | 
[**apiV1ItemGetLatestVersionNumbersPost**](VersionNumberApi.md#apiV1ItemGetLatestVersionNumbersPost) | **POST** /api/v1/item/_getLatestVersionNumbers | 


<a name="apiV1ItemByAgencyByIdByTagVersionsLatestGet"></a>
# **apiV1ItemByAgencyByIdByTagVersionsLatestGet**
> Long apiV1ItemByAgencyByIdByTagVersionsLatestGet(agency, id, tag)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.VersionNumberApi;


VersionNumberApi apiInstance = new VersionNumberApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
String tag = "tag_example"; // String | 
try {
    Long result = apiInstance.apiV1ItemByAgencyByIdByTagVersionsLatestGet(agency, id, tag);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling VersionNumberApi#apiV1ItemByAgencyByIdByTagVersionsLatestGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agency** | **String**|  |
 **id** | **UUID**|  |
 **tag** | **String**|  |

### Return type

**Long**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1ItemByAgencyByIdVersionsGet"></a>
# **apiV1ItemByAgencyByIdVersionsGet**
> List&lt;IdentifierTriple&gt; apiV1ItemByAgencyByIdVersionsGet(agency, id)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.VersionNumberApi;


VersionNumberApi apiInstance = new VersionNumberApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
try {
    List<IdentifierTriple> result = apiInstance.apiV1ItemByAgencyByIdVersionsGet(agency, id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling VersionNumberApi#apiV1ItemByAgencyByIdVersionsGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agency** | **String**|  |
 **id** | **UUID**|  |

### Return type

[**List&lt;IdentifierTriple&gt;**](IdentifierTriple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1ItemByAgencyByIdVersionsLatestGet"></a>
# **apiV1ItemByAgencyByIdVersionsLatestGet**
> Long apiV1ItemByAgencyByIdVersionsLatestGet(agency, id)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.VersionNumberApi;


VersionNumberApi apiInstance = new VersionNumberApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
try {
    Long result = apiInstance.apiV1ItemByAgencyByIdVersionsLatestGet(agency, id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling VersionNumberApi#apiV1ItemByAgencyByIdVersionsLatestGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agency** | **String**|  |
 **id** | **UUID**|  |

### Return type

**Long**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1ItemGetLatestVersionNumbersPost"></a>
# **apiV1ItemGetLatestVersionNumbersPost**
> List&lt;IdentifierTriple&gt; apiV1ItemGetLatestVersionNumbersPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.VersionNumberApi;


VersionNumberApi apiInstance = new VersionNumberApi();
GetLatestVersionNumbersRequest request = new GetLatestVersionNumbersRequest(); // GetLatestVersionNumbersRequest | 
try {
    List<IdentifierTriple> result = apiInstance.apiV1ItemGetLatestVersionNumbersPost(request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling VersionNumberApi#apiV1ItemGetLatestVersionNumbersPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GetLatestVersionNumbersRequest**](GetLatestVersionNumbersRequest.md)|  | [optional]

### Return type

[**List&lt;IdentifierTriple&gt;**](IdentifierTriple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

