// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApiRestColectica
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ApiV1.
    /// </summary>
    public static partial class ApiV1Extensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static IList<RepositoryItemMetadata> QueryRelationshipBysubjectDescriptionsPost(this IApiV1 operations, GraphSearchRequest request = default(GraphSearchRequest))
            {
                return operations.QueryRelationshipBysubjectDescriptionsPostAsync(request).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<RepositoryItemMetadata>> QueryRelationshipBysubjectDescriptionsPostAsync(this IApiV1 operations, GraphSearchRequest request = default(GraphSearchRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.QueryRelationshipBysubjectDescriptionsPostWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static IList<RepositoryItemMetadata> QueryRelationshipByobjectDescriptionsPost(this IApiV1 operations, GraphSearchRequest request = default(GraphSearchRequest))
            {
                return operations.QueryRelationshipByobjectDescriptionsPostAsync(request).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<RepositoryItemMetadata>> QueryRelationshipByobjectDescriptionsPostAsync(this IApiV1 operations, GraphSearchRequest request = default(GraphSearchRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.QueryRelationshipByobjectDescriptionsPostWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static IList<TypedIdTriple> QueryRelationshipBysubjectPost(this IApiV1 operations, GraphSearchRequest request = default(GraphSearchRequest))
            {
                return operations.QueryRelationshipBysubjectPostAsync(request).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<TypedIdTriple>> QueryRelationshipBysubjectPostAsync(this IApiV1 operations, GraphSearchRequest request = default(GraphSearchRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.QueryRelationshipBysubjectPostWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static IList<TypedIdTriple> QueryRelationshipByobjectPost(this IApiV1 operations, GraphSearchRequest request = default(GraphSearchRequest))
            {
                return operations.QueryRelationshipByobjectPostAsync(request).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<TypedIdTriple>> QueryRelationshipByobjectPostAsync(this IApiV1 operations, GraphSearchRequest request = default(GraphSearchRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.QueryRelationshipByobjectPostWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static AdjacencyMatrix QueryRelationshipMatrixPost(this IApiV1 operations, GetRelationshipsRequest request = default(GetRelationshipsRequest))
            {
                return operations.QueryRelationshipMatrixPostAsync(request).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AdjacencyMatrix> QueryRelationshipMatrixPostAsync(this IApiV1 operations, GetRelationshipsRequest request = default(GetRelationshipsRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.QueryRelationshipMatrixPostWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static TypedAdjacencyMatrix QueryRelationshipMatrixTypedPost(this IApiV1 operations, GetTypedRelationshipsRequest request = default(GetTypedRelationshipsRequest))
            {
                return operations.QueryRelationshipMatrixTypedPostAsync(request).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TypedAdjacencyMatrix> QueryRelationshipMatrixTypedPostAsync(this IApiV1 operations, GetTypedRelationshipsRequest request = default(GetTypedRelationshipsRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.QueryRelationshipMatrixTypedPostWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static SearchResponse QueryPost(this IApiV1 operations, SearchRequest request = default(SearchRequest))
            {
                return operations.QueryPostAsync(request).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SearchResponse> QueryPostAsync(this IApiV1 operations, SearchRequest request = default(SearchRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.QueryPostWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static IList<TypedIdTriple> QuerySetPost(this IApiV1 operations, SearchTypedSetRequest request = default(SearchTypedSetRequest))
            {
                return operations.QuerySetPostAsync(request).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<TypedIdTriple>> QuerySetPostAsync(this IApiV1 operations, SearchTypedSetRequest request = default(SearchTypedSetRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.QuerySetPostWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
