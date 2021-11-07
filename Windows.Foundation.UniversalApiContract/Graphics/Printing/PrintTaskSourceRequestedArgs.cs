// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTaskSourceRequestedArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Arguments associated with the PrintTaskSourceRequestedHandler delegate. Provides a method for handing the content to be printed to the Print Task.</summary>
  [Muse(Version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PrintTaskSourceRequestedArgs : IPrintTaskSourceRequestedArgs
  {
    /// <summary>Gets the **DateTime** object that indicates the deadline for a print task source request.</summary>
    /// <returns>The deadline for a print task source request.</returns>
    public extern DateTime Deadline { [MethodImpl] get; }

    /// <summary>Informs the print task of the content to be printed.</summary>
    /// <param name="source">A pointer to the **IPrintDocumentSource** interface.</param>
    [MethodImpl]
    public extern void SetSource(IPrintDocumentSource source);

    /// <summary>Gets a PrintTaskSourceRequestedDeferral object that provides access to a Complete method. This method indicates then the deferral is over.</summary>
    /// <returns>Provides access to a **Complete** method.</returns>
    [MethodImpl]
    public extern PrintTaskSourceRequestedDeferral GetDeferral();
  }
}
