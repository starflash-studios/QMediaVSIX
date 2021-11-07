// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppResourceGroupInfoWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (AppResourceGroupInfoWatcher))]
  [Guid(3652231421, 28250, 19570, 139, 23, 9, 254, 196, 162, 18, 189)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IAppResourceGroupInfoWatcher
  {
    event TypedEventHandler<AppResourceGroupInfoWatcher, AppResourceGroupInfoWatcherEventArgs> Added;

    event TypedEventHandler<AppResourceGroupInfoWatcher, AppResourceGroupInfoWatcherEventArgs> Removed;

    event TypedEventHandler<AppResourceGroupInfoWatcher, object> EnumerationCompleted;

    event TypedEventHandler<AppResourceGroupInfoWatcher, object> Stopped;

    event TypedEventHandler<AppResourceGroupInfoWatcher, AppResourceGroupInfoWatcherExecutionStateChangedEventArgs> ExecutionStateChanged;

    AppResourceGroupInfoWatcherStatus Status { get; }

    void Start();

    void Stop();
  }
}
