// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebAuthenticationCoreManagerStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  [ExclusiveTo(typeof (WebAuthenticationCoreManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(604303026, 35108, 19859, 171, 58, 153, 104, 139, 65, 157, 86)]
  internal interface IWebAuthenticationCoreManagerStatics3 : IWebAuthenticationCoreManagerStatics
  {
    WebAccountMonitor CreateWebAccountMonitor(IIterable<WebAccount> webAccounts);
  }
}
