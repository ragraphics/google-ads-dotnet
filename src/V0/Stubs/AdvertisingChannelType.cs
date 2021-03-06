// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/advertising_channel_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/advertising_channel_type.proto</summary>
  public static partial class AdvertisingChannelTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/advertising_channel_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdvertisingChannelTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9hZHZlcnRpc2luZ19j",
            "aGFubmVsX3R5cGUucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVu",
            "dW1zIpEBChpBZHZlcnRpc2luZ0NoYW5uZWxUeXBlRW51bSJzChZBZHZlcnRp",
            "c2luZ0NoYW5uZWxUeXBlEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThAB",
            "EgoKBlNFQVJDSBACEgsKB0RJU1BMQVkQAxIMCghTSE9QUElORxAEEgkKBUhP",
            "VEVMEAUSCQoFVklERU8QBkLMAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYwLmVudW1zQhtBZHZlcnRpc2luZ0NoYW5uZWxUeXBlUHJvdG9QAVpCZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xl",
            "YWRzL3YwL2VudW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVB",
            "ZHMuVjAuRW51bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMFxFbnVtc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelTypeEnum), global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The channel type a campaign may target to serve on.
  /// </summary>
  public sealed partial class AdvertisingChannelTypeEnum : pb::IMessage<AdvertisingChannelTypeEnum> {
    private static readonly pb::MessageParser<AdvertisingChannelTypeEnum> _parser = new pb::MessageParser<AdvertisingChannelTypeEnum>(() => new AdvertisingChannelTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdvertisingChannelTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdvertisingChannelTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdvertisingChannelTypeEnum(AdvertisingChannelTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdvertisingChannelTypeEnum Clone() {
      return new AdvertisingChannelTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdvertisingChannelTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdvertisingChannelTypeEnum other) {
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
    public void MergeFrom(AdvertisingChannelTypeEnum other) {
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
    /// <summary>Container for nested types declared in the AdvertisingChannelTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing the various advertising channel types.
      /// </summary>
      public enum AdvertisingChannelType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Search Network. Includes display bundled, and Search+ campaigns.
        /// </summary>
        [pbr::OriginalName("SEARCH")] Search = 2,
        /// <summary>
        /// Google Display Network only.
        /// </summary>
        [pbr::OriginalName("DISPLAY")] Display = 3,
        /// <summary>
        /// Shopping campaigns serve on the shopping property
        /// and on google.com search results.
        /// </summary>
        [pbr::OriginalName("SHOPPING")] Shopping = 4,
        /// <summary>
        /// Hotel Ads campaigns.
        /// </summary>
        [pbr::OriginalName("HOTEL")] Hotel = 5,
        /// <summary>
        /// Video campaigns.
        /// </summary>
        [pbr::OriginalName("VIDEO")] Video = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
