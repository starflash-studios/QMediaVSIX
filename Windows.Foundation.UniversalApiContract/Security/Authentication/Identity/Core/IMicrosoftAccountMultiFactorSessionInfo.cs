// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.IMicrosoftAccountMultiFactorSessionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  [Guid(1602137012, 41592, 17973, 183, 101, 180, 148, 235, 38, 10, 244)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MicrosoftAccountMultiFactorSessionInfo))]
  internal interface IMicrosoftAccountMultiFactorSessionInfo
  {
    string UserAccountId { get; }

    string SessionId { get; }

    string DisplaySessionId { get; }

    MicrosoftAccountMultiFactorSessionApprovalStatus ApprovalStatus { get; }

    MicrosoftAccountMultiFactorAuthenticationType AuthenticationType { get; }

    DateTime RequestTime { get; }

    DateTime ExpirationTime { get; }
  }
}
