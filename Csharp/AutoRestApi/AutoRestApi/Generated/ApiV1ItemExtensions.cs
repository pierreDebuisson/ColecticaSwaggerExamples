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
    /// Extension methods for ApiV1Item.
    /// </summary>
    public static partial class ApiV1ItemExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static IList<RepositoryItemMetadata> GetListPost(this IApiV1Item operations, GetItemsRequest request = default(GetItemsRequest))
            {
                return operations.GetListPostAsync(request).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<RepositoryItemMetadata>> GetListPostAsync(this IApiV1Item operations, GetItemsRequest request = default(GetItemsRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetListPostWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static void UpdateStatePost(this IApiV1Item operations, UpdateStateRequest request = default(UpdateStateRequest))
            {
                operations.UpdateStatePostAsync(request).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateStatePostAsync(this IApiV1Item operations, UpdateStateRequest request = default(UpdateStateRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateStatePostWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static IList<RepositoryItem> GetListLatestPost(this IApiV1Item operations, GetLatestItemsRequest request = default(GetLatestItemsRequest))
            {
                return operations.GetListLatestPostAsync(request).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<RepositoryItem>> GetListLatestPostAsync(this IApiV1Item operations, GetLatestItemsRequest request = default(GetLatestItemsRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetListLatestPostWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static IList<RepositoryItemMetadata> GetDescriptionsPost(this IApiV1Item operations, GetRepositoryItemDescriptionsRequest request = default(GetRepositoryItemDescriptionsRequest))
            {
                return operations.GetDescriptionsPostAsync(request).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<RepositoryItemMetadata>> GetDescriptionsPostAsync(this IApiV1Item operations, GetRepositoryItemDescriptionsRequest request = default(GetRepositoryItemDescriptionsRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDescriptionsPostWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static IList<IdentifierTriple> GetLatestVersionNumbersPost(this IApiV1Item operations, GetLatestVersionNumbersRequest request = default(GetLatestVersionNumbersRequest))
            {
                return operations.GetLatestVersionNumbersPostAsync(request).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<IdentifierTriple>> GetLatestVersionNumbersPostAsync(this IApiV1Item operations, GetLatestVersionNumbersRequest request = default(GetLatestVersionNumbersRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLatestVersionNumbersPostWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
