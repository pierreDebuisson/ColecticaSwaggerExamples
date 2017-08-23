# SettingApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV1SettingBySettingDelete**](SettingApi.md#apiV1SettingBySettingDelete) | **DELETE** /api/v1/setting/{setting} | 
[**apiV1SettingBySettingGet**](SettingApi.md#apiV1SettingBySettingGet) | **GET** /api/v1/setting/{setting} | 
[**apiV1SettingGet**](SettingApi.md#apiV1SettingGet) | **GET** /api/v1/setting | 
[**apiV1SettingPost**](SettingApi.md#apiV1SettingPost) | **POST** /api/v1/setting | 


<a name="apiV1SettingBySettingDelete"></a>
# **apiV1SettingBySettingDelete**
> apiV1SettingBySettingDelete(setting)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.SettingApi;


SettingApi apiInstance = new SettingApi();
String setting = "setting_example"; // String | 
try {
    apiInstance.apiV1SettingBySettingDelete(setting);
} catch (ApiException e) {
    System.err.println("Exception when calling SettingApi#apiV1SettingBySettingDelete");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **setting** | **String**|  |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="apiV1SettingBySettingGet"></a>
# **apiV1SettingBySettingGet**
> RepositorySetting apiV1SettingBySettingGet(setting)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.SettingApi;


SettingApi apiInstance = new SettingApi();
String setting = "setting_example"; // String | 
try {
    RepositorySetting result = apiInstance.apiV1SettingBySettingGet(setting);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling SettingApi#apiV1SettingBySettingGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **setting** | **String**|  |

### Return type

[**RepositorySetting**](RepositorySetting.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1SettingGet"></a>
# **apiV1SettingGet**
> List&lt;RepositorySetting&gt; apiV1SettingGet()



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.SettingApi;


SettingApi apiInstance = new SettingApi();
try {
    List<RepositorySetting> result = apiInstance.apiV1SettingGet();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling SettingApi#apiV1SettingGet");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;RepositorySetting&gt;**](RepositorySetting.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1SettingPost"></a>
# **apiV1SettingPost**
> apiV1SettingPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.SettingApi;


SettingApi apiInstance = new SettingApi();
RepositorySetting request = new RepositorySetting(); // RepositorySetting | 
try {
    apiInstance.apiV1SettingPost(request);
} catch (ApiException e) {
    System.err.println("Exception when calling SettingApi#apiV1SettingPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**RepositorySetting**](RepositorySetting.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: Not defined

