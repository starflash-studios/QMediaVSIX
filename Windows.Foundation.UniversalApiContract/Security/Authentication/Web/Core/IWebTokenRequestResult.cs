// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebTokenRequestResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  [ExclusiveTo(typeof (WebTokenRequestResult))]
  [Guid(3240788741, 53752, 17539, 141, 84, 56, 254, 41, 39, 132, 255)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebTokenRequestResult
  {
    IVectorView<WebTokenResponse> ResponseData { get; }

    WebTokenRequestStatus ResponseStatus { get; }

    WebProviderError ResponseError { get; }

    [RemoteAsync]
    IAsyncAction InvalidateCacheAsync();
  }
}
