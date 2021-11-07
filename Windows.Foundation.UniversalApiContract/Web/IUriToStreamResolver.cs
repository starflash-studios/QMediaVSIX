// Decompiled with JetBrains decompiler
// Type: Windows.Web.IUriToStreamResolver
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Web
{
  /// <summary>Provides a method to translate a URI to a content stream for use by the WebView.NavigateToLocalStreamUri method.</summary>
  [Guid(2964039786, 39659, 19770, 149, 144, 0, 62, 60, 167, 226, 144)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IUriToStreamResolver
  {
    [RemoteAsync]
    IAsyncOperation<IInputStream> UriToStreamAsync(Uri uri);
  }
}
