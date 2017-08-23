# EventApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV1EventPost**](EventApi.md#apiV1EventPost) | **POST** /api/v1/event | 


<a name="apiV1EventPost"></a>
# **apiV1EventPost**
> apiV1EventPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.EventApi;


EventApi apiInstance = new EventApi();
LoggedEvent request = new LoggedEvent(); // LoggedEvent | 
try {
    apiInstance.apiV1EventPost(request);
} catch (ApiException e) {
    System.err.println("Exception when calling EventApi#apiV1EventPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**LoggedEvent**](LoggedEvent.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: Not defined

