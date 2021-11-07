// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowForegroundSetupRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing.PrintTicket;

namespace Windows.Graphics.Printing.Workflow
{
  /// <summary>Contains information about a PrintWorkflowForegroundSession.SetupRequested event that was raised.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PrintWorkflowForegroundSetupRequestedEventArgs : 
    IPrintWorkflowForegroundSetupRequestedEventArgs
  {
    /// <summary>Gets the print ticket for the current print task.</summary>
    /// <returns>An asynchronous operation with a print ticket.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WorkflowPrintTicket> GetUserPrintTicketAsync();

    /// <summary>Gets information about the source application, print job title, and session ID for this print workflow session.</summary>
    /// <returns>The configuration data for this print job.</returns>
    public extern PrintWorkflowConfiguration Configuration { [MethodImpl] get; }

    /// <summary>Gets a deferral object for managing the work done on the corresponding PrintWorkflowForegroundSession.SetupRequested event.</summary>
    /// <returns>A deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
