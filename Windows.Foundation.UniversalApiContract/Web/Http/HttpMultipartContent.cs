// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpMultipartContent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  /// <summary>Provides HTTP content that uses the **multipart/*** MIME type.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IHttpMultipartContentFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpMultipartContent : 
    IHttpMultipartContent,
    IHttpContent,
    IClosable,
    IIterable<IHttpContent>,
    IStringable
  {
    /// <summary>Initializes a new instance of the HttpMultipartContent class with the specified MIME subtype.</summary>
    /// <param name="subtype">The MIME subtype of the multipart content.</param>
    [MethodImpl]
    public extern HttpMultipartContent(string subtype);

    /// <summary>Initializes a new instance of the HttpMultipartContent class with the specified MIME subtype and boundary string.</summary>
    /// <param name="subtype">The MIME subtype of the multipart content.</param>
    /// <param name="boundary">The boundary string for the multipart content.</param>
    [MethodImpl]
    public extern HttpMultipartContent(string subtype, string boundary);

    /// <summary>Initializes a new instance of the HttpMultipartContent class.</summary>
    [MethodImpl]
    public extern HttpMultipartContent();

    /// <summary>Add HTTP content to the HttpMultipartContent instance.</summary>
    /// <param name="content">The HTTP content to add to HttpMultipartContent.</param>
    [MethodImpl]
    public extern void Add(IHttpContent content);

    /// <summary>Get a collection of content headers set on the HttpMultipartContent.</summary>
    /// <returns>A collection of content headers set on the HttpMultipartContent.</returns>
    public extern HttpContentHeaderCollection Headers { [MethodImpl] get; }

    /// <summary>Serialize the HttpMultipartContent into memory as an asynchronous operation.</summary>
    /// <returns>The object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<ulong, ulong> BufferAllAsync();

    /// <summary>Serialize the HttpMultipartContent to a buffer as an asynchronous operation.</summary>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IBuffer, ulong> ReadAsBufferAsync();

    /// <summary>Serialize the HttpMultipartContent and return an input stream that represents the content as an asynchronous operation.</summary>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IInputStream, ulong> ReadAsInputStreamAsync();

    /// <summary>Serialize the HttpMultipartContent to a String as an asynchronous operation.</summary>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<string, ulong> ReadAsStringAsync();

    /// <summary>Determines whether the HttpMultipartContent has a valid length in bytes.</summary>
    /// <param name="length">The length in bytes of the HttpMultipartContent.</param>
    /// <returns>**true** if *length* is a valid length; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool TryComputeLength(out ulong length);

    /// <summary>Write the HttpMultipartContent to an output stream as an asynchronous operation.</summary>
    /// <param name="outputStream">The output stream to write to.</param>
    /// <returns>The object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<ulong, ulong> WriteToStreamAsync(
      IOutputStream outputStream);

    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public extern IIterator<IHttpContent> First();

    /// <summary>Returns a string that represents the current HttpMultipartContent object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
