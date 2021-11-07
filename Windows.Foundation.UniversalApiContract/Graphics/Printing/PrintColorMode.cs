// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintColorMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Specifies the color mode option.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PrintColorMode
  {
    /// <summary>The default color mode option.</summary>
    Default,
    /// <summary>An unsupported color mode option.</summary>
    NotAvailable,
    /// <summary>A custom color mode option that is specific to the print device.</summary>
    PrinterCustom,
    /// <summary>An option to indicate that the printed output will be in color.</summary>
    Color,
    /// <summary>An option to indicate that the printed output will be in shades of gray.</summary>
    Grayscale,
    /// <summary>An option to indicate that the printed output will be in one shade of a single color.</summary>
    Monochrome,
  }
}
