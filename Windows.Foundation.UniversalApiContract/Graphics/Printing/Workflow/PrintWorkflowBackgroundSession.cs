// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowBackgroundSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  /// <summary>Represents a single print workflow session that runs in the background.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PrintWorkflowBackgroundSession : IPrintWorkflowBackgroundSession
  {
    /// <summary>Raised first in the print workflow background session. This event exposes information about the print job but not the print content itself. Register for this event to do work on a print job configuration before printing.</summary>
    public extern event TypedEventHandler<PrintWorkflowBackgroundSession, PrintWorkflowBackgroundSetupRequestedEventArgs> SetupRequested;

    /// <summary>Raised when the final XPS print data has become available. This is done after the SetupRequested event and after the optional UI-dependent foreground task is completed.</summary>
    public extern event TypedEventHandler<PrintWorkflowBackgroundSession, PrintWorkflowSubmittedEventArgs> Submitted;

    /// <summary>The status of the current print workflow session.</summary>
    /// <returns>The session status.</returns>
    public extern PrintWorkflowSessionStatus Status { [MethodImpl] get; }

    /// <summary>Starts the print workflow background process. The events of this class are raised in sequential order.</summary>
    [MethodImpl]
    public extern void Start();
  }
}
