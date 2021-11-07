// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowSourceContent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing.PrintTicket;

namespace Windows.Graphics.Printing.Workflow
{
  [Guid(438879809, 52913, 17715, 187, 115, 251, 230, 62, 239, 219, 24)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (PrintWorkflowSourceContent))]
  internal interface IPrintWorkflowSourceContent
  {
    [RemoteAsync]
    IAsyncOperation<WorkflowPrintTicket> GetJobPrintTicketAsync();

    PrintWorkflowSpoolStreamContent GetSourceSpoolDataAsStreamContent();

    PrintWorkflowObjectModelSourceFileContent GetSourceSpoolDataAsXpsObjectModel();
  }
}
