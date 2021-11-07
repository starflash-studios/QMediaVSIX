// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFontIconSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [ExclusiveTo(typeof (FontIconSource))]
  [Guid(571583642, 29923, 17389, 182, 28, 33, 175, 199, 223, 77, 16)]
  internal interface IFontIconSource
  {
    string Glyph { get; set; }

    double FontSize { get; set; }

    FontFamily FontFamily { get; set; }

    FontWeight FontWeight { get; set; }

    FontStyle FontStyle { get; set; }

    bool IsTextScaleFactorEnabled { get; set; }

    bool MirroredWhenRightToLeft { get; set; }
  }
}
