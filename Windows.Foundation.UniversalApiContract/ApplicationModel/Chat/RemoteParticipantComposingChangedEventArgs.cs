// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.RemoteParticipantComposingChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides data to the RemoteParticipantComposingChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteParticipantComposingChangedEventArgs : 
    IRemoteParticipantComposingChangedEventArgs
  {
    /// <summary>Gets the ID for the message transport.</summary>
    /// <returns>The ID for the transport.</returns>
    public extern string TransportId { [MethodImpl] get; }

    /// <summary>Gets the address of the remote chat participant.</summary>
    /// <returns>The address of the remote chat participant.</returns>
    public extern string ParticipantAddress { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the remote participant is currently composing a message.</summary>
    /// <returns>A Boolean value indicating if the remote participant is currently composing a message.</returns>
    public extern bool IsComposing { [MethodImpl] get; }
  }
}
