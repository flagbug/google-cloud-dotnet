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

namespace Google.Cloud.Firestore.V1
{
    /// <summary>
    /// Settings for a <see cref="FirestoreClient"/>.
    /// </summary>
    public sealed partial class FirestoreSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="FirestoreSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="FirestoreSettings"/>.
        /// </returns>
        public static FirestoreSettings GetDefault() => new FirestoreSettings();

        /// <summary>
        /// Constructs a new <see cref="FirestoreSettings"/> object with default settings.
        /// </summary>
        public FirestoreSettings() { }

        private FirestoreSettings(FirestoreSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDocumentSettings = existing.GetDocumentSettings;
            ListDocumentsSettings = existing.ListDocumentsSettings;
            CreateDocumentSettings = existing.CreateDocumentSettings;
            UpdateDocumentSettings = existing.UpdateDocumentSettings;
            DeleteDocumentSettings = existing.DeleteDocumentSettings;
            BatchGetDocumentsSettings = existing.BatchGetDocumentsSettings;
            BeginTransactionSettings = existing.BeginTransactionSettings;
            CommitSettings = existing.CommitSettings;
            RollbackSettings = existing.RollbackSettings;
            RunQuerySettings = existing.RunQuerySettings;
            WriteSettings = existing.WriteSettings;
            WriteStreamingSettings = existing.WriteStreamingSettings;
            ListenSettings = existing.ListenSettings;
            ListenStreamingSettings = existing.ListenStreamingSettings;
            ListCollectionIdsSettings = existing.ListCollectionIdsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FirestoreSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="FirestoreClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="FirestoreClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="FirestoreClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="FirestoreClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="FirestoreClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="FirestoreClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="FirestoreClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="FirestoreClient"/> RPC methods is defined as:
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
        /// "Streaming" retry backoff for <see cref="FirestoreClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Streaming" retry backoff for <see cref="FirestoreClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Streaming" retry backoff for <see cref="FirestoreClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetStreamingRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Streaming" timeout backoff for <see cref="FirestoreClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Streaming" timeout backoff for <see cref="FirestoreClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Streaming" timeout backoff for <see cref="FirestoreClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 300000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetStreamingTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(300000),
            maxDelay: sys::TimeSpan.FromMilliseconds(300000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.GetDocument</c> and <c>FirestoreClient.GetDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.GetDocument</c> and
        /// <c>FirestoreClient.GetDocumentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetDocumentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.ListDocuments</c> and <c>FirestoreClient.ListDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.ListDocuments</c> and
        /// <c>FirestoreClient.ListDocumentsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListDocumentsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.CreateDocument</c> and <c>FirestoreClient.CreateDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.CreateDocument</c> and
        /// <c>FirestoreClient.CreateDocumentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateDocumentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.UpdateDocument</c> and <c>FirestoreClient.UpdateDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.UpdateDocument</c> and
        /// <c>FirestoreClient.UpdateDocumentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateDocumentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.DeleteDocument</c> and <c>FirestoreClient.DeleteDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.DeleteDocument</c> and
        /// <c>FirestoreClient.DeleteDocumentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteDocumentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for calls to <c>FirestoreClient.BatchGetDocuments</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings BatchGetDocumentsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.BeginTransaction</c> and <c>FirestoreClient.BeginTransactionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.BeginTransaction</c> and
        /// <c>FirestoreClient.BeginTransactionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings BeginTransactionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.Commit</c> and <c>FirestoreClient.CommitAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.Commit</c> and
        /// <c>FirestoreClient.CommitAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CommitSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.Rollback</c> and <c>FirestoreClient.RollbackAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.Rollback</c> and
        /// <c>FirestoreClient.RollbackAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings RollbackSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for calls to <c>FirestoreClient.RunQuery</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings RunQuerySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for calls to <c>FirestoreClient.Write</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings WriteSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>FirestoreClient.Write</c>.
        /// </summary>
        /// <remarks>
        /// The default local send queue size is 100.
        /// </remarks>
        public gaxgrpc::BidirectionalStreamingSettings WriteStreamingSettings { get; set; } =
            new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for calls to <c>FirestoreClient.Listen</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListenSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>FirestoreClient.Listen</c>.
        /// </summary>
        /// <remarks>
        /// The default local send queue size is 100.
        /// </remarks>
        public gaxgrpc::BidirectionalStreamingSettings ListenStreamingSettings { get; set; } =
            new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.ListCollectionIds</c> and <c>FirestoreClient.ListCollectionIdsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.ListCollectionIds</c> and
        /// <c>FirestoreClient.ListCollectionIdsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListCollectionIdsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="FirestoreSettings"/> object.</returns>
        public FirestoreSettings Clone() => new FirestoreSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FirestoreClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class FirestoreClientBuilder : gaxgrpc::ClientBuilderBase<FirestoreClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public FirestoreSettings Settings { get; set; }

        /// <inheritdoc/>
        public override FirestoreClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FirestoreClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<FirestoreClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FirestoreClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => FirestoreClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => FirestoreClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => FirestoreClient.ChannelPool;
    }

    /// <summary>
    /// Firestore client wrapper, for convenient use.
    /// </summary>
    public abstract partial class FirestoreClient
    {
        /// <summary>
        /// The default endpoint for the Firestore service, which is a host of "firestore.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("firestore.googleapis.com", 443);

        /// <summary>
        /// The default Firestore scopes.
        /// </summary>
        /// <remarks>
        /// The default Firestore scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/datastore"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/datastore",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="FirestoreClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Firestore.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// FirestoreClient client = await FirestoreClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Firestore.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     FirestoreClient.DefaultEndpoint.Host, FirestoreClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// FirestoreClient client = FirestoreClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="FirestoreSettings"/>.</param>
        /// <returns>The task representing the created <see cref="FirestoreClient"/>.</returns>
        public static async stt::Task<FirestoreClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, FirestoreSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="FirestoreClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Firestore.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// FirestoreClient client = FirestoreClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Firestore.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     FirestoreClient.DefaultEndpoint.Host, FirestoreClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// FirestoreClient client = FirestoreClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="FirestoreSettings"/>.</param>
        /// <returns>The created <see cref="FirestoreClient"/>.</returns>
        public static FirestoreClient Create(gaxgrpc::ServiceEndpoint endpoint = null, FirestoreSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="FirestoreClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="FirestoreSettings"/>.</param>
        /// <returns>The created <see cref="FirestoreClient"/>.</returns>
        public static FirestoreClient Create(grpccore::Channel channel, FirestoreSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="FirestoreClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="FirestoreSettings"/>.</param>
        /// <returns>The created <see cref="FirestoreClient"/>.</returns>
        public static FirestoreClient Create(grpccore::CallInvoker callInvoker, FirestoreSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Firestore.FirestoreClient grpcClient = new Firestore.FirestoreClient(callInvoker);
            return new FirestoreClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, FirestoreSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, FirestoreSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, FirestoreSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, FirestoreSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Firestore client.
        /// </summary>
        public virtual Firestore.FirestoreClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Gets a single document.
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
        public virtual stt::Task<Document> GetDocumentAsync(
            GetDocumentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a single document.
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
        public virtual stt::Task<Document> GetDocumentAsync(
            GetDocumentRequest request,
            st::CancellationToken cancellationToken) => GetDocumentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single document.
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
        public virtual Document GetDocument(
            GetDocumentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists documents.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Document"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDocumentsResponse, Document> ListDocumentsAsync(
            ListDocumentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists documents.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Document"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListDocumentsResponse, Document> ListDocuments(
            ListDocumentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new document.
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
        public virtual stt::Task<Document> CreateDocumentAsync(
            CreateDocumentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new document.
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
        public virtual stt::Task<Document> CreateDocumentAsync(
            CreateDocumentRequest request,
            st::CancellationToken cancellationToken) => CreateDocumentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new document.
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
        public virtual Document CreateDocument(
            CreateDocumentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates or inserts a document.
        /// </summary>
        /// <param name="document">
        /// The updated document.
        /// Creates the document if it does not already exist.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// None of the field paths in the mask may contain a reserved name.
        ///
        /// If the document exists on the server and has fields not referenced in the
        /// mask, they are left unchanged.
        /// Fields referenced in the mask, but not present in the input document, are
        /// deleted from the document on the server.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Document> UpdateDocumentAsync(
            Document document,
            DocumentMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateDocumentAsync(
                new UpdateDocumentRequest
                {
                    Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                    UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Updates or inserts a document.
        /// </summary>
        /// <param name="document">
        /// The updated document.
        /// Creates the document if it does not already exist.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// None of the field paths in the mask may contain a reserved name.
        ///
        /// If the document exists on the server and has fields not referenced in the
        /// mask, they are left unchanged.
        /// Fields referenced in the mask, but not present in the input document, are
        /// deleted from the document on the server.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Document> UpdateDocumentAsync(
            Document document,
            DocumentMask updateMask,
            st::CancellationToken cancellationToken) => UpdateDocumentAsync(
                document,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates or inserts a document.
        /// </summary>
        /// <param name="document">
        /// The updated document.
        /// Creates the document if it does not already exist.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// None of the field paths in the mask may contain a reserved name.
        ///
        /// If the document exists on the server and has fields not referenced in the
        /// mask, they are left unchanged.
        /// Fields referenced in the mask, but not present in the input document, are
        /// deleted from the document on the server.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Document UpdateDocument(
            Document document,
            DocumentMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateDocument(
                new UpdateDocumentRequest
                {
                    Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                    UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Updates or inserts a document.
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
        public virtual stt::Task<Document> UpdateDocumentAsync(
            UpdateDocumentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates or inserts a document.
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
        public virtual stt::Task<Document> UpdateDocumentAsync(
            UpdateDocumentRequest request,
            st::CancellationToken cancellationToken) => UpdateDocumentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates or inserts a document.
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
        public virtual Document UpdateDocument(
            UpdateDocumentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Document to delete. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteDocumentAsync(
            AnyPathName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteDocumentAsync(
                new DeleteDocumentRequest
                {
                    AnyPathName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Document to delete. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteDocumentAsync(
            AnyPathName name,
            st::CancellationToken cancellationToken) => DeleteDocumentAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Document to delete. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteDocument(
            AnyPathName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteDocument(
                new DeleteDocumentRequest
                {
                    AnyPathName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Document to delete. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteDocumentAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteDocumentAsync(
                new DeleteDocumentRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Document to delete. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteDocumentAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteDocumentAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Document to delete. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteDocument(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteDocument(
                new DeleteDocumentRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a document.
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
        public virtual stt::Task DeleteDocumentAsync(
            DeleteDocumentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a document.
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
        public virtual stt::Task DeleteDocumentAsync(
            DeleteDocumentRequest request,
            st::CancellationToken cancellationToken) => DeleteDocumentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteDocument(
            DeleteDocumentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets multiple documents.
        ///
        /// Documents returned by this method are not guaranteed to be returned in the
        /// same order that they were requested.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual BatchGetDocumentsStream BatchGetDocuments(
            BatchGetDocumentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Server streaming methods for <c>BatchGetDocuments</c>.
        /// </summary>
        public abstract partial class BatchGetDocumentsStream : gaxgrpc::ServerStreamingBase<BatchGetDocumentsResponse>
        {
        }

        /// <summary>
        /// Starts a new transaction.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<BeginTransactionResponse> BeginTransactionAsync(
            string database,
            gaxgrpc::CallSettings callSettings = null) => BeginTransactionAsync(
                new BeginTransactionRequest
                {
                    Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Starts a new transaction.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<BeginTransactionResponse> BeginTransactionAsync(
            string database,
            st::CancellationToken cancellationToken) => BeginTransactionAsync(
                database,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a new transaction.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual BeginTransactionResponse BeginTransaction(
            string database,
            gaxgrpc::CallSettings callSettings = null) => BeginTransaction(
                new BeginTransactionRequest
                {
                    Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Starts a new transaction.
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
        public virtual stt::Task<BeginTransactionResponse> BeginTransactionAsync(
            BeginTransactionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Starts a new transaction.
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
        public virtual stt::Task<BeginTransactionResponse> BeginTransactionAsync(
            BeginTransactionRequest request,
            st::CancellationToken cancellationToken) => BeginTransactionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a new transaction.
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
        public virtual BeginTransactionResponse BeginTransaction(
            BeginTransactionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="writes">
        /// The writes to apply.
        ///
        /// Always executed atomically and in order.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CommitResponse> CommitAsync(
            string database,
            scg::IEnumerable<Write> writes,
            gaxgrpc::CallSettings callSettings = null) => CommitAsync(
                new CommitRequest
                {
                    Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                    Writes = { gax::GaxPreconditions.CheckNotNull(writes, nameof(writes)) },
                },
                callSettings);

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="writes">
        /// The writes to apply.
        ///
        /// Always executed atomically and in order.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CommitResponse> CommitAsync(
            string database,
            scg::IEnumerable<Write> writes,
            st::CancellationToken cancellationToken) => CommitAsync(
                database,
                writes,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="writes">
        /// The writes to apply.
        ///
        /// Always executed atomically and in order.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CommitResponse Commit(
            string database,
            scg::IEnumerable<Write> writes,
            gaxgrpc::CallSettings callSettings = null) => Commit(
                new CommitRequest
                {
                    Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                    Writes = { gax::GaxPreconditions.CheckNotNull(writes, nameof(writes)) },
                },
                callSettings);

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
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
        public virtual stt::Task<CommitResponse> CommitAsync(
            CommitRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
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
        public virtual stt::Task<CommitResponse> CommitAsync(
            CommitRequest request,
            st::CancellationToken cancellationToken) => CommitAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
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
        public virtual CommitResponse Commit(
            CommitRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="transaction">
        /// The transaction to roll back.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task RollbackAsync(
            string database,
            pb::ByteString transaction,
            gaxgrpc::CallSettings callSettings = null) => RollbackAsync(
                new RollbackRequest
                {
                    Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                    Transaction = gax::GaxPreconditions.CheckNotNull(transaction, nameof(transaction)),
                },
                callSettings);

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="transaction">
        /// The transaction to roll back.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task RollbackAsync(
            string database,
            pb::ByteString transaction,
            st::CancellationToken cancellationToken) => RollbackAsync(
                database,
                transaction,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="transaction">
        /// The transaction to roll back.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void Rollback(
            string database,
            pb::ByteString transaction,
            gaxgrpc::CallSettings callSettings = null) => Rollback(
                new RollbackRequest
                {
                    Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                    Transaction = gax::GaxPreconditions.CheckNotNull(transaction, nameof(transaction)),
                },
                callSettings);

        /// <summary>
        /// Rolls back a transaction.
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
        public virtual stt::Task RollbackAsync(
            RollbackRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Rolls back a transaction.
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
        public virtual stt::Task RollbackAsync(
            RollbackRequest request,
            st::CancellationToken cancellationToken) => RollbackAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void Rollback(
            RollbackRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Runs a query.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual RunQueryStream RunQuery(
            RunQueryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Server streaming methods for <c>RunQuery</c>.
        /// </summary>
        public abstract partial class RunQueryStream : gaxgrpc::ServerStreamingBase<RunQueryResponse>
        {
        }

        /// <summary>
        /// Streams batches of document updates and deletes, in order.
        /// </summary>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <param name="streamingSettings">
        /// If not null, applies streaming overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The client-server stream.
        /// </returns>
        public virtual WriteStream Write(
            gaxgrpc::CallSettings callSettings = null,
            gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Bidirectional streaming methods for <c>Write</c>.
        /// </summary>
        public abstract partial class WriteStream : gaxgrpc::BidirectionalStreamingBase<WriteRequest, WriteResponse>
        {
        }

        /// <summary>
        /// Listens to changes.
        /// </summary>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <param name="streamingSettings">
        /// If not null, applies streaming overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The client-server stream.
        /// </returns>
        public virtual ListenStream Listen(
            gaxgrpc::CallSettings callSettings = null,
            gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Bidirectional streaming methods for <c>Listen</c>.
        /// </summary>
        public abstract partial class ListenStream : gaxgrpc::BidirectionalStreamingBase<ListenRequest, ListenResponse>
        {
        }

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="parent">
        /// The parent document. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// For example:
        /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
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
        /// A pageable asynchronous sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListCollectionIdsResponse, string> ListCollectionIdsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListCollectionIdsAsync(
                new ListCollectionIdsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="parent">
        /// The parent document. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// For example:
        /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
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
        /// A pageable sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListCollectionIdsResponse, string> ListCollectionIds(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListCollectionIds(
                new ListCollectionIdsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListCollectionIdsResponse, string> ListCollectionIdsAsync(
            ListCollectionIdsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListCollectionIdsResponse, string> ListCollectionIds(
            ListCollectionIdsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// Firestore client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class FirestoreClientImpl : FirestoreClient
    {
        private readonly gaxgrpc::ApiCall<GetDocumentRequest, Document> _callGetDocument;
        private readonly gaxgrpc::ApiCall<ListDocumentsRequest, ListDocumentsResponse> _callListDocuments;
        private readonly gaxgrpc::ApiCall<CreateDocumentRequest, Document> _callCreateDocument;
        private readonly gaxgrpc::ApiCall<UpdateDocumentRequest, Document> _callUpdateDocument;
        private readonly gaxgrpc::ApiCall<DeleteDocumentRequest, pbwkt::Empty> _callDeleteDocument;
        private readonly gaxgrpc::ApiServerStreamingCall<BatchGetDocumentsRequest, BatchGetDocumentsResponse> _callBatchGetDocuments;
        private readonly gaxgrpc::ApiCall<BeginTransactionRequest, BeginTransactionResponse> _callBeginTransaction;
        private readonly gaxgrpc::ApiCall<CommitRequest, CommitResponse> _callCommit;
        private readonly gaxgrpc::ApiCall<RollbackRequest, pbwkt::Empty> _callRollback;
        private readonly gaxgrpc::ApiServerStreamingCall<RunQueryRequest, RunQueryResponse> _callRunQuery;
        private readonly gaxgrpc::ApiBidirectionalStreamingCall<WriteRequest, WriteResponse> _callWrite;
        private readonly gaxgrpc::ApiBidirectionalStreamingCall<ListenRequest, ListenResponse> _callListen;
        private readonly gaxgrpc::ApiCall<ListCollectionIdsRequest, ListCollectionIdsResponse> _callListCollectionIds;

        /// <summary>
        /// Constructs a client wrapper for the Firestore service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FirestoreSettings"/> used within this client </param>
        public FirestoreClientImpl(Firestore.FirestoreClient grpcClient, FirestoreSettings settings)
        {
            GrpcClient = grpcClient;
            FirestoreSettings effectiveSettings = settings ?? FirestoreSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetDocument = clientHelper.BuildApiCall<GetDocumentRequest, Document>(
                GrpcClient.GetDocumentAsync, GrpcClient.GetDocument, effectiveSettings.GetDocumentSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callListDocuments = clientHelper.BuildApiCall<ListDocumentsRequest, ListDocumentsResponse>(
                GrpcClient.ListDocumentsAsync, GrpcClient.ListDocuments, effectiveSettings.ListDocumentsSettings);
            _callCreateDocument = clientHelper.BuildApiCall<CreateDocumentRequest, Document>(
                GrpcClient.CreateDocumentAsync, GrpcClient.CreateDocument, effectiveSettings.CreateDocumentSettings);
            _callUpdateDocument = clientHelper.BuildApiCall<UpdateDocumentRequest, Document>(
                GrpcClient.UpdateDocumentAsync, GrpcClient.UpdateDocument, effectiveSettings.UpdateDocumentSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"document.name={request.Document?.Name}"));
            _callDeleteDocument = clientHelper.BuildApiCall<DeleteDocumentRequest, pbwkt::Empty>(
                GrpcClient.DeleteDocumentAsync, GrpcClient.DeleteDocument, effectiveSettings.DeleteDocumentSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callBatchGetDocuments = clientHelper.BuildApiCall<BatchGetDocumentsRequest, BatchGetDocumentsResponse>(
                GrpcClient.BatchGetDocuments, effectiveSettings.BatchGetDocumentsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"database={request.Database}"));
            _callBeginTransaction = clientHelper.BuildApiCall<BeginTransactionRequest, BeginTransactionResponse>(
                GrpcClient.BeginTransactionAsync, GrpcClient.BeginTransaction, effectiveSettings.BeginTransactionSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"database={request.Database}"));
            _callCommit = clientHelper.BuildApiCall<CommitRequest, CommitResponse>(
                GrpcClient.CommitAsync, GrpcClient.Commit, effectiveSettings.CommitSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"database={request.Database}"));
            _callRollback = clientHelper.BuildApiCall<RollbackRequest, pbwkt::Empty>(
                GrpcClient.RollbackAsync, GrpcClient.Rollback, effectiveSettings.RollbackSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"database={request.Database}"));
            _callRunQuery = clientHelper.BuildApiCall<RunQueryRequest, RunQueryResponse>(
                GrpcClient.RunQuery, effectiveSettings.RunQuerySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callWrite = clientHelper.BuildApiCall<WriteRequest, WriteResponse>(
                GrpcClient.Write, effectiveSettings.WriteSettings, effectiveSettings.WriteStreamingSettings);
            _callListen = clientHelper.BuildApiCall<ListenRequest, ListenResponse>(
                GrpcClient.Listen, effectiveSettings.ListenSettings, effectiveSettings.ListenStreamingSettings);
            _callListCollectionIds = clientHelper.BuildApiCall<ListCollectionIdsRequest, ListCollectionIdsResponse>(
                GrpcClient.ListCollectionIdsAsync, GrpcClient.ListCollectionIds, effectiveSettings.ListCollectionIdsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            Modify_ApiCall(ref _callGetDocument);
            Modify_GetDocumentApiCall(ref _callGetDocument);
            Modify_ApiCall(ref _callListDocuments);
            Modify_ListDocumentsApiCall(ref _callListDocuments);
            Modify_ApiCall(ref _callCreateDocument);
            Modify_CreateDocumentApiCall(ref _callCreateDocument);
            Modify_ApiCall(ref _callUpdateDocument);
            Modify_UpdateDocumentApiCall(ref _callUpdateDocument);
            Modify_ApiCall(ref _callDeleteDocument);
            Modify_DeleteDocumentApiCall(ref _callDeleteDocument);
            Modify_ApiCall(ref _callBatchGetDocuments);
            Modify_BatchGetDocumentsApiCall(ref _callBatchGetDocuments);
            Modify_ApiCall(ref _callBeginTransaction);
            Modify_BeginTransactionApiCall(ref _callBeginTransaction);
            Modify_ApiCall(ref _callCommit);
            Modify_CommitApiCall(ref _callCommit);
            Modify_ApiCall(ref _callRollback);
            Modify_RollbackApiCall(ref _callRollback);
            Modify_ApiCall(ref _callRunQuery);
            Modify_RunQueryApiCall(ref _callRunQuery);
            Modify_ApiCall(ref _callWrite);
            Modify_WriteApiCall(ref _callWrite);
            Modify_ApiCall(ref _callListen);
            Modify_ListenApiCall(ref _callListen);
            Modify_ApiCall(ref _callListCollectionIds);
            Modify_ListCollectionIdsApiCall(ref _callListCollectionIds);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_GetDocumentApiCall(ref gaxgrpc::ApiCall<GetDocumentRequest, Document> call);
        partial void Modify_ListDocumentsApiCall(ref gaxgrpc::ApiCall<ListDocumentsRequest, ListDocumentsResponse> call);
        partial void Modify_CreateDocumentApiCall(ref gaxgrpc::ApiCall<CreateDocumentRequest, Document> call);
        partial void Modify_UpdateDocumentApiCall(ref gaxgrpc::ApiCall<UpdateDocumentRequest, Document> call);
        partial void Modify_DeleteDocumentApiCall(ref gaxgrpc::ApiCall<DeleteDocumentRequest, pbwkt::Empty> call);
        partial void Modify_BatchGetDocumentsApiCall(ref gaxgrpc::ApiServerStreamingCall<BatchGetDocumentsRequest, BatchGetDocumentsResponse> call);
        partial void Modify_BeginTransactionApiCall(ref gaxgrpc::ApiCall<BeginTransactionRequest, BeginTransactionResponse> call);
        partial void Modify_CommitApiCall(ref gaxgrpc::ApiCall<CommitRequest, CommitResponse> call);
        partial void Modify_RollbackApiCall(ref gaxgrpc::ApiCall<RollbackRequest, pbwkt::Empty> call);
        partial void Modify_RunQueryApiCall(ref gaxgrpc::ApiServerStreamingCall<RunQueryRequest, RunQueryResponse> call);
        partial void Modify_WriteApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<WriteRequest, WriteResponse> call);
        partial void Modify_ListenApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<ListenRequest, ListenResponse> call);
        partial void Modify_ListCollectionIdsApiCall(ref gaxgrpc::ApiCall<ListCollectionIdsRequest, ListCollectionIdsResponse> call);
        partial void OnConstruction(Firestore.FirestoreClient grpcClient, FirestoreSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Firestore client.
        /// </summary>
        public override Firestore.FirestoreClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetDocumentRequest(ref GetDocumentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListDocumentsRequest(ref ListDocumentsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateDocumentRequest(ref CreateDocumentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateDocumentRequest(ref UpdateDocumentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteDocumentRequest(ref DeleteDocumentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchGetDocumentsRequest(ref BatchGetDocumentsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BeginTransactionRequest(ref BeginTransactionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CommitRequest(ref CommitRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_RollbackRequest(ref RollbackRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_RunQueryRequest(ref RunQueryRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_WriteRequestCallSettings(ref gaxgrpc::CallSettings settings);
        partial void Modify_WriteRequestRequest(ref WriteRequest request);
        partial void Modify_ListenRequestCallSettings(ref gaxgrpc::CallSettings settings);
        partial void Modify_ListenRequestRequest(ref ListenRequest request);
        partial void Modify_ListCollectionIdsRequest(ref ListCollectionIdsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a single document.
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
        public override stt::Task<Document> GetDocumentAsync(
            GetDocumentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDocumentRequest(ref request, ref callSettings);
            return _callGetDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a single document.
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
        public override Document GetDocument(
            GetDocumentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDocumentRequest(ref request, ref callSettings);
            return _callGetDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists documents.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Document"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListDocumentsResponse, Document> ListDocumentsAsync(
            ListDocumentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDocumentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDocumentsRequest, ListDocumentsResponse, Document>(_callListDocuments, request, callSettings);
        }

        /// <summary>
        /// Lists documents.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Document"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListDocumentsResponse, Document> ListDocuments(
            ListDocumentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDocumentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDocumentsRequest, ListDocumentsResponse, Document>(_callListDocuments, request, callSettings);
        }

        /// <summary>
        /// Creates a new document.
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
        public override stt::Task<Document> CreateDocumentAsync(
            CreateDocumentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDocumentRequest(ref request, ref callSettings);
            return _callCreateDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new document.
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
        public override Document CreateDocument(
            CreateDocumentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDocumentRequest(ref request, ref callSettings);
            return _callCreateDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates or inserts a document.
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
        public override stt::Task<Document> UpdateDocumentAsync(
            UpdateDocumentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDocumentRequest(ref request, ref callSettings);
            return _callUpdateDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Updates or inserts a document.
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
        public override Document UpdateDocument(
            UpdateDocumentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDocumentRequest(ref request, ref callSettings);
            return _callUpdateDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a document.
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
        public override stt::Task DeleteDocumentAsync(
            DeleteDocumentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDocumentRequest(ref request, ref callSettings);
            return _callDeleteDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteDocument(
            DeleteDocumentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDocumentRequest(ref request, ref callSettings);
            _callDeleteDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets multiple documents.
        ///
        /// Documents returned by this method are not guaranteed to be returned in the
        /// same order that they were requested.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public override BatchGetDocumentsStream BatchGetDocuments(
            BatchGetDocumentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetDocumentsRequest(ref request, ref callSettings);
            return new BatchGetDocumentsStreamImpl(_callBatchGetDocuments.Call(request, callSettings));
        }

        internal sealed partial class BatchGetDocumentsStreamImpl : BatchGetDocumentsStream
        {
            /// <summary>
            /// Construct the server-streaming method for <c>BatchGetDocuments</c>.
            /// </summary>
            /// <param name="call">The underlying gRPC server-streaming call.</param>
            internal BatchGetDocumentsStreamImpl(grpccore::AsyncServerStreamingCall<BatchGetDocumentsResponse> call)
            {
                GrpcCall = call;
            }

            /// <inheritdoc/>
            public override grpccore::AsyncServerStreamingCall<BatchGetDocumentsResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override scg::IAsyncEnumerator<BatchGetDocumentsResponse> ResponseStream => GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Starts a new transaction.
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
        public override stt::Task<BeginTransactionResponse> BeginTransactionAsync(
            BeginTransactionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BeginTransactionRequest(ref request, ref callSettings);
            return _callBeginTransaction.Async(request, callSettings);
        }

        /// <summary>
        /// Starts a new transaction.
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
        public override BeginTransactionResponse BeginTransaction(
            BeginTransactionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BeginTransactionRequest(ref request, ref callSettings);
            return _callBeginTransaction.Sync(request, callSettings);
        }

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
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
        public override stt::Task<CommitResponse> CommitAsync(
            CommitRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitRequest(ref request, ref callSettings);
            return _callCommit.Async(request, callSettings);
        }

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
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
        public override CommitResponse Commit(
            CommitRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitRequest(ref request, ref callSettings);
            return _callCommit.Sync(request, callSettings);
        }

        /// <summary>
        /// Rolls back a transaction.
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
        public override stt::Task RollbackAsync(
            RollbackRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackRequest(ref request, ref callSettings);
            return _callRollback.Async(request, callSettings);
        }

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void Rollback(
            RollbackRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackRequest(ref request, ref callSettings);
            _callRollback.Sync(request, callSettings);
        }

        /// <summary>
        /// Runs a query.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public override RunQueryStream RunQuery(
            RunQueryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunQueryRequest(ref request, ref callSettings);
            return new RunQueryStreamImpl(_callRunQuery.Call(request, callSettings));
        }

        internal sealed partial class RunQueryStreamImpl : RunQueryStream
        {
            /// <summary>
            /// Construct the server-streaming method for <c>RunQuery</c>.
            /// </summary>
            /// <param name="call">The underlying gRPC server-streaming call.</param>
            internal RunQueryStreamImpl(grpccore::AsyncServerStreamingCall<RunQueryResponse> call)
            {
                GrpcCall = call;
            }

            /// <inheritdoc/>
            public override grpccore::AsyncServerStreamingCall<RunQueryResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override scg::IAsyncEnumerator<RunQueryResponse> ResponseStream => GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Streams batches of document updates and deletes, in order.
        /// </summary>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <param name="streamingSettings">
        /// If not null, applies streaming overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The client-server stream.
        /// </returns>
        public override WriteStream Write(
            gaxgrpc::CallSettings callSettings = null,
            gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_WriteRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings =
                streamingSettings ?? _callWrite.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<WriteRequest, WriteResponse> call =
                _callWrite.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<WriteRequest> writeBuffer =
                new gaxgrpc::BufferedClientStreamWriter<WriteRequest>(
                    call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new WriteStreamImpl(this, call, writeBuffer);
        }

        internal sealed partial class WriteStreamImpl : WriteStream
        {
            /// <summary>
            /// Construct the bidirectional streaming method for <c>Write</c>.
            /// </summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">The <see cref="gaxgrpc::BufferedClientStreamWriter{WriteRequest}"/>
            /// instance associated with this streaming call.</param>
            public WriteStreamImpl(
                FirestoreClientImpl service,
                grpccore::AsyncDuplexStreamingCall<WriteRequest, WriteResponse> call,
                gaxgrpc::BufferedClientStreamWriter<WriteRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private FirestoreClientImpl _service;
            private gaxgrpc::BufferedClientStreamWriter<WriteRequest> _writeBuffer;

            private WriteRequest ModifyRequest(WriteRequest request)
            {
                _service.Modify_WriteRequestRequest(ref request);
                return request;
            }

            /// <inheritdoc/>
            public override grpccore::AsyncDuplexStreamingCall<WriteRequest, WriteResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override stt::Task TryWriteAsync(WriteRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override stt::Task WriteAsync(WriteRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override stt::Task TryWriteAsync(WriteRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override stt::Task WriteAsync(WriteRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override stt::Task TryWriteCompleteAsync() =>
                _writeBuffer.TryWriteCompleteAsync();

            /// <inheritdoc/>
            public override stt::Task WriteCompleteAsync() =>
                _writeBuffer.WriteCompleteAsync();

            /// <inheritdoc/>
            public override scg::IAsyncEnumerator<WriteResponse> ResponseStream =>
                GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Listens to changes.
        /// </summary>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <param name="streamingSettings">
        /// If not null, applies streaming overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The client-server stream.
        /// </returns>
        public override ListenStream Listen(
            gaxgrpc::CallSettings callSettings = null,
            gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_ListenRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings =
                streamingSettings ?? _callListen.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<ListenRequest, ListenResponse> call =
                _callListen.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<ListenRequest> writeBuffer =
                new gaxgrpc::BufferedClientStreamWriter<ListenRequest>(
                    call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new ListenStreamImpl(this, call, writeBuffer);
        }

        internal sealed partial class ListenStreamImpl : ListenStream
        {
            /// <summary>
            /// Construct the bidirectional streaming method for <c>Listen</c>.
            /// </summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">The <see cref="gaxgrpc::BufferedClientStreamWriter{ListenRequest}"/>
            /// instance associated with this streaming call.</param>
            public ListenStreamImpl(
                FirestoreClientImpl service,
                grpccore::AsyncDuplexStreamingCall<ListenRequest, ListenResponse> call,
                gaxgrpc::BufferedClientStreamWriter<ListenRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private FirestoreClientImpl _service;
            private gaxgrpc::BufferedClientStreamWriter<ListenRequest> _writeBuffer;

            private ListenRequest ModifyRequest(ListenRequest request)
            {
                _service.Modify_ListenRequestRequest(ref request);
                return request;
            }

            /// <inheritdoc/>
            public override grpccore::AsyncDuplexStreamingCall<ListenRequest, ListenResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override stt::Task TryWriteAsync(ListenRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override stt::Task WriteAsync(ListenRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override stt::Task TryWriteAsync(ListenRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override stt::Task WriteAsync(ListenRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override stt::Task TryWriteCompleteAsync() =>
                _writeBuffer.TryWriteCompleteAsync();

            /// <inheritdoc/>
            public override stt::Task WriteCompleteAsync() =>
                _writeBuffer.WriteCompleteAsync();

            /// <inheritdoc/>
            public override scg::IAsyncEnumerator<ListenResponse> ResponseStream =>
                GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="string"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListCollectionIdsResponse, string> ListCollectionIdsAsync(
            ListCollectionIdsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCollectionIdsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCollectionIdsRequest, ListCollectionIdsResponse, string>(_callListCollectionIds, request, callSettings);
        }

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="string"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListCollectionIdsResponse, string> ListCollectionIds(
            ListCollectionIdsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCollectionIdsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCollectionIdsRequest, ListCollectionIdsResponse, string>(_callListCollectionIds, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListDocumentsRequest : gaxgrpc::IPageRequest { }
    public partial class ListDocumentsResponse : gaxgrpc::IPageResponse<Document>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Document> GetEnumerator() => Documents.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCollectionIdsRequest : gaxgrpc::IPageRequest { }
    public partial class ListCollectionIdsResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<string> GetEnumerator() => CollectionIds.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
