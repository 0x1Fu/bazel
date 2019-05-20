// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/protobuf/timestamp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.WellKnownTypes {

  /// <summary>Holder for reflection information generated from google/protobuf/timestamp.proto</summary>
  public static partial class TimestampReflection {

    #region Descriptor
    /// <summary>File descriptor for google/protobuf/timestamp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TimestampReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvEg9nb29nbGUucHJv",
            "dG9idWYiKwoJVGltZXN0YW1wEg8KB3NlY29uZHMYASABKAMSDQoFbmFub3MY",
            "AiABKAVCfgoTY29tLmdvb2dsZS5wcm90b2J1ZkIOVGltZXN0YW1wUHJvdG9Q",
            "AVorZ2l0aHViLmNvbS9nb2xhbmcvcHJvdG9idWYvcHR5cGVzL3RpbWVzdGFt",
            "cPgBAaICA0dQQqoCHkdvb2dsZS5Qcm90b2J1Zi5XZWxsS25vd25UeXBlc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.WellKnownTypes.Timestamp), global::Google.Protobuf.WellKnownTypes.Timestamp.Parser, new[]{ "Seconds", "Nanos" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Timestamp represents a point in time independent of any time zone or local
  /// calendar, encoded as a count of seconds and fractions of seconds at
  /// nanosecond resolution. The count is relative to an epoch at UTC midnight on
  /// January 1, 1970, in the proleptic Gregorian calendar which extends the
  /// Gregorian calendar backwards to year one.
  ///
  /// All minutes are 60 seconds long. Leap seconds are "smeared" so that no leap
  /// second table is needed for interpretation, using a [24-hour linear
  /// smear](https://developers.google.com/time/smear).
  ///
  /// The range is from 0001-01-01T00:00:00Z to 9999-12-31T23:59:59.999999999Z. By
  /// restricting to that range, we ensure that we can convert to and from [RFC
  /// 3339](https://www.ietf.org/rfc/rfc3339.txt) date strings.
  ///
  /// # Examples
  ///
  /// Example 1: Compute Timestamp from POSIX `time()`.
  ///
  ///     Timestamp timestamp;
  ///     timestamp.set_seconds(time(NULL));
  ///     timestamp.set_nanos(0);
  ///
  /// Example 2: Compute Timestamp from POSIX `gettimeofday()`.
  ///
  ///     struct timeval tv;
  ///     gettimeofday(&amp;tv, NULL);
  ///
  ///     Timestamp timestamp;
  ///     timestamp.set_seconds(tv.tv_sec);
  ///     timestamp.set_nanos(tv.tv_usec * 1000);
  ///
  /// Example 3: Compute Timestamp from Win32 `GetSystemTimeAsFileTime()`.
  ///
  ///     FILETIME ft;
  ///     GetSystemTimeAsFileTime(&amp;ft);
  ///     UINT64 ticks = (((UINT64)ft.dwHighDateTime) &lt;&lt; 32) | ft.dwLowDateTime;
  ///
  ///     // A Windows tick is 100 nanoseconds. Windows epoch 1601-01-01T00:00:00Z
  ///     // is 11644473600 seconds before Unix epoch 1970-01-01T00:00:00Z.
  ///     Timestamp timestamp;
  ///     timestamp.set_seconds((INT64) ((ticks / 10000000) - 11644473600LL));
  ///     timestamp.set_nanos((INT32) ((ticks % 10000000) * 100));
  ///
  /// Example 4: Compute Timestamp from Java `System.currentTimeMillis()`.
  ///
  ///     long millis = System.currentTimeMillis();
  ///
  ///     Timestamp timestamp = Timestamp.newBuilder().setSeconds(millis / 1000)
  ///         .setNanos((int) ((millis % 1000) * 1000000)).build();
  ///
  /// Example 5: Compute Timestamp from current time in Python.
  ///
  ///     timestamp = Timestamp()
  ///     timestamp.GetCurrentTime()
  ///
  /// # JSON Mapping
  ///
  /// In JSON format, the Timestamp type is encoded as a string in the
  /// [RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) format. That is, the
  /// format is "{year}-{month}-{day}T{hour}:{min}:{sec}[.{frac_sec}]Z"
  /// where {year} is always expressed using four digits while {month}, {day},
  /// {hour}, {min}, and {sec} are zero-padded to two digits each. The fractional
  /// seconds, which can go up to 9 digits (i.e. up to 1 nanosecond resolution),
  /// are optional. The "Z" suffix indicates the timezone ("UTC"); the timezone
  /// is required. A proto3 JSON serializer should always use UTC (as indicated by
  /// "Z") when printing the Timestamp type and a proto3 JSON parser should be
  /// able to accept both UTC and other timezones (as indicated by an offset).
  ///
  /// For example, "2017-01-15T01:30:15.01Z" encodes 15.01 seconds past
  /// 01:30 UTC on January 15, 2017.
  ///
  /// In JavaScript, one can convert a Date object to this format using the
  /// standard [toISOString()](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/toISOString)
  /// method. In Python, a standard `datetime.datetime` object can be converted
  /// to this format using [`strftime`](https://docs.python.org/2/library/time.html#time.strftime)
  /// with the time format spec '%Y-%m-%dT%H:%M:%S.%fZ'. Likewise, in Java, one
  /// can use the Joda Time's [`ISODateTimeFormat.dateTime()`](
  /// http://www.joda.org/joda-time/apidocs/org/joda/time/format/ISODateTimeFormat.html#dateTime%2D%2D
  /// ) to obtain a formatter capable of generating timestamps in this format.
  /// </summary>
  public sealed partial class Timestamp : pb::IMessage<Timestamp> {
    private static readonly pb::MessageParser<Timestamp> _parser = new pb::MessageParser<Timestamp>(() => new Timestamp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Timestamp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Timestamp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Timestamp(Timestamp other) : this() {
      seconds_ = other.seconds_;
      nanos_ = other.nanos_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Timestamp Clone() {
      return new Timestamp(this);
    }

    /// <summary>Field number for the "seconds" field.</summary>
    public const int SecondsFieldNumber = 1;
    private long seconds_;
    /// <summary>
    /// Represents seconds of UTC time since Unix epoch
    /// 1970-01-01T00:00:00Z. Must be from 0001-01-01T00:00:00Z to
    /// 9999-12-31T23:59:59Z inclusive.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Seconds {
      get { return seconds_; }
      set {
        seconds_ = value;
      }
    }

    /// <summary>Field number for the "nanos" field.</summary>
    public const int NanosFieldNumber = 2;
    private int nanos_;
    /// <summary>
    /// Non-negative fractions of a second at nanosecond resolution. Negative
    /// second values with fractions must still have non-negative nanos values
    /// that count forward in time. Must be from 0 to 999,999,999
    /// inclusive.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Nanos {
      get { return nanos_; }
      set {
        nanos_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Timestamp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Timestamp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Seconds != other.Seconds) return false;
      if (Nanos != other.Nanos) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Seconds != 0L) hash ^= Seconds.GetHashCode();
      if (Nanos != 0) hash ^= Nanos.GetHashCode();
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
      if (Seconds != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Seconds);
      }
      if (Nanos != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Nanos);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Seconds != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Seconds);
      }
      if (Nanos != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Nanos);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Timestamp other) {
      if (other == null) {
        return;
      }
      if (other.Seconds != 0L) {
        Seconds = other.Seconds;
      }
      if (other.Nanos != 0) {
        Nanos = other.Nanos;
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
            Seconds = input.ReadInt64();
            break;
          }
          case 16: {
            Nanos = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
