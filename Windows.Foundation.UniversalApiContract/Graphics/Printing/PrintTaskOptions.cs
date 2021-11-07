// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTaskOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing
{
  /// <summary>Represents a collection of methods and properties for managing the options which define how the content is to be printed.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PrintTaskOptions : 
    IPrintTaskOptionsCore,
    IPrintTaskOptionsCoreProperties,
    IPrintTaskOptionsCoreUIConfiguration,
    IPrintTaskOptions,
    IPrintTaskOptions2
  {
    /// <summary>Retrieves the physical dimensions of the printed page.</summary>
    /// <param name="jobPageNumber">The page number.</param>
    /// <returns>The page description data.</returns>
    [MethodImpl]
    public extern PrintPageDescription GetPageDescription(uint jobPageNumber);

    /// <summary>Gets or sets the media size option of the print task.</summary>
    /// <returns>The media size option.</returns>
    public extern PrintMediaSize MediaSize { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the media type option for the print task.</summary>
    /// <returns>The media type option.</returns>
    public extern PrintMediaType MediaType { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the orientation option for the print task.</summary>
    /// <returns>The orientation for the print task.</returns>
    public extern PrintOrientation Orientation { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the print quality option for the print task.</summary>
    /// <returns>The print quality for the print task.</returns>
    public extern PrintQuality PrintQuality { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the color mode option of the print task.</summary>
    /// <returns>The color mode option.</returns>
    public extern PrintColorMode ColorMode { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the duplex option of the print task.</summary>
    /// <returns>The duplex option.</returns>
    public extern PrintDuplex Duplex { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the collation option of the print tasks.</summary>
    /// <returns>The collation option.</returns>
    public extern PrintCollation Collation { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the staple option for the print task.</summary>
    /// <returns>The staple option for the print task.</returns>
    public extern PrintStaple Staple { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the hole punch option of the print task.</summary>
    /// <returns>The hole punch option.</returns>
    public extern PrintHolePunch HolePunch { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the binding option for the print task.</summary>
    /// <returns>The binding option.</returns>
    public extern PrintBinding Binding { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the minimum number of copies allowed for the print task.</summary>
    /// <returns>The minimum number of copies.</returns>
    public extern uint MinCopies { [MethodImpl] get; }

    /// <summary>Gets the maximum number of copies supported for the print task.</summary>
    /// <returns>The maximum number of copies.</returns>
    public extern uint MaxCopies { [MethodImpl] get; }

    /// <summary>Gets or sets the value for the number of copies for the print task.</summary>
    /// <returns>The value for the number of copies.</returns>
    public extern uint NumberOfCopies { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the list of options displayed for the print experience.</summary>
    /// <returns>The list of displayed options.</returns>
    public extern IVector<string> DisplayedOptions { [MethodImpl] get; }

    /// <summary>Gets or sets the bordering option for the print task.</summary>
    /// <returns>The bordering option.</returns>
    public extern PrintBordering Bordering { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Retrieves the physical dimensions and formatting data of a printed page.</summary>
    /// <param name="printPageInfo">The formatting data for a given print section.</param>
    /// <returns>The print ticket data for the given page(s), to be sent down the print pipeline.</returns>
    [MethodImpl]
    public extern IRandomAccessStream GetPagePrintTicket(
      PrintPageInfo printPageInfo);

    /// <summary>Gets the page range options for the print task.</summary>
    /// <returns>The page range options.</returns>
    public extern PrintPageRangeOptions PageRangeOptions { [MethodImpl] get; }

    /// <summary>Gets the custom page range options for the print task.</summary>
    /// <returns>The custom page range options.</returns>
    public extern IVector<PrintPageRange> CustomPageRanges { [MethodImpl] get; }
  }
}
