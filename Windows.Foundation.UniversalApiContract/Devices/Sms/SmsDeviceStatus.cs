// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsDeviceStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>Contains values that indicate the readiness of an SMS device to engage in cellular network traffic operations.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SmsDeviceStatus
  {
    /// <summary>The device is powered off.</summary>
    Off,
    /// <summary>The device is powered on and ready to be used.</summary>
    Ready,
    /// <summary>The SIM card is not inserted into the device.</summary>
    SimNotInserted,
    /// <summary>The SIM is invalid; PIN unblock key retrials have exceeded the limit.</summary>
    BadSim,
    /// <summary>General device failure.</summary>
    DeviceFailure,
    /// <summary>The service subscription is not activated.</summary>
    SubscriptionNotActivated,
    /// <summary>The device is locked by a PIN or password that prevents the device from initializing and registering on the network.</summary>
    DeviceLocked,
    /// <summary>The device is blocked by a PIN or password that prevents the device from initializing and registering on the nework.</summary>
    DeviceBlocked,
  }
}
