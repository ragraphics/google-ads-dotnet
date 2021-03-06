// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/services/hotel_performance_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/services/hotel_performance_view_service.proto</summary>
  public static partial class HotelPerformanceViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/services/hotel_performance_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HotelPerformanceViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9zZXJ2aWNlcy9ob3RlbF9wZXJm",
            "b3JtYW5jZV92aWV3X3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYwLnNlcnZpY2VzGj5nb29nbGUvYWRzL2dvb2dsZWFkcy92MC9yZXNv",
            "dXJjZXMvaG90ZWxfcGVyZm9ybWFuY2Vfdmlldy5wcm90bxocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90byI3Ch5HZXRIb3RlbFBlcmZvcm1hbmNlVmll",
            "d1JlcXVlc3QSFQoNcmVzb3VyY2VfbmFtZRgBIAEoCTLyAQobSG90ZWxQZXJm",
            "b3JtYW5jZVZpZXdTZXJ2aWNlEtIBChdHZXRIb3RlbFBlcmZvcm1hbmNlVmll",
            "dxJALmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLnNlcnZpY2VzLkdldEhvdGVs",
            "UGVyZm9ybWFuY2VWaWV3UmVxdWVzdBo3Lmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYwLnJlc291cmNlcy5Ib3RlbFBlcmZvcm1hbmNlVmlldyI8gtPkkwI2EjQv",
            "djAve3Jlc291cmNlX25hbWU9Y3VzdG9tZXJzLyovaG90ZWxQZXJmb3JtYW5j",
            "ZVZpZXd9QuABCiRjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuc2Vydmlj",
            "ZXNCIEhvdGVsUGVyZm9ybWFuY2VWaWV3U2VydmljZVByb3RvUAFaSGdvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFk",
            "cy92MC9zZXJ2aWNlcztzZXJ2aWNlc6ICA0dBQaoCIEdvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlYwLlNlcnZpY2VzygIgR29vZ2xlXEFkc1xHb29nbGVBZHNcVjBc",
            "U2VydmljZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Resources.HotelPerformanceViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.GetHotelPerformanceViewRequest), global::Google.Ads.GoogleAds.V0.Services.GetHotelPerformanceViewRequest.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [HotelPerformanceViewService.GetHotelPerformanceView][google.ads.googleads.v0.services.HotelPerformanceViewService.GetHotelPerformanceView].
  /// </summary>
  public sealed partial class GetHotelPerformanceViewRequest : pb::IMessage<GetHotelPerformanceViewRequest> {
    private static readonly pb::MessageParser<GetHotelPerformanceViewRequest> _parser = new pb::MessageParser<GetHotelPerformanceViewRequest>(() => new GetHotelPerformanceViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetHotelPerformanceViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.HotelPerformanceViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHotelPerformanceViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHotelPerformanceViewRequest(GetHotelPerformanceViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHotelPerformanceViewRequest Clone() {
      return new GetHotelPerformanceViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Resource name of the Hotel Performance View to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetHotelPerformanceViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetHotelPerformanceViewRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetHotelPerformanceViewRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
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
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
