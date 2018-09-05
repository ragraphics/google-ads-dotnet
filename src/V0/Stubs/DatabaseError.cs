// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/database_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/database_error.proto</summary>
  public static partial class DatabaseErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/database_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DatabaseErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMvZGF0YWJhc2VfZXJy",
            "b3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVycm9ycyJfChFE",
            "YXRhYmFzZUVycm9yRW51bSJKCg1EYXRhYmFzZUVycm9yEg8KC1VOU1BFQ0lG",
            "SUVEEAASCwoHVU5LTk9XThABEhsKF0NPTkNVUlJFTlRfTU9ESUZJQ0FUSU9O",
            "EAJCyAEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lcnJvcnNCEkRh",
            "dGFiYXNlRXJyb3JQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjAvZXJyb3JzO2Vycm9yc6IC",
            "A0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYwLkVycm9yc8oCHkdvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYwXEVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.DatabaseErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.DatabaseErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.DatabaseErrorEnum.Types.DatabaseError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible database errors.
  /// </summary>
  public sealed partial class DatabaseErrorEnum : pb::IMessage<DatabaseErrorEnum> {
    private static readonly pb::MessageParser<DatabaseErrorEnum> _parser = new pb::MessageParser<DatabaseErrorEnum>(() => new DatabaseErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DatabaseErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Errors.DatabaseErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DatabaseErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DatabaseErrorEnum(DatabaseErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DatabaseErrorEnum Clone() {
      return new DatabaseErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DatabaseErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DatabaseErrorEnum other) {
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
    public void MergeFrom(DatabaseErrorEnum other) {
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
    /// <summary>Container for nested types declared in the DatabaseErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible database errors.
      /// </summary>
      public enum DatabaseError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Multiple requests were attempting to modify the same resource at once.
        /// Please retry the request.
        /// </summary>
        [pbr::OriginalName("CONCURRENT_MODIFICATION")] ConcurrentModification = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
