// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.DataReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Reads data from an input stream.</summary>
  [Activatable(typeof (IDataReaderFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IDataReaderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772166)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DataReader : IDataReader, IClosable
  {
    /// <summary>Creates and initializes a new instance of the data reader.</summary>
    /// <param name="inputStream">The input stream.</param>
    [MethodImpl]
    public extern DataReader(IInputStream inputStream);

    /// <summary>Gets the size of the buffer that has not been read.</summary>
    /// <returns>The size of the buffer that has not been read, in bytes.</returns>
    public extern uint UnconsumedBufferLength { [MethodImpl] get; }

    /// <summary>Gets or sets the Unicode character encoding for the input stream.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern UnicodeEncoding UnicodeEncoding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the byte order of the data in the input stream.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ByteOrder ByteOrder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the read options for the input stream.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern InputStreamOptions InputStreamOptions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Reads a byte value from the input stream.</summary>
    /// <returns>The value.</returns>
    [MethodImpl]
    public extern byte ReadByte();

    /// <summary>Reads an array of byte values from the input stream.</summary>
    /// <param name="value">The array that receives the byte values.</param>
    [MethodImpl]
    public extern void ReadBytes([Out] byte[] value);

    /// <summary>Reads a buffer from the input stream.</summary>
    /// <param name="length">The length of the buffer, in bytes.</param>
    /// <returns>The buffer.</returns>
    [MethodImpl]
    public extern IBuffer ReadBuffer(uint length);

    /// <summary>Reads a Boolean value from the input stream.</summary>
    /// <returns>The value.</returns>
    [MethodImpl]
    public extern bool ReadBoolean();

    /// <summary>Reads a GUID value from the input stream.</summary>
    /// <returns>The value.</returns>
    [MethodImpl]
    public extern Guid ReadGuid();

    /// <summary>Reads a 16-bit integer value from the input stream.</summary>
    /// <returns>The value.</returns>
    [MethodImpl]
    public extern short ReadInt16();

    /// <summary>Reads a 32-bit integer value from the input stream.</summary>
    /// <returns>The value.</returns>
    [MethodImpl]
    public extern int ReadInt32();

    /// <summary>Reads a 64-bit integer value from the input stream.</summary>
    /// <returns>The value.</returns>
    [MethodImpl]
    public extern long ReadInt64();

    /// <summary>Reads a 16-bit unsigned integer from the input stream.</summary>
    /// <returns>The value.</returns>
    [MethodImpl]
    public extern ushort ReadUInt16();

    /// <summary>Reads a 32-bit unsigned integer from the input stream.</summary>
    /// <returns>The value.</returns>
    [MethodImpl]
    public extern uint ReadUInt32();

    /// <summary>Reads a 64-bit unsigned integer from the input stream.</summary>
    /// <returns>The value.</returns>
    [MethodImpl]
    public extern ulong ReadUInt64();

    /// <summary>Reads a floating-point value from the input stream.</summary>
    /// <returns>The value.</returns>
    [MethodImpl]
    public extern float ReadSingle();

    /// <summary>Reads a floating-point value from the input stream.</summary>
    /// <returns>The value.</returns>
    [MethodImpl]
    public extern double ReadDouble();

    /// <summary>Reads a string value from the input stream.</summary>
    /// <param name="codeUnitCount">The length of the string.</param>
    /// <returns>The value.</returns>
    [MethodImpl]
    public extern string ReadString(uint codeUnitCount);

    /// <summary>Reads a date and time value from the input stream.</summary>
    /// <returns>The value.</returns>
    [MethodImpl]
    public extern global::Windows.Foundation.DateTime ReadDateTime();

    /// <summary>Reads a time-interval value from the input stream.</summary>
    /// <returns>The value.</returns>
    [MethodImpl]
    public extern global::Windows.Foundation.TimeSpan ReadTimeSpan();

    /// <summary>Loads data from the input stream.</summary>
    /// <param name="count">The count of bytes to load into the intermediate buffer.</param>
    /// <returns>The asynchronous load data request.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern DataReaderLoadOperation LoadAsync(uint count);

    /// <summary>Detaches the buffer that is associated with the data reader. This is useful if you want to retain the buffer after you dispose the data reader.</summary>
    /// <returns>The detached buffer.</returns>
    [MethodImpl]
    public extern IBuffer DetachBuffer();

    /// <summary>Detaches the stream that is associated with the data reader.</summary>
    /// <returns>The detached stream.</returns>
    [MethodImpl]
    public extern IInputStream DetachStream();

    [MethodImpl]
    public extern void Close();

    /// <summary>Creates a new instance of the data reader with data from the specified buffer.</summary>
    /// <param name="buffer">The buffer.</param>
    /// <returns>The data reader.</returns>
    [MethodImpl]
    public static extern DataReader FromBuffer(IBuffer buffer);
  }
}
