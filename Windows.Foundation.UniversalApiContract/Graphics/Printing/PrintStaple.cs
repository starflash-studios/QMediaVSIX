// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintStaple
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Specifies the staple options.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PrintStaple
  {
    /// <summary>The default staple option.</summary>
    Default,
    /// <summary>A staple option that is not available with the application or one that is not supported by the print device.</summary>
    NotAvailable,
    /// <summary>A custom staple option that is specific to the print device.</summary>
    PrinterCustom,
    /// <summary>The option to indicate that no stapling is required.</summary>
    None,
    /// <summary>The option to staple the top left of the printed output.</summary>
    StapleTopLeft,
    /// <summary>The option to staple the top right of the printed output.</summary>
    StapleTopRight,
    /// <summary>The option to staple the bottom left of the printed output.</summary>
    StapleBottomLeft,
    /// <summary>The option to staple the bottom right of the printed output.</summary>
    StapleBottomRight,
    /// <summary>The option to staple the printed output in two places along the left edge.</summary>
    StapleDualLeft,
    /// <summary>The option to staple the printed output in two places along the right edge.</summary>
    StapleDualRight,
    /// <summary>The option to staple the printed output in two places along the top edge.</summary>
    StapleDualTop,
    /// <summary>The option to staple the printed output in two places along the bottom edge.</summary>
    StapleDualBottom,
    /// <summary>The option to saddle stitch the printed output.</summary>
    SaddleStitch,
  }
}
