// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFontIconStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3015605238, 5223, 16518, 187, 203, 78, 33, 217, 122, 123, 77)]
  [ExclusiveTo(typeof (FontIcon))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFontIconStatics
  {
    DependencyProperty GlyphProperty { get; }

    DependencyProperty FontSizeProperty { get; }

    DependencyProperty FontFamilyProperty { get; }

    DependencyProperty FontWeightProperty { get; }

    DependencyProperty FontStyleProperty { get; }
  }
}
