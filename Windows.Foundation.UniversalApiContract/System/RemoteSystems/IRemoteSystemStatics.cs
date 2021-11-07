// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystem))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2760225682, 65323, 19271, 190, 98, 116, 63, 47, 20, 15, 48)]
  internal interface IRemoteSystemStatics
  {
    [RemoteAsync]
    IAsyncOperation<RemoteSystem> FindByHostNameAsync(HostName hostName);

    [Overload("CreateWatcher")]
    RemoteSystemWatcher CreateWatcher();

    [Overload("CreateWatcherWithFilters")]
    RemoteSystemWatcher CreateWatcher(IIterable<IRemoteSystemFilter> filters);

    [RemoteAsync]
    IAsyncOperation<RemoteSystemAccessStatus> RequestAccessAsync();
  }
}
