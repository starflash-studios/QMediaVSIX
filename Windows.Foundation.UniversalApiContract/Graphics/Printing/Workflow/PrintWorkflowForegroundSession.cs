// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowForegroundSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  /// <summary>Represents a single print workflow session that runs in the foreground.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class PrintWorkflowForegroundSession : IPrintWorkflowForegroundSession
  {
    /// <summary>Raised first in the print workflow foreground session. This event exposes information about the print job but not the print content itself. Register for this event to do UI-dependent work on the print job before printing.</summary>
    public extern event TypedEventHandler<PrintWorkflowForegroundSession, PrintWorkflowForegroundSetupRequestedEventArgs> SetupRequested;

    /// <summary>Raised when the XPS print data is available to be read. This is done after the SetupRequested event is raised. Register for this event to do UI-dependent work that requires displaying the print content.</summary>
    public extern event TypedEventHandler<PrintWorkflowForegroundSession, PrintWorkflowXpsDataAvailableEventArgs> XpsDataAvailable;

    /// <summary>The status of the current print workflow session.</summary>
    /// <returns>The session status.</returns>
    public extern PrintWorkflowSessionStatus Status { [MethodImpl] get; }

    /// <summary>Starts the print workflow foreground process. The events of this class are raised in sequential order.</summary>
    [MethodImpl]
    public extern void Start();
  }
}
