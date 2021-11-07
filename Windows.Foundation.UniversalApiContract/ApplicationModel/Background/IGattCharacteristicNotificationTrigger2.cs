// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IGattCharacteristicNotificationTrigger2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (GattCharacteristicNotificationTrigger))]
  [Guid(2468520644, 44558, 17138, 178, 140, 245, 19, 114, 230, 146, 69)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattCharacteristicNotificationTrigger2
  {
    BluetoothEventTriggeringMode EventTriggeringMode { get; }
  }
}
