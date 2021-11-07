// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthentication
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  /// <summary>Contains core methods for authenticating with a companion device.</summary>
  /// <deprecated type="deprecate">SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Static(typeof (ISecondaryAuthenticationFactorAuthenticationStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class SecondaryAuthenticationFactorAuthentication : 
    ISecondaryAuthenticationFactorAuthentication
  {
    /// <summary>Gets the service authentication HMAC.</summary>
    /// <returns>The service authentication HMAC.</returns>
    public extern IBuffer ServiceAuthenticationHmac { [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the session nonce.</summary>
    /// <returns>The session nonce.</returns>
    public extern IBuffer SessionNonce { [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the device nonce.</summary>
    /// <returns>The device nonce.</returns>
    public extern IBuffer DeviceNonce { [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the device configuration data.</summary>
    /// <returns>The device configuration data.</returns>
    public extern IBuffer DeviceConfigurationData { [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Finishes an authentication with a companion device.</summary>
    /// <deprecated type="deprecate">SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="deviceHmac">The authentication device HMAC.</param>
    /// <param name="sessionHmac">The session HMAC.</param>
    /// <returns>When this method completes, it returns the status of the operation finishing.</returns>
    [RemoteAsync]
    [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<SecondaryAuthenticationFactorFinishAuthenticationStatus> FinishAuthenticationAsync(
      IBuffer deviceHmac,
      IBuffer sessionHmac);

    /// <summary>Aborts an authentication.</summary>
    /// <deprecated type="deprecate">SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="errorLogMessage">An error message to log.</param>
    /// <returns>This method does not return a value.</returns>
    [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AbortAuthenticationAsync(string errorLogMessage);

    /// <summary>Shows a message above the lock screen or within the companion device sign in option tile.</summary>
    /// <deprecated type="deprecate">SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="deviceName">The name of device to display as part of the notification message (set using the message parameter).</param>
    /// <param name="message">The message to show.</param>
    /// <returns>This method does not return a value.</returns>
    [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncAction ShowNotificationMessageAsync(
      string deviceName,
      SecondaryAuthenticationFactorAuthenticationMessage message);

    /// <summary>Start an authentication with a companion device.</summary>
    /// <deprecated type="deprecate">SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="deviceId">The Id of the device to authenticate with.</param>
    /// <param name="serviceAuthenticationNonce">The service authentication nonce.</param>
    /// <returns>When this method completes, it returns the results of the authentication.</returns>
    [RemoteAsync]
    [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<SecondaryAuthenticationFactorAuthenticationResult> StartAuthenticationAsync(
      string deviceId,
      IBuffer serviceAuthenticationNonce);

    /// <summary>Fires when the authentication stage changes.</summary>
    public static extern event EventHandler<SecondaryAuthenticationFactorAuthenticationStageChangedEventArgs> AuthenticationStageChanged;

    /// <summary>Gets info on the authentication stage.</summary>
    /// <deprecated type="deprecate">SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <returns>When this method completes, it returns info on the authentication stage.</returns>
    [RemoteAsync]
    [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<SecondaryAuthenticationFactorAuthenticationStageInfo> GetAuthenticationStageInfoAsync();
  }
}
