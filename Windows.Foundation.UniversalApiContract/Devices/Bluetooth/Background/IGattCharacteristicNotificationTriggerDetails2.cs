// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IGattCharacteristicNotificationTriggerDetails2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1920618716, 38045, 17738, 177, 146, 152, 52, 103, 227, 213, 15)]
  [ExclusiveTo(typeof (GattCharacteristicNotificationTriggerDetails))]
  internal interface IGattCharacteristicNotificationTriggerDetails2
  {
    BluetoothError Error { get; }

    BluetoothEventTriggeringMode EventTriggeringMode { get; }

    IVectorView<GattValueChangedEventArgs> ValueChangedEvents { get; }
  }
}
