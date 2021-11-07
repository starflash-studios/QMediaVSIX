// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IGattCharacteristicNotificationTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (GattCharacteristicNotificationTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3797913544, 1686, 18255, 167, 50, 242, 146, 176, 206, 188, 93)]
  internal interface IGattCharacteristicNotificationTrigger : IBackgroundTrigger
  {
    GattCharacteristic Characteristic { get; }
  }
}
