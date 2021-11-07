// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEManufacturerData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Advertisement
{
  /// <summary>A Bluetooth LE manufacturer-specific data section (one particular type of LE advertisement section). A Bluetooth LE advertisement packet can contain multiple instances of these BluetoothLEManufacturerData objects.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IBluetoothLEManufacturerDataFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class BluetoothLEManufacturerData : IBluetoothLEManufacturerData
  {
    /// <summary>Creates a new BluetoothLEManufacturerData object.</summary>
    [MethodImpl]
    public extern BluetoothLEManufacturerData();

    /// <summary>Creates a new BluetoothLEManufacturerData object with a company identifier code and manufacterer-specific section data.</summary>
    /// <param name="companyId">The Bluetooth LE company identifier code as defined by the Bluetooth Special Interest Group (SIG).</param>
    /// <param name="data">Bluetooth LE manufacturer-specific section data.</param>
    [MethodImpl]
    public extern BluetoothLEManufacturerData(ushort companyId, IBuffer data);

    /// <summary>The Bluetooth LE company identifier code as defined by the Bluetooth Special Interest Group (SIG).</summary>
    /// <returns>The Bluetooth LE company identifier code.</returns>
    public extern ushort CompanyId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Bluetooth LE manufacturer-specific section data.</summary>
    /// <returns>Bluetooth LE manufacturer-specific section data.</returns>
    public extern IBuffer Data { [MethodImpl] get; [MethodImpl] set; }
  }
}
