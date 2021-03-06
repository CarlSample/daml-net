// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: com/digitalasset/daml_lf_1_7/daml_lf.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.DigitalAsset.Daml_Lf_1_7.DamlLf {

  /// <summary>Holder for reflection information generated from com/digitalasset/daml_lf_1_7/daml_lf.proto</summary>
  public static partial class DamlLfReflection {

    #region Descriptor
    /// <summary>File descriptor for com/digitalasset/daml_lf_1_7/daml_lf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DamlLfReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cipjb20vZGlnaXRhbGFzc2V0L2RhbWxfbGZfMV83L2RhbWxfbGYucHJvdG8S",
            "C2RhbWxfbGZfMV83Gixjb20vZGlnaXRhbGFzc2V0L2RhbWxfbGZfMV83L2Rh",
            "bWxfbGZfMC5wcm90bxosY29tL2RpZ2l0YWxhc3NldC9kYW1sX2xmXzFfNy9k",
            "YW1sX2xmXzEucHJvdG8igAEKDkFyY2hpdmVQYXlsb2FkEg0KBW1pbm9yGAMg",
            "ASgJEicKCWRhbWxfbGZfMBgBIAEoCzISLmRhbWxfbGZfMC5QYWNrYWdlSAAS",
            "JwoJZGFtbF9sZl8xGAIgASgLMhIuZGFtbF9sZl8xLlBhY2thZ2VIAEIFCgNT",
            "dW1KBgiPThCQTiJaCgdBcmNoaXZlEjAKDWhhc2hfZnVuY3Rpb24YASABKA4y",
            "GS5kYW1sX2xmXzFfNy5IYXNoRnVuY3Rpb24SDwoHcGF5bG9hZBgDIAEoDBIM",
            "CgRoYXNoGAQgASgJKhoKDEhhc2hGdW5jdGlvbhIKCgZTSEEyNTYQAEJEChxj",
            "b20uZGlnaXRhbGFzc2V0LmRhbWxfbGZfMV83qgIjQ29tLkRpZ2l0YWxBc3Nl",
            "dC5EYW1sX0xmXzFfNy5EYW1sTGZiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf0.DamlLf0Reflection.Descriptor, global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf1.DamlLf1Reflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf.HashFunction), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf.ArchivePayload), global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf.ArchivePayload.Parser, new[]{ "Minor", "DamlLf0", "DamlLf1" }, new[]{ "Sum" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf.Archive), global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf.Archive.Parser, new[]{ "HashFunction", "Payload", "Hash" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum HashFunction {
    [pbr::OriginalName("SHA256")] Sha256 = 0,
  }

  #endregion

  #region Messages
  public sealed partial class ArchivePayload : pb::IMessage<ArchivePayload> {
    private static readonly pb::MessageParser<ArchivePayload> _parser = new pb::MessageParser<ArchivePayload>(() => new ArchivePayload());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ArchivePayload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf.DamlLfReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArchivePayload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArchivePayload(ArchivePayload other) : this() {
      minor_ = other.minor_;
      switch (other.SumCase) {
        case SumOneofCase.DamlLf0:
          DamlLf0 = other.DamlLf0.Clone();
          break;
        case SumOneofCase.DamlLf1:
          DamlLf1 = other.DamlLf1.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArchivePayload Clone() {
      return new ArchivePayload(this);
    }

    /// <summary>Field number for the "minor" field.</summary>
    public const int MinorFieldNumber = 3;
    private string minor_ = "";
    /// <summary>
    /// this is number 3 for historical reasons -- we had
    /// DAML-LF v0 and v1 before we had minor versions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Minor {
      get { return minor_; }
      set {
        minor_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "daml_lf_0" field.</summary>
    public const int DamlLf0FieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf0.Package DamlLf0 {
      get { return sumCase_ == SumOneofCase.DamlLf0 ? (global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf0.Package) sum_ : null; }
      set {
        sum_ = value;
        sumCase_ = value == null ? SumOneofCase.None : SumOneofCase.DamlLf0;
      }
    }

    /// <summary>Field number for the "daml_lf_1" field.</summary>
    public const int DamlLf1FieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf1.Package DamlLf1 {
      get { return sumCase_ == SumOneofCase.DamlLf1 ? (global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf1.Package) sum_ : null; }
      set {
        sum_ = value;
        sumCase_ = value == null ? SumOneofCase.None : SumOneofCase.DamlLf1;
      }
    }

    private object sum_;
    /// <summary>Enum of possible cases for the "Sum" oneof.</summary>
    public enum SumOneofCase {
      None = 0,
      DamlLf0 = 1,
      DamlLf1 = 2,
    }
    private SumOneofCase sumCase_ = SumOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SumOneofCase SumCase {
      get { return sumCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearSum() {
      sumCase_ = SumOneofCase.None;
      sum_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ArchivePayload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ArchivePayload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Minor != other.Minor) return false;
      if (!object.Equals(DamlLf0, other.DamlLf0)) return false;
      if (!object.Equals(DamlLf1, other.DamlLf1)) return false;
      if (SumCase != other.SumCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Minor.Length != 0) hash ^= Minor.GetHashCode();
      if (sumCase_ == SumOneofCase.DamlLf0) hash ^= DamlLf0.GetHashCode();
      if (sumCase_ == SumOneofCase.DamlLf1) hash ^= DamlLf1.GetHashCode();
      hash ^= (int) sumCase_;
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
      if (sumCase_ == SumOneofCase.DamlLf0) {
        output.WriteRawTag(10);
        output.WriteMessage(DamlLf0);
      }
      if (sumCase_ == SumOneofCase.DamlLf1) {
        output.WriteRawTag(18);
        output.WriteMessage(DamlLf1);
      }
      if (Minor.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Minor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Minor.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Minor);
      }
      if (sumCase_ == SumOneofCase.DamlLf0) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DamlLf0);
      }
      if (sumCase_ == SumOneofCase.DamlLf1) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DamlLf1);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ArchivePayload other) {
      if (other == null) {
        return;
      }
      if (other.Minor.Length != 0) {
        Minor = other.Minor;
      }
      switch (other.SumCase) {
        case SumOneofCase.DamlLf0:
          if (DamlLf0 == null) {
            DamlLf0 = new global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf0.Package();
          }
          DamlLf0.MergeFrom(other.DamlLf0);
          break;
        case SumOneofCase.DamlLf1:
          if (DamlLf1 == null) {
            DamlLf1 = new global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf1.Package();
          }
          DamlLf1.MergeFrom(other.DamlLf1);
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
            global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf0.Package subBuilder = new global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf0.Package();
            if (sumCase_ == SumOneofCase.DamlLf0) {
              subBuilder.MergeFrom(DamlLf0);
            }
            input.ReadMessage(subBuilder);
            DamlLf0 = subBuilder;
            break;
          }
          case 18: {
            global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf1.Package subBuilder = new global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf1.Package();
            if (sumCase_ == SumOneofCase.DamlLf1) {
              subBuilder.MergeFrom(DamlLf1);
            }
            input.ReadMessage(subBuilder);
            DamlLf1 = subBuilder;
            break;
          }
          case 26: {
            Minor = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Archive : pb::IMessage<Archive> {
    private static readonly pb::MessageParser<Archive> _parser = new pb::MessageParser<Archive>(() => new Archive());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Archive> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf.DamlLfReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Archive() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Archive(Archive other) : this() {
      hashFunction_ = other.hashFunction_;
      payload_ = other.payload_;
      hash_ = other.hash_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Archive Clone() {
      return new Archive(this);
    }

    /// <summary>Field number for the "hash_function" field.</summary>
    public const int HashFunctionFieldNumber = 1;
    private global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf.HashFunction hashFunction_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf.HashFunction HashFunction {
      get { return hashFunction_; }
      set {
        hashFunction_ = value;
      }
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 3;
    private pb::ByteString payload_ = pb::ByteString.Empty;
    /// <summary>
    /// Must be an encoded ArchivePayload. We store it as `bytes` to
    /// simplify hashing and in future signing.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Payload {
      get { return payload_; }
      set {
        payload_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hash" field.</summary>
    public const int HashFieldNumber = 4;
    private string hash_ = "";
    /// <summary>
    /// The hash is simply the ascii7 lowercase hex-encoded hash of the bytes
    /// according to the hash_function. We store it here for convenience, code
    /// reading the Archive should verify that the hash is valid.
    ///
    /// Note that the hash is computed directly on the blob and not
    /// on the decoded structure. This means that servers implementing
    /// a DAML ledger need to store the blob as-is somewhere to be able
    /// to always offer proof that they have a DAML package matching
    /// the requested hash. We decided to go for this route rather than
    /// relying on a canonical encoding of the AST since such a scheme
    /// would be extremely hard (for example protobuf encoding is not
    /// canonical) to maintain and does not buy us much.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Hash {
      get { return hash_; }
      set {
        hash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Archive);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Archive other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HashFunction != other.HashFunction) return false;
      if (Payload != other.Payload) return false;
      if (Hash != other.Hash) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HashFunction != 0) hash ^= HashFunction.GetHashCode();
      if (Payload.Length != 0) hash ^= Payload.GetHashCode();
      if (Hash.Length != 0) hash ^= Hash.GetHashCode();
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
      if (HashFunction != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) HashFunction);
      }
      if (Payload.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Payload);
      }
      if (Hash.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Hash);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HashFunction != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) HashFunction);
      }
      if (Payload.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Payload);
      }
      if (Hash.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Hash);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Archive other) {
      if (other == null) {
        return;
      }
      if (other.HashFunction != 0) {
        HashFunction = other.HashFunction;
      }
      if (other.Payload.Length != 0) {
        Payload = other.Payload;
      }
      if (other.Hash.Length != 0) {
        Hash = other.Hash;
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
            HashFunction = (global::Com.DigitalAsset.Daml_Lf_1_7.DamlLf.HashFunction) input.ReadEnum();
            break;
          }
          case 26: {
            Payload = input.ReadBytes();
            break;
          }
          case 34: {
            Hash = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
