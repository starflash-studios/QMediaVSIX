// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialEntityWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [Guid(3015204768, 27998, 19388, 128, 93, 95, 229, 185, 186, 25, 89)]
  [ExclusiveTo(typeof (SpatialEntityWatcher))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISpatialEntityWatcher
  {
    SpatialEntityWatcherStatus Status { get; }

    event TypedEventHandler<SpatialEntityWatcher, SpatialEntityAddedEventArgs> Added;

    event TypedEventHandler<SpatialEntityWatcher, SpatialEntityUpdatedEventArgs> Updated;

    event TypedEventHandler<SpatialEntityWatcher, SpatialEntityRemovedEventArgs> Removed;

    event TypedEventHandler<SpatialEntityWatcher, object> EnumerationCompleted;

    void Start();

    void Stop();
  }
}
