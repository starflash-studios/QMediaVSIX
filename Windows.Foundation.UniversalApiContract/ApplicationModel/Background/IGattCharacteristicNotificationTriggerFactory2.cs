// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IGattCharacteristicNotificationTriggerFactory2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth.Background;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GattCharacteristicNotificationTrigger))]
  [Guid(1503193375, 35411, 20127, 163, 44, 35, 205, 51, 102, 76, 238)]
  internal interface IGattCharacteristicNotificationTriggerFactory2
  {
    [Overload("CreateWithEventTriggeringMode")]
    GattCharacteristicNotificationTrigger Create(
      GattCharacteristic characteristic,
      BluetoothEventTriggeringMode eventTriggeringMode);
  }
}
