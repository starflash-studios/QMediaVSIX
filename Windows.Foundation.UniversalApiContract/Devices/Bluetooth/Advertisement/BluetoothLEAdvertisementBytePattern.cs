// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementBytePattern
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Advertisement
{
  /// <summary>A Bluetooth LE advertisement byte pattern for filters to match.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IBluetoothLEAdvertisementBytePatternFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BluetoothLEAdvertisementBytePattern : IBluetoothLEAdvertisementBytePattern
  {
    /// <summary>Create a new BluetoothLEAdvertisementBytePattern object.</summary>
    [MethodImpl]
    public extern BluetoothLEAdvertisementBytePattern();

    /// <summary>Create a new BluetoothLEAdvertisementBytePattern object with an advertisement data type to match, the advertisement data byte pattern to match, and the offset of the byte pattern from the beginning of the advertisement data section.</summary>
    /// <param name="dataType">The Bluetooth LE advertisement data type to match.</param>
    /// <param name="offset">The offset of byte pattern from beginning of advertisement data section.</param>
    /// <param name="data">The Bluetooth LE advertisement data byte pattern to match.</param>
    [MethodImpl]
    public extern BluetoothLEAdvertisementBytePattern(byte dataType, short offset, IBuffer data);

    /// <summary>The Bluetooth LE advertisement data type defined by the Bluetooth Special Interest Group (SIG) to match.</summary>
    /// <returns>The Bluetooth LE advertisement data type to match.</returns>
    public extern byte DataType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The offset of byte pattern from beginning of advertisement data section.</summary>
    /// <returns>The offset of byte pattern from beginning of advertisement data section.</returns>
    public extern short Offset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The Bluetooth LE advertisement data byte pattern to match.</summary>
    /// <returns>The Bluetooth LE advertisement data byte pattern to match.</returns>
    public extern IBuffer Data { [MethodImpl] get; [MethodImpl] set; }
  }
}
