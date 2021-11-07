// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintOrientation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Specifies the orientation options for the printed output.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PrintOrientation
  {
    /// <summary>The default orientation option.</summary>
    Default,
    /// <summary>An orientaiton option that is not available with the application or one that is not supported by the print device.</summary>
    NotAvailable,
    /// <summary>A custom orientation that is specific to the print device.</summary>
    PrinterCustom,
    /// <summary>The Portrait orientation option.</summary>
    Portrait,
    /// <summary>The PortraitFlipped orientation option.</summary>
    PortraitFlipped,
    /// <summary>The Landscape orientation option.</summary>
    Landscape,
    /// <summary>The LandscapeFlipped orientation option.</summary>
    LandscapeFlipped,
  }
}
