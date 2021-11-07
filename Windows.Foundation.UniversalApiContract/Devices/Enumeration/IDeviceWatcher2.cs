// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceWatcher2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4278732142, 60692, 18921, 154, 105, 129, 23, 197, 74, 233, 113)]
  [ExclusiveTo(typeof (DeviceWatcher))]
  internal interface IDeviceWatcher2
  {
    DeviceWatcherTrigger GetBackgroundTrigger(
      IIterable<DeviceWatcherEventKind> requestedEventKinds);
  }
}
