// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IColorPaletteResources
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (ColorPaletteResources))]
  [Guid(629180612, 44786, 23871, 131, 59, 195, 109, 182, 39, 142, 217)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  internal interface IColorPaletteResources
  {
    IReference<Color> AltHigh { get; set; }

    IReference<Color> AltLow { get; set; }

    IReference<Color> AltMedium { get; set; }

    IReference<Color> AltMediumHigh { get; set; }

    IReference<Color> AltMediumLow { get; set; }

    IReference<Color> BaseHigh { get; set; }

    IReference<Color> BaseLow { get; set; }

    IReference<Color> BaseMedium { get; set; }

    IReference<Color> BaseMediumHigh { get; set; }

    IReference<Color> BaseMediumLow { get; set; }

    IReference<Color> ChromeAltLow { get; set; }

    IReference<Color> ChromeBlackHigh { get; set; }

    IReference<Color> ChromeBlackLow { get; set; }

    IReference<Color> ChromeBlackMediumLow { get; set; }

    IReference<Color> ChromeBlackMedium { get; set; }

    IReference<Color> ChromeDisabledHigh { get; set; }

    IReference<Color> ChromeDisabledLow { get; set; }

    IReference<Color> ChromeHigh { get; set; }

    IReference<Color> ChromeLow { get; set; }

    IReference<Color> ChromeMedium { get; set; }

    IReference<Color> ChromeMediumLow { get; set; }

    IReference<Color> ChromeWhite { get; set; }

    IReference<Color> ChromeGray { get; set; }

    IReference<Color> ListLow { get; set; }

    IReference<Color> ListMedium { get; set; }

    IReference<Color> ErrorText { get; set; }

    IReference<Color> Accent { get; set; }
  }
}
