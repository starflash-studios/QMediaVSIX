// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionInfraredFrameSourceWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(943521689, 55052, 17485, 168, 176, 114, 12, 46, 102, 254, 59)]
  [ExclusiveTo(typeof (PerceptionInfraredFrameSourceWatcher))]
  [Deprecated("PerceptionInfraredFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IPerceptionInfraredFrameSourceWatcher
  {
    event TypedEventHandler<PerceptionInfraredFrameSourceWatcher, PerceptionInfraredFrameSourceAddedEventArgs> SourceAdded;

    event TypedEventHandler<PerceptionInfraredFrameSourceWatcher, PerceptionInfraredFrameSourceRemovedEventArgs> SourceRemoved;

    event TypedEventHandler<PerceptionInfraredFrameSourceWatcher, object> Stopped;

    event TypedEventHandler<PerceptionInfraredFrameSourceWatcher, object> EnumerationCompleted;

    DeviceWatcherStatus Status { [Deprecated("PerceptionInfraredFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("PerceptionInfraredFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void Start();

    [Deprecated("PerceptionInfraredFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void Stop();
  }
}
