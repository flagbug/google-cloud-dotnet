// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>
    /// Settings for a <see cref="NotificationChannelServiceClient"/>.
    /// </summary>
    public sealed partial class NotificationChannelServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="NotificationChannelServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="NotificationChannelServiceSettings"/>.
        /// </returns>
        public static NotificationChannelServiceSettings GetDefault() => new NotificationChannelServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="NotificationChannelServiceSettings"/> object with default settings.
        /// </summary>
        public NotificationChannelServiceSettings() { }

        private NotificationChannelServiceSettings(NotificationChannelServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListNotificationChannelDescriptorsSettings = existing.ListNotificationChannelDescriptorsSettings;
            GetNotificationChannelDescriptorSettings = existing.GetNotificationChannelDescriptorSettings;
            ListNotificationChannelsSettings = existing.ListNotificationChannelsSettings;
            GetNotificationChannelSettings = existing.GetNotificationChannelSettings;
            CreateNotificationChannelSettings = existing.CreateNotificationChannelSettings;
            UpdateNotificationChannelSettings = existing.UpdateNotificationChannelSettings;
            DeleteNotificationChannelSettings = existing.DeleteNotificationChannelSettings;
            OnCopy(existing);
        }

        partial void OnCopy(NotificationChannelServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="NotificationChannelServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="NotificationChannelServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="NotificationChannelServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="NotificationChannelServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="NotificationChannelServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="NotificationChannelServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="NotificationChannelServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="NotificationChannelServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.ListNotificationChannelDescriptors</c> and <c>NotificationChannelServiceClient.ListNotificationChannelDescriptorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>NotificationChannelServiceClient.ListNotificationChannelDescriptors</c> and
        /// <c>NotificationChannelServiceClient.ListNotificationChannelDescriptorsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListNotificationChannelDescriptorsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.GetNotificationChannelDescriptor</c> and <c>NotificationChannelServiceClient.GetNotificationChannelDescriptorAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>NotificationChannelServiceClient.GetNotificationChannelDescriptor</c> and
        /// <c>NotificationChannelServiceClient.GetNotificationChannelDescriptorAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetNotificationChannelDescriptorSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.ListNotificationChannels</c> and <c>NotificationChannelServiceClient.ListNotificationChannelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>NotificationChannelServiceClient.ListNotificationChannels</c> and
        /// <c>NotificationChannelServiceClient.ListNotificationChannelsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListNotificationChannelsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.GetNotificationChannel</c> and <c>NotificationChannelServiceClient.GetNotificationChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>NotificationChannelServiceClient.GetNotificationChannel</c> and
        /// <c>NotificationChannelServiceClient.GetNotificationChannelAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetNotificationChannelSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.CreateNotificationChannel</c> and <c>NotificationChannelServiceClient.CreateNotificationChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>NotificationChannelServiceClient.CreateNotificationChannel</c> and
        /// <c>NotificationChannelServiceClient.CreateNotificationChannelAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateNotificationChannelSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.UpdateNotificationChannel</c> and <c>NotificationChannelServiceClient.UpdateNotificationChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>NotificationChannelServiceClient.UpdateNotificationChannel</c> and
        /// <c>NotificationChannelServiceClient.UpdateNotificationChannelAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateNotificationChannelSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.DeleteNotificationChannel</c> and <c>NotificationChannelServiceClient.DeleteNotificationChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>NotificationChannelServiceClient.DeleteNotificationChannel</c> and
        /// <c>NotificationChannelServiceClient.DeleteNotificationChannelAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteNotificationChannelSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="NotificationChannelServiceSettings"/> object.</returns>
        public NotificationChannelServiceSettings Clone() => new NotificationChannelServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="NotificationChannelServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class NotificationChannelServiceClientBuilder : gaxgrpc::ClientBuilderBase<NotificationChannelServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public NotificationChannelServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override NotificationChannelServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return NotificationChannelServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<NotificationChannelServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return NotificationChannelServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => NotificationChannelServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => NotificationChannelServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => NotificationChannelServiceClient.ChannelPool;
    }

    /// <summary>
    /// NotificationChannelService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class NotificationChannelServiceClient
    {
        /// <summary>
        /// The default endpoint for the NotificationChannelService service, which is a host of "monitoring.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("monitoring.googleapis.com", 443);

        /// <summary>
        /// The default NotificationChannelService scopes.
        /// </summary>
        /// <remarks>
        /// The default NotificationChannelService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring.read"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring.write"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
            "https://www.googleapis.com/auth/monitoring.write",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="NotificationChannelServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// NotificationChannelServiceClient client = await NotificationChannelServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     NotificationChannelServiceClient.DefaultEndpoint.Host, NotificationChannelServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// NotificationChannelServiceClient client = NotificationChannelServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="NotificationChannelServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="NotificationChannelServiceClient"/>.</returns>
        public static async stt::Task<NotificationChannelServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, NotificationChannelServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="NotificationChannelServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// NotificationChannelServiceClient client = NotificationChannelServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     NotificationChannelServiceClient.DefaultEndpoint.Host, NotificationChannelServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// NotificationChannelServiceClient client = NotificationChannelServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="NotificationChannelServiceSettings"/>.</param>
        /// <returns>The created <see cref="NotificationChannelServiceClient"/>.</returns>
        public static NotificationChannelServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, NotificationChannelServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="NotificationChannelServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="NotificationChannelServiceSettings"/>.</param>
        /// <returns>The created <see cref="NotificationChannelServiceClient"/>.</returns>
        public static NotificationChannelServiceClient Create(grpccore::Channel channel, NotificationChannelServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="NotificationChannelServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="NotificationChannelServiceSettings"/>.</param>
        /// <returns>The created <see cref="NotificationChannelServiceClient"/>.</returns>
        public static NotificationChannelServiceClient Create(grpccore::CallInvoker callInvoker, NotificationChannelServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            NotificationChannelService.NotificationChannelServiceClient grpcClient = new NotificationChannelService.NotificationChannelServiceClient(callInvoker);
            return new NotificationChannelServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, NotificationChannelServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, NotificationChannelServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, NotificationChannelServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, NotificationChannelServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC NotificationChannelService client.
        /// </summary>
        public virtual NotificationChannelService.NotificationChannelServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="name">
        /// The REST resource name of the parent from which to retrieve
        /// the notification channel descriptors. The expected syntax is:
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this names the parent container in which to look for the
        /// descriptors; to retrieve a single descriptor by name, use the
        /// [GetNotificationChannelDescriptor][google.monitoring.v3.NotificationChannelService.GetNotificationChannelDescriptor]
        /// operation, instead.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptorsAsync(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotificationChannelDescriptorsAsync(
                new ListNotificationChannelDescriptorsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="name">
        /// The REST resource name of the parent from which to retrieve
        /// the notification channel descriptors. The expected syntax is:
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this names the parent container in which to look for the
        /// descriptors; to retrieve a single descriptor by name, use the
        /// [GetNotificationChannelDescriptor][google.monitoring.v3.NotificationChannelService.GetNotificationChannelDescriptor]
        /// operation, instead.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptors(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotificationChannelDescriptors(
                new ListNotificationChannelDescriptorsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="name">
        /// The REST resource name of the parent from which to retrieve
        /// the notification channel descriptors. The expected syntax is:
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this names the parent container in which to look for the
        /// descriptors; to retrieve a single descriptor by name, use the
        /// [GetNotificationChannelDescriptor][google.monitoring.v3.NotificationChannelService.GetNotificationChannelDescriptor]
        /// operation, instead.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptorsAsync(
            string name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotificationChannelDescriptorsAsync(
                new ListNotificationChannelDescriptorsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="name">
        /// The REST resource name of the parent from which to retrieve
        /// the notification channel descriptors. The expected syntax is:
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this names the parent container in which to look for the
        /// descriptors; to retrieve a single descriptor by name, use the
        /// [GetNotificationChannelDescriptor][google.monitoring.v3.NotificationChannelService.GetNotificationChannelDescriptor]
        /// operation, instead.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptors(
            string name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotificationChannelDescriptors(
                new ListNotificationChannelDescriptorsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptorsAsync(
            ListNotificationChannelDescriptorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptors(
            ListNotificationChannelDescriptorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// The channel type for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannelDescriptors/{channel_type}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(
            NotificationChannelDescriptorName name,
            gaxgrpc::CallSettings callSettings = null) => GetNotificationChannelDescriptorAsync(
                new GetNotificationChannelDescriptorRequest
                {
                    NotificationChannelDescriptorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// The channel type for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannelDescriptors/{channel_type}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(
            NotificationChannelDescriptorName name,
            st::CancellationToken cancellationToken) => GetNotificationChannelDescriptorAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// The channel type for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannelDescriptors/{channel_type}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual NotificationChannelDescriptor GetNotificationChannelDescriptor(
            NotificationChannelDescriptorName name,
            gaxgrpc::CallSettings callSettings = null) => GetNotificationChannelDescriptor(
                new GetNotificationChannelDescriptorRequest
                {
                    NotificationChannelDescriptorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// The channel type for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannelDescriptors/{channel_type}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetNotificationChannelDescriptorAsync(
                new GetNotificationChannelDescriptorRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// The channel type for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannelDescriptors/{channel_type}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(
            string name,
            st::CancellationToken cancellationToken) => GetNotificationChannelDescriptorAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// The channel type for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannelDescriptors/{channel_type}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual NotificationChannelDescriptor GetNotificationChannelDescriptor(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetNotificationChannelDescriptor(
                new GetNotificationChannelDescriptorRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(
            GetNotificationChannelDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(
            GetNotificationChannelDescriptorRequest request,
            st::CancellationToken cancellationToken) => GetNotificationChannelDescriptorAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual NotificationChannelDescriptor GetNotificationChannelDescriptor(
            GetNotificationChannelDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `projects/[PROJECT_ID]`. That is, this names the container
        /// in which to look for the notification channels; it does not name a
        /// specific channel. To query a specific channel by REST resource name, use
        /// the
        /// [`GetNotificationChannel`][google.monitoring.v3.NotificationChannelService.GetNotificationChannel]
        /// operation.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannel"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannelsAsync(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotificationChannelsAsync(
                new ListNotificationChannelsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `projects/[PROJECT_ID]`. That is, this names the container
        /// in which to look for the notification channels; it does not name a
        /// specific channel. To query a specific channel by REST resource name, use
        /// the
        /// [`GetNotificationChannel`][google.monitoring.v3.NotificationChannelService.GetNotificationChannel]
        /// operation.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="NotificationChannel"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannels(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotificationChannels(
                new ListNotificationChannelsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `projects/[PROJECT_ID]`. That is, this names the container
        /// in which to look for the notification channels; it does not name a
        /// specific channel. To query a specific channel by REST resource name, use
        /// the
        /// [`GetNotificationChannel`][google.monitoring.v3.NotificationChannelService.GetNotificationChannel]
        /// operation.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannel"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannelsAsync(
            string name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotificationChannelsAsync(
                new ListNotificationChannelsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `projects/[PROJECT_ID]`. That is, this names the container
        /// in which to look for the notification channels; it does not name a
        /// specific channel. To query a specific channel by REST resource name, use
        /// the
        /// [`GetNotificationChannel`][google.monitoring.v3.NotificationChannelService.GetNotificationChannel]
        /// operation.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="NotificationChannel"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannels(
            string name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotificationChannels(
                new ListNotificationChannelsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannel"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannelsAsync(
            ListNotificationChannelsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="NotificationChannel"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannels(
            ListNotificationChannelsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannel> GetNotificationChannelAsync(
            NotificationChannelName name,
            gaxgrpc::CallSettings callSettings = null) => GetNotificationChannelAsync(
                new GetNotificationChannelRequest
                {
                    NotificationChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannel> GetNotificationChannelAsync(
            NotificationChannelName name,
            st::CancellationToken cancellationToken) => GetNotificationChannelAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual NotificationChannel GetNotificationChannel(
            NotificationChannelName name,
            gaxgrpc::CallSettings callSettings = null) => GetNotificationChannel(
                new GetNotificationChannelRequest
                {
                    NotificationChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannel> GetNotificationChannelAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetNotificationChannelAsync(
                new GetNotificationChannelRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannel> GetNotificationChannelAsync(
            string name,
            st::CancellationToken cancellationToken) => GetNotificationChannelAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual NotificationChannel GetNotificationChannel(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetNotificationChannel(
                new GetNotificationChannelRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannel> GetNotificationChannelAsync(
            GetNotificationChannelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannel> GetNotificationChannelAsync(
            GetNotificationChannelRequest request,
            st::CancellationToken cancellationToken) => GetNotificationChannelAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual NotificationChannel GetNotificationChannel(
            GetNotificationChannelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is:
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this names the container into which the channel will be
        /// written. This does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(
            ProjectName name,
            NotificationChannel notificationChannel,
            gaxgrpc::CallSettings callSettings = null) => CreateNotificationChannelAsync(
                new CreateNotificationChannelRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
                },
                callSettings);

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is:
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this names the container into which the channel will be
        /// written. This does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(
            ProjectName name,
            NotificationChannel notificationChannel,
            st::CancellationToken cancellationToken) => CreateNotificationChannelAsync(
                name,
                notificationChannel,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is:
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this names the container into which the channel will be
        /// written. This does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual NotificationChannel CreateNotificationChannel(
            ProjectName name,
            NotificationChannel notificationChannel,
            gaxgrpc::CallSettings callSettings = null) => CreateNotificationChannel(
                new CreateNotificationChannelRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
                },
                callSettings);

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is:
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this names the container into which the channel will be
        /// written. This does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(
            string name,
            NotificationChannel notificationChannel,
            gaxgrpc::CallSettings callSettings = null) => CreateNotificationChannelAsync(
                new CreateNotificationChannelRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
                },
                callSettings);

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is:
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this names the container into which the channel will be
        /// written. This does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(
            string name,
            NotificationChannel notificationChannel,
            st::CancellationToken cancellationToken) => CreateNotificationChannelAsync(
                name,
                notificationChannel,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is:
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this names the container into which the channel will be
        /// written. This does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual NotificationChannel CreateNotificationChannel(
            string name,
            NotificationChannel notificationChannel,
            gaxgrpc::CallSettings callSettings = null) => CreateNotificationChannel(
                new CreateNotificationChannelRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
                },
                callSettings);

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(
            CreateNotificationChannelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(
            CreateNotificationChannelRequest request,
            st::CancellationToken cancellationToken) => CreateNotificationChannelAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual NotificationChannel CreateNotificationChannel(
            CreateNotificationChannelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// </summary>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="notificationChannel">
        /// A description of the changes to be applied to the specified
        /// notification channel. The description must provide a definition for
        /// fields to be updated; the names of these fields should also be
        /// included in the `update_mask`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannel> UpdateNotificationChannelAsync(
            pbwkt::FieldMask updateMask,
            NotificationChannel notificationChannel,
            gaxgrpc::CallSettings callSettings = null) => UpdateNotificationChannelAsync(
                new UpdateNotificationChannelRequest
                {
                    UpdateMask = updateMask, // Optional
                    NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
                },
                callSettings);

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// </summary>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="notificationChannel">
        /// A description of the changes to be applied to the specified
        /// notification channel. The description must provide a definition for
        /// fields to be updated; the names of these fields should also be
        /// included in the `update_mask`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannel> UpdateNotificationChannelAsync(
            pbwkt::FieldMask updateMask,
            NotificationChannel notificationChannel,
            st::CancellationToken cancellationToken) => UpdateNotificationChannelAsync(
                updateMask,
                notificationChannel,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// </summary>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="notificationChannel">
        /// A description of the changes to be applied to the specified
        /// notification channel. The description must provide a definition for
        /// fields to be updated; the names of these fields should also be
        /// included in the `update_mask`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual NotificationChannel UpdateNotificationChannel(
            pbwkt::FieldMask updateMask,
            NotificationChannel notificationChannel,
            gaxgrpc::CallSettings callSettings = null) => UpdateNotificationChannel(
                new UpdateNotificationChannelRequest
                {
                    UpdateMask = updateMask, // Optional
                    NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
                },
                callSettings);

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannel> UpdateNotificationChannelAsync(
            UpdateNotificationChannelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<NotificationChannel> UpdateNotificationChannelAsync(
            UpdateNotificationChannelRequest request,
            st::CancellationToken cancellationToken) => UpdateNotificationChannelAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual NotificationChannel UpdateNotificationChannel(
            UpdateNotificationChannelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a notification channel.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteNotificationChannelAsync(
            NotificationChannelName name,
            bool? force,
            gaxgrpc::CallSettings callSettings = null) => DeleteNotificationChannelAsync(
                new DeleteNotificationChannelRequest
                {
                    NotificationChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Force = force ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Deletes a notification channel.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteNotificationChannelAsync(
            NotificationChannelName name,
            bool? force,
            st::CancellationToken cancellationToken) => DeleteNotificationChannelAsync(
                name,
                force,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a notification channel.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteNotificationChannel(
            NotificationChannelName name,
            bool? force,
            gaxgrpc::CallSettings callSettings = null) => DeleteNotificationChannel(
                new DeleteNotificationChannelRequest
                {
                    NotificationChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Force = force ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Deletes a notification channel.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteNotificationChannelAsync(
            string name,
            bool? force,
            gaxgrpc::CallSettings callSettings = null) => DeleteNotificationChannelAsync(
                new DeleteNotificationChannelRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Force = force ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Deletes a notification channel.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteNotificationChannelAsync(
            string name,
            bool? force,
            st::CancellationToken cancellationToken) => DeleteNotificationChannelAsync(
                name,
                force,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a notification channel.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteNotificationChannel(
            string name,
            bool? force,
            gaxgrpc::CallSettings callSettings = null) => DeleteNotificationChannel(
                new DeleteNotificationChannelRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Force = force ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Deletes a notification channel.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteNotificationChannelAsync(
            DeleteNotificationChannelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a notification channel.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteNotificationChannelAsync(
            DeleteNotificationChannelRequest request,
            st::CancellationToken cancellationToken) => DeleteNotificationChannelAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a notification channel.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteNotificationChannel(
            DeleteNotificationChannelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// NotificationChannelService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class NotificationChannelServiceClientImpl : NotificationChannelServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListNotificationChannelDescriptorsRequest, ListNotificationChannelDescriptorsResponse> _callListNotificationChannelDescriptors;
        private readonly gaxgrpc::ApiCall<GetNotificationChannelDescriptorRequest, NotificationChannelDescriptor> _callGetNotificationChannelDescriptor;
        private readonly gaxgrpc::ApiCall<ListNotificationChannelsRequest, ListNotificationChannelsResponse> _callListNotificationChannels;
        private readonly gaxgrpc::ApiCall<GetNotificationChannelRequest, NotificationChannel> _callGetNotificationChannel;
        private readonly gaxgrpc::ApiCall<CreateNotificationChannelRequest, NotificationChannel> _callCreateNotificationChannel;
        private readonly gaxgrpc::ApiCall<UpdateNotificationChannelRequest, NotificationChannel> _callUpdateNotificationChannel;
        private readonly gaxgrpc::ApiCall<DeleteNotificationChannelRequest, pbwkt::Empty> _callDeleteNotificationChannel;

        /// <summary>
        /// Constructs a client wrapper for the NotificationChannelService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="NotificationChannelServiceSettings"/> used within this client </param>
        public NotificationChannelServiceClientImpl(NotificationChannelService.NotificationChannelServiceClient grpcClient, NotificationChannelServiceSettings settings)
        {
            GrpcClient = grpcClient;
            NotificationChannelServiceSettings effectiveSettings = settings ?? NotificationChannelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListNotificationChannelDescriptors = clientHelper.BuildApiCall<ListNotificationChannelDescriptorsRequest, ListNotificationChannelDescriptorsResponse>(
                GrpcClient.ListNotificationChannelDescriptorsAsync, GrpcClient.ListNotificationChannelDescriptors, effectiveSettings.ListNotificationChannelDescriptorsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callGetNotificationChannelDescriptor = clientHelper.BuildApiCall<GetNotificationChannelDescriptorRequest, NotificationChannelDescriptor>(
                GrpcClient.GetNotificationChannelDescriptorAsync, GrpcClient.GetNotificationChannelDescriptor, effectiveSettings.GetNotificationChannelDescriptorSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callListNotificationChannels = clientHelper.BuildApiCall<ListNotificationChannelsRequest, ListNotificationChannelsResponse>(
                GrpcClient.ListNotificationChannelsAsync, GrpcClient.ListNotificationChannels, effectiveSettings.ListNotificationChannelsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callGetNotificationChannel = clientHelper.BuildApiCall<GetNotificationChannelRequest, NotificationChannel>(
                GrpcClient.GetNotificationChannelAsync, GrpcClient.GetNotificationChannel, effectiveSettings.GetNotificationChannelSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callCreateNotificationChannel = clientHelper.BuildApiCall<CreateNotificationChannelRequest, NotificationChannel>(
                GrpcClient.CreateNotificationChannelAsync, GrpcClient.CreateNotificationChannel, effectiveSettings.CreateNotificationChannelSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callUpdateNotificationChannel = clientHelper.BuildApiCall<UpdateNotificationChannelRequest, NotificationChannel>(
                GrpcClient.UpdateNotificationChannelAsync, GrpcClient.UpdateNotificationChannel, effectiveSettings.UpdateNotificationChannelSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"notification_channel.name={request.NotificationChannel?.Name}"));
            _callDeleteNotificationChannel = clientHelper.BuildApiCall<DeleteNotificationChannelRequest, pbwkt::Empty>(
                GrpcClient.DeleteNotificationChannelAsync, GrpcClient.DeleteNotificationChannel, effectiveSettings.DeleteNotificationChannelSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            Modify_ApiCall(ref _callListNotificationChannelDescriptors);
            Modify_ListNotificationChannelDescriptorsApiCall(ref _callListNotificationChannelDescriptors);
            Modify_ApiCall(ref _callGetNotificationChannelDescriptor);
            Modify_GetNotificationChannelDescriptorApiCall(ref _callGetNotificationChannelDescriptor);
            Modify_ApiCall(ref _callListNotificationChannels);
            Modify_ListNotificationChannelsApiCall(ref _callListNotificationChannels);
            Modify_ApiCall(ref _callGetNotificationChannel);
            Modify_GetNotificationChannelApiCall(ref _callGetNotificationChannel);
            Modify_ApiCall(ref _callCreateNotificationChannel);
            Modify_CreateNotificationChannelApiCall(ref _callCreateNotificationChannel);
            Modify_ApiCall(ref _callUpdateNotificationChannel);
            Modify_UpdateNotificationChannelApiCall(ref _callUpdateNotificationChannel);
            Modify_ApiCall(ref _callDeleteNotificationChannel);
            Modify_DeleteNotificationChannelApiCall(ref _callDeleteNotificationChannel);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_ListNotificationChannelDescriptorsApiCall(ref gaxgrpc::ApiCall<ListNotificationChannelDescriptorsRequest, ListNotificationChannelDescriptorsResponse> call);
        partial void Modify_GetNotificationChannelDescriptorApiCall(ref gaxgrpc::ApiCall<GetNotificationChannelDescriptorRequest, NotificationChannelDescriptor> call);
        partial void Modify_ListNotificationChannelsApiCall(ref gaxgrpc::ApiCall<ListNotificationChannelsRequest, ListNotificationChannelsResponse> call);
        partial void Modify_GetNotificationChannelApiCall(ref gaxgrpc::ApiCall<GetNotificationChannelRequest, NotificationChannel> call);
        partial void Modify_CreateNotificationChannelApiCall(ref gaxgrpc::ApiCall<CreateNotificationChannelRequest, NotificationChannel> call);
        partial void Modify_UpdateNotificationChannelApiCall(ref gaxgrpc::ApiCall<UpdateNotificationChannelRequest, NotificationChannel> call);
        partial void Modify_DeleteNotificationChannelApiCall(ref gaxgrpc::ApiCall<DeleteNotificationChannelRequest, pbwkt::Empty> call);
        partial void OnConstruction(NotificationChannelService.NotificationChannelServiceClient grpcClient, NotificationChannelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC NotificationChannelService client.
        /// </summary>
        public override NotificationChannelService.NotificationChannelServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListNotificationChannelDescriptorsRequest(ref ListNotificationChannelDescriptorsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetNotificationChannelDescriptorRequest(ref GetNotificationChannelDescriptorRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListNotificationChannelsRequest(ref ListNotificationChannelsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetNotificationChannelRequest(ref GetNotificationChannelRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateNotificationChannelRequest(ref CreateNotificationChannelRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateNotificationChannelRequest(ref UpdateNotificationChannelRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteNotificationChannelRequest(ref DeleteNotificationChannelRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptorsAsync(
            ListNotificationChannelDescriptorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotificationChannelDescriptorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNotificationChannelDescriptorsRequest, ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor>(_callListNotificationChannelDescriptors, request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptors(
            ListNotificationChannelDescriptorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotificationChannelDescriptorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNotificationChannelDescriptorsRequest, ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor>(_callListNotificationChannelDescriptors, request, callSettings);
        }

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(
            GetNotificationChannelDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationChannelDescriptorRequest(ref request, ref callSettings);
            return _callGetNotificationChannelDescriptor.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override NotificationChannelDescriptor GetNotificationChannelDescriptor(
            GetNotificationChannelDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationChannelDescriptorRequest(ref request, ref callSettings);
            return _callGetNotificationChannelDescriptor.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannel"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannelsAsync(
            ListNotificationChannelsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotificationChannelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNotificationChannelsRequest, ListNotificationChannelsResponse, NotificationChannel>(_callListNotificationChannels, request, callSettings);
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="NotificationChannel"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannels(
            ListNotificationChannelsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotificationChannelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNotificationChannelsRequest, ListNotificationChannelsResponse, NotificationChannel>(_callListNotificationChannels, request, callSettings);
        }

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<NotificationChannel> GetNotificationChannelAsync(
            GetNotificationChannelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationChannelRequest(ref request, ref callSettings);
            return _callGetNotificationChannel.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override NotificationChannel GetNotificationChannel(
            GetNotificationChannelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationChannelRequest(ref request, ref callSettings);
            return _callGetNotificationChannel.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<NotificationChannel> CreateNotificationChannelAsync(
            CreateNotificationChannelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNotificationChannelRequest(ref request, ref callSettings);
            return _callCreateNotificationChannel.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override NotificationChannel CreateNotificationChannel(
            CreateNotificationChannelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNotificationChannelRequest(ref request, ref callSettings);
            return _callCreateNotificationChannel.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<NotificationChannel> UpdateNotificationChannelAsync(
            UpdateNotificationChannelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNotificationChannelRequest(ref request, ref callSettings);
            return _callUpdateNotificationChannel.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override NotificationChannel UpdateNotificationChannel(
            UpdateNotificationChannelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNotificationChannelRequest(ref request, ref callSettings);
            return _callUpdateNotificationChannel.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a notification channel.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteNotificationChannelAsync(
            DeleteNotificationChannelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNotificationChannelRequest(ref request, ref callSettings);
            return _callDeleteNotificationChannel.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a notification channel.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteNotificationChannel(
            DeleteNotificationChannelRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNotificationChannelRequest(ref request, ref callSettings);
            _callDeleteNotificationChannel.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListNotificationChannelDescriptorsRequest : gaxgrpc::IPageRequest { }
    public partial class ListNotificationChannelDescriptorsResponse : gaxgrpc::IPageResponse<NotificationChannelDescriptor>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<NotificationChannelDescriptor> GetEnumerator() => ChannelDescriptors.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNotificationChannelsRequest : gaxgrpc::IPageRequest { }
    public partial class ListNotificationChannelsResponse : gaxgrpc::IPageResponse<NotificationChannel>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<NotificationChannel> GetEnumerator() => NotificationChannels.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
