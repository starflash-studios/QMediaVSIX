// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattServiceProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(2015540173, 10377, 20358, 160, 81, 63, 10, 237, 28, 39, 96)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GattServiceProvider))]
  internal interface IGattServiceProvider
  {
    GattLocalService Service { get; }

    GattServiceProviderAdvertisementStatus AdvertisementStatus { get; }

    event TypedEventHandler<GattServiceProvider, GattServiceProviderAdvertisementStatusChangedEventArgs> AdvertisementStatusChanged;

    [Overload("StartAdvertising")]
    void StartAdvertising();

    [Overload("StartAdvertisingWithParameters")]
    void StartAdvertising(
      GattServiceProviderAdvertisingParameters parameters);

    void StopAdvertising();
  }
}
