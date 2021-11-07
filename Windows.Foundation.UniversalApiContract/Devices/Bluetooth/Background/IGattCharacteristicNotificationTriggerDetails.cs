// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IGattCharacteristicNotificationTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GattCharacteristicNotificationTriggerDetails))]
  [Guid(2610969368, 4076, 17258, 147, 177, 244, 108, 105, 117, 50, 162)]
  internal interface IGattCharacteristicNotificationTriggerDetails
  {
    GattCharacteristic Characteristic { get; }

    IBuffer Value { get; }
  }
}
