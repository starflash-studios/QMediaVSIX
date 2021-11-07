// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  /// <summary>Groups parameters used to configure payload-based filtering of received Bluetooth LE advertisements.</summary>
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BluetoothLEAdvertisementFilter : IBluetoothLEAdvertisementFilter
  {
    /// <summary>Creates a new BluetoothLEAdvertisementFilter object.</summary>
    [MethodImpl]
    public extern BluetoothLEAdvertisementFilter();

    /// <summary>A BluetoothLEAdvertisement object that can be applied as filters to received Bluetooth LE advertisements.</summary>
    /// <returns>A BluetoothLEAdvertisement object that can be applied as filters to received Bluetooth LE advertisements.</returns>
    public extern BluetoothLEAdvertisement Advertisement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a vector of byte patterns with offsets to match advertisement sections in a received Bluetooth LE advertisement.</summary>
    /// <returns>A vector of byte patterns with offsets to match advertisement sections in a received Bluetooth LE advertisement.</returns>
    public extern IVector<BluetoothLEAdvertisementBytePattern> BytePatterns { [MethodImpl] get; }
  }
}
