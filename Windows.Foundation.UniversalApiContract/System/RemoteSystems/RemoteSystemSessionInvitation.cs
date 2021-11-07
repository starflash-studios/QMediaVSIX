// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionInvitation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Represents an invitation from a session participant to join their remote session.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteSystemSessionInvitation : IRemoteSystemSessionInvitation
  {
    /// <summary>Gets a RemoteSystem object representing the device that sent the invitation.</summary>
    /// <returns>The RemoteSystem object representing the sending device.</returns>
    public extern RemoteSystem Sender { [MethodImpl] get; }

    /// <summary>Gets a RemoteSystemSessionInfo object representing the session to which this device was invited.</summary>
    /// <returns>The RemoteSystemSessionInfo object representing the session to which this device was invited.</returns>
    public extern RemoteSystemSessionInfo SessionInfo { [MethodImpl] get; }
  }
}
