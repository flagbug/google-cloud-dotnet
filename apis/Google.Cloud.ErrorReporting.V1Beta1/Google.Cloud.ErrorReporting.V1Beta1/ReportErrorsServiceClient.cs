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
using gaxres = Google.Api.Gax.ResourceNames;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.ErrorReporting.V1Beta1
{
    /// <summary>
    /// Settings for a <see cref="ReportErrorsServiceClient"/>.
    /// </summary>
    public sealed partial class ReportErrorsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ReportErrorsServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ReportErrorsServiceSettings"/>.
        /// </returns>
        public static ReportErrorsServiceSettings GetDefault() => new ReportErrorsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ReportErrorsServiceSettings"/> object with default settings.
        /// </summary>
        public ReportErrorsServiceSettings() { }

        private ReportErrorsServiceSettings(ReportErrorsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ReportErrorEventSettings = existing.ReportErrorEventSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ReportErrorsServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ReportErrorsServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ReportErrorsServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ReportErrorsServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ReportErrorsServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ReportErrorsServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="ReportErrorsServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ReportErrorsServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ReportErrorsServiceClient"/> RPC methods is defined as:
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
        /// <c>ReportErrorsServiceClient.ReportErrorEvent</c> and <c>ReportErrorsServiceClient.ReportErrorEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ReportErrorsServiceClient.ReportErrorEvent</c> and
        /// <c>ReportErrorsServiceClient.ReportErrorEventAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ReportErrorEventSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ReportErrorsServiceSettings"/> object.</returns>
        public ReportErrorsServiceSettings Clone() => new ReportErrorsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReportErrorsServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ReportErrorsServiceClientBuilder : gaxgrpc::ClientBuilderBase<ReportErrorsServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public ReportErrorsServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override ReportErrorsServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReportErrorsServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<ReportErrorsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReportErrorsServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => ReportErrorsServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ReportErrorsServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReportErrorsServiceClient.ChannelPool;
    }

    /// <summary>
    /// ReportErrorsService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ReportErrorsServiceClient
    {
        /// <summary>
        /// The default endpoint for the ReportErrorsService service, which is a host of "clouderrorreporting.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("clouderrorreporting.googleapis.com", 443);

        /// <summary>
        /// The default ReportErrorsService scopes.
        /// </summary>
        /// <remarks>
        /// The default ReportErrorsService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="ReportErrorsServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.ErrorReporting.V1Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ReportErrorsServiceClient client = await ReportErrorsServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.ErrorReporting.V1Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ReportErrorsServiceClient.DefaultEndpoint.Host, ReportErrorsServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ReportErrorsServiceClient client = ReportErrorsServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ReportErrorsServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ReportErrorsServiceClient"/>.</returns>
        public static async stt::Task<ReportErrorsServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ReportErrorsServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ReportErrorsServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.ErrorReporting.V1Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ReportErrorsServiceClient client = ReportErrorsServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.ErrorReporting.V1Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ReportErrorsServiceClient.DefaultEndpoint.Host, ReportErrorsServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ReportErrorsServiceClient client = ReportErrorsServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ReportErrorsServiceSettings"/>.</param>
        /// <returns>The created <see cref="ReportErrorsServiceClient"/>.</returns>
        public static ReportErrorsServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ReportErrorsServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ReportErrorsServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ReportErrorsServiceSettings"/>.</param>
        /// <returns>The created <see cref="ReportErrorsServiceClient"/>.</returns>
        public static ReportErrorsServiceClient Create(grpccore::Channel channel, ReportErrorsServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ReportErrorsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ReportErrorsServiceSettings"/>.</param>
        /// <returns>The created <see cref="ReportErrorsServiceClient"/>.</returns>
        public static ReportErrorsServiceClient Create(grpccore::CallInvoker callInvoker, ReportErrorsServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReportErrorsService.ReportErrorsServiceClient grpcClient = new ReportErrorsService.ReportErrorsServiceClient(callInvoker);
            return new ReportErrorsServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ReportErrorsServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ReportErrorsServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ReportErrorsServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ReportErrorsServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ReportErrorsService client.
        /// </summary>
        public virtual ReportErrorsService.ReportErrorsServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Report an individual error event.
        ///
        /// This endpoint accepts &lt;strong&gt;either&lt;/strong&gt; an OAuth token,
        /// &lt;strong&gt;or&lt;/strong&gt; an
        /// &lt;a href="https://support.google.com/cloud/answer/6158862"&gt;API key&lt;/a&gt;
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// &lt;pre&gt;POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/projects/example-project/events:report?key=123ABC456&lt;/pre&gt;
        /// </summary>
        /// <param name="projectName">
        /// [Required] The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840). Example:
        /// `projects/my-project-123`.
        /// </param>
        /// <param name="event">
        /// [Required] The error event to be reported.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ReportErrorEventResponse> ReportErrorEventAsync(
            gaxres::ProjectName projectName,
            ReportedErrorEvent @event,
            gaxgrpc::CallSettings callSettings = null) => ReportErrorEventAsync(
                new ReportErrorEventRequest
                {
                    ProjectNameAsProjectName = gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                    Event = gax::GaxPreconditions.CheckNotNull(@event, nameof(@event)),
                },
                callSettings);

        /// <summary>
        /// Report an individual error event.
        ///
        /// This endpoint accepts &lt;strong&gt;either&lt;/strong&gt; an OAuth token,
        /// &lt;strong&gt;or&lt;/strong&gt; an
        /// &lt;a href="https://support.google.com/cloud/answer/6158862"&gt;API key&lt;/a&gt;
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// &lt;pre&gt;POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/projects/example-project/events:report?key=123ABC456&lt;/pre&gt;
        /// </summary>
        /// <param name="projectName">
        /// [Required] The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840). Example:
        /// `projects/my-project-123`.
        /// </param>
        /// <param name="event">
        /// [Required] The error event to be reported.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ReportErrorEventResponse> ReportErrorEventAsync(
            gaxres::ProjectName projectName,
            ReportedErrorEvent @event,
            st::CancellationToken cancellationToken) => ReportErrorEventAsync(
                projectName,
                @event,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Report an individual error event.
        ///
        /// This endpoint accepts &lt;strong&gt;either&lt;/strong&gt; an OAuth token,
        /// &lt;strong&gt;or&lt;/strong&gt; an
        /// &lt;a href="https://support.google.com/cloud/answer/6158862"&gt;API key&lt;/a&gt;
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// &lt;pre&gt;POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/projects/example-project/events:report?key=123ABC456&lt;/pre&gt;
        /// </summary>
        /// <param name="projectName">
        /// [Required] The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840). Example:
        /// `projects/my-project-123`.
        /// </param>
        /// <param name="event">
        /// [Required] The error event to be reported.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ReportErrorEventResponse ReportErrorEvent(
            gaxres::ProjectName projectName,
            ReportedErrorEvent @event,
            gaxgrpc::CallSettings callSettings = null) => ReportErrorEvent(
                new ReportErrorEventRequest
                {
                    ProjectNameAsProjectName = gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                    Event = gax::GaxPreconditions.CheckNotNull(@event, nameof(@event)),
                },
                callSettings);

        /// <summary>
        /// Report an individual error event.
        ///
        /// This endpoint accepts &lt;strong&gt;either&lt;/strong&gt; an OAuth token,
        /// &lt;strong&gt;or&lt;/strong&gt; an
        /// &lt;a href="https://support.google.com/cloud/answer/6158862"&gt;API key&lt;/a&gt;
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// &lt;pre&gt;POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/projects/example-project/events:report?key=123ABC456&lt;/pre&gt;
        /// </summary>
        /// <param name="projectName">
        /// [Required] The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840). Example:
        /// `projects/my-project-123`.
        /// </param>
        /// <param name="event">
        /// [Required] The error event to be reported.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ReportErrorEventResponse> ReportErrorEventAsync(
            string projectName,
            ReportedErrorEvent @event,
            gaxgrpc::CallSettings callSettings = null) => ReportErrorEventAsync(
                new ReportErrorEventRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                    Event = gax::GaxPreconditions.CheckNotNull(@event, nameof(@event)),
                },
                callSettings);

        /// <summary>
        /// Report an individual error event.
        ///
        /// This endpoint accepts &lt;strong&gt;either&lt;/strong&gt; an OAuth token,
        /// &lt;strong&gt;or&lt;/strong&gt; an
        /// &lt;a href="https://support.google.com/cloud/answer/6158862"&gt;API key&lt;/a&gt;
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// &lt;pre&gt;POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/projects/example-project/events:report?key=123ABC456&lt;/pre&gt;
        /// </summary>
        /// <param name="projectName">
        /// [Required] The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840). Example:
        /// `projects/my-project-123`.
        /// </param>
        /// <param name="event">
        /// [Required] The error event to be reported.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ReportErrorEventResponse> ReportErrorEventAsync(
            string projectName,
            ReportedErrorEvent @event,
            st::CancellationToken cancellationToken) => ReportErrorEventAsync(
                projectName,
                @event,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Report an individual error event.
        ///
        /// This endpoint accepts &lt;strong&gt;either&lt;/strong&gt; an OAuth token,
        /// &lt;strong&gt;or&lt;/strong&gt; an
        /// &lt;a href="https://support.google.com/cloud/answer/6158862"&gt;API key&lt;/a&gt;
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// &lt;pre&gt;POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/projects/example-project/events:report?key=123ABC456&lt;/pre&gt;
        /// </summary>
        /// <param name="projectName">
        /// [Required] The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840). Example:
        /// `projects/my-project-123`.
        /// </param>
        /// <param name="event">
        /// [Required] The error event to be reported.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ReportErrorEventResponse ReportErrorEvent(
            string projectName,
            ReportedErrorEvent @event,
            gaxgrpc::CallSettings callSettings = null) => ReportErrorEvent(
                new ReportErrorEventRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                    Event = gax::GaxPreconditions.CheckNotNull(@event, nameof(@event)),
                },
                callSettings);

        /// <summary>
        /// Report an individual error event.
        ///
        /// This endpoint accepts &lt;strong&gt;either&lt;/strong&gt; an OAuth token,
        /// &lt;strong&gt;or&lt;/strong&gt; an
        /// &lt;a href="https://support.google.com/cloud/answer/6158862"&gt;API key&lt;/a&gt;
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// &lt;pre&gt;POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/projects/example-project/events:report?key=123ABC456&lt;/pre&gt;
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
        public virtual stt::Task<ReportErrorEventResponse> ReportErrorEventAsync(
            ReportErrorEventRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Report an individual error event.
        ///
        /// This endpoint accepts &lt;strong&gt;either&lt;/strong&gt; an OAuth token,
        /// &lt;strong&gt;or&lt;/strong&gt; an
        /// &lt;a href="https://support.google.com/cloud/answer/6158862"&gt;API key&lt;/a&gt;
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// &lt;pre&gt;POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/projects/example-project/events:report?key=123ABC456&lt;/pre&gt;
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
        public virtual stt::Task<ReportErrorEventResponse> ReportErrorEventAsync(
            ReportErrorEventRequest request,
            st::CancellationToken cancellationToken) => ReportErrorEventAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Report an individual error event.
        ///
        /// This endpoint accepts &lt;strong&gt;either&lt;/strong&gt; an OAuth token,
        /// &lt;strong&gt;or&lt;/strong&gt; an
        /// &lt;a href="https://support.google.com/cloud/answer/6158862"&gt;API key&lt;/a&gt;
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// &lt;pre&gt;POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/projects/example-project/events:report?key=123ABC456&lt;/pre&gt;
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
        public virtual ReportErrorEventResponse ReportErrorEvent(
            ReportErrorEventRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// ReportErrorsService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ReportErrorsServiceClientImpl : ReportErrorsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ReportErrorEventRequest, ReportErrorEventResponse> _callReportErrorEvent;

        /// <summary>
        /// Constructs a client wrapper for the ReportErrorsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ReportErrorsServiceSettings"/> used within this client </param>
        public ReportErrorsServiceClientImpl(ReportErrorsService.ReportErrorsServiceClient grpcClient, ReportErrorsServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ReportErrorsServiceSettings effectiveSettings = settings ?? ReportErrorsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callReportErrorEvent = clientHelper.BuildApiCall<ReportErrorEventRequest, ReportErrorEventResponse>(
                GrpcClient.ReportErrorEventAsync, GrpcClient.ReportErrorEvent, effectiveSettings.ReportErrorEventSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"project_name={request.ProjectName}"));
            Modify_ApiCall(ref _callReportErrorEvent);
            Modify_ReportErrorEventApiCall(ref _callReportErrorEvent);
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
        partial void Modify_ReportErrorEventApiCall(ref gaxgrpc::ApiCall<ReportErrorEventRequest, ReportErrorEventResponse> call);
        partial void OnConstruction(ReportErrorsService.ReportErrorsServiceClient grpcClient, ReportErrorsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ReportErrorsService client.
        /// </summary>
        public override ReportErrorsService.ReportErrorsServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ReportErrorEventRequest(ref ReportErrorEventRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Report an individual error event.
        ///
        /// This endpoint accepts &lt;strong&gt;either&lt;/strong&gt; an OAuth token,
        /// &lt;strong&gt;or&lt;/strong&gt; an
        /// &lt;a href="https://support.google.com/cloud/answer/6158862"&gt;API key&lt;/a&gt;
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// &lt;pre&gt;POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/projects/example-project/events:report?key=123ABC456&lt;/pre&gt;
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
        public override stt::Task<ReportErrorEventResponse> ReportErrorEventAsync(
            ReportErrorEventRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportErrorEventRequest(ref request, ref callSettings);
            return _callReportErrorEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Report an individual error event.
        ///
        /// This endpoint accepts &lt;strong&gt;either&lt;/strong&gt; an OAuth token,
        /// &lt;strong&gt;or&lt;/strong&gt; an
        /// &lt;a href="https://support.google.com/cloud/answer/6158862"&gt;API key&lt;/a&gt;
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// &lt;pre&gt;POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/projects/example-project/events:report?key=123ABC456&lt;/pre&gt;
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
        public override ReportErrorEventResponse ReportErrorEvent(
            ReportErrorEventRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportErrorEventRequest(ref request, ref callSettings);
            return _callReportErrorEvent.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
