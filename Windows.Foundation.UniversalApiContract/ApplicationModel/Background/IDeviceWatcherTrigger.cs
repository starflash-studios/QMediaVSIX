// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IDeviceWatcherTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (DeviceWatcherTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2757853149, 34163, 16992, 190, 252, 91, 236, 137, 203, 105, 61)]
  internal interface IDeviceWatcherTrigger : IBackgroundTrigger
  {
  }
}
