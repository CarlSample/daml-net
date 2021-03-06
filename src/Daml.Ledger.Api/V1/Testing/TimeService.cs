// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: com/digitalasset/ledger/api/v1/testing/time_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.DigitalAsset.Ledger.Api.V1.Testing {

  /// <summary>Holder for reflection information generated from com/digitalasset/ledger/api/v1/testing/time_service.proto</summary>
  public static partial class TimeServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for com/digitalasset/ledger/api/v1/testing/time_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TimeServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjljb20vZGlnaXRhbGFzc2V0L2xlZGdlci9hcGkvdjEvdGVzdGluZy90aW1l",
            "X3NlcnZpY2UucHJvdG8SJmNvbS5kaWdpdGFsYXNzZXQubGVkZ2VyLmFwaS52",
            "MS50ZXN0aW5nGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8aH2dvb2ds",
            "ZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8iIwoOR2V0VGltZVJlcXVlc3QS",
            "EQoJbGVkZ2VyX2lkGAEgASgJIkMKD0dldFRpbWVSZXNwb25zZRIwCgxjdXJy",
            "ZW50X3RpbWUYASABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wIoMB",
            "Cg5TZXRUaW1lUmVxdWVzdBIRCglsZWRnZXJfaWQYASABKAkSMAoMY3VycmVu",
            "dF90aW1lGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIsCghu",
            "ZXdfdGltZRgDIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXAy5gEK",
            "C1RpbWVTZXJ2aWNlEnwKB0dldFRpbWUSNi5jb20uZGlnaXRhbGFzc2V0Lmxl",
            "ZGdlci5hcGkudjEudGVzdGluZy5HZXRUaW1lUmVxdWVzdBo3LmNvbS5kaWdp",
            "dGFsYXNzZXQubGVkZ2VyLmFwaS52MS50ZXN0aW5nLkdldFRpbWVSZXNwb25z",
            "ZTABElkKB1NldFRpbWUSNi5jb20uZGlnaXRhbGFzc2V0LmxlZGdlci5hcGku",
            "djEudGVzdGluZy5TZXRUaW1lUmVxdWVzdBoWLmdvb2dsZS5wcm90b2J1Zi5F",
            "bXB0eUJoCiZjb20uZGlnaXRhbGFzc2V0LmxlZGdlci5hcGkudjEudGVzdGlu",
            "Z0IVVGltZVNlcnZpY2VPdXRlckNsYXNzqgImQ29tLkRpZ2l0YWxBc3NldC5M",
            "ZWRnZXIuQXBpLlYxLlRlc3RpbmdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Testing.GetTimeRequest), global::Com.DigitalAsset.Ledger.Api.V1.Testing.GetTimeRequest.Parser, new[]{ "LedgerId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Testing.GetTimeResponse), global::Com.DigitalAsset.Ledger.Api.V1.Testing.GetTimeResponse.Parser, new[]{ "CurrentTime" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.Testing.SetTimeRequest), global::Com.DigitalAsset.Ledger.Api.V1.Testing.SetTimeRequest.Parser, new[]{ "LedgerId", "CurrentTime", "NewTime" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetTimeRequest : pb::IMessage<GetTimeRequest> {
    private static readonly pb::MessageParser<GetTimeRequest> _parser = new pb::MessageParser<GetTimeRequest>(() => new GetTimeRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetTimeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Testing.TimeServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTimeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTimeRequest(GetTimeRequest other) : this() {
      ledgerId_ = other.ledgerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTimeRequest Clone() {
      return new GetTimeRequest(this);
    }

    /// <summary>Field number for the "ledger_id" field.</summary>
    public const int LedgerIdFieldNumber = 1;
    private string ledgerId_ = "";
    /// <summary>
    /// Must correspond to the ledger ID reported by the Ledger Identification Service.
    /// Must be a valid LedgerString (as describe in ``value.proto``).
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LedgerId {
      get { return ledgerId_; }
      set {
        ledgerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetTimeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetTimeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LedgerId != other.LedgerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (LedgerId.Length != 0) hash ^= LedgerId.GetHashCode();
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
      if (LedgerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LedgerId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (LedgerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LedgerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetTimeRequest other) {
      if (other == null) {
        return;
      }
      if (other.LedgerId.Length != 0) {
        LedgerId = other.LedgerId;
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
            LedgerId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetTimeResponse : pb::IMessage<GetTimeResponse> {
    private static readonly pb::MessageParser<GetTimeResponse> _parser = new pb::MessageParser<GetTimeResponse>(() => new GetTimeResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetTimeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Testing.TimeServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTimeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTimeResponse(GetTimeResponse other) : this() {
      currentTime_ = other.currentTime_ != null ? other.currentTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTimeResponse Clone() {
      return new GetTimeResponse(this);
    }

    /// <summary>Field number for the "current_time" field.</summary>
    public const int CurrentTimeFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp currentTime_;
    /// <summary>
    /// The current time according to the ledger server.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CurrentTime {
      get { return currentTime_; }
      set {
        currentTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetTimeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetTimeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CurrentTime, other.CurrentTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (currentTime_ != null) hash ^= CurrentTime.GetHashCode();
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
      if (currentTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CurrentTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (currentTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurrentTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetTimeResponse other) {
      if (other == null) {
        return;
      }
      if (other.currentTime_ != null) {
        if (currentTime_ == null) {
          CurrentTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CurrentTime.MergeFrom(other.CurrentTime);
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
            if (currentTime_ == null) {
              CurrentTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CurrentTime);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SetTimeRequest : pb::IMessage<SetTimeRequest> {
    private static readonly pb::MessageParser<SetTimeRequest> _parser = new pb::MessageParser<SetTimeRequest>(() => new SetTimeRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetTimeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.Testing.TimeServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetTimeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetTimeRequest(SetTimeRequest other) : this() {
      ledgerId_ = other.ledgerId_;
      currentTime_ = other.currentTime_ != null ? other.currentTime_.Clone() : null;
      newTime_ = other.newTime_ != null ? other.newTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetTimeRequest Clone() {
      return new SetTimeRequest(this);
    }

    /// <summary>Field number for the "ledger_id" field.</summary>
    public const int LedgerIdFieldNumber = 1;
    private string ledgerId_ = "";
    /// <summary>
    /// Must correspond to the ledger ID reported by the Ledger Identification Service.
    /// Must be a valid LedgerString (as describe in ``value.proto``).
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LedgerId {
      get { return ledgerId_; }
      set {
        ledgerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "current_time" field.</summary>
    public const int CurrentTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp currentTime_;
    /// <summary>
    /// MUST precisely match the current time as it's known to the ledger server.
    /// On mismatch, an ``INVALID_PARAMETER`` gRPC error will be returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CurrentTime {
      get { return currentTime_; }
      set {
        currentTime_ = value;
      }
    }

    /// <summary>Field number for the "new_time" field.</summary>
    public const int NewTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp newTime_;
    /// <summary>
    /// The time the client wants to set on the ledger.
    /// MUST be a point int time after ``current_time``.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp NewTime {
      get { return newTime_; }
      set {
        newTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetTimeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetTimeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LedgerId != other.LedgerId) return false;
      if (!object.Equals(CurrentTime, other.CurrentTime)) return false;
      if (!object.Equals(NewTime, other.NewTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (LedgerId.Length != 0) hash ^= LedgerId.GetHashCode();
      if (currentTime_ != null) hash ^= CurrentTime.GetHashCode();
      if (newTime_ != null) hash ^= NewTime.GetHashCode();
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
      if (LedgerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LedgerId);
      }
      if (currentTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CurrentTime);
      }
      if (newTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(NewTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (LedgerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LedgerId);
      }
      if (currentTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurrentTime);
      }
      if (newTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NewTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetTimeRequest other) {
      if (other == null) {
        return;
      }
      if (other.LedgerId.Length != 0) {
        LedgerId = other.LedgerId;
      }
      if (other.currentTime_ != null) {
        if (currentTime_ == null) {
          CurrentTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CurrentTime.MergeFrom(other.CurrentTime);
      }
      if (other.newTime_ != null) {
        if (newTime_ == null) {
          NewTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        NewTime.MergeFrom(other.NewTime);
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
            LedgerId = input.ReadString();
            break;
          }
          case 18: {
            if (currentTime_ == null) {
              CurrentTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CurrentTime);
            break;
          }
          case 26: {
            if (newTime_ == null) {
              NewTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(NewTime);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
