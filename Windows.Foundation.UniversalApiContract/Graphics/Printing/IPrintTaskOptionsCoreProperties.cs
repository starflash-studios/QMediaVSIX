// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskOptionsCoreProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>An interface with properties that provide access to the core options for a print task.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3250001970, 40595, 20053, 129, 75, 51, 38, 165, 158, 252, 225)]
  public interface IPrintTaskOptionsCoreProperties
  {
    /// <summary>Gets or sets the media size option of the print task.</summary>
    /// <returns>The media size option.</returns>
    PrintMediaSize MediaSize { set; get; }

    /// <summary>Gets or sets the media type option for the print task.</summary>
    /// <returns>The media type option.</returns>
    PrintMediaType MediaType { set; get; }

    /// <summary>Gets or sets the orientation option for a print task.</summary>
    /// <returns>The orientation option.</returns>
    PrintOrientation Orientation { set; get; }

    /// <summary>Gets or sets the print quality option for a print task.</summary>
    /// <returns>The print quality option.</returns>
    PrintQuality PrintQuality { set; get; }

    /// <summary>Gets or sets the color mode option for the print task.</summary>
    /// <returns>The color mode option.</returns>
    PrintColorMode ColorMode { set; get; }

    /// <summary>Gets or sets the duplex option for a print task.</summary>
    /// <returns>The duplex option.</returns>
    PrintDuplex Duplex { set; get; }

    /// <summary>Gets or sets the collation option for a print task.</summary>
    /// <returns>The collation option.</returns>
    PrintCollation Collation { set; get; }

    /// <summary>Gets or sets the staple option for a print task.</summary>
    /// <returns>The staple option.</returns>
    PrintStaple Staple { set; get; }

    /// <summary>Gets or sets the hole punch option for the print task.</summary>
    /// <returns>The hole punch option.</returns>
    PrintHolePunch HolePunch { set; get; }

    /// <summary>Gets or sets the binding option for a print task.</summary>
    /// <returns>The binding option.</returns>
    PrintBinding Binding { set; get; }

    /// <summary>Gets the **MinCopies** option for the print task.</summary>
    /// <returns>The MinCopies option.</returns>
    uint MinCopies { get; }

    /// <summary>Gets the **MaxCopies** option for the print task.</summary>
    /// <returns>The MaxCopies option.</returns>
    uint MaxCopies { get; }

    /// <summary>Gets or sets the **NumberOfCopies** option for a print task.</summary>
    /// <returns>The NumberOfCopies option.</returns>
    uint NumberOfCopies { set; get; }
  }
}
