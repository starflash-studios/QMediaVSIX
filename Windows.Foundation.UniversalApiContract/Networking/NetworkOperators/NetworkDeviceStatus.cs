// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.NetworkDeviceStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Describes the readiness of a device to connect to a wireless network.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum NetworkDeviceStatus
  {
    /// <summary>The mobile broadband device is off.</summary>
    DeviceNotReady,
    /// <summary>The device is powered on and ready for mobile broadband operations.</summary>
    DeviceReady,
    /// <summary>The mobile broadband device does not have a SIM card.</summary>
    SimNotInserted,
    /// <summary>The SIM card is not valid. This can occur when PIN Unblock Key attempts have exceeded the limit.</summary>
    BadSim,
    /// <summary>The mobile broadband device hardware is not responding.</summary>
    DeviceHardwareFailure,
    /// <summary>A subscription account for the mobile broadband device is not active.</summary>
    AccountNotActivated,
    /// <summary>The mobile broadband device is locked by a PIN or password preventing the device from initializing and registering with a wireless network.</summary>
    DeviceLocked,
    /// <summary>The mobile broadband device is blocked by a PIN or password preventing the device from initializing and registering with a wireless network.</summary>
    DeviceBlocked,
  }
}
