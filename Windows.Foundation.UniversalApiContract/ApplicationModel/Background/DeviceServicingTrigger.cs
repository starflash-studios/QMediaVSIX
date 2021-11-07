// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.DeviceServicingTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents an event that an application can trigger to initiate a long-running update (firmware or settings) of a device.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class DeviceServicingTrigger : IDeviceServicingTrigger, IBackgroundTrigger
  {
    /// <summary>Constructor for DeviceServicingTrigger. Takes no parameters.</summary>
    [MethodImpl]
    public extern DeviceServicingTrigger();

    [RemoteAsync]
    [DefaultOverload]
    [Overload("RequestAsyncSimple")]
    [MethodImpl]
    public extern IAsyncOperation<DeviceTriggerResult> RequestAsync(
      string deviceId,
      TimeSpan expectedDuration);

    [Overload("RequestAsyncWithArguments")]
    [RemoteAsync]
    [DefaultOverload]
    [MethodImpl]
    public extern IAsyncOperation<DeviceTriggerResult> RequestAsync(
      string deviceId,
      TimeSpan expectedDuration,
      string arguments);
  }
}
