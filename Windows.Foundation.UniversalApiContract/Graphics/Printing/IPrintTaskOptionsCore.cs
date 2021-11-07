// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskOptionsCore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Represents the core functionality for a **PrintTaskOptions** object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(467383412, 20177, 16875, 190, 60, 114, 209, 142, 214, 115, 55)]
  public interface IPrintTaskOptionsCore
  {
    /// <summary>Gets the page description for a print job.</summary>
    /// <param name="jobPageNumber">The job page number.</param>
    /// <returns>The page description data.</returns>
    PrintPageDescription GetPageDescription(uint jobPageNumber);
  }
}
