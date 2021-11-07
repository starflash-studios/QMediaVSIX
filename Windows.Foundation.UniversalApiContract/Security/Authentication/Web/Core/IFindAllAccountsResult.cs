// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IFindAllAccountsResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (FindAllAccountsResult))]
  [Guid(2776705885, 46894, 16908, 134, 171, 170, 192, 215, 183, 38, 31)]
  internal interface IFindAllAccountsResult
  {
    IVectorView<WebAccount> Accounts { get; }

    FindAllWebAccountsStatus Status { get; }

    WebProviderError ProviderError { get; }
  }
}
