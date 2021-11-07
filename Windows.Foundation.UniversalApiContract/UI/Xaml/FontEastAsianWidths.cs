// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.FontEastAsianWidths
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides a mechanism for selecting glyphs of different width styles.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FontEastAsianWidths
  {
    /// <summary>Default width style.</summary>
    Normal,
    /// <summary>Replaces uniform width glyphs with full width (usually em) glyphs.</summary>
    Full,
    /// <summary>Replaces uniform width glyphs with half width (half em) glyphs</summary>
    Half,
    /// <summary>Replaces uniform width glyphs with proportionally spaced glyphs.</summary>
    Proportional,
    /// <summary>Replaces uniform width glyphs with one-quarter width (one-quarter em) glyphs.</summary>
    Quarter,
    /// <summary>Replaces uniform width glyphs with one-third width (one-third em) glyphs.</summary>
    Third,
  }
}
