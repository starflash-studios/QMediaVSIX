// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowBackgroundSetupRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing.PrintTicket;

namespace Windows.Graphics.Printing.Workflow
{
  [ExclusiveTo(typeof (PrintWorkflowBackgroundSetupRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1139372866, 5968, 22985, 97, 251, 56, 55, 72, 162, 3, 98)]
  internal interface IPrintWorkflowBackgroundSetupRequestedEventArgs
  {
    [RemoteAsync]
    IAsyncOperation<WorkflowPrintTicket> GetUserPrintTicketAsync();

    PrintWorkflowConfiguration Configuration { get; }

    void SetRequiresUI();

    Deferral GetDeferral();
  }
}
