// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/common/criterion_category_availability.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/common/criterion_category_availability.proto</summary>
  public static partial class CriterionCategoryAvailabilityReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/common/criterion_category_availability.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CriterionCategoryAvailabilityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9jb21tb24vY3JpdGVyaW9uX2Nh",
            "dGVnb3J5X2F2YWlsYWJpbGl0eS5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjAuY29tbW9uGkBnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9h",
            "ZHZlcnRpc2luZ19jaGFubmVsX3N1Yl90eXBlLnByb3RvGjxnb29nbGUvYWRz",
            "L2dvb2dsZWFkcy92MC9lbnVtcy9hZHZlcnRpc2luZ19jaGFubmVsX3R5cGUu",
            "cHJvdG8aUGdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YwL2VudW1zL2NyaXRlcmlv",
            "bl9jYXRlZ29yeV9jaGFubmVsX2F2YWlsYWJpbGl0eV9tb2RlLnByb3RvGk9n",
            "b29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9jcml0ZXJpb25fY2F0ZWdv",
            "cnlfbG9jYWxlX2F2YWlsYWJpbGl0eV9tb2RlLnByb3RvGh5nb29nbGUvcHJv",
            "dG9idWYvd3JhcHBlcnMucHJvdG8iywEKHUNyaXRlcmlvbkNhdGVnb3J5QXZh",
            "aWxhYmlsaXR5ElUKB2NoYW5uZWwYASABKAsyRC5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MC5jb21tb24uQ3JpdGVyaW9uQ2F0ZWdvcnlDaGFubmVsQXZhaWxh",
            "YmlsaXR5ElMKBmxvY2FsZRgCIAMoCzJDLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYwLmNvbW1vbi5Dcml0ZXJpb25DYXRlZ29yeUxvY2FsZUF2YWlsYWJpbGl0",
            "eSLwAwokQ3JpdGVyaW9uQ2F0ZWdvcnlDaGFubmVsQXZhaWxhYmlsaXR5Eo8B",
            "ChFhdmFpbGFiaWxpdHlfbW9kZRgBIAEoDjJ0Lmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYwLmVudW1zLkNyaXRlcmlvbkNhdGVnb3J5Q2hhbm5lbEF2YWlsYWJp",
            "bGl0eU1vZGVFbnVtLkNyaXRlcmlvbkNhdGVnb3J5Q2hhbm5lbEF2YWlsYWJp",
            "bGl0eU1vZGUScgoYYWR2ZXJ0aXNpbmdfY2hhbm5lbF90eXBlGAIgASgOMlAu",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZW51bXMuQWR2ZXJ0aXNpbmdDaGFu",
            "bmVsVHlwZUVudW0uQWR2ZXJ0aXNpbmdDaGFubmVsVHlwZRJ8ChxhZHZlcnRp",
            "c2luZ19jaGFubmVsX3N1Yl90eXBlGAMgAygOMlYuZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjAuZW51bXMuQWR2ZXJ0aXNpbmdDaGFubmVsU3ViVHlwZUVudW0u",
            "QWR2ZXJ0aXNpbmdDaGFubmVsU3ViVHlwZRJECiBpbmNsdWRlX2RlZmF1bHRf",
            "Y2hhbm5lbF9zdWJfdHlwZRgEIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5Cb29s",
            "VmFsdWUingIKI0NyaXRlcmlvbkNhdGVnb3J5TG9jYWxlQXZhaWxhYmlsaXR5",
            "Eo0BChFhdmFpbGFiaWxpdHlfbW9kZRgBIAEoDjJyLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYwLmVudW1zLkNyaXRlcmlvbkNhdGVnb3J5TG9jYWxlQXZhaWxh",
            "YmlsaXR5TW9kZUVudW0uQ3JpdGVyaW9uQ2F0ZWdvcnlMb2NhbGVBdmFpbGFi",
            "aWxpdHlNb2RlEjIKDGNvdW50cnlfY29kZRgCIAEoCzIcLmdvb2dsZS5wcm90",
            "b2J1Zi5TdHJpbmdWYWx1ZRIzCg1sYW5ndWFnZV9jb2RlGAMgASgLMhwuZ29v",
            "Z2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQtgBCiJjb20uZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjAuY29tbW9uQiJDcml0ZXJpb25DYXRlZ29yeUF2YWlsYWJp",
            "bGl0eVByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvYWRzL2dvb2dsZWFkcy92MC9jb21tb247Y29tbW9uogIDR0FBqgIe",
            "R29vZ2xlLkFkcy5Hb29nbGVBZHMuVjAuQ29tbW9uygIeR29vZ2xlXEFkc1xH",
            "b29nbGVBZHNcVjBcQ29tbW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelSubTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V0.Enums.CriterionCategoryChannelAvailabilityModeReflection.Descriptor, global::Google.Ads.GoogleAds.V0.Enums.CriterionCategoryLocaleAvailabilityModeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryAvailability), global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryAvailability.Parser, new[]{ "Channel", "Locale" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryChannelAvailability), global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryChannelAvailability.Parser, new[]{ "AvailabilityMode", "AdvertisingChannelType", "AdvertisingChannelSubType", "IncludeDefaultChannelSubType" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryLocaleAvailability), global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryLocaleAvailability.Parser, new[]{ "AvailabilityMode", "CountryCode", "LanguageCode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Information of category availability, per advertising channel.
  /// </summary>
  public sealed partial class CriterionCategoryAvailability : pb::IMessage<CriterionCategoryAvailability> {
    private static readonly pb::MessageParser<CriterionCategoryAvailability> _parser = new pb::MessageParser<CriterionCategoryAvailability>(() => new CriterionCategoryAvailability());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CriterionCategoryAvailability> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryAvailabilityReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionCategoryAvailability() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionCategoryAvailability(CriterionCategoryAvailability other) : this() {
      channel_ = other.channel_ != null ? other.channel_.Clone() : null;
      locale_ = other.locale_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionCategoryAvailability Clone() {
      return new CriterionCategoryAvailability(this);
    }

    /// <summary>Field number for the "channel" field.</summary>
    public const int ChannelFieldNumber = 1;
    private global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryChannelAvailability channel_;
    /// <summary>
    /// Channel types and subtypes that are available to the category.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryChannelAvailability Channel {
      get { return channel_; }
      set {
        channel_ = value;
      }
    }

    /// <summary>Field number for the "locale" field.</summary>
    public const int LocaleFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryLocaleAvailability> _repeated_locale_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryLocaleAvailability.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryLocaleAvailability> locale_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryLocaleAvailability>();
    /// <summary>
    /// Locales that are available to the category for the channel.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryLocaleAvailability> Locale {
      get { return locale_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CriterionCategoryAvailability);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CriterionCategoryAvailability other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Channel, other.Channel)) return false;
      if(!locale_.Equals(other.locale_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (channel_ != null) hash ^= Channel.GetHashCode();
      hash ^= locale_.GetHashCode();
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
      if (channel_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Channel);
      }
      locale_.WriteTo(output, _repeated_locale_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (channel_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Channel);
      }
      size += locale_.CalculateSize(_repeated_locale_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CriterionCategoryAvailability other) {
      if (other == null) {
        return;
      }
      if (other.channel_ != null) {
        if (channel_ == null) {
          channel_ = new global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryChannelAvailability();
        }
        Channel.MergeFrom(other.Channel);
      }
      locale_.Add(other.locale_);
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
            if (channel_ == null) {
              channel_ = new global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryChannelAvailability();
            }
            input.ReadMessage(channel_);
            break;
          }
          case 18: {
            locale_.AddEntriesFrom(input, _repeated_locale_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Information of advertising channel type and subtypes a category is available
  /// in.
  /// </summary>
  public sealed partial class CriterionCategoryChannelAvailability : pb::IMessage<CriterionCategoryChannelAvailability> {
    private static readonly pb::MessageParser<CriterionCategoryChannelAvailability> _parser = new pb::MessageParser<CriterionCategoryChannelAvailability>(() => new CriterionCategoryChannelAvailability());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CriterionCategoryChannelAvailability> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryAvailabilityReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionCategoryChannelAvailability() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionCategoryChannelAvailability(CriterionCategoryChannelAvailability other) : this() {
      availabilityMode_ = other.availabilityMode_;
      advertisingChannelType_ = other.advertisingChannelType_;
      advertisingChannelSubType_ = other.advertisingChannelSubType_.Clone();
      IncludeDefaultChannelSubType = other.IncludeDefaultChannelSubType;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionCategoryChannelAvailability Clone() {
      return new CriterionCategoryChannelAvailability(this);
    }

    /// <summary>Field number for the "availability_mode" field.</summary>
    public const int AvailabilityModeFieldNumber = 1;
    private global::Google.Ads.GoogleAds.V0.Enums.CriterionCategoryChannelAvailabilityModeEnum.Types.CriterionCategoryChannelAvailabilityMode availabilityMode_ = 0;
    /// <summary>
    /// Format of the channel availability. Can be ALL_CHANNELS (the rest of the
    /// fields will not be set), CHANNEL_TYPE (only advertising_channel_type type
    /// will be set, the category is available to all sub types under it) or
    /// CHANNEL_TYPE_AND_SUBTYPES (advertising_channel_type,
    /// advertising_channel_sub_type, and include_default_channel_sub_type will all
    /// be set).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Enums.CriterionCategoryChannelAvailabilityModeEnum.Types.CriterionCategoryChannelAvailabilityMode AvailabilityMode {
      get { return availabilityMode_; }
      set {
        availabilityMode_ = value;
      }
    }

    /// <summary>Field number for the "advertising_channel_type" field.</summary>
    public const int AdvertisingChannelTypeFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType advertisingChannelType_ = 0;
    /// <summary>
    /// Channel type the category is available to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType AdvertisingChannelType {
      get { return advertisingChannelType_; }
      set {
        advertisingChannelType_ = value;
      }
    }

    /// <summary>Field number for the "advertising_channel_sub_type" field.</summary>
    public const int AdvertisingChannelSubTypeFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType> _repeated_advertisingChannelSubType_codec
        = pb::FieldCodec.ForEnum(26, x => (int) x, x => (global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType) x);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType> advertisingChannelSubType_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType>();
    /// <summary>
    /// Channel subtypes under the channel type the category is available to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType> AdvertisingChannelSubType {
      get { return advertisingChannelSubType_; }
    }

    /// <summary>Field number for the "include_default_channel_sub_type" field.</summary>
    public const int IncludeDefaultChannelSubTypeFieldNumber = 4;
    private static readonly pb::FieldCodec<bool?> _single_includeDefaultChannelSubType_codec = pb::FieldCodec.ForStructWrapper<bool>(34);
    private bool? includeDefaultChannelSubType_;
    /// <summary>
    /// Whether default channel sub type is included. For example,
    /// advertising_channel_type being DISPLAY and include_default_channel_sub_type
    /// being false means that the default display campaign where channel sub type
    /// is not set is not included in this availability configuration.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? IncludeDefaultChannelSubType {
      get { return includeDefaultChannelSubType_; }
      set {
        includeDefaultChannelSubType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CriterionCategoryChannelAvailability);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CriterionCategoryChannelAvailability other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvailabilityMode != other.AvailabilityMode) return false;
      if (AdvertisingChannelType != other.AdvertisingChannelType) return false;
      if(!advertisingChannelSubType_.Equals(other.advertisingChannelSubType_)) return false;
      if (IncludeDefaultChannelSubType != other.IncludeDefaultChannelSubType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AvailabilityMode != 0) hash ^= AvailabilityMode.GetHashCode();
      if (AdvertisingChannelType != 0) hash ^= AdvertisingChannelType.GetHashCode();
      hash ^= advertisingChannelSubType_.GetHashCode();
      if (includeDefaultChannelSubType_ != null) hash ^= IncludeDefaultChannelSubType.GetHashCode();
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
      if (AvailabilityMode != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) AvailabilityMode);
      }
      if (AdvertisingChannelType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) AdvertisingChannelType);
      }
      advertisingChannelSubType_.WriteTo(output, _repeated_advertisingChannelSubType_codec);
      if (includeDefaultChannelSubType_ != null) {
        _single_includeDefaultChannelSubType_codec.WriteTagAndValue(output, IncludeDefaultChannelSubType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AvailabilityMode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AvailabilityMode);
      }
      if (AdvertisingChannelType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AdvertisingChannelType);
      }
      size += advertisingChannelSubType_.CalculateSize(_repeated_advertisingChannelSubType_codec);
      if (includeDefaultChannelSubType_ != null) {
        size += _single_includeDefaultChannelSubType_codec.CalculateSizeWithTag(IncludeDefaultChannelSubType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CriterionCategoryChannelAvailability other) {
      if (other == null) {
        return;
      }
      if (other.AvailabilityMode != 0) {
        AvailabilityMode = other.AvailabilityMode;
      }
      if (other.AdvertisingChannelType != 0) {
        AdvertisingChannelType = other.AdvertisingChannelType;
      }
      advertisingChannelSubType_.Add(other.advertisingChannelSubType_);
      if (other.includeDefaultChannelSubType_ != null) {
        if (includeDefaultChannelSubType_ == null || other.IncludeDefaultChannelSubType != false) {
          IncludeDefaultChannelSubType = other.IncludeDefaultChannelSubType;
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
          case 8: {
            availabilityMode_ = (global::Google.Ads.GoogleAds.V0.Enums.CriterionCategoryChannelAvailabilityModeEnum.Types.CriterionCategoryChannelAvailabilityMode) input.ReadEnum();
            break;
          }
          case 16: {
            advertisingChannelType_ = (global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType) input.ReadEnum();
            break;
          }
          case 26:
          case 24: {
            advertisingChannelSubType_.AddEntriesFrom(input, _repeated_advertisingChannelSubType_codec);
            break;
          }
          case 34: {
            bool? value = _single_includeDefaultChannelSubType_codec.Read(input);
            if (includeDefaultChannelSubType_ == null || value != false) {
              IncludeDefaultChannelSubType = value;
            }
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Information about which locales a category is available in.
  /// </summary>
  public sealed partial class CriterionCategoryLocaleAvailability : pb::IMessage<CriterionCategoryLocaleAvailability> {
    private static readonly pb::MessageParser<CriterionCategoryLocaleAvailability> _parser = new pb::MessageParser<CriterionCategoryLocaleAvailability>(() => new CriterionCategoryLocaleAvailability());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CriterionCategoryLocaleAvailability> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Common.CriterionCategoryAvailabilityReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionCategoryLocaleAvailability() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionCategoryLocaleAvailability(CriterionCategoryLocaleAvailability other) : this() {
      availabilityMode_ = other.availabilityMode_;
      CountryCode = other.CountryCode;
      LanguageCode = other.LanguageCode;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionCategoryLocaleAvailability Clone() {
      return new CriterionCategoryLocaleAvailability(this);
    }

    /// <summary>Field number for the "availability_mode" field.</summary>
    public const int AvailabilityModeFieldNumber = 1;
    private global::Google.Ads.GoogleAds.V0.Enums.CriterionCategoryLocaleAvailabilityModeEnum.Types.CriterionCategoryLocaleAvailabilityMode availabilityMode_ = 0;
    /// <summary>
    /// Format of the locale availability. Can be LAUNCHED_TO_ALL (both country and
    /// language will be empty), COUNTRY (only country will be set), LANGUAGE (only
    /// language wil be set), COUNTRY_AND_LANGUAGE (both country and language will
    /// be set).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Enums.CriterionCategoryLocaleAvailabilityModeEnum.Types.CriterionCategoryLocaleAvailabilityMode AvailabilityMode {
      get { return availabilityMode_; }
      set {
        availabilityMode_ = value;
      }
    }

    /// <summary>Field number for the "country_code" field.</summary>
    public const int CountryCodeFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_countryCode_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string countryCode_;
    /// <summary>
    /// Code of the country.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CountryCode {
      get { return countryCode_; }
      set {
        countryCode_ = value;
      }
    }

    /// <summary>Field number for the "language_code" field.</summary>
    public const int LanguageCodeFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_languageCode_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string languageCode_;
    /// <summary>
    /// Code of the language.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LanguageCode {
      get { return languageCode_; }
      set {
        languageCode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CriterionCategoryLocaleAvailability);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CriterionCategoryLocaleAvailability other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvailabilityMode != other.AvailabilityMode) return false;
      if (CountryCode != other.CountryCode) return false;
      if (LanguageCode != other.LanguageCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AvailabilityMode != 0) hash ^= AvailabilityMode.GetHashCode();
      if (countryCode_ != null) hash ^= CountryCode.GetHashCode();
      if (languageCode_ != null) hash ^= LanguageCode.GetHashCode();
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
      if (AvailabilityMode != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) AvailabilityMode);
      }
      if (countryCode_ != null) {
        _single_countryCode_codec.WriteTagAndValue(output, CountryCode);
      }
      if (languageCode_ != null) {
        _single_languageCode_codec.WriteTagAndValue(output, LanguageCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AvailabilityMode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AvailabilityMode);
      }
      if (countryCode_ != null) {
        size += _single_countryCode_codec.CalculateSizeWithTag(CountryCode);
      }
      if (languageCode_ != null) {
        size += _single_languageCode_codec.CalculateSizeWithTag(LanguageCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CriterionCategoryLocaleAvailability other) {
      if (other == null) {
        return;
      }
      if (other.AvailabilityMode != 0) {
        AvailabilityMode = other.AvailabilityMode;
      }
      if (other.countryCode_ != null) {
        if (countryCode_ == null || other.CountryCode != "") {
          CountryCode = other.CountryCode;
        }
      }
      if (other.languageCode_ != null) {
        if (languageCode_ == null || other.LanguageCode != "") {
          LanguageCode = other.LanguageCode;
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
          case 8: {
            availabilityMode_ = (global::Google.Ads.GoogleAds.V0.Enums.CriterionCategoryLocaleAvailabilityModeEnum.Types.CriterionCategoryLocaleAvailabilityMode) input.ReadEnum();
            break;
          }
          case 18: {
            string value = _single_countryCode_codec.Read(input);
            if (countryCode_ == null || value != "") {
              CountryCode = value;
            }
            break;
          }
          case 26: {
            string value = _single_languageCode_codec.Read(input);
            if (languageCode_ == null || value != "") {
              LanguageCode = value;
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
