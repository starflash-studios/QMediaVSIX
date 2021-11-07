// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionDisconnectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains information about a RemoteSystemSession.Disconnected event, namely the reason that this device was disconnected from the session.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class RemoteSystemSessionDisconnectedEventArgs : 
    IRemoteSystemSessionDisconnectedEventArgs
  {
    /// <summary>Gets the reason this device was disconnected from the session.</summary>
    /// <returns>The RemoteSystemSessionDisconnectedReason value representing the reason for disconnection.</returns>
    public extern RemoteSystemSessionDisconnectedReason Reason { [MethodImpl] get; }
  }
}
