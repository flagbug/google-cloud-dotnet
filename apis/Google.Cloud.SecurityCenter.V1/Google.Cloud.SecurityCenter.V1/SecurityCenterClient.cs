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

namespace Google.Cloud.SecurityCenter.V1
{
    /// <summary>
    /// Settings for a <see cref="SecurityCenterClient"/>.
    /// </summary>
    public sealed partial class SecurityCenterSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="SecurityCenterSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="SecurityCenterSettings"/>.
        /// </returns>
        public static SecurityCenterSettings GetDefault() => new SecurityCenterSettings();

        /// <summary>
        /// Constructs a new <see cref="SecurityCenterSettings"/> object with default settings.
        /// </summary>
        public SecurityCenterSettings() { }

        private SecurityCenterSettings(SecurityCenterSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSourceSettings = existing.CreateSourceSettings;
            CreateFindingSettings = existing.CreateFindingSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            GetOrganizationSettingsSettings = existing.GetOrganizationSettingsSettings;
            GetSourceSettings = existing.GetSourceSettings;
            GroupAssetsSettings = existing.GroupAssetsSettings;
            GroupFindingsSettings = existing.GroupFindingsSettings;
            ListAssetsSettings = existing.ListAssetsSettings;
            ListFindingsSettings = existing.ListFindingsSettings;
            ListSourcesSettings = existing.ListSourcesSettings;
            RunAssetDiscoverySettings = existing.RunAssetDiscoverySettings;
            RunAssetDiscoveryOperationsSettings = existing.RunAssetDiscoveryOperationsSettings?.Clone();
            SetFindingStateSettings = existing.SetFindingStateSettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            UpdateFindingSettings = existing.UpdateFindingSettings;
            UpdateOrganizationSettingsSettings = existing.UpdateOrganizationSettingsSettings;
            UpdateSourceSettings = existing.UpdateSourceSettings;
            UpdateSecurityMarksSettings = existing.UpdateSecurityMarksSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SecurityCenterSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="SecurityCenterClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="SecurityCenterClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="SecurityCenterClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="SecurityCenterClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="SecurityCenterClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="SecurityCenterClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="SecurityCenterClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="SecurityCenterClient"/> RPC methods is defined as:
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
        /// <c>SecurityCenterClient.CreateSource</c> and <c>SecurityCenterClient.CreateSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.CreateSource</c> and
        /// <c>SecurityCenterClient.CreateSourceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateSourceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.CreateFinding</c> and <c>SecurityCenterClient.CreateFindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.CreateFinding</c> and
        /// <c>SecurityCenterClient.CreateFindingAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateFindingSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.GetIamPolicy</c> and <c>SecurityCenterClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.GetIamPolicy</c> and
        /// <c>SecurityCenterClient.GetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.GetOrganizationSettings</c> and <c>SecurityCenterClient.GetOrganizationSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.GetOrganizationSettings</c> and
        /// <c>SecurityCenterClient.GetOrganizationSettingsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetOrganizationSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.GetSource</c> and <c>SecurityCenterClient.GetSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.GetSource</c> and
        /// <c>SecurityCenterClient.GetSourceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetSourceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.GroupAssets</c> and <c>SecurityCenterClient.GroupAssetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.GroupAssets</c> and
        /// <c>SecurityCenterClient.GroupAssetsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GroupAssetsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.GroupFindings</c> and <c>SecurityCenterClient.GroupFindingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.GroupFindings</c> and
        /// <c>SecurityCenterClient.GroupFindingsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GroupFindingsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.ListAssets</c> and <c>SecurityCenterClient.ListAssetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.ListAssets</c> and
        /// <c>SecurityCenterClient.ListAssetsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListAssetsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.ListFindings</c> and <c>SecurityCenterClient.ListFindingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.ListFindings</c> and
        /// <c>SecurityCenterClient.ListFindingsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListFindingsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.ListSources</c> and <c>SecurityCenterClient.ListSourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.ListSources</c> and
        /// <c>SecurityCenterClient.ListSourcesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListSourcesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.RunAssetDiscovery</c> and <c>SecurityCenterClient.RunAssetDiscoveryAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.RunAssetDiscovery</c> and
        /// <c>SecurityCenterClient.RunAssetDiscoveryAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings RunAssetDiscoverySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecurityCenterClient.RunAssetDiscovery</c>.
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
        public lro::OperationsSettings RunAssetDiscoveryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.SetFindingState</c> and <c>SecurityCenterClient.SetFindingStateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.SetFindingState</c> and
        /// <c>SecurityCenterClient.SetFindingStateAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SetFindingStateSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.SetIamPolicy</c> and <c>SecurityCenterClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.SetIamPolicy</c> and
        /// <c>SecurityCenterClient.SetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.TestIamPermissions</c> and <c>SecurityCenterClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.TestIamPermissions</c> and
        /// <c>SecurityCenterClient.TestIamPermissionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.UpdateFinding</c> and <c>SecurityCenterClient.UpdateFindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.UpdateFinding</c> and
        /// <c>SecurityCenterClient.UpdateFindingAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateFindingSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.UpdateOrganizationSettings</c> and <c>SecurityCenterClient.UpdateOrganizationSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.UpdateOrganizationSettings</c> and
        /// <c>SecurityCenterClient.UpdateOrganizationSettingsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateOrganizationSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.UpdateSource</c> and <c>SecurityCenterClient.UpdateSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.UpdateSource</c> and
        /// <c>SecurityCenterClient.UpdateSourceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateSourceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.UpdateSecurityMarks</c> and <c>SecurityCenterClient.UpdateSecurityMarksAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SecurityCenterClient.UpdateSecurityMarks</c> and
        /// <c>SecurityCenterClient.UpdateSecurityMarksAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateSecurityMarksSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="SecurityCenterSettings"/> object.</returns>
        public SecurityCenterSettings Clone() => new SecurityCenterSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SecurityCenterClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class SecurityCenterClientBuilder : gaxgrpc::ClientBuilderBase<SecurityCenterClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public SecurityCenterSettings Settings { get; set; }

        /// <inheritdoc/>
        public override SecurityCenterClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SecurityCenterClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<SecurityCenterClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SecurityCenterClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => SecurityCenterClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => SecurityCenterClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => SecurityCenterClient.ChannelPool;
    }

    /// <summary>
    /// SecurityCenter client wrapper, for convenient use.
    /// </summary>
    public abstract partial class SecurityCenterClient
    {
        /// <summary>
        /// The default endpoint for the SecurityCenter service, which is a host of "securitycenter.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("securitycenter.googleapis.com", 443);

