// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRatingItemFontInfoStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (RatingItemFontInfo))]
  [Guid(4213264129, 25652, 20203, 130, 255, 124, 229, 212, 11, 245, 16)]
  internal interface IRatingItemFontInfoStatics
  {
    DependencyProperty DisabledGlyphProperty { get; }

    DependencyProperty GlyphProperty { get; }

    DependencyProperty PlaceholderGlyphProperty { get; }

    DependencyProperty PointerOverGlyphProperty { get; }

    DependencyProperty PointerOverPlaceholderGlyphProperty { get; }

    DependencyProperty UnsetGlyphProperty { get; }
  }
}
