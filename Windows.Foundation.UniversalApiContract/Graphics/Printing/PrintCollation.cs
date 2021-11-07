// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintCollation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Specifies the collation option.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PrintCollation
  {
    /// <summary>The default collation option.</summary>
    Default,
    /// <summary>An unsupported collation option.</summary>
    NotAvailable,
    /// <summary>A custom collation option that is specific to the print device.</summary>
    PrinterCustom,
    /// <summary>An option to specify that collation has been selected for the printed output.</summary>
    Collated,
    /// <summary>An option to specify that collation has not been selected for the printed output.</summary>
    Uncollated,
  }
}
