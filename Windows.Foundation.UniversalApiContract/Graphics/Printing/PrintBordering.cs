// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintBordering
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Specifies the bordering printing option.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum PrintBordering
  {
    /// <summary>The default bordering option.</summary>
    Default,
    /// <summary>An unsupported border option.</summary>
    NotAvailable,
    /// <summary>A border option that is specific to the printer device.</summary>
    PrinterCustom,
    /// <summary>An option to indicate the printed output will be bordered.</summary>
    Bordered,
    /// <summary>An option to indicate the printed output will be borderless.</summary>
    Borderless,
  }
}
