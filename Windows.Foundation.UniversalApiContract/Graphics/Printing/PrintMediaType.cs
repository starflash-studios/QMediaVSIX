// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintMediaType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Specifies the media types for the printed output.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PrintMediaType
  {
    /// <summary>The default media type for the printed output.</summary>
    Default,
    /// <summary>A media type that is not available with the application or one that is not supported by the print device.</summary>
    NotAvailable,
    /// <summary>A custom media type that is specific to the print device.</summary>
    PrinterCustom,
    /// <summary>The option to auto select a media type.</summary>
    AutoSelect,
    /// <summary>The Archival media type.</summary>
    Archival,
    /// <summary>The BackPrintFilm media type.</summary>
    BackPrintFilm,
    /// <summary>The Bond media type.</summary>
    Bond,
    /// <summary>The CardStock media type.</summary>
    CardStock,
    /// <summary>The Continuous media type.</summary>
    Continuous,
    /// <summary>The EnvelopePlain media type.</summary>
    EnvelopePlain,
    /// <summary>The EnvelopeWindow media type.</summary>
    EnvelopeWindow,
    /// <summary>The Fabric media type.</summary>
    Fabric,
    /// <summary>The HighResolution media type.</summary>
    HighResolution,
    /// <summary>The Label media type.</summary>
    Label,
    /// <summary>The MultiLayerForm media type.</summary>
    MultiLayerForm,
    /// <summary>The MultiPartForm media type.</summary>
    MultiPartForm,
    /// <summary>The Photographic media type.</summary>
    Photographic,
    /// <summary>The PhotographicFilm media type.</summary>
    PhotographicFilm,
    /// <summary>The PhotographicGlossy media type.</summary>
    PhotographicGlossy,
    /// <summary>The PhotographicHighGloss media type.</summary>
    PhotographicHighGloss,
    /// <summary>The PhotographicMatte media type.</summary>
    PhotographicMatte,
    /// <summary>The PhotographicSatin media type.</summary>
    PhotographicSatin,
    /// <summary>The PhotographicSemiGloss media type.</summary>
    PhotographicSemiGloss,
    /// <summary>The Plain media type.</summary>
    Plain,
    /// <summary>The Screen media type.</summary>
    Screen,
    /// <summary>The ScreenPaged media type.</summary>
    ScreenPaged,
    /// <summary>The Stationery media type.</summary>
    Stationery,
    /// <summary>The TabStockFull media type.</summary>
    TabStockFull,
    /// <summary>The TabStockPreCut media type.</summary>
    TabStockPreCut,
    /// <summary>The Transparency media type.</summary>
    Transparency,
    /// <summary>The TShirtTransfer media type.</summary>
    TShirtTransfer,
    /// <summary>The option to indicate that a media type has not been selected.</summary>
    None,
  }
}
