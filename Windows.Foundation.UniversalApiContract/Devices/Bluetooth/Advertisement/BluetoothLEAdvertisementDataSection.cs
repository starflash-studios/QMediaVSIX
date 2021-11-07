// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementDataSection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Advertisement
{
  /// <summary>A Bluetooth LE advertisement section. A Bluetooth LE advertisement packet can contain multiple instances of these BluetoothLEAdvertisementDataSection objects.</summary>
  [Activatable(typeof (IBluetoothLEAdvertisementDataSectionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BluetoothLEAdvertisementDataSection : IBluetoothLEAdvertisementDataSection
  {
    /// <summary>Creates a new BluetoothLEAdvertisementDataSection object.</summary>
    [MethodImpl]
    public extern BluetoothLEAdvertisementDataSection();

    /// <summary>Creates a new BluetoothLEAdvertisementDataSection object with the Bluetooth LE advertisement data type and the payload.</summary>
    /// <param name="dataType">The Bluetooth LE advertisement data type as defined by the Bluetooth Special Interest Group (SIG).</param>
    /// <param name="data">The Bluetooth LE advertisement data payload.</param>
    [MethodImpl]
    public extern BluetoothLEAdvertisementDataSection(byte dataType, IBuffer data);

    /// <summary>Gets or sets the Bluetooth LE advertisement data type, as defined by the Bluetooth Special Interest Group (SIG). See Assigned numbers and GAP.</summary>
    /// <returns>The Bluetooth LE advertisement data type.</returns>
    public extern byte DataType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The Bluetooth LE advertisement data payload.</summary>
    /// <returns>The Bluetooth LE advertisement data payload.</returns>
    public extern IBuffer Data { [MethodImpl] get; [MethodImpl] set; }
  }
}
