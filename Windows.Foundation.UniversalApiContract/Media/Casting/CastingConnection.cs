// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.CastingConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  /// <summary>Represents a connection with a casting device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CastingConnection : ICastingConnection, IClosable
  {
    /// <summary>Gets the current state of the connection.</summary>
    /// <returns>The current state of the connection.</returns>
    public extern CastingConnectionState State { [MethodImpl] get; }

    /// <summary>Gets the casting device with which a connection has been made.</summary>
    /// <returns>The casting device.</returns>
    public extern CastingDevice Device { [MethodImpl] get; }

    /// <summary>Gets and sets the content source that is being casted through the connection to the casting device. The content can be set and changed at any time and doing so does not disconnect the connection.</summary>
    /// <returns>The content source that is being casted to the casting device.</returns>
    public extern CastingSource Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates a change in the State property.</summary>
    public extern event TypedEventHandler<CastingConnection, object> StateChanged;

    /// <summary>Indicates an error occurred while attempting to make a casting connection.</summary>
    public extern event TypedEventHandler<CastingConnection, CastingConnectionErrorOccurredEventArgs> ErrorOccurred;

    /// <summary>Starts the process of casting to a casting device. When called, this method pairs the c sting device, if necessary, and verifies access to the casting device with the user. If the user denies the app access to the device, casting fails. Otherwise, a connection is established, and content is sent to the device. During this time, the connection state changes to connecting, then to connected. If a casting source is set, the state changes to rendering once playback begins.</summary>
    /// <param name="value">The content to be casted.</param>
    /// <returns>The status of the casting connection request.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CastingConnectionErrorStatus> RequestStartCastingAsync(
      CastingSource value);

    /// <summary>Terminates a casting connection. The content that was rendering remotely returns to the local element that you retrieved the casting source from.</summary>
    /// <returns>The status of the termination.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CastingConnectionErrorStatus> DisconnectAsync();

    [MethodImpl]
    public extern void Close();
  }
}
