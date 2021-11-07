// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.TetheringOperationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Defines the values returned with a NetworkOperatorTetheringOperationResult object to indicate the status of a tethering operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TetheringOperationStatus
  {
    /// <summary>The operation completed successfully.</summary>
    Success,
    /// <summary>The status of the operation is unknown.</summary>
    Unknown,
    /// <summary>The operation could not begin because the mobile broadband device is turned off.</summary>
    MobileBroadbandDeviceOff,
    /// <summary>The operation could not begin because the Wifi device is turned off.</summary>
    WiFiDeviceOff,
    /// <summary>The operation did not complete because the mobile operator could not be contacted to confirm tethering capabilities are provided for this account.</summary>
    EntitlementCheckTimeout,
    /// <summary>The operation did not complete because the account does not currently support tethering operations.</summary>
    EntitlementCheckFailure,
    /// <summary>The operation is still in progress.</summary>
    OperationInProgress,
    /// <summary>The operation could not begin because Bluetooth or a required Bluetooth device is turned off.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] BluetoothDeviceOff,
    /// <summary>The operation did not complete because of limited network connectivity.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] NetworkLimitedConnectivity,
  }
}
