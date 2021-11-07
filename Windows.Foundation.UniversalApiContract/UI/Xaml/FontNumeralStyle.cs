// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.FontNumeralStyle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Describes a numeral style value for the Typography.NumeralStyle attached property.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FontNumeralStyle
  {
    /// <summary>Default numeral style is used.</summary>
    Normal,
    /// <summary>Lining numeral style is used. Replaces default glyphs with numeric forms of even height.</summary>
    Lining,
    /// <summary>Old style numeral style is used. Replaces default glyphs with a figure style that matches lowercase letters in height and color.</summary>
    OldStyle,
  }
}
