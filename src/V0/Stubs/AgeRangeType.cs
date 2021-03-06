// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/age_range_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/age_range_type.proto</summary>
  public static partial class AgeRangeTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/age_range_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AgeRangeTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9hZ2VfcmFuZ2VfdHlw",
            "ZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZW51bXMi6QEKEEFn",
            "ZVJhbmdlVHlwZUVudW0i1AEKDEFnZVJhbmdlVHlwZRIPCgtVTlNQRUNJRklF",
            "RBAAEgsKB1VOS05PV04QARIVCg9BR0VfUkFOR0VfMThfMjQQ2dkeEhUKD0FH",
            "RV9SQU5HRV8yNV8zNBDa2R4SFQoPQUdFX1JBTkdFXzM1XzQ0ENvZHhIVCg9B",
            "R0VfUkFOR0VfNDVfNTQQ3NkeEhUKD0FHRV9SQU5HRV81NV82NBDd2R4SFQoP",
            "QUdFX1JBTkdFXzY1X1VQEN7ZHhIcChZBR0VfUkFOR0VfVU5ERVRFUk1JTkVE",
            "EL/hHkLCAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVudW1zQhFB",
            "Z2VSYW5nZVR5cGVQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjAvZW51bXM7ZW51bXOiAgNH",
            "QUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMC5FbnVtc8oCHUdvb2dsZVxB",
            "ZHNcR29vZ2xlQWRzXFYwXEVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.AgeRangeTypeEnum), global::Google.Ads.GoogleAds.V0.Enums.AgeRangeTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.AgeRangeTypeEnum.Types.AgeRangeType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the type of demographic age ranges.
  /// </summary>
  public sealed partial class AgeRangeTypeEnum : pb::IMessage<AgeRangeTypeEnum> {
    private static readonly pb::MessageParser<AgeRangeTypeEnum> _parser = new pb::MessageParser<AgeRangeTypeEnum>(() => new AgeRangeTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AgeRangeTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.AgeRangeTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AgeRangeTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AgeRangeTypeEnum(AgeRangeTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AgeRangeTypeEnum Clone() {
      return new AgeRangeTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AgeRangeTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AgeRangeTypeEnum other) {
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
    public void MergeFrom(AgeRangeTypeEnum other) {
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
    /// <summary>Container for nested types declared in the AgeRangeTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The type of demographic age ranges (e.g. between 18 and 24 years old).
      /// </summary>
      public enum AgeRangeType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Between 18 and 24 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_18_24")] AgeRange1824 = 503001,
        /// <summary>
        /// Between 25 and 34 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_25_34")] AgeRange2534 = 503002,
        /// <summary>
        /// Between 35 and 44 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_35_44")] AgeRange3544 = 503003,
        /// <summary>
        /// Between 45 and 54 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_45_54")] AgeRange4554 = 503004,
        /// <summary>
        /// Between 55 and 64 years old.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_55_64")] AgeRange5564 = 503005,
        /// <summary>
        /// 65 years old and beyond.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_65_UP")] AgeRange65Up = 503006,
        /// <summary>
        /// Undetermined age range.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE_UNDETERMINED")] AgeRangeUndetermined = 503999,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
