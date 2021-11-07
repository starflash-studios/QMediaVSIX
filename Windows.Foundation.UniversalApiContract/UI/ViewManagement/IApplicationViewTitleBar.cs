// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewTitleBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (ApplicationViewTitleBar))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(9587392, 37675, 19051, 156, 75, 220, 56, 200, 36, 120, 206)]
  internal interface IApplicationViewTitleBar
  {
    IReference<Color> ForegroundColor { set; get; }

    IReference<Color> BackgroundColor { set; get; }

    IReference<Color> ButtonForegroundColor { set; get; }

    IReference<Color> ButtonBackgroundColor { set; get; }

    IReference<Color> ButtonHoverForegroundColor { set; get; }

    IReference<Color> ButtonHoverBackgroundColor { set; get; }

    IReference<Color> ButtonPressedForegroundColor { set; get; }

    IReference<Color> ButtonPressedBackgroundColor { set; get; }

    IReference<Color> InactiveForegroundColor { set; get; }

    IReference<Color> InactiveBackgroundColor { set; get; }

    IReference<Color> ButtonInactiveForegroundColor { set; get; }

    IReference<Color> ButtonInactiveBackgroundColor { set; get; }
  }
}
