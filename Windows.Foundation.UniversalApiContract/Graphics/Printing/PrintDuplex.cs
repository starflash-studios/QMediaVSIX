// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintDuplex
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Specifies the duplex option.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PrintDuplex
  {
    /// <summary>The default duplex option.</summary>
    Default,
    /// <summary>An unsupported duplex option.</summary>
    NotAvailable,
    /// <summary>A custom duplex option that is specific to the print device.</summary>
    PrinterCustom,
    /// <summary>The option to print on only one side of the sheet.</summary>
    OneSided,
    /// <summary>The option to print on both sides of the sheet, flipped along the short edge.</summary>
    TwoSidedShortEdge,
    /// <summary>The option to print on both sides of the sheet, flipped along the long edge.</summary>
    TwoSidedLongEdge,
  }
}
