// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowForegroundSetupRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing.PrintTicket;

namespace Windows.Graphics.Printing.Workflow
{
  [Guid(3152249415, 39963, 19923, 155, 43, 200, 4, 104, 217, 65, 179)]
  [ExclusiveTo(typeof (PrintWorkflowForegroundSetupRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IPrintWorkflowForegroundSetupRequestedEventArgs
  {
    [RemoteAsync]
    IAsyncOperation<WorkflowPrintTicket> GetUserPrintTicketAsync();

    PrintWorkflowConfiguration Configuration { get; }

    Deferral GetDeferral();
  }
}
