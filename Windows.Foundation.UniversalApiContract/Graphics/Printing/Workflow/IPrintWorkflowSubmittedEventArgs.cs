// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowSubmittedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing.PrintTicket;

namespace Windows.Graphics.Printing.Workflow
{
  [Guid(987564609, 14228, 21865, 92, 135, 64, 232, 255, 114, 15, 131)]
  [ExclusiveTo(typeof (PrintWorkflowSubmittedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IPrintWorkflowSubmittedEventArgs
  {
    PrintWorkflowSubmittedOperation Operation { get; }

    PrintWorkflowTarget GetTarget(WorkflowPrintTicket jobPrintTicket);

    Deferral GetDeferral();
  }
}
