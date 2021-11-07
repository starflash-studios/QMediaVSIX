// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>This class represents a GATT local service.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class GattLocalService : IGattLocalService
  {
    /// <summary>Gets the local service UUID.</summary>
    /// <returns>The local service UUID.</returns>
    public extern Guid Uuid { [MethodImpl] get; }

    /// <summary>Creates a characteristic for this local service.</summary>
    /// <param name="characteristicUuid">The characteristic UUID.</param>
    /// <param name="parameters">The characteristic parameters.</param>
    /// <returns>An asynchronous operation</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattLocalCharacteristicResult> CreateCharacteristicAsync(
      Guid characteristicUuid,
      GattLocalCharacteristicParameters parameters);

    /// <summary>Gets a vector list of the characteristics available for this local service.</summary>
    /// <returns>A vector list of the characteristics available for this local service.</returns>
    public extern IVectorView<GattLocalCharacteristic> Characteristics { [MethodImpl] get; }
  }
}
