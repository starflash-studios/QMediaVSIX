// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderAdvertisingParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>This class is used to define a GATT service advertisement parameters.</summary>
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class GattServiceProviderAdvertisingParameters : 
    IGattServiceProviderAdvertisingParameters,
    IGattServiceProviderAdvertisingParameters2
  {
    /// <summary>Creates a new GattServiceProviderAdvertisingParameters object.</summary>
    [MethodImpl]
    public extern GattServiceProviderAdvertisingParameters();

    /// <summary>Gets or sets a boolean that indicates if the GATT service is connectable.</summary>
    /// <returns>A boolean that indicates if the GATT service is connectable.</returns>
    public extern bool IsConnectable { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a boolean indicating that the GATT service is discoverable.</summary>
    /// <returns>A boolean indicating that the GATT service is discoverable.</returns>
    public extern bool IsDiscoverable { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>For Bluetooth Low Energy, this parameter adds an additional **ServiceData** section to the advertisement payload for the service's service UUID if space is available. If the service data is added to the advertisement, then the service UUID will also be included in the same section in the advertisement.</summary>
    /// <returns>The service data included in a Bluetooth Low Energy advertising payload.</returns>
    public extern IBuffer ServiceData { [MethodImpl] set; [MethodImpl] get; }
  }
}
