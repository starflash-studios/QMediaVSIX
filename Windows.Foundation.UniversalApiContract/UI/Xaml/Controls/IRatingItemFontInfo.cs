// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRatingItemFontInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RatingItemFontInfo))]
  [Guid(88548329, 31113, 19804, 157, 1, 167, 235, 135, 111, 16, 113)]
  internal interface IRatingItemFontInfo
  {
    string DisabledGlyph { get; set; }

    string Glyph { get; set; }

    string PointerOverGlyph { get; set; }

    string PointerOverPlaceholderGlyph { get; set; }

    string PlaceholderGlyph { get; set; }

    string UnsetGlyph { get; set; }
  }
}
