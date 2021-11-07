// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ActivationKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Specifies the type of activation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ActivationKind
  {
    /// <summary>The user launched the app or tapped a content tile.</summary>
    Launch = 0,
    /// <summary>The user wants to search with the app.</summary>
    Search = 1,
    /// <summary>The app is activated as a target for share operations.</summary>
    ShareTarget = 2,
    /// <summary>An app launched a file whose file type this app is registered to handle.</summary>
    File = 3,
    /// <summary>An app launched a URI whose scheme name this app is registered to handle.</summary>
    Protocol = 4,
    /// <summary>The user wants to pick files that are provided by the app.</summary>
    FileOpenPicker = 5,
    /// <summary>The user wants to save a file and selected the app as the location.</summary>
    FileSavePicker = 6,
    /// <summary>The user wants to save a file that the app provides content management for.</summary>
    CachedFileUpdater = 7,
    /// <summary>The user wants to pick contacts.</summary>
    ContactPicker = 8,
    /// <summary>The app handles AutoPlay.</summary>
    Device = 9,
    /// <summary>The app handles print tasks.</summary>
    PrintTaskSettings = 10, // 0x0000000A
    /// <summary>The app captures photos or video from an attached camera.</summary>
    CameraSettings = 11, // 0x0000000B
    /// <summary>Windows Store only. The user launched the restricted app.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] RestrictedLaunch = 12, // 0x0000000C
    /// <summary>The user wants to manage appointments that are provided by the app.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] AppointmentsProvider = 13, // 0x0000000D
    /// <summary>Windows Store only. The user wants to handle calls or messages for the phone number of a contact that is provided by the app.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Contact = 14, // 0x0000000E
    /// <summary>Windows Store only. The app launches a call from the lock screen. If the user wants to accept the call, the app displays its call UI directly on the lock screen without requiring the user to unlock. A lock-screen call is a special type of launch activation.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] LockScreenCall = 15, // 0x0000000F
    /// <summary>The app was activated as the result of a voice command.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] VoiceCommand = 16, // 0x00000010
    /// <summary>The app was activated as the lock screen. Introduced in Windows 10, version 1507 (10.0.10240).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] LockScreen = 17, // 0x00000011
    /// <summary>Windows Phone only. The app was activated after the completion of a picker.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PickerReturned = 1000, // 0x000003E8
    /// <summary>Windows Phone only. The app was activated to perform a Wallet operation.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] WalletAction = 1001, // 0x000003E9
    /// <summary>Windows Phone only. The app was activated after the app was suspended for a file picker operation.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PickFileContinuation = 1002, // 0x000003EA
    /// <summary>Windows Phone only. The app was activated after the app was suspended for a file save picker operation.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PickSaveFileContinuation = 1003, // 0x000003EB
    /// <summary>Windows Phone only. The app was activated after the app was suspended for a folder picker operation.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PickFolderContinuation = 1004, // 0x000003EC
    /// <summary>Windows Phone only. The app was activated after the app was suspended for a web authentication broker operation.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] WebAuthenticationBrokerContinuation = 1005, // 0x000003ED
    /// <summary>The app was activated by a web account provider. Introduced in Windows 10, version 1507 (10.0.10240).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] WebAccountProvider = 1006, // 0x000003EE
    /// <summary>Reserved for system use. Introduced in Windows 10, version 1507 (10.0.10240).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ComponentUI = 1007, // 0x000003EF
    /// <summary>The app was launched by another app with the expectation that it will return a result back to the caller. Introduced in Windows 10, version 1507 (10.0.10240).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ProtocolForResults = 1009, // 0x000003F1
    /// <summary>The app was activated when a user tapped on the body of a toast notification or performed an action inside a toast notification. Introduced in Windows 10, version 1507 (10.0.10240).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ToastNotification = 1010, // 0x000003F2
    /// <summary>This app was launched by another app to provide a customized printing experience for a 3D printer. Introduced in Windows 10, version 1507 (10.0.10240).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] Print3DWorkflow = 1011, // 0x000003F3
    /// <summary>This app was launched by another app on a different device by using the DIAL protocol. Introduced in Windows 10, version 1507 (10.0.10240).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] DialReceiver = 1012, // 0x000003F4
    /// <summary>This app was activated as a result of pairing a device.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] DevicePairing = 1013, // 0x000003F5
    /// <summary>The app was launched to handle the user interface for account management. In circumstances where the system would have shown the default system user interface, it instead has invoked your app with the UserDataAccountProvider contract. The activation payload contains information about the type of operation being requested and all the information necessary to replicate the system-provided user interface. This activation kind is limited to 1st party apps.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] UserDataAccountsProvider = 1014, // 0x000003F6
    /// <summary>Reserved for system use. Introduced in Windows 10, version 1607 (10.0.14393).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] FilePickerExperience = 1015, // 0x000003F7
    /// <summary>Reserved for system use. Introduced in Windows 10, version 1703 (10.0.15063).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] LockScreenComponent = 1016, // 0x000003F8
    /// <summary>The app was launched from the **My People** UI. Note: introduced in Windows 10, version 1703 (10.0.15063), but not used. Now used starting with Windows 10, version 1709 (10.0.16299).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] ContactPanel = 1017, // 0x000003F9
    /// <summary>The app was activated because the user is printing to a printer that has a Print Workflow Application associated with it which has requested user input.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] PrintWorkflowForegroundTask = 1018, // 0x000003FA
    /// <summary>The app was activated because it was launched by the OS due to a game's request for Xbox-specific UI. Introduced in Windows 10, version 1703 (10.0.15063).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] GameUIProvider = 1019, // 0x000003FB
    /// <summary>The app was activated because the app is specified to launch at system startup or user log-in. Introduced in Windows 10, version 1703 (10.0.15063).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] StartupTask = 1020, // 0x000003FC
    /// <summary>The app was launched from the command line. Introduced in Windows 10, version 1709 (10.0.16299)</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] CommandLineLaunch = 1021, // 0x000003FD
    /// <summary>The app was activated as a barcode scanner provider.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] BarcodeScannerProvider = 1022, // 0x000003FE
    [ContractVersion("Windows.Foundation.UniversalApiContract", 851968)] PrintSupportJobUI = 1023, // 0x000003FF
    [ContractVersion("Windows.Foundation.UniversalApiContract", 851968)] PrintSupportSettingsUI = 1024, // 0x00000400
    [ContractVersion("Windows.Foundation.UniversalApiContract", 851968)] PhoneCallActivation = 1025, // 0x00000401
    [ContractVersion("Windows.Foundation.UniversalApiContract", 851968)] VpnForeground = 1026, // 0x00000402
  }
}
