// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowSubmittedOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  /// <summary>Contains information about a print task that has potentially been modified by a print workflow session.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PrintWorkflowSubmittedOperation : IPrintWorkflowSubmittedOperation
  {
    /// <summary>Indicates the completion of the print workflow session. This method should be called in the handler for the PrintWorkflowBackgroundSession.Submitted event when all work relating to the print task has been completed or when an error occurred that requires the process to be aborted.</summary>
    /// <param name="status">Indicates the status of the completed print workflow procedure. This will determine whether the printing pipeline should continue or abort.</param>
    [MethodImpl]
    public extern void Complete(PrintWorkflowSubmittedStatus status);

    /// <summary>Gets information about the source application, print job title, and session ID for this print workflow session.</summary>
    /// <returns>The configuration data for this print job.</returns>
    public extern PrintWorkflowConfiguration Configuration { [MethodImpl] get; }

    /// <summary>Gets the source application's original XPS data. This can be edited and then assigned to the print target in order to change the print content.</summary>
    /// <returns>The XPS print data.</returns>
    public extern PrintWorkflowSourceContent XpsContent { [MethodImpl] get; }
  }
}
