// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.IAppWindowTitleBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(1855138948, 63044, 21533, 162, 215, 12, 38, 36, 55, 132, 45)]
  [ExclusiveTo(typeof (AppWindowTitleBar))]
  internal interface IAppWindowTitleBar
  {
    IReference<Color> BackgroundColor { get; set; }

    IReference<Color> ButtonBackgroundColor { get; set; }

    IReference<Color> ButtonForegroundColor { get; set; }

    IReference<Color> ButtonHoverBackgroundColor { get; set; }

    IReference<Color> ButtonHoverForegroundColor { get; set; }

    IReference<Color> ButtonInactiveBackgroundColor { get; set; }

    IReference<Color> ButtonInactiveForegroundColor { get; set; }

    IReference<Color> ButtonPressedBackgroundColor { get; set; }

    IReference<Color> ButtonPressedForegroundColor { get; set; }

    bool ExtendsContentIntoTitleBar { get; set; }

    IReference<Color> ForegroundColor { get; set; }

    IReference<Color> InactiveBackgroundColor { get; set; }

    IReference<Color> InactiveForegroundColor { get; set; }

    bool IsVisible { get; }

    IVectorView<AppWindowTitleBarOcclusion> GetTitleBarOcclusions();
  }
}
