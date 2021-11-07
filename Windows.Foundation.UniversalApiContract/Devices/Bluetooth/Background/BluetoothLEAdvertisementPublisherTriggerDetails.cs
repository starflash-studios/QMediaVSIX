// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.BluetoothLEAdvertisementPublisherTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  /// <summary>Provides information about a BluetoothLEAdvertisementPublisher trigger. You can obtain an instance of this class through a BluetoothLEAdvertisementPublisher trigger.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class BluetoothLEAdvertisementPublisherTriggerDetails : 
    IBluetoothLEAdvertisementPublisherTriggerDetails,
    IBluetoothLEAdvertisementPublisherTriggerDetails2
  {
    /// <summary>Gets the current status of the BluetoothLEAdvertisementPublisher.</summary>
    /// <returns>The current status of the BluetoothLEAdvertisementPublisher.</returns>
    public extern BluetoothLEAdvertisementPublisherStatus Status { [MethodImpl] get; }

    /// <summary>Gets the error status for the trigger.</summary>
    /// <returns>The error status for the trigger.</returns>
    public extern BluetoothError Error { [MethodImpl] get; }

    /// <summary>Represents the current transmit power selected by the Bluetooth adapter for the advertisement.</summary>
    /// <returns>The current transmit power selected. If the Extended Advertisement format is not supported by the adapter, this instead represents the adapter's default transmit power level.</returns>
    public extern IReference<short> SelectedTransmitPowerLevelInDBm { [MethodImpl] get; }
  }
}
