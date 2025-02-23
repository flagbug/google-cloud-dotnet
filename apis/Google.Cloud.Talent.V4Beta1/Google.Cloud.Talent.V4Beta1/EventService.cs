// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/talent/v4beta1/event_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Talent.V4Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/talent/v4beta1/event_service.proto</summary>
  public static partial class EventServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/talent/v4beta1/event_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EventServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvY2xvdWQvdGFsZW50L3Y0YmV0YTEvZXZlbnRfc2VydmljZS5w",
            "cm90bxIbZ29vZ2xlLmNsb3VkLnRhbGVudC52NGJldGExGhxnb29nbGUvYXBp",
            "L2Fubm90YXRpb25zLnByb3RvGhdnb29nbGUvYXBpL2NsaWVudC5wcm90bxon",
            "Z29vZ2xlL2Nsb3VkL3RhbGVudC92NGJldGExL2V2ZW50LnByb3RvImoKGENy",
            "ZWF0ZUNsaWVudEV2ZW50UmVxdWVzdBIOCgZwYXJlbnQYASABKAkSPgoMY2xp",
            "ZW50X2V2ZW50GAIgASgLMiguZ29vZ2xlLmNsb3VkLnRhbGVudC52NGJldGEx",
            "LkNsaWVudEV2ZW50MuMCCgxFdmVudFNlcnZpY2US5AEKEUNyZWF0ZUNsaWVu",
            "dEV2ZW50EjUuZ29vZ2xlLmNsb3VkLnRhbGVudC52NGJldGExLkNyZWF0ZUNs",
            "aWVudEV2ZW50UmVxdWVzdBooLmdvb2dsZS5jbG91ZC50YWxlbnQudjRiZXRh",
            "MS5DbGllbnRFdmVudCJugtPkkwJoIjMvdjRiZXRhMS97cGFyZW50PXByb2pl",
            "Y3RzLyovdGVuYW50cy8qfS9jbGllbnRFdmVudHM6ASpaLiIpL3Y0YmV0YTEv",
            "e3BhcmVudD1wcm9qZWN0cy8qfS9jbGllbnRFdmVudHM6ASoabMpBE2pvYnMu",
            "Z29vZ2xlYXBpcy5jb23SQVNodHRwczovL3d3dy5nb29nbGVhcGlzLmNvbS9h",
            "dXRoL2Nsb3VkLXBsYXRmb3JtLGh0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29t",
            "L2F1dGgvam9ic0J/Ch9jb20uZ29vZ2xlLmNsb3VkLnRhbGVudC52NGJldGEx",
            "QhFFdmVudFNlcnZpY2VQcm90b1ABWkFnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Nsb3VkL3RhbGVudC92NGJldGExO3RhbGVudKIC",
            "A0NUU2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Cloud.Talent.V4Beta1.EventReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Talent.V4Beta1.CreateClientEventRequest), global::Google.Cloud.Talent.V4Beta1.CreateClientEventRequest.Parser, new[]{ "Parent", "ClientEvent" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The report event request.
  /// </summary>
  public sealed partial class CreateClientEventRequest : pb::IMessage<CreateClientEventRequest> {
    private static readonly pb::MessageParser<CreateClientEventRequest> _parser = new pb::MessageParser<CreateClientEventRequest>(() => new CreateClientEventRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CreateClientEventRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Talent.V4Beta1.EventServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateClientEventRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateClientEventRequest(CreateClientEventRequest other) : this() {
      parent_ = other.parent_;
      clientEvent_ = other.clientEvent_ != null ? other.clientEvent_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateClientEventRequest Clone() {
      return new CreateClientEventRequest(this);
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 1;
    private string parent_ = "";
    /// <summary>
    /// Required. Resource name of the tenant under which the event is created.
    ///
    /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
    /// "projects/api-test-project/tenant/foo".
    ///
    /// Tenant id is optional and a default tenant is created if unspecified, for
    /// example, "projects/api-test-project".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Parent {
      get { return parent_; }
      set {
        parent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_event" field.</summary>
    public const int ClientEventFieldNumber = 2;
    private global::Google.Cloud.Talent.V4Beta1.ClientEvent clientEvent_;
    /// <summary>
    /// Required. Events issued when end user interacts with customer's application
    /// that uses Cloud Talent Solution.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Talent.V4Beta1.ClientEvent ClientEvent {
      get { return clientEvent_; }
      set {
        clientEvent_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CreateClientEventRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CreateClientEventRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Parent != other.Parent) return false;
      if (!object.Equals(ClientEvent, other.ClientEvent)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Parent.Length != 0) hash ^= Parent.GetHashCode();
      if (clientEvent_ != null) hash ^= ClientEvent.GetHashCode();
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
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (clientEvent_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ClientEvent);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Parent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Parent);
      }
      if (clientEvent_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClientEvent);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CreateClientEventRequest other) {
      if (other == null) {
        return;
      }
      if (other.Parent.Length != 0) {
        Parent = other.Parent;
      }
      if (other.clientEvent_ != null) {
        if (clientEvent_ == null) {
          clientEvent_ = new global::Google.Cloud.Talent.V4Beta1.ClientEvent();
        }
        ClientEvent.MergeFrom(other.ClientEvent);
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
            Parent = input.ReadString();
            break;
          }
          case 18: {
            if (clientEvent_ == null) {
              clientEvent_ = new global::Google.Cloud.Talent.V4Beta1.ClientEvent();
            }
            input.ReadMessage(clientEvent_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
