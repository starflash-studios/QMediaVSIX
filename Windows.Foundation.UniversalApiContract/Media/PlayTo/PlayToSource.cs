// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  /// <summary>Represents a media element to connect to a Play To target.</summary>
  /// <deprecated type="deprecate">PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.</deprecated>
  [Muse(Version = 100794368)]
  [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlayToSource : IPlayToSource, IPlayToSourceWithPreferredSourceUri
  {
    /// <summary>Gets the connection to the Play To target.</summary>
    /// <returns>The connection to the Play To target.</returns>
    public extern PlayToConnection Connection { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets or sets the next Play To source element.</summary>
    /// <returns>The next Play To source element.</returns>
    public extern PlayToSource Next { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Connects the next Play To source element to the Play To target.</summary>
    /// <deprecated type="deprecate">PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.</deprecated>
    [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void PlayNext();

    /// <summary>Specifies a preferred Uniform Resource Identifier (URI) for the media stream, such as a cloud based media server, used is used for Play To by reference.</summary>
    /// <returns>The preferred URI to stream the media from.</returns>
    public extern Uri PreferredSourceUri { [Deprecated("PlayToSourceWithPreferredSourceUri may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("PlayToSourceWithPreferredSourceUri may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }
  }
}
