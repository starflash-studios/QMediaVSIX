// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFontIcon
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (FontIcon))]
  [Guid(3570799505, 14764, 18768, 145, 102, 54, 6, 194, 100, 65, 139)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IFontIcon
  {
    string Glyph { get; set; }

    double FontSize { get; set; }

    FontFamily FontFamily { get; set; }

    FontWeight FontWeight { get; set; }

    FontStyle FontStyle { get; set; }
  }
}
