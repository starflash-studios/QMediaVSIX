// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LoggingFields
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Represents a sequence of event fields and provides methods for adding fields to the sequence.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class LoggingFields : ILoggingFields
  {
    /// <summary>Initializes a new **LoggingFields** instance.</summary>
    [MethodImpl]
    public extern LoggingFields();

    /// <summary>Removes all fields stored in the object and resets the object to its newly-constructed state.</summary>
    [MethodImpl]
    public extern void Clear();

    /// <summary>Begins a new structured field with the specified field name.</summary>
    /// <param name="name">Name of the structured field.</param>
    [Overload("BeginStruct")]
    [MethodImpl]
    public extern void BeginStruct(string name);

    /// <summary>Begins a new structured field with the specified field name and tags.</summary>
    /// <param name="name">Name of the structured field.</param>
    /// <param name="tags">Specifies up to twenty-eight bits of user-defined field metadata. The top four bits are reserved and must be set to zero (0).The metadata may be used by a custom Event Tracing for Windows (ETW) processing tool. For example, you might define a tag that indicates that a field might contain personally-identifiable information.</param>
    [Overload("BeginStructWithTags")]
    [MethodImpl]
    public extern void BeginStruct(string name, int tags);

    /// <summary>Ends a structured field.</summary>
    [MethodImpl]
    public extern void EndStruct();

    /// <summary>Adds an empty field.</summary>
    /// <param name="name">Name of the event field.</param>
    [Overload("AddEmpty")]
    [MethodImpl]
    public extern void AddEmpty(string name);

    /// <summary>Adds an empty field.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddEmptyWithFormat")]
    [MethodImpl]
    public extern void AddEmpty(string name, LoggingFieldFormat format);

    /// <summary>Adds an empty field.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddEmptyWithFormatAndTags")]
    [MethodImpl]
    public extern void AddEmpty(string name, LoggingFieldFormat format, int tags);

    /// <summary>Adds an 8-bit unsigned integer field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    [Overload("AddUInt8")]
    [MethodImpl]
    public extern void AddUInt8(string name, byte value);

    /// <summary>Adds an 8-bit unsigned integer field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddUInt8WithFormat")]
    [MethodImpl]
    public extern void AddUInt8(string name, byte value, LoggingFieldFormat format);

    /// <summary>Adds an 8-bit unsigned integer field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddUInt8WithFormatAndTags")]
    [MethodImpl]
    public extern void AddUInt8(string name, byte value, LoggingFieldFormat format, int tags);

    /// <summary>Adds an 8-bit unsigned integer array field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field. The format for the array is binary.</param>
    [Overload("AddUInt8Array")]
    [MethodImpl]
    public extern void AddUInt8Array(string name, byte[] value);

    /// <summary>Adds an 8-bit unsigned integer array field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field. The default format for the array is binary. See the remarks section for other formats that may be specified.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddUInt8ArrayWithFormat")]
    [MethodImpl]
    public extern void AddUInt8Array(string name, byte[] value, LoggingFieldFormat format);

    /// <summary>Adds an 8-bit unsigned integer array field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field. The default format for the array is binary. See the remarks section for other formats that may be specified.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddUInt8ArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddUInt8Array(
      string name,
      byte[] value,
      LoggingFieldFormat format,
      int tags);

    /// <summary>Adds a 16-bit integer field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">Value of the event field.</param>
    [Overload("AddInt16")]
    [MethodImpl]
    public extern void AddInt16(string name, short value);

    /// <summary>Adds a 16-bit integer field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">Value of the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddInt16WithFormat")]
    [MethodImpl]
    public extern void AddInt16(string name, short value, LoggingFieldFormat format);

    /// <summary>Adds a 16-bit integer field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">Value of the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddInt16WithFormatAndTags")]
    [MethodImpl]
    public extern void AddInt16(string name, short value, LoggingFieldFormat format, int tags);

    /// <summary>Adds a 16-bit integer array field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">Value of the event field.</param>
    [Overload("AddInt16Array")]
    [MethodImpl]
    public extern void AddInt16Array(string name, short[] value);

    /// <summary>Adds a 16-bit integer array field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">Value of the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddInt16ArrayWithFormat")]
    [MethodImpl]
    public extern void AddInt16Array(string name, short[] value, LoggingFieldFormat format);

    /// <summary>Adds a 16-bit integer array field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">Value of the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddInt16ArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddInt16Array(
      string name,
      short[] value,
      LoggingFieldFormat format,
      int tags);

    /// <summary>Adds a 16-bit unsigned integer field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    [Overload("AddUInt16")]
    [MethodImpl]
    public extern void AddUInt16(string name, ushort value);

    /// <summary>Adds a 16-bit unsigned integer field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddUInt16WithFormat")]
    [MethodImpl]
    public extern void AddUInt16(string name, ushort value, LoggingFieldFormat format);

    /// <summary>Adds a 16-bit unsigned integer field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddUInt16WithFormatAndTags")]
    [MethodImpl]
    public extern void AddUInt16(string name, ushort value, LoggingFieldFormat format, int tags);

    /// <summary>Adds a16-bit unsigned integer field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field. The default format for the array is binary. See the remarks section for other formats that may be specified.</param>
    [Overload("AddUInt16Array")]
    [MethodImpl]
    public extern void AddUInt16Array(string name, ushort[] value);

    /// <summary>Adds a 16-bit unsigned integer array field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field. The default format for the array is binary. See the remarks section for other formats that may be specified.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddUInt16ArrayWithFormat")]
    [MethodImpl]
    public extern void AddUInt16Array(string name, ushort[] value, LoggingFieldFormat format);

    /// <summary>Adds a 16-bit unsigned integer array field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field. The default format for the array is binary. See the remarks section for other formats that may be specified.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddUInt16ArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddUInt16Array(
      string name,
      ushort[] value,
      LoggingFieldFormat format,
      int tags);

    /// <summary>Adds a 32-bit integer array field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">Value of the event field.</param>
    [Overload("AddInt32")]
    [MethodImpl]
    public extern void AddInt32(string name, int value);

    /// <summary>Adds a 32-bit integer array field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">Value of the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddInt32WithFormat")]
    [MethodImpl]
    public extern void AddInt32(string name, int value, LoggingFieldFormat format);

    /// <summary>Adds a 32-bit integer array field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The array values for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddInt32WithFormatAndTags")]
    [MethodImpl]
    public extern void AddInt32(string name, int value, LoggingFieldFormat format, int tags);

    /// <summary>Adds a 32-bit integer array field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The array values for the event field.</param>
    [Overload("AddInt32Array")]
    [MethodImpl]
    public extern void AddInt32Array(string name, int[] value);

    /// <summary>Adds a 32-bit integer array field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The array values for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddInt32ArrayWithFormat")]
    [MethodImpl]
    public extern void AddInt32Array(string name, int[] value, LoggingFieldFormat format);

    /// <summary>Adds a 32-bit integer array field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The array values for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddInt32ArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddInt32Array(
      string name,
      int[] value,
      LoggingFieldFormat format,
      int tags);

    /// <summary>Adds a 32-bit unsigned integer field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    [Overload("AddUInt32")]
    [MethodImpl]
    public extern void AddUInt32(string name, uint value);

    /// <summary>Adds a 32-bit unsigned integer field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddUInt32WithFormat")]
    [MethodImpl]
    public extern void AddUInt32(string name, uint value, LoggingFieldFormat format);

    /// <summary>Adds a 32-bit unsigned integer field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddUInt32WithFormatAndTags")]
    [MethodImpl]
    public extern void AddUInt32(string name, uint value, LoggingFieldFormat format, int tags);

    /// <summary>Adds a 32-bit unsigned integer array field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    [Overload("AddUInt32Array")]
    [MethodImpl]
    public extern void AddUInt32Array(string name, uint[] value);

    /// <summary>Adds a 32-bit unsigned integer array field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddUInt32ArrayWithFormat")]
    [MethodImpl]
    public extern void AddUInt32Array(string name, uint[] value, LoggingFieldFormat format);

    /// <summary>Adds a 32-bit unsigned integer array field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddUInt32ArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddUInt32Array(
      string name,
      uint[] value,
      LoggingFieldFormat format,
      int tags);

    /// <summary>Adds a 64-bit integer array field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The array values for the event field.</param>
    [Overload("AddInt64")]
    [MethodImpl]
    public extern void AddInt64(string name, long value);

    /// <summary>Adds a 64-bit integer array field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The array values for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddInt64WithFormat")]
    [MethodImpl]
    public extern void AddInt64(string name, long value, LoggingFieldFormat format);

    /// <summary>Adds a 64-bit integer field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddInt64WithFormatAndTags")]
    [MethodImpl]
    public extern void AddInt64(string name, long value, LoggingFieldFormat format, int tags);

    /// <summary>Adds a 64-bit integer array field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The array values for the event field.</param>
    [Overload("AddInt64Array")]
    [MethodImpl]
    public extern void AddInt64Array(string name, long[] value);

    /// <summary>Adds a 64-bit integer array field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The array values for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddInt64ArrayWithFormat")]
    [MethodImpl]
    public extern void AddInt64Array(string name, long[] value, LoggingFieldFormat format);

    /// <summary>Adds a 64-bit integer array field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The array values for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddInt64ArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddInt64Array(
      string name,
      long[] value,
      LoggingFieldFormat format,
      int tags);

    /// <summary>Adds a 64-bit unsigned integer field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    [Overload("AddUInt64")]
    [MethodImpl]
    public extern void AddUInt64(string name, ulong value);

    /// <summary>Adds a 64-bit unsigned integer field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddUInt64WithFormat")]
    [MethodImpl]
    public extern void AddUInt64(string name, ulong value, LoggingFieldFormat format);

    /// <summary>Adds a 64-bit unsigned integer field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddUInt64WithFormatAndTags")]
    [MethodImpl]
    public extern void AddUInt64(string name, ulong value, LoggingFieldFormat format, int tags);

    /// <summary>Adds a 64-bit unsigned integer array field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    [Overload("AddUInt64Array")]
    [MethodImpl]
    public extern void AddUInt64Array(string name, ulong[] value);

    /// <summary>Adds a 64-bit unsigned integer array field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddUInt64ArrayWithFormat")]
    [MethodImpl]
    public extern void AddUInt64Array(string name, ulong[] value, LoggingFieldFormat format);

    /// <summary>Adds a 64-bit unsigned integer array field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddUInt64ArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddUInt64Array(
      string name,
      ulong[] value,
      LoggingFieldFormat format,
      int tags);

    /// <summary>Adds a Single field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    [Overload("AddSingle")]
    [MethodImpl]
    public extern void AddSingle(string name, float value);

    /// <summary>Adds a Single field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddSingleWithFormat")]
    [MethodImpl]
    public extern void AddSingle(string name, float value, LoggingFieldFormat format);

    /// <summary>Adds a Single field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddSingleWithFormatAndTags")]
    [MethodImpl]
    public extern void AddSingle(string name, float value, LoggingFieldFormat format, int tags);

    /// <summary>Adds a Single array field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    [Overload("AddSingleArray")]
    [MethodImpl]
    public extern void AddSingleArray(string name, float[] value);

    /// <summary>Adds a Single array field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddSingleArrayWithFormat")]
    [MethodImpl]
    public extern void AddSingleArray(string name, float[] value, LoggingFieldFormat format);

    /// <summary>Adds a Single array field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddSingleArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddSingleArray(
      string name,
      float[] value,
      LoggingFieldFormat format,
      int tags);

    /// <summary>Adds a Double field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">Value of the event field.</param>
    [Overload("AddDouble")]
    [MethodImpl]
    public extern void AddDouble(string name, double value);

    /// <summary>Adds a Double field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">Value of the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddDoubleWithFormat")]
    [MethodImpl]
    public extern void AddDouble(string name, double value, LoggingFieldFormat format);

    /// <summary>Adds a Double field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">Value of the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddDoubleWithFormatAndTags")]
    [MethodImpl]
    public extern void AddDouble(string name, double value, LoggingFieldFormat format, int tags);

    /// <summary>Adds a Double array field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The array of values for the event field.</param>
    [Overload("AddDoubleArray")]
    [MethodImpl]
    public extern void AddDoubleArray(string name, double[] value);

    /// <summary>Adds a Double array field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The array of values for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddDoubleArrayWithFormat")]
    [MethodImpl]
    public extern void AddDoubleArray(string name, double[] value, LoggingFieldFormat format);

    /// <summary>Adds a Double array field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The array of values for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddDoubleArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddDoubleArray(
      string name,
      double[] value,
      LoggingFieldFormat format,
      int tags);

    /// <summary>Adds a 16-bit character field with the specified field name.</summary>
    /// <param name="name">The name of the event field.</param>
    /// <param name="value">The value of the event field.</param>
    [Overload("AddChar16")]
    [MethodImpl]
    public extern void AddChar16(string name, char value);

    /// <summary>Adds a 16-bit character field with the specified field name and format.</summary>
    /// <param name="name">The name of the event field.</param>
    /// <param name="value">The value of the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddChar16WithFormat")]
    [MethodImpl]
    public extern void AddChar16(string name, char value, LoggingFieldFormat format);

    /// <summary>Adds a 16-bit character field with the specified field name, format, and tag.</summary>
    /// <param name="name">The name of the event field.</param>
    /// <param name="value">The value of the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddChar16WithFormatAndTags")]
    [MethodImpl]
    public extern void AddChar16(string name, char value, LoggingFieldFormat format, int tags);

    /// <summary>Adds a 16-bit character array field with the specified field name.</summary>
    /// <param name="name">The name of the event field.</param>
    /// <param name="value">The array of values for the event field.</param>
    [Overload("AddChar16Array")]
    [MethodImpl]
    public extern void AddChar16Array(string name, char[] value);

    /// <summary>Adds a 16-bit character array field with the specified field name and format.</summary>
    /// <param name="name">The name of the event field.</param>
    /// <param name="value">The array of values for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddChar16ArrayWithFormat")]
    [MethodImpl]
    public extern void AddChar16Array(string name, char[] value, LoggingFieldFormat format);

    /// <summary>Adds a 16-bit character array field with the specified field name and format, and tags.</summary>
    /// <param name="name">The name of the event field.</param>
    /// <param name="value">The array of values for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddChar16ArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddChar16Array(
      string name,
      char[] value,
      LoggingFieldFormat format,
      int tags);

    /// <summary>Adds a boolean field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">Value of the event field.</param>
    [Overload("AddBoolean")]
    [MethodImpl]
    public extern void AddBoolean(string name, bool value);

    /// <summary>Adds a boolean field with the specified field name and format.</summary>
    /// <param name="name">The name of the event field.</param>
    /// <param name="value">The value of the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddBooleanWithFormat")]
    [MethodImpl]
    public extern void AddBoolean(string name, bool value, LoggingFieldFormat format);

    /// <summary>Adds a boolean field with the specified field name, format, and tags.</summary>
    /// <param name="name">The name of the event field.</param>
    /// <param name="value">The value of the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddBooleanWithFormatAndTags")]
    [MethodImpl]
    public extern void AddBoolean(string name, bool value, LoggingFieldFormat format, int tags);

    /// <summary>Adds a boolean array field with the specified field name.</summary>
    /// <param name="name">The name of the event field.</param>
    /// <param name="value">The array values for the event field.</param>
    [Overload("AddBooleanArray")]
    [MethodImpl]
    public extern void AddBooleanArray(string name, bool[] value);

    /// <summary>Adds a boolean array field with the specified field name and format.</summary>
    /// <param name="name">The name of the event field.</param>
    /// <param name="value">The array of values for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddBooleanArrayWithFormat")]
    [MethodImpl]
    public extern void AddBooleanArray(string name, bool[] value, LoggingFieldFormat format);

    /// <summary>Adds a boolean array field with the specified field name, format, and tag.</summary>
    /// <param name="name">The name of the event field.</param>
    /// <param name="value">The array of values for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddBooleanArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddBooleanArray(
      string name,
      bool[] value,
      LoggingFieldFormat format,
      int tags);

    /// <summary>Adds a String field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    [Overload("AddString")]
    [MethodImpl]
    public extern void AddString(string name, string value);

    /// <summary>Adds a String field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddStringWithFormat")]
    [MethodImpl]
    public extern void AddString(string name, string value, LoggingFieldFormat format);

    /// <summary>Adds a String field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddStringWithFormatAndTags")]
    [MethodImpl]
    public extern void AddString(string name, string value, LoggingFieldFormat format, int tags);

    /// <summary>Adds a String array field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    [Overload("AddStringArray")]
    [MethodImpl]
    public extern void AddStringArray(string name, string[] value);

    /// <summary>Adds a String array field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddStringArrayWithFormat")]
    [MethodImpl]
    public extern void AddStringArray(string name, string[] value, LoggingFieldFormat format);

    /// <summary>Adds a String array field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddStringArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddStringArray(
      string name,
      string[] value,
      LoggingFieldFormat format,
      int tags);

    /// <summary>Adds a GUID field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">Value of the event field.</param>
    [Overload("AddGuid")]
    [MethodImpl]
    public extern void AddGuid(string name, Guid value);

    /// <summary>Adds a GUID field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">Value of the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddGuidWithFormat")]
    [MethodImpl]
    public extern void AddGuid(string name, Guid value, LoggingFieldFormat format);

    /// <summary>Adds a GUID field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">Value of the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddGuidWithFormatAndTags")]
    [MethodImpl]
    public extern void AddGuid(string name, Guid value, LoggingFieldFormat format, int tags);

    /// <summary>Adds a GUID array field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The array values for the event field.</param>
    [Overload("AddGuidArray")]
    [MethodImpl]
    public extern void AddGuidArray(string name, Guid[] value);

    /// <summary>Adds a GUID array field with the specified field name and format</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The array values for the event field.</param>
    /// <param name="format">The format of the event field.</param>
    [Overload("AddGuidArrayWithFormat")]
    [MethodImpl]
    public extern void AddGuidArray(string name, Guid[] value, LoggingFieldFormat format);

    /// <summary>Adds a GUID array field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The array values for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddGuidArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddGuidArray(
      string name,
      Guid[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddDateTime")]
    [MethodImpl]
    public extern void AddDateTime(string name, global::Windows.Foundation.DateTime value);

    [Overload("AddDateTimeWithFormat")]
    [MethodImpl]
    public extern void AddDateTime(string name, global::Windows.Foundation.DateTime value, LoggingFieldFormat format);

    [Overload("AddDateTimeWithFormatAndTags")]
    [MethodImpl]
    public extern void AddDateTime(
      string name,
      global::Windows.Foundation.DateTime value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddDateTimeArray")]
    [MethodImpl]
    public extern void AddDateTimeArray(string name, global::Windows.Foundation.DateTime[] value);

    [Overload("AddDateTimeArrayWithFormat")]
    [MethodImpl]
    public extern void AddDateTimeArray(string name, global::Windows.Foundation.DateTime[] value, LoggingFieldFormat format);

    [Overload("AddDateTimeArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddDateTimeArray(
      string name,
      global::Windows.Foundation.DateTime[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddTimeSpan")]
    [MethodImpl]
    public extern void AddTimeSpan(string name, global::Windows.Foundation.TimeSpan value);

    [Overload("AddTimeSpanWithFormat")]
    [MethodImpl]
    public extern void AddTimeSpan(string name, global::Windows.Foundation.TimeSpan value, LoggingFieldFormat format);

    [Overload("AddTimeSpanWithFormatAndTags")]
    [MethodImpl]
    public extern void AddTimeSpan(
      string name,
      global::Windows.Foundation.TimeSpan value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddTimeSpanArray")]
    [MethodImpl]
    public extern void AddTimeSpanArray(string name, global::Windows.Foundation.TimeSpan[] value);

    [Overload("AddTimeSpanArrayWithFormat")]
    [MethodImpl]
    public extern void AddTimeSpanArray(string name, global::Windows.Foundation.TimeSpan[] value, LoggingFieldFormat format);

    [Overload("AddTimeSpanArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddTimeSpanArray(
      string name,
      global::Windows.Foundation.TimeSpan[] value,
      LoggingFieldFormat format,
      int tags);

    /// <summary>Adds a Point field with the specified name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    [Overload("AddPoint")]
    [MethodImpl]
    public extern void AddPoint(string name, Point value);

    /// <summary>Adds a Point field with the specified name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddPointWithFormat")]
    [MethodImpl]
    public extern void AddPoint(string name, Point value, LoggingFieldFormat format);

    /// <summary>Adds a Point field with the specified name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddPointWithFormatAndTags")]
    [MethodImpl]
    public extern void AddPoint(string name, Point value, LoggingFieldFormat format, int tags);

    /// <summary>Adds a Point array field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    [Overload("AddPointArray")]
    [MethodImpl]
    public extern void AddPointArray(string name, Point[] value);

    /// <summary>Adds a Point array field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddPointArrayWithFormat")]
    [MethodImpl]
    public extern void AddPointArray(string name, Point[] value, LoggingFieldFormat format);

    /// <summary>Adds a Point array field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddPointArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddPointArray(
      string name,
      Point[] value,
      LoggingFieldFormat format,
      int tags);

    /// <summary>Adds a Size field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    [Overload("AddSize")]
    [MethodImpl]
    public extern void AddSize(string name, Size value);

    /// <summary>Adds a Size field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddSizeWithFormat")]
    [MethodImpl]
    public extern void AddSize(string name, Size value, LoggingFieldFormat format);

    /// <summary>Adds a Size field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddSizeWithFormatAndTags")]
    [MethodImpl]
    public extern void AddSize(string name, Size value, LoggingFieldFormat format, int tags);

    /// <summary>Adds a Size array field with the specified field name.</summary>
    /// <param name="name">The name of the field.</param>
    /// <param name="value">The value for the event field.</param>
    [Overload("AddSizeArray")]
    [MethodImpl]
    public extern void AddSizeArray(string name, Size[] value);

    /// <summary>Adds a Size array field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddSizeArrayWithFormat")]
    [MethodImpl]
    public extern void AddSizeArray(string name, Size[] value, LoggingFieldFormat format);

    /// <summary>Adds a Size array field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddSizeArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddSizeArray(
      string name,
      Size[] value,
      LoggingFieldFormat format,
      int tags);

    /// <summary>Adds a Rect field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    [Overload("AddRect")]
    [MethodImpl]
    public extern void AddRect(string name, Rect value);

    /// <summary>Adds a Rect field with the specified field name, and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    [Overload("AddRectWithFormat")]
    [MethodImpl]
    public extern void AddRect(string name, Rect value, LoggingFieldFormat format);

    /// <summary>Adds a Rect field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddRectWithFormatAndTags")]
    [MethodImpl]
    public extern void AddRect(string name, Rect value, LoggingFieldFormat format, int tags);

    /// <summary>Adds a Rect array field with the specified field name.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    [Overload("AddRectArray")]
    [MethodImpl]
    public extern void AddRectArray(string name, Rect[] value);

    /// <summary>Adds a Rect array field with the specified field name and format.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The value for the event field.</param>
    [Overload("AddRectArrayWithFormat")]
    [MethodImpl]
    public extern void AddRectArray(string name, Rect[] value, LoggingFieldFormat format);

    /// <summary>Adds a Rect array field with the specified field name, format, and tags.</summary>
    /// <param name="name">Name of the event field.</param>
    /// <param name="value">The value for the event field.</param>
    /// <param name="format">The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.</param>
    /// <param name="tags">The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).</param>
    [Overload("AddRectArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddRectArray(
      string name,
      Rect[] value,
      LoggingFieldFormat format,
      int tags);
  }
}
