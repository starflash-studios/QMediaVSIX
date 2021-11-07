// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IRandomAccessStream
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Supports random access of data in input and output streams.</summary>
  [Guid(2421821409, 48211, 4575, 140, 73, 0, 30, 79, 198, 134, 218)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IRandomAccessStream : IClosable, IInputStream, IOutputStream
  {
    /// <summary>Gets or sets the size of the random access stream.</summary>
    /// <returns>The size of the stream.</returns>
    ulong Size { get; set; }

    /// <summary>Returns an input stream at a specified location in a stream.</summary>
    /// <param name="position">The location in the stream at which to begin.</param>
    /// <returns>The input stream.</returns>
    IInputStream GetInputStreamAt(ulong position);

    /// <summary>Returns an output stream at a specified location in a stream.</summary>
    /// <param name="position">The location in the output stream at which to begin.</param>
    /// <returns>The output stream.</returns>
    IOutputStream GetOutputStreamAt(ulong position);

    /// <summary>Gets the byte offset of the stream.</summary>
    /// <returns>The number of bytes from the start of the stream.</returns>
    ulong Position { get; }

    /// <summary>Sets the position of the stream to the specified value.</summary>
    /// <param name="position">The new position of the stream.</param>
    void Seek(ulong position);

    /// <summary>Creates a new instance of a IRandomAccessStream over the same resource as the current stream.</summary>
    /// <returns>The new stream. The initial, internal position of the stream is 0.</returns>
    IRandomAccessStream CloneStream();

    /// <summary>Gets a value that indicates whether the stream can be read from.</summary>
    /// <returns>True if the stream can be read from. Otherwise, false.</returns>
    bool CanRead { get; }

    /// <summary>Gets a value that indicates whether the stream can be written to.</summary>
    /// <returns>True if the stream can be written to. Otherwise, false.</returns>
    bool CanWrite { get; }
  }
}
