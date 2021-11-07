// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpContent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  /// <summary>Provides a base interface for an HTTP entity body and content headers.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1796514881, 64423, 19410, 175, 10, 131, 157, 231, 194, 149, 218)]
  public interface IHttpContent : IClosable
  {
    /// <summary>Get a collection of content headers set on the IHttpContent.</summary>
    /// <returns>A collection of content headers set on the IHttpContent.</returns>
    HttpContentHeaderCollection Headers { get; }

    /// <summary>Serialize the HTTP content into memory as an asynchronous operation.</summary>
    /// <returns>The object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    IAsyncOperationWithProgress<ulong, ulong> BufferAllAsync();

    /// <summary>Serialize the HTTP content to a buffer as an asynchronous operation.</summary>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    IAsyncOperationWithProgress<IBuffer, ulong> ReadAsBufferAsync();

    /// <summary>Serialize the HTTP content and return an input stream that represents the content as an asynchronous operation.</summary>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    IAsyncOperationWithProgress<IInputStream, ulong> ReadAsInputStreamAsync();

    /// <summary>Serialize the HTTP content to a String as an asynchronous operation.</summary>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    IAsyncOperationWithProgress<string, ulong> ReadAsStringAsync();

    /// <summary>Determines whether the HTTP content has a valid length in bytes.</summary>
    /// <param name="length">The length in bytes of the HTTP content.</param>
    /// <returns>**true** if *length* is a valid length; otherwise, **false**.</returns>
    bool TryComputeLength(out ulong length);

    /// <summary>Write the HTTP content to an output stream as an asynchronous operation.</summary>
    /// <param name="outputStream">The output stream to write to.</param>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    IAsyncOperationWithProgress<ulong, ulong> WriteToStreamAsync(
      IOutputStream outputStream);
  }
}
