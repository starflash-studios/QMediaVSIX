// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebProviderTokenResponse
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4011931539, 61269, 16774, 183, 206, 140, 178, 231, 249, 132, 158)]
  [ExclusiveTo(typeof (WebProviderTokenResponse))]
  internal interface IWebProviderTokenResponse
  {
    WebTokenResponse ClientResponse { get; }
  }
}
