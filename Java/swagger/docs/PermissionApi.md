# PermissionApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV1PermissionDeletePost**](PermissionApi.md#apiV1PermissionDeletePost) | **POST** /api/v1/permission/_delete | 
[**apiV1PermissionGetPost**](PermissionApi.md#apiV1PermissionGetPost) | **POST** /api/v1/permission/_get | 
[**apiV1PermissionPost**](PermissionApi.md#apiV1PermissionPost) | **POST** /api/v1/permission | 


<a name="apiV1PermissionDeletePost"></a>
# **apiV1PermissionDeletePost**
> apiV1PermissionDeletePost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.PermissionApi;


PermissionApi apiInstance = new PermissionApi();
RemovePermissionsRequest request = new RemovePermissionsRequest(); // RemovePermissionsRequest | 
try {
    apiInstance.apiV1PermissionDeletePost(request);
} catch (ApiException e) {
    System.err.println("Exception when calling PermissionApi#apiV1PermissionDeletePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**RemovePermissionsRequest**](RemovePermissionsRequest.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: Not defined

<a name="apiV1PermissionGetPost"></a>
# **apiV1PermissionGetPost**
> RepositorySecurityContext apiV1PermissionGetPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.PermissionApi;


PermissionApi apiInstance = new PermissionApi();
GetPermissionsRequest request = new GetPermissionsRequest(); // GetPermissionsRequest | 
try {
    RepositorySecurityContext result = apiInstance.apiV1PermissionGetPost(request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling PermissionApi#apiV1PermissionGetPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GetPermissionsRequest**](GetPermissionsRequest.md)|  | [optional]

### Return type

[**RepositorySecurityContext**](RepositorySecurityContext.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1PermissionPost"></a>
# **apiV1PermissionPost**
> apiV1PermissionPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.PermissionApi;


PermissionApi apiInstance = new PermissionApi();
RepositorySecurityContext request = new RepositorySecurityContext(); // RepositorySecurityContext | 
try {
    apiInstance.apiV1PermissionPost(request);
} catch (ApiException e) {
    System.err.println("Exception when calling PermissionApi#apiV1PermissionPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**RepositorySecurityContext**](RepositorySecurityContext.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: Not defined

