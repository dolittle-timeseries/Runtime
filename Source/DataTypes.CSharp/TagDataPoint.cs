// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: dolittle/timeseries/datatypes/tag_data_point.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Dolittle.TimeSeries.DataTypes {

  /// <summary>Holder for reflection information generated from dolittle/timeseries/datatypes/tag_data_point.proto</summary>
  public static partial class TagDataPointReflection {

    #region Descriptor
    /// <summary>File descriptor for dolittle/timeseries/datatypes/tag_data_point.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TagDataPointReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJkb2xpdHRsZS90aW1lc2VyaWVzL2RhdGF0eXBlcy90YWdfZGF0YV9wb2lu",
            "dC5wcm90bxIdZG9saXR0bGUudGltZXNlcmllcy5kYXRhdHlwZXMaGWdvb2ds",
            "ZS9wcm90b2J1Zi9hbnkucHJvdG8iQAoMVGFnRGF0YVBvaW50EgsKA3RhZxgB",
            "IAEoCRIjCgV2YWx1ZRgCIAEoCzIULmdvb2dsZS5wcm90b2J1Zi5BbnlCIKoC",
            "HURvbGl0dGxlLlRpbWVTZXJpZXMuRGF0YVR5cGVzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Dolittle.TimeSeries.DataTypes.TagDataPoint), global::Dolittle.TimeSeries.DataTypes.TagDataPoint.Parser, new[]{ "Tag", "Value" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TagDataPoint : pb::IMessage<TagDataPoint> {
    private static readonly pb::MessageParser<TagDataPoint> _parser = new pb::MessageParser<TagDataPoint>(() => new TagDataPoint());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TagDataPoint> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dolittle.TimeSeries.DataTypes.TagDataPointReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TagDataPoint() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TagDataPoint(TagDataPoint other) : this() {
      tag_ = other.tag_;
      value_ = other.value_ != null ? other.value_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TagDataPoint Clone() {
      return new TagDataPoint(this);
    }

    /// <summary>Field number for the "tag" field.</summary>
    public const int TagFieldNumber = 1;
    private string tag_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Tag {
      get { return tag_; }
      set {
        tag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Any value_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Any Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TagDataPoint);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TagDataPoint other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Tag != other.Tag) return false;
      if (!object.Equals(Value, other.Value)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Tag.Length != 0) hash ^= Tag.GetHashCode();
      if (value_ != null) hash ^= Value.GetHashCode();
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
      if (Tag.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Tag);
      }
      if (value_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Tag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Tag);
      }
      if (value_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TagDataPoint other) {
      if (other == null) {
        return;
      }
      if (other.Tag.Length != 0) {
        Tag = other.Tag;
      }
      if (other.value_ != null) {
        if (value_ == null) {
          Value = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        Value.MergeFrom(other.Value);
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
            Tag = input.ReadString();
            break;
          }
          case 18: {
            if (value_ == null) {
              Value = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(Value);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
