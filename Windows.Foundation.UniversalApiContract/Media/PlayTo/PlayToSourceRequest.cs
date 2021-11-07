// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToSourceRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  /// <summary>Represents a request to connect a media element with a Play To target.</summary>
  /// <deprecated type="deprecate">PlayToSourceRequest may be altered or unavailable for releases after Windows 10.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PlayToSourceRequest may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PlayToSourceRequest : IPlayToSourceRequest
  {
    /// <summary>Gets the time limit to supply the Play To source element.</summary>
    /// <returns>The time limit to supply the Play To source element.</returns>
    public extern DateTime Deadline { [Deprecated("PlayToSourceRequest may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Displays an error message in the Play To UI.</summary>
    /// <deprecated type="deprecate">PlayToSourceRequest may be altered or unavailable for releases after Windows 10.</deprecated>
    /// <param name="errorString">The error message to display in the Play To UI.</param>
    [Deprecated("PlayToSourceRequest may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void DisplayErrorString(string errorString);

    /// <summary>Defers connecting a media source to a Play To target.</summary>
    /// <deprecated type="deprecate">PlayToSourceRequest may be altered or unavailable for releases after Windows 10.</deprecated>
    /// <returns>A deferral object that you can use to identify when the deferral is complete.</returns>
    [Deprecated("PlayToSourceRequest may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern PlayToSourceDeferral GetDeferral();

    /// <summary>Sets the source element to connect to the Play To target.</summary>
    /// <deprecated type="deprecate">PlayToSourceRequest may be altered or unavailable for releases after Windows 10.</deprecated>
    /// <param name="value">The source element to connect to the Play To target.</param>
    [Deprecated("PlayToSourceRequest may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void SetSource(PlayToSource value);
  }
}
