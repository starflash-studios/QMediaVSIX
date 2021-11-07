// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  [ExclusiveTo(typeof (WebAccountManager))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1755818025, 11615, 18003, 139, 176, 189, 47, 166, 189, 45, 135)]
  internal interface IWebAccountManagerStatics2
  {
    [RemoteAsync]
    IAsyncAction PullCookiesAsync(string uriString, string callerPFN);
  }
}
