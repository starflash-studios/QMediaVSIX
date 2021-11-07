// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionColorFrameSourceWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Guid(2528973714, 58983, 16580, 137, 249, 20, 98, 222, 166, 169, 204)]
  [ExclusiveTo(typeof (PerceptionColorFrameSourceWatcher))]
  [Deprecated("PerceptionColorFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPerceptionColorFrameSourceWatcher
  {
    event TypedEventHandler<PerceptionColorFrameSourceWatcher, PerceptionColorFrameSourceAddedEventArgs> SourceAdded;

    event TypedEventHandler<PerceptionColorFrameSourceWatcher, PerceptionColorFrameSourceRemovedEventArgs> SourceRemoved;

    event TypedEventHandler<PerceptionColorFrameSourceWatcher, object> Stopped;

    event TypedEventHandler<PerceptionColorFrameSourceWatcher, object> EnumerationCompleted;

    DeviceWatcherStatus Status { [Deprecated("PerceptionColorFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("PerceptionColorFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void Start();

    [Deprecated("PerceptionColorFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void Stop();
  }
}
