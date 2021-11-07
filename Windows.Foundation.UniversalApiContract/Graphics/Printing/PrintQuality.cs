// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintQuality
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Specifies the print quality options for the printed output.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PrintQuality
  {
    /// <summary>The default print quality option.</summary>
    Default,
    /// <summary>A print quality option that is not available with the application or one that is not supported by the print device.</summary>
    NotAvailable,
    /// <summary>A print quality option that is specific to the print device.</summary>
    PrinterCustom,
    /// <summary>The option to automatically select the print quality.</summary>
    Automatic,
    /// <summary>The Draft print quality option.</summary>
    Draft,
    /// <summary>The Fax print quality option.</summary>
    Fax,
    /// <summary>The High print quality option.</summary>
    High,
    /// <summary>The Normal print quality option.</summary>
    Normal,
    /// <summary>The Photographic print quality option.</summary>
    Photographic,
    /// <summary>The Text print quality option.</summary>
    Text,
  }
}
