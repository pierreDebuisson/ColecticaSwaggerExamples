# RepositoryApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV1RepositoryInfoGet**](RepositoryApi.md#apiV1RepositoryInfoGet) | **GET** /api/v1/repository/info | 
[**apiV1RepositoryStatisticsGet**](RepositoryApi.md#apiV1RepositoryStatisticsGet) | **GET** /api/v1/repository/statistics | 


<a name="apiV1RepositoryInfoGet"></a>
# **apiV1RepositoryInfoGet**
> RepositoryInfo apiV1RepositoryInfoGet()



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.RepositoryApi;


RepositoryApi apiInstance = new RepositoryApi();
try {
    RepositoryInfo result = apiInstance.apiV1RepositoryInfoGet();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling RepositoryApi#apiV1RepositoryInfoGet");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RepositoryInfo**](RepositoryInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1RepositoryStatisticsGet"></a>
# **apiV1RepositoryStatisticsGet**
> RepositoryStatistics apiV1RepositoryStatisticsGet()



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.RepositoryApi;


RepositoryApi apiInstance = new RepositoryApi();
try {
    RepositoryStatistics result = apiInstance.apiV1RepositoryStatisticsGet();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling RepositoryApi#apiV1RepositoryStatisticsGet");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RepositoryStatistics**](RepositoryStatistics.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

