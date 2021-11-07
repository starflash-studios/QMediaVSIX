// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.UnderlineType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Specifies the type of character underlining.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UnderlineType
  {
    /// <summary>No underline type is defined.</summary>
    Undefined,
    /// <summary>Characters are not underlined.</summary>
    None,
    /// <summary>A single solid line.</summary>
    Single,
    /// <summary>Underline words, but not the spaces between words.</summary>
    Words,
    /// <summary>Two solid double lines.</summary>
    Double,
    /// <summary>A dotted line.</summary>
    Dotted,
    /// <summary>A dashed line.</summary>
    Dash,
    /// <summary>Alternating dashes and dots.</summary>
    DashDot,
    /// <summary>Single dashes, each followed by two dots.</summary>
    DashDotDot,
    /// <summary>A wavy line.</summary>
    Wave,
    /// <summary>A thick solid line.</summary>
    Thick,
    /// <summary>A thin solid line.</summary>
    Thin,
    /// <summary>Two wavy lines.</summary>
    DoubleWave,
    /// <summary>A thick wavy line.</summary>
    HeavyWave,
    /// <summary>Long dashes.</summary>
    LongDash,
    /// <summary>Thick dashes.</summary>
    ThickDash,
    /// <summary>Thick, alternating dashes and dots.</summary>
    ThickDashDot,
    /// <summary>Thick single dashes, each followed by two thick dots.</summary>
    ThickDashDotDot,
    /// <summary>A thick dotted line.</summary>
    ThickDotted,
    /// <summary>Thick long dashes.</summary>
    ThickLongDash,
  }
}
