// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.IHttpFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Filters
{
  /// <summary>An interface used to implement custom filters for an HttpClient instance.</summary>
  [Guid(2764795349, 2306, 17310, 191, 215, 225, 37, 82, 177, 101, 206)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IHttpFilter : IClosable
  {
    /// <summary>Send an HTTP request on the IHttpFilter instance as an asynchronous operation.</summary>
    /// <param name="request">The HTTP request message to send.</param>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> SendRequestAsync(
      HttpRequestMessage request);
  }
}
