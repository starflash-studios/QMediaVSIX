// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattLocalCharacteristic
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattLocalCharacteristic))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2933798765, 21522, 19828, 146, 168, 141, 235, 133, 38, 130, 156)]
  internal interface IGattLocalCharacteristic
  {
    Guid Uuid { get; }

    IBuffer StaticValue { get; }

    GattCharacteristicProperties CharacteristicProperties { get; }

    GattProtectionLevel ReadProtectionLevel { get; }

    GattProtectionLevel WriteProtectionLevel { get; }

    [RemoteAsync]
    IAsyncOperation<GattLocalDescriptorResult> CreateDescriptorAsync(
      Guid descriptorUuid,
      GattLocalDescriptorParameters parameters);

    IVectorView<GattLocalDescriptor> Descriptors { get; }

    string UserDescription { get; }

    IVectorView<GattPresentationFormat> PresentationFormats { get; }

    IVectorView<GattSubscribedClient> SubscribedClients { get; }

    event TypedEventHandler<GattLocalCharacteristic, object> SubscribedClientsChanged;

    event TypedEventHandler<GattLocalCharacteristic, GattReadRequestedEventArgs> ReadRequested;

    event TypedEventHandler<GattLocalCharacteristic, GattWriteRequestedEventArgs> WriteRequested;

    [Overload("NotifyValueAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<GattClientNotificationResult>> NotifyValueAsync(
      IBuffer value);

    [RemoteAsync]
    [Overload("NotifyValueForSubscribedClientAsync")]
    IAsyncOperation<GattClientNotificationResult> NotifyValueAsync(
      IBuffer value,
      GattSubscribedClient subscribedClient);
  }
}
