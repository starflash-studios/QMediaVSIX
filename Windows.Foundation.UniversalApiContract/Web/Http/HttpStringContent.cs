// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpStringContent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  /// <summary>Provides HTTP content that uses a string.</summary>
  [DualApiPartition(version = 100859904)]
  [Activatable(typeof (IHttpStringContentFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class HttpStringContent : IHttpContent, IClosable, IStringable
  {
    /// <summary>Initializes a new instance of the HttpStringContent class with the specified content.</summary>
    /// <param name="content">The content used to initialize the HttpStringContent.</param>
    [MethodImpl]
    public extern HttpStringContent(string content);

    /// <summary>Initializes a new instance of the HttpStringContent class with the specified content and encoding.</summary>
    /// <param name="content">The content used to initialize the HttpStringContent.</param>
    /// <param name="encoding">The encoding to use for the content.</param>
    [MethodImpl]
    public extern HttpStringContent(string content, UnicodeEncoding encoding);

    /// <summary>Initializes a new instance of the HttpStringContent class with the specified content, encoding, and media type.</summary>
    /// <param name="content">The content used to initialize the HttpStringContent.</param>
    /// <param name="encoding">The encoding to use for the content.</param>
    /// <param name="mediaType">The media type to use for the content.</param>
    [MethodImpl]
    public extern HttpStringContent(string content, UnicodeEncoding encoding, string mediaType);

    /// <summary>Get a collection of content headers set on the HttpStringContent.</summary>
    /// <returns>A collection of content headers set on the HttpStringContent.</returns>
    public extern HttpContentHeaderCollection Headers { [MethodImpl] get; }

    /// <summary>Serialize the HttpStringContent into memory as an asynchronous operation.</summary>
    /// <returns>The object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<ulong, ulong> BufferAllAsync();

    /// <summary>Serialize the HttpStringContent to a buffer as an asynchronous operation.</summary>
    /// <returns>The object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IBuffer, ulong> ReadAsBufferAsync();

    /// <summary>Serialize the HttpStringContent and return an input stream that represents the content as an asynchronous operation.</summary>
    /// <returns>The object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IInputStream, ulong> ReadAsInputStreamAsync();

    /// <summary>Serialize the HttpStringContent to a String as an asynchronous operation.</summary>
    /// <returns>The object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<string, ulong> ReadAsStringAsync();

    /// <summary>Compute the HttpStringContent length in bytes.</summary>
    /// <param name="length">The length in bytes of the HttpStringContent.</param>
    /// <returns>**true** if *length* is a valid length; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool TryComputeLength(out ulong length);

    /// <summary>Write the HttpStringContent to an output stream as an asynchronous operation.</summary>
    /// <param name="outputStream">The output stream to write to.</param>
    /// <returns>The object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<ulong, ulong> WriteToStreamAsync(
      IOutputStream outputStream);

    [MethodImpl]
    public extern void Close();

    /// <summary>Returns a string that represents the current HttpStringContent object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
