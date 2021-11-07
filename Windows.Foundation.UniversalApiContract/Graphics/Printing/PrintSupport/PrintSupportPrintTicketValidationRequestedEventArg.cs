// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintSupport.PrintSupportPrintTicketValidationRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing.PrintTicket;

namespace Windows.Graphics.Printing.PrintSupport
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PrintSupportPrintTicketValidationRequestedEventArgs : 
    IPrintSupportPrintTicketValidationRequestedEventArgs
  {
    public extern WorkflowPrintTicket PrintTicket { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetPrintTicketValidationStatus(WorkflowPrintTicketValidationStatus status);

    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
