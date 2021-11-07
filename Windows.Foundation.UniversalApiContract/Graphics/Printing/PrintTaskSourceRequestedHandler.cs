// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTaskSourceRequestedHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Occurs when a print task requests the document to print. The supplied print document must implement the IPrintDocumentSource interface.</summary>
  /// <param name="args">Pointer to a **PrintTaskSourceRequestedArgs** object.</param>
  [Guid(1813028776, 23734, 19258, 134, 99, 243, 156, 176, 45, 201, 180)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void PrintTaskSourceRequestedHandler(PrintTaskSourceRequestedArgs args);
}
