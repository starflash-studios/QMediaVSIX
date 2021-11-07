// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionAddedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains information about a RemoteSystemSessionWatcher.Added event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class RemoteSystemSessionAddedEventArgs : IRemoteSystemSessionAddedEventArgs
  {
    /// <summary>Gets information about the remote session that has been discovered.</summary>
    /// <returns>A RemoteSystemSessionInfo object corresponding to the newly discovered remote session.</returns>
    public extern RemoteSystemSessionInfo SessionInfo { [MethodImpl] get; }
  }
}
