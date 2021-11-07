// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattServiceProviderAdvertisementStatusChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(1504029285, 64033, 20476, 177, 85, 4, 217, 40, 1, 38, 134)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GattServiceProviderAdvertisementStatusChangedEventArgs))]
  internal interface IGattServiceProviderAdvertisementStatusChangedEventArgs
  {
    BluetoothError Error { get; }

    GattServiceProviderAdvertisementStatus Status { get; }
  }
}
