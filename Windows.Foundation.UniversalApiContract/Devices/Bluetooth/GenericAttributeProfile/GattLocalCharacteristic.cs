// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalCharacteristic
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>This class represents a local characteristic.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class GattLocalCharacteristic : IGattLocalCharacteristic
  {
    /// <summary>Gets the BluetoothSIG-defined UUID for this local characteristic.</summary>
    /// <returns>The BluetoothSIG-defined UUID for this local characteristic.</returns>
    public extern Guid Uuid { [MethodImpl] get; }

    /// <summary>Gets the static value for this local GATT characteristic.</summary>
    /// <returns>The static value for this local GATT characteristic.</returns>
    public extern IBuffer StaticValue { [MethodImpl] get; }

    /// <summary>Gets the local characteristic properties.</summary>
    /// <returns>The local characteristic properties.</returns>
    public extern GattCharacteristicProperties CharacteristicProperties { [MethodImpl] get; }

    /// <summary>Gets the read protection level of this local characteristic.</summary>
    /// <returns>The read protection level of this local characteristic.</returns>
    public extern GattProtectionLevel ReadProtectionLevel { [MethodImpl] get; }

    /// <summary>Gets the write protection level of this local characteristic.</summary>
    /// <returns>The write protection level of this local characteristic.</returns>
    public extern GattProtectionLevel WriteProtectionLevel { [MethodImpl] get; }

    /// <summary>Creates descriptor for this local characteristic.</summary>
    /// <param name="descriptorUuid">The descriptor UUID.</param>
    /// <param name="parameters">The parameters for the descriptor.</param>
    /// <returns>An asynchronous operation that completes with a GattLocalDescriptorResult object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattLocalDescriptorResult> CreateDescriptorAsync(
      Guid descriptorUuid,
      GattLocalDescriptorParameters parameters);

    /// <summary>Gets a vector list of all the descriptors for this local characteristic.</summary>
    /// <returns>A vector list of all the descriptors for this local characteristic.</returns>
    public extern IVectorView<GattLocalDescriptor> Descriptors { [MethodImpl] get; }

    /// <summary>Gets the user-friendly description for this local characteristic.</summary>
    /// <returns>The user-friendly description for this local characteristic.</returns>
    public extern string UserDescription { [MethodImpl] get; }

    /// <summary>Gets the presentation formats for this local characteristic.</summary>
    /// <returns>The presentation formats for this local characteristic.</returns>
    public extern IVectorView<GattPresentationFormat> PresentationFormats { [MethodImpl] get; }

    /// <summary>Gets a vector list of all clients that are subscribed to this local characteristic.</summary>
    /// <returns>A vector list of all clients that are subscribed to this local characteristic.</returns>
    public extern IVectorView<GattSubscribedClient> SubscribedClients { [MethodImpl] get; }

    /// <summary>An event that triggers when the clients subscribed to this local characteristic changes.</summary>
    public extern event TypedEventHandler<GattLocalCharacteristic, object> SubscribedClientsChanged;

    /// <summary>An event that is triggered when a GATT client requests a read operation.</summary>
    public extern event TypedEventHandler<GattLocalCharacteristic, GattReadRequestedEventArgs> ReadRequested;

    /// <summary>This is an event that is triggered when a write was requested.</summary>
    public extern event TypedEventHandler<GattLocalCharacteristic, GattWriteRequestedEventArgs> WriteRequested;

    /// <summary>Send and notifies all subscribed clients a GattSubscribedClient of a value.</summary>
    /// <param name="value">The buffer that contains the value to send to the GattSubscribedClient.</param>
    /// <returns>An asynchronous operation that completes with a vector list of all the GattClientNotificationResult for each subscribed client.</returns>
    [RemoteAsync]
    [Overload("NotifyValueAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<GattClientNotificationResult>> NotifyValueAsync(
      IBuffer value);

    /// <summary>Sends and notifies a GattSubscribedClient of a value.</summary>
    /// <param name="value">The buffer that contains the value to send to the GattSubscribedClient.</param>
    /// <param name="subscribedClient">The subscribed client notify the value.</param>
    /// <returns>An asynchronous operation that completes with a GattClientNotificationResult object.</returns>
    [Overload("NotifyValueForSubscribedClientAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattClientNotificationResult> NotifyValueAsync(
      IBuffer value,
      GattSubscribedClient subscribedClient);
  }
}
