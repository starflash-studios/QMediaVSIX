// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionDepthFrameSourceWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PerceptionDepthFrameSourceWatcher))]
  [Guid(2014222033, 36098, 19755, 173, 164, 91, 166, 36, 160, 235, 16)]
  [Deprecated("PerceptionDepthFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IPerceptionDepthFrameSourceWatcher
  {
    event TypedEventHandler<PerceptionDepthFrameSourceWatcher, PerceptionDepthFrameSourceAddedEventArgs> SourceAdded;

    event TypedEventHandler<PerceptionDepthFrameSourceWatcher, PerceptionDepthFrameSourceRemovedEventArgs> SourceRemoved;

    event TypedEventHandler<PerceptionDepthFrameSourceWatcher, object> Stopped;

    event TypedEventHandler<PerceptionDepthFrameSourceWatcher, object> EnumerationCompleted;

    DeviceWatcherStatus Status { [Deprecated("PerceptionDepthFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("PerceptionDepthFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void Start();

    [Deprecated("PerceptionDepthFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void Stop();
  }
}
