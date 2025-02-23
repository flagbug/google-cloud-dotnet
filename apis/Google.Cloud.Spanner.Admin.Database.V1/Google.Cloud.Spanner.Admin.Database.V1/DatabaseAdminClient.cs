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
using iam = Google.Cloud.Iam.V1;
using gcscv = Google.Cloud.Spanner.Common.V1;
using lro = Google.LongRunning;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Spanner.Admin.Database.V1
{
    /// <summary>
    /// Settings for a <see cref="DatabaseAdminClient"/>.
    /// </summary>
    public sealed partial class DatabaseAdminSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="DatabaseAdminSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="DatabaseAdminSettings"/>.
        /// </returns>
        public static DatabaseAdminSettings GetDefault() => new DatabaseAdminSettings();

        /// <summary>
        /// Constructs a new <see cref="DatabaseAdminSettings"/> object with default settings.
        /// </summary>
        public DatabaseAdminSettings() { }

        private DatabaseAdminSettings(DatabaseAdminSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListDatabasesSettings = existing.ListDatabasesSettings;
            CreateDatabaseSettings = existing.CreateDatabaseSettings;
            CreateDatabaseOperationsSettings = existing.CreateDatabaseOperationsSettings?.Clone();
            GetDatabaseSettings = existing.GetDatabaseSettings;
            UpdateDatabaseDdlSettings = existing.UpdateDatabaseDdlSettings;
            UpdateDatabaseDdlOperationsSettings = existing.UpdateDatabaseDdlOperationsSettings?.Clone();
            DropDatabaseSettings = existing.DropDatabaseSettings;
            GetDatabaseDdlSettings = existing.GetDatabaseDdlSettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DatabaseAdminSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="DatabaseAdminClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="DatabaseAdminClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="DatabaseAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="DatabaseAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="DatabaseAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 1000 milliseconds</description></item>
        /// <item><description>Maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(1000),
            maxDelay: sys::TimeSpan.FromMilliseconds(32000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="DatabaseAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="DatabaseAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="DatabaseAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(60000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.ListDatabases</c> and <c>DatabaseAdminClient.ListDatabasesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.ListDatabases</c> and
        /// <c>DatabaseAdminClient.ListDatabasesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListDatabasesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.CreateDatabase</c> and <c>DatabaseAdminClient.CreateDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.CreateDatabase</c> and
        /// <c>DatabaseAdminClient.CreateDatabaseAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateDatabaseSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatabaseAdminClient.CreateDatabase</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45000 milliseconds</description></item>
        /// <item><description>Total timeout: 86400000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateDatabaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(86400000L)),
                sys::TimeSpan.FromMilliseconds(20000L),
                1.5,
                sys::TimeSpan.FromMilliseconds(45000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.GetDatabase</c> and <c>DatabaseAdminClient.GetDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.GetDatabase</c> and
        /// <c>DatabaseAdminClient.GetDatabaseAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetDatabaseSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.UpdateDatabaseDdl</c> and <c>DatabaseAdminClient.UpdateDatabaseDdlAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.UpdateDatabaseDdl</c> and
        /// <c>DatabaseAdminClient.UpdateDatabaseDdlAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDatabaseDdlSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatabaseAdminClient.UpdateDatabaseDdl</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45000 milliseconds</description></item>
        /// <item><description>Total timeout: 86400000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateDatabaseDdlOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(86400000L)),
                sys::TimeSpan.FromMilliseconds(20000L),
                1.5,
                sys::TimeSpan.FromMilliseconds(45000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.DropDatabase</c> and <c>DatabaseAdminClient.DropDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.DropDatabase</c> and
        /// <c>DatabaseAdminClient.DropDatabaseAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DropDatabaseSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.GetDatabaseDdl</c> and <c>DatabaseAdminClient.GetDatabaseDdlAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.GetDatabaseDdl</c> and
        /// <c>DatabaseAdminClient.GetDatabaseDdlAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetDatabaseDdlSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.SetIamPolicy</c> and <c>DatabaseAdminClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.SetIamPolicy</c> and
        /// <c>DatabaseAdminClient.SetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.GetIamPolicy</c> and <c>DatabaseAdminClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.GetIamPolicy</c> and
        /// <c>DatabaseAdminClient.GetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.TestIamPermissions</c> and <c>DatabaseAdminClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.TestIamPermissions</c> and
        /// <c>DatabaseAdminClient.TestIamPermissionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="DatabaseAdminSettings"/> object.</returns>
        public DatabaseAdminSettings Clone() => new DatabaseAdminSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DatabaseAdminClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DatabaseAdminClientBuilder : gaxgrpc::ClientBuilderBase<DatabaseAdminClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public DatabaseAdminSettings Settings { get; set; }

        /// <inheritdoc/>
        public override DatabaseAdminClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DatabaseAdminClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<DatabaseAdminClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DatabaseAdminClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => DatabaseAdminClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DatabaseAdminClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => DatabaseAdminClient.ChannelPool;
    }

    /// <summary>
    /// DatabaseAdmin client wrapper, for convenient use.
    /// </summary>
    public abstract partial class DatabaseAdminClient
    {
        /// <summary>
        /// The default endpoint for the DatabaseAdmin service, which is a host of "spanner.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("spanner.googleapis.com", 443);

        /// <summary>
        /// The default DatabaseAdmin scopes.
        /// </summary>
        /// <remarks>
        /// The default DatabaseAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/spanner.admin"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/spanner.admin",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="DatabaseAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Spanner.Admin.Database.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// DatabaseAdminClient client = await DatabaseAdminClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Spanner.Admin.Database.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     DatabaseAdminClient.DefaultEndpoint.Host, DatabaseAdminClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// DatabaseAdminClient client = DatabaseAdminClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DatabaseAdminSettings"/>.</param>
        /// <returns>The task representing the created <see cref="DatabaseAdminClient"/>.</returns>
        public static async stt::Task<DatabaseAdminClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, DatabaseAdminSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="DatabaseAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Spanner.Admin.Database.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// DatabaseAdminClient client = DatabaseAdminClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Spanner.Admin.Database.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     DatabaseAdminClient.DefaultEndpoint.Host, DatabaseAdminClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// DatabaseAdminClient client = DatabaseAdminClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DatabaseAdminSettings"/>.</param>
        /// <returns>The created <see cref="DatabaseAdminClient"/>.</returns>
        public static DatabaseAdminClient Create(gaxgrpc::ServiceEndpoint endpoint = null, DatabaseAdminSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="DatabaseAdminClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="DatabaseAdminSettings"/>.</param>
        /// <returns>The created <see cref="DatabaseAdminClient"/>.</returns>
        public static DatabaseAdminClient Create(grpccore::Channel channel, DatabaseAdminSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="DatabaseAdminClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="DatabaseAdminSettings"/>.</param>
        /// <returns>The created <see cref="DatabaseAdminClient"/>.</returns>
        public static DatabaseAdminClient Create(grpccore::CallInvoker callInvoker, DatabaseAdminSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DatabaseAdmin.DatabaseAdminClient grpcClient = new DatabaseAdmin.DatabaseAdminClient(callInvoker);
            return new DatabaseAdminClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, DatabaseAdminSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, DatabaseAdminSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, DatabaseAdminSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, DatabaseAdminSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC DatabaseAdmin client.
        /// </summary>
        public virtual DatabaseAdmin.DatabaseAdminClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Lists Cloud Spanner databases.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance whose databases should be listed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// A pageable asynchronous sequence of <see cref="Database"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDatabasesResponse, Database> ListDatabasesAsync(
            gcscv::InstanceName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListDatabasesAsync(
                new ListDatabasesRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists Cloud Spanner databases.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance whose databases should be listed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// A pageable sequence of <see cref="Database"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListDatabasesResponse, Database> ListDatabases(
            gcscv::InstanceName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListDatabases(
                new ListDatabasesRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists Cloud Spanner databases.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance whose databases should be listed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// A pageable asynchronous sequence of <see cref="Database"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDatabasesResponse, Database> ListDatabasesAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListDatabasesAsync(
                new ListDatabasesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists Cloud Spanner databases.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance whose databases should be listed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// A pageable sequence of <see cref="Database"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListDatabasesResponse, Database> ListDatabases(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListDatabases(
                new ListDatabasesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists Cloud Spanner databases.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Database"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDatabasesResponse, Database> ListDatabasesAsync(
            ListDatabasesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists Cloud Spanner databases.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Database"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListDatabasesResponse, Database> ListDatabases(
            ListDatabasesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the instance that will serve the new database.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="createStatement">
        /// Required. A `CREATE DATABASE` statement, which specifies the ID of the
        /// new database.  The database ID must conform to the regular expression
        /// `[a-z][a-z0-9_\-]*[a-z0-9]` and be between 2 and 30 characters in length.
        /// If the database ID is a reserved word or if it contains a hyphen, the
        /// database ID must be enclosed in backticks (`` ` ``).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Database, CreateDatabaseMetadata>> CreateDatabaseAsync(
            gcscv::InstanceName parent,
            string createStatement,
            gaxgrpc::CallSettings callSettings = null) => CreateDatabaseAsync(
                new CreateDatabaseRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    CreateStatement = gax::GaxPreconditions.CheckNotNullOrEmpty(createStatement, nameof(createStatement)),
                },
                callSettings);

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the instance that will serve the new database.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="createStatement">
        /// Required. A `CREATE DATABASE` statement, which specifies the ID of the
        /// new database.  The database ID must conform to the regular expression
        /// `[a-z][a-z0-9_\-]*[a-z0-9]` and be between 2 and 30 characters in length.
        /// If the database ID is a reserved word or if it contains a hyphen, the
        /// database ID must be enclosed in backticks (`` ` ``).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Database, CreateDatabaseMetadata>> CreateDatabaseAsync(
            gcscv::InstanceName parent,
            string createStatement,
            st::CancellationToken cancellationToken) => CreateDatabaseAsync(
                parent,
                createStatement,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the instance that will serve the new database.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="createStatement">
        /// Required. A `CREATE DATABASE` statement, which specifies the ID of the
        /// new database.  The database ID must conform to the regular expression
        /// `[a-z][a-z0-9_\-]*[a-z0-9]` and be between 2 and 30 characters in length.
        /// If the database ID is a reserved word or if it contains a hyphen, the
        /// database ID must be enclosed in backticks (`` ` ``).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<Database, CreateDatabaseMetadata> CreateDatabase(
            gcscv::InstanceName parent,
            string createStatement,
            gaxgrpc::CallSettings callSettings = null) => CreateDatabase(
                new CreateDatabaseRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    CreateStatement = gax::GaxPreconditions.CheckNotNullOrEmpty(createStatement, nameof(createStatement)),
                },
                callSettings);

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the instance that will serve the new database.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="createStatement">
        /// Required. A `CREATE DATABASE` statement, which specifies the ID of the
        /// new database.  The database ID must conform to the regular expression
        /// `[a-z][a-z0-9_\-]*[a-z0-9]` and be between 2 and 30 characters in length.
        /// If the database ID is a reserved word or if it contains a hyphen, the
        /// database ID must be enclosed in backticks (`` ` ``).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Database, CreateDatabaseMetadata>> CreateDatabaseAsync(
            string parent,
            string createStatement,
            gaxgrpc::CallSettings callSettings = null) => CreateDatabaseAsync(
                new CreateDatabaseRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    CreateStatement = gax::GaxPreconditions.CheckNotNullOrEmpty(createStatement, nameof(createStatement)),
                },
                callSettings);

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the instance that will serve the new database.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="createStatement">
        /// Required. A `CREATE DATABASE` statement, which specifies the ID of the
        /// new database.  The database ID must conform to the regular expression
        /// `[a-z][a-z0-9_\-]*[a-z0-9]` and be between 2 and 30 characters in length.
        /// If the database ID is a reserved word or if it contains a hyphen, the
        /// database ID must be enclosed in backticks (`` ` ``).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Database, CreateDatabaseMetadata>> CreateDatabaseAsync(
            string parent,
            string createStatement,
            st::CancellationToken cancellationToken) => CreateDatabaseAsync(
                parent,
                createStatement,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the instance that will serve the new database.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="createStatement">
        /// Required. A `CREATE DATABASE` statement, which specifies the ID of the
        /// new database.  The database ID must conform to the regular expression
        /// `[a-z][a-z0-9_\-]*[a-z0-9]` and be between 2 and 30 characters in length.
        /// If the database ID is a reserved word or if it contains a hyphen, the
        /// database ID must be enclosed in backticks (`` ` ``).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<Database, CreateDatabaseMetadata> CreateDatabase(
            string parent,
            string createStatement,
            gaxgrpc::CallSettings callSettings = null) => CreateDatabase(
                new CreateDatabaseRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    CreateStatement = gax::GaxPreconditions.CheckNotNullOrEmpty(createStatement, nameof(createStatement)),
                },
                callSettings);

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
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
        public virtual stt::Task<lro::Operation<Database, CreateDatabaseMetadata>> CreateDatabaseAsync(
            CreateDatabaseRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDatabaseAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Database, CreateDatabaseMetadata>> PollOnceCreateDatabaseAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Database, CreateDatabaseMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateDatabaseOperationsClient,
                callSettings);

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
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
        public virtual lro::Operation<Database, CreateDatabaseMetadata> CreateDatabase(
            CreateDatabaseRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateDatabase</c>.
        /// </summary>
        public virtual lro::OperationsClient CreateDatabaseOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDatabase</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Database, CreateDatabaseMetadata> PollOnceCreateDatabase(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Database, CreateDatabaseMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateDatabaseOperationsClient,
                callSettings);

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested database. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/databases/&lt;database&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Database> GetDatabaseAsync(
            gcscv::DatabaseName name,
            gaxgrpc::CallSettings callSettings = null) => GetDatabaseAsync(
                new GetDatabaseRequest
                {
                    DatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested database. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/databases/&lt;database&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Database> GetDatabaseAsync(
            gcscv::DatabaseName name,
            st::CancellationToken cancellationToken) => GetDatabaseAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested database. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/databases/&lt;database&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Database GetDatabase(
            gcscv::DatabaseName name,
            gaxgrpc::CallSettings callSettings = null) => GetDatabase(
                new GetDatabaseRequest
                {
                    DatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested database. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/databases/&lt;database&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Database> GetDatabaseAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetDatabaseAsync(
                new GetDatabaseRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested database. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/databases/&lt;database&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Database> GetDatabaseAsync(
            string name,
            st::CancellationToken cancellationToken) => GetDatabaseAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested database. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/databases/&lt;database&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Database GetDatabase(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetDatabase(
                new GetDatabaseRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
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
        public virtual stt::Task<Database> GetDatabaseAsync(
            GetDatabaseRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
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
        public virtual stt::Task<Database> GetDatabaseAsync(
            GetDatabaseRequest request,
            st::CancellationToken cancellationToken) => GetDatabaseAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
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
        public virtual Database GetDatabase(
            GetDatabaseRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].
        /// The operation has no response.
        /// </summary>
        /// <param name="database">
        /// Required. The database to update.
        /// </param>
        /// <param name="statements">
        /// DDL statements to be applied to the database.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, UpdateDatabaseDdlMetadata>> UpdateDatabaseDdlAsync(
            gcscv::DatabaseName database,
            scg::IEnumerable<string> statements,
            gaxgrpc::CallSettings callSettings = null) => UpdateDatabaseDdlAsync(
                new UpdateDatabaseDdlRequest
                {
                    DatabaseAsDatabaseName = gax::GaxPreconditions.CheckNotNull(database, nameof(database)),
                    Statements = { gax::GaxPreconditions.CheckNotNull(statements, nameof(statements)) },
                },
                callSettings);

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].
        /// The operation has no response.
        /// </summary>
        /// <param name="database">
        /// Required. The database to update.
        /// </param>
        /// <param name="statements">
        /// DDL statements to be applied to the database.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, UpdateDatabaseDdlMetadata>> UpdateDatabaseDdlAsync(
            gcscv::DatabaseName database,
            scg::IEnumerable<string> statements,
            st::CancellationToken cancellationToken) => UpdateDatabaseDdlAsync(
                database,
                statements,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].
        /// The operation has no response.
        /// </summary>
        /// <param name="database">
        /// Required. The database to update.
        /// </param>
        /// <param name="statements">
        /// DDL statements to be applied to the database.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, UpdateDatabaseDdlMetadata> UpdateDatabaseDdl(
            gcscv::DatabaseName database,
            scg::IEnumerable<string> statements,
            gaxgrpc::CallSettings callSettings = null) => UpdateDatabaseDdl(
                new UpdateDatabaseDdlRequest
                {
                    DatabaseAsDatabaseName = gax::GaxPreconditions.CheckNotNull(database, nameof(database)),
                    Statements = { gax::GaxPreconditions.CheckNotNull(statements, nameof(statements)) },
                },
                callSettings);

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].
        /// The operation has no response.
        /// </summary>
        /// <param name="database">
        /// Required. The database to update.
        /// </param>
        /// <param name="statements">
        /// DDL statements to be applied to the database.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, UpdateDatabaseDdlMetadata>> UpdateDatabaseDdlAsync(
            string database,
            scg::IEnumerable<string> statements,
            gaxgrpc::CallSettings callSettings = null) => UpdateDatabaseDdlAsync(
                new UpdateDatabaseDdlRequest
                {
                    Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                    Statements = { gax::GaxPreconditions.CheckNotNull(statements, nameof(statements)) },
                },
                callSettings);

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].
        /// The operation has no response.
        /// </summary>
        /// <param name="database">
        /// Required. The database to update.
        /// </param>
        /// <param name="statements">
        /// DDL statements to be applied to the database.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, UpdateDatabaseDdlMetadata>> UpdateDatabaseDdlAsync(
            string database,
            scg::IEnumerable<string> statements,
            st::CancellationToken cancellationToken) => UpdateDatabaseDdlAsync(
                database,
                statements,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].
        /// The operation has no response.
        /// </summary>
        /// <param name="database">
        /// Required. The database to update.
        /// </param>
        /// <param name="statements">
        /// DDL statements to be applied to the database.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, UpdateDatabaseDdlMetadata> UpdateDatabaseDdl(
            string database,
            scg::IEnumerable<string> statements,
            gaxgrpc::CallSettings callSettings = null) => UpdateDatabaseDdl(
                new UpdateDatabaseDdlRequest
                {
                    Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                    Statements = { gax::GaxPreconditions.CheckNotNull(statements, nameof(statements)) },
                },
                callSettings);

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].
        /// The operation has no response.
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, UpdateDatabaseDdlMetadata>> UpdateDatabaseDdlAsync(
            UpdateDatabaseDdlRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDatabaseDdlAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, UpdateDatabaseDdlMetadata>> PollOnceUpdateDatabaseDdlAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, UpdateDatabaseDdlMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateDatabaseDdlOperationsClient,
                callSettings);

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].
        /// The operation has no response.
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
        public virtual lro::Operation<pbwkt::Empty, UpdateDatabaseDdlMetadata> UpdateDatabaseDdl(
            UpdateDatabaseDdlRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateDatabaseDdl</c>.
        /// </summary>
        public virtual lro::OperationsClient UpdateDatabaseDdlOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDatabaseDdl</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<pbwkt::Empty, UpdateDatabaseDdlMetadata> PollOnceUpdateDatabaseDdl(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, UpdateDatabaseDdlMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateDatabaseDdlOperationsClient,
                callSettings);

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
        /// </summary>
        /// <param name="database">
        /// Required. The database to be dropped.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DropDatabaseAsync(
            gcscv::DatabaseName database,
            gaxgrpc::CallSettings callSettings = null) => DropDatabaseAsync(
                new DropDatabaseRequest
                {
                    DatabaseAsDatabaseName = gax::GaxPreconditions.CheckNotNull(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
        /// </summary>
        /// <param name="database">
        /// Required. The database to be dropped.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DropDatabaseAsync(
            gcscv::DatabaseName database,
            st::CancellationToken cancellationToken) => DropDatabaseAsync(
                database,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
        /// </summary>
        /// <param name="database">
        /// Required. The database to be dropped.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DropDatabase(
            gcscv::DatabaseName database,
            gaxgrpc::CallSettings callSettings = null) => DropDatabase(
                new DropDatabaseRequest
                {
                    DatabaseAsDatabaseName = gax::GaxPreconditions.CheckNotNull(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
        /// </summary>
        /// <param name="database">
        /// Required. The database to be dropped.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DropDatabaseAsync(
            string database,
            gaxgrpc::CallSettings callSettings = null) => DropDatabaseAsync(
                new DropDatabaseRequest
                {
                    Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
        /// </summary>
        /// <param name="database">
        /// Required. The database to be dropped.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DropDatabaseAsync(
            string database,
            st::CancellationToken cancellationToken) => DropDatabaseAsync(
                database,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
        /// </summary>
        /// <param name="database">
        /// Required. The database to be dropped.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DropDatabase(
            string database,
            gaxgrpc::CallSettings callSettings = null) => DropDatabase(
                new DropDatabaseRequest
                {
                    Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
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
        public virtual stt::Task DropDatabaseAsync(
            DropDatabaseRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
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
        public virtual stt::Task DropDatabaseAsync(
            DropDatabaseRequest request,
            st::CancellationToken cancellationToken) => DropDatabaseAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DropDatabase(
            DropDatabaseRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
        /// </summary>
        /// <param name="database">
        /// Required. The database whose schema we wish to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GetDatabaseDdlResponse> GetDatabaseDdlAsync(
            gcscv::DatabaseName database,
            gaxgrpc::CallSettings callSettings = null) => GetDatabaseDdlAsync(
                new GetDatabaseDdlRequest
                {
                    DatabaseAsDatabaseName = gax::GaxPreconditions.CheckNotNull(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
        /// </summary>
        /// <param name="database">
        /// Required. The database whose schema we wish to get.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GetDatabaseDdlResponse> GetDatabaseDdlAsync(
            gcscv::DatabaseName database,
            st::CancellationToken cancellationToken) => GetDatabaseDdlAsync(
                database,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
        /// </summary>
        /// <param name="database">
        /// Required. The database whose schema we wish to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual GetDatabaseDdlResponse GetDatabaseDdl(
            gcscv::DatabaseName database,
            gaxgrpc::CallSettings callSettings = null) => GetDatabaseDdl(
                new GetDatabaseDdlRequest
                {
                    DatabaseAsDatabaseName = gax::GaxPreconditions.CheckNotNull(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
        /// </summary>
        /// <param name="database">
        /// Required. The database whose schema we wish to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GetDatabaseDdlResponse> GetDatabaseDdlAsync(
            string database,
            gaxgrpc::CallSettings callSettings = null) => GetDatabaseDdlAsync(
                new GetDatabaseDdlRequest
                {
                    Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
        /// </summary>
        /// <param name="database">
        /// Required. The database whose schema we wish to get.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GetDatabaseDdlResponse> GetDatabaseDdlAsync(
            string database,
            st::CancellationToken cancellationToken) => GetDatabaseDdlAsync(
                database,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
        /// </summary>
        /// <param name="database">
        /// Required. The database whose schema we wish to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual GetDatabaseDdlResponse GetDatabaseDdl(
            string database,
            gaxgrpc::CallSettings callSettings = null) => GetDatabaseDdl(
                new GetDatabaseDdlRequest
                {
                    Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
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
        public virtual stt::Task<GetDatabaseDdlResponse> GetDatabaseDdlAsync(
            GetDatabaseDdlRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
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
        public virtual stt::Task<GetDatabaseDdlResponse> GetDatabaseDdlAsync(
            GetDatabaseDdlRequest request,
            st::CancellationToken cancellationToken) => GetDatabaseDdlAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
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
        public virtual GetDatabaseDdlResponse GetDatabaseDdl(
            GetDatabaseDdlRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on a database resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.databases.setIamPolicy` permission on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            string resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicyAsync(
                new iam::SetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on a database resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.databases.setIamPolicy` permission on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            string resource,
            iam::Policy policy,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                resource,
                policy,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on a database resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.databases.setIamPolicy` permission on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy SetIamPolicy(
            string resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicy(
                new iam::SetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on a database resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.databases.setIamPolicy` permission on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on a database resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.databases.setIamPolicy` permission on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on a database resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.databases.setIamPolicy` permission on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        public virtual iam::Policy SetIamPolicy(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for a database resource. Returns an empty
        /// policy if a database exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.databases.getIamPolicy` permission on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            string resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicyAsync(
                new iam::GetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a database resource. Returns an empty
        /// policy if a database exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.databases.getIamPolicy` permission on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            string resource,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                resource,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a database resource. Returns an empty
        /// policy if a database exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.databases.getIamPolicy` permission on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy GetIamPolicy(
            string resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicy(
                new iam::GetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a database resource. Returns an empty
        /// policy if a database exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.databases.getIamPolicy` permission on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for a database resource. Returns an empty
        /// policy if a database exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.databases.getIamPolicy` permission on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a database resource. Returns an empty
        /// policy if a database exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.databases.getIamPolicy` permission on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        public virtual iam::Policy GetIamPolicy(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns permissions that the caller has on the specified database resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner database will result in
        /// a NOT_FOUND error if the user has `spanner.databases.list` permission on
        /// the containing Cloud Spanner instance. Otherwise returns an empty set of
        /// permissions.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissionsAsync(
                new iam::TestIamPermissionsRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns permissions that the caller has on the specified database resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner database will result in
        /// a NOT_FOUND error if the user has `spanner.databases.list` permission on
        /// the containing Cloud Spanner instance. Otherwise returns an empty set of
        /// permissions.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            scg::IEnumerable<string> permissions,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                resource,
                permissions,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that the caller has on the specified database resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner database will result in
        /// a NOT_FOUND error if the user has `spanner.databases.list` permission on
        /// the containing Cloud Spanner instance. Otherwise returns an empty set of
        /// permissions.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::TestIamPermissionsResponse TestIamPermissions(
            string resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissions(
                new iam::TestIamPermissionsRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns permissions that the caller has on the specified database resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner database will result in
        /// a NOT_FOUND error if the user has `spanner.databases.list` permission on
        /// the containing Cloud Spanner instance. Otherwise returns an empty set of
        /// permissions.
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
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns permissions that the caller has on the specified database resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner database will result in
        /// a NOT_FOUND error if the user has `spanner.databases.list` permission on
        /// the containing Cloud Spanner instance. Otherwise returns an empty set of
        /// permissions.
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
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that the caller has on the specified database resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner database will result in
        /// a NOT_FOUND error if the user has `spanner.databases.list` permission on
        /// the containing Cloud Spanner instance. Otherwise returns an empty set of
        /// permissions.
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
        public virtual iam::TestIamPermissionsResponse TestIamPermissions(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// DatabaseAdmin client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class DatabaseAdminClientImpl : DatabaseAdminClient
    {
        private readonly gaxgrpc::ApiCall<ListDatabasesRequest, ListDatabasesResponse> _callListDatabases;
        private readonly gaxgrpc::ApiCall<CreateDatabaseRequest, lro::Operation> _callCreateDatabase;
        private readonly gaxgrpc::ApiCall<GetDatabaseRequest, Database> _callGetDatabase;
        private readonly gaxgrpc::ApiCall<UpdateDatabaseDdlRequest, lro::Operation> _callUpdateDatabaseDdl;
        private readonly gaxgrpc::ApiCall<DropDatabaseRequest, pbwkt::Empty> _callDropDatabase;
        private readonly gaxgrpc::ApiCall<GetDatabaseDdlRequest, GetDatabaseDdlResponse> _callGetDatabaseDdl;
        private readonly gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> _callSetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> _callGetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the DatabaseAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DatabaseAdminSettings"/> used within this client </param>
        public DatabaseAdminClientImpl(DatabaseAdmin.DatabaseAdminClient grpcClient, DatabaseAdminSettings settings)
        {
            GrpcClient = grpcClient;
            DatabaseAdminSettings effectiveSettings = settings ?? DatabaseAdminSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateDatabaseOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateDatabaseOperationsSettings);
            UpdateDatabaseDdlOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDatabaseDdlOperationsSettings);
            _callListDatabases = clientHelper.BuildApiCall<ListDatabasesRequest, ListDatabasesResponse>(
                GrpcClient.ListDatabasesAsync, GrpcClient.ListDatabases, effectiveSettings.ListDatabasesSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callCreateDatabase = clientHelper.BuildApiCall<CreateDatabaseRequest, lro::Operation>(
                GrpcClient.CreateDatabaseAsync, GrpcClient.CreateDatabase, effectiveSettings.CreateDatabaseSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callGetDatabase = clientHelper.BuildApiCall<GetDatabaseRequest, Database>(
                GrpcClient.GetDatabaseAsync, GrpcClient.GetDatabase, effectiveSettings.GetDatabaseSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callUpdateDatabaseDdl = clientHelper.BuildApiCall<UpdateDatabaseDdlRequest, lro::Operation>(
                GrpcClient.UpdateDatabaseDdlAsync, GrpcClient.UpdateDatabaseDdl, effectiveSettings.UpdateDatabaseDdlSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"database={request.Database}"));
            _callDropDatabase = clientHelper.BuildApiCall<DropDatabaseRequest, pbwkt::Empty>(
                GrpcClient.DropDatabaseAsync, GrpcClient.DropDatabase, effectiveSettings.DropDatabaseSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"database={request.Database}"));
            _callGetDatabaseDdl = clientHelper.BuildApiCall<GetDatabaseDdlRequest, GetDatabaseDdlResponse>(
                GrpcClient.GetDatabaseDdlAsync, GrpcClient.GetDatabaseDdl, effectiveSettings.GetDatabaseDdlSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"database={request.Database}"));
            _callSetIamPolicy = clientHelper.BuildApiCall<iam::SetIamPolicyRequest, iam::Policy>(
                GrpcClient.SetIamPolicyAsync, GrpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            _callGetIamPolicy = clientHelper.BuildApiCall<iam::GetIamPolicyRequest, iam::Policy>(
                GrpcClient.GetIamPolicyAsync, GrpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            _callTestIamPermissions = clientHelper.BuildApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse>(
                GrpcClient.TestIamPermissionsAsync, GrpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            Modify_ApiCall(ref _callListDatabases);
            Modify_ListDatabasesApiCall(ref _callListDatabases);
            Modify_ApiCall(ref _callCreateDatabase);
            Modify_CreateDatabaseApiCall(ref _callCreateDatabase);
            Modify_ApiCall(ref _callGetDatabase);
            Modify_GetDatabaseApiCall(ref _callGetDatabase);
            Modify_ApiCall(ref _callUpdateDatabaseDdl);
            Modify_UpdateDatabaseDdlApiCall(ref _callUpdateDatabaseDdl);
            Modify_ApiCall(ref _callDropDatabase);
            Modify_DropDatabaseApiCall(ref _callDropDatabase);
            Modify_ApiCall(ref _callGetDatabaseDdl);
            Modify_GetDatabaseDdlApiCall(ref _callGetDatabaseDdl);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
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
        partial void Modify_ListDatabasesApiCall(ref gaxgrpc::ApiCall<ListDatabasesRequest, ListDatabasesResponse> call);
        partial void Modify_CreateDatabaseApiCall(ref gaxgrpc::ApiCall<CreateDatabaseRequest, lro::Operation> call);
        partial void Modify_GetDatabaseApiCall(ref gaxgrpc::ApiCall<GetDatabaseRequest, Database> call);
        partial void Modify_UpdateDatabaseDdlApiCall(ref gaxgrpc::ApiCall<UpdateDatabaseDdlRequest, lro::Operation> call);
        partial void Modify_DropDatabaseApiCall(ref gaxgrpc::ApiCall<DropDatabaseRequest, pbwkt::Empty> call);
        partial void Modify_GetDatabaseDdlApiCall(ref gaxgrpc::ApiCall<GetDatabaseDdlRequest, GetDatabaseDdlResponse> call);
        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> call);
        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> call);
        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> call);
        partial void OnConstruction(DatabaseAdmin.DatabaseAdminClient grpcClient, DatabaseAdminSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC DatabaseAdmin client.
        /// </summary>
        public override DatabaseAdmin.DatabaseAdminClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListDatabasesRequest(ref ListDatabasesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateDatabaseRequest(ref CreateDatabaseRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetDatabaseRequest(ref GetDatabaseRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateDatabaseDdlRequest(ref UpdateDatabaseDdlRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DropDatabaseRequest(ref DropDatabaseRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetDatabaseDdlRequest(ref GetDatabaseDdlRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SetIamPolicyRequest(ref iam::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetIamPolicyRequest(ref iam::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_TestIamPermissionsRequest(ref iam::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Cloud Spanner databases.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Database"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListDatabasesResponse, Database> ListDatabasesAsync(
            ListDatabasesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatabasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDatabasesRequest, ListDatabasesResponse, Database>(_callListDatabases, request, callSettings);
        }

        /// <summary>
        /// Lists Cloud Spanner databases.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Database"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListDatabasesResponse, Database> ListDatabases(
            ListDatabasesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatabasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDatabasesRequest, ListDatabasesResponse, Database>(_callListDatabases, request, callSettings);
        }

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
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
        public override async stt::Task<lro::Operation<Database, CreateDatabaseMetadata>> CreateDatabaseAsync(
            CreateDatabaseRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<Database, CreateDatabaseMetadata>(
                await _callCreateDatabase.Async(request, callSettings).ConfigureAwait(false), CreateDatabaseOperationsClient);
        }

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
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
        public override lro::Operation<Database, CreateDatabaseMetadata> CreateDatabase(
            CreateDatabaseRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<Database, CreateDatabaseMetadata>(
                _callCreateDatabase.Sync(request, callSettings), CreateDatabaseOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateDatabase</c>.
        /// </summary>
        public override lro::OperationsClient CreateDatabaseOperationsClient { get; }

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
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
        public override stt::Task<Database> GetDatabaseAsync(
            GetDatabaseRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatabaseRequest(ref request, ref callSettings);
            return _callGetDatabase.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
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
        public override Database GetDatabase(
            GetDatabaseRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatabaseRequest(ref request, ref callSettings);
            return _callGetDatabase.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].
        /// The operation has no response.
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
        public override async stt::Task<lro::Operation<pbwkt::Empty, UpdateDatabaseDdlMetadata>> UpdateDatabaseDdlAsync(
            UpdateDatabaseDdlRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatabaseDdlRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, UpdateDatabaseDdlMetadata>(
                await _callUpdateDatabaseDdl.Async(request, callSettings).ConfigureAwait(false), UpdateDatabaseDdlOperationsClient);
        }

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].
        /// The operation has no response.
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
        public override lro::Operation<pbwkt::Empty, UpdateDatabaseDdlMetadata> UpdateDatabaseDdl(
            UpdateDatabaseDdlRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatabaseDdlRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, UpdateDatabaseDdlMetadata>(
                _callUpdateDatabaseDdl.Sync(request, callSettings), UpdateDatabaseDdlOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateDatabaseDdl</c>.
        /// </summary>
        public override lro::OperationsClient UpdateDatabaseDdlOperationsClient { get; }

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
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
        public override stt::Task DropDatabaseAsync(
            DropDatabaseRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DropDatabaseRequest(ref request, ref callSettings);
            return _callDropDatabase.Async(request, callSettings);
        }

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DropDatabase(
            DropDatabaseRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DropDatabaseRequest(ref request, ref callSettings);
            _callDropDatabase.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
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
        public override stt::Task<GetDatabaseDdlResponse> GetDatabaseDdlAsync(
            GetDatabaseDdlRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatabaseDdlRequest(ref request, ref callSettings);
            return _callGetDatabaseDdl.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
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
        public override GetDatabaseDdlResponse GetDatabaseDdl(
            GetDatabaseDdlRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatabaseDdlRequest(ref request, ref callSettings);
            return _callGetDatabaseDdl.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on a database resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.databases.setIamPolicy` permission on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        public override stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on a database resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.databases.setIamPolicy` permission on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        public override iam::Policy SetIamPolicy(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a database resource. Returns an empty
        /// policy if a database exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.databases.getIamPolicy` permission on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        public override stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a database resource. Returns an empty
        /// policy if a database exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.databases.getIamPolicy` permission on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        public override iam::Policy GetIamPolicy(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that the caller has on the specified database resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner database will result in
        /// a NOT_FOUND error if the user has `spanner.databases.list` permission on
        /// the containing Cloud Spanner instance. Otherwise returns an empty set of
        /// permissions.
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
        public override stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that the caller has on the specified database resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner database will result in
        /// a NOT_FOUND error if the user has `spanner.databases.list` permission on
        /// the containing Cloud Spanner instance. Otherwise returns an empty set of
        /// permissions.
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
        public override iam::TestIamPermissionsResponse TestIamPermissions(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListDatabasesRequest : gaxgrpc::IPageRequest { }
    public partial class ListDatabasesResponse : gaxgrpc::IPageResponse<Database>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Database> GetEnumerator() => Databases.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class DatabaseAdmin
    {
        public partial class DatabaseAdminClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
