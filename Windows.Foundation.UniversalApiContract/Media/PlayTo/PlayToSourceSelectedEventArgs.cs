// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToSourceSelectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.PlayTo
{
  /// <summary>Provides information about the SourceSelected event.</summary>
  /// <deprecated type="deprecate">PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PlayToSourceSelectedEventArgs : IPlayToSourceSelectedEventArgs
  {
    /// <summary>Gets the display name of the selected Play To source.</summary>
    /// <returns>The display name of the selected Play To source.</returns>
    public extern string FriendlyName { [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the display icon for the selected Play To source.</summary>
    /// <returns>The display icon for the selected Play To source.</returns>
    public extern IRandomAccessStreamWithContentType Icon { [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the selected Play To source supports displaying images.</summary>
    /// <returns>True if the selected Play To source supports displaying images; otherwise false.</returns>
    public extern bool SupportsImage { [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the selected Play To source supports audio.</summary>
    /// <returns>True if the selected Play To source supports audio; otherwise false.</returns>
    public extern bool SupportsAudio { [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the selected Play To source supports video.</summary>
    /// <returns>True if the selected Play To source supports video; otherwise false.</returns>
    public extern bool SupportsVideo { [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
