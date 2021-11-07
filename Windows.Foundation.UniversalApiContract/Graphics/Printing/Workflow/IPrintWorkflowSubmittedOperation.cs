// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowSubmittedOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  [Guid(776888854, 15329, 24335, 92, 129, 165, 162, 189, 78, 171, 14)]
  [ExclusiveTo(typeof (PrintWorkflowSubmittedOperation))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IPrintWorkflowSubmittedOperation
  {
    void Complete(PrintWorkflowSubmittedStatus status);

    PrintWorkflowConfiguration Configuration { get; }

    PrintWorkflowSourceContent XpsContent { get; }
  }
}
