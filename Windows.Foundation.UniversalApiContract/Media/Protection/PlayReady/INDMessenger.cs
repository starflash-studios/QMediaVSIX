// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDMessenger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Sends registration, proximity detection, and license fetch messages between PlayReady-ND receivers and transmitters.</summary>
  /// <deprecated type="deprecate">INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [Guid(3559782749, 42843, 18367, 130, 73, 188, 131, 130, 13, 163, 138)]
  public interface INDMessenger
  {
    /// <summary>Sends the specified data in an asynchronous registration request message.</summary>
    /// <deprecated type="deprecate">INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="sessionIDBytes">The session identifier. The session identifier must be 16 bytes.</param>
    /// <param name="challengeDataBytes">The data for the challenge message.</param>
    /// <returns>The result of the license fetch request.</returns>
    [Deprecated("INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<INDSendResult> SendRegistrationRequestAsync(
      byte[] sessionIDBytes,
      byte[] challengeDataBytes);

    /// <summary>Sends the specified data in an asynchronous proximity detection start message.</summary>
    /// <deprecated type="deprecate">INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="pdType">The type of proximity detection operation. This value can be **UDP**, **TCP**, or **Transport-Agnostic**.</param>
    /// <param name="transmitterChannelBytes">The transmitter channel data.</param>
    /// <param name="sessionIDBytes">The session identifier. The session identifier must be 16 bytes.</param>
    /// <param name="challengeDataBytes">The data for the challenge message.</param>
    /// <returns>The result of the proximity detection start operation.</returns>
    [RemoteAsync]
    [Deprecated("INDMessenger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<INDSendResult> SendProximityDetectionStartAsync(
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
    IAsyncOperation<INDSendResult> SendProximityDetectionResponseAsync(
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
    IAsyncOperation<INDSendResult> SendLicenseFetchRequestAsync(
      byte[] sessionIDBytes,
      byte[] challengeDataBytes);
  }
}
