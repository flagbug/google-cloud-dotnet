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
using iam = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.Bigtable.Admin.V2
{
    /// <summary>
    /// Settings for a <see cref="BigtableInstanceAdminClient"/>.
    /// </summary>
    public sealed partial class BigtableInstanceAdminSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="BigtableInstanceAdminSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="BigtableInstanceAdminSettings"/>.
        /// </returns>
        public static BigtableInstanceAdminSettings GetDefault() => new BigtableInstanceAdminSettings();

        /// <summary>
        /// Constructs a new <see cref="BigtableInstanceAdminSettings"/> object with default settings.
        /// </summary>
        public BigtableInstanceAdminSettings() { }

        private BigtableInstanceAdminSettings(BigtableInstanceAdminSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateInstanceSettings = existing.CreateInstanceSettings;
            CreateInstanceOperationsSettings = existing.CreateInstanceOperationsSettings?.Clone();
            GetInstanceSettings = existing.GetInstanceSettings;
            ListInstancesSettings = existing.ListInstancesSettings;
            PartialUpdateInstanceSettings = existing.PartialUpdateInstanceSettings;
            PartialUpdateInstanceOperationsSettings = existing.PartialUpdateInstanceOperationsSettings?.Clone();
            DeleteInstanceSettings = existing.DeleteInstanceSettings;
            CreateClusterSettings = existing.CreateClusterSettings;
            CreateClusterOperationsSettings = existing.CreateClusterOperationsSettings?.Clone();
            GetClusterSettings = existing.GetClusterSettings;
            ListClustersSettings = existing.ListClustersSettings;
            UpdateClusterSettings = existing.UpdateClusterSettings;
            UpdateClusterOperationsSettings = existing.UpdateClusterOperationsSettings?.Clone();
            DeleteClusterSettings = existing.DeleteClusterSettings;
            CreateAppProfileSettings = existing.CreateAppProfileSettings;
            GetAppProfileSettings = existing.GetAppProfileSettings;
            ListAppProfilesSettings = existing.ListAppProfilesSettings;
            UpdateAppProfileSettings = existing.UpdateAppProfileSettings;
            UpdateAppProfileOperationsSettings = existing.UpdateAppProfileOperationsSettings?.Clone();
            DeleteAppProfileSettings = existing.DeleteAppProfileSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BigtableInstanceAdminSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="BigtableInstanceAdminClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "NonIdempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable);

        /// <summary>
        /// "Default" retry backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 5 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 2.0</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(5),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 2.0
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods is defined as:
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
        /// <c>BigtableInstanceAdminClient.CreateInstance</c> and <c>BigtableInstanceAdminClient.CreateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.CreateInstance</c> and
        /// <c>BigtableInstanceAdminClient.CreateInstanceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.CreateInstance</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.GetInstance</c> and <c>BigtableInstanceAdminClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.GetInstance</c> and
        /// <c>BigtableInstanceAdminClient.GetInstanceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.ListInstances</c> and <c>BigtableInstanceAdminClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.ListInstances</c> and
        /// <c>BigtableInstanceAdminClient.ListInstancesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.PartialUpdateInstance</c> and <c>BigtableInstanceAdminClient.PartialUpdateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.PartialUpdateInstance</c> and
        /// <c>BigtableInstanceAdminClient.PartialUpdateInstanceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        public gaxgrpc::CallSettings PartialUpdateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.PartialUpdateInstance</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings PartialUpdateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.DeleteInstance</c> and <c>BigtableInstanceAdminClient.DeleteInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.DeleteInstance</c> and
        /// <c>BigtableInstanceAdminClient.DeleteInstanceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.CreateCluster</c> and <c>BigtableInstanceAdminClient.CreateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.CreateCluster</c> and
        /// <c>BigtableInstanceAdminClient.CreateClusterAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateClusterSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.CreateCluster</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.GetCluster</c> and <c>BigtableInstanceAdminClient.GetClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.GetCluster</c> and
        /// <c>BigtableInstanceAdminClient.GetClusterAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        public gaxgrpc::CallSettings GetClusterSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.ListClusters</c> and <c>BigtableInstanceAdminClient.ListClustersAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.ListClusters</c> and
        /// <c>BigtableInstanceAdminClient.ListClustersAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        public gaxgrpc::CallSettings ListClustersSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.UpdateCluster</c> and <c>BigtableInstanceAdminClient.UpdateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.UpdateCluster</c> and
        /// <c>BigtableInstanceAdminClient.UpdateClusterAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        public gaxgrpc::CallSettings UpdateClusterSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.UpdateCluster</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.DeleteCluster</c> and <c>BigtableInstanceAdminClient.DeleteClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.DeleteCluster</c> and
        /// <c>BigtableInstanceAdminClient.DeleteClusterAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteClusterSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.CreateAppProfile</c> and <c>BigtableInstanceAdminClient.CreateAppProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.CreateAppProfile</c> and
        /// <c>BigtableInstanceAdminClient.CreateAppProfileAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateAppProfileSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.GetAppProfile</c> and <c>BigtableInstanceAdminClient.GetAppProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.GetAppProfile</c> and
        /// <c>BigtableInstanceAdminClient.GetAppProfileAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        public gaxgrpc::CallSettings GetAppProfileSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.ListAppProfiles</c> and <c>BigtableInstanceAdminClient.ListAppProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.ListAppProfiles</c> and
        /// <c>BigtableInstanceAdminClient.ListAppProfilesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        public gaxgrpc::CallSettings ListAppProfilesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.UpdateAppProfile</c> and <c>BigtableInstanceAdminClient.UpdateAppProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.UpdateAppProfile</c> and
        /// <c>BigtableInstanceAdminClient.UpdateAppProfileAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        public gaxgrpc::CallSettings UpdateAppProfileSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.UpdateAppProfile</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 5 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateAppProfileOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(5L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.DeleteAppProfile</c> and <c>BigtableInstanceAdminClient.DeleteAppProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.DeleteAppProfile</c> and
        /// <c>BigtableInstanceAdminClient.DeleteAppProfileAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAppProfileSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.GetIamPolicy</c> and <c>BigtableInstanceAdminClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.GetIamPolicy</c> and
        /// <c>BigtableInstanceAdminClient.GetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        /// <c>BigtableInstanceAdminClient.SetIamPolicy</c> and <c>BigtableInstanceAdminClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.SetIamPolicy</c> and
        /// <c>BigtableInstanceAdminClient.SetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
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
        /// <c>BigtableInstanceAdminClient.TestIamPermissions</c> and <c>BigtableInstanceAdminClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.TestIamPermissions</c> and
        /// <c>BigtableInstanceAdminClient.TestIamPermissionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="BigtableInstanceAdminSettings"/> object.</returns>
        public BigtableInstanceAdminSettings Clone() => new BigtableInstanceAdminSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BigtableInstanceAdminClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class BigtableInstanceAdminClientBuilder : gaxgrpc::ClientBuilderBase<BigtableInstanceAdminClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public BigtableInstanceAdminSettings Settings { get; set; }

        /// <inheritdoc/>
        public override BigtableInstanceAdminClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BigtableInstanceAdminClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<BigtableInstanceAdminClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BigtableInstanceAdminClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => BigtableInstanceAdminClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => BigtableInstanceAdminClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => BigtableInstanceAdminClient.ChannelPool;
    }

    /// <summary>
    /// BigtableInstanceAdmin client wrapper, for convenient use.
    /// </summary>
    public abstract partial class BigtableInstanceAdminClient
    {
        /// <summary>
        /// The default endpoint for the BigtableInstanceAdmin service, which is a host of "bigtableadmin.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("bigtableadmin.googleapis.com", 443);

        /// <summary>
        /// The default BigtableInstanceAdmin scopes.
        /// </summary>
        /// <remarks>
        /// The default BigtableInstanceAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin.cluster"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin.instance"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin.table"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.admin.cluster"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.admin.table"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform.read-only"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/bigtable.admin",
            "https://www.googleapis.com/auth/bigtable.admin.cluster",
            "https://www.googleapis.com/auth/bigtable.admin.instance",
            "https://www.googleapis.com/auth/bigtable.admin.table",
            "https://www.googleapis.com/auth/cloud-bigtable.admin",
            "https://www.googleapis.com/auth/cloud-bigtable.admin.cluster",
            "https://www.googleapis.com/auth/cloud-bigtable.admin.table",
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="BigtableInstanceAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Bigtable.Admin.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// BigtableInstanceAdminClient client = await BigtableInstanceAdminClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Bigtable.Admin.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     BigtableInstanceAdminClient.DefaultEndpoint.Host, BigtableInstanceAdminClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// BigtableInstanceAdminClient client = BigtableInstanceAdminClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableInstanceAdminSettings"/>.</param>
        /// <returns>The task representing the created <see cref="BigtableInstanceAdminClient"/>.</returns>
        public static async stt::Task<BigtableInstanceAdminClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, BigtableInstanceAdminSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="BigtableInstanceAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Bigtable.Admin.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// BigtableInstanceAdminClient client = BigtableInstanceAdminClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Bigtable.Admin.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     BigtableInstanceAdminClient.DefaultEndpoint.Host, BigtableInstanceAdminClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// BigtableInstanceAdminClient client = BigtableInstanceAdminClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableInstanceAdminSettings"/>.</param>
        /// <returns>The created <see cref="BigtableInstanceAdminClient"/>.</returns>
        public static BigtableInstanceAdminClient Create(gaxgrpc::ServiceEndpoint endpoint = null, BigtableInstanceAdminSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="BigtableInstanceAdminClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BigtableInstanceAdminSettings"/>.</param>
        /// <returns>The created <see cref="BigtableInstanceAdminClient"/>.</returns>
        public static BigtableInstanceAdminClient Create(grpccore::Channel channel, BigtableInstanceAdminSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="BigtableInstanceAdminClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BigtableInstanceAdminSettings"/>.</param>
        /// <returns>The created <see cref="BigtableInstanceAdminClient"/>.</returns>
        public static BigtableInstanceAdminClient Create(grpccore::CallInvoker callInvoker, BigtableInstanceAdminSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BigtableInstanceAdmin.BigtableInstanceAdminClient grpcClient = new BigtableInstanceAdmin.BigtableInstanceAdminClient(callInvoker);
            return new BigtableInstanceAdminClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, BigtableInstanceAdminSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, BigtableInstanceAdminSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, BigtableInstanceAdminSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, BigtableInstanceAdminSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC BigtableInstanceAdmin client.
        /// </summary>
        public virtual BigtableInstanceAdmin.BigtableInstanceAdminClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Create an instance within a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project in which to create the new instance.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// The ID to be used when referring to the new instance within its project,
        /// e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// Currently, at most two clusters can be specified.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            gaxres::ProjectName parent,
            string instanceId,
            Instance instance,
            scg::IDictionary<string, Cluster> clusters,
            gaxgrpc::CallSettings callSettings = null) => CreateInstanceAsync(
                new CreateInstanceRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                    Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    Clusters = { gax::GaxPreconditions.CheckNotNull(clusters, nameof(clusters)) },
                },
                callSettings);

        /// <summary>
        /// Create an instance within a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project in which to create the new instance.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// The ID to be used when referring to the new instance within its project,
        /// e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// Currently, at most two clusters can be specified.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            gaxres::ProjectName parent,
            string instanceId,
            Instance instance,
            scg::IDictionary<string, Cluster> clusters,
            st::CancellationToken cancellationToken) => CreateInstanceAsync(
                parent,
                instanceId,
                instance,
                clusters,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an instance within a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project in which to create the new instance.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// The ID to be used when referring to the new instance within its project,
        /// e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// Currently, at most two clusters can be specified.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<Instance, CreateInstanceMetadata> CreateInstance(
            gaxres::ProjectName parent,
            string instanceId,
            Instance instance,
            scg::IDictionary<string, Cluster> clusters,
            gaxgrpc::CallSettings callSettings = null) => CreateInstance(
                new CreateInstanceRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                    Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    Clusters = { gax::GaxPreconditions.CheckNotNull(clusters, nameof(clusters)) },
                },
                callSettings);

        /// <summary>
        /// Create an instance within a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project in which to create the new instance.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// The ID to be used when referring to the new instance within its project,
        /// e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// Currently, at most two clusters can be specified.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            string parent,
            string instanceId,
            Instance instance,
            scg::IDictionary<string, Cluster> clusters,
            gaxgrpc::CallSettings callSettings = null) => CreateInstanceAsync(
                new CreateInstanceRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                    Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    Clusters = { gax::GaxPreconditions.CheckNotNull(clusters, nameof(clusters)) },
                },
                callSettings);

        /// <summary>
        /// Create an instance within a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project in which to create the new instance.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// The ID to be used when referring to the new instance within its project,
        /// e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// Currently, at most two clusters can be specified.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            string parent,
            string instanceId,
            Instance instance,
            scg::IDictionary<string, Cluster> clusters,
            st::CancellationToken cancellationToken) => CreateInstanceAsync(
                parent,
                instanceId,
                instance,
                clusters,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an instance within a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project in which to create the new instance.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// The ID to be used when referring to the new instance within its project,
        /// e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// Currently, at most two clusters can be specified.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<Instance, CreateInstanceMetadata> CreateInstance(
            string parent,
            string instanceId,
            Instance instance,
            scg::IDictionary<string, Cluster> clusters,
            gaxgrpc::CallSettings callSettings = null) => CreateInstance(
                new CreateInstanceRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                    Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    Clusters = { gax::GaxPreconditions.CheckNotNull(clusters, nameof(clusters)) },
                },
                callSettings);

        /// <summary>
        /// Create an instance within a project.
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
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            CreateInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstanceAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> PollOnceCreateInstanceAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Instance, CreateInstanceMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateInstanceOperationsClient,
                callSettings);

        /// <summary>
        /// Create an instance within a project.
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
        public virtual lro::Operation<Instance, CreateInstanceMetadata> CreateInstance(
            CreateInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateInstance</c>.
        /// </summary>
        public virtual lro::OperationsClient CreateInstanceOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, CreateInstanceMetadata> PollOnceCreateInstance(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Instance, CreateInstanceMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateInstanceOperationsClient,
                callSettings);

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Instance> GetInstanceAsync(
            InstanceName name,
            gaxgrpc::CallSettings callSettings = null) => GetInstanceAsync(
                new GetInstanceRequest
                {
                    InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Instance> GetInstanceAsync(
            InstanceName name,
            st::CancellationToken cancellationToken) => GetInstanceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Instance GetInstance(
            InstanceName name,
            gaxgrpc::CallSettings callSettings = null) => GetInstance(
                new GetInstanceRequest
                {
                    InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Instance> GetInstanceAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetInstanceAsync(
                new GetInstanceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Instance> GetInstanceAsync(
            string name,
            st::CancellationToken cancellationToken) => GetInstanceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Instance GetInstance(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetInstance(
                new GetInstanceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about an instance.
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
        public virtual stt::Task<Instance> GetInstanceAsync(
            GetInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets information about an instance.
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
        public virtual stt::Task<Instance> GetInstanceAsync(
            GetInstanceRequest request,
            st::CancellationToken cancellationToken) => GetInstanceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about an instance.
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
        public virtual Instance GetInstance(
            GetInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project for which a list of instances is requested.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListInstancesResponse> ListInstancesAsync(
            gaxres::ProjectName parent,
            gaxgrpc::CallSettings callSettings = null) => ListInstancesAsync(
                new ListInstancesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project for which a list of instances is requested.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListInstancesResponse> ListInstancesAsync(
            gaxres::ProjectName parent,
            st::CancellationToken cancellationToken) => ListInstancesAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project for which a list of instances is requested.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListInstancesResponse ListInstances(
            gaxres::ProjectName parent,
            gaxgrpc::CallSettings callSettings = null) => ListInstances(
                new ListInstancesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project for which a list of instances is requested.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListInstancesResponse> ListInstancesAsync(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => ListInstancesAsync(
                new ListInstancesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project for which a list of instances is requested.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListInstancesResponse> ListInstancesAsync(
            string parent,
            st::CancellationToken cancellationToken) => ListInstancesAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project for which a list of instances is requested.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListInstancesResponse ListInstances(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => ListInstances(
                new ListInstancesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Lists information about instances in a project.
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
        public virtual stt::Task<ListInstancesResponse> ListInstancesAsync(
            ListInstancesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists information about instances in a project.
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
        public virtual stt::Task<ListInstancesResponse> ListInstancesAsync(
            ListInstancesRequest request,
            st::CancellationToken cancellationToken) => ListInstancesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about instances in a project.
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
        public virtual ListInstancesResponse ListInstances(
            ListInstancesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Partially updates an instance within a project.
        /// </summary>
        /// <param name="instance">
        /// The Instance which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// The subset of Instance fields which should be replaced.
        /// Must be explicitly set.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> PartialUpdateInstanceAsync(
            Instance instance,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => PartialUpdateInstanceAsync(
                new PartialUpdateInstanceRequest
                {
                    Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Partially updates an instance within a project.
        /// </summary>
        /// <param name="instance">
        /// The Instance which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// The subset of Instance fields which should be replaced.
        /// Must be explicitly set.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> PartialUpdateInstanceAsync(
            Instance instance,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => PartialUpdateInstanceAsync(
                instance,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Partially updates an instance within a project.
        /// </summary>
        /// <param name="instance">
        /// The Instance which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// The subset of Instance fields which should be replaced.
        /// Must be explicitly set.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<Instance, UpdateInstanceMetadata> PartialUpdateInstance(
            Instance instance,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => PartialUpdateInstance(
                new PartialUpdateInstanceRequest
                {
                    Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Partially updates an instance within a project.
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
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> PartialUpdateInstanceAsync(
            PartialUpdateInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PartialUpdateInstanceAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> PollOncePartialUpdateInstanceAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Instance, UpdateInstanceMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                PartialUpdateInstanceOperationsClient,
                callSettings);

        /// <summary>
        /// Partially updates an instance within a project.
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
        public virtual lro::Operation<Instance, UpdateInstanceMetadata> PartialUpdateInstance(
            PartialUpdateInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>PartialUpdateInstance</c>.
        /// </summary>
        public virtual lro::OperationsClient PartialUpdateInstanceOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PartialUpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, UpdateInstanceMetadata> PollOncePartialUpdateInstance(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Instance, UpdateInstanceMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                PartialUpdateInstanceOperationsClient,
                callSettings);

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// The unique name of the instance to be deleted.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteInstanceAsync(
            InstanceName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteInstanceAsync(
                new DeleteInstanceRequest
                {
                    InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// The unique name of the instance to be deleted.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteInstanceAsync(
            InstanceName name,
            st::CancellationToken cancellationToken) => DeleteInstanceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// The unique name of the instance to be deleted.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteInstance(
            InstanceName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteInstance(
                new DeleteInstanceRequest
                {
                    InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// The unique name of the instance to be deleted.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteInstanceAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteInstanceAsync(
                new DeleteInstanceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// The unique name of the instance to be deleted.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteInstanceAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteInstanceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// The unique name of the instance to be deleted.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteInstance(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteInstance(
                new DeleteInstanceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Delete an instance from a project.
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
        public virtual stt::Task DeleteInstanceAsync(
            DeleteInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Delete an instance from a project.
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
        public virtual stt::Task DeleteInstanceAsync(
            DeleteInstanceRequest request,
            st::CancellationToken cancellationToken) => DeleteInstanceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteInstance(
            DeleteInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a cluster within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new cluster.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="clusterId">
        /// The ID to be used when referring to the new cluster within its instance,
        /// e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(
            InstanceName parent,
            string clusterId,
            Cluster cluster,
            gaxgrpc::CallSettings callSettings = null) => CreateClusterAsync(
                new CreateClusterRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                },
                callSettings);

        /// <summary>
        /// Creates a cluster within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new cluster.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="clusterId">
        /// The ID to be used when referring to the new cluster within its instance,
        /// e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(
            InstanceName parent,
            string clusterId,
            Cluster cluster,
            st::CancellationToken cancellationToken) => CreateClusterAsync(
                parent,
                clusterId,
                cluster,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a cluster within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new cluster.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="clusterId">
        /// The ID to be used when referring to the new cluster within its instance,
        /// e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<Cluster, CreateClusterMetadata> CreateCluster(
            InstanceName parent,
            string clusterId,
            Cluster cluster,
            gaxgrpc::CallSettings callSettings = null) => CreateCluster(
                new CreateClusterRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                },
                callSettings);

        /// <summary>
        /// Creates a cluster within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new cluster.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="clusterId">
        /// The ID to be used when referring to the new cluster within its instance,
        /// e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(
            string parent,
            string clusterId,
            Cluster cluster,
            gaxgrpc::CallSettings callSettings = null) => CreateClusterAsync(
                new CreateClusterRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                },
                callSettings);

        /// <summary>
        /// Creates a cluster within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new cluster.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="clusterId">
        /// The ID to be used when referring to the new cluster within its instance,
        /// e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(
            string parent,
            string clusterId,
            Cluster cluster,
            st::CancellationToken cancellationToken) => CreateClusterAsync(
                parent,
                clusterId,
                cluster,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a cluster within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new cluster.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="clusterId">
        /// The ID to be used when referring to the new cluster within its instance,
        /// e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<Cluster, CreateClusterMetadata> CreateCluster(
            string parent,
            string clusterId,
            Cluster cluster,
            gaxgrpc::CallSettings callSettings = null) => CreateCluster(
                new CreateClusterRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                },
                callSettings);

        /// <summary>
        /// Creates a cluster within an instance.
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
        public virtual stt::Task<lro::Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(
            CreateClusterRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateClusterAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, CreateClusterMetadata>> PollOnceCreateClusterAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Cluster, CreateClusterMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Creates a cluster within an instance.
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
        public virtual lro::Operation<Cluster, CreateClusterMetadata> CreateCluster(
            CreateClusterRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateCluster</c>.
        /// </summary>
        public virtual lro::OperationsClient CreateClusterOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCluster</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, CreateClusterMetadata> PollOnceCreateCluster(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Cluster, CreateClusterMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested cluster. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Cluster> GetClusterAsync(
            ClusterName name,
            gaxgrpc::CallSettings callSettings = null) => GetClusterAsync(
                new GetClusterRequest
                {
                    ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested cluster. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Cluster> GetClusterAsync(
            ClusterName name,
            st::CancellationToken cancellationToken) => GetClusterAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested cluster. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Cluster GetCluster(
            ClusterName name,
            gaxgrpc::CallSettings callSettings = null) => GetCluster(
                new GetClusterRequest
                {
                    ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested cluster. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Cluster> GetClusterAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetClusterAsync(
                new GetClusterRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested cluster. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Cluster> GetClusterAsync(
            string name,
            st::CancellationToken cancellationToken) => GetClusterAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested cluster. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Cluster GetCluster(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetCluster(
                new GetClusterRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about a cluster.
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
        public virtual stt::Task<Cluster> GetClusterAsync(
            GetClusterRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets information about a cluster.
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
        public virtual stt::Task<Cluster> GetClusterAsync(
            GetClusterRequest request,
            st::CancellationToken cancellationToken) => GetClusterAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a cluster.
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
        public virtual Cluster GetCluster(
            GetClusterRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of clusters is requested.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// Use `&lt;instance&gt; = '-'` to list Clusters for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListClustersResponse> ListClustersAsync(
            InstanceName parent,
            gaxgrpc::CallSettings callSettings = null) => ListClustersAsync(
                new ListClustersRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of clusters is requested.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// Use `&lt;instance&gt; = '-'` to list Clusters for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListClustersResponse> ListClustersAsync(
            InstanceName parent,
            st::CancellationToken cancellationToken) => ListClustersAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of clusters is requested.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// Use `&lt;instance&gt; = '-'` to list Clusters for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListClustersResponse ListClusters(
            InstanceName parent,
            gaxgrpc::CallSettings callSettings = null) => ListClusters(
                new ListClustersRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of clusters is requested.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// Use `&lt;instance&gt; = '-'` to list Clusters for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListClustersResponse> ListClustersAsync(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => ListClustersAsync(
                new ListClustersRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of clusters is requested.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// Use `&lt;instance&gt; = '-'` to list Clusters for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListClustersResponse> ListClustersAsync(
            string parent,
            st::CancellationToken cancellationToken) => ListClustersAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of clusters is requested.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// Use `&lt;instance&gt; = '-'` to list Clusters for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListClustersResponse ListClusters(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => ListClusters(
                new ListClustersRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Lists information about clusters in an instance.
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
        public virtual stt::Task<ListClustersResponse> ListClustersAsync(
            ListClustersRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists information about clusters in an instance.
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
        public virtual stt::Task<ListClustersResponse> ListClustersAsync(
            ListClustersRequest request,
            st::CancellationToken cancellationToken) => ListClustersAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about clusters in an instance.
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
        public virtual ListClustersResponse ListClusters(
            ListClustersRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates a cluster within an instance.
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
        public virtual stt::Task<lro::Operation<Cluster, UpdateClusterMetadata>> UpdateClusterAsync(
            Cluster request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateClusterAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, UpdateClusterMetadata>> PollOnceUpdateClusterAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Cluster, UpdateClusterMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Updates a cluster within an instance.
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
        public virtual lro::Operation<Cluster, UpdateClusterMetadata> UpdateCluster(
            Cluster request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateCluster</c>.
        /// </summary>
        public virtual lro::OperationsClient UpdateClusterOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateCluster</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, UpdateClusterMetadata> PollOnceUpdateCluster(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Cluster, UpdateClusterMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the cluster to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteClusterAsync(
            ClusterName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteClusterAsync(
                new DeleteClusterRequest
                {
                    ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the cluster to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteClusterAsync(
            ClusterName name,
            st::CancellationToken cancellationToken) => DeleteClusterAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the cluster to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteCluster(
            ClusterName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteCluster(
                new DeleteClusterRequest
                {
                    ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the cluster to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteClusterAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteClusterAsync(
                new DeleteClusterRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the cluster to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteClusterAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteClusterAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the cluster to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteCluster(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteCluster(
                new DeleteClusterRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a cluster from an instance.
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
        public virtual stt::Task DeleteClusterAsync(
            DeleteClusterRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a cluster from an instance.
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
        public virtual stt::Task DeleteClusterAsync(
            DeleteClusterRequest request,
            st::CancellationToken cancellationToken) => DeleteClusterAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteCluster(
            DeleteClusterRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new app profile.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// The ID to be used when referring to the new app profile within its
        /// instance, e.g., just `myprofile` rather than
        /// `projects/myproject/instances/myinstance/appProfiles/myprofile`.
        /// </param>
        /// <param name="appProfile">
        /// The app profile to be created.
        /// Fields marked `OutputOnly` will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AppProfile> CreateAppProfileAsync(
            InstanceName parent,
            string appProfileId,
            AppProfile appProfile,
            gaxgrpc::CallSettings callSettings = null) => CreateAppProfileAsync(
                new CreateAppProfileRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    AppProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(appProfileId, nameof(appProfileId)),
                    AppProfile = gax::GaxPreconditions.CheckNotNull(appProfile, nameof(appProfile)),
                },
                callSettings);

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new app profile.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// The ID to be used when referring to the new app profile within its
        /// instance, e.g., just `myprofile` rather than
        /// `projects/myproject/instances/myinstance/appProfiles/myprofile`.
        /// </param>
        /// <param name="appProfile">
        /// The app profile to be created.
        /// Fields marked `OutputOnly` will be ignored.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AppProfile> CreateAppProfileAsync(
            InstanceName parent,
            string appProfileId,
            AppProfile appProfile,
            st::CancellationToken cancellationToken) => CreateAppProfileAsync(
                parent,
                appProfileId,
                appProfile,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new app profile.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// The ID to be used when referring to the new app profile within its
        /// instance, e.g., just `myprofile` rather than
        /// `projects/myproject/instances/myinstance/appProfiles/myprofile`.
        /// </param>
        /// <param name="appProfile">
        /// The app profile to be created.
        /// Fields marked `OutputOnly` will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AppProfile CreateAppProfile(
            InstanceName parent,
            string appProfileId,
            AppProfile appProfile,
            gaxgrpc::CallSettings callSettings = null) => CreateAppProfile(
                new CreateAppProfileRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    AppProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(appProfileId, nameof(appProfileId)),
                    AppProfile = gax::GaxPreconditions.CheckNotNull(appProfile, nameof(appProfile)),
                },
                callSettings);

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new app profile.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// The ID to be used when referring to the new app profile within its
        /// instance, e.g., just `myprofile` rather than
        /// `projects/myproject/instances/myinstance/appProfiles/myprofile`.
        /// </param>
        /// <param name="appProfile">
        /// The app profile to be created.
        /// Fields marked `OutputOnly` will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AppProfile> CreateAppProfileAsync(
            string parent,
            string appProfileId,
            AppProfile appProfile,
            gaxgrpc::CallSettings callSettings = null) => CreateAppProfileAsync(
                new CreateAppProfileRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    AppProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(appProfileId, nameof(appProfileId)),
                    AppProfile = gax::GaxPreconditions.CheckNotNull(appProfile, nameof(appProfile)),
                },
                callSettings);

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new app profile.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// The ID to be used when referring to the new app profile within its
        /// instance, e.g., just `myprofile` rather than
        /// `projects/myproject/instances/myinstance/appProfiles/myprofile`.
        /// </param>
        /// <param name="appProfile">
        /// The app profile to be created.
        /// Fields marked `OutputOnly` will be ignored.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AppProfile> CreateAppProfileAsync(
            string parent,
            string appProfileId,
            AppProfile appProfile,
            st::CancellationToken cancellationToken) => CreateAppProfileAsync(
                parent,
                appProfileId,
                appProfile,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new app profile.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// The ID to be used when referring to the new app profile within its
        /// instance, e.g., just `myprofile` rather than
        /// `projects/myproject/instances/myinstance/appProfiles/myprofile`.
        /// </param>
        /// <param name="appProfile">
        /// The app profile to be created.
        /// Fields marked `OutputOnly` will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AppProfile CreateAppProfile(
            string parent,
            string appProfileId,
            AppProfile appProfile,
            gaxgrpc::CallSettings callSettings = null) => CreateAppProfile(
                new CreateAppProfileRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    AppProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(appProfileId, nameof(appProfileId)),
                    AppProfile = gax::GaxPreconditions.CheckNotNull(appProfile, nameof(appProfile)),
                },
                callSettings);

        /// <summary>
        /// Creates an app profile within an instance.
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
        public virtual stt::Task<AppProfile> CreateAppProfileAsync(
            CreateAppProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates an app profile within an instance.
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
        public virtual stt::Task<AppProfile> CreateAppProfileAsync(
            CreateAppProfileRequest request,
            st::CancellationToken cancellationToken) => CreateAppProfileAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an app profile within an instance.
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
        public virtual AppProfile CreateAppProfile(
            CreateAppProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested app profile. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AppProfile> GetAppProfileAsync(
            AppProfileName name,
            gaxgrpc::CallSettings callSettings = null) => GetAppProfileAsync(
                new GetAppProfileRequest
                {
                    AppProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested app profile. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AppProfile> GetAppProfileAsync(
            AppProfileName name,
            st::CancellationToken cancellationToken) => GetAppProfileAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested app profile. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AppProfile GetAppProfile(
            AppProfileName name,
            gaxgrpc::CallSettings callSettings = null) => GetAppProfile(
                new GetAppProfileRequest
                {
                    AppProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested app profile. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AppProfile> GetAppProfileAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetAppProfileAsync(
                new GetAppProfileRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested app profile. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AppProfile> GetAppProfileAsync(
            string name,
            st::CancellationToken cancellationToken) => GetAppProfileAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested app profile. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AppProfile GetAppProfile(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetAppProfile(
                new GetAppProfileRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about an app profile.
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
        public virtual stt::Task<AppProfile> GetAppProfileAsync(
            GetAppProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets information about an app profile.
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
        public virtual stt::Task<AppProfile> GetAppProfileAsync(
            GetAppProfileRequest request,
            st::CancellationToken cancellationToken) => GetAppProfileAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about an app profile.
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
        public virtual AppProfile GetAppProfile(
            GetAppProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of app profiles is
        /// requested. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// Use `&lt;instance&gt; = '-'` to list AppProfiles for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
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
        /// A pageable asynchronous sequence of <see cref="AppProfile"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfilesAsync(
            InstanceName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListAppProfilesAsync(
                new ListAppProfilesRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of app profiles is
        /// requested. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// Use `&lt;instance&gt; = '-'` to list AppProfiles for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
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
        /// A pageable sequence of <see cref="AppProfile"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfiles(
            InstanceName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListAppProfiles(
                new ListAppProfilesRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of app profiles is
        /// requested. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// Use `&lt;instance&gt; = '-'` to list AppProfiles for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
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
        /// A pageable asynchronous sequence of <see cref="AppProfile"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfilesAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListAppProfilesAsync(
                new ListAppProfilesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of app profiles is
        /// requested. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// Use `&lt;instance&gt; = '-'` to list AppProfiles for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
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
        /// A pageable sequence of <see cref="AppProfile"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfiles(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListAppProfiles(
                new ListAppProfilesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="AppProfile"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfilesAsync(
            ListAppProfilesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="AppProfile"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfiles(
            ListAppProfilesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an app profile within an instance.
        /// </summary>
        /// <param name="appProfile">
        /// The app profile which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// The subset of app profile fields which should be replaced.
        /// If unset, all fields will be replaced.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<AppProfile, UpdateAppProfileMetadata>> UpdateAppProfileAsync(
            AppProfile appProfile,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateAppProfileAsync(
                new UpdateAppProfileRequest
                {
                    AppProfile = gax::GaxPreconditions.CheckNotNull(appProfile, nameof(appProfile)),
                    UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Updates an app profile within an instance.
        /// </summary>
        /// <param name="appProfile">
        /// The app profile which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// The subset of app profile fields which should be replaced.
        /// If unset, all fields will be replaced.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<AppProfile, UpdateAppProfileMetadata>> UpdateAppProfileAsync(
            AppProfile appProfile,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateAppProfileAsync(
                appProfile,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an app profile within an instance.
        /// </summary>
        /// <param name="appProfile">
        /// The app profile which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// The subset of app profile fields which should be replaced.
        /// If unset, all fields will be replaced.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<AppProfile, UpdateAppProfileMetadata> UpdateAppProfile(
            AppProfile appProfile,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateAppProfile(
                new UpdateAppProfileRequest
                {
                    AppProfile = gax::GaxPreconditions.CheckNotNull(appProfile, nameof(appProfile)),
                    UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Updates an app profile within an instance.
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
        public virtual stt::Task<lro::Operation<AppProfile, UpdateAppProfileMetadata>> UpdateAppProfileAsync(
            UpdateAppProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAppProfileAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AppProfile, UpdateAppProfileMetadata>> PollOnceUpdateAppProfileAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<AppProfile, UpdateAppProfileMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateAppProfileOperationsClient,
                callSettings);

        /// <summary>
        /// Updates an app profile within an instance.
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
        public virtual lro::Operation<AppProfile, UpdateAppProfileMetadata> UpdateAppProfile(
            UpdateAppProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateAppProfile</c>.
        /// </summary>
        public virtual lro::OperationsClient UpdateAppProfileOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAppProfile</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AppProfile, UpdateAppProfileMetadata> PollOnceUpdateAppProfile(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<AppProfile, UpdateAppProfileMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateAppProfileOperationsClient,
                callSettings);

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the app profile to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAppProfileAsync(
            AppProfileName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteAppProfileAsync(
                new DeleteAppProfileRequest
                {
                    AppProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the app profile to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAppProfileAsync(
            AppProfileName name,
            st::CancellationToken cancellationToken) => DeleteAppProfileAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the app profile to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteAppProfile(
            AppProfileName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteAppProfile(
                new DeleteAppProfileRequest
                {
                    AppProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the app profile to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAppProfileAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteAppProfileAsync(
                new DeleteAppProfileRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the app profile to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAppProfileAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteAppProfileAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the app profile to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteAppProfile(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteAppProfile(
                new DeleteAppProfileRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an app profile from an instance.
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
        public virtual stt::Task DeleteAppProfileAsync(
            DeleteAppProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an app profile from an instance.
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
        public virtual stt::Task DeleteAppProfileAsync(
            DeleteAppProfileRequest request,
            st::CancellationToken cancellationToken) => DeleteAppProfileAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteAppProfile(
            DeleteAppProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
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
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// Returns permissions that the caller has on the specified instance resource.
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
    /// BigtableInstanceAdmin client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class BigtableInstanceAdminClientImpl : BigtableInstanceAdminClient
    {
        private readonly gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> _callCreateInstance;
        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;
        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;
        private readonly gaxgrpc::ApiCall<PartialUpdateInstanceRequest, lro::Operation> _callPartialUpdateInstance;
        private readonly gaxgrpc::ApiCall<DeleteInstanceRequest, pbwkt::Empty> _callDeleteInstance;
        private readonly gaxgrpc::ApiCall<CreateClusterRequest, lro::Operation> _callCreateCluster;
        private readonly gaxgrpc::ApiCall<GetClusterRequest, Cluster> _callGetCluster;
        private readonly gaxgrpc::ApiCall<ListClustersRequest, ListClustersResponse> _callListClusters;
        private readonly gaxgrpc::ApiCall<Cluster, lro::Operation> _callUpdateCluster;
        private readonly gaxgrpc::ApiCall<DeleteClusterRequest, pbwkt::Empty> _callDeleteCluster;
        private readonly gaxgrpc::ApiCall<CreateAppProfileRequest, AppProfile> _callCreateAppProfile;
        private readonly gaxgrpc::ApiCall<GetAppProfileRequest, AppProfile> _callGetAppProfile;
        private readonly gaxgrpc::ApiCall<ListAppProfilesRequest, ListAppProfilesResponse> _callListAppProfiles;
        private readonly gaxgrpc::ApiCall<UpdateAppProfileRequest, lro::Operation> _callUpdateAppProfile;
        private readonly gaxgrpc::ApiCall<DeleteAppProfileRequest, pbwkt::Empty> _callDeleteAppProfile;
        private readonly gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> _callGetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> _callSetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the BigtableInstanceAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigtableInstanceAdminSettings"/> used within this client </param>
        public BigtableInstanceAdminClientImpl(BigtableInstanceAdmin.BigtableInstanceAdminClient grpcClient, BigtableInstanceAdminSettings settings)
        {
            GrpcClient = grpcClient;
            BigtableInstanceAdminSettings effectiveSettings = settings ?? BigtableInstanceAdminSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateInstanceOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings);
            PartialUpdateInstanceOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.PartialUpdateInstanceOperationsSettings);
            CreateClusterOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateClusterOperationsSettings);
            UpdateClusterOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.UpdateClusterOperationsSettings);
            UpdateAppProfileOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAppProfileOperationsSettings);
            _callCreateInstance = clientHelper.BuildApiCall<CreateInstanceRequest, lro::Operation>(
                GrpcClient.CreateInstanceAsync, GrpcClient.CreateInstance, effectiveSettings.CreateInstanceSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>(
                GrpcClient.GetInstanceAsync, GrpcClient.GetInstance, effectiveSettings.GetInstanceSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>(
                GrpcClient.ListInstancesAsync, GrpcClient.ListInstances, effectiveSettings.ListInstancesSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callPartialUpdateInstance = clientHelper.BuildApiCall<PartialUpdateInstanceRequest, lro::Operation>(
                GrpcClient.PartialUpdateInstanceAsync, GrpcClient.PartialUpdateInstance, effectiveSettings.PartialUpdateInstanceSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"instance.name={request.Instance?.Name}"));
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, pbwkt::Empty>(
                GrpcClient.DeleteInstanceAsync, GrpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callCreateCluster = clientHelper.BuildApiCall<CreateClusterRequest, lro::Operation>(
                GrpcClient.CreateClusterAsync, GrpcClient.CreateCluster, effectiveSettings.CreateClusterSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callGetCluster = clientHelper.BuildApiCall<GetClusterRequest, Cluster>(
                GrpcClient.GetClusterAsync, GrpcClient.GetCluster, effectiveSettings.GetClusterSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callListClusters = clientHelper.BuildApiCall<ListClustersRequest, ListClustersResponse>(
                GrpcClient.ListClustersAsync, GrpcClient.ListClusters, effectiveSettings.ListClustersSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callUpdateCluster = clientHelper.BuildApiCall<Cluster, lro::Operation>(
                GrpcClient.UpdateClusterAsync, GrpcClient.UpdateCluster, effectiveSettings.UpdateClusterSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callDeleteCluster = clientHelper.BuildApiCall<DeleteClusterRequest, pbwkt::Empty>(
                GrpcClient.DeleteClusterAsync, GrpcClient.DeleteCluster, effectiveSettings.DeleteClusterSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callCreateAppProfile = clientHelper.BuildApiCall<CreateAppProfileRequest, AppProfile>(
                GrpcClient.CreateAppProfileAsync, GrpcClient.CreateAppProfile, effectiveSettings.CreateAppProfileSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callGetAppProfile = clientHelper.BuildApiCall<GetAppProfileRequest, AppProfile>(
                GrpcClient.GetAppProfileAsync, GrpcClient.GetAppProfile, effectiveSettings.GetAppProfileSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callListAppProfiles = clientHelper.BuildApiCall<ListAppProfilesRequest, ListAppProfilesResponse>(
                GrpcClient.ListAppProfilesAsync, GrpcClient.ListAppProfiles, effectiveSettings.ListAppProfilesSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callUpdateAppProfile = clientHelper.BuildApiCall<UpdateAppProfileRequest, lro::Operation>(
                GrpcClient.UpdateAppProfileAsync, GrpcClient.UpdateAppProfile, effectiveSettings.UpdateAppProfileSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"app_profile.name={request.AppProfile?.Name}"));
            _callDeleteAppProfile = clientHelper.BuildApiCall<DeleteAppProfileRequest, pbwkt::Empty>(
                GrpcClient.DeleteAppProfileAsync, GrpcClient.DeleteAppProfile, effectiveSettings.DeleteAppProfileSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callGetIamPolicy = clientHelper.BuildApiCall<iam::GetIamPolicyRequest, iam::Policy>(
                GrpcClient.GetIamPolicyAsync, GrpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            _callSetIamPolicy = clientHelper.BuildApiCall<iam::SetIamPolicyRequest, iam::Policy>(
                GrpcClient.SetIamPolicyAsync, GrpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            _callTestIamPermissions = clientHelper.BuildApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse>(
                GrpcClient.TestIamPermissionsAsync, GrpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            Modify_ApiCall(ref _callCreateInstance);
            Modify_CreateInstanceApiCall(ref _callCreateInstance);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            Modify_ApiCall(ref _callPartialUpdateInstance);
            Modify_PartialUpdateInstanceApiCall(ref _callPartialUpdateInstance);
            Modify_ApiCall(ref _callDeleteInstance);
            Modify_DeleteInstanceApiCall(ref _callDeleteInstance);
            Modify_ApiCall(ref _callCreateCluster);
            Modify_CreateClusterApiCall(ref _callCreateCluster);
            Modify_ApiCall(ref _callGetCluster);
            Modify_GetClusterApiCall(ref _callGetCluster);
            Modify_ApiCall(ref _callListClusters);
            Modify_ListClustersApiCall(ref _callListClusters);
            Modify_ApiCall(ref _callUpdateCluster);
            Modify_UpdateClusterApiCall(ref _callUpdateCluster);
            Modify_ApiCall(ref _callDeleteCluster);
            Modify_DeleteClusterApiCall(ref _callDeleteCluster);
            Modify_ApiCall(ref _callCreateAppProfile);
            Modify_CreateAppProfileApiCall(ref _callCreateAppProfile);
            Modify_ApiCall(ref _callGetAppProfile);
            Modify_GetAppProfileApiCall(ref _callGetAppProfile);
            Modify_ApiCall(ref _callListAppProfiles);
            Modify_ListAppProfilesApiCall(ref _callListAppProfiles);
            Modify_ApiCall(ref _callUpdateAppProfile);
            Modify_UpdateAppProfileApiCall(ref _callUpdateAppProfile);
            Modify_ApiCall(ref _callDeleteAppProfile);
            Modify_DeleteAppProfileApiCall(ref _callDeleteAppProfile);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
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
        partial void Modify_CreateInstanceApiCall(ref gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> call);
        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);
        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);
        partial void Modify_PartialUpdateInstanceApiCall(ref gaxgrpc::ApiCall<PartialUpdateInstanceRequest, lro::Operation> call);
        partial void Modify_DeleteInstanceApiCall(ref gaxgrpc::ApiCall<DeleteInstanceRequest, pbwkt::Empty> call);
        partial void Modify_CreateClusterApiCall(ref gaxgrpc::ApiCall<CreateClusterRequest, lro::Operation> call);
        partial void Modify_GetClusterApiCall(ref gaxgrpc::ApiCall<GetClusterRequest, Cluster> call);
        partial void Modify_ListClustersApiCall(ref gaxgrpc::ApiCall<ListClustersRequest, ListClustersResponse> call);
        partial void Modify_UpdateClusterApiCall(ref gaxgrpc::ApiCall<Cluster, lro::Operation> call);
        partial void Modify_DeleteClusterApiCall(ref gaxgrpc::ApiCall<DeleteClusterRequest, pbwkt::Empty> call);
        partial void Modify_CreateAppProfileApiCall(ref gaxgrpc::ApiCall<CreateAppProfileRequest, AppProfile> call);
        partial void Modify_GetAppProfileApiCall(ref gaxgrpc::ApiCall<GetAppProfileRequest, AppProfile> call);
        partial void Modify_ListAppProfilesApiCall(ref gaxgrpc::ApiCall<ListAppProfilesRequest, ListAppProfilesResponse> call);
        partial void Modify_UpdateAppProfileApiCall(ref gaxgrpc::ApiCall<UpdateAppProfileRequest, lro::Operation> call);
        partial void Modify_DeleteAppProfileApiCall(ref gaxgrpc::ApiCall<DeleteAppProfileRequest, pbwkt::Empty> call);
        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> call);
        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> call);
        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> call);
        partial void OnConstruction(BigtableInstanceAdmin.BigtableInstanceAdminClient grpcClient, BigtableInstanceAdminSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC BigtableInstanceAdmin client.
        /// </summary>
        public override BigtableInstanceAdmin.BigtableInstanceAdminClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_PartialUpdateInstanceRequest(ref PartialUpdateInstanceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateClusterRequest(ref CreateClusterRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetClusterRequest(ref GetClusterRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListClustersRequest(ref ListClustersRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_Cluster(ref Cluster request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteClusterRequest(ref DeleteClusterRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateAppProfileRequest(ref CreateAppProfileRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetAppProfileRequest(ref GetAppProfileRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListAppProfilesRequest(ref ListAppProfilesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateAppProfileRequest(ref UpdateAppProfileRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteAppProfileRequest(ref DeleteAppProfileRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetIamPolicyRequest(ref iam::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SetIamPolicyRequest(ref iam::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_TestIamPermissionsRequest(ref iam::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create an instance within a project.
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
        public override async stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            CreateInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, CreateInstanceMetadata>(
                await _callCreateInstance.Async(request, callSettings).ConfigureAwait(false), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// Create an instance within a project.
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
        public override lro::Operation<Instance, CreateInstanceMetadata> CreateInstance(
            CreateInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, CreateInstanceMetadata>(
                _callCreateInstance.Sync(request, callSettings), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateInstance</c>.
        /// </summary>
        public override lro::OperationsClient CreateInstanceOperationsClient { get; }

        /// <summary>
        /// Gets information about an instance.
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
        public override stt::Task<Instance> GetInstanceAsync(
            GetInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information about an instance.
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
        public override Instance GetInstance(
            GetInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists information about instances in a project.
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
        public override stt::Task<ListInstancesResponse> ListInstancesAsync(
            ListInstancesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return _callListInstances.Async(request, callSettings);
        }

        /// <summary>
        /// Lists information about instances in a project.
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
        public override ListInstancesResponse ListInstances(
            ListInstancesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return _callListInstances.Sync(request, callSettings);
        }

        /// <summary>
        /// Partially updates an instance within a project.
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
        public override async stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> PartialUpdateInstanceAsync(
            PartialUpdateInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PartialUpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, UpdateInstanceMetadata>(
                await _callPartialUpdateInstance.Async(request, callSettings).ConfigureAwait(false), PartialUpdateInstanceOperationsClient);
        }

        /// <summary>
        /// Partially updates an instance within a project.
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
        public override lro::Operation<Instance, UpdateInstanceMetadata> PartialUpdateInstance(
            PartialUpdateInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PartialUpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, UpdateInstanceMetadata>(
                _callPartialUpdateInstance.Sync(request, callSettings), PartialUpdateInstanceOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>PartialUpdateInstance</c>.
        /// </summary>
        public override lro::OperationsClient PartialUpdateInstanceOperationsClient { get; }

        /// <summary>
        /// Delete an instance from a project.
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
        public override stt::Task DeleteInstanceAsync(
            DeleteInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return _callDeleteInstance.Async(request, callSettings);
        }

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteInstance(
            DeleteInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            _callDeleteInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a cluster within an instance.
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
        public override async stt::Task<lro::Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(
            CreateClusterRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, CreateClusterMetadata>(
                await _callCreateCluster.Async(request, callSettings).ConfigureAwait(false), CreateClusterOperationsClient);
        }

        /// <summary>
        /// Creates a cluster within an instance.
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
        public override lro::Operation<Cluster, CreateClusterMetadata> CreateCluster(
            CreateClusterRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, CreateClusterMetadata>(
                _callCreateCluster.Sync(request, callSettings), CreateClusterOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateCluster</c>.
        /// </summary>
        public override lro::OperationsClient CreateClusterOperationsClient { get; }

        /// <summary>
        /// Gets information about a cluster.
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
        public override stt::Task<Cluster> GetClusterAsync(
            GetClusterRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information about a cluster.
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
        public override Cluster GetCluster(
            GetClusterRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists information about clusters in an instance.
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
        public override stt::Task<ListClustersResponse> ListClustersAsync(
            ListClustersRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return _callListClusters.Async(request, callSettings);
        }

        /// <summary>
        /// Lists information about clusters in an instance.
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
        public override ListClustersResponse ListClusters(
            ListClustersRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return _callListClusters.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a cluster within an instance.
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
        public override async stt::Task<lro::Operation<Cluster, UpdateClusterMetadata>> UpdateClusterAsync(
            Cluster request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Cluster(ref request, ref callSettings);
            return new lro::Operation<Cluster, UpdateClusterMetadata>(
                await _callUpdateCluster.Async(request, callSettings).ConfigureAwait(false), UpdateClusterOperationsClient);
        }

        /// <summary>
        /// Updates a cluster within an instance.
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
        public override lro::Operation<Cluster, UpdateClusterMetadata> UpdateCluster(
            Cluster request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Cluster(ref request, ref callSettings);
            return new lro::Operation<Cluster, UpdateClusterMetadata>(
                _callUpdateCluster.Sync(request, callSettings), UpdateClusterOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateCluster</c>.
        /// </summary>
        public override lro::OperationsClient UpdateClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a cluster from an instance.
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
        public override stt::Task DeleteClusterAsync(
            DeleteClusterRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return _callDeleteCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteCluster(
            DeleteClusterRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            _callDeleteCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an app profile within an instance.
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
        public override stt::Task<AppProfile> CreateAppProfileAsync(
            CreateAppProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAppProfileRequest(ref request, ref callSettings);
            return _callCreateAppProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an app profile within an instance.
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
        public override AppProfile CreateAppProfile(
            CreateAppProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAppProfileRequest(ref request, ref callSettings);
            return _callCreateAppProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about an app profile.
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
        public override stt::Task<AppProfile> GetAppProfileAsync(
            GetAppProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAppProfileRequest(ref request, ref callSettings);
            return _callGetAppProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information about an app profile.
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
        public override AppProfile GetAppProfile(
            GetAppProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAppProfileRequest(ref request, ref callSettings);
            return _callGetAppProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="AppProfile"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfilesAsync(
            ListAppProfilesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAppProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAppProfilesRequest, ListAppProfilesResponse, AppProfile>(_callListAppProfiles, request, callSettings);
        }

        /// <summary>
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="AppProfile"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfiles(
            ListAppProfilesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAppProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAppProfilesRequest, ListAppProfilesResponse, AppProfile>(_callListAppProfiles, request, callSettings);
        }

        /// <summary>
        /// Updates an app profile within an instance.
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
        public override async stt::Task<lro::Operation<AppProfile, UpdateAppProfileMetadata>> UpdateAppProfileAsync(
            UpdateAppProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAppProfileRequest(ref request, ref callSettings);
            return new lro::Operation<AppProfile, UpdateAppProfileMetadata>(
                await _callUpdateAppProfile.Async(request, callSettings).ConfigureAwait(false), UpdateAppProfileOperationsClient);
        }

        /// <summary>
        /// Updates an app profile within an instance.
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
        public override lro::Operation<AppProfile, UpdateAppProfileMetadata> UpdateAppProfile(
            UpdateAppProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAppProfileRequest(ref request, ref callSettings);
            return new lro::Operation<AppProfile, UpdateAppProfileMetadata>(
                _callUpdateAppProfile.Sync(request, callSettings), UpdateAppProfileOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateAppProfile</c>.
        /// </summary>
        public override lro::OperationsClient UpdateAppProfileOperationsClient { get; }

        /// <summary>
        /// Deletes an app profile from an instance.
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
        public override stt::Task DeleteAppProfileAsync(
            DeleteAppProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAppProfileRequest(ref request, ref callSettings);
            return _callDeleteAppProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteAppProfile(
            DeleteAppProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAppProfileRequest(ref request, ref callSettings);
            _callDeleteAppProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
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
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// Returns permissions that the caller has on the specified instance resource.
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

    public partial class ListAppProfilesRequest : gaxgrpc::IPageRequest { }
    public partial class ListAppProfilesResponse : gaxgrpc::IPageResponse<AppProfile>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<AppProfile> GetEnumerator() => AppProfiles.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class BigtableInstanceAdmin
    {
        public partial class BigtableInstanceAdminClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
