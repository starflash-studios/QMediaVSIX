// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemWatcherErrorOccurredEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1959118511, 20756, 17446, 146, 22, 32, 216, 31, 133, 25, 174)]
  [ExclusiveTo(typeof (RemoteSystemWatcherErrorOccurredEventArgs))]
  internal interface IRemoteSystemWatcherErrorOccurredEventArgs
  {
    RemoteSystemWatcherError Error { get; }
  }
}
