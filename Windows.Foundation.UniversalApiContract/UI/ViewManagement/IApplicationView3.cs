// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationView3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (ApplicationView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2419891429, 31034, 20447, 162, 178, 175, 26, 194, 30, 49, 8)]
  internal interface IApplicationView3
  {
    ApplicationViewTitleBar TitleBar { get; }

    FullScreenSystemOverlayMode FullScreenSystemOverlayMode { get; set; }

    bool IsFullScreenMode { get; }

    bool TryEnterFullScreenMode();

    void ExitFullScreenMode();

    void ShowStandardSystemOverlays();

    bool TryResizeView(Size value);

    void SetPreferredMinSize(Size minSize);
  }
}
