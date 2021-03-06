// Copyright 2018, Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V0.Services;

namespace Google.Ads.GoogleAds
{
    /// <summary>
    ///  Class to act as a pseudo namespace provider for service creation.
    /// </summary>
    public partial class Services
    {
        /// <summary>
        /// Pseudo enum to list the services supported in V0.
        /// </summary>
        public class V0
        {
            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.AdGroupAdService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAdServiceClient, AdGroupAdServiceSettings>
                AdGroupAdService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.AccountBudgetProposalService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<AccountBudgetProposalServiceClient, AccountBudgetProposalServiceSettings>
                AccountBudgetProposalService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.AdGroupBidModifierService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<AdGroupBidModifierServiceClient,
                AdGroupBidModifierServiceSettings> AdGroupBidModifierService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.AdGroupCriterionService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCriterionServiceClient,
                AdGroupCriterionServiceSettings> AdGroupCriterionService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.AdGroupService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<AdGroupServiceClient,
                AdGroupServiceSettings> AdGroupService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.BiddingStrategyService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<BiddingStrategyServiceClient,
                BiddingStrategyServiceSettings> BiddingStrategyService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.BillingSetupService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<BillingSetupServiceClient,
                BillingSetupServiceSettings> BillingSetupService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.BudgetService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<CampaignBudgetServiceClient,
                CampaignBudgetServiceSettings> CampaignBudgetService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CampaignCriterionService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<CampaignCriterionServiceClient,
                CampaignCriterionServiceSettings> CampaignCriterionService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CampaignService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<CampaignServiceClient,
                CampaignServiceSettings> CampaignService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CampaignBidModifierService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<CampaignBidModifierServiceClient,
                CampaignBidModifierServiceSettings> CampaignBidModifierService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CampaignGroupService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<CampaignGroupServiceClient,
                CampaignGroupServiceSettings> CampaignGroupService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CampaignSharedSetService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<CampaignSharedSetServiceClient,
                CampaignSharedSetServiceSettings> CampaignSharedSetService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.ChangeStatusService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<ChangeStatusServiceClient,
                ChangeStatusServiceSettings> ChangeStatusService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.ConversionActionService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<ConversionActionServiceClient,
                ConversionActionServiceSettings> ConversionActionService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CustomerService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<CustomerServiceClient,
                CustomerServiceSettings> CustomerService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.GeoTargetConstantService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<GeoTargetConstantServiceClient,
                GeoTargetConstantServiceSettings> GeoTargetConstantService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.GoogleAdsService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<GoogleAdsServiceClient,
                GoogleAdsServiceSettings> GoogleAdsService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.GoogleAdsFieldService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<GoogleAdsFieldServiceClient,
                GoogleAdsFieldServiceSettings> GoogleAdsFieldService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.KeywordViewService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<KeywordViewServiceClient,
                KeywordViewServiceSettings> KeywordViewService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.RecommendationService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<RecommendationServiceClient,
                RecommendationServiceSettings> RecommendationService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.SharedCriterionService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<SharedCriterionServiceClient,
                SharedCriterionServiceSettings> SharedCriterionService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.SharedSetService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<SharedSetServiceClient,
                SharedSetServiceSettings> SharedSetService;

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.VideoService
            /// for details;
            /// </summary>
            public static readonly ServiceTemplate<VideoServiceClient,
                VideoServiceSettings> VideoService;
        }
    }
}
