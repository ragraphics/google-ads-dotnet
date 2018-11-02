// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/resources/customer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/resources/customer.proto</summary>
  public static partial class CustomerReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/resources/customer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9yZXNvdXJjZXMvY3VzdG9tZXIu",
            "cHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLnJlc291cmNlcxoeZ29v",
            "Z2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvIvADCghDdXN0b21lchIVCg1y",
            "ZXNvdXJjZV9uYW1lGAEgASgJEicKAmlkGAMgASgLMhsuZ29vZ2xlLnByb3Rv",
            "YnVmLkludDY0VmFsdWUSNgoQZGVzY3JpcHRpdmVfbmFtZRgEIAEoCzIcLmdv",
            "b2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZRIzCg1jdXJyZW5jeV9jb2RlGAUg",
            "ASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlEi8KCXRpbWVfem9u",
            "ZRgGIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZRI7ChV0cmFj",
            "a2luZ191cmxfdGVtcGxhdGUYByABKAsyHC5nb29nbGUucHJvdG9idWYuU3Ry",
            "aW5nVmFsdWUSOAoUYXV0b190YWdnaW5nX2VuYWJsZWQYCCABKAsyGi5nb29n",
            "bGUucHJvdG9idWYuQm9vbFZhbHVlEjYKEmhhc19wYXJ0bmVyc19iYWRnZRgJ",
            "IAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5Cb29sVmFsdWUSVwoWY2FsbF9yZXBv",
            "cnRpbmdfc2V0dGluZxgKIAEoCzI3Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYw",
            "LnJlc291cmNlcy5DYWxsUmVwb3J0aW5nU2V0dGluZyLXAQoUQ2FsbFJlcG9y",
            "dGluZ1NldHRpbmcSOgoWY2FsbF9yZXBvcnRpbmdfZW5hYmxlZBgBIAEoCzIa",
            "Lmdvb2dsZS5wcm90b2J1Zi5Cb29sVmFsdWUSRQohY2FsbF9jb252ZXJzaW9u",
            "X3JlcG9ydGluZ19lbmFibGVkGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLkJv",
            "b2xWYWx1ZRI8ChZjYWxsX2NvbnZlcnNpb25fYWN0aW9uGAkgASgLMhwuZ29v",
            "Z2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQtIBCiVjb20uZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjAucmVzb3VyY2VzQg1DdXN0b21lclByb3RvUAFaSmdvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFk",
            "cy92MC9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5H",
            "b29nbGVBZHMuVjAuUmVzb3VyY2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjBcUmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Resources.Customer), global::Google.Ads.GoogleAds.V0.Resources.Customer.Parser, new[]{ "ResourceName", "Id", "DescriptiveName", "CurrencyCode", "TimeZone", "TrackingUrlTemplate", "AutoTaggingEnabled", "HasPartnersBadge", "CallReportingSetting" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Resources.CallReportingSetting), global::Google.Ads.GoogleAds.V0.Resources.CallReportingSetting.Parser, new[]{ "CallReportingEnabled", "CallConversionReportingEnabled", "CallConversionAction" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A customer.
  /// </summary>
  public sealed partial class Customer : pb::IMessage<Customer> {
    private static readonly pb::MessageParser<Customer> _parser = new pb::MessageParser<Customer>(() => new Customer());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Customer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Resources.CustomerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Customer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Customer(Customer other) : this() {
      resourceName_ = other.resourceName_;
      Id = other.Id;
      DescriptiveName = other.DescriptiveName;
      CurrencyCode = other.CurrencyCode;
      TimeZone = other.TimeZone;
      TrackingUrlTemplate = other.TrackingUrlTemplate;
      AutoTaggingEnabled = other.AutoTaggingEnabled;
      HasPartnersBadge = other.HasPartnersBadge;
      callReportingSetting_ = other.callReportingSetting_ != null ? other.callReportingSetting_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Customer Clone() {
      return new Customer(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the customer.
    /// Customer resource names have the form:
    ///
    /// `customers/{customer_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 3;
    private static readonly pb::FieldCodec<long?> _single_id_codec = pb::FieldCodec.ForStructWrapper<long>(26);
    private long? id_;
    /// <summary>
    /// The ID of the customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "descriptive_name" field.</summary>
    public const int DescriptiveNameFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_descriptiveName_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string descriptiveName_;
    /// <summary>
    /// Optional, non-unique descriptive name of the customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DescriptiveName {
      get { return descriptiveName_; }
      set {
        descriptiveName_ = value;
      }
    }

    /// <summary>Field number for the "currency_code" field.</summary>
    public const int CurrencyCodeFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _single_currencyCode_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    private string currencyCode_;
    /// <summary>
    /// The currency in which the account operates.
    /// A subset of the currency codes from the ISO 4217 standard is
    /// supported.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CurrencyCode {
      get { return currencyCode_; }
      set {
        currencyCode_ = value;
      }
    }

    /// <summary>Field number for the "time_zone" field.</summary>
    public const int TimeZoneFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _single_timeZone_codec = pb::FieldCodec.ForClassWrapper<string>(50);
    private string timeZone_;
    /// <summary>
    /// The local timezone ID of the customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TimeZone {
      get { return timeZone_; }
      set {
        timeZone_ = value;
      }
    }

    /// <summary>Field number for the "tracking_url_template" field.</summary>
    public const int TrackingUrlTemplateFieldNumber = 7;
    private static readonly pb::FieldCodec<string> _single_trackingUrlTemplate_codec = pb::FieldCodec.ForClassWrapper<string>(58);
    private string trackingUrlTemplate_;
    /// <summary>
    /// The URL template for constructing a tracking URL out of parameters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TrackingUrlTemplate {
      get { return trackingUrlTemplate_; }
      set {
        trackingUrlTemplate_ = value;
      }
    }

    /// <summary>Field number for the "auto_tagging_enabled" field.</summary>
    public const int AutoTaggingEnabledFieldNumber = 8;
    private static readonly pb::FieldCodec<bool?> _single_autoTaggingEnabled_codec = pb::FieldCodec.ForStructWrapper<bool>(66);
    private bool? autoTaggingEnabled_;
    /// <summary>
    /// Whether auto-tagging is enabled for the customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? AutoTaggingEnabled {
      get { return autoTaggingEnabled_; }
      set {
        autoTaggingEnabled_ = value;
      }
    }

    /// <summary>Field number for the "has_partners_badge" field.</summary>
    public const int HasPartnersBadgeFieldNumber = 9;
    private static readonly pb::FieldCodec<bool?> _single_hasPartnersBadge_codec = pb::FieldCodec.ForStructWrapper<bool>(74);
    private bool? hasPartnersBadge_;
    /// <summary>
    /// Whether the Customer has a Partners program badge. If the Customer is not
    /// associated with the Partners program, this will be false. For more
    /// information, see https://support.google.com/partners/answer/3125774.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? HasPartnersBadge {
      get { return hasPartnersBadge_; }
      set {
        hasPartnersBadge_ = value;
      }
    }

    /// <summary>Field number for the "call_reporting_setting" field.</summary>
    public const int CallReportingSettingFieldNumber = 10;
    private global::Google.Ads.GoogleAds.V0.Resources.CallReportingSetting callReportingSetting_;
    /// <summary>
    /// Call reporting setting for a customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Resources.CallReportingSetting CallReportingSetting {
      get { return callReportingSetting_; }
      set {
        callReportingSetting_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Customer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Customer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (DescriptiveName != other.DescriptiveName) return false;
      if (CurrencyCode != other.CurrencyCode) return false;
      if (TimeZone != other.TimeZone) return false;
      if (TrackingUrlTemplate != other.TrackingUrlTemplate) return false;
      if (AutoTaggingEnabled != other.AutoTaggingEnabled) return false;
      if (HasPartnersBadge != other.HasPartnersBadge) return false;
      if (!object.Equals(CallReportingSetting, other.CallReportingSetting)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (descriptiveName_ != null) hash ^= DescriptiveName.GetHashCode();
      if (currencyCode_ != null) hash ^= CurrencyCode.GetHashCode();
      if (timeZone_ != null) hash ^= TimeZone.GetHashCode();
      if (trackingUrlTemplate_ != null) hash ^= TrackingUrlTemplate.GetHashCode();
      if (autoTaggingEnabled_ != null) hash ^= AutoTaggingEnabled.GetHashCode();
      if (hasPartnersBadge_ != null) hash ^= HasPartnersBadge.GetHashCode();
      if (callReportingSetting_ != null) hash ^= CallReportingSetting.GetHashCode();
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
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (descriptiveName_ != null) {
        _single_descriptiveName_codec.WriteTagAndValue(output, DescriptiveName);
      }
      if (currencyCode_ != null) {
        _single_currencyCode_codec.WriteTagAndValue(output, CurrencyCode);
      }
      if (timeZone_ != null) {
        _single_timeZone_codec.WriteTagAndValue(output, TimeZone);
      }
      if (trackingUrlTemplate_ != null) {
        _single_trackingUrlTemplate_codec.WriteTagAndValue(output, TrackingUrlTemplate);
      }
      if (autoTaggingEnabled_ != null) {
        _single_autoTaggingEnabled_codec.WriteTagAndValue(output, AutoTaggingEnabled);
      }
      if (hasPartnersBadge_ != null) {
        _single_hasPartnersBadge_codec.WriteTagAndValue(output, HasPartnersBadge);
      }
      if (callReportingSetting_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CallReportingSetting);
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
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (descriptiveName_ != null) {
        size += _single_descriptiveName_codec.CalculateSizeWithTag(DescriptiveName);
      }
      if (currencyCode_ != null) {
        size += _single_currencyCode_codec.CalculateSizeWithTag(CurrencyCode);
      }
      if (timeZone_ != null) {
        size += _single_timeZone_codec.CalculateSizeWithTag(TimeZone);
      }
      if (trackingUrlTemplate_ != null) {
        size += _single_trackingUrlTemplate_codec.CalculateSizeWithTag(TrackingUrlTemplate);
      }
      if (autoTaggingEnabled_ != null) {
        size += _single_autoTaggingEnabled_codec.CalculateSizeWithTag(AutoTaggingEnabled);
      }
      if (hasPartnersBadge_ != null) {
        size += _single_hasPartnersBadge_codec.CalculateSizeWithTag(HasPartnersBadge);
      }
      if (callReportingSetting_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CallReportingSetting);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Customer other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != 0L) {
          Id = other.Id;
        }
      }
      if (other.descriptiveName_ != null) {
        if (descriptiveName_ == null || other.DescriptiveName != "") {
          DescriptiveName = other.DescriptiveName;
        }
      }
      if (other.currencyCode_ != null) {
        if (currencyCode_ == null || other.CurrencyCode != "") {
          CurrencyCode = other.CurrencyCode;
        }
      }
      if (other.timeZone_ != null) {
        if (timeZone_ == null || other.TimeZone != "") {
          TimeZone = other.TimeZone;
        }
      }
      if (other.trackingUrlTemplate_ != null) {
        if (trackingUrlTemplate_ == null || other.TrackingUrlTemplate != "") {
          TrackingUrlTemplate = other.TrackingUrlTemplate;
        }
      }
      if (other.autoTaggingEnabled_ != null) {
        if (autoTaggingEnabled_ == null || other.AutoTaggingEnabled != false) {
          AutoTaggingEnabled = other.AutoTaggingEnabled;
        }
      }
      if (other.hasPartnersBadge_ != null) {
        if (hasPartnersBadge_ == null || other.HasPartnersBadge != false) {
          HasPartnersBadge = other.HasPartnersBadge;
        }
      }
      if (other.callReportingSetting_ != null) {
        if (callReportingSetting_ == null) {
          callReportingSetting_ = new global::Google.Ads.GoogleAds.V0.Resources.CallReportingSetting();
        }
        CallReportingSetting.MergeFrom(other.CallReportingSetting);
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
            long? value = _single_id_codec.Read(input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
          case 34: {
            string value = _single_descriptiveName_codec.Read(input);
            if (descriptiveName_ == null || value != "") {
              DescriptiveName = value;
            }
            break;
          }
          case 42: {
            string value = _single_currencyCode_codec.Read(input);
            if (currencyCode_ == null || value != "") {
              CurrencyCode = value;
            }
            break;
          }
          case 50: {
            string value = _single_timeZone_codec.Read(input);
            if (timeZone_ == null || value != "") {
              TimeZone = value;
            }
            break;
          }
          case 58: {
            string value = _single_trackingUrlTemplate_codec.Read(input);
            if (trackingUrlTemplate_ == null || value != "") {
              TrackingUrlTemplate = value;
            }
            break;
          }
          case 66: {
            bool? value = _single_autoTaggingEnabled_codec.Read(input);
            if (autoTaggingEnabled_ == null || value != false) {
              AutoTaggingEnabled = value;
            }
            break;
          }
          case 74: {
            bool? value = _single_hasPartnersBadge_codec.Read(input);
            if (hasPartnersBadge_ == null || value != false) {
              HasPartnersBadge = value;
            }
            break;
          }
          case 82: {
            if (callReportingSetting_ == null) {
              callReportingSetting_ = new global::Google.Ads.GoogleAds.V0.Resources.CallReportingSetting();
            }
            input.ReadMessage(callReportingSetting_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Call reporting setting for a customer.
  /// </summary>
  public sealed partial class CallReportingSetting : pb::IMessage<CallReportingSetting> {
    private static readonly pb::MessageParser<CallReportingSetting> _parser = new pb::MessageParser<CallReportingSetting>(() => new CallReportingSetting());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CallReportingSetting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Resources.CustomerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallReportingSetting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallReportingSetting(CallReportingSetting other) : this() {
      CallReportingEnabled = other.CallReportingEnabled;
      CallConversionReportingEnabled = other.CallConversionReportingEnabled;
      CallConversionAction = other.CallConversionAction;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CallReportingSetting Clone() {
      return new CallReportingSetting(this);
    }

    /// <summary>Field number for the "call_reporting_enabled" field.</summary>
    public const int CallReportingEnabledFieldNumber = 1;
    private static readonly pb::FieldCodec<bool?> _single_callReportingEnabled_codec = pb::FieldCodec.ForStructWrapper<bool>(10);
    private bool? callReportingEnabled_;
    /// <summary>
    /// Enable reporting of phone call events by redirecting them via Google
    /// System.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? CallReportingEnabled {
      get { return callReportingEnabled_; }
      set {
        callReportingEnabled_ = value;
      }
    }

    /// <summary>Field number for the "call_conversion_reporting_enabled" field.</summary>
    public const int CallConversionReportingEnabledFieldNumber = 2;
    private static readonly pb::FieldCodec<bool?> _single_callConversionReportingEnabled_codec = pb::FieldCodec.ForStructWrapper<bool>(18);
    private bool? callConversionReportingEnabled_;
    /// <summary>
    /// Whether to enable call conversion reporting.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? CallConversionReportingEnabled {
      get { return callConversionReportingEnabled_; }
      set {
        callConversionReportingEnabled_ = value;
      }
    }

    /// <summary>Field number for the "call_conversion_action" field.</summary>
    public const int CallConversionActionFieldNumber = 9;
    private static readonly pb::FieldCodec<string> _single_callConversionAction_codec = pb::FieldCodec.ForClassWrapper<string>(74);
    private string callConversionAction_;
    /// <summary>
    /// Customer-level call conversion action to attribute a call conversion to.
    /// If not set a default conversion action is used. Only in effect when
    /// call_conversion_reporting_enabled is set to true.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CallConversionAction {
      get { return callConversionAction_; }
      set {
        callConversionAction_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CallReportingSetting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CallReportingSetting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CallReportingEnabled != other.CallReportingEnabled) return false;
      if (CallConversionReportingEnabled != other.CallConversionReportingEnabled) return false;
      if (CallConversionAction != other.CallConversionAction) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (callReportingEnabled_ != null) hash ^= CallReportingEnabled.GetHashCode();
      if (callConversionReportingEnabled_ != null) hash ^= CallConversionReportingEnabled.GetHashCode();
      if (callConversionAction_ != null) hash ^= CallConversionAction.GetHashCode();
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
      if (callReportingEnabled_ != null) {
        _single_callReportingEnabled_codec.WriteTagAndValue(output, CallReportingEnabled);
      }
      if (callConversionReportingEnabled_ != null) {
        _single_callConversionReportingEnabled_codec.WriteTagAndValue(output, CallConversionReportingEnabled);
      }
      if (callConversionAction_ != null) {
        _single_callConversionAction_codec.WriteTagAndValue(output, CallConversionAction);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (callReportingEnabled_ != null) {
        size += _single_callReportingEnabled_codec.CalculateSizeWithTag(CallReportingEnabled);
      }
      if (callConversionReportingEnabled_ != null) {
        size += _single_callConversionReportingEnabled_codec.CalculateSizeWithTag(CallConversionReportingEnabled);
      }
      if (callConversionAction_ != null) {
        size += _single_callConversionAction_codec.CalculateSizeWithTag(CallConversionAction);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CallReportingSetting other) {
      if (other == null) {
        return;
      }
      if (other.callReportingEnabled_ != null) {
        if (callReportingEnabled_ == null || other.CallReportingEnabled != false) {
          CallReportingEnabled = other.CallReportingEnabled;
        }
      }
      if (other.callConversionReportingEnabled_ != null) {
        if (callConversionReportingEnabled_ == null || other.CallConversionReportingEnabled != false) {
          CallConversionReportingEnabled = other.CallConversionReportingEnabled;
        }
      }
      if (other.callConversionAction_ != null) {
        if (callConversionAction_ == null || other.CallConversionAction != "") {
          CallConversionAction = other.CallConversionAction;
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
            bool? value = _single_callReportingEnabled_codec.Read(input);
            if (callReportingEnabled_ == null || value != false) {
              CallReportingEnabled = value;
            }
            break;
          }
          case 18: {
            bool? value = _single_callConversionReportingEnabled_codec.Read(input);
            if (callConversionReportingEnabled_ == null || value != false) {
              CallConversionReportingEnabled = value;
            }
            break;
          }
          case 74: {
            string value = _single_callConversionAction_codec.Read(input);
            if (callConversionAction_ == null || value != "") {
              CallConversionAction = value;
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
