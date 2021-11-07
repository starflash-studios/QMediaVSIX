// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintSupport.IPrintSupportPrintTicketValidationRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing.PrintTicket;

namespace Windows.Graphics.Printing.PrintSupport
{
  [Guid(864964201, 56149, 21959, 131, 56, 239, 100, 104, 10, 143, 144)]
  [ExclusiveTo(typeof (PrintSupportPrintTicketValidationRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IPrintSupportPrintTicketValidationRequestedEventArgs
  {
    WorkflowPrintTicket PrintTicket { get; }

    void SetPrintTicketValidationStatus(WorkflowPrintTicketValidationStatus status);

    Deferral GetDeferral();
  }
}
