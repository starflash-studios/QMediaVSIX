// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IDeviceConnectionChangeTriggerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (DeviceConnectionChangeTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3286901866, 20221, 17560, 170, 96, 164, 228, 227, 177, 122, 185)]
  internal interface IDeviceConnectionChangeTriggerStatics
  {
    [RemoteAsync]
    IAsyncOperation<DeviceConnectionChangeTrigger> FromIdAsync(
      string deviceId);
  }
}
