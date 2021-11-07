// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpBufferContent
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
  /// <summary>Provides HTTP content that uses a buffer.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IHttpBufferContentFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class HttpBufferContent : IHttpContent, IClosable, IStringable
  {
    /// <summary>Initializes a new instance of the HttpBufferContent class with the specified buffer.</summary>
    /// <param name="content">The content used to initialize the HttpBufferContent.</param>
    [MethodImpl]
    public extern HttpBufferContent(IBuffer content);

    /// <summary>Initializes a new instance of the HttpBufferContent class with an offset and count of bytes from the specified buffer.</summary>
    /// <param name="content">The content used to initialize the HttpBufferContent.</param>
    /// <param name="offset">The offset in bytes from the beginning of the *content* buffer to initialize the HttpBufferContent.</param>
    /// <param name="count">The count of bytes in the *content* buffer to initialize the HttpBufferContent.</param>
    [MethodImpl]
    public extern HttpBufferContent(IBuffer content, uint offset, uint count);

    /// <summary>Get a collection of content headers set on the HttpBufferContent.</summary>
    /// <returns>A collection of content headers set on the HttpBufferContent.</returns>
    public extern HttpContentHeaderCollection Headers { [MethodImpl] get; }

    /// <summary>Serialize the HttpBufferContent into memory as an asynchronous operation.</summary>
    /// <returns>The object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<ulong, ulong> BufferAllAsync();

    /// <summary>Serialize the HttpBufferContent to a buffer as an asynchronous operation.</summary>
    /// <returns>The object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IBuffer, ulong> ReadAsBufferAsync();

    /// <summary>Serialize the HttpBufferContent and return an input stream that represents the content as an asynchronous operation.</summary>
    /// <returns>The object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IInputStream, ulong> ReadAsInputStreamAsync();

    /// <summary>Serialize the HttpBufferContent to a String as an asynchronous operation.</summary>
    /// <returns>The object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<string, ulong> ReadAsStringAsync();

    /// <summary>Computes the HttpBufferContent length in bytes.</summary>
    /// <param name="length">The length in bytes of the HttpBufferContent.</param>
    /// <returns>**true** if *length* is a valid length; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool TryComputeLength(out ulong length);

    /// <summary>Write the HttpBufferContent to an output stream as an asynchronous operation.</summary>
    /// <param name="outputStream">The output stream to write to.</param>
    /// <returns>The object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<ulong, ulong> WriteToStreamAsync(
      IOutputStream outputStream);

    [MethodImpl]
    public extern void Close();

    /// <summary>Returns a string that represents the current HttpBufferContent object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
