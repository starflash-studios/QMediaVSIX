// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToSourceRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  /// <summary>Provides information about the SourceRequested event.</summary>
  /// <deprecated type="deprecate">PlayToSourceRequestedEventArgs may be altered or unavailable for releases after Windows 10.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PlayToSourceRequestedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PlayToSourceRequestedEventArgs : IPlayToSourceRequestedEventArgs
  {
    /// <summary>Gets the media object to connect to a Play To target.</summary>
    /// <returns>The media object to connect to a Play To target.</returns>
    public extern PlayToSourceRequest SourceRequest { [Deprecated("PlayToSourceRequestedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
