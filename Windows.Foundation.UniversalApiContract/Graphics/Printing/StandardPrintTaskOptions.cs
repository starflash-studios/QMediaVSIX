// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.StandardPrintTaskOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Provides access to the canonical names for the options represented by the PrintTaskOptions class. You can use the StandardPrintTaskOptions class to identify print options displayed in the user experience or to retrieve specific options using the PrintTaskOptionDetails class.</summary>
  [Static(typeof (IStandardPrintTaskOptionsStatic2), 196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IStandardPrintTaskOptionsStatic), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IStandardPrintTaskOptionsStatic3), 393216, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100859904)]
  public static class StandardPrintTaskOptions
  {
    /// <summary>Gets the canonical name for the custom page ranges option for the print task.</summary>
    /// <returns>The canonical name for the custom page ranges option for the print task.</returns>
    public static extern string CustomPageRanges { [MethodImpl] get; }

    /// <summary>Gets the canonical name of the bordering option for the print task.</summary>
    /// <returns>The canonical name of the bordering option for the print task.</returns>
    public static extern string Bordering { [MethodImpl] get; }

    /// <summary>Gets the canonical name for the media size option of the print task.</summary>
    /// <returns>The canonical name for the media size option of the print task.</returns>
    public static extern string MediaSize { [MethodImpl] get; }

    /// <summary>Gets the canonical name for the media type option of the print task.</summary>
    /// <returns>The canonical name for the media type option of the print task.</returns>
    public static extern string MediaType { [MethodImpl] get; }

    /// <summary>Gets the canonical name for the orientation option of the print task.</summary>
    /// <returns>The canonical name for the orientation option of the print task.</returns>
    public static extern string Orientation { [MethodImpl] get; }

    /// <summary>Gets the canonical name for the print quality option of the print task.</summary>
    /// <returns>The canonical name for the print quality option of the print task.</returns>
    public static extern string PrintQuality { [MethodImpl] get; }

    /// <summary>Gets the canonical name for color mode option of the print task.</summary>
    /// <returns>The canonical name for color mode option of the print task.</returns>
    public static extern string ColorMode { [MethodImpl] get; }

    /// <summary>Gets the canonical name for the duplex option of the print task.</summary>
    /// <returns>The canonical name for the duplex option of the print task.</returns>
    public static extern string Duplex { [MethodImpl] get; }

    /// <summary>Gets the canonical name for collation option of the print task.</summary>
    /// <returns>The canonical name for collation option of the print task.</returns>
    public static extern string Collation { [MethodImpl] get; }

    /// <summary>Gets the canonical name for the staple option of the print task.</summary>
    /// <returns>The canonical name for the staple option of the print task.</returns>
    public static extern string Staple { [MethodImpl] get; }

    /// <summary>Gets the canonical name for the hole punch option of the print task.</summary>
    /// <returns>The canonical name for the hole punch option of the print task.</returns>
    public static extern string HolePunch { [MethodImpl] get; }

    /// <summary>Gets the canonical name for the binding option of the print task.</summary>
    /// <returns>The canonical name for the binding option of the print task.</returns>
    public static extern string Binding { [MethodImpl] get; }

    /// <summary>Gets the canonical name for the copies option of the print task.</summary>
    /// <returns>The canonical name for the copies option of the print task.</returns>
    public static extern string Copies { [MethodImpl] get; }

    /// <summary>Gets the canonical name for the NUp (pages per sheet) option of the print task.</summary>
    /// <returns>The canonical name for the NUp (pages per sheet) option of the print task.</returns>
    public static extern string NUp { [MethodImpl] get; }

    /// <summary>Gets the canonical name for the input bin option of the print task.</summary>
    /// <returns>The canonical name for the input bin option of the print task.</returns>
    public static extern string InputBin { [MethodImpl] get; }
  }
}
