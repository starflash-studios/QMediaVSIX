// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebProviderTokenResponseFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4199143834, 9658, 16503, 156, 250, 157, 180, 222, 167, 183, 26)]
  [ExclusiveTo(typeof (WebProviderTokenResponse))]
  internal interface IWebProviderTokenResponseFactory
  {
    WebProviderTokenResponse Create(WebTokenResponse webTokenResponse);
  }
}
