// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.GattServiceProviderTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Constructs a Generic Attributes (GATT) service that can be persisted in the background.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGattServiceProviderTriggerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class GattServiceProviderTrigger : IBackgroundTrigger, IGattServiceProviderTrigger
  {
    /// <summary>Gets the trigger identifier.</summary>
    /// <returns>The trigger ID.</returns>
    public extern string TriggerId { [MethodImpl] get; }

    /// <summary>Gets the service associated with this trigger.</summary>
    /// <returns>The service.</returns>
    public extern GattLocalService Service { [MethodImpl] get; }

    /// <summary>Gets the advertising parameters which control whether the radio is connected/discoverable.</summary>
    /// <returns>
    /// </returns>
    public extern GattServiceProviderAdvertisingParameters AdvertisingParameters { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Creates a GATT provider service.</summary>
    /// <param name="triggerId">The identifier for the trigger.</param>
    /// <param name="serviceUuid">The universally unique identifier for the trigger.</param>
    /// <returns>Await the asynchronous operation to get the **GattServiceProviderTriggerResult**.</returns>
    [Overload("CreateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<GattServiceProviderTriggerResult> CreateAsync(
      string triggerId,
      Guid serviceUuid);
  }
}
