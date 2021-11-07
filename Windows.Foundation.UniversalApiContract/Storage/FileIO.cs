// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileIO
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage
{
  /// <summary>Provides helper methods for reading and writing files that are represented by objects of type IStorageFile.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IFileIOStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public static class FileIO
  {
    /// <summary>Reads the contents of the specified file and returns text.</summary>
    /// <param name="file">The file to read.</param>
    /// <returns>When this method completes successfully, it returns the contents of the file as a text string.</returns>
    [RemoteAsync]
    [Overload("ReadTextAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<string> ReadTextAsync(IStorageFile file);

    /// <summary>Reads the contents of the specified file using the specified character encoding and returns text.</summary>
    /// <param name="file">The file to read.</param>
    /// <param name="encoding">The character encoding to use.</param>
    /// <returns>When this method completes successfully, it returns the contents of the file as a text string.</returns>
    [Overload("ReadTextWithEncodingAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> ReadTextAsync(
      IStorageFile file,
      UnicodeEncoding encoding);

    /// <summary>Writes text to the specified file.</summary>
    /// <param name="file">The file that the text is written to.</param>
    /// <param name="contents">The text to write.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [Overload("WriteTextAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction WriteTextAsync(IStorageFile file, string contents);

    /// <summary>Writes text to the specified file using the specified character encoding.</summary>
    /// <param name="file">The file that the text is written to.</param>
    /// <param name="contents">The text to write.</param>
    /// <param name="encoding">The character encoding of the file.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [Overload("WriteTextWithEncodingAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction WriteTextAsync(
      IStorageFile file,
      string contents,
      UnicodeEncoding encoding);

    /// <summary>Appends text to the specified file.</summary>
    /// <param name="file">The file that the text is appended to.</param>
    /// <param name="contents">The text to append.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [Overload("AppendTextAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction AppendTextAsync(
      IStorageFile file,
      string contents);

    /// <summary>Appends text to the specified file using the specified character encoding.</summary>
    /// <param name="file">The file that the text is appended to.</param>
    /// <param name="contents">The text to append.</param>
    /// <param name="encoding">The character encoding of the file.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [Overload("AppendTextWithEncodingAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction AppendTextAsync(
      IStorageFile file,
      string contents,
      UnicodeEncoding encoding);

    /// <summary>Reads the contents of the specified file and returns lines of text.</summary>
    /// <param name="file">The file to read.</param>
    /// <returns>When this method completes successfully, it returns the contents of the file as a list (type IVector ) of lines of text. Each line of text in the list is represented by a String object.</returns>
    [RemoteAsync]
    [Overload("ReadLinesAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVector<string>> ReadLinesAsync(
      IStorageFile file);

    /// <summary>Reads the contents of the specified file using the specified character encoding and returns lines of text.</summary>
    /// <param name="file">The file to read.</param>
    /// <param name="encoding">The character encoding to use.</param>
    /// <returns>When this method completes successfully, it returns the contents of the file as a list (type IVector ) of lines of text. Each line of text in the list is represented by a String object.</returns>
    [Overload("ReadLinesWithEncodingAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVector<string>> ReadLinesAsync(
      IStorageFile file,
      UnicodeEncoding encoding);

    [Overload("WriteLinesAsync")]
    [MethodImpl]
    public static extern IAsyncAction WriteLinesAsync(
      IStorageFile file,
      IIterable<string> lines);

    [Overload("WriteLinesWithEncodingAsync")]
    [MethodImpl]
    public static extern IAsyncAction WriteLinesAsync(
      IStorageFile file,
      IIterable<string> lines,
      UnicodeEncoding encoding);

    [Overload("AppendLinesAsync")]
    [MethodImpl]
    public static extern IAsyncAction AppendLinesAsync(
      IStorageFile file,
      IIterable<string> lines);

    [Overload("AppendLinesWithEncodingAsync")]
    [MethodImpl]
    public static extern IAsyncAction AppendLinesAsync(
      IStorageFile file,
      IIterable<string> lines,
      UnicodeEncoding encoding);

    /// <summary>Reads the contents of the specified file and returns a buffer.</summary>
    /// <param name="file">The file to read.</param>
    /// <returns>When this method completes, it returns an object (type IBuffer ) that represents the contents of the file.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IBuffer> ReadBufferAsync(
      IStorageFile file);

    /// <summary>Writes data from a buffer to the specified file.</summary>
    /// <param name="file">The file that the buffer of data is written to.</param>
    /// <param name="buffer">The buffer that contains the data to write.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction WriteBufferAsync(
      IStorageFile file,
      IBuffer buffer);

    /// <summary>Writes an array of bytes of data to the specified file.</summary>
    /// <param name="file">The file that the byte is written to.</param>
    /// <param name="buffer">The array of bytes to write.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction WriteBytesAsync(IStorageFile file, byte[] buffer);
  }
}
