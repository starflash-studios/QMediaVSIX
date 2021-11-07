// Decompiled with JetBrains decompiler
// Type: Windows.Storage.PathIO
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
  /// <summary>Provides helper methods for reading and writing a file using the absolute path or Uniform Resource Identifier (URI) of the file.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPathIOStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public static class PathIO
  {
    /// <summary>Reads the contents of the file at the specified path or Uniform Resource Identifier (URI) and returns text.</summary>
    /// <param name="absolutePath">The path of the file to read.</param>
    /// <returns>When this method completes successfully, it returns the contents of the file as a text string.</returns>
    [Overload("ReadTextAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> ReadTextAsync(string absolutePath);

    /// <summary>Reads the contents of the file at the specified path or Uniform Resource Identifier (URI) using the specified character encoding and returns text.</summary>
    /// <param name="absolutePath">The path of the file to read.</param>
    /// <param name="encoding">The character encoding of the file.</param>
    /// <returns>When this method completes successfully, it returns the contents of the file as a text string.</returns>
    [RemoteAsync]
    [Overload("ReadTextWithEncodingAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<string> ReadTextAsync(
      string absolutePath,
      UnicodeEncoding encoding);

    /// <summary>Writes text to the file at the specified path or Uniform Resource Identifier (URI).</summary>
    /// <param name="absolutePath">The path of the file that the text is written to.</param>
    /// <param name="contents">The text to write.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [Overload("WriteTextAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction WriteTextAsync(
      string absolutePath,
      string contents);

    /// <summary>Writes text to the file at the specified path or Uniform Resource Identifier (URI) using the specified character encoding.</summary>
    /// <param name="absolutePath">The path of the file that the text is written to.</param>
    /// <param name="contents">The text to write.</param>
    /// <param name="encoding">The character encoding of the file.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [Overload("WriteTextWithEncodingAsync")]
    [MethodImpl]
    public static extern IAsyncAction WriteTextAsync(
      string absolutePath,
      string contents,
      UnicodeEncoding encoding);

    /// <summary>Appends text to the file at the specified path or Uniform Resource Identifier (URI).</summary>
    /// <param name="absolutePath">The path of the file that the text is appended to.</param>
    /// <param name="contents">The text to append.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [Overload("AppendTextAsync")]
    [MethodImpl]
    public static extern IAsyncAction AppendTextAsync(
      string absolutePath,
      string contents);

    /// <summary>Appends text to the file at the specified path or Uniform Resource Identifier (URI) using the specified character encoding.</summary>
    /// <param name="absolutePath">The path of the file that the text is appended to.</param>
    /// <param name="contents">The text to append.</param>
    /// <param name="encoding">The character encoding of the file.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [Overload("AppendTextWithEncodingAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction AppendTextAsync(
      string absolutePath,
      string contents,
      UnicodeEncoding encoding);

    /// <summary>Reads the contents of the file at the specified path or Uniform Resource Identifier (URI) and returns lines of text.</summary>
    /// <param name="absolutePath">The path of the file to read.</param>
    /// <returns>When this method completes successfully, it returns the contents of the file as a list (type IVector ) of lines of text. Each line of text in the list is represented by a String object.</returns>
    [RemoteAsync]
    [Overload("ReadLinesAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVector<string>> ReadLinesAsync(
      string absolutePath);

    /// <summary>Reads the contents of the file at the specified path or Uniform Resource Identifier (URI) using the specified character encoding and returns lines of text.</summary>
    /// <param name="absolutePath">The path of the file to read.</param>
    /// <param name="encoding">The character encoding of the file.</param>
    /// <returns>When this method completes successfully, it returns the contents of the file as a list (type IVector ) of lines of text. Each line of text in the list is represented by a String object.</returns>
    [RemoteAsync]
    [Overload("ReadLinesWithEncodingAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVector<string>> ReadLinesAsync(
      string absolutePath,
      UnicodeEncoding encoding);

    [Overload("WriteLinesAsync")]
    [MethodImpl]
    public static extern IAsyncAction WriteLinesAsync(
      string absolutePath,
      IIterable<string> lines);

    [Overload("WriteLinesWithEncodingAsync")]
    [MethodImpl]
    public static extern IAsyncAction WriteLinesAsync(
      string absolutePath,
      IIterable<string> lines,
      UnicodeEncoding encoding);

    [Overload("AppendLinesAsync")]
    [MethodImpl]
    public static extern IAsyncAction AppendLinesAsync(
      string absolutePath,
      IIterable<string> lines);

    [Overload("AppendLinesWithEncodingAsync")]
    [MethodImpl]
    public static extern IAsyncAction AppendLinesAsync(
      string absolutePath,
      IIterable<string> lines,
      UnicodeEncoding encoding);

    /// <summary>Reads the contents of the file at the specified path or Uniform Resource Identifier (URI) and returns a buffer.</summary>
    /// <param name="absolutePath">The path of the file to read.</param>
    /// <returns>When this method completes, it returns an object (type IBuffer ) that represents the contents of the file.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IBuffer> ReadBufferAsync(
      string absolutePath);

    /// <summary>Writes data from a buffer to the file at the specified path or Uniform Resource Identifier (URI).</summary>
    /// <param name="absolutePath">The path of the file that the data is written to.</param>
    /// <param name="buffer">The buffer that contains the data to write.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction WriteBufferAsync(
      string absolutePath,
      IBuffer buffer);

    /// <summary>Writes a single byte of data to the file at the specified path or Uniform Resource Identifier (URI).</summary>
    /// <param name="absolutePath">The path of the file that the byte is written to.</param>
    /// <param name="buffer">An array of bytes to write.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction WriteBytesAsync(
      string absolutePath,
      byte[] buffer);
  }
}
