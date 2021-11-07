// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.SystemTriggerType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Specifies the system events that can be used to trigger a background task.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SystemTriggerType
  {
    /// <summary>Not a valid trigger type.</summary>
    Invalid,
    /// <summary>The background task is triggered when a new SMS message is received by an installed mobile broadband device.</summary>
    SmsReceived,
    /// <summary>The background task is triggered when the user becomes present.</summary>
    UserPresent,
    /// <summary>The background task is triggered when the user becomes absent.</summary>
    UserAway,
    /// <summary>The background task is triggered when a network change occurs, such as a change in cost or connectivity.</summary>
    NetworkStateChange,
    /// <summary>The background task is triggered when a control channel is reset.</summary>
    ControlChannelReset,
    /// <summary>The background task is triggered when the Internet becomes available.</summary>
    InternetAvailable,
    /// <summary>The background task is triggered when the session is connected.</summary>
    SessionConnected,
    /// <summary>The background task is triggered when the system has finished updating an app.</summary>
    ServicingComplete,
    /// <summary>The background task is triggered when a tile is added to the lock screen.</summary>
    LockScreenApplicationAdded,
    /// <summary>The background task is triggered when a tile is removed from the lock screen.</summary>
    LockScreenApplicationRemoved,
    /// <summary>The background task is triggered when the time zone changes on the device (for example, when the system adjusts the clock for daylight saving time).</summary>
    TimeZoneChange,
    /// <summary>The background task is triggered when the Microsoft account connected to the account changes.</summary>
    OnlineIdConnectedStateChange,
    /// <summary>The background task is triggered when the cost of background work changes.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] BackgroundWorkCostChange,
    /// <summary>The background task is triggered when the status of the battery, BatteryStatus, changes.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PowerStateChange,
    /// <summary>The background task is triggered when the default sign-in account changes.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] DefaultSignInAccountChange,
  }
}