        /// <summary>
        /// The default SecurityCenter scopes.
        /// </summary>
        /// <remarks>
        /// The default SecurityCenter scopes are:
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
        /// Asynchronously creates a <see cref="SecurityCenterClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.SecurityCenter.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// SecurityCenterClient client = await SecurityCenterClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.SecurityCenter.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     SecurityCenterClient.DefaultEndpoint.Host, SecurityCenterClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// SecurityCenterClient client = SecurityCenterClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SecurityCenterSettings"/>.</param>
        /// <returns>The task representing the created <see cref="SecurityCenterClient"/>.</returns>
        public static async stt::Task<SecurityCenterClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, SecurityCenterSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="SecurityCenterClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.SecurityCenter.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// SecurityCenterClient client = SecurityCenterClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.SecurityCenter.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     SecurityCenterClient.DefaultEndpoint.Host, SecurityCenterClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// SecurityCenterClient client = SecurityCenterClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SecurityCenterSettings"/>.</param>
        /// <returns>The created <see cref="SecurityCenterClient"/>.</returns>
        public static SecurityCenterClient Create(gaxgrpc::ServiceEndpoint endpoint = null, SecurityCenterSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="SecurityCenterClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SecurityCenterSettings"/>.</param>
        /// <returns>The created <see cref="SecurityCenterClient"/>.</returns>
        public static SecurityCenterClient Create(grpccore::Channel channel, SecurityCenterSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="SecurityCenterClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SecurityCenterSettings"/>.</param>
        /// <returns>The created <see cref="SecurityCenterClient"/>.</returns>
        public static SecurityCenterClient Create(grpccore::CallInvoker callInvoker, SecurityCenterSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SecurityCenter.SecurityCenterClient grpcClient = new SecurityCenter.SecurityCenterClient(callInvoker);
            return new SecurityCenterClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, SecurityCenterSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, SecurityCenterSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, SecurityCenterSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, SecurityCenterSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC SecurityCenter client.
        /// </summary>
        public virtual SecurityCenter.SecurityCenterClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the new source's parent. Its format should be
        /// "organizations/[organization_id]".
        /// </param>
        /// <param name="source">
        /// The Source being created, only the display_name and description will be
        /// used. All other fields will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Source> CreateSourceAsync(
            OrganizationName parent,
            Source source,
            gaxgrpc::CallSettings callSettings = null) => CreateSourceAsync(
                new CreateSourceRequest
                {
                    ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
                },
                callSettings);

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the new source's parent. Its format should be
        /// "organizations/[organization_id]".
        /// </param>
        /// <param name="source">
        /// The Source being created, only the display_name and description will be
        /// used. All other fields will be ignored.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Source> CreateSourceAsync(
            OrganizationName parent,
            Source source,
            st::CancellationToken cancellationToken) => CreateSourceAsync(
                parent,
                source,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the new source's parent. Its format should be
        /// "organizations/[organization_id]".
        /// </param>
        /// <param name="source">
        /// The Source being created, only the display_name and description will be
        /// used. All other fields will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Source CreateSource(
            OrganizationName parent,
            Source source,
            gaxgrpc::CallSettings callSettings = null) => CreateSource(
                new CreateSourceRequest
                {
                    ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
                },
                callSettings);

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the new source's parent. Its format should be
        /// "organizations/[organization_id]".
        /// </param>
        /// <param name="source">
        /// The Source being created, only the display_name and description will be
        /// used. All other fields will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Source> CreateSourceAsync(
            string parent,
            Source source,
            gaxgrpc::CallSettings callSettings = null) => CreateSourceAsync(
                new CreateSourceRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
                },
                callSettings);

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the new source's parent. Its format should be
        /// "organizations/[organization_id]".
        /// </param>
        /// <param name="source">
        /// The Source being created, only the display_name and description will be
        /// used. All other fields will be ignored.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Source> CreateSourceAsync(
            string parent,
            Source source,
            st::CancellationToken cancellationToken) => CreateSourceAsync(
                parent,
                source,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the new source's parent. Its format should be
        /// "organizations/[organization_id]".
        /// </param>
        /// <param name="source">
        /// The Source being created, only the display_name and description will be
        /// used. All other fields will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Source CreateSource(
            string parent,
            Source source,
            gaxgrpc::CallSettings callSettings = null) => CreateSource(
                new CreateSourceRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
                },
                callSettings);

        /// <summary>
        /// Creates a source.
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
        public virtual stt::Task<Source> CreateSourceAsync(
            CreateSourceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a source.
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
        public virtual stt::Task<Source> CreateSourceAsync(
            CreateSourceRequest request,
            st::CancellationToken cancellationToken) => CreateSourceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a source.
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
        public virtual Source CreateSource(
            CreateSourceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a finding. The corresponding source must exist for finding creation
        /// to succeed.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the new finding's parent. Its format should be
        /// "organizations/[organization_id]/sources/[source_id]".
        /// </param>
        /// <param name="findingId">
        /// Unique identifier provided by the client within the parent scope.
        /// It must be alphanumeric and less than or equal to 32 characters and
        /// greater than 0 characters in length.
        /// </param>
        /// <param name="finding">
        /// The Finding being created. The name and security_marks will be ignored as
        /// they are both output only fields on this resource.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Finding> CreateFindingAsync(
            SourceName parent,
            string findingId,
            Finding finding,
            gaxgrpc::CallSettings callSettings = null) => CreateFindingAsync(
                new CreateFindingRequest
                {
                    ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    FindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)),
                    Finding = gax::GaxPreconditions.CheckNotNull(finding, nameof(finding)),
                },
                callSettings);

        /// <summary>
        /// Creates a finding. The corresponding source must exist for finding creation
        /// to succeed.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the new finding's parent. Its format should be
        /// "organizations/[organization_id]/sources/[source_id]".
        /// </param>
        /// <param name="findingId">
        /// Unique identifier provided by the client within the parent scope.
        /// It must be alphanumeric and less than or equal to 32 characters and
        /// greater than 0 characters in length.
        /// </param>
        /// <param name="finding">
        /// The Finding being created. The name and security_marks will be ignored as
        /// they are both output only fields on this resource.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Finding> CreateFindingAsync(
            SourceName parent,
            string findingId,
            Finding finding,
            st::CancellationToken cancellationToken) => CreateFindingAsync(
                parent,
                findingId,
                finding,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a finding. The corresponding source must exist for finding creation
        /// to succeed.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the new finding's parent. Its format should be
        /// "organizations/[organization_id]/sources/[source_id]".
        /// </param>
        /// <param name="findingId">
        /// Unique identifier provided by the client within the parent scope.
        /// It must be alphanumeric and less than or equal to 32 characters and
        /// greater than 0 characters in length.
        /// </param>
        /// <param name="finding">
        /// The Finding being created. The name and security_marks will be ignored as
        /// they are both output only fields on this resource.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Finding CreateFinding(
            SourceName parent,
            string findingId,
            Finding finding,
            gaxgrpc::CallSettings callSettings = null) => CreateFinding(
                new CreateFindingRequest
                {
                    ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    FindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)),
                    Finding = gax::GaxPreconditions.CheckNotNull(finding, nameof(finding)),
                },
                callSettings);

        /// <summary>
        /// Creates a finding. The corresponding source must exist for finding creation
        /// to succeed.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the new finding's parent. Its format should be
        /// "organizations/[organization_id]/sources/[source_id]".
        /// </param>
        /// <param name="findingId">
        /// Unique identifier provided by the client within the parent scope.
        /// It must be alphanumeric and less than or equal to 32 characters and
        /// greater than 0 characters in length.
        /// </param>
        /// <param name="finding">
        /// The Finding being created. The name and security_marks will be ignored as
        /// they are both output only fields on this resource.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Finding> CreateFindingAsync(
            string parent,
            string findingId,
            Finding finding,
            gaxgrpc::CallSettings callSettings = null) => CreateFindingAsync(
                new CreateFindingRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    FindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)),
                    Finding = gax::GaxPreconditions.CheckNotNull(finding, nameof(finding)),
                },
                callSettings);

        /// <summary>
        /// Creates a finding. The corresponding source must exist for finding creation
        /// to succeed.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the new finding's parent. Its format should be
        /// "organizations/[organization_id]/sources/[source_id]".
        /// </param>
        /// <param name="findingId">
        /// Unique identifier provided by the client within the parent scope.
        /// It must be alphanumeric and less than or equal to 32 characters and
        /// greater than 0 characters in length.
        /// </param>
        /// <param name="finding">
        /// The Finding being created. The name and security_marks will be ignored as
        /// they are both output only fields on this resource.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Finding> CreateFindingAsync(
            string parent,
            string findingId,
            Finding finding,
            st::CancellationToken cancellationToken) => CreateFindingAsync(
                parent,
                findingId,
                finding,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a finding. The corresponding source must exist for finding creation
        /// to succeed.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the new finding's parent. Its format should be
        /// "organizations/[organization_id]/sources/[source_id]".
        /// </param>
        /// <param name="findingId">
        /// Unique identifier provided by the client within the parent scope.
        /// It must be alphanumeric and less than or equal to 32 characters and
        /// greater than 0 characters in length.
        /// </param>
        /// <param name="finding">
        /// The Finding being created. The name and security_marks will be ignored as
        /// they are both output only fields on this resource.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Finding CreateFinding(
            string parent,
            string findingId,
            Finding finding,
            gaxgrpc::CallSettings callSettings = null) => CreateFinding(
                new CreateFindingRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    FindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)),
                    Finding = gax::GaxPreconditions.CheckNotNull(finding, nameof(finding)),
                },
                callSettings);

        /// <summary>
        /// Creates a finding. The corresponding source must exist for finding creation
        /// to succeed.
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
        public virtual stt::Task<Finding> CreateFindingAsync(
            CreateFindingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a finding. The corresponding source must exist for finding creation
        /// to succeed.
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
        public virtual stt::Task<Finding> CreateFindingAsync(
            CreateFindingRequest request,
            st::CancellationToken cancellationToken) => CreateFindingAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a finding. The corresponding source must exist for finding creation
        /// to succeed.
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
        public virtual Finding CreateFinding(
            CreateFindingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy on the specified Source.
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
            SourceName resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicyAsync(
                new iam::GetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy on the specified Source.
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
            SourceName resource,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                resource,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy on the specified Source.
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
            SourceName resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicy(
                new iam::GetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy on the specified Source.
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
        /// Gets the access control policy on the specified Source.
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
        /// Gets the access control policy on the specified Source.
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
        /// Gets the access control policy on the specified Source.
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
        /// Gets the access control policy on the specified Source.
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
        /// Gets the access control policy on the specified Source.
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
        /// Gets the settings for an organization.
        /// </summary>
        /// <param name="name">
        /// Name of the organization to get organization settings for. Its format is
        /// "organizations/[organization_id]/organizationSettings".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<OrganizationSettings> GetOrganizationSettingsAsync(
            OrganizationSettingsName name,
            gaxgrpc::CallSettings callSettings = null) => GetOrganizationSettingsAsync(
                new GetOrganizationSettingsRequest
                {
                    OrganizationSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the settings for an organization.
        /// </summary>
        /// <param name="name">
        /// Name of the organization to get organization settings for. Its format is
        /// "organizations/[organization_id]/organizationSettings".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<OrganizationSettings> GetOrganizationSettingsAsync(
            OrganizationSettingsName name,
            st::CancellationToken cancellationToken) => GetOrganizationSettingsAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the settings for an organization.
        /// </summary>
        /// <param name="name">
        /// Name of the organization to get organization settings for. Its format is
        /// "organizations/[organization_id]/organizationSettings".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual OrganizationSettings GetOrganizationSettings(
            OrganizationSettingsName name,
            gaxgrpc::CallSettings callSettings = null) => GetOrganizationSettings(
                new GetOrganizationSettingsRequest
                {
                    OrganizationSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the settings for an organization.
        /// </summary>
        /// <param name="name">
        /// Name of the organization to get organization settings for. Its format is
        /// "organizations/[organization_id]/organizationSettings".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<OrganizationSettings> GetOrganizationSettingsAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetOrganizationSettingsAsync(
                new GetOrganizationSettingsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the settings for an organization.
        /// </summary>
        /// <param name="name">
        /// Name of the organization to get organization settings for. Its format is
        /// "organizations/[organization_id]/organizationSettings".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<OrganizationSettings> GetOrganizationSettingsAsync(
            string name,
            st::CancellationToken cancellationToken) => GetOrganizationSettingsAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the settings for an organization.
        /// </summary>
        /// <param name="name">
        /// Name of the organization to get organization settings for. Its format is
        /// "organizations/[organization_id]/organizationSettings".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual OrganizationSettings GetOrganizationSettings(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetOrganizationSettings(
                new GetOrganizationSettingsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the settings for an organization.
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
        public virtual stt::Task<OrganizationSettings> GetOrganizationSettingsAsync(
            GetOrganizationSettingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the settings for an organization.
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
        public virtual stt::Task<OrganizationSettings> GetOrganizationSettingsAsync(
            GetOrganizationSettingsRequest request,
            st::CancellationToken cancellationToken) => GetOrganizationSettingsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the settings for an organization.
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
        public virtual OrganizationSettings GetOrganizationSettings(
            GetOrganizationSettingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="name">
        /// Relative resource name of the source. Its format is
        /// "organizations/[organization_id]/source/[source_id]".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Source> GetSourceAsync(
            SourceName name,
            gaxgrpc::CallSettings callSettings = null) => GetSourceAsync(
                new GetSourceRequest
                {
                    SourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="name">
        /// Relative resource name of the source. Its format is
        /// "organizations/[organization_id]/source/[source_id]".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Source> GetSourceAsync(
            SourceName name,
            st::CancellationToken cancellationToken) => GetSourceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="name">
        /// Relative resource name of the source. Its format is
        /// "organizations/[organization_id]/source/[source_id]".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Source GetSource(
            SourceName name,
            gaxgrpc::CallSettings callSettings = null) => GetSource(
                new GetSourceRequest
                {
                    SourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="name">
        /// Relative resource name of the source. Its format is
        /// "organizations/[organization_id]/source/[source_id]".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Source> GetSourceAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetSourceAsync(
                new GetSourceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="name">
        /// Relative resource name of the source. Its format is
        /// "organizations/[organization_id]/source/[source_id]".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Source> GetSourceAsync(
            string name,
            st::CancellationToken cancellationToken) => GetSourceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="name">
        /// Relative resource name of the source. Its format is
        /// "organizations/[organization_id]/source/[source_id]".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Source GetSource(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetSource(
                new GetSourceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a source.
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
        public virtual stt::Task<Source> GetSourceAsync(
            GetSourceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a source.
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
        public virtual stt::Task<Source> GetSourceAsync(
            GetSourceRequest request,
            st::CancellationToken cancellationToken) => GetSourceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a source.
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
        public virtual Source GetSource(
            GetSourceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Filters an organization's assets and  groups them by their specified
        /// properties.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="GroupResult"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<GroupAssetsResponse, GroupResult> GroupAssetsAsync(
            GroupAssetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Filters an organization's assets and  groups them by their specified
        /// properties.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="GroupResult"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<GroupAssetsResponse, GroupResult> GroupAssets(
            GroupAssetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Filters an organization or source's findings and  groups them by their
        /// specified properties.
        ///
        /// To group across all sources provide a `-` as the source id.
        /// Example: /v1/organizations/123/sources/-/findings
        /// </summary>
        /// <param name="parent">
        /// Name of the source to groupBy. Its format is
        /// "organizations/[organization_id]/sources/[source_id]". To groupBy across
        /// all sources provide a source_id of `-`. For example:
        /// organizations/123/sources/-
        /// </param>
        /// <param name="groupBy">
        /// Expression that defines what assets fields to use for grouping (including
        /// `state_change`). The string value should follow SQL syntax: comma separated
        /// list of fields. For example: "parent,resource_name".
        ///
        /// The following fields are supported:
        ///
        /// * resource_name
        /// * category
        /// * state
        /// * parent
        ///
        /// The following fields are supported when compare_duration is set:
        ///
        /// * state_change
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
        /// A pageable asynchronous sequence of <see cref="GroupResult"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<GroupFindingsResponse, GroupResult> GroupFindingsAsync(
            SourceName parent,
            string groupBy,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => GroupFindingsAsync(
                new GroupFindingsRequest
                {
                    ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    GroupBy = gax::GaxPreconditions.CheckNotNullOrEmpty(groupBy, nameof(groupBy)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Filters an organization or source's findings and  groups them by their
        /// specified properties.
        ///
        /// To group across all sources provide a `-` as the source id.
        /// Example: /v1/organizations/123/sources/-/findings
        /// </summary>
        /// <param name="parent">
        /// Name of the source to groupBy. Its format is
        /// "organizations/[organization_id]/sources/[source_id]". To groupBy across
        /// all sources provide a source_id of `-`. For example:
        /// organizations/123/sources/-
        /// </param>
        /// <param name="groupBy">
        /// Expression that defines what assets fields to use for grouping (including
        /// `state_change`). The string value should follow SQL syntax: comma separated
        /// list of fields. For example: "parent,resource_name".
        ///
        /// The following fields are supported:
        ///
        /// * resource_name
        /// * category
        /// * state
        /// * parent
        ///
        /// The following fields are supported when compare_duration is set:
        ///
        /// * state_change
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
        /// A pageable sequence of <see cref="GroupResult"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<GroupFindingsResponse, GroupResult> GroupFindings(
            SourceName parent,
            string groupBy,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => GroupFindings(
                new GroupFindingsRequest
                {
                    ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    GroupBy = gax::GaxPreconditions.CheckNotNullOrEmpty(groupBy, nameof(groupBy)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Filters an organization or source's findings and  groups them by their
        /// specified properties.
        ///
        /// To group across all sources provide a `-` as the source id.
        /// Example: /v1/organizations/123/sources/-/findings
        /// </summary>
        /// <param name="parent">
        /// Name of the source to groupBy. Its format is
        /// "organizations/[organization_id]/sources/[source_id]". To groupBy across
        /// all sources provide a source_id of `-`. For example:
        /// organizations/123/sources/-
        /// </param>
        /// <param name="groupBy">
        /// Expression that defines what assets fields to use for grouping (including
        /// `state_change`). The string value should follow SQL syntax: comma separated
        /// list of fields. For example: "parent,resource_name".
        ///
        /// The following fields are supported:
        ///
        /// * resource_name
        /// * category
        /// * state
        /// * parent
        ///
        /// The following fields are supported when compare_duration is set:
        ///
        /// * state_change
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
        /// A pageable asynchronous sequence of <see cref="GroupResult"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<GroupFindingsResponse, GroupResult> GroupFindingsAsync(
            string parent,
            string groupBy,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => GroupFindingsAsync(
                new GroupFindingsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    GroupBy = gax::GaxPreconditions.CheckNotNullOrEmpty(groupBy, nameof(groupBy)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Filters an organization or source's findings and  groups them by their
        /// specified properties.
        ///
        /// To group across all sources provide a `-` as the source id.
        /// Example: /v1/organizations/123/sources/-/findings
        /// </summary>
        /// <param name="parent">
        /// Name of the source to groupBy. Its format is
        /// "organizations/[organization_id]/sources/[source_id]". To groupBy across
        /// all sources provide a source_id of `-`. For example:
        /// organizations/123/sources/-
        /// </param>
        /// <param name="groupBy">
        /// Expression that defines what assets fields to use for grouping (including
        /// `state_change`). The string value should follow SQL syntax: comma separated
        /// list of fields. For example: "parent,resource_name".
        ///
        /// The following fields are supported:
        ///
        /// * resource_name
        /// * category
        /// * state
        /// * parent
        ///
        /// The following fields are supported when compare_duration is set:
        ///
        /// * state_change
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
        /// A pageable sequence of <see cref="GroupResult"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<GroupFindingsResponse, GroupResult> GroupFindings(
            string parent,
            string groupBy,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => GroupFindings(
                new GroupFindingsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    GroupBy = gax::GaxPreconditions.CheckNotNullOrEmpty(groupBy, nameof(groupBy)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Filters an organization or source's findings and  groups them by their
        /// specified properties.
        ///
        /// To group across all sources provide a `-` as the source id.
        /// Example: /v1/organizations/123/sources/-/findings
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="GroupResult"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<GroupFindingsResponse, GroupResult> GroupFindingsAsync(
            GroupFindingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Filters an organization or source's findings and  groups them by their
        /// specified properties.
        ///
        /// To group across all sources provide a `-` as the source id.
        /// Example: /v1/organizations/123/sources/-/findings
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="GroupResult"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<GroupFindingsResponse, GroupResult> GroupFindings(
            GroupFindingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists an organization's assets.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ListAssetsResponse.Types.ListAssetsResult"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListAssetsResponse, ListAssetsResponse.Types.ListAssetsResult> ListAssetsAsync(
            ListAssetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists an organization's assets.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ListAssetsResponse.Types.ListAssetsResult"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListAssetsResponse, ListAssetsResponse.Types.ListAssetsResult> ListAssets(
            ListAssetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists an organization or source's findings.
        ///
        /// To list across all sources provide a `-` as the source id.
        /// Example: /v1/organizations/123/sources/-/findings
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ListFindingsResponse.Types.ListFindingsResult"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> ListFindingsAsync(
            ListFindingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists an organization or source's findings.
        ///
        /// To list across all sources provide a `-` as the source id.
        /// Example: /v1/organizations/123/sources/-/findings
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ListFindingsResponse.Types.ListFindingsResult"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> ListFindings(
            ListFindingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent of sources to list. Its format should be
        /// "organizations/[organization_id]".
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
        /// A pageable asynchronous sequence of <see cref="Source"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSourcesResponse, Source> ListSourcesAsync(
            OrganizationName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSourcesAsync(
                new ListSourcesRequest
                {
                    ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent of sources to list. Its format should be
        /// "organizations/[organization_id]".
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
        /// A pageable sequence of <see cref="Source"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSourcesResponse, Source> ListSources(
            OrganizationName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSources(
                new ListSourcesRequest
                {
                    ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent of sources to list. Its format should be
        /// "organizations/[organization_id]".
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
        /// A pageable asynchronous sequence of <see cref="Source"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSourcesResponse, Source> ListSourcesAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSourcesAsync(
                new ListSourcesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent of sources to list. Its format should be
        /// "organizations/[organization_id]".
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
        /// A pageable sequence of <see cref="Source"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSourcesResponse, Source> ListSources(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSources(
                new ListSourcesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Source"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSourcesResponse, Source> ListSourcesAsync(
            ListSourcesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Source"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSourcesResponse, Source> ListSources(
            ListSourcesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Runs asset discovery. The discovery is tracked with a long-running
        /// operation.
        ///
        /// This API can only be called with limited frequency for an organization. If
        /// it is called too frequently the caller will receive a TOO_MANY_REQUESTS
        /// error.
        /// </summary>
        /// <param name="parent">
        /// Name of the organization to run asset discovery for. Its format is
        /// "organizations/[organization_id]".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<RunAssetDiscoveryResponse, pbwkt::Empty>> RunAssetDiscoveryAsync(
            OrganizationName parent,
            gaxgrpc::CallSettings callSettings = null) => RunAssetDiscoveryAsync(
                new RunAssetDiscoveryRequest
                {
                    ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Runs asset discovery. The discovery is tracked with a long-running
        /// operation.
        ///
        /// This API can only be called with limited frequency for an organization. If
        /// it is called too frequently the caller will receive a TOO_MANY_REQUESTS
        /// error.
        /// </summary>
        /// <param name="parent">
        /// Name of the organization to run asset discovery for. Its format is
        /// "organizations/[organization_id]".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<RunAssetDiscoveryResponse, pbwkt::Empty>> RunAssetDiscoveryAsync(
            OrganizationName parent,
            st::CancellationToken cancellationToken) => RunAssetDiscoveryAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs asset discovery. The discovery is tracked with a long-running
        /// operation.
        ///
        /// This API can only be called with limited frequency for an organization. If
        /// it is called too frequently the caller will receive a TOO_MANY_REQUESTS
        /// error.
        /// </summary>
        /// <param name="parent">
        /// Name of the organization to run asset discovery for. Its format is
        /// "organizations/[organization_id]".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<RunAssetDiscoveryResponse, pbwkt::Empty> RunAssetDiscovery(
            OrganizationName parent,
            gaxgrpc::CallSettings callSettings = null) => RunAssetDiscovery(
                new RunAssetDiscoveryRequest
                {
                    ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Runs asset discovery. The discovery is tracked with a long-running
        /// operation.
        ///
        /// This API can only be called with limited frequency for an organization. If
        /// it is called too frequently the caller will receive a TOO_MANY_REQUESTS
        /// error.
        /// </summary>
        /// <param name="parent">
        /// Name of the organization to run asset discovery for. Its format is
        /// "organizations/[organization_id]".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<RunAssetDiscoveryResponse, pbwkt::Empty>> RunAssetDiscoveryAsync(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => RunAssetDiscoveryAsync(
                new RunAssetDiscoveryRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Runs asset discovery. The discovery is tracked with a long-running
        /// operation.
        ///
        /// This API can only be called with limited frequency for an organization. If
        /// it is called too frequently the caller will receive a TOO_MANY_REQUESTS
        /// error.
        /// </summary>
        /// <param name="parent">
        /// Name of the organization to run asset discovery for. Its format is
        /// "organizations/[organization_id]".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<RunAssetDiscoveryResponse, pbwkt::Empty>> RunAssetDiscoveryAsync(
            string parent,
            st::CancellationToken cancellationToken) => RunAssetDiscoveryAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs asset discovery. The discovery is tracked with a long-running
        /// operation.
        ///
        /// This API can only be called with limited frequency for an organization. If
        /// it is called too frequently the caller will receive a TOO_MANY_REQUESTS
        /// error.
        /// </summary>
        /// <param name="parent">
        /// Name of the organization to run asset discovery for. Its format is
        /// "organizations/[organization_id]".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<RunAssetDiscoveryResponse, pbwkt::Empty> RunAssetDiscovery(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => RunAssetDiscovery(
                new RunAssetDiscoveryRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Runs asset discovery. The discovery is tracked with a long-running
        /// operation.
        ///
        /// This API can only be called with limited frequency for an organization. If
        /// it is called too frequently the caller will receive a TOO_MANY_REQUESTS
        /// error.
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
        public virtual stt::Task<lro::Operation<RunAssetDiscoveryResponse, pbwkt::Empty>> RunAssetDiscoveryAsync(
            RunAssetDiscoveryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunAssetDiscoveryAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RunAssetDiscoveryResponse, pbwkt::Empty>> PollOnceRunAssetDiscoveryAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<RunAssetDiscoveryResponse, pbwkt::Empty>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                RunAssetDiscoveryOperationsClient,
                callSettings);

        /// <summary>
        /// Runs asset discovery. The discovery is tracked with a long-running
        /// operation.
        ///
        /// This API can only be called with limited frequency for an organization. If
        /// it is called too frequently the caller will receive a TOO_MANY_REQUESTS
        /// error.
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
        public virtual lro::Operation<RunAssetDiscoveryResponse, pbwkt::Empty> RunAssetDiscovery(
            RunAssetDiscoveryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>RunAssetDiscovery</c>.
        /// </summary>
        public virtual lro::OperationsClient RunAssetDiscoveryOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunAssetDiscovery</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RunAssetDiscoveryResponse, pbwkt::Empty> PollOnceRunAssetDiscovery(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<RunAssetDiscoveryResponse, pbwkt::Empty>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                RunAssetDiscoveryOperationsClient,
                callSettings);

        /// <summary>
        /// Updates the state of a finding.
        /// </summary>
        /// <param name="name">
        /// The relative resource name of the finding. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name
        /// Example:
        /// "organizations/123/sources/456/finding/789".
        /// </param>
        /// <param name="state">
        /// The desired State of the finding.
        /// </param>
        /// <param name="startTime">
        /// The time at which the updated state takes effect.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Finding> SetFindingStateAsync(
            FindingName name,
            Finding.Types.State state,
            pbwkt::Timestamp startTime,
            gaxgrpc::CallSettings callSettings = null) => SetFindingStateAsync(
                new SetFindingStateRequest
                {
                    FindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    State = state,
                    StartTime = gax::GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                },
                callSettings);

        /// <summary>
        /// Updates the state of a finding.
        /// </summary>
        /// <param name="name">
        /// The relative resource name of the finding. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name
        /// Example:
        /// "organizations/123/sources/456/finding/789".
        /// </param>
        /// <param name="state">
        /// The desired State of the finding.
        /// </param>
        /// <param name="startTime">
        /// The time at which the updated state takes effect.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Finding> SetFindingStateAsync(
            FindingName name,
            Finding.Types.State state,
            pbwkt::Timestamp startTime,
            st::CancellationToken cancellationToken) => SetFindingStateAsync(
                name,
                state,
                startTime,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the state of a finding.
        /// </summary>
        /// <param name="name">
        /// The relative resource name of the finding. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name
        /// Example:
        /// "organizations/123/sources/456/finding/789".
        /// </param>
        /// <param name="state">
        /// The desired State of the finding.
        /// </param>
        /// <param name="startTime">
        /// The time at which the updated state takes effect.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Finding SetFindingState(
            FindingName name,
            Finding.Types.State state,
            pbwkt::Timestamp startTime,
            gaxgrpc::CallSettings callSettings = null) => SetFindingState(
                new SetFindingStateRequest
                {
                    FindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    State = state,
                    StartTime = gax::GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                },
                callSettings);

        /// <summary>
        /// Updates the state of a finding.
        /// </summary>
        /// <param name="name">
        /// The relative resource name of the finding. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name
        /// Example:
        /// "organizations/123/sources/456/finding/789".
        /// </param>
        /// <param name="state">
        /// The desired State of the finding.
        /// </param>
        /// <param name="startTime">
        /// The time at which the updated state takes effect.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Finding> SetFindingStateAsync(
            string name,
            Finding.Types.State state,
            pbwkt::Timestamp startTime,
            gaxgrpc::CallSettings callSettings = null) => SetFindingStateAsync(
                new SetFindingStateRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    State = state,
                    StartTime = gax::GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                },
                callSettings);

        /// <summary>
        /// Updates the state of a finding.
        /// </summary>
        /// <param name="name">
        /// The relative resource name of the finding. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name
        /// Example:
        /// "organizations/123/sources/456/finding/789".
        /// </param>
        /// <param name="state">
        /// The desired State of the finding.
        /// </param>
        /// <param name="startTime">
        /// The time at which the updated state takes effect.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Finding> SetFindingStateAsync(
            string name,
            Finding.Types.State state,
            pbwkt::Timestamp startTime,
            st::CancellationToken cancellationToken) => SetFindingStateAsync(
                name,
                state,
                startTime,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the state of a finding.
        /// </summary>
        /// <param name="name">
        /// The relative resource name of the finding. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name
        /// Example:
        /// "organizations/123/sources/456/finding/789".
        /// </param>
        /// <param name="state">
        /// The desired State of the finding.
        /// </param>
        /// <param name="startTime">
        /// The time at which the updated state takes effect.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Finding SetFindingState(
            string name,
            Finding.Types.State state,
            pbwkt::Timestamp startTime,
            gaxgrpc::CallSettings callSettings = null) => SetFindingState(
                new SetFindingStateRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    State = state,
                    StartTime = gax::GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                },
                callSettings);

        /// <summary>
        /// Updates the state of a finding.
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
        public virtual stt::Task<Finding> SetFindingStateAsync(
            SetFindingStateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the state of a finding.
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
        public virtual stt::Task<Finding> SetFindingStateAsync(
            SetFindingStateRequest request,
            st::CancellationToken cancellationToken) => SetFindingStateAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the state of a finding.
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
        public virtual Finding SetFindingState(
            SetFindingStateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on the specified Source.
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
            SourceName resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicyAsync(
                new iam::SetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on the specified Source.
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
            SourceName resource,
            iam::Policy policy,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                resource,
                policy,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified Source.
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
            SourceName resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicy(
                new iam::SetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on the specified Source.
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
        /// Sets the access control policy on the specified Source.
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
        /// Sets the access control policy on the specified Source.
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
        /// Sets the access control policy on the specified Source.
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
        /// Sets the access control policy on the specified Source.
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
        /// Sets the access control policy on the specified Source.
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
        /// Returns the permissions that a caller has on the specified source.
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
            SourceName resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissionsAsync(
                new iam::TestIamPermissionsRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified source.
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
            SourceName resource,
            scg::IEnumerable<string> permissions,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                resource,
                permissions,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the permissions that a caller has on the specified source.
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
            SourceName resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissions(
                new iam::TestIamPermissionsRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified source.
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
        /// Returns the permissions that a caller has on the specified source.
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
        /// Returns the permissions that a caller has on the specified source.
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
        /// Returns the permissions that a caller has on the specified source.
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
        /// Returns the permissions that a caller has on the specified source.
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
        /// Returns the permissions that a caller has on the specified source.
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

        /// <summary>
        /// Creates or updates a finding. The corresponding source must exist for a
        /// finding creation to succeed.
        /// </summary>
        /// <param name="finding">
        /// The finding resource to update or create if it does not already exist.
        /// parent, security_marks, and update_time will be ignored.
        ///
        /// In the case of creation, the finding id portion of the name must be
        /// alphanumeric and less than or equal to 32 characters and greater than 0
        /// characters in length.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Finding> UpdateFindingAsync(
            Finding finding,
            gaxgrpc::CallSettings callSettings = null) => UpdateFindingAsync(
                new UpdateFindingRequest
                {
                    Finding = gax::GaxPreconditions.CheckNotNull(finding, nameof(finding)),
                },
                callSettings);

        /// <summary>
        /// Creates or updates a finding. The corresponding source must exist for a
        /// finding creation to succeed.
        /// </summary>
        /// <param name="finding">
        /// The finding resource to update or create if it does not already exist.
        /// parent, security_marks, and update_time will be ignored.
        ///
        /// In the case of creation, the finding id portion of the name must be
        /// alphanumeric and less than or equal to 32 characters and greater than 0
        /// characters in length.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Finding> UpdateFindingAsync(
            Finding finding,
            st::CancellationToken cancellationToken) => UpdateFindingAsync(
                finding,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates a finding. The corresponding source must exist for a
        /// finding creation to succeed.
        /// </summary>
        /// <param name="finding">
        /// The finding resource to update or create if it does not already exist.
        /// parent, security_marks, and update_time will be ignored.
        ///
        /// In the case of creation, the finding id portion of the name must be
        /// alphanumeric and less than or equal to 32 characters and greater than 0
        /// characters in length.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Finding UpdateFinding(
            Finding finding,
            gaxgrpc::CallSettings callSettings = null) => UpdateFinding(
                new UpdateFindingRequest
                {
                    Finding = gax::GaxPreconditions.CheckNotNull(finding, nameof(finding)),
                },
                callSettings);

        /// <summary>
        /// Creates or updates a finding. The corresponding source must exist for a
        /// finding creation to succeed.
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
        public virtual stt::Task<Finding> UpdateFindingAsync(
            UpdateFindingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates or updates a finding. The corresponding source must exist for a
        /// finding creation to succeed.
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
        public virtual stt::Task<Finding> UpdateFindingAsync(
            UpdateFindingRequest request,
            st::CancellationToken cancellationToken) => UpdateFindingAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates a finding. The corresponding source must exist for a
        /// finding creation to succeed.
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
        public virtual Finding UpdateFinding(
            UpdateFindingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an organization's settings.
        /// </summary>
        /// <param name="organizationSettings">
        /// The organization settings resource to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<OrganizationSettings> UpdateOrganizationSettingsAsync(
            OrganizationSettings organizationSettings,
            gaxgrpc::CallSettings callSettings = null) => UpdateOrganizationSettingsAsync(
                new UpdateOrganizationSettingsRequest
                {
                    OrganizationSettings = gax::GaxPreconditions.CheckNotNull(organizationSettings, nameof(organizationSettings)),
                },
                callSettings);

        /// <summary>
        /// Updates an organization's settings.
        /// </summary>
        /// <param name="organizationSettings">
        /// The organization settings resource to update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<OrganizationSettings> UpdateOrganizationSettingsAsync(
            OrganizationSettings organizationSettings,
            st::CancellationToken cancellationToken) => UpdateOrganizationSettingsAsync(
                organizationSettings,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an organization's settings.
        /// </summary>
        /// <param name="organizationSettings">
        /// The organization settings resource to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual OrganizationSettings UpdateOrganizationSettings(
            OrganizationSettings organizationSettings,
            gaxgrpc::CallSettings callSettings = null) => UpdateOrganizationSettings(
                new UpdateOrganizationSettingsRequest
                {
                    OrganizationSettings = gax::GaxPreconditions.CheckNotNull(organizationSettings, nameof(organizationSettings)),
                },
                callSettings);

        /// <summary>
        /// Updates an organization's settings.
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
        public virtual stt::Task<OrganizationSettings> UpdateOrganizationSettingsAsync(
            UpdateOrganizationSettingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an organization's settings.
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
        public virtual stt::Task<OrganizationSettings> UpdateOrganizationSettingsAsync(
            UpdateOrganizationSettingsRequest request,
            st::CancellationToken cancellationToken) => UpdateOrganizationSettingsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an organization's settings.
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
        public virtual OrganizationSettings UpdateOrganizationSettings(
            UpdateOrganizationSettingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates a source.
        /// </summary>
        /// <param name="source">
        /// The source resource to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Source> UpdateSourceAsync(
            Source source,
            gaxgrpc::CallSettings callSettings = null) => UpdateSourceAsync(
                new UpdateSourceRequest
                {
                    Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
                },
                callSettings);

        /// <summary>
        /// Updates a source.
        /// </summary>
        /// <param name="source">
        /// The source resource to update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Source> UpdateSourceAsync(
            Source source,
            st::CancellationToken cancellationToken) => UpdateSourceAsync(
                source,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a source.
        /// </summary>
        /// <param name="source">
        /// The source resource to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Source UpdateSource(
            Source source,
            gaxgrpc::CallSettings callSettings = null) => UpdateSource(
                new UpdateSourceRequest
                {
                    Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
                },
                callSettings);

        /// <summary>
        /// Updates a source.
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
        public virtual stt::Task<Source> UpdateSourceAsync(
            UpdateSourceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates a source.
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
        public virtual stt::Task<Source> UpdateSourceAsync(
            UpdateSourceRequest request,
            st::CancellationToken cancellationToken) => UpdateSourceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a source.
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
        public virtual Source UpdateSource(
            UpdateSourceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates security marks.
        /// </summary>
        /// <param name="securityMarks">
        /// The security marks resource to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SecurityMarks> UpdateSecurityMarksAsync(
            SecurityMarks securityMarks,
            gaxgrpc::CallSettings callSettings = null) => UpdateSecurityMarksAsync(
                new UpdateSecurityMarksRequest
                {
                    SecurityMarks = gax::GaxPreconditions.CheckNotNull(securityMarks, nameof(securityMarks)),
                },
                callSettings);

        /// <summary>
        /// Updates security marks.
        /// </summary>
        /// <param name="securityMarks">
        /// The security marks resource to update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SecurityMarks> UpdateSecurityMarksAsync(
            SecurityMarks securityMarks,
            st::CancellationToken cancellationToken) => UpdateSecurityMarksAsync(
                securityMarks,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates security marks.
        /// </summary>
        /// <param name="securityMarks">
        /// The security marks resource to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SecurityMarks UpdateSecurityMarks(
            SecurityMarks securityMarks,
            gaxgrpc::CallSettings callSettings = null) => UpdateSecurityMarks(
                new UpdateSecurityMarksRequest
                {
                    SecurityMarks = gax::GaxPreconditions.CheckNotNull(securityMarks, nameof(securityMarks)),
                },
                callSettings);

        /// <summary>
        /// Updates security marks.
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
        public virtual stt::Task<SecurityMarks> UpdateSecurityMarksAsync(
            UpdateSecurityMarksRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates security marks.
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
        public virtual stt::Task<SecurityMarks> UpdateSecurityMarksAsync(
            UpdateSecurityMarksRequest request,
            st::CancellationToken cancellationToken) => UpdateSecurityMarksAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates security marks.
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
        public virtual SecurityMarks UpdateSecurityMarks(
            UpdateSecurityMarksRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// SecurityCenter client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class SecurityCenterClientImpl : SecurityCenterClient
    {
        private readonly gaxgrpc::ApiCall<CreateSourceRequest, Source> _callCreateSource;
        private readonly gaxgrpc::ApiCall<CreateFindingRequest, Finding> _callCreateFinding;
        private readonly gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> _callGetIamPolicy;
        private readonly gaxgrpc::ApiCall<GetOrganizationSettingsRequest, OrganizationSettings> _callGetOrganizationSettings;
        private readonly gaxgrpc::ApiCall<GetSourceRequest, Source> _callGetSource;
        private readonly gaxgrpc::ApiCall<GroupAssetsRequest, GroupAssetsResponse> _callGroupAssets;
        private readonly gaxgrpc::ApiCall<GroupFindingsRequest, GroupFindingsResponse> _callGroupFindings;
        private readonly gaxgrpc::ApiCall<ListAssetsRequest, ListAssetsResponse> _callListAssets;
        private readonly gaxgrpc::ApiCall<ListFindingsRequest, ListFindingsResponse> _callListFindings;
        private readonly gaxgrpc::ApiCall<ListSourcesRequest, ListSourcesResponse> _callListSources;
        private readonly gaxgrpc::ApiCall<RunAssetDiscoveryRequest, lro::Operation> _callRunAssetDiscovery;
        private readonly gaxgrpc::ApiCall<SetFindingStateRequest, Finding> _callSetFindingState;
        private readonly gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> _callSetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> _callTestIamPermissions;
        private readonly gaxgrpc::ApiCall<UpdateFindingRequest, Finding> _callUpdateFinding;
        private readonly gaxgrpc::ApiCall<UpdateOrganizationSettingsRequest, OrganizationSettings> _callUpdateOrganizationSettings;
        private readonly gaxgrpc::ApiCall<UpdateSourceRequest, Source> _callUpdateSource;
        private readonly gaxgrpc::ApiCall<UpdateSecurityMarksRequest, SecurityMarks> _callUpdateSecurityMarks;

        /// <summary>
        /// Constructs a client wrapper for the SecurityCenter service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SecurityCenterSettings"/> used within this client </param>
        public SecurityCenterClientImpl(SecurityCenter.SecurityCenterClient grpcClient, SecurityCenterSettings settings)
        {
            GrpcClient = grpcClient;
            SecurityCenterSettings effectiveSettings = settings ?? SecurityCenterSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            RunAssetDiscoveryOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.RunAssetDiscoveryOperationsSettings);
            _callCreateSource = clientHelper.BuildApiCall<CreateSourceRequest, Source>(
                GrpcClient.CreateSourceAsync, GrpcClient.CreateSource, effectiveSettings.CreateSourceSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callCreateFinding = clientHelper.BuildApiCall<CreateFindingRequest, Finding>(
                GrpcClient.CreateFindingAsync, GrpcClient.CreateFinding, effectiveSettings.CreateFindingSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callGetIamPolicy = clientHelper.BuildApiCall<iam::GetIamPolicyRequest, iam::Policy>(
                GrpcClient.GetIamPolicyAsync, GrpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            _callGetOrganizationSettings = clientHelper.BuildApiCall<GetOrganizationSettingsRequest, OrganizationSettings>(
                GrpcClient.GetOrganizationSettingsAsync, GrpcClient.GetOrganizationSettings, effectiveSettings.GetOrganizationSettingsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callGetSource = clientHelper.BuildApiCall<GetSourceRequest, Source>(
                GrpcClient.GetSourceAsync, GrpcClient.GetSource, effectiveSettings.GetSourceSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callGroupAssets = clientHelper.BuildApiCall<GroupAssetsRequest, GroupAssetsResponse>(
                GrpcClient.GroupAssetsAsync, GrpcClient.GroupAssets, effectiveSettings.GroupAssetsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callGroupFindings = clientHelper.BuildApiCall<GroupFindingsRequest, GroupFindingsResponse>(
                GrpcClient.GroupFindingsAsync, GrpcClient.GroupFindings, effectiveSettings.GroupFindingsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callListAssets = clientHelper.BuildApiCall<ListAssetsRequest, ListAssetsResponse>(
                GrpcClient.ListAssetsAsync, GrpcClient.ListAssets, effectiveSettings.ListAssetsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callListFindings = clientHelper.BuildApiCall<ListFindingsRequest, ListFindingsResponse>(
                GrpcClient.ListFindingsAsync, GrpcClient.ListFindings, effectiveSettings.ListFindingsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callListSources = clientHelper.BuildApiCall<ListSourcesRequest, ListSourcesResponse>(
                GrpcClient.ListSourcesAsync, GrpcClient.ListSources, effectiveSettings.ListSourcesSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callRunAssetDiscovery = clientHelper.BuildApiCall<RunAssetDiscoveryRequest, lro::Operation>(
                GrpcClient.RunAssetDiscoveryAsync, GrpcClient.RunAssetDiscovery, effectiveSettings.RunAssetDiscoverySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callSetFindingState = clientHelper.BuildApiCall<SetFindingStateRequest, Finding>(
                GrpcClient.SetFindingStateAsync, GrpcClient.SetFindingState, effectiveSettings.SetFindingStateSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callSetIamPolicy = clientHelper.BuildApiCall<iam::SetIamPolicyRequest, iam::Policy>(
                GrpcClient.SetIamPolicyAsync, GrpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            _callTestIamPermissions = clientHelper.BuildApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse>(
                GrpcClient.TestIamPermissionsAsync, GrpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            _callUpdateFinding = clientHelper.BuildApiCall<UpdateFindingRequest, Finding>(
                GrpcClient.UpdateFindingAsync, GrpcClient.UpdateFinding, effectiveSettings.UpdateFindingSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"finding.name={request.Finding?.Name}"));
            _callUpdateOrganizationSettings = clientHelper.BuildApiCall<UpdateOrganizationSettingsRequest, OrganizationSettings>(
                GrpcClient.UpdateOrganizationSettingsAsync, GrpcClient.UpdateOrganizationSettings, effectiveSettings.UpdateOrganizationSettingsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"organization_settings.name={request.OrganizationSettings?.Name}"));
            _callUpdateSource = clientHelper.BuildApiCall<UpdateSourceRequest, Source>(
                GrpcClient.UpdateSourceAsync, GrpcClient.UpdateSource, effectiveSettings.UpdateSourceSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"source.name={request.Source?.Name}"));
            _callUpdateSecurityMarks = clientHelper.BuildApiCall<UpdateSecurityMarksRequest, SecurityMarks>(
                GrpcClient.UpdateSecurityMarksAsync, GrpcClient.UpdateSecurityMarks, effectiveSettings.UpdateSecurityMarksSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"security_marks.name={request.SecurityMarks?.Name}"));
            Modify_ApiCall(ref _callCreateSource);
            Modify_CreateSourceApiCall(ref _callCreateSource);
            Modify_ApiCall(ref _callCreateFinding);
            Modify_CreateFindingApiCall(ref _callCreateFinding);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            Modify_ApiCall(ref _callGetOrganizationSettings);
            Modify_GetOrganizationSettingsApiCall(ref _callGetOrganizationSettings);
            Modify_ApiCall(ref _callGetSource);
            Modify_GetSourceApiCall(ref _callGetSource);
            Modify_ApiCall(ref _callGroupAssets);
            Modify_GroupAssetsApiCall(ref _callGroupAssets);
            Modify_ApiCall(ref _callGroupFindings);
            Modify_GroupFindingsApiCall(ref _callGroupFindings);
            Modify_ApiCall(ref _callListAssets);
            Modify_ListAssetsApiCall(ref _callListAssets);
            Modify_ApiCall(ref _callListFindings);
            Modify_ListFindingsApiCall(ref _callListFindings);
            Modify_ApiCall(ref _callListSources);
            Modify_ListSourcesApiCall(ref _callListSources);
            Modify_ApiCall(ref _callRunAssetDiscovery);
            Modify_RunAssetDiscoveryApiCall(ref _callRunAssetDiscovery);
            Modify_ApiCall(ref _callSetFindingState);
            Modify_SetFindingStateApiCall(ref _callSetFindingState);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            Modify_ApiCall(ref _callUpdateFinding);
            Modify_UpdateFindingApiCall(ref _callUpdateFinding);
            Modify_ApiCall(ref _callUpdateOrganizationSettings);
            Modify_UpdateOrganizationSettingsApiCall(ref _callUpdateOrganizationSettings);
            Modify_ApiCall(ref _callUpdateSource);
            Modify_UpdateSourceApiCall(ref _callUpdateSource);
            Modify_ApiCall(ref _callUpdateSecurityMarks);
            Modify_UpdateSecurityMarksApiCall(ref _callUpdateSecurityMarks);
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
        partial void Modify_CreateSourceApiCall(ref gaxgrpc::ApiCall<CreateSourceRequest, Source> call);
        partial void Modify_CreateFindingApiCall(ref gaxgrpc::ApiCall<CreateFindingRequest, Finding> call);
        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> call);
        partial void Modify_GetOrganizationSettingsApiCall(ref gaxgrpc::ApiCall<GetOrganizationSettingsRequest, OrganizationSettings> call);
        partial void Modify_GetSourceApiCall(ref gaxgrpc::ApiCall<GetSourceRequest, Source> call);
        partial void Modify_GroupAssetsApiCall(ref gaxgrpc::ApiCall<GroupAssetsRequest, GroupAssetsResponse> call);
        partial void Modify_GroupFindingsApiCall(ref gaxgrpc::ApiCall<GroupFindingsRequest, GroupFindingsResponse> call);
        partial void Modify_ListAssetsApiCall(ref gaxgrpc::ApiCall<ListAssetsRequest, ListAssetsResponse> call);
        partial void Modify_ListFindingsApiCall(ref gaxgrpc::ApiCall<ListFindingsRequest, ListFindingsResponse> call);
        partial void Modify_ListSourcesApiCall(ref gaxgrpc::ApiCall<ListSourcesRequest, ListSourcesResponse> call);
        partial void Modify_RunAssetDiscoveryApiCall(ref gaxgrpc::ApiCall<RunAssetDiscoveryRequest, lro::Operation> call);
        partial void Modify_SetFindingStateApiCall(ref gaxgrpc::ApiCall<SetFindingStateRequest, Finding> call);
        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> call);
        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> call);
        partial void Modify_UpdateFindingApiCall(ref gaxgrpc::ApiCall<UpdateFindingRequest, Finding> call);
        partial void Modify_UpdateOrganizationSettingsApiCall(ref gaxgrpc::ApiCall<UpdateOrganizationSettingsRequest, OrganizationSettings> call);
        partial void Modify_UpdateSourceApiCall(ref gaxgrpc::ApiCall<UpdateSourceRequest, Source> call);
        partial void Modify_UpdateSecurityMarksApiCall(ref gaxgrpc::ApiCall<UpdateSecurityMarksRequest, SecurityMarks> call);
        partial void OnConstruction(SecurityCenter.SecurityCenterClient grpcClient, SecurityCenterSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC SecurityCenter client.
        /// </summary>
        public override SecurityCenter.SecurityCenterClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateSourceRequest(ref CreateSourceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateFindingRequest(ref CreateFindingRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetIamPolicyRequest(ref iam::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetOrganizationSettingsRequest(ref GetOrganizationSettingsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetSourceRequest(ref GetSourceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GroupAssetsRequest(ref GroupAssetsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GroupFindingsRequest(ref GroupFindingsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListAssetsRequest(ref ListAssetsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListFindingsRequest(ref ListFindingsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListSourcesRequest(ref ListSourcesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_RunAssetDiscoveryRequest(ref RunAssetDiscoveryRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SetFindingStateRequest(ref SetFindingStateRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SetIamPolicyRequest(ref iam::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_TestIamPermissionsRequest(ref iam::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateFindingRequest(ref UpdateFindingRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateOrganizationSettingsRequest(ref UpdateOrganizationSettingsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateSourceRequest(ref UpdateSourceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateSecurityMarksRequest(ref UpdateSecurityMarksRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a source.
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
        public override stt::Task<Source> CreateSourceAsync(
            CreateSourceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSourceRequest(ref request, ref callSettings);
            return _callCreateSource.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a source.
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
        public override Source CreateSource(
            CreateSourceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSourceRequest(ref request, ref callSettings);
            return _callCreateSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a finding. The corresponding source must exist for finding creation
        /// to succeed.
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
        public override stt::Task<Finding> CreateFindingAsync(
            CreateFindingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFindingRequest(ref request, ref callSettings);
            return _callCreateFinding.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a finding. The corresponding source must exist for finding creation
        /// to succeed.
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
        public override Finding CreateFinding(
            CreateFindingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFindingRequest(ref request, ref callSettings);
            return _callCreateFinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy on the specified Source.
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
        /// Gets the access control policy on the specified Source.
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
        /// Gets the settings for an organization.
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
        public override stt::Task<OrganizationSettings> GetOrganizationSettingsAsync(
            GetOrganizationSettingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrganizationSettingsRequest(ref request, ref callSettings);
            return _callGetOrganizationSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the settings for an organization.
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
        public override OrganizationSettings GetOrganizationSettings(
            GetOrganizationSettingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrganizationSettingsRequest(ref request, ref callSettings);
            return _callGetOrganizationSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a source.
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
        public override stt::Task<Source> GetSourceAsync(
            GetSourceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSourceRequest(ref request, ref callSettings);
            return _callGetSource.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a source.
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
        public override Source GetSource(
            GetSourceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSourceRequest(ref request, ref callSettings);
            return _callGetSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Filters an organization's assets and  groups them by their specified
        /// properties.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="GroupResult"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<GroupAssetsResponse, GroupResult> GroupAssetsAsync(
            GroupAssetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GroupAssetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<GroupAssetsRequest, GroupAssetsResponse, GroupResult>(_callGroupAssets, request, callSettings);
        }

        /// <summary>
        /// Filters an organization's assets and  groups them by their specified
        /// properties.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="GroupResult"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<GroupAssetsResponse, GroupResult> GroupAssets(
            GroupAssetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GroupAssetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<GroupAssetsRequest, GroupAssetsResponse, GroupResult>(_callGroupAssets, request, callSettings);
        }

        /// <summary>
        /// Filters an organization or source's findings and  groups them by their
        /// specified properties.
        ///
        /// To group across all sources provide a `-` as the source id.
        /// Example: /v1/organizations/123/sources/-/findings
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="GroupResult"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<GroupFindingsResponse, GroupResult> GroupFindingsAsync(
            GroupFindingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GroupFindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<GroupFindingsRequest, GroupFindingsResponse, GroupResult>(_callGroupFindings, request, callSettings);
        }

        /// <summary>
        /// Filters an organization or source's findings and  groups them by their
        /// specified properties.
        ///
        /// To group across all sources provide a `-` as the source id.
        /// Example: /v1/organizations/123/sources/-/findings
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="GroupResult"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<GroupFindingsResponse, GroupResult> GroupFindings(
            GroupFindingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GroupFindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<GroupFindingsRequest, GroupFindingsResponse, GroupResult>(_callGroupFindings, request, callSettings);
        }

        /// <summary>
        /// Lists an organization's assets.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ListAssetsResponse.Types.ListAssetsResult"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListAssetsResponse, ListAssetsResponse.Types.ListAssetsResult> ListAssetsAsync(
            ListAssetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAssetsRequest, ListAssetsResponse, ListAssetsResponse.Types.ListAssetsResult>(_callListAssets, request, callSettings);
        }

        /// <summary>
        /// Lists an organization's assets.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ListAssetsResponse.Types.ListAssetsResult"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListAssetsResponse, ListAssetsResponse.Types.ListAssetsResult> ListAssets(
            ListAssetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAssetsRequest, ListAssetsResponse, ListAssetsResponse.Types.ListAssetsResult>(_callListAssets, request, callSettings);
        }

        /// <summary>
        /// Lists an organization or source's findings.
        ///
        /// To list across all sources provide a `-` as the source id.
        /// Example: /v1/organizations/123/sources/-/findings
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ListFindingsResponse.Types.ListFindingsResult"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> ListFindingsAsync(
            ListFindingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFindingsRequest, ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult>(_callListFindings, request, callSettings);
        }

        /// <summary>
        /// Lists an organization or source's findings.
        ///
        /// To list across all sources provide a `-` as the source id.
        /// Example: /v1/organizations/123/sources/-/findings
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ListFindingsResponse.Types.ListFindingsResult"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> ListFindings(
            ListFindingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFindingsRequest, ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult>(_callListFindings, request, callSettings);
        }

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Source"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListSourcesResponse, Source> ListSourcesAsync(
            ListSourcesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSourcesRequest, ListSourcesResponse, Source>(_callListSources, request, callSettings);
        }

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Source"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListSourcesResponse, Source> ListSources(
            ListSourcesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSourcesRequest, ListSourcesResponse, Source>(_callListSources, request, callSettings);
        }

        /// <summary>
        /// Runs asset discovery. The discovery is tracked with a long-running
        /// operation.
        ///
        /// This API can only be called with limited frequency for an organization. If
        /// it is called too frequently the caller will receive a TOO_MANY_REQUESTS
        /// error.
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
        public override async stt::Task<lro::Operation<RunAssetDiscoveryResponse, pbwkt::Empty>> RunAssetDiscoveryAsync(
            RunAssetDiscoveryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunAssetDiscoveryRequest(ref request, ref callSettings);
            return new lro::Operation<RunAssetDiscoveryResponse, pbwkt::Empty>(
                await _callRunAssetDiscovery.Async(request, callSettings).ConfigureAwait(false), RunAssetDiscoveryOperationsClient);
        }

        /// <summary>
        /// Runs asset discovery. The discovery is tracked with a long-running
        /// operation.
        ///
        /// This API can only be called with limited frequency for an organization. If
        /// it is called too frequently the caller will receive a TOO_MANY_REQUESTS
        /// error.
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
        public override lro::Operation<RunAssetDiscoveryResponse, pbwkt::Empty> RunAssetDiscovery(
            RunAssetDiscoveryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunAssetDiscoveryRequest(ref request, ref callSettings);
            return new lro::Operation<RunAssetDiscoveryResponse, pbwkt::Empty>(
                _callRunAssetDiscovery.Sync(request, callSettings), RunAssetDiscoveryOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>RunAssetDiscovery</c>.
        /// </summary>
        public override lro::OperationsClient RunAssetDiscoveryOperationsClient { get; }

        /// <summary>
        /// Updates the state of a finding.
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
        public override stt::Task<Finding> SetFindingStateAsync(
            SetFindingStateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetFindingStateRequest(ref request, ref callSettings);
            return _callSetFindingState.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the state of a finding.
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
        public override Finding SetFindingState(
            SetFindingStateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetFindingStateRequest(ref request, ref callSettings);
            return _callSetFindingState.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified Source.
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
        /// Sets the access control policy on the specified Source.
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
        /// Returns the permissions that a caller has on the specified source.
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
        /// Returns the permissions that a caller has on the specified source.
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

        /// <summary>
        /// Creates or updates a finding. The corresponding source must exist for a
        /// finding creation to succeed.
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
        public override stt::Task<Finding> UpdateFindingAsync(
            UpdateFindingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFindingRequest(ref request, ref callSettings);
            return _callUpdateFinding.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or updates a finding. The corresponding source must exist for a
        /// finding creation to succeed.
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
        public override Finding UpdateFinding(
            UpdateFindingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFindingRequest(ref request, ref callSettings);
            return _callUpdateFinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an organization's settings.
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
        public override stt::Task<OrganizationSettings> UpdateOrganizationSettingsAsync(
            UpdateOrganizationSettingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOrganizationSettingsRequest(ref request, ref callSettings);
            return _callUpdateOrganizationSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an organization's settings.
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
        public override OrganizationSettings UpdateOrganizationSettings(
            UpdateOrganizationSettingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOrganizationSettingsRequest(ref request, ref callSettings);
            return _callUpdateOrganizationSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a source.
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
        public override stt::Task<Source> UpdateSourceAsync(
            UpdateSourceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSourceRequest(ref request, ref callSettings);
            return _callUpdateSource.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a source.
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
        public override Source UpdateSource(
            UpdateSourceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSourceRequest(ref request, ref callSettings);
            return _callUpdateSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates security marks.
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
        public override stt::Task<SecurityMarks> UpdateSecurityMarksAsync(
            UpdateSecurityMarksRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSecurityMarksRequest(ref request, ref callSettings);
            return _callUpdateSecurityMarks.Async(request, callSettings);
        }

        /// <summary>
        /// Updates security marks.
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
        public override SecurityMarks UpdateSecurityMarks(
            UpdateSecurityMarksRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSecurityMarksRequest(ref request, ref callSettings);
            return _callUpdateSecurityMarks.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class GroupAssetsRequest : gaxgrpc::IPageRequest { }
    public partial class GroupAssetsResponse : gaxgrpc::IPageResponse<GroupResult>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<GroupResult> GetEnumerator() => GroupByResults.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class GroupFindingsRequest : gaxgrpc::IPageRequest { }
    public partial class GroupFindingsResponse : gaxgrpc::IPageResponse<GroupResult>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<GroupResult> GetEnumerator() => GroupByResults.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAssetsRequest : gaxgrpc::IPageRequest { }
    public partial class ListAssetsResponse : gaxgrpc::IPageResponse<ListAssetsResponse.Types.ListAssetsResult>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<ListAssetsResponse.Types.ListAssetsResult> GetEnumerator() => ListAssetsResults.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFindingsRequest : gaxgrpc::IPageRequest { }
    public partial class ListFindingsResponse : gaxgrpc::IPageResponse<ListFindingsResponse.Types.ListFindingsResult>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<ListFindingsResponse.Types.ListFindingsResult> GetEnumerator() => ListFindingsResults.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSourcesRequest : gaxgrpc::IPageRequest { }
    public partial class ListSourcesResponse : gaxgrpc::IPageResponse<Source>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Source> GetEnumerator() => Sources.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class SecurityCenter
    {
        public partial class SecurityCenterClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
