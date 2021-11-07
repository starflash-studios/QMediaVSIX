// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IDeviceUseTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(229015569, 13135, 19799, 182, 236, 109, 202, 100, 180, 18, 228)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceUseTrigger))]
  internal interface IDeviceUseTrigger : IBackgroundTrigger
  {
    [RemoteAsync]
    [Overload("RequestAsyncSimple")]
    [DefaultOverload]
    IAsyncOperation<DeviceTriggerResult> RequestAsync(
      string deviceId);

    [DefaultOverload]
    [Overload("RequestAsyncWithArguments")]
    [RemoteAsync]
    IAsyncOperation<DeviceTriggerResult> RequestAsync(
      string deviceId,
      string arguments);
  }
}
