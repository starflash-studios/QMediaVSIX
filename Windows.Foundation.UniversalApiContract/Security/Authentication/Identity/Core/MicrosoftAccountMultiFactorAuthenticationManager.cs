// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.MicrosoftAccountMultiFactorAuthenticationManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  /// <summary>This API is for internal use only and should not be used in your code.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMicrosoftAccountMultiFactorAuthenticatorStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MicrosoftAccountMultiFactorAuthenticationManager : 
    IMicrosoftAccountMultiFactorAuthenticationManager
  {
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    /// <param name="userAccountId">This API is for internal use only and should not be used in your code.</param>
    /// <param name="codeLength">This API is for internal use only and should not be used in your code.</param>
    /// <returns>This API is for internal use only and should not be used in your code.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorOneTimeCodedInfo> GetOneTimePassCodeAsync(
      string userAccountId,
      uint codeLength);

    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    /// <param name="userAccountId">This API is for internal use only and should not be used in your code.</param>
    /// <param name="authenticationToken">This API is for internal use only and should not be used in your code.</param>
    /// <param name="wnsChannelId">This API is for internal use only and should not be used in your code.</param>
    /// <returns>This API is for internal use only and should not be used in your code.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> AddDeviceAsync(
      string userAccountId,
      string authenticationToken,
      string wnsChannelId);

    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    /// <param name="userAccountId">This API is for internal use only and should not be used in your code.</param>
    /// <returns>This API is for internal use only and should not be used in your code.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> RemoveDeviceAsync(
      string userAccountId);

    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    /// <param name="userAccountId">This API is for internal use only and should not be used in your code.</param>
    /// <param name="channelUri">This API is for internal use only and should not be used in your code.</param>
    /// <returns>This API is for internal use only and should not be used in your code.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> UpdateWnsChannelAsync(
      string userAccountId,
      string channelUri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorGetSessionsResult> GetSessionsAsync(
      IIterable<string> userAccountIdList);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorUnregisteredAccountsAndSessionInfo> GetSessionsAndUnregisteredAccountsAsync(
      IIterable<string> userAccountIdList);

    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    /// <param name="sessionAuthentictionStatus">This API is for internal use only and should not be used in your code.</param>
    /// <param name="authenticationSessionInfo">This API is for internal use only and should not be used in your code.</param>
    /// <returns>This API is for internal use only and should not be used in your code.</returns>
    [RemoteAsync]
    [Overload("ApproveSessionUsingAuthSessionInfoAsync")]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> ApproveSessionAsync(
      MicrosoftAccountMultiFactorSessionAuthenticationStatus sessionAuthentictionStatus,
      MicrosoftAccountMultiFactorSessionInfo authenticationSessionInfo);

    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    /// <param name="sessionAuthentictionStatus">This API is for internal use only and should not be used in your code.</param>
    /// <param name="userAccountId">This API is for internal use only and should not be used in your code.</param>
    /// <param name="sessionId">This API is for internal use only and should not be used in your code.</param>
    /// <param name="sessionAuthenticationType">This API is for internal use only and should not be used in your code.</param>
    /// <returns>This API is for internal use only and should not be used in your code.</returns>
    [Overload("ApproveSessionAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> ApproveSessionAsync(
      MicrosoftAccountMultiFactorSessionAuthenticationStatus sessionAuthentictionStatus,
      string userAccountId,
      string sessionId,
      MicrosoftAccountMultiFactorAuthenticationType sessionAuthenticationType);

    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    /// <param name="authenticationSessionInfo">This API is for internal use only and should not be used in your code.</param>
    /// <returns>This API is for internal use only and should not be used in your code.</returns>
    [Overload("DenySessionUsingAuthSessionInfoAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> DenySessionAsync(
      MicrosoftAccountMultiFactorSessionInfo authenticationSessionInfo);

    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    /// <param name="userAccountId">This API is for internal use only and should not be used in your code.</param>
    /// <param name="sessionId">This API is for internal use only and should not be used in your code.</param>
    /// <param name="sessionAuthenticationType">This API is for internal use only and should not be used in your code.</param>
    /// <returns>This API is for internal use only and should not be used in your code.</returns>
    [RemoteAsync]
    [Overload("DenySessionAsync")]
    [MethodImpl]
    public extern IAsyncOperation<MicrosoftAccountMultiFactorServiceResponse> DenySessionAsync(
      string userAccountId,
      string sessionId,
      MicrosoftAccountMultiFactorAuthenticationType sessionAuthenticationType);

    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    /// <returns>This API is for internal use only and should not be used in your code.</returns>
    public static extern MicrosoftAccountMultiFactorAuthenticationManager Current { [MethodImpl] get; }
  }
}
