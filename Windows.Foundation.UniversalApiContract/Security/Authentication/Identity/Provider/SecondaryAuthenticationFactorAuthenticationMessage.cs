// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  /// <summary>Represents standard error messages.</summary>
  /// <deprecated type="deprecate">SecondaryAuthenticationFactorAuthenticationMessage is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Deprecated("SecondaryAuthenticationFactorAuthenticationMessage is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum SecondaryAuthenticationFactorAuthenticationMessage
  {
    /// <summary>Invalid message.</summary>
    Invalid,
    /// <summary>Swipe up or press space bar to sign in with **device name**.</summary>
    SwipeUpWelcome,
    /// <summary>Tap **device name** to the NFC reader to sign in.</summary>
    TapWelcome,
    /// <summary>See **device name** for sign-in instructions.</summary>
    DeviceNeedsAttention,
    /// <summary>Looking for **device name**...</summary>
    LookingForDevice,
    /// <summary>Plug **device name** into a USB port to sign in.</summary>
    LookingForDevicePluggedin,
    /// <summary>Turn on Bluetooth to use **device name** to sign in.</summary>
    BluetoothIsDisabled,
    /// <summary>Turn on NFC to use **device name** to sign in.</summary>
    NfcIsDisabled,
    /// <summary>Connect to a Wi-Fi network to use **device name** to sign in.</summary>
    WiFiIsDisabled,
    /// <summary>Tap **device name** again.</summary>
    ExtraTapIsRequired,
    /// <summary>Your enterprise prevents sign in with **device name**. Use another sign-in option.</summary>
    DisabledByPolicy,
    /// <summary>Tap **device name** to sign in.</summary>
    TapOnDeviceRequired,
    /// <summary>Rest your finger on **device name** to sign in.</summary>
    HoldFinger,
    /// <summary>Swipe your finger on **device name** to sign in.</summary>
    ScanFinger,
    /// <summary>Couldn’t sign in with **device name**. Use another sign-in option.</summary>
    UnauthorizedUser,
    /// <summary>Something went wrong. Use another sign-in option, and then set up **device name** again.</summary>
    ReregisterRequired,
    /// <summary>Try again.</summary>
    TryAgain,
    /// <summary>Say your Spoken Passphrase into **device name**.</summary>
    SayPassphrase,
    /// <summary>Ready to sign in with **device name**.</summary>
    ReadyToSignIn,
    /// <summary>Use another sign-in option first, then you can use **device name** to sign in.</summary>
    UseAnotherSignInOption,
    /// <summary>Could not connect to companion device. Try again.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] ConnectionRequired,
    /// <summary>The authentication process exceeded the time limit. Try again.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] TimeLimitExceeded,
    /// <summary>The authentication process was cancelled. Try again.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] CanceledByUser,
    /// <summary>Instruct the user to center their hand over the companion device.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] CenterHand,
    /// <summary>Instruct the user to move their hand closer to the companion device.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] MoveHandCloser,
    /// <summary>Instruct the user to move their hand farther from the companion device.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] MoveHandFarther,
    /// <summary>Instruct the user to move their hand above the companion device.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] PlaceHandAbove,
    /// <summary>The companion device failed to recognize the user.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] RecognitionFailed,
    /// <summary>The companion device is unavailable. Use another sign-in option.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] DeviceUnavailable,
  }
}
