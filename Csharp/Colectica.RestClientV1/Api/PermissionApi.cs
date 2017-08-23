/* 
 * Colectica Repository REST API
 *
 * Colectica Repository REST API
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Colectica.RestClientV1.Client;
using Colectica.RestClientV1.Model;

namespace Colectica.RestClientV1.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPermissionApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Removes the specified permissions from the repository.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns></returns>
        void ApiV1PermissionDeletePost (RemovePermissionsRequest request = null);

        /// <summary>
        /// Removes the specified permissions from the repository.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ApiV1PermissionDeletePostWithHttpInfo (RemovePermissionsRequest request = null);
        /// <summary>
        /// Gets all permissions that apply to the specified items and item types.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>RepositorySecurityContext</returns>
        RepositorySecurityContext ApiV1PermissionGetPost (GetPermissionsRequest request = null);

        /// <summary>
        /// Gets all permissions that apply to the specified items and item types.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of RepositorySecurityContext</returns>
        ApiResponse<RepositorySecurityContext> ApiV1PermissionGetPostWithHttpInfo (GetPermissionsRequest request = null);
        /// <summary>
        /// Adds the specified permissions to the repository.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns></returns>
        void ApiV1PermissionPost (RepositorySecurityContext request = null);

        /// <summary>
        /// Adds the specified permissions to the repository.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ApiV1PermissionPostWithHttpInfo (RepositorySecurityContext request = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Removes the specified permissions from the repository.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ApiV1PermissionDeletePostAsync (RemovePermissionsRequest request = null);

        /// <summary>
        /// Removes the specified permissions from the repository.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApiV1PermissionDeletePostAsyncWithHttpInfo (RemovePermissionsRequest request = null);
        /// <summary>
        /// Gets all permissions that apply to the specified items and item types.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of RepositorySecurityContext</returns>
        System.Threading.Tasks.Task<RepositorySecurityContext> ApiV1PermissionGetPostAsync (GetPermissionsRequest request = null);

        /// <summary>
        /// Gets all permissions that apply to the specified items and item types.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse (RepositorySecurityContext)</returns>
        System.Threading.Tasks.Task<ApiResponse<RepositorySecurityContext>> ApiV1PermissionGetPostAsyncWithHttpInfo (GetPermissionsRequest request = null);
        /// <summary>
        /// Adds the specified permissions to the repository.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ApiV1PermissionPostAsync (RepositorySecurityContext request = null);

        /// <summary>
        /// Adds the specified permissions to the repository.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApiV1PermissionPostAsyncWithHttpInfo (RepositorySecurityContext request = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PermissionApi : IPermissionApi
    {
        private Colectica.RestClientV1.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PermissionApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Colectica.RestClientV1.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PermissionApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Colectica.RestClientV1.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Colectica.RestClientV1.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Removes the specified permissions from the repository. 
        /// </summary>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns></returns>
        public void ApiV1PermissionDeletePost (RemovePermissionsRequest request = null)
        {
             ApiV1PermissionDeletePostWithHttpInfo(request);
        }

        /// <summary>
        /// Removes the specified permissions from the repository. 
        /// </summary>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ApiV1PermissionDeletePostWithHttpInfo (RemovePermissionsRequest request = null)
        {

            var localVarPath = "/api/v1/permission/_delete";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/json-patch+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV1PermissionDeletePost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Removes the specified permissions from the repository. 
        /// </summary>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ApiV1PermissionDeletePostAsync (RemovePermissionsRequest request = null)
        {
             await ApiV1PermissionDeletePostAsyncWithHttpInfo(request);

        }

        /// <summary>
        /// Removes the specified permissions from the repository. 
        /// </summary>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ApiV1PermissionDeletePostAsyncWithHttpInfo (RemovePermissionsRequest request = null)
        {

            var localVarPath = "/api/v1/permission/_delete";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/json-patch+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV1PermissionDeletePost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Gets all permissions that apply to the specified items and item types. 
        /// </summary>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>RepositorySecurityContext</returns>
        public RepositorySecurityContext ApiV1PermissionGetPost (GetPermissionsRequest request = null)
        {
             ApiResponse<RepositorySecurityContext> localVarResponse = ApiV1PermissionGetPostWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets all permissions that apply to the specified items and item types. 
        /// </summary>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of RepositorySecurityContext</returns>
        public ApiResponse< RepositorySecurityContext > ApiV1PermissionGetPostWithHttpInfo (GetPermissionsRequest request = null)
        {

            var localVarPath = "/api/v1/permission/_get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/json-patch+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain", 
                "application/json", 
                "text/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV1PermissionGetPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RepositorySecurityContext>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RepositorySecurityContext) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RepositorySecurityContext)));
            
        }

        /// <summary>
        /// Gets all permissions that apply to the specified items and item types. 
        /// </summary>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of RepositorySecurityContext</returns>
        public async System.Threading.Tasks.Task<RepositorySecurityContext> ApiV1PermissionGetPostAsync (GetPermissionsRequest request = null)
        {
             ApiResponse<RepositorySecurityContext> localVarResponse = await ApiV1PermissionGetPostAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets all permissions that apply to the specified items and item types. 
        /// </summary>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse (RepositorySecurityContext)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RepositorySecurityContext>> ApiV1PermissionGetPostAsyncWithHttpInfo (GetPermissionsRequest request = null)
        {

            var localVarPath = "/api/v1/permission/_get";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/json-patch+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain", 
                "application/json", 
                "text/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV1PermissionGetPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RepositorySecurityContext>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RepositorySecurityContext) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RepositorySecurityContext)));
            
        }

        /// <summary>
        /// Adds the specified permissions to the repository. 
        /// </summary>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns></returns>
        public void ApiV1PermissionPost (RepositorySecurityContext request = null)
        {
             ApiV1PermissionPostWithHttpInfo(request);
        }

        /// <summary>
        /// Adds the specified permissions to the repository. 
        /// </summary>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ApiV1PermissionPostWithHttpInfo (RepositorySecurityContext request = null)
        {

            var localVarPath = "/api/v1/permission";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/json-patch+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV1PermissionPost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Adds the specified permissions to the repository. 
        /// </summary>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ApiV1PermissionPostAsync (RepositorySecurityContext request = null)
        {
             await ApiV1PermissionPostAsyncWithHttpInfo(request);

        }

        /// <summary>
        /// Adds the specified permissions to the repository. 
        /// </summary>
        /// <exception cref="Colectica.RestClientV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ApiV1PermissionPostAsyncWithHttpInfo (RepositorySecurityContext request = null)
        {

            var localVarPath = "/api/v1/permission";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/json-patch+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV1PermissionPost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
