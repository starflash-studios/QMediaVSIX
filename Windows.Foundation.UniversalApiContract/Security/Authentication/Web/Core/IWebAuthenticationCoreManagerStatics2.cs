// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebAuthenticationCoreManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.System;

namespace Windows.Security.Authentication.Web.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4119074890, 35671, 18464, 182, 164, 112, 165, 182, 252, 244, 74)]
  [ExclusiveTo(typeof (WebAuthenticationCoreManager))]
  internal interface IWebAuthenticationCoreManagerStatics2 : IWebAuthenticationCoreManagerStatics
  {
    [Overload("FindAccountProviderWithAuthorityForUserAsync")]
    [RemoteAsync]
    IAsyncOperation<WebAccountProvider> FindAccountProviderAsync(
      string webAccountProviderId,
      string authority,
      User user);
  }
}
