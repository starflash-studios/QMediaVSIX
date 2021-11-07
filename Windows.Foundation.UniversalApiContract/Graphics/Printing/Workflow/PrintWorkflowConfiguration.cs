// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  /// <summary>Contains information about the source application, print job title, and session ID for a print workflow session.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class PrintWorkflowConfiguration : 
    IPrintWorkflowConfiguration2,
    IPrintWorkflowConfiguration
  {
    [MethodImpl]
    public extern void AbortPrintFlow(PrintWorkflowJobAbortReason reason);

    /// <summary>Gets the display name of the external application that initiated the print job.</summary>
    /// <returns>The display name of the source application.</returns>
    public extern string SourceAppDisplayName { [MethodImpl] get; }

    /// <summary>Gets the job title for this print job.</summary>
    /// <returns>The job title string.</returns>
    public extern string JobTitle { [MethodImpl] get; }

    /// <summary>Gets the session ID for this print job.</summary>
    /// <returns>The unique session ID.</returns>
    public extern string SessionId { [MethodImpl] get; }
  }
}
