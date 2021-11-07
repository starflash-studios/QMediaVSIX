// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemWatcher3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(4154200015, 43283, 21971, 132, 19, 65, 143, 207, 21, 186, 84)]
  [ExclusiveTo(typeof (RemoteSystemWatcher))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IRemoteSystemWatcher3
  {
    User User { get; }
  }
}
