// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.FontStretch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Describes the degree to which a font has been stretched, compared to the normal aspect ratio of that font.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FontStretch
  {
    /// <summary>No defined font stretch.</summary>
    Undefined,
    /// <summary>An ultra-condensed font stretch (50% of normal).</summary>
    UltraCondensed,
    /// <summary>An extra-condensed font stretch (62.5% of normal).</summary>
    ExtraCondensed,
    /// <summary>A condensed font stretch (75% of normal).</summary>
    Condensed,
    /// <summary>A semi-condensed font stretch (87.5% of normal).</summary>
    SemiCondensed,
    /// <summary>The normal font stretch that all other font stretch values relate to (100%).</summary>
    Normal,
    /// <summary>A semi-expanded font stretch (112.5% of normal).</summary>
    SemiExpanded,
    /// <summary>An expanded font stretch (125% of normal).</summary>
    Expanded,
    /// <summary>An extra-expanded font stretch (150% of normal).</summary>
    ExtraExpanded,
    /// <summary>An ultra-expanded font stretch (200% of normal).</summary>
    UltraExpanded,
  }
}
