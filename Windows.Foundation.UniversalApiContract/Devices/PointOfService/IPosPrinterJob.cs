// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinterJob
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents actions common to jobs for all types of stations for a point-of-service printer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2593390684, 1557, 17809, 165, 143, 48, 248, 126, 223, 226, 228)]
  public interface IPosPrinterJob
  {
    /// <summary>Adds an instruction to the print job to print the specified text.</summary>
    /// <param name="data">The text to print on the point-of-service printer.</param>
    void Print(string data);

    /// <summary>Adds an instruction to the print job to print the specified line of text.</summary>
    /// <param name="data">The line of text to print.</param>
    [Overload("PrintLine")]
    void PrintLine(string data);

    /// <summary>Adds an instruction to the print job to print a newline character.</summary>
    [Overload("PrintNewline")]
    void PrintLine();

    /// <summary>Runs the print job on the printer station asynchronously.</summary>
    /// <returns>The operation to run the print job. This operation returns true if the print job succeeds; otherwise, the operation returns false.</returns>
    [RemoteAsync]
    IAsyncOperation<bool> ExecuteAsync();
  }
}
