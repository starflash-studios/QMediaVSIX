// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>This class is used to advertise a GATT service.</summary>
  [DualApiPartition(version = 1)]
  [Static(typeof (IGattServiceProviderStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GattServiceProvider : IGattServiceProvider
  {
    /// <summary>Gets the GATT service.</summary>
    /// <returns>The GATT service.</returns>
    public extern GattLocalService Service { [MethodImpl] get; }

    /// <summary>Gets the advertisement status of this GATT service.</summary>
    /// <returns>The advertisement service.</returns>
    public extern GattServiceProviderAdvertisementStatus AdvertisementStatus { [MethodImpl] get; }

    /// <summary>An event that is triggered when the advertisement status has changed.</summary>
    public extern event TypedEventHandler<GattServiceProvider, GattServiceProviderAdvertisementStatusChangedEventArgs> AdvertisementStatusChanged;

    /// <summary>Start advertising the GATT service.</summary>
    [Overload("StartAdvertising")]
    [MethodImpl]
    public extern void StartAdvertising();

    /// <summary>Start advertising the GATT service.</summary>
    /// <param name="parameters">The advertising parameters.</param>
    [Overload("StartAdvertisingWithParameters")]
    [MethodImpl]
    public extern void StartAdvertising(
      GattServiceProviderAdvertisingParameters parameters);

    /// <summary>Stop advertising the GATT service.</summary>
    [MethodImpl]
    public extern void StopAdvertising();

    /// <summary>Creates a new GATT service with the specified serviceUuid</summary>
    /// <param name="serviceUuid">The service UUID.</param>
    /// <returns>An asynchronous operation that completes with a GattServiceProviderResult object.</returns>
    [Overload("CreateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<GattServiceProviderResult> CreateAsync(
      Guid serviceUuid);
  }
}
