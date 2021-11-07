// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintBinding
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Specifies the print binding option.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PrintBinding
  {
    /// <summary>The default binding option.</summary>
    Default,
    /// <summary>An unsupported binding option.</summary>
    NotAvailable,
    /// <summary>A custom option that is specific to the print device.</summary>
    PrinterCustom,
    /// <summary>No binding required.</summary>
    None,
    /// <summary>The bale binding option.</summary>
    Bale,
    /// <summary>The option to bind the pages along their bottom edge.</summary>
    BindBottom,
    /// <summary>The option to bind the pages along their left edge.</summary>
    BindLeft,
    /// <summary>The option to bind the pages along their right edge.</summary>
    BindRight,
    /// <summary>The option to bind the pages along their top edge.</summary>
    BindTop,
    /// <summary>The option to bind the pages in booklet form.</summary>
    Booklet,
    /// <summary>The option to bind the pages along their bottom edge, with stiches.</summary>
    EdgeStitchBottom,
    /// <summary>The option to bind the pages along their left edge, with stiches.</summary>
    EdgeStitchLeft,
    /// <summary>The option to bind the pages along their right edge, with stiches.</summary>
    EdgeStitchRight,
    /// <summary>The option to bind the pages along their top edge, with stiches.</summary>
    EdgeStitchTop,
    /// <summary>The option to fold the pages.</summary>
    Fold,
    /// <summary>The option to offset the positioning of the pages in the output tray.</summary>
    JogOffset,
    /// <summary>The option to trim the printed sheets.</summary>
    Trim,
  }
}
