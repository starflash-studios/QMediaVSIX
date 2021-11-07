// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.GattServiceProviderConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  /// <summary>This class represents a gatt service provider connection.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGattServiceProviderConnectionStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  public sealed class GattServiceProviderConnection : IGattServiceProviderConnection
  {
    /// <summary>Gets GATT service connection trigger ID.</summary>
    /// <returns>Gets GATT service connection trigger ID.</returns>
    public extern string TriggerId { [MethodImpl] get; }

    /// <summary>Gets the local GATT service.</summary>
    /// <returns>Gets the local GATT service.</returns>
    public extern GattLocalService Service { [MethodImpl] get; }

    /// <summary>Starts a GATT service provider connection.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Gets all the services.</summary>
    /// <returns>Gets all the services.</returns>
    public static extern IMapView<string, GattServiceProviderConnection> AllServices { [MethodImpl] get; }
  }
}
