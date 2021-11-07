// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceWatcherTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(947945753, 19639, 20055, 165, 109, 119, 109, 7, 203, 254, 249)]
  [ExclusiveTo(typeof (DeviceWatcherTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceWatcherTriggerDetails
  {
    IVectorView<DeviceWatcherEvent> DeviceWatcherEvents { get; }
  }
}
