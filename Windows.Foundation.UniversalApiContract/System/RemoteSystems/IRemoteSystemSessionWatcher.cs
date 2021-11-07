// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2147738432, 3137, 19042, 182, 215, 189, 190, 43, 25, 190, 45)]
  [ExclusiveTo(typeof (RemoteSystemSessionWatcher))]
  internal interface IRemoteSystemSessionWatcher
  {
    void Start();

    void Stop();

    RemoteSystemSessionWatcherStatus Status { get; }

    event TypedEventHandler<RemoteSystemSessionWatcher, RemoteSystemSessionAddedEventArgs> Added;

    event TypedEventHandler<RemoteSystemSessionWatcher, RemoteSystemSessionUpdatedEventArgs> Updated;

    event TypedEventHandler<RemoteSystemSessionWatcher, RemoteSystemSessionRemovedEventArgs> Removed;
  }
}
