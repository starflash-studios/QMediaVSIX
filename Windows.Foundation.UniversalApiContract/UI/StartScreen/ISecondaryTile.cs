// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ISecondaryTile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.UI.StartScreen
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2661175776, 11189, 19392, 187, 141, 66, 178, 58, 188, 200, 141)]
  [ExclusiveTo(typeof (SecondaryTile))]
  internal interface ISecondaryTile
  {
    string TileId { set; get; }

    string Arguments { set; get; }

    string ShortName { [Deprecated("ShortName may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayName.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("ShortName may be altered or unavailable for releases after Windows 8.1. Instead, use DisplayName.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    string DisplayName { set; get; }

    Uri Logo { [Deprecated("Logo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Square150x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("Logo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Square150x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    Uri SmallLogo { [Deprecated("SmallLogo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Square30x30Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("SmallLogo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Square30x30Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    Uri WideLogo { [Deprecated("WideLogo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Wide310x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("WideLogo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Wide310x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    Uri LockScreenBadgeLogo { set; get; }

    bool LockScreenDisplayBadgeAndTileText { set; get; }

    TileOptions TileOptions { [Deprecated("TileOptions may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.ShowNameOnSquare150x150Logo, VisualElements.ShowNameOnWide310x150Logo, and RoamingEnabled.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("TileOptions may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.ShowNameOnSquare150x150Logo, VisualElements.ShowNameOnWide310x150Logo, and RoamingEnabled.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    ForegroundText ForegroundText { [Deprecated("TileOptions may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.ShowNameOnSquare150x150Logo, VisualElements.ShowNameOnWide310x150Logo, and RoamingEnabled.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("ForegroundText may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.ForegroundText.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    Color BackgroundColor { [Deprecated("BackgroundColor may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.BackgroundColor.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("BackgroundColor may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.BackgroundColor.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    [Overload("RequestCreateAsync")]
    IAsyncOperation<bool> RequestCreateAsync();

    [Overload("RequestCreateAsyncWithPoint")]
    IAsyncOperation<bool> RequestCreateAsync(Point invocationPoint);

    [Overload("RequestCreateAsyncWithRect")]
    IAsyncOperation<bool> RequestCreateForSelectionAsync(Rect selection);

    [Overload("RequestCreateAsyncWithRectAndPlacement")]
    IAsyncOperation<bool> RequestCreateForSelectionAsync(
      Rect selection,
      Placement preferredPlacement);

    [Overload("RequestDeleteAsync")]
    IAsyncOperation<bool> RequestDeleteAsync();

    [Overload("RequestDeleteAsyncWithPoint")]
    IAsyncOperation<bool> RequestDeleteAsync(Point invocationPoint);

    [Overload("RequestDeleteAsyncWithRect")]
    IAsyncOperation<bool> RequestDeleteForSelectionAsync(Rect selection);

    [Overload("RequestDeleteAsyncWithRectAndPlacement")]
    IAsyncOperation<bool> RequestDeleteForSelectionAsync(
      Rect selection,
      Placement preferredPlacement);

    [RemoteAsync]
    IAsyncOperation<bool> UpdateAsync();
  }
}
