// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/resources/media_file.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/resources/media_file.proto</summary>
  public static partial class MediaFileReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/resources/media_file.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MediaFileReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9yZXNvdXJjZXMvbWVkaWFfZmls",
            "ZS5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAucmVzb3VyY2VzGi5n",
            "b29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9tZWRpYV90eXBlLnByb3Rv",
            "Gi1nb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9taW1lX3R5cGUucHJv",
            "dG8aHmdvb2dsZS9wcm90b2J1Zi93cmFwcGVycy5wcm90byL9AwoJTWVkaWFG",
            "aWxlEhUKDXJlc291cmNlX25hbWUYASABKAkSJwoCaWQYAiABKAsyGy5nb29n",
            "bGUucHJvdG9idWYuSW50NjRWYWx1ZRJECgR0eXBlGAUgASgOMjYuZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjAuZW51bXMuTWVkaWFUeXBlRW51bS5NZWRpYVR5",
            "cGUSRwoJbWltZV90eXBlGAYgASgOMjQuZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djAuZW51bXMuTWltZVR5cGVFbnVtLk1pbWVUeXBlEjAKCnNvdXJjZV91cmwY",
            "ByABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWUSKgoEbmFtZRgI",
            "IAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZRIuCglmaWxlX3Np",
            "emUYCSABKAsyGy5nb29nbGUucHJvdG9idWYuSW50NjRWYWx1ZRI+CgVpbWFn",
            "ZRgDIAEoCzItLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLnJlc291cmNlcy5N",
            "ZWRpYUltYWdlSAASRgoMbWVkaWFfYnVuZGxlGAQgASgLMi4uZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjAucmVzb3VyY2VzLk1lZGlhQnVuZGxlSABCCwoJbWVk",
            "aWF0eXBlIjcKCk1lZGlhSW1hZ2USKQoEZGF0YRgBIAEoCzIbLmdvb2dsZS5w",
            "cm90b2J1Zi5CeXRlc1ZhbHVlIjgKC01lZGlhQnVuZGxlEikKBGRhdGEYASAB",
            "KAsyGy5nb29nbGUucHJvdG9idWYuQnl0ZXNWYWx1ZULTAQolY29tLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnYwLnJlc291cmNlc0IOTWVkaWFGaWxlUHJvdG9Q",
            "AVpKZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMv",
            "Z29vZ2xlYWRzL3YwL3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiFHb29n",
            "bGUuQWRzLkdvb2dsZUFkcy5WMC5SZXNvdXJjZXPKAiFHb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWMFxSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Enums.MediaTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V0.Enums.MimeTypeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Resources.MediaFile), global::Google.Ads.GoogleAds.V0.Resources.MediaFile.Parser, new[]{ "ResourceName", "Id", "Type", "MimeType", "SourceUrl", "Name", "FileSize", "Image", "MediaBundle" }, new[]{ "Mediatype" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Resources.MediaImage), global::Google.Ads.GoogleAds.V0.Resources.MediaImage.Parser, new[]{ "Data" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Resources.MediaBundle), global::Google.Ads.GoogleAds.V0.Resources.MediaBundle.Parser, new[]{ "Data" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A media file.
  /// </summary>
  public sealed partial class MediaFile : pb::IMessage<MediaFile> {
    private static readonly pb::MessageParser<MediaFile> _parser = new pb::MessageParser<MediaFile>(() => new MediaFile());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MediaFile> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Resources.MediaFileReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaFile() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaFile(MediaFile other) : this() {
      resourceName_ = other.resourceName_;
      Id = other.Id;
      type_ = other.type_;
      mimeType_ = other.mimeType_;
      SourceUrl = other.SourceUrl;
      Name = other.Name;
      FileSize = other.FileSize;
      switch (other.MediatypeCase) {
        case MediatypeOneofCase.Image:
          Image = other.Image.Clone();
          break;
        case MediatypeOneofCase.MediaBundle:
          MediaBundle = other.MediaBundle.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaFile Clone() {
      return new MediaFile(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the media file.
    /// Media file resource names have the form:
    ///
    /// `customers/{customer_id}/mediaFiles/{media_file_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private static readonly pb::FieldCodec<long?> _single_id_codec = pb::FieldCodec.ForStructWrapper<long>(18);
    private long? id_;
    /// <summary>
    /// The ID of the media file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V0.Enums.MediaTypeEnum.Types.MediaType type_ = 0;
    /// <summary>
    /// Type of the media file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Enums.MediaTypeEnum.Types.MediaType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "mime_type" field.</summary>
    public const int MimeTypeFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V0.Enums.MimeTypeEnum.Types.MimeType mimeType_ = 0;
    /// <summary>
    /// The mime type of the media file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Enums.MimeTypeEnum.Types.MimeType MimeType {
      get { return mimeType_; }
      set {
        mimeType_ = value;
      }
    }

    /// <summary>Field number for the "source_url" field.</summary>
    public const int SourceUrlFieldNumber = 7;
    private static readonly pb::FieldCodec<string> _single_sourceUrl_codec = pb::FieldCodec.ForClassWrapper<string>(58);
    private string sourceUrl_;
    /// <summary>
    /// The URL of where the original media file was downloaded from (or a file
    /// name).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SourceUrl {
      get { return sourceUrl_; }
      set {
        sourceUrl_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 8;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(66);
    private string name_;
    /// <summary>
    /// The name of the media file. The name can be used by clients to help
    /// identify previously uploaded media.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }

    /// <summary>Field number for the "file_size" field.</summary>
    public const int FileSizeFieldNumber = 9;
    private static readonly pb::FieldCodec<long?> _single_fileSize_codec = pb::FieldCodec.ForStructWrapper<long>(74);
    private long? fileSize_;
    /// <summary>
    /// The size of the media file in bytes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? FileSize {
      get { return fileSize_; }
      set {
        fileSize_ = value;
      }
    }

    /// <summary>Field number for the "image" field.</summary>
    public const int ImageFieldNumber = 3;
    /// <summary>
    /// Encapsulates an Image.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Resources.MediaImage Image {
      get { return mediatypeCase_ == MediatypeOneofCase.Image ? (global::Google.Ads.GoogleAds.V0.Resources.MediaImage) mediatype_ : null; }
      set {
        mediatype_ = value;
        mediatypeCase_ = value == null ? MediatypeOneofCase.None : MediatypeOneofCase.Image;
      }
    }

    /// <summary>Field number for the "media_bundle" field.</summary>
    public const int MediaBundleFieldNumber = 4;
    /// <summary>
    /// A ZIP archive media the content of which contains HTML5 assets.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Resources.MediaBundle MediaBundle {
      get { return mediatypeCase_ == MediatypeOneofCase.MediaBundle ? (global::Google.Ads.GoogleAds.V0.Resources.MediaBundle) mediatype_ : null; }
      set {
        mediatype_ = value;
        mediatypeCase_ = value == null ? MediatypeOneofCase.None : MediatypeOneofCase.MediaBundle;
      }
    }

    private object mediatype_;
    /// <summary>Enum of possible cases for the "mediatype" oneof.</summary>
    public enum MediatypeOneofCase {
      None = 0,
      Image = 3,
      MediaBundle = 4,
    }
    private MediatypeOneofCase mediatypeCase_ = MediatypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediatypeOneofCase MediatypeCase {
      get { return mediatypeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearMediatype() {
      mediatypeCase_ = MediatypeOneofCase.None;
      mediatype_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MediaFile);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MediaFile other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Type != other.Type) return false;
      if (MimeType != other.MimeType) return false;
      if (SourceUrl != other.SourceUrl) return false;
      if (Name != other.Name) return false;
      if (FileSize != other.FileSize) return false;
      if (!object.Equals(Image, other.Image)) return false;
      if (!object.Equals(MediaBundle, other.MediaBundle)) return false;
      if (MediatypeCase != other.MediatypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (MimeType != 0) hash ^= MimeType.GetHashCode();
      if (sourceUrl_ != null) hash ^= SourceUrl.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      if (fileSize_ != null) hash ^= FileSize.GetHashCode();
      if (mediatypeCase_ == MediatypeOneofCase.Image) hash ^= Image.GetHashCode();
      if (mediatypeCase_ == MediatypeOneofCase.MediaBundle) hash ^= MediaBundle.GetHashCode();
      hash ^= (int) mediatypeCase_;
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
      if (mediatypeCase_ == MediatypeOneofCase.Image) {
        output.WriteRawTag(26);
        output.WriteMessage(Image);
      }
      if (mediatypeCase_ == MediatypeOneofCase.MediaBundle) {
        output.WriteRawTag(34);
        output.WriteMessage(MediaBundle);
      }
      if (Type != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Type);
      }
      if (MimeType != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) MimeType);
      }
      if (sourceUrl_ != null) {
        _single_sourceUrl_codec.WriteTagAndValue(output, SourceUrl);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (fileSize_ != null) {
        _single_fileSize_codec.WriteTagAndValue(output, FileSize);
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
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (MimeType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MimeType);
      }
      if (sourceUrl_ != null) {
        size += _single_sourceUrl_codec.CalculateSizeWithTag(SourceUrl);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (fileSize_ != null) {
        size += _single_fileSize_codec.CalculateSizeWithTag(FileSize);
      }
      if (mediatypeCase_ == MediatypeOneofCase.Image) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Image);
      }
      if (mediatypeCase_ == MediatypeOneofCase.MediaBundle) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MediaBundle);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MediaFile other) {
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
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.MimeType != 0) {
        MimeType = other.MimeType;
      }
      if (other.sourceUrl_ != null) {
        if (sourceUrl_ == null || other.SourceUrl != "") {
          SourceUrl = other.SourceUrl;
        }
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.fileSize_ != null) {
        if (fileSize_ == null || other.FileSize != 0L) {
          FileSize = other.FileSize;
        }
      }
      switch (other.MediatypeCase) {
        case MediatypeOneofCase.Image:
          if (Image == null) {
            Image = new global::Google.Ads.GoogleAds.V0.Resources.MediaImage();
          }
          Image.MergeFrom(other.Image);
          break;
        case MediatypeOneofCase.MediaBundle:
          if (MediaBundle == null) {
            MediaBundle = new global::Google.Ads.GoogleAds.V0.Resources.MediaBundle();
          }
          MediaBundle.MergeFrom(other.MediaBundle);
          break;
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
          case 18: {
            long? value = _single_id_codec.Read(input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
          case 26: {
            global::Google.Ads.GoogleAds.V0.Resources.MediaImage subBuilder = new global::Google.Ads.GoogleAds.V0.Resources.MediaImage();
            if (mediatypeCase_ == MediatypeOneofCase.Image) {
              subBuilder.MergeFrom(Image);
            }
            input.ReadMessage(subBuilder);
            Image = subBuilder;
            break;
          }
          case 34: {
            global::Google.Ads.GoogleAds.V0.Resources.MediaBundle subBuilder = new global::Google.Ads.GoogleAds.V0.Resources.MediaBundle();
            if (mediatypeCase_ == MediatypeOneofCase.MediaBundle) {
              subBuilder.MergeFrom(MediaBundle);
            }
            input.ReadMessage(subBuilder);
            MediaBundle = subBuilder;
            break;
          }
          case 40: {
            type_ = (global::Google.Ads.GoogleAds.V0.Enums.MediaTypeEnum.Types.MediaType) input.ReadEnum();
            break;
          }
          case 48: {
            mimeType_ = (global::Google.Ads.GoogleAds.V0.Enums.MimeTypeEnum.Types.MimeType) input.ReadEnum();
            break;
          }
          case 58: {
            string value = _single_sourceUrl_codec.Read(input);
            if (sourceUrl_ == null || value != "") {
              SourceUrl = value;
            }
            break;
          }
          case 66: {
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 74: {
            long? value = _single_fileSize_codec.Read(input);
            if (fileSize_ == null || value != 0L) {
              FileSize = value;
            }
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Encapsulates an Image.
  /// </summary>
  public sealed partial class MediaImage : pb::IMessage<MediaImage> {
    private static readonly pb::MessageParser<MediaImage> _parser = new pb::MessageParser<MediaImage>(() => new MediaImage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MediaImage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Resources.MediaFileReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaImage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaImage(MediaImage other) : this() {
      Data = other.Data;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaImage Clone() {
      return new MediaImage(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private static readonly pb::FieldCodec<pb::ByteString> _single_data_codec = pb::FieldCodec.ForClassWrapper<pb::ByteString>(10);
    private pb::ByteString data_;
    /// <summary>
    /// Raw image data.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MediaImage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MediaImage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Data != other.Data) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (data_ != null) hash ^= Data.GetHashCode();
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
      if (data_ != null) {
        _single_data_codec.WriteTagAndValue(output, Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (data_ != null) {
        size += _single_data_codec.CalculateSizeWithTag(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MediaImage other) {
      if (other == null) {
        return;
      }
      if (other.data_ != null) {
        if (data_ == null || other.Data != pb::ByteString.Empty) {
          Data = other.Data;
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
            pb::ByteString value = _single_data_codec.Read(input);
            if (data_ == null || value != pb::ByteString.Empty) {
              Data = value;
            }
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Represents a ZIP archive media the content of which contains HTML5 assets.
  /// </summary>
  public sealed partial class MediaBundle : pb::IMessage<MediaBundle> {
    private static readonly pb::MessageParser<MediaBundle> _parser = new pb::MessageParser<MediaBundle>(() => new MediaBundle());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MediaBundle> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Resources.MediaFileReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaBundle() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaBundle(MediaBundle other) : this() {
      Data = other.Data;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaBundle Clone() {
      return new MediaBundle(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private static readonly pb::FieldCodec<pb::ByteString> _single_data_codec = pb::FieldCodec.ForClassWrapper<pb::ByteString>(10);
    private pb::ByteString data_;
    /// <summary>
    /// Raw zipped data.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MediaBundle);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MediaBundle other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Data != other.Data) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (data_ != null) hash ^= Data.GetHashCode();
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
      if (data_ != null) {
        _single_data_codec.WriteTagAndValue(output, Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (data_ != null) {
        size += _single_data_codec.CalculateSizeWithTag(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MediaBundle other) {
      if (other == null) {
        return;
      }
      if (other.data_ != null) {
        if (data_ == null || other.Data != pb::ByteString.Empty) {
          Data = other.Data;
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
            pb::ByteString value = _single_data_codec.Read(input);
            if (data_ == null || value != pb::ByteString.Empty) {
              Data = value;
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
