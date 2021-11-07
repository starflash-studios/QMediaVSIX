// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalCharacteristicResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>A result of CreateCharacteristicAsync.</summary>
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class GattLocalCharacteristicResult : IGattLocalCharacteristicResult
  {
    /// <summary>Gets the characteristic of the GATT service.</summary>
    /// <returns>The characteristic of the GATT service.</returns>
    public extern GattLocalCharacteristic Characteristic { [MethodImpl] get; }

    /// <summary>Gets the error.</summary>
    /// <returns>The error.</returns>
    public extern BluetoothError Error { [MethodImpl] get; }
  }
}
