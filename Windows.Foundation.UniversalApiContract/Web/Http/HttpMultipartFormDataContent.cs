// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpMultipartFormDataContent
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
  /// <summary>Provides HTTP content that uses the **multipart/form-data** MIME type.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IHttpMultipartFormDataContentFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpMultipartFormDataContent : 
    IHttpMultipartFormDataContent,
    IHttpContent,
    IClosable,
    IIterable<IHttpContent>,
    IStringable
  {
    /// <summary>Initializes a new instance of the HttpMultipartFormDataContent class with the specified boundary string.</summary>
    /// <param name="boundary">The boundary string for the multipart content.</param>
    [MethodImpl]
    public extern HttpMultipartFormDataContent(string boundary);

    /// <summary>Initializes a new instance of the HttpMultipartFormDataContent class.</summary>
    [MethodImpl]
    public extern HttpMultipartFormDataContent();

    /// <summary>Add HTTP content to the HttpMultipartFormDataContent instance.</summary>
    /// <param name="content">The HTTP content to add to HttpMultipartFormDataContent.</param>
    [Overload("Add")]
    [MethodImpl]
    public extern void Add(IHttpContent content);

    /// <summary>Add HTTP content with a specified name to the HttpMultipartFormDataContent instance.</summary>
    /// <param name="content">The HTTP content to add to HttpMultipartFormDataContent.</param>
    /// <param name="name">The name for the HTTP content to add to HttpMultipartFormDataContent.</param>
    [Overload("AddWithName")]
    [MethodImpl]
    public extern void Add(IHttpContent content, string name);

    /// <summary>Add HTTP content with a specified name from a file to the HttpMultipartFormDataContent instance.</summary>
    /// <param name="content">The HTTP content to add to HttpMultipartFormDataContent.</param>
    /// <param name="name">The name for the HTTP content to add to HttpMultipartFormDataContent.</param>
    /// <param name="fileName">The file name for the HTTP content to add to HttpMultipartFormDataContent.</param>
    [Overload("AddWithNameAndFileName")]
    [MethodImpl]
    public extern void Add(IHttpContent content, string name, string fileName);

    /// <summary>Get a collection of content headers set on the HttpMultipartFormDataContent.</summary>
    /// <returns>A collection of content headers set on the HttpMultipartFormDataContent.</returns>
    public extern HttpContentHeaderCollection Headers { [MethodImpl] get; }

    /// <summary>Serialize the HttpMultipartFormDataContent into memory as an asynchronous operation.</summary>
    /// <returns>The object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<ulong, ulong> BufferAllAsync();

    /// <summary>Serialize the HttpMultipartFormDataContent to a buffer as an asynchronous operation.</summary>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IBuffer, ulong> ReadAsBufferAsync();

    /// <summary>Serialize the HttpMultipartFormDataContent and return an input stream that represents the content as an asynchronous operation.</summary>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IInputStream, ulong> ReadAsInputStreamAsync();

    /// <summary>Serialize the HttpMultipartFormDataContent to a String as an asynchronous operation.</summary>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<string, ulong> ReadAsStringAsync();

    /// <summary>Determines whether the HttpMultipartFormDataContent has a valid length in bytes.</summary>
    /// <param name="length">The length in bytes of the HttpMultipartFormDataContent.</param>
    /// <returns>**true** if *length* is a valid length; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool TryComputeLength(out ulong length);

    /// <summary>Write the HttpMultipartFormDataContent to an output stream as an asynchronous operation.</summary>
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

    /// <summary>Returns a string that represents the current HttpMultipartFormDataContent object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
