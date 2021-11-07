// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowSourceContent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing.PrintTicket;

namespace Windows.Graphics.Printing.Workflow
{
  /// <summary>Represents raw print data from the source application.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PrintWorkflowSourceContent : IPrintWorkflowSourceContent
  {
    /// <summary>Gets the print ticket for the printing task associated with this print data.</summary>
    /// <returns>A print ticket object with the current print task configuration.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WorkflowPrintTicket> GetJobPrintTicketAsync();

    /// <summary>Gets the print data as an XPS data stream.</summary>
    /// <returns>An data stream of XPS data.</returns>
    [MethodImpl]
    public extern PrintWorkflowSpoolStreamContent GetSourceSpoolDataAsStreamContent();

    /// <summary>Gets the print data in the form of the COM-friendly XPS object model.</summary>
    /// <returns>The XPS object model content.</returns>
    [MethodImpl]
    public extern PrintWorkflowObjectModelSourceFileContent GetSourceSpoolDataAsXpsObjectModel();
  }
}
