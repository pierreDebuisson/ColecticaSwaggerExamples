# QueryApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV1QueryPost**](QueryApi.md#apiV1QueryPost) | **POST** /api/v1/_query | 
[**apiV1QueryRelationshipByobjectDescriptionsPost**](QueryApi.md#apiV1QueryRelationshipByobjectDescriptionsPost) | **POST** /api/v1/_query/relationship/byobject/descriptions | 
[**apiV1QueryRelationshipByobjectPost**](QueryApi.md#apiV1QueryRelationshipByobjectPost) | **POST** /api/v1/_query/relationship/byobject | 
[**apiV1QueryRelationshipBysubjectDescriptionsPost**](QueryApi.md#apiV1QueryRelationshipBysubjectDescriptionsPost) | **POST** /api/v1/_query/relationship/bysubject/descriptions | 
[**apiV1QueryRelationshipBysubjectPost**](QueryApi.md#apiV1QueryRelationshipBysubjectPost) | **POST** /api/v1/_query/relationship/bysubject | 
[**apiV1QueryRelationshipMatrixPost**](QueryApi.md#apiV1QueryRelationshipMatrixPost) | **POST** /api/v1/_query/relationship/matrix | 
[**apiV1QueryRelationshipMatrixTypedPost**](QueryApi.md#apiV1QueryRelationshipMatrixTypedPost) | **POST** /api/v1/_query/relationship/matrix/typed | 
[**apiV1QuerySetPost**](QueryApi.md#apiV1QuerySetPost) | **POST** /api/v1/_query/set | 


<a name="apiV1QueryPost"></a>
# **apiV1QueryPost**
> SearchResponse apiV1QueryPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.QueryApi;


QueryApi apiInstance = new QueryApi();
SearchRequest request = new SearchRequest(); // SearchRequest | 
try {
    SearchResponse result = apiInstance.apiV1QueryPost(request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling QueryApi#apiV1QueryPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SearchRequest**](SearchRequest.md)|  | [optional]

### Return type

[**SearchResponse**](SearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1QueryRelationshipByobjectDescriptionsPost"></a>
# **apiV1QueryRelationshipByobjectDescriptionsPost**
> List&lt;RepositoryItemMetadata&gt; apiV1QueryRelationshipByobjectDescriptionsPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.QueryApi;


QueryApi apiInstance = new QueryApi();
GraphSearchRequest request = new GraphSearchRequest(); // GraphSearchRequest | 
try {
    List<RepositoryItemMetadata> result = apiInstance.apiV1QueryRelationshipByobjectDescriptionsPost(request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling QueryApi#apiV1QueryRelationshipByobjectDescriptionsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GraphSearchRequest**](GraphSearchRequest.md)|  | [optional]

### Return type

[**List&lt;RepositoryItemMetadata&gt;**](RepositoryItemMetadata.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1QueryRelationshipByobjectPost"></a>
# **apiV1QueryRelationshipByobjectPost**
> List&lt;TypedIdTriple&gt; apiV1QueryRelationshipByobjectPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.QueryApi;


QueryApi apiInstance = new QueryApi();
GraphSearchRequest request = new GraphSearchRequest(); // GraphSearchRequest | 
try {
    List<TypedIdTriple> result = apiInstance.apiV1QueryRelationshipByobjectPost(request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling QueryApi#apiV1QueryRelationshipByobjectPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GraphSearchRequest**](GraphSearchRequest.md)|  | [optional]

### Return type

[**List&lt;TypedIdTriple&gt;**](TypedIdTriple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1QueryRelationshipBysubjectDescriptionsPost"></a>
# **apiV1QueryRelationshipBysubjectDescriptionsPost**
> List&lt;RepositoryItemMetadata&gt; apiV1QueryRelationshipBysubjectDescriptionsPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.QueryApi;


QueryApi apiInstance = new QueryApi();
GraphSearchRequest request = new GraphSearchRequest(); // GraphSearchRequest | 
try {
    List<RepositoryItemMetadata> result = apiInstance.apiV1QueryRelationshipBysubjectDescriptionsPost(request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling QueryApi#apiV1QueryRelationshipBysubjectDescriptionsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GraphSearchRequest**](GraphSearchRequest.md)|  | [optional]

### Return type

[**List&lt;RepositoryItemMetadata&gt;**](RepositoryItemMetadata.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1QueryRelationshipBysubjectPost"></a>
# **apiV1QueryRelationshipBysubjectPost**
> List&lt;TypedIdTriple&gt; apiV1QueryRelationshipBysubjectPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.QueryApi;


QueryApi apiInstance = new QueryApi();
GraphSearchRequest request = new GraphSearchRequest(); // GraphSearchRequest | 
try {
    List<TypedIdTriple> result = apiInstance.apiV1QueryRelationshipBysubjectPost(request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling QueryApi#apiV1QueryRelationshipBysubjectPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GraphSearchRequest**](GraphSearchRequest.md)|  | [optional]

### Return type

[**List&lt;TypedIdTriple&gt;**](TypedIdTriple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1QueryRelationshipMatrixPost"></a>
# **apiV1QueryRelationshipMatrixPost**
> AdjacencyMatrix apiV1QueryRelationshipMatrixPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.QueryApi;


QueryApi apiInstance = new QueryApi();
GetRelationshipsRequest request = new GetRelationshipsRequest(); // GetRelationshipsRequest | 
try {
    AdjacencyMatrix result = apiInstance.apiV1QueryRelationshipMatrixPost(request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling QueryApi#apiV1QueryRelationshipMatrixPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GetRelationshipsRequest**](GetRelationshipsRequest.md)|  | [optional]

### Return type

[**AdjacencyMatrix**](AdjacencyMatrix.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1QueryRelationshipMatrixTypedPost"></a>
# **apiV1QueryRelationshipMatrixTypedPost**
> TypedAdjacencyMatrix apiV1QueryRelationshipMatrixTypedPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.QueryApi;


QueryApi apiInstance = new QueryApi();
GetTypedRelationshipsRequest request = new GetTypedRelationshipsRequest(); // GetTypedRelationshipsRequest | 
try {
    TypedAdjacencyMatrix result = apiInstance.apiV1QueryRelationshipMatrixTypedPost(request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling QueryApi#apiV1QueryRelationshipMatrixTypedPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GetTypedRelationshipsRequest**](GetTypedRelationshipsRequest.md)|  | [optional]

### Return type

[**TypedAdjacencyMatrix**](TypedAdjacencyMatrix.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

<a name="apiV1QuerySetPost"></a>
# **apiV1QuerySetPost**
> List&lt;TypedIdTriple&gt; apiV1QuerySetPost(request)



### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.QueryApi;


QueryApi apiInstance = new QueryApi();
SearchTypedSetRequest request = new SearchTypedSetRequest(); // SearchTypedSetRequest | 
try {
    List<TypedIdTriple> result = apiInstance.apiV1QuerySetPost(request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling QueryApi#apiV1QuerySetPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SearchTypedSetRequest**](SearchTypedSetRequest.md)|  | [optional]

### Return type

[**List&lt;TypedIdTriple&gt;**](TypedIdTriple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: text/plain, application/json, text/json

