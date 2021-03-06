// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/keyword_plan_competition_level.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/keyword_plan_competition_level.proto</summary>
  public static partial class KeywordPlanCompetitionLevelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/keyword_plan_competition_level.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordPlanCompetitionLevelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9rZXl3b3JkX3BsYW5f",
            "Y29tcGV0aXRpb25fbGV2ZWwucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYwLmVudW1zIn0KH0tleXdvcmRQbGFuQ29tcGV0aXRpb25MZXZlbEVudW0i",
            "WgobS2V5d29yZFBsYW5Db21wZXRpdGlvbkxldmVsEg8KC1VOU1BFQ0lGSUVE",
            "EAASCwoHVU5LTk9XThABEgcKA0xPVxACEgoKBk1FRElVTRADEggKBEhJR0gQ",
            "BELRAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVudW1zQiBLZXl3",
            "b3JkUGxhbkNvbXBldGl0aW9uTGV2ZWxQcm90b1ABWkJnb29nbGUuZ29sYW5n",
            "Lm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjAvZW51",
            "bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMC5FbnVt",
            "c8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYwXEVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.KeywordPlanCompetitionLevelEnum), global::Google.Ads.GoogleAds.V0.Enums.KeywordPlanCompetitionLevelEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enumeration of keyword competition levels. The competition
  /// level indicates how competitive ad placement is for a keyword and
  /// is determined by the number of advertisers bidding on that keyword relative
  /// to all keywords across Google. The competition level can depend on the
  /// location and Search Network targeting options you've selected.
  /// </summary>
  public sealed partial class KeywordPlanCompetitionLevelEnum : pb::IMessage<KeywordPlanCompetitionLevelEnum> {
    private static readonly pb::MessageParser<KeywordPlanCompetitionLevelEnum> _parser = new pb::MessageParser<KeywordPlanCompetitionLevelEnum>(() => new KeywordPlanCompetitionLevelEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeywordPlanCompetitionLevelEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.KeywordPlanCompetitionLevelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanCompetitionLevelEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanCompetitionLevelEnum(KeywordPlanCompetitionLevelEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanCompetitionLevelEnum Clone() {
      return new KeywordPlanCompetitionLevelEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlanCompetitionLevelEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeywordPlanCompetitionLevelEnum other) {
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
    public void MergeFrom(KeywordPlanCompetitionLevelEnum other) {
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
    /// <summary>Container for nested types declared in the KeywordPlanCompetitionLevelEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Competition level of a keyword.
      /// </summary>
      public enum KeywordPlanCompetitionLevel {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Low competition.
        /// </summary>
        [pbr::OriginalName("LOW")] Low = 2,
        /// <summary>
        /// Medium competition.
        /// </summary>
        [pbr::OriginalName("MEDIUM")] Medium = 3,
        /// <summary>
        /// High competition.
        /// </summary>
        [pbr::OriginalName("HIGH")] High = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
