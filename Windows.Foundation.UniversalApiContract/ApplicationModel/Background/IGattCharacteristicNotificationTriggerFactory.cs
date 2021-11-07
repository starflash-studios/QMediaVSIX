// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IGattCharacteristicNotificationTriggerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GattCharacteristicNotificationTrigger))]
  [Guid(1471814037, 45379, 17781, 159, 107, 253, 89, 217, 58, 206, 26)]
  internal interface IGattCharacteristicNotificationTriggerFactory
  {
    [Overload("Create")]
    GattCharacteristicNotificationTrigger Create(
      GattCharacteristic characteristic);
  }
}
