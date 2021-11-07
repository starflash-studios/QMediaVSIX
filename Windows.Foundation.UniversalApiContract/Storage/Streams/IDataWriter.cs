// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IDataWriter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Provides write access to an output stream.</summary>
  [Guid(1689817701, 54081, 18722, 179, 138, 221, 74, 248, 128, 140, 78)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IDataWriter
  {
    /// <summary>Gets the size of the buffer that has not been used.</summary>
    /// <returns>The available buffer length, in bytes.</returns>
    uint UnstoredBufferLength { get; }

    /// <summary>Gets or sets the Unicode character encoding for the output stream.</summary>
    /// <returns>One of the enumeration values.</returns>
    UnicodeEncoding UnicodeEncoding { get; set; }

    /// <summary>Gets or sets the byte order of the data in the output stream.</summary>
    /// <returns>One of the enumeration values.</returns>
    ByteOrder ByteOrder { get; set; }

    /// <summary>Writes a byte value to the output stream.</summary>
    /// <param name="value">The value.</param>
    void WriteByte(byte value);

    /// <summary>Writes an array of byte values to the output stream.</summary>
    /// <param name="value">The array of values.</param>
    void WriteBytes(byte[] value);

    /// <summary>Writes a number of bytes from a buffer to the output stream.</summary>
    /// <param name="buffer">The buffer.</param>
    [Overload("WriteBuffer")]
    void WriteBuffer(IBuffer buffer);

    /// <summary>Writes a range of bytes from a buffer to the output stream.</summary>
    /// <param name="buffer">The buffer.</param>
    /// <param name="start">The starting byte tobe written.</param>
    /// <param name="count">The number of bytes to write.</param>
    [Overload("WriteBufferRange")]
    void WriteBuffer(IBuffer buffer, uint start, uint count);

    /// <summary>Writes a Boolean value to the output stream.</summary>
    /// <param name="value">The value.</param>
    void WriteBoolean(bool value);

    /// <summary>Writes a GUID value to the output stream.</summary>
    /// <param name="value">The value to write.</param>
    void WriteGuid(Guid value);

    /// <summary>Writes a 16-bit integer value to the output stream.</summary>
    /// <param name="value">The value.</param>
    void WriteInt16(short value);

    /// <summary>Writes a 32-bit integer value to the output stream.</summary>
    /// <param name="value">The value.</param>
    void WriteInt32(int value);

    /// <summary>Writes a 64-bit integer value to the output stream.</summary>
    /// <param name="value">The value.</param>
    void WriteInt64(long value);

    /// <summary>Writes a 16-bit unsigned integer value to the output stream.</summary>
    /// <param name="value">The value.</param>
    void WriteUInt16(ushort value);

    /// <summary>Writes a 32-bit unsigned integer value to the output stream.</summary>
    /// <param name="value">The value.</param>
    void WriteUInt32(uint value);

    /// <summary>Writes a 64-bit unsigned integer value to the output stream.</summary>
    /// <param name="value">The value.</param>
    void WriteUInt64(ulong value);

    /// <summary>Write a floating-point value to the output stream.</summary>
    /// <param name="value">The value to write.</param>
    void WriteSingle(float value);

    /// <summary>Writes a floating-point value to the output stream.</summary>
    /// <param name="value">The value to write.</param>
    void WriteDouble(double value);

    void WriteDateTime(global::Windows.Foundation.DateTime value);

    void WriteTimeSpan(global::Windows.Foundation.TimeSpan value);

    /// <summary>Writes a string value to the output stream.</summary>
    /// <param name="value">The value to write.</param>
    /// <returns>The length of the string.</returns>
    uint WriteString(string value);

    /// <summary>Gets the size of a string.</summary>
    /// <param name="value">The string.</param>
    /// <returns>The size of the string, in bytes.</returns>
    uint MeasureString(string value);

    /// <summary>Commits data in the buffer to a backing store.</summary>
    /// <returns>The asynchronous store data operation.</returns>
    [RemoteAsync]
    DataWriterStoreOperation StoreAsync();

    /// <summary>Flushes data asynchronously.</summary>
    /// <returns>The stream flush operation.</returns>
    [RemoteAsync]
    IAsyncOperation<bool> FlushAsync();

    /// <summary>Detaches a buffer that was previously attached to the writer.</summary>
    /// <returns>The detached buffer.</returns>
    IBuffer DetachBuffer();

    /// <summary>Detaches a stream that was previously attached to the writer.</summary>
    /// <returns>The detached stream.</returns>
    IOutputStream DetachStream();
  }
}
