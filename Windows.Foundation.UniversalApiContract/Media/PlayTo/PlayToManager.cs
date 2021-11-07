// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  /// <summary>Provides access to Play To capabilities.</summary>
  /// <deprecated type="deprecate">PlayToManager may be altered or unavailable for releases after Windows 10.</deprecated>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPlayToManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlayToManager : IPlayToManager
  {
    /// <summary>Occurs when a user requests media to stream to a Play To target device.</summary>
    public extern event TypedEventHandler<PlayToManager, PlayToSourceRequestedEventArgs> SourceRequested;

    /// <summary>Occurs when a Play To source element has been selected.</summary>
    public extern event TypedEventHandler<PlayToManager, PlayToSourceSelectedEventArgs> SourceSelected;

    /// <summary>Enables or disables the default source selection for Play To.</summary>
    /// <returns>True to enable default source selection; otherwise false. The default is true.</returns>
    public extern bool DefaultSourceSelection { [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the Play To manager for the current view.</summary>
    /// <deprecated type="deprecate">PlayToManager may be altered or unavailable for releases after Windows 10.</deprecated>
    /// <returns>The Play To manager for the current view.</returns>
    [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern PlayToManager GetForCurrentView();

    /// <summary>Displays the Play To UI.</summary>
    /// <deprecated type="deprecate">PlayToManager may be altered or unavailable for releases after Windows 10.</deprecated>
    [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void ShowPlayToUI();
  }
}
