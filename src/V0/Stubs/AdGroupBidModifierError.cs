// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/ad_group_bid_modifier_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/ad_group_bid_modifier_error.proto</summary>
  public static partial class AdGroupBidModifierErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/ad_group_bid_modifier_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupBidModifierErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMvYWRfZ3JvdXBfYmlk",
            "X21vZGlmaWVyX2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MC5lcnJvcnMitgEKG0FkR3JvdXBCaWRNb2RpZmllckVycm9yRW51bSKWAQoX",
            "QWRHcm91cEJpZE1vZGlmaWVyRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdV",
            "TktOT1dOEAESHgoaQ1JJVEVSSU9OX0lEX05PVF9TVVBQT1JURUQQAhI9CjlD",
            "QU5OT1RfT1ZFUlJJREVfT1BURURfT1VUX0NBTVBBSUdOX0NSSVRFUklPTl9C",
            "SURfTU9ESUZJRVIQA0LSAQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYw",
            "LmVycm9yc0IcQWRHcm91cEJpZE1vZGlmaWVyRXJyb3JQcm90b1ABWkRnb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVh",
            "ZHMvdjAvZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xl",
            "QWRzLlYwLkVycm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYwXEVycm9y",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.AdGroupBidModifierErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.AdGroupBidModifierErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.AdGroupBidModifierErrorEnum.Types.AdGroupBidModifierError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible ad group bid modifier errors.
  /// </summary>
  public sealed partial class AdGroupBidModifierErrorEnum : pb::IMessage<AdGroupBidModifierErrorEnum> {
    private static readonly pb::MessageParser<AdGroupBidModifierErrorEnum> _parser = new pb::MessageParser<AdGroupBidModifierErrorEnum>(() => new AdGroupBidModifierErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupBidModifierErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Errors.AdGroupBidModifierErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupBidModifierErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupBidModifierErrorEnum(AdGroupBidModifierErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupBidModifierErrorEnum Clone() {
      return new AdGroupBidModifierErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupBidModifierErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupBidModifierErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdGroupBidModifierErrorEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the AdGroupBidModifierErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible ad group bid modifier errors.
      /// </summary>
      public enum AdGroupBidModifierError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The criterion ID does not support bid modification.
        /// </summary>
        [pbr::OriginalName("CRITERION_ID_NOT_SUPPORTED")] CriterionIdNotSupported = 2,
        /// <summary>
        /// Cannot override the bid modifier for the given criterion ID if the parent
        /// campaign is opted out of the same criterion.
        /// </summary>
        [pbr::OriginalName("CANNOT_OVERRIDE_OPTED_OUT_CAMPAIGN_CRITERION_BID_MODIFIER")] CannotOverrideOptedOutCampaignCriterionBidModifier = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
