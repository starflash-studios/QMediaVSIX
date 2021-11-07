// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IPeerWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  [ExclusiveTo(typeof (PeerWatcher))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1022239224, 12198, 18041, 150, 145, 3, 201, 74, 66, 15, 52)]
  internal interface IPeerWatcher
  {
    event TypedEventHandler<PeerWatcher, PeerInformation> Added;

    event TypedEventHandler<PeerWatcher, PeerInformation> Removed;

    event TypedEventHandler<PeerWatcher, PeerInformation> Updated;

    event TypedEventHandler<PeerWatcher, object> EnumerationCompleted;

    event TypedEventHandler<PeerWatcher, object> Stopped;

    PeerWatcherStatus Status { get; }

    void Start();

    void Stop();
  }
}
