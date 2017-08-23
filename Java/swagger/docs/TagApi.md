# TagApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV1ItemByAgencyByIdByVersionTagByTagDelete**](TagApi.md#apiV1ItemByAgencyByIdByVersionTagByTagDelete) | **DELETE** /api/v1/item/{agency}/{id}/{version}/tag/{tag} | 
[**apiV1ItemByAgencyByIdByVersionTagByTagPut**](TagApi.md#apiV1ItemByAgencyByIdByVersionTagByTagPut) | **PUT** /api/v1/item/{agency}/{id}/{version}/tag/{tag} | 
[**apiV1ItemByAgencyByIdByVersionTagGet**](TagApi.md#apiV1ItemByAgencyByIdByVersionTagGet) | **GET** /api/v1/item/{agency}/{id}/{version}/tag | 


<a name="apiV1ItemByAgencyByIdByVersionTagByTagDelete"></a>
# **apiV1ItemByAgencyByIdByVersionTagByTagDelete**
> apiV1ItemByAgencyByIdByVersionTagByTagDelete(agency, id, version, tag)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.TagApi;


TagApi apiInstance = new TagApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
Long version = 789L; // Long | 
String tag = "tag_example"; // String | 
try {
    apiInstance.apiV1ItemByAgencyByIdByVersionTagByTagDelete(agency, id, version, tag);
} catch (ApiException e) {
    System.err.println("Exception when calling TagApi#apiV1ItemByAgencyByIdByVersionTagByTagDelete");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agency** | **String**|  |
 **id** | **UUID**|  |
 **version** | **Long**|  |
 **tag** | **String**|  |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="apiV1ItemByAgencyByIdByVersionTagByTagPut"></a>
# **apiV1ItemByAgencyByIdByVersionTagByTagPut**
> apiV1ItemByAgencyByIdByVersionTagByTagPut(agency, id, version, tag)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.TagApi;


TagApi apiInstance = new TagApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
Long version = 789L; // Long | 
String tag = "tag_example"; // String | 
try {
    apiInstance.apiV1ItemByAgencyByIdByVersionTagByTagPut(agency, id, version, tag);
} catch (ApiException e) {
    System.err.println("Exception when calling TagApi#apiV1ItemByAgencyByIdByVersionTagByTagPut");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agency** | **String**|  |
 **id** | **UUID**|  |
 **version** | **Long**|  |
 **tag** | **String**|  |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="apiV1ItemByAgencyByIdByVersionTagGet"></a>
# **apiV1ItemByAgencyByIdByVersionTagGet**
> List&lt;String&gt; apiV1ItemByAgencyByIdByVersionTagGet(agency, id, version)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.TagApi;


TagApi apiInstance = new TagApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
Long version = 789L; // Long | 
try {
    List<String> result = apiInstance.apiV1ItemByAgencyByIdByVersionTagGet(agency, id, version);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TagApi#apiV1ItemByAgencyByIdByVersionTagGet");
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

**List&lt;String&gt;**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

