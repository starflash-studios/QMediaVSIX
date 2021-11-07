// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  /// <summary>A representation of a Bluetooth LE advertisement payload.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BluetoothLEAdvertisement : IBluetoothLEAdvertisement
  {
    /// <summary>Creates a new BluetoothLEAdvertisement object.</summary>
    [MethodImpl]
    public extern BluetoothLEAdvertisement();

    /// <summary>Bluetooth LE advertisement flags.</summary>
    /// <returns>Bluetooth LE advertisement flags.</returns>
    public extern IReference<BluetoothLEAdvertisementFlags> Flags { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The local name contained within the advertisement.</summary>
    /// <returns>The local name contained within the advertisement. This property can be either the shortened or complete local name defined by the Bluetooth LE specifications.</returns>
    public extern string LocalName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the list of service UUIDs (in 128-bit GUID format) in a BluetoothLEAdvertisement.</summary>
    /// <returns>An IVector of GUID, representing the list of service UUIDs in 128-bit GUID format. This property aggregates all the 16-bit, 32-bit, and 128-bit service UUIDs into a single list.</returns>
    public extern IVector<Guid> ServiceUuids { [MethodImpl] get; }

    /// <summary>Gets the list of manufacturer-specific data sections in a BluetoothLEAdvertisement.</summary>
    /// <returns>The list of manufacturer-specific data sections.</returns>
    public extern IVector<BluetoothLEManufacturerData> ManufacturerData { [MethodImpl] get; }

    /// <summary>Gets the list of raw data sections.</summary>
    /// <returns>The list of raw data sections.</returns>
    public extern IVector<BluetoothLEAdvertisementDataSection> DataSections { [MethodImpl] get; }

    /// <summary>Return a list of all manufacturer data sections in the BluetoothLEAdvertisement payload matching the specified company ID.</summary>
    /// <param name="companyId">The company identifier code defined by the Bluetooth Special Interest Group (SIG).</param>
    /// <returns>A vector of BluetoothLEManufacturerData contained within the payload.</returns>
    [MethodImpl]
    public extern IVectorView<BluetoothLEManufacturerData> GetManufacturerDataByCompanyId(
      ushort companyId);

    /// <summary>Return a list of advertisement data sections that matches a given advertisement section type in a BluetoothLEAdvertisement.</summary>
    /// <param name="type">The advertisement section type</param>
    /// <returns>A vector of all the BluetoothLEAdvertisementDataSection matching the given advertisement type. This method returns an empty list if no such sections are found in the payload.</returns>
    [MethodImpl]
    public extern IVectorView<BluetoothLEAdvertisementDataSection> GetSectionsByType(
      byte type);
  }
}
