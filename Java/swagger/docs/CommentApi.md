# CommentApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV1ItemByAgencyByIdByVersionCommentPost**](CommentApi.md#apiV1ItemByAgencyByIdByVersionCommentPost) | **POST** /api/v1/item/{agency}/{id}/{version}/comment | 
[**apiV1ItemByAgencyByIdCommentGet**](CommentApi.md#apiV1ItemByAgencyByIdCommentGet) | **GET** /api/v1/item/{agency}/{id}/comment | 


<a name="apiV1ItemByAgencyByIdByVersionCommentPost"></a>
# **apiV1ItemByAgencyByIdByVersionCommentPost**
> apiV1ItemByAgencyByIdByVersionCommentPost(agency, id, version, request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CommentApi;


CommentApi apiInstance = new CommentApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
Long version = 789L; // Long | 
CreateCommentRequest request = new CreateCommentRequest(); // CreateCommentRequest | 
try {
    apiInstance.apiV1ItemByAgencyByIdByVersionCommentPost(agency, id, version, request);
} catch (ApiException e) {
    System.err.println("Exception when calling CommentApi#apiV1ItemByAgencyByIdByVersionCommentPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agency** | **String**|  |
 **id** | **UUID**|  |
 **version** | **Long**|  |
 **request** | [**CreateCommentRequest**](CreateCommentRequest.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: Not defined

<a name="apiV1ItemByAgencyByIdCommentGet"></a>
# **apiV1ItemByAgencyByIdCommentGet**
> List&lt;UserComment&gt; apiV1ItemByAgencyByIdCommentGet(agency, id)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CommentApi;


CommentApi apiInstance = new CommentApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
try {
    List<UserComment> result = apiInstance.apiV1ItemByAgencyByIdCommentGet(agency, id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CommentApi#apiV1ItemByAgencyByIdCommentGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agency** | **String**|  |
 **id** | **UUID**|  |

### Return type

[**List&lt;UserComment&gt;**](UserComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

