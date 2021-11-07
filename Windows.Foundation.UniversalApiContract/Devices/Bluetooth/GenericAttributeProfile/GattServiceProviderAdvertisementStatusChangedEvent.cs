// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderAdvertisementStatusChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>The event args for the GattServiceProvider.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class GattServiceProviderAdvertisementStatusChangedEventArgs : 
    IGattServiceProviderAdvertisementStatusChangedEventArgs
  {
    /// <summary>Gets the error of the GATT service.</summary>
    /// <returns>The error of the GATT service.</returns>
    public extern BluetoothError Error { [MethodImpl] get; }

    /// <summary>Gets the status of the GATT service.</summary>
    /// <returns>The status of the GATT service.</returns>
    public extern GattServiceProviderAdvertisementStatus Status { [MethodImpl] get; }
  }
}
