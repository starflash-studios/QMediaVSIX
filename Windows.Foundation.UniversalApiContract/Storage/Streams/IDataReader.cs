// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IDataReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Provides read access to an input stream.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3803512873, 46273, 17172, 164, 184, 251, 129, 58, 47, 39, 94)]
  public interface IDataReader
  {
    /// <summary>Gets the size of the buffer that has not been read.</summary>
    /// <returns>The size of the buffer that has not been read, in bytes.</returns>
    uint UnconsumedBufferLength { get; }

    /// <summary>Gets or sets the Unicode character encoding for the input stream.</summary>
    /// <returns>One of the enumeration values.</returns>
    UnicodeEncoding UnicodeEncoding { get; set; }

    /// <summary>Gets or sets the byte order of the data in the input stream.</summary>
    /// <returns>One of the enumeration values.</returns>
    ByteOrder ByteOrder { get; set; }

    /// <summary>Gets or sets the read options for the input stream.</summary>
    /// <returns>One of the enumeration values.</returns>
    InputStreamOptions InputStreamOptions { get; set; }

    /// <summary>Reads a byte value from the input stream.</summary>
    /// <returns>The value.</returns>
    byte ReadByte();

    /// <summary>Reads an array of byte values from the input stream.</summary>
    /// <param name="value">The array of values.</param>
    void ReadBytes([Out] byte[] value);

    /// <summary>Reads a buffer from the input stream.</summary>
    /// <param name="length">The length of the buffer, in bytes.</param>
    /// <returns>The buffer.</returns>
    IBuffer ReadBuffer(uint length);

    /// <summary>Reads a Boolean value from the input stream.</summary>
    /// <returns>The value.</returns>
    bool ReadBoolean();

    /// <summary>Reads a GUID value from the input stream.</summary>
    /// <returns>The value.</returns>
    Guid ReadGuid();

    /// <summary>Reads a 16-bit integer value from the input stream.</summary>
    /// <returns>The value.</returns>
    short ReadInt16();

    /// <summary>Reads a 32-bit integer value from the input stream.</summary>
    /// <returns>The value.</returns>
    int ReadInt32();

    /// <summary>Reads a 64-bit integer value from the input stream.</summary>
    /// <returns>The value.</returns>
    long ReadInt64();

    /// <summary>Reads a 16-bit unsigned integer from the input stream.</summary>
    /// <returns>The value.</returns>
    ushort ReadUInt16();

    /// <summary>Reads a 32-bit unsigned integer from the input stream.</summary>
    /// <returns>The value.</returns>
    uint ReadUInt32();

    /// <summary>Reads a 64-bit unsigned integer from the input stream.</summary>
    /// <returns>The value.</returns>
    ulong ReadUInt64();

    /// <summary>Reads a floating-point value from the input stream.</summary>
    /// <returns>The value.</returns>
    float ReadSingle();

    /// <summary>Reads a floating-point value from the input stream.</summary>
    /// <returns>The value.</returns>
    double ReadDouble();

    /// <summary>Reads a string value from the input stream.</summary>
    /// <param name="codeUnitCount">The length of the string.</param>
    /// <returns>The value.</returns>
    string ReadString(uint codeUnitCount);

    /// <summary>Reads a date and time value from the input stream.</summary>
    /// <returns>The value.</returns>
    global::Windows.Foundation.DateTime ReadDateTime();

    /// <summary>Reads a time interval from the input stream.</summary>
    /// <returns>The value.</returns>
    global::Windows.Foundation.TimeSpan ReadTimeSpan();

    /// <summary>Loads data from the input stream.</summary>
    /// <param name="count">The count of bytes to load into the intermediate buffer.</param>
    /// <returns>The asynchronous operation.</returns>
    [RemoteAsync]
    DataReaderLoadOperation LoadAsync(uint count);

    /// <summary>Detaches a buffer that was previously attached to the reader.</summary>
    /// <returns>The detached buffer.</returns>
    IBuffer DetachBuffer();

    /// <summary>Detaches a stream that was previously attached to the reader.</summary>
    /// <returns>The detached stream.</returns>
    IInputStream DetachStream();
  }
}
