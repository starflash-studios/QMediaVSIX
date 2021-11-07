// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintPageRangeOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Describes the print page range options.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PrintPageRangeOptions : IPrintPageRangeOptions
  {
    /// <summary>Gets and sets the allow all pages option of the print page range.</summary>
    /// <returns>The allow all pages option.</returns>
    public extern bool AllowAllPages { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets and sets the allow current page option of the print page range.</summary>
    /// <returns>The allow current page option.</returns>
    public extern bool AllowCurrentPage { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets and sets the allow custom set of pages option for the print page range.</summary>
    /// <returns>The allow custom set of pages option.</returns>
    public extern bool AllowCustomSetOfPages { [MethodImpl] set; [MethodImpl] get; }
  }
}
