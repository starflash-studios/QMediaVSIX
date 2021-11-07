// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.DataWriter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Writes data to an output stream.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772166)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IDataWriterFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DataWriter : IDataWriter, IClosable
  {
    /// <summary>Creates and initializes a new instance of the data writer to an output stream.</summary>
    /// <param name="outputStream">The new output stream instance.</param>
    [MethodImpl]
    public extern DataWriter(IOutputStream outputStream);

    /// <summary>Creates and initializes a new instance of the data writer.</summary>
    [MethodImpl]
    public extern DataWriter();

    /// <summary>Gets the size of the buffer that has not been used.</summary>
    /// <returns>The size of the buffer that has not been used, in bytes.</returns>
    public extern uint UnstoredBufferLength { [MethodImpl] get; }

    /// <summary>Gets or sets the Unicode character encoding for the output stream.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern UnicodeEncoding UnicodeEncoding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the byte order of the data in the output stream.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ByteOrder ByteOrder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Writes a byte value to the output stream.</summary>
    /// <param name="value">The value.</param>
    [MethodImpl]
    public extern void WriteByte(byte value);

    /// <summary>Writes an array of byte values to the output stream.</summary>
    /// <param name="value">The array of values.</param>
    [MethodImpl]
    public extern void WriteBytes(byte[] value);

    /// <summary>Writes the contents of the specified buffer to the output stream.</summary>
    /// <param name="buffer">The buffer.</param>
    [Overload("WriteBuffer")]
    [MethodImpl]
    public extern void WriteBuffer(IBuffer buffer);

    /// <summary>Writes the specified bytes from a buffer to the output stream.</summary>
    /// <param name="buffer">The buffer.</param>
    /// <param name="start">The starting byte.</param>
    /// <param name="count">The number of bytes to write.</param>
    [Overload("WriteBufferRange")]
    [MethodImpl]
    public extern void WriteBuffer(IBuffer buffer, uint start, uint count);

    /// <summary>Writes a Boolean value to the output stream.</summary>
    /// <param name="value">The value.</param>
    [MethodImpl]
    public extern void WriteBoolean(bool value);

    /// <summary>Writes a GUID value to the output stream.</summary>
    /// <param name="value">The value.</param>
    [MethodImpl]
    public extern void WriteGuid(Guid value);

    /// <summary>Writes a 16-bit integer value to the output stream.</summary>
    /// <param name="value">The value.</param>
    [MethodImpl]
    public extern void WriteInt16(short value);

    /// <summary>Writes a 32-bit integer value to the output stream.</summary>
    /// <param name="value">The value.</param>
    [MethodImpl]
    public extern void WriteInt32(int value);

    /// <summary>Writes a 64-bit integer value to the output stream.</summary>
    /// <param name="value">The value.</param>
    [MethodImpl]
    public extern void WriteInt64(long value);

    /// <summary>Writes a 16-bit unsigned integer value to the output stream.</summary>
    /// <param name="value">The value.</param>
    [MethodImpl]
    public extern void WriteUInt16(ushort value);

    /// <summary>Writes a 32-bit unsigned integer value to the output stream.</summary>
    /// <param name="value">The value.</param>
    [MethodImpl]
    public extern void WriteUInt32(uint value);

    /// <summary>Writes a 64-bit unsigned integer value to the output stream.</summary>
    /// <param name="value">The value.</param>
    [MethodImpl]
    public extern void WriteUInt64(ulong value);

    /// <summary>Writes a floating-point value to the output stream.</summary>
    /// <param name="value">The value.</param>
    [MethodImpl]
    public extern void WriteSingle(float value);

    /// <summary>Writes a floating-point value to the output stream.</summary>
    /// <param name="value">The value.</param>
    [MethodImpl]
    public extern void WriteDouble(double value);

    [MethodImpl]
    public extern void WriteDateTime(global::Windows.Foundation.DateTime value);

    [MethodImpl]
    public extern void WriteTimeSpan(global::Windows.Foundation.TimeSpan value);

    /// <summary>Writes a string value to the output stream.</summary>
    /// <param name="value">The value.</param>
    /// <returns>The length of the string, in bytes.</returns>
    [MethodImpl]
    public extern uint WriteString(string value);

    /// <summary>Gets the size of a string.</summary>
    /// <param name="value">The string.</param>
    /// <returns>The size of the string, in bytes.</returns>
    [MethodImpl]
    public extern uint MeasureString(string value);

    /// <summary>Commits data in the buffer to the output stream.  This method should only be called when the DataWriter is writing into a stream; it will fail when the underlying store is a buffer.</summary>
    /// <returns>The asynchronous store data operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern DataWriterStoreOperation StoreAsync();

    /// <summary>Flushes data asynchronously.</summary>
    /// <returns>The stream flush operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> FlushAsync();

    /// <summary>Detaches the buffer that is associated with the data writer.</summary>
    /// <returns>The detached buffer.</returns>
    [MethodImpl]
    public extern IBuffer DetachBuffer();

    /// <summary>Detaches the stream that is associated with the data writer.</summary>
    /// <returns>The detached stream.</returns>
    [MethodImpl]
    public extern IOutputStream DetachStream();

    [MethodImpl]
    public extern void Close();
  }
}
