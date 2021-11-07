// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowSubmittedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing.PrintTicket;

namespace Windows.Graphics.Printing.Workflow
{
  /// <summary>Contains information about a PrintWorkflowBackgroundSession.Submitted event that was raised.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PrintWorkflowSubmittedEventArgs : IPrintWorkflowSubmittedEventArgs
  {
    /// <summary>Gets information about the current print task.</summary>
    /// <returns>Information about the print task.</returns>
    public extern PrintWorkflowSubmittedOperation Operation { [MethodImpl] get; }

    /// <summary>Gets a reference to the target document for outputting the edited print job.</summary>
    /// <param name="jobPrintTicket">The print ticket specifying printer configuration options. If no printer options were specified for this print job, use **null**.</param>
    /// <returns>The target document for output.</returns>
    [MethodImpl]
    public extern PrintWorkflowTarget GetTarget(
      WorkflowPrintTicket jobPrintTicket);

    /// <summary>Gets a deferral object for managing the work done on the corresponding PrintWorkflowBackgroundSession.Submitted event.</summary>
    /// <returns>A deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
