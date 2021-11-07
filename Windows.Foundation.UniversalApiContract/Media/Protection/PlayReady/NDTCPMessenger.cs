// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDTCPMessenger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Sends PlayReady-ND messages and challenges using the TCP network protocol.</summary>
  /// <deprecated type="deprecate">NDTCPMessenger is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Activatable(typeof (INDTCPMessengerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("NDTCPMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class NDTCPMessenger : INDMessenger
  {
    /// <summary>Creates a new instance of the NDTCPMessenger class.</summary>
    /// <deprecated type="deprecate">INDTCPMessengerFactory is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="remoteHostName">The IP address of the remote host that will receive messages. The format is either an IPv4 address in dotted-decimal notation or an IPv6 address in colon-hex notation.</param>
    /// <param name="remoteHostPort">The TCP port of the remote host that will receive messages.</param>
    [Deprecated("INDTCPMessengerFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern NDTCPMessenger(string remoteHostName, uint remoteHostPort);

    /// <summary>Sends the specified data in an asynchronous registration request message.</summary>
    /// <deprecated type="deprecate">INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="sessionIDBytes">The session identifier. The session identifier must be 16 bytes.</param>
    /// <param name="challengeDataBytes">The data for the challenge message.</param>
    /// <returns>The result of the registration request.</returns>
    [RemoteAsync]
    [Deprecated("INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<INDSendResult> SendRegistrationRequestAsync(
      byte[] sessionIDBytes,
      byte[] challengeDataBytes);

    /// <summary>Sends the specified data in an asynchronous proximity detection start message.</summary>
    /// <deprecated type="deprecate">INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="pdType">The type of proximity detection operation. This value can be **UDP**, **TCP**, or **Transport-Agnostic**.</param>
    /// <param name="transmitterChannelBytes">The transmitter channel data.</param>
    /// <param name="sessionIDBytes">The session identifier. The session identifier must be 16 bytes.</param>
    /// <param name="challengeDataBytes">The data for the challenge message.</param>
    /// <returns>The result of the proximity detection start operation.</returns>
    [Deprecated("INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<INDSendResult> SendProximityDetectionStartAsync(
      NDProximityDetectionType pdType,
      byte[] transmitterChannelBytes,
      byte[] sessionIDBytes,
      byte[] challengeDataBytes);

    /// <summary>Sends the specified data in an asynchronous proximity detection response message.</summary>
    /// <deprecated type="deprecate">INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="pdType">The type of proximity detection operation. This value can be **UDP**, **TCP**, or **Transport-Agnostic**.</param>
    /// <param name="transmitterChannelBytes">The transmitter channel data.</param>
    /// <param name="sessionIDBytes">The session identifier. The session identifier must be 16 bytes.</param>
    /// <param name="responseDataBytes">The data for the response message.</param>
    /// <returns>The result of the proximity detection response operation.</returns>
    [RemoteAsync]
    [Deprecated("INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<INDSendResult> SendProximityDetectionResponseAsync(
      NDProximityDetectionType pdType,
      byte[] transmitterChannelBytes,
      byte[] sessionIDBytes,
      byte[] responseDataBytes);

    /// <summary>Sends the specified data in an asynchronous license fetch request message.</summary>
    /// <deprecated type="deprecate">INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="sessionIDBytes">The session identifier. The session identifier must be 16 bytes.</param>
    /// <param name="challengeDataBytes">The data for the challenge message.</param>
    /// <returns>The result of the license fetch request.</returns>
    [Deprecated("INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<INDSendResult> SendLicenseFetchRequestAsync(
      byte[] sessionIDBytes,
      byte[] challengeDataBytes);
  }
}
