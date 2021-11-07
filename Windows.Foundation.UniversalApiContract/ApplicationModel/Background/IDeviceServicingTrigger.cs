// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IDeviceServicingTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(447879085, 28212, 18899, 158, 111, 23, 241, 182, 223, 168, 129)]
  [ExclusiveTo(typeof (DeviceServicingTrigger))]
  internal interface IDeviceServicingTrigger : IBackgroundTrigger
  {
    [DefaultOverload]
    [RemoteAsync]
    [Overload("RequestAsyncSimple")]
    IAsyncOperation<DeviceTriggerResult> RequestAsync(
      string deviceId,
      TimeSpan expectedDuration);

    [DefaultOverload]
    [Overload("RequestAsyncWithArguments")]
    [RemoteAsync]
    IAsyncOperation<DeviceTriggerResult> RequestAsync(
      string deviceId,
      TimeSpan expectedDuration,
      string arguments);
  }
}
