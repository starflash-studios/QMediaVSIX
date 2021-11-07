// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintPageInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Stores formatting data for a single section of printable pages.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Muse(Version = 167772162)]
  public sealed class PrintPageInfo : IPrintPageInfo
  {
    /// <summary>Initializes an instance of the PrintPageInfo class.</summary>
    [MethodImpl]
    public extern PrintPageInfo();

    /// <summary>Gets or sets the media size option of the given print section.</summary>
    /// <returns>The media size option.</returns>
    public extern PrintMediaSize MediaSize { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the intended paper size on which to print the given section.</summary>
    /// <returns>The page size of the print section.</returns>
    public extern Size PageSize { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the print resolution on the horizontal axis for the given print section.</summary>
    /// <returns>Print resolution in dots per inch.</returns>
    public extern uint DpiX { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the print resolution on the vertical axis for the given print section.</summary>
    /// <returns>Print resolution in dots per inch.</returns>
    public extern uint DpiY { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the orientation option for the given print section.</summary>
    /// <returns>The orientation for the section.</returns>
    public extern PrintOrientation Orientation { [MethodImpl] set; [MethodImpl] get; }
  }
}
