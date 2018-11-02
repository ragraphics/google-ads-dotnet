// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/resources/change_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/resources/change_status.proto</summary>
  public static partial class ChangeStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/resources/change_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9yZXNvdXJjZXMvY2hhbmdlX3N0",
            "YXR1cy5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAucmVzb3VyY2Vz",
            "Gjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9jaGFuZ2Vfc3RhdHVz",
            "X29wZXJhdGlvbi5wcm90bxo/Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjAvZW51",
            "bXMvY2hhbmdlX3N0YXR1c19yZXNvdXJjZV90eXBlLnByb3RvGh5nb29nbGUv",
            "cHJvdG9idWYvd3JhcHBlcnMucHJvdG8ivwQKDENoYW5nZVN0YXR1cxIVCg1y",
            "ZXNvdXJjZV9uYW1lGAEgASgJEjsKFWxhc3RfY2hhbmdlX2RhdGVfdGltZRgD",
            "IAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZRJrCg1yZXNvdXJj",
            "ZV90eXBlGAQgASgOMlQuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZW51bXMu",
            "Q2hhbmdlU3RhdHVzUmVzb3VyY2VUeXBlRW51bS5DaGFuZ2VTdGF0dXNSZXNv",
            "dXJjZVR5cGUSLgoIY2FtcGFpZ24YBSABKAsyHC5nb29nbGUucHJvdG9idWYu",
            "U3RyaW5nVmFsdWUSLgoIYWRfZ3JvdXAYBiABKAsyHC5nb29nbGUucHJvdG9i",
            "dWYuU3RyaW5nVmFsdWUSZwoPcmVzb3VyY2Vfc3RhdHVzGAggASgOMk4uZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjAuZW51bXMuQ2hhbmdlU3RhdHVzT3BlcmF0",
            "aW9uRW51bS5DaGFuZ2VTdGF0dXNPcGVyYXRpb24SMQoLYWRfZ3JvdXBfYWQY",
            "CSABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWUSOAoSYWRfZ3Jv",
            "dXBfY3JpdGVyaW9uGAogASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1Zh",
            "bHVlEjgKEmNhbXBhaWduX2NyaXRlcmlvbhgLIAEoCzIcLmdvb2dsZS5wcm90",
            "b2J1Zi5TdHJpbmdWYWx1ZULWAQolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYwLnJlc291cmNlc0IRQ2hhbmdlU3RhdHVzUHJvdG9QAVpKZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Yw",
            "L3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdvb2ds",
            "ZUFkcy5WMC5SZXNvdXJjZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xWMFxS",
            "ZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Enums.ChangeStatusOperationReflection.Descriptor, global::Google.Ads.GoogleAds.V0.Enums.ChangeStatusResourceTypeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Resources.ChangeStatus), global::Google.Ads.GoogleAds.V0.Resources.ChangeStatus.Parser, new[]{ "ResourceName", "LastChangeDateTime", "ResourceType", "Campaign", "AdGroup", "ResourceStatus", "AdGroupAd", "AdGroupCriterion", "CampaignCriterion" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Describes the status of returned resource.
  /// </summary>
  public sealed partial class ChangeStatus : pb::IMessage<ChangeStatus> {
    private static readonly pb::MessageParser<ChangeStatus> _parser = new pb::MessageParser<ChangeStatus>(() => new ChangeStatus());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChangeStatus> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Resources.ChangeStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangeStatus() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangeStatus(ChangeStatus other) : this() {
      resourceName_ = other.resourceName_;
      LastChangeDateTime = other.LastChangeDateTime;
      resourceType_ = other.resourceType_;
      Campaign = other.Campaign;
      AdGroup = other.AdGroup;
      resourceStatus_ = other.resourceStatus_;
      AdGroupAd = other.AdGroupAd;
      AdGroupCriterion = other.AdGroupCriterion;
      CampaignCriterion = other.CampaignCriterion;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangeStatus Clone() {
      return new ChangeStatus(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the change status.
    /// Change status resource names have the form:
    ///
    /// `customers/{customer_id}/changeStatus/{change_status_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_change_date_time" field.</summary>
    public const int LastChangeDateTimeFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_lastChangeDateTime_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string lastChangeDateTime_;
    /// <summary>
    /// Time at which the most recent change has occurred on this resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LastChangeDateTime {
      get { return lastChangeDateTime_; }
      set {
        lastChangeDateTime_ = value;
      }
    }

    /// <summary>Field number for the "resource_type" field.</summary>
    public const int ResourceTypeFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V0.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType resourceType_ = 0;
    /// <summary>
    /// Represents the type of the changed resource. This dictates what fields
    /// will be set. For example, for AD_GROUP, campaign and ad_group fields will
    /// be set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType ResourceType {
      get { return resourceType_; }
      set {
        resourceType_ = value;
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _single_campaign_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    private string campaign_;
    /// <summary>
    /// The Campaign affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Campaign {
      get { return campaign_; }
      set {
        campaign_ = value;
      }
    }

    /// <summary>Field number for the "ad_group" field.</summary>
    public const int AdGroupFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _single_adGroup_codec = pb::FieldCodec.ForClassWrapper<string>(50);
    private string adGroup_;
    /// <summary>
    /// The AdGroup affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroup {
      get { return adGroup_; }
      set {
        adGroup_ = value;
      }
    }

    /// <summary>Field number for the "resource_status" field.</summary>
    public const int ResourceStatusFieldNumber = 8;
    private global::Google.Ads.GoogleAds.V0.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation resourceStatus_ = 0;
    /// <summary>
    /// Represents the status of the changed resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation ResourceStatus {
      get { return resourceStatus_; }
      set {
        resourceStatus_ = value;
      }
    }

    /// <summary>Field number for the "ad_group_ad" field.</summary>
    public const int AdGroupAdFieldNumber = 9;
    private static readonly pb::FieldCodec<string> _single_adGroupAd_codec = pb::FieldCodec.ForClassWrapper<string>(74);
    private string adGroupAd_;
    /// <summary>
    /// The AdGroupAd affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroupAd {
      get { return adGroupAd_; }
      set {
        adGroupAd_ = value;
      }
    }

    /// <summary>Field number for the "ad_group_criterion" field.</summary>
    public const int AdGroupCriterionFieldNumber = 10;
    private static readonly pb::FieldCodec<string> _single_adGroupCriterion_codec = pb::FieldCodec.ForClassWrapper<string>(82);
    private string adGroupCriterion_;
    /// <summary>
    /// The AdGroupCriterion affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroupCriterion {
      get { return adGroupCriterion_; }
      set {
        adGroupCriterion_ = value;
      }
    }

    /// <summary>Field number for the "campaign_criterion" field.</summary>
    public const int CampaignCriterionFieldNumber = 11;
    private static readonly pb::FieldCodec<string> _single_campaignCriterion_codec = pb::FieldCodec.ForClassWrapper<string>(90);
    private string campaignCriterion_;
    /// <summary>
    /// The CampaignCriterion affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CampaignCriterion {
      get { return campaignCriterion_; }
      set {
        campaignCriterion_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChangeStatus);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChangeStatus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (LastChangeDateTime != other.LastChangeDateTime) return false;
      if (ResourceType != other.ResourceType) return false;
      if (Campaign != other.Campaign) return false;
      if (AdGroup != other.AdGroup) return false;
      if (ResourceStatus != other.ResourceStatus) return false;
      if (AdGroupAd != other.AdGroupAd) return false;
      if (AdGroupCriterion != other.AdGroupCriterion) return false;
      if (CampaignCriterion != other.CampaignCriterion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (lastChangeDateTime_ != null) hash ^= LastChangeDateTime.GetHashCode();
      if (ResourceType != 0) hash ^= ResourceType.GetHashCode();
      if (campaign_ != null) hash ^= Campaign.GetHashCode();
      if (adGroup_ != null) hash ^= AdGroup.GetHashCode();
      if (ResourceStatus != 0) hash ^= ResourceStatus.GetHashCode();
      if (adGroupAd_ != null) hash ^= AdGroupAd.GetHashCode();
      if (adGroupCriterion_ != null) hash ^= AdGroupCriterion.GetHashCode();
      if (campaignCriterion_ != null) hash ^= CampaignCriterion.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (lastChangeDateTime_ != null) {
        _single_lastChangeDateTime_codec.WriteTagAndValue(output, LastChangeDateTime);
      }
      if (ResourceType != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ResourceType);
      }
      if (campaign_ != null) {
        _single_campaign_codec.WriteTagAndValue(output, Campaign);
      }
      if (adGroup_ != null) {
        _single_adGroup_codec.WriteTagAndValue(output, AdGroup);
      }
      if (ResourceStatus != 0) {
        output.WriteRawTag(64);
        output.WriteEnum((int) ResourceStatus);
      }
      if (adGroupAd_ != null) {
        _single_adGroupAd_codec.WriteTagAndValue(output, AdGroupAd);
      }
      if (adGroupCriterion_ != null) {
        _single_adGroupCriterion_codec.WriteTagAndValue(output, AdGroupCriterion);
      }
      if (campaignCriterion_ != null) {
        _single_campaignCriterion_codec.WriteTagAndValue(output, CampaignCriterion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (lastChangeDateTime_ != null) {
        size += _single_lastChangeDateTime_codec.CalculateSizeWithTag(LastChangeDateTime);
      }
      if (ResourceType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ResourceType);
      }
      if (campaign_ != null) {
        size += _single_campaign_codec.CalculateSizeWithTag(Campaign);
      }
      if (adGroup_ != null) {
        size += _single_adGroup_codec.CalculateSizeWithTag(AdGroup);
      }
      if (ResourceStatus != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ResourceStatus);
      }
      if (adGroupAd_ != null) {
        size += _single_adGroupAd_codec.CalculateSizeWithTag(AdGroupAd);
      }
      if (adGroupCriterion_ != null) {
        size += _single_adGroupCriterion_codec.CalculateSizeWithTag(AdGroupCriterion);
      }
      if (campaignCriterion_ != null) {
        size += _single_campaignCriterion_codec.CalculateSizeWithTag(CampaignCriterion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChangeStatus other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.lastChangeDateTime_ != null) {
        if (lastChangeDateTime_ == null || other.LastChangeDateTime != "") {
          LastChangeDateTime = other.LastChangeDateTime;
        }
      }
      if (other.ResourceType != 0) {
        ResourceType = other.ResourceType;
      }
      if (other.campaign_ != null) {
        if (campaign_ == null || other.Campaign != "") {
          Campaign = other.Campaign;
        }
      }
      if (other.adGroup_ != null) {
        if (adGroup_ == null || other.AdGroup != "") {
          AdGroup = other.AdGroup;
        }
      }
      if (other.ResourceStatus != 0) {
        ResourceStatus = other.ResourceStatus;
      }
      if (other.adGroupAd_ != null) {
        if (adGroupAd_ == null || other.AdGroupAd != "") {
          AdGroupAd = other.AdGroupAd;
        }
      }
      if (other.adGroupCriterion_ != null) {
        if (adGroupCriterion_ == null || other.AdGroupCriterion != "") {
          AdGroupCriterion = other.AdGroupCriterion;
        }
      }
      if (other.campaignCriterion_ != null) {
        if (campaignCriterion_ == null || other.CampaignCriterion != "") {
          CampaignCriterion = other.CampaignCriterion;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 26: {
            string value = _single_lastChangeDateTime_codec.Read(input);
            if (lastChangeDateTime_ == null || value != "") {
              LastChangeDateTime = value;
            }
            break;
          }
          case 32: {
            resourceType_ = (global::Google.Ads.GoogleAds.V0.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType) input.ReadEnum();
            break;
          }
          case 42: {
            string value = _single_campaign_codec.Read(input);
            if (campaign_ == null || value != "") {
              Campaign = value;
            }
            break;
          }
          case 50: {
            string value = _single_adGroup_codec.Read(input);
            if (adGroup_ == null || value != "") {
              AdGroup = value;
            }
            break;
          }
          case 64: {
            resourceStatus_ = (global::Google.Ads.GoogleAds.V0.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation) input.ReadEnum();
            break;
          }
          case 74: {
            string value = _single_adGroupAd_codec.Read(input);
            if (adGroupAd_ == null || value != "") {
              AdGroupAd = value;
            }
            break;
          }
          case 82: {
            string value = _single_adGroupCriterion_codec.Read(input);
            if (adGroupCriterion_ == null || value != "") {
              AdGroupCriterion = value;
            }
            break;
          }
          case 90: {
            string value = _single_campaignCriterion_codec.Read(input);
            if (campaignCriterion_ == null || value != "") {
              CampaignCriterion = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
