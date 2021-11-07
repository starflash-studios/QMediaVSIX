// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.AutomationTextDecorationLineStyle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Defines the line style of text decorations.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AutomationTextDecorationLineStyle
  {
    /// <summary>No text decoration.</summary>
    None,
    /// <summary>Single line.</summary>
    Single,
    /// <summary>Words only.</summary>
    WordsOnly,
    /// <summary>Double line.</summary>
    Double,
    /// <summary>Dotted line.</summary>
    Dot,
    /// <summary>Dashed line.</summary>
    Dash,
    /// <summary>Dash-dot line.</summary>
    DashDot,
    /// <summary>Dash-dot-dot line.</summary>
    DashDotDot,
    /// <summary>Wavy line.</summary>
    Wavy,
    /// <summary>Single thick line.</summary>
    ThickSingle,
    /// <summary>Double wavy line.</summary>
    DoubleWavy,
    /// <summary>Thick wavy line.</summary>
    ThickWavy,
    /// <summary>Long dashed line.</summary>
    LongDash,
    /// <summary>Thick dashed line.</summary>
    ThickDash,
    /// <summary>Thick dash-dot line.</summary>
    ThickDashDot,
    /// <summary>Thick dash-dot-dot line.</summary>
    ThickDashDotDot,
    /// <summary>Thick dotted line.</summary>
    ThickDot,
    /// <summary>Thick long dashed line.</summary>
    ThickLongDash,
    /// <summary>Other line.</summary>
    Other,
  }
}
