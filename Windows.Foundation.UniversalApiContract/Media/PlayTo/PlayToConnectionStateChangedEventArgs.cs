// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToConnectionStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  /// <summary>Provides information about the StateChanged event.</summary>
  /// <deprecated type="deprecate">PlayToConnectionStateChangedEventArgs may be altered or unavailable for releases after Windows 10.</deprecated>
  [Deprecated("PlayToConnectionStateChangedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlayToConnectionStateChangedEventArgs : IPlayToConnectionStateChangedEventArgs
  {
    /// <summary>Gets the previous state before the Play To connection state was changed.</summary>
    /// <returns>The previous state before the Play To connection state was changed.</returns>
    public extern PlayToConnectionState PreviousState { [Deprecated("PlayToConnectionStateChangedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the current state after the Play To connection state has changed.</summary>
    /// <returns>The current state after the Play To connection state has changed.</returns>
    public extern PlayToConnectionState CurrentState { [Deprecated("PlayToConnectionStateChangedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
