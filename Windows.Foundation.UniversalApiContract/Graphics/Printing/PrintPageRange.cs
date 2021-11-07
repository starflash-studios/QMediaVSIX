// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintPageRange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Describes the range of pages in a print task.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IPrintPageRangeFactory), 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772165)]
  public sealed class PrintPageRange : IPrintPageRange
  {
    /// <summary>Initializes an instance of the PrintPageRange class, using the specified first and last page numbers.</summary>
    /// <param name="firstPage">The first page number of the print range.</param>
    /// <param name="lastPage">The last page number of the print range.</param>
    [MethodImpl]
    public extern PrintPageRange(int firstPage, int lastPage);

    /// <summary>Initializes an instance of the PrintPageRange class, using the specified page number.</summary>
    /// <param name="page">The page number of the print range.</param>
    [MethodImpl]
    public extern PrintPageRange(int page);

    /// <summary>Gets the first page number of the print range.</summary>
    /// <returns>The first page number of the print range.</returns>
    public extern int FirstPageNumber { [MethodImpl] get; }

    /// <summary>Gets the last page number of the print range.</summary>
    /// <returns>The last page number of the print range.</returns>
    public extern int LastPageNumber { [MethodImpl] get; }
  }
}
