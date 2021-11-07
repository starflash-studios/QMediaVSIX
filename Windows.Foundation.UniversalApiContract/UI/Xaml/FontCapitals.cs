// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.FontCapitals
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Describes the capital letter style value for the Typography.Capitals attached property.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum FontCapitals
  {
    /// <summary>Capital letters render normally.</summary>
    Normal,
    /// <summary>Both capital and lowercase letters are replaced with a glyph form of an uppercase letter with the same approximate height.</summary>
    AllSmallCaps,
    /// <summary>Lowercase letters are replaced with a glyph form of an uppercase letter with the same approximate height.</summary>
    SmallCaps,
    /// <summary>Both capital and lowercase letters are replaced with a glyph form of an uppercase letter with the same approximate height. Petite capitals are smaller than small capitals.</summary>
    AllPetiteCaps,
    /// <summary>Lowercase letters are replaced with a glyph form of an uppercase letter with the same approximate height. Petite capitals are smaller than small capitals.</summary>
    PetiteCaps,
    /// <summary>Capital letters display in unicase. Unicase fonts render both uppercase and lowercase letters in a mixture of uppercase and lowercase glyphs determined by the type designer.</summary>
    Unicase,
    /// <summary>Glyph forms are substituted with a typographic form specifically designed for titles.</summary>
    Titling,
  }
}
