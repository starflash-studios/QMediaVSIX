// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionInvitationListener
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains the functionality for receiving and handling invitations to join remote sessions. This class begins listening for invitations when it is instantiated.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class RemoteSystemSessionInvitationListener : IRemoteSystemSessionInvitationListener
  {
    /// <summary>Initializes an instance of RemoteSystemSessionInvitationListener.</summary>
    [MethodImpl]
    public extern RemoteSystemSessionInvitationListener();

    /// <summary>Raised when a remote session invitation from another device has been detected.</summary>
    public extern event TypedEventHandler<RemoteSystemSessionInvitationListener, RemoteSystemSessionInvitationReceivedEventArgs> InvitationReceived;
  }
}
