// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.IMicrosoftAccountMultiFactorAuthenticationManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(265502885, 62836, 17184, 160, 142, 10, 25, 168, 35, 34, 170)]
  [ExclusiveTo(typeof (MicrosoftAccountMultiFactorAuthenticationManager))]
  internal interface IMicrosoftAccountMultiFactorAuthenticationManager
  {
    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorOneTimeCodedInfo> GetOneTimePassCodeAsync(
      string userAccountId,
      uint codeLength);

    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> AddDeviceAsync(
      string userAccountId,
      string authenticationToken,
      string wnsChannelId);

    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> RemoveDeviceAsync(
      string userAccountId);

    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> UpdateWnsChannelAsync(
      string userAccountId,
      string channelUri);

    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorGetSessionsResult> GetSessionsAsync(
      IIterable<string> userAccountIdList);

    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorUnregisteredAccountsAndSessionInfo> GetSessionsAndUnregisteredAccountsAsync(
      IIterable<string> userAccountIdList);

    [RemoteAsync]
    [Overload("ApproveSessionUsingAuthSessionInfoAsync")]
    IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> ApproveSessionAsync(
      MicrosoftAccountMultiFactorSessionAuthenticationStatus sessionAuthentictionStatus,
      MicrosoftAccountMultiFactorSessionInfo authenticationSessionInfo);

    [RemoteAsync]
    [Overload("ApproveSessionAsync")]
    IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> ApproveSessionAsync(
      MicrosoftAccountMultiFactorSessionAuthenticationStatus sessionAuthentictionStatus,
      string userAccountId,
      string sessionId,
      MicrosoftAccountMultiFactorAuthenticationType sessionAuthenticationType);

    [Overload("DenySessionUsingAuthSessionInfoAsync")]
    [RemoteAsync]
    IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> DenySessionAsync(
      MicrosoftAccountMultiFactorSessionInfo authenticationSessionInfo);

    [RemoteAsync]
    [Overload("DenySessionAsync")]
    IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> DenySessionAsync(
      string userAccountId,
      string sessionId,
      MicrosoftAccountMultiFactorAuthenticationType sessionAuthenticationType);
  }
}
