// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpFormUrlEncodedContent
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
  /// <summary>Provides HTTP content that uses name/value data encoded with the **application/x-www-form-urlencoded** MIME type.</summary>
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IHttpFormUrlEncodedContentFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HttpFormUrlEncodedContent : IHttpContent, IClosable, IStringable
  {
    [MethodImpl]
    public extern HttpFormUrlEncodedContent(IIterable<IKeyValuePair<string, string>> content);

    /// <summary>Get a collection of content headers set on the HttpFormUrlEncodedContent.</summary>
    /// <returns>A collection of content headers set on the HttpFormUrlEncodedContent.</returns>
    public extern HttpContentHeaderCollection Headers { [MethodImpl] get; }

    /// <summary>Serialize the HttpFormUrlEncodedContent into memory as an asynchronous operation.</summary>
    /// <returns>The object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<ulong, ulong> BufferAllAsync();

    /// <summary>Serialize the HttpFormUrlEncodedContent to a buffer as an asynchronous operation.</summary>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IBuffer, ulong> ReadAsBufferAsync();

    /// <summary>Serialize the HttpFormUrlEncodedContent and return an input stream that represents the content as an asynchronous operation.</summary>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IInputStream, ulong> ReadAsInputStreamAsync();

    /// <summary>Serialize the HttpFormUrlEncodedContent to a String as an asynchronous operation.</summary>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<string, ulong> ReadAsStringAsync();

    /// <summary>Computes the HttpFormUrlEncodedContent length in bytes.</summary>
    /// <param name="length">The length in bytes of the HttpFormUrlEncodedContent.</param>
    /// <returns>**true** if *length* is a valid length; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool TryComputeLength(out ulong length);

    /// <summary>Write the HttpFormUrlEncodedContent to an output stream as an asynchronous operation.</summary>
    /// <param name="outputStream">The output stream to write to.</param>
    /// <returns>The object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<ulong, ulong> WriteToStreamAsync(
      IOutputStream outputStream);

    [MethodImpl]
    public extern void Close();

    /// <summary>Returns a string that represents the current HttpFormUrlEncodedContent object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
