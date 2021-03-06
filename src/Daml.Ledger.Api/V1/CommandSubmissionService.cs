// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: com/digitalasset/ledger/api/v1/command_submission_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.DigitalAsset.Ledger.Api.V1 {

  /// <summary>Holder for reflection information generated from com/digitalasset/ledger/api/v1/command_submission_service.proto</summary>
  public static partial class CommandSubmissionServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for com/digitalasset/ledger/api/v1/command_submission_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommandSubmissionServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9jb20vZGlnaXRhbGFzc2V0L2xlZGdlci9hcGkvdjEvY29tbWFuZF9zdWJt",
            "aXNzaW9uX3NlcnZpY2UucHJvdG8SHmNvbS5kaWdpdGFsYXNzZXQubGVkZ2Vy",
            "LmFwaS52MRoyY29tL2RpZ2l0YWxhc3NldC9sZWRnZXIvYXBpL3YxL3RyYWNl",
            "X2NvbnRleHQucHJvdG8aLWNvbS9kaWdpdGFsYXNzZXQvbGVkZ2VyL2FwaS92",
            "MS9jb21tYW5kcy5wcm90bxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3Rv",
            "IpEBCg1TdWJtaXRSZXF1ZXN0EjoKCGNvbW1hbmRzGAEgASgLMiguY29tLmRp",
            "Z2l0YWxhc3NldC5sZWRnZXIuYXBpLnYxLkNvbW1hbmRzEkQKDXRyYWNlX2Nv",
            "bnRleHQY6AcgASgLMiwuY29tLmRpZ2l0YWxhc3NldC5sZWRnZXIuYXBpLnYx",
            "LlRyYWNlQ29udGV4dDJrChhDb21tYW5kU3VibWlzc2lvblNlcnZpY2USTwoG",
            "U3VibWl0Ei0uY29tLmRpZ2l0YWxhc3NldC5sZWRnZXIuYXBpLnYxLlN1Ym1p",
            "dFJlcXVlc3QaFi5nb29nbGUucHJvdG9idWYuRW1wdHlCZQoeY29tLmRpZ2l0",
            "YWxhc3NldC5sZWRnZXIuYXBpLnYxQiJDb21tYW5kU3VibWlzc2lvblNlcnZp",
            "Y2VPdXRlckNsYXNzqgIeQ29tLkRpZ2l0YWxBc3NldC5MZWRnZXIuQXBpLlYx",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Com.DigitalAsset.Ledger.Api.V1.TraceContextReflection.Descriptor, global::Com.DigitalAsset.Ledger.Api.V1.CommandsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.DigitalAsset.Ledger.Api.V1.SubmitRequest), global::Com.DigitalAsset.Ledger.Api.V1.SubmitRequest.Parser, new[]{ "Commands", "TraceContext" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The submitted commands will be processed atomically in a single transaction. Moreover, each ``Command`` in ``commands`` will be executed in the order specified by the request.
  /// </summary>
  public sealed partial class SubmitRequest : pb::IMessage<SubmitRequest> {
    private static readonly pb::MessageParser<SubmitRequest> _parser = new pb::MessageParser<SubmitRequest>(() => new SubmitRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SubmitRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.DigitalAsset.Ledger.Api.V1.CommandSubmissionServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SubmitRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SubmitRequest(SubmitRequest other) : this() {
      commands_ = other.commands_ != null ? other.commands_.Clone() : null;
      traceContext_ = other.traceContext_ != null ? other.traceContext_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SubmitRequest Clone() {
      return new SubmitRequest(this);
    }

    /// <summary>Field number for the "commands" field.</summary>
    public const int CommandsFieldNumber = 1;
    private global::Com.DigitalAsset.Ledger.Api.V1.Commands commands_;
    /// <summary>
    /// The commands to be submitted in a single transaction.
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.DigitalAsset.Ledger.Api.V1.Commands Commands {
      get { return commands_; }
      set {
        commands_ = value;
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
      return Equals(other as SubmitRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SubmitRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Commands, other.Commands)) return false;
      if (!object.Equals(TraceContext, other.TraceContext)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (commands_ != null) hash ^= Commands.GetHashCode();
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
      if (commands_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Commands);
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
      if (commands_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Commands);
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
    public void MergeFrom(SubmitRequest other) {
      if (other == null) {
        return;
      }
      if (other.commands_ != null) {
        if (commands_ == null) {
          Commands = new global::Com.DigitalAsset.Ledger.Api.V1.Commands();
        }
        Commands.MergeFrom(other.Commands);
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
            if (commands_ == null) {
              Commands = new global::Com.DigitalAsset.Ledger.Api.V1.Commands();
            }
            input.ReadMessage(Commands);
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
