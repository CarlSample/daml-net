// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: com/digitalasset/ledger/api/v1/active_contracts_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.DigitalAsset.Ledger.Api.V1 {

  /// <summary>Holder for reflection information generated from com/digitalasset/ledger/api/v1/active_contracts_service.proto</summary>
  public static partial class ActiveContractsServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for com/digitalasset/ledger/api/v1/active_contracts_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ActiveContractsServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1jb20vZGlnaXRhbGFzc2V0L2xlZGdlci9hcGkvdjEvYWN0aXZlX2NvbnRy",
            "YWN0c19zZXJ2aWNlLnByb3RvEh5jb20uZGlnaXRhbGFzc2V0LmxlZGdlci5h",
            "cGkudjEaKmNvbS9kaWdpdGFsYXNzZXQvbGVkZ2VyL2FwaS92MS9ldmVudC5w",
            "cm90bxo3Y29tL2RpZ2l0YWxhc3NldC9sZWRnZXIvYXBpL3YxL3RyYW5zYWN0",
            "aW9uX2ZpbHRlci5wcm90bxoyY29tL2RpZ2l0YWxhc3NldC9sZWRnZXIvYXBp",
            "L3YxL3RyYWNlX2NvbnRleHQucHJvdG8iyAEKGUdldEFjdGl2ZUNvbnRyYWN0",
            "c1JlcXVlc3QSEQoJbGVkZ2VyX2lkGAEgASgJEkEKBmZpbHRlchgCIAEoCzIx",
            "LmNvbS5kaWdpdGFsYXNzZXQubGVkZ2VyLmFwaS52MS5UcmFuc2FjdGlvbkZp",
            "bHRlchIPCgd2ZXJib3NlGAMgASgIEkQKDXRyYWNlX2NvbnRleHQY6AcgASgL",
            "MiwuY29tLmRpZ2l0YWxhc3NldC5sZWRnZXIuYXBpLnYxLlRyYWNlQ29udGV4",
            "dCLPAQoaR2V0QWN0aXZlQ29udHJhY3RzUmVzcG9uc2USDgoGb2Zmc2V0GAEg",
            "ASgJEhMKC3dvcmtmbG93X2lkGAIgASgJEkYKEGFjdGl2ZV9jb250cmFjdHMY",
            "AyADKAsyLC5jb20uZGlnaXRhbGFzc2V0LmxlZGdlci5hcGkudjEuQ3JlYXRl",
            "ZEV2ZW50EkQKDXRyYWNlX2NvbnRleHQY6AcgASgLMiwuY29tLmRpZ2l0YWxh",
            "c3NldC5sZWRnZXIuYXBpLnYxLlRyYWNlQ29udGV4dDKoAQoWQWN0aXZlQ29u",
            "dHJhY3RzU2VydmljZRKNAQoSR2V0QWN0aXZlQ29udHJhY3RzEjkuY29tLmRp",
            "Z2l0YWxhc3NldC5sZWRnZXIuYXBpLnYxLkdldEFjdGl2ZUNvbnRyYWN0c1Jl",
            "cXVlc3QaOi5jb20uZGlnaXRhbGFzc2V0LmxlZGdlci5hcGkudjEuR2V0QWN0",
            "aXZlQ29udHJhY3RzUmVzcG9uc2UwAUJjCh5jb20uZGlnaXRhbGFzc2V0Lmxl",
            "ZGdlci5hcGkudjFCIEFjdGl2ZUNvbnRyYWN0c1NlcnZpY2VPdXRlckNsYXNz",
            "qgIeQ29tLkRpZ2l0YWxBc3NldC5MZWRnZXIuQXBpLlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Com.DigitalAsset.Ledger.Api.V1.EventReflection.Descriptor, global::Com.DigitalAsset.Ledger.Api.V1.TransactionFilterReflection.Descriptor, global::Com.DigitalAsset.Ledger.Api.V1.TraceContextReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.GetActiveContractsRequest), global::Com.DigitalAsset.Ledger.Api.V1.GetActiveContractsRequest.Parser, new[]{ "LedgerId", "Filter", "Verbose", "TraceContext" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.GetActiveContractsResponse), global::Com.DigitalAsset.Ledger.Api.V1.GetActiveContractsResponse.Parser, new[]{ "Offset", "WorkflowId", "ActiveContracts", "TraceContext" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetActiveContractsRequest : pb::IMessage<GetActiveContractsRequest> {
    private static readonly pb::MessageParser<GetActiveContractsRequest> _parser = new pb::MessageParser<GetActiveContractsRequest>(() => new GetActiveContractsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetActiveContractsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.ActiveContractsServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetActiveContractsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetActiveContractsRequest(GetActiveContractsRequest other) : this() {
      ledgerId_ = other.ledgerId_;
      filter_ = other.filter_ != null ? other.filter_.Clone() : null;
      verbose_ = other.verbose_;
      traceContext_ = other.traceContext_ != null ? other.traceContext_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetActiveContractsRequest Clone() {
      return new GetActiveContractsRequest(this);
    }

    /// <summary>Field number for the "ledger_id" field.</summary>
    public const int LedgerIdFieldNumber = 1;
    private string ledgerId_ = "";
    /// <summary>
    /// Must correspond to the ledger ID reported by the Ledger Identification Service.
    /// Must be a valid LedgerString (as described in ``value.proto``).
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LedgerId {
      get { return ledgerId_; }
      set {
        ledgerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "filter" field.</summary>
    public const int FilterFieldNumber = 2;
    private global::Com.DigitalAsset.Ledger.Api.V1.TransactionFilter filter_;
    /// <summary>
    /// Templates to include in the served snapshot, per party.
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.DigitalAsset.Ledger.Api.V1.TransactionFilter Filter {
      get { return filter_; }
      set {
        filter_ = value;
      }
    }

    /// <summary>Field number for the "verbose" field.</summary>
    public const int VerboseFieldNumber = 3;
    private bool verbose_;
    /// <summary>
    /// If enabled, values served over the API will contain more information than strictly necessary to interpret the data.
    /// In particular, setting the verbose flag to true triggers the ledger to include labels for record fields.
    /// Optional
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Verbose {
      get { return verbose_; }
      set {
        verbose_ = value;
      }
    }

    /// <summary>Field number for the "trace_context" field.</summary>
    public const int TraceContextFieldNumber = 1000;
    private global::Com.DigitalAsset.Ledger.Api.V1.TraceContext traceContext_;
    /// <summary>
    /// Server side tracing will be registered as a child of the submitted context.
    /// This field is a future extension point and is currently not supported.
    /// Optional
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.DigitalAsset.Ledger.Api.V1.TraceContext TraceContext {
      get { return traceContext_; }
      set {
        traceContext_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetActiveContractsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetActiveContractsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LedgerId != other.LedgerId) return false;
      if (!object.Equals(Filter, other.Filter)) return false;
      if (Verbose != other.Verbose) return false;
      if (!object.Equals(TraceContext, other.TraceContext)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (LedgerId.Length != 0) hash ^= LedgerId.GetHashCode();
      if (filter_ != null) hash ^= Filter.GetHashCode();
      if (Verbose != false) hash ^= Verbose.GetHashCode();
      if (traceContext_ != null) hash ^= TraceContext.GetHashCode();
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
      if (filter_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Filter);
      }
      if (Verbose != false) {
        output.WriteRawTag(24);
        output.WriteBool(Verbose);
      }
      if (traceContext_ != null) {
        output.WriteRawTag(194, 62);
        output.WriteMessage(TraceContext);
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
      if (filter_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Filter);
      }
      if (Verbose != false) {
        size += 1 + 1;
      }
      if (traceContext_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(TraceContext);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetActiveContractsRequest other) {
      if (other == null) {
        return;
      }
      if (other.LedgerId.Length != 0) {
        LedgerId = other.LedgerId;
      }
      if (other.filter_ != null) {
        if (filter_ == null) {
          Filter = new global::Com.DigitalAsset.Ledger.Api.V1.TransactionFilter();
        }
        Filter.MergeFrom(other.Filter);
      }
      if (other.Verbose != false) {
        Verbose = other.Verbose;
      }
      if (other.traceContext_ != null) {
        if (traceContext_ == null) {
          TraceContext = new global::Com.DigitalAsset.Ledger.Api.V1.TraceContext();
        }
        TraceContext.MergeFrom(other.TraceContext);
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
            if (filter_ == null) {
              Filter = new global::Com.DigitalAsset.Ledger.Api.V1.TransactionFilter();
            }
            input.ReadMessage(Filter);
            break;
          }
          case 24: {
            Verbose = input.ReadBool();
            break;
          }
          case 8002: {
            if (traceContext_ == null) {
              TraceContext = new global::Com.DigitalAsset.Ledger.Api.V1.TraceContext();
            }
            input.ReadMessage(TraceContext);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetActiveContractsResponse : pb::IMessage<GetActiveContractsResponse> {
    private static readonly pb::MessageParser<GetActiveContractsResponse> _parser = new pb::MessageParser<GetActiveContractsResponse>(() => new GetActiveContractsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetActiveContractsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.ActiveContractsServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetActiveContractsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetActiveContractsResponse(GetActiveContractsResponse other) : this() {
      offset_ = other.offset_;
      workflowId_ = other.workflowId_;
      activeContracts_ = other.activeContracts_.Clone();
      traceContext_ = other.traceContext_ != null ? other.traceContext_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetActiveContractsResponse Clone() {
      return new GetActiveContractsResponse(this);
    }

    /// <summary>Field number for the "offset" field.</summary>
    public const int OffsetFieldNumber = 1;
    private string offset_ = "";
    /// <summary>
    /// Included in the last message.
    /// The client should start consuming the transactions endpoint with this offset.
    /// The format of this field is described in ``ledger_offset.proto``.
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Offset {
      get { return offset_; }
      set {
        offset_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "workflow_id" field.</summary>
    public const int WorkflowIdFieldNumber = 2;
    private string workflowId_ = "";
    /// <summary>
    /// The workflow that created the contracts.
    /// Must be a valid LedgerString (as described in ``value.proto``).
    /// Optional
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string WorkflowId {
      get { return workflowId_; }
      set {
        workflowId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "active_contracts" field.</summary>
    public const int ActiveContractsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Com.DigitalAsset.Ledger.Api.V1.CreatedEvent> _repeated_activeContracts_codec
        = pb::FieldCodec.ForMessage(26, global::Com.DigitalAsset.Ledger.Api.V1.CreatedEvent.Parser);
    private readonly pbc::RepeatedField<global::Com.DigitalAsset.Ledger.Api.V1.CreatedEvent> activeContracts_ = new pbc::RepeatedField<global::Com.DigitalAsset.Ledger.Api.V1.CreatedEvent>();
    /// <summary>
    /// The list of contracts that were introduced by the workflow with ``workflow_id`` at the offset.
    /// Must be a valid LedgerString (as described in ``value.proto``).
    /// Optional
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Com.DigitalAsset.Ledger.Api.V1.CreatedEvent> ActiveContracts {
      get { return activeContracts_; }
    }

    /// <summary>Field number for the "trace_context" field.</summary>
    public const int TraceContextFieldNumber = 1000;
    private global::Com.DigitalAsset.Ledger.Api.V1.TraceContext traceContext_;
    /// <summary>
    /// Zipkin trace context.
    /// This field is a future extension point and is currently not supported.
    /// Optional
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.DigitalAsset.Ledger.Api.V1.TraceContext TraceContext {
      get { return traceContext_; }
      set {
        traceContext_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetActiveContractsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetActiveContractsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Offset != other.Offset) return false;
      if (WorkflowId != other.WorkflowId) return false;
      if(!activeContracts_.Equals(other.activeContracts_)) return false;
      if (!object.Equals(TraceContext, other.TraceContext)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Offset.Length != 0) hash ^= Offset.GetHashCode();
      if (WorkflowId.Length != 0) hash ^= WorkflowId.GetHashCode();
      hash ^= activeContracts_.GetHashCode();
      if (traceContext_ != null) hash ^= TraceContext.GetHashCode();
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
      if (Offset.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Offset);
      }
      if (WorkflowId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(WorkflowId);
      }
      activeContracts_.WriteTo(output, _repeated_activeContracts_codec);
      if (traceContext_ != null) {
        output.WriteRawTag(194, 62);
        output.WriteMessage(TraceContext);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Offset.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Offset);
      }
      if (WorkflowId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(WorkflowId);
      }
      size += activeContracts_.CalculateSize(_repeated_activeContracts_codec);
      if (traceContext_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(TraceContext);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetActiveContractsResponse other) {
      if (other == null) {
        return;
      }
      if (other.Offset.Length != 0) {
        Offset = other.Offset;
      }
      if (other.WorkflowId.Length != 0) {
        WorkflowId = other.WorkflowId;
      }
      activeContracts_.Add(other.activeContracts_);
      if (other.traceContext_ != null) {
        if (traceContext_ == null) {
          TraceContext = new global::Com.DigitalAsset.Ledger.Api.V1.TraceContext();
        }
        TraceContext.MergeFrom(other.TraceContext);
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
            Offset = input.ReadString();
            break;
          }
          case 18: {
            WorkflowId = input.ReadString();
            break;
          }
          case 26: {
            activeContracts_.AddEntriesFrom(input, _repeated_activeContracts_codec);
            break;
          }
          case 8002: {
            if (traceContext_ == null) {
              TraceContext = new global::Com.DigitalAsset.Ledger.Api.V1.TraceContext();
            }
            input.ReadMessage(TraceContext);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
