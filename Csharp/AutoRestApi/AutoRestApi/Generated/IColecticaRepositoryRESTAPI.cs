// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApiRestColectica
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Colectica Repository REST API
    /// </summary>
    public partial interface IColecticaRepositoryRESTAPI : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// Gets the IApiV1Item.
        /// </summary>
        IApiV1Item ApiV1Item { get; }

        /// <summary>
        /// Gets the IApiV1Permission.
        /// </summary>
        IApiV1Permission ApiV1Permission { get; }

        /// <summary>
        /// Gets the IApiV1.
        /// </summary>
        IApiV1 ApiV1 { get; }

        /// <summary>
        /// Gets the IApiV1ItemByAgencyByIdVersions.
        /// </summary>
        IApiV1ItemByAgencyByIdVersions ApiV1ItemByAgencyByIdVersions { get; }

        /// <summary>
        /// Gets the IApiV1ItemByAgencyByIdByTagVersions.
        /// </summary>
        IApiV1ItemByAgencyByIdByTagVersions ApiV1ItemByAgencyByIdByTagVersions { get; }

        /// <param name='request'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> ApiV1AgencyPostWithHttpMessagesAsync(CreateAgencyRequest request = default(CreateAgencyRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='agency'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> ApiV1AgencyByAgencyDeleteWithHttpMessagesAsync(string agency, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='agency'>
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='request'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> ApiV1ItemByAgencyByIdByVersionCommentPostWithHttpMessagesAsync(string agency, System.Guid id, long version, CreateCommentRequest request = default(CreateCommentRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='agency'>
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<UserComment>>> ApiV1ItemByAgencyByIdCommentGetWithHttpMessagesAsync(string agency, System.Guid id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='request'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> ApiV1EventPostWithHttpMessagesAsync(LoggedEvent request = default(LoggedEvent), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='request'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<RepositoryConflict>>> ApiV1ItemPostWithHttpMessagesAsync(RegisterItemsRequest request = default(RegisterItemsRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='agency'>
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<RepositoryItem>> ApiV1ItemByAgencyByIdByVersionGetWithHttpMessagesAsync(string agency, System.Guid id, long version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='agency'>
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<RepositoryItemMetadata>> ApiV1ItemByAgencyByIdGetWithHttpMessagesAsync(string agency, System.Guid id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='agency'>
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<RepositoryItemMetadata>>> ApiV1ItemByAgencyByIdHistoryGetWithHttpMessagesAsync(string agency, System.Guid id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='agency'>
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<RepositoryItemMetadata>> ApiV1ItemByAgencyByIdByVersionDescriptionGetWithHttpMessagesAsync(string agency, System.Guid id, long version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='request'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> ApiV1PermissionPostWithHttpMessagesAsync(RepositorySecurityContext request = default(RepositorySecurityContext), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='agency'>
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<UserRating>>> ApiV1ItemByAgencyByIdByVersionRatingGetWithHttpMessagesAsync(string agency, System.Guid id, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='agency'>
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='rating'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> ApiV1ItemByAgencyByIdByVersionRatingPostWithHttpMessagesAsync(string agency, System.Guid id, long version, int? rating = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<RepositoryInfo>> ApiV1RepositoryInfoGetWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<RepositoryStatistics>> ApiV1RepositoryStatisticsGetWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='agency'>
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<IdentifierTriple>>> ApiV1SetByAgencyByIdByVersionGetWithHttpMessagesAsync(string agency, System.Guid id, long version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='agency'>
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<TypedIdTriple>>> ApiV1SetByAgencyByIdByVersionTypedGetWithHttpMessagesAsync(string agency, System.Guid id, long version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='setting'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<RepositorySetting>> ApiV1SettingBySettingGetWithHttpMessagesAsync(string setting, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='setting'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> ApiV1SettingBySettingDeleteWithHttpMessagesAsync(string setting, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<RepositorySetting>>> ApiV1SettingGetWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='request'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> ApiV1SettingPostWithHttpMessagesAsync(RepositorySetting request = default(RepositorySetting), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='agency'>
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='tag'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> ApiV1ItemByAgencyByIdByVersionTagByTagPutWithHttpMessagesAsync(string agency, System.Guid id, long version, string tag, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='agency'>
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='tag'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> ApiV1ItemByAgencyByIdByVersionTagByTagDeleteWithHttpMessagesAsync(string agency, System.Guid id, long version, string tag, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='agency'>
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<string>>> ApiV1ItemByAgencyByIdByVersionTagGetWithHttpMessagesAsync(string agency, System.Guid id, long version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='agency'>
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<IdentifierTriple>>> ApiV1ItemByAgencyByIdVersionsGetWithHttpMessagesAsync(string agency, System.Guid id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
