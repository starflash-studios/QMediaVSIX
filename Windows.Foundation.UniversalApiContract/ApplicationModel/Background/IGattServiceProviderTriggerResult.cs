// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IGattServiceProviderTriggerResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1011257777, 45464, 20100, 186, 212, 207, 74, 210, 153, 237, 58)]
  [ExclusiveTo(typeof (GattServiceProviderTriggerResult))]
  internal interface IGattServiceProviderTriggerResult
  {
    GattServiceProviderTrigger Trigger { get; }

    BluetoothError Error { get; }
  }
}
