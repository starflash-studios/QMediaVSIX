// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToConnectionTransferredEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  /// <summary>Provides information about the Transferred event.</summary>
  /// <deprecated type="deprecate">PlayToConnectionTransferredEventArgs may be altered or unavailable for releases after Windows 10.</deprecated>
  [Threading(ThreadingModel.Both)]
  [Deprecated("PlayToConnectionTransferredEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PlayToConnectionTransferredEventArgs : IPlayToConnectionTransferredEventArgs
  {
    /// <summary>Gets the previous Play To source that a connection was transferred from.</summary>
    /// <returns>The previous Play To source that a connection was transferred from.</returns>
    public extern PlayToSource PreviousSource { [Deprecated("PlayToConnectionTransferredEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the current Play To source that a connection was transferred to.</summary>
    /// <returns>The current Play To source that a connection was transferred to.</returns>
    public extern PlayToSource CurrentSource { [Deprecated("PlayToConnectionTransferredEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
