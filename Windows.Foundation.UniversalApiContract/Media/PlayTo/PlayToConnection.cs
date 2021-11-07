// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  /// <summary>Provides information about a Play To connection.</summary>
  /// <deprecated type="deprecate">PlayToConnection may be altered or unavailable for releases after Windows 10. Instead, use CastingConnection.</deprecated>
  [Deprecated("PlayToConnection may be altered or unavailable for releases after Windows 10. Instead, use CastingConnection.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class PlayToConnection : IPlayToConnection
  {
    /// <summary>Gets the state of the Play To connection.</summary>
    /// <returns>The state of the Play To connection.</returns>
    public extern PlayToConnectionState State { [Deprecated("PlayToConnection may be altered or unavailable for releases after Windows 10. Instead, use CastingConnection.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Occurs when the state of the Play To connection has changed.</summary>
    public extern event TypedEventHandler<PlayToConnection, PlayToConnectionStateChangedEventArgs> StateChanged;

    /// <summary>Occurs when the Play To connection is transferred to the next Play To source.</summary>
    public extern event TypedEventHandler<PlayToConnection, PlayToConnectionTransferredEventArgs> Transferred;

    /// <summary>Occurs when an error is encountered for the Play To connection.</summary>
    public extern event TypedEventHandler<PlayToConnection, PlayToConnectionErrorEventArgs> Error;
  }
}
