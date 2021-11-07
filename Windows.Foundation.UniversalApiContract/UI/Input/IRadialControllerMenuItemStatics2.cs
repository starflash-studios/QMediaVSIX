// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerMenuItemStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(213610686, 32318, 18621, 190, 4, 44, 127, 202, 169, 193, 255)]
  [ExclusiveTo(typeof (RadialControllerMenuItem))]
  internal interface IRadialControllerMenuItemStatics2
  {
    [Overload("CreateFromFontGlyph")]
    RadialControllerMenuItem CreateFromFontGlyph(
      string displayText,
      string glyph,
      string fontFamily);

    [Overload("CreateFromFontGlyphWithUri")]
    RadialControllerMenuItem CreateFromFontGlyph(
      string displayText,
      string glyph,
      string fontFamily,
      Uri fontUri);
  }
}
