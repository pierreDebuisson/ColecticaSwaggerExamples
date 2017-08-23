# RatingApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV1ItemByAgencyByIdByVersionRatingGet**](RatingApi.md#apiV1ItemByAgencyByIdByVersionRatingGet) | **GET** /api/v1/item/{agency}/{id}/{version}/rating | 
[**apiV1ItemByAgencyByIdByVersionRatingPost**](RatingApi.md#apiV1ItemByAgencyByIdByVersionRatingPost) | **POST** /api/v1/item/{agency}/{id}/{version}/rating | 


<a name="apiV1ItemByAgencyByIdByVersionRatingGet"></a>
# **apiV1ItemByAgencyByIdByVersionRatingGet**
> List&lt;UserRating&gt; apiV1ItemByAgencyByIdByVersionRatingGet(agency, id, version)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.RatingApi;


RatingApi apiInstance = new RatingApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
String version = "version_example"; // String | 
try {
    List<UserRating> result = apiInstance.apiV1ItemByAgencyByIdByVersionRatingGet(agency, id, version);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling RatingApi#apiV1ItemByAgencyByIdByVersionRatingGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agency** | **String**|  |
 **id** | **UUID**|  |
 **version** | **String**|  |

### Return type

[**List&lt;UserRating&gt;**](UserRating.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1ItemByAgencyByIdByVersionRatingPost"></a>
# **apiV1ItemByAgencyByIdByVersionRatingPost**
> apiV1ItemByAgencyByIdByVersionRatingPost(agency, id, version, rating)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.RatingApi;


RatingApi apiInstance = new RatingApi();
String agency = "agency_example"; // String | 
UUID id = new UUID(); // UUID | 
Long version = 789L; // Long | 
Integer rating = 56; // Integer | 
try {
    apiInstance.apiV1ItemByAgencyByIdByVersionRatingPost(agency, id, version, rating);
} catch (ApiException e) {
    System.err.println("Exception when calling RatingApi#apiV1ItemByAgencyByIdByVersionRatingPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agency** | **String**|  |
 **id** | **UUID**|  |
 **version** | **Long**|  |
 **rating** | **Integer**|  | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: Not defined

