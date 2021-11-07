// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.IMicrosoftAccountMultiFactorUnregisteredAccountsAndSessionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2860434939, 55871, 16520, 162, 13, 86, 24, 175, 173, 178, 229)]
  [ExclusiveTo(typeof (MicrosoftAccountMultiFactorUnregisteredAccountsAndSessionInfo))]
  internal interface IMicrosoftAccountMultiFactorUnregisteredAccountsAndSessionInfo
  {
    IVectorView<MicrosoftAccountMultiFactorSessionInfo> Sessions { get; }

    IVectorView<string> UnregisteredAccounts { get; }

    MicrosoftAccountMultiFactorServiceResponse ServiceResponse { get; }
  }
}
