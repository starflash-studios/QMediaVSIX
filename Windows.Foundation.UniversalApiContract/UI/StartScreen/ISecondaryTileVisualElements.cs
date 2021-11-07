// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ISecondaryTileVisualElements
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ExclusiveTo(typeof (SecondaryTileVisualElements))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(495842099, 33118, 16703, 159, 80, 168, 29, 167, 10, 150, 178)]
  internal interface ISecondaryTileVisualElements
  {
    Uri Square30x30Logo { [Deprecated("SecondaryTileVisualElements.Square30x30Logo may be altered or unavailable for release after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("SecondaryTileVisualElements.Square30x30Logo may be altered or unavailable for release after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    Uri Square70x70Logo { [Deprecated("SecondaryTileVisualElements.Square70x70Logo may be altered or unavailable for release after Windows Phone 8.1.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("SecondaryTileVisualElements.Square70x70Logo may be altered or unavailable for release after Windows Phone 8.1.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    Uri Square150x150Logo { set; get; }

    Uri Wide310x150Logo { set; get; }

    Uri Square310x310Logo { set; get; }

    ForegroundText ForegroundText { set; get; }

    Color BackgroundColor { set; get; }

    bool ShowNameOnSquare150x150Logo { set; get; }

    bool ShowNameOnWide310x150Logo { set; get; }

    bool ShowNameOnSquare310x310Logo { set; get; }
  }
}
