# AgencyApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV1AgencyByAgencyDelete**](AgencyApi.md#apiV1AgencyByAgencyDelete) | **DELETE** /api/v1/agency/{agency} | 
[**apiV1AgencyPost**](AgencyApi.md#apiV1AgencyPost) | **POST** /api/v1/agency | 


<a name="apiV1AgencyByAgencyDelete"></a>
# **apiV1AgencyByAgencyDelete**
> apiV1AgencyByAgencyDelete(agency)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AgencyApi;


AgencyApi apiInstance = new AgencyApi();
String agency = "agency_example"; // String | 
try {
    apiInstance.apiV1AgencyByAgencyDelete(agency);
} catch (ApiException e) {
    System.err.println("Exception when calling AgencyApi#apiV1AgencyByAgencyDelete");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agency** | **String**|  |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="apiV1AgencyPost"></a>
# **apiV1AgencyPost**
> apiV1AgencyPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AgencyApi;


AgencyApi apiInstance = new AgencyApi();
CreateAgencyRequest request = new CreateAgencyRequest(); // CreateAgencyRequest | 
try {
    apiInstance.apiV1AgencyPost(request);
} catch (ApiException e) {
    System.err.println("Exception when calling AgencyApi#apiV1AgencyPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateAgencyRequest**](CreateAgencyRequest.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: Not defined

