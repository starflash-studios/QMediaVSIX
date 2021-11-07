// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1566575742, 11271, 18629, 136, 156, 69, 93, 43, 9, 151, 113)]
  [ExclusiveTo(typeof (RemoteSystemWatcher))]
  internal interface IRemoteSystemWatcher
  {
    void Start();

    void Stop();

    event TypedEventHandler<RemoteSystemWatcher, RemoteSystemAddedEventArgs> RemoteSystemAdded;

    event TypedEventHandler<RemoteSystemWatcher, RemoteSystemUpdatedEventArgs> RemoteSystemUpdated;

    event TypedEventHandler<RemoteSystemWatcher, RemoteSystemRemovedEventArgs> RemoteSystemRemoved;
  }
}
