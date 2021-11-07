// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.JournalPrintJob
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents a set of printing instructions that you want to run on the journal printer station.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class JournalPrintJob : IJournalPrintJob, IPosPrinterJob
  {
    /// <summary>Adds an instruction to the print job to print the specified text and options on the journal printer station.</summary>
    /// <param name="data">The text to print on the journal printer.</param>
    /// <param name="printOptions">The print options of the text to print on the journal printer.</param>
    [MethodImpl]
    public extern void Print(string data, PosPrinterPrintOptions printOptions);

    /// <summary>Adds an instruction to the print job to feed paper by line on the journal printer station.</summary>
    /// <param name="lineCount">The number of lines to feed on the journal printer. Use a positive number to feed paper forward or a negative number to feed paper backward.</param>
    [MethodImpl]
    public extern void FeedPaperByLine(int lineCount);

    /// <summary>Adds an instruction to the print job to feed paper by map mode unit on the journal printer station.</summary>
    /// <param name="distance">The number of map mode units to feed on the journal printer. Use a positive number to feed paper forward or a negative number to feed paper backward.</param>
    [MethodImpl]
    public extern void FeedPaperByMapModeUnit(int distance);

    /// <summary>Adds an instruction to the print job to print the specified text on the journal printer station.</summary>
    /// <param name="data">The text to print on the journal printer.</param>
    [MethodImpl]
    public extern void Print(string data);

    /// <summary>Adds an instruction to the print job to print the specified line of text on the journal printer station.</summary>
    /// <param name="data">The line of text to print.</param>
    [Overload("PrintLine")]
    [MethodImpl]
    public extern void PrintLine(string data);

    /// <summary>Adds an instruction to the print job to print a newline character on the journal printer station.</summary>
    [Overload("PrintNewline")]
    [MethodImpl]
    public extern void PrintLine();

    /// <summary>Runs the print job on the journal printer station asynchronously.</summary>
    /// <returns>The operation to run the print job. This operation returns true if the print job succeeds; otherwise, the operation returns false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ExecuteAsync();
  }
}
