// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  /// <summary>Specifies common Bluetooth error cases.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BluetoothError
  {
    /// <summary>The operation was successfully completed or serviced.</summary>
    Success,
    /// <summary>The Bluetooth radio was not available. This error occurs when the Bluetooth radio has been turned off.</summary>
    RadioNotAvailable,
    /// <summary>The operation cannot be serviced because the necessary resources are currently in use.</summary>
    ResourceInUse,
    /// <summary>The operation cannot be completed because the remote device is not connected.</summary>
    DeviceNotConnected,
    /// <summary>An unexpected error has occurred.</summary>
    OtherError,
    /// <summary>The operation is disabled by policy.</summary>
    DisabledByPolicy,
    /// <summary>The operation is not supported on the current Bluetooth radio hardware.</summary>
    NotSupported,
    /// <summary>The operation is disabled by the user.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] DisabledByUser,
    /// <summary>The operation requires consent.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] ConsentRequired,
    /// <summary>The transport is not supported.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] TransportNotSupported,
  }
}
