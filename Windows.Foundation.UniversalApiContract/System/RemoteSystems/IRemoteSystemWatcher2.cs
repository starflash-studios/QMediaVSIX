// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemWatcher2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(1933797120, 6602, 18681, 164, 205, 120, 15, 122, 213, 140, 113)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (RemoteSystemWatcher))]
  internal interface IRemoteSystemWatcher2
  {
    event TypedEventHandler<RemoteSystemWatcher, RemoteSystemEnumerationCompletedEventArgs> EnumerationCompleted;

    event TypedEventHandler<RemoteSystemWatcher, RemoteSystemWatcherErrorOccurredEventArgs> ErrorOccurred;
  }
}
