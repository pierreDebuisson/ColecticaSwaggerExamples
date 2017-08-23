# SetApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV1SetByAgencyByIdByVersionGet**](SetApi.md#apiV1SetByAgencyByIdByVersionGet) | **GET** /api/v1/set/{agency}/{id}/{version} | 
[**apiV1SetByAgencyByIdByVersionTypedGet**](SetApi.md#apiV1SetByAgencyByIdByVersionTypedGet) | **GET** /api/v1/set/{agency}/{id}/{version}/typed | 
[**apiV1SetByAgencyByIdGet**](SetApi.md#apiV1SetByAgencyByIdGet) | **GET** /api/v1/set/{agency}/{id} | 


<a name="apiV1SetByAgencyByIdByVersionGet"></a>
# **apiV1SetByAgencyByIdByVersionGet**
> List&lt;IdentifierTriple&gt; apiV1SetByAgencyByIdByVersionGet(agency, id, version)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.SetApi;


SetApi apiInstance = new SetApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
Long version = 789L; // Long | 
try {
    List<IdentifierTriple> result = apiInstance.apiV1SetByAgencyByIdByVersionGet(agency, id, version);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling SetApi#apiV1SetByAgencyByIdByVersionGet");
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

[**List&lt;IdentifierTriple&gt;**](IdentifierTriple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1SetByAgencyByIdByVersionTypedGet"></a>
# **apiV1SetByAgencyByIdByVersionTypedGet**
> List&lt;TypedIdTriple&gt; apiV1SetByAgencyByIdByVersionTypedGet(agency, id, version)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.SetApi;


SetApi apiInstance = new SetApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
Long version = 789L; // Long | 
try {
    List<TypedIdTriple> result = apiInstance.apiV1SetByAgencyByIdByVersionTypedGet(agency, id, version);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling SetApi#apiV1SetByAgencyByIdByVersionTypedGet");
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

[**List&lt;TypedIdTriple&gt;**](TypedIdTriple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1SetByAgencyByIdGet"></a>
# **apiV1SetByAgencyByIdGet**
> List&lt;IdentifierTriple&gt; apiV1SetByAgencyByIdGet(agency, id)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.SetApi;


SetApi apiInstance = new SetApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
try {
    List<IdentifierTriple> result = apiInstance.apiV1SetByAgencyByIdGet(agency, id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling SetApi#apiV1SetByAgencyByIdGet");
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

