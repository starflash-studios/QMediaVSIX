// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystem))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(2576740719, 2876, 23237, 179, 37, 204, 115, 244, 55, 223, 205)]
  internal interface IRemoteSystemStatics3
  {
    [Overload("CreateWatcherForUser")]
    RemoteSystemWatcher CreateWatcherForUser(User user);

    [Overload("CreateWatcherWithFiltersForUser")]
    RemoteSystemWatcher CreateWatcherForUser(
      User user,
      IIterable<IRemoteSystemFilter> filters);
  }
}
