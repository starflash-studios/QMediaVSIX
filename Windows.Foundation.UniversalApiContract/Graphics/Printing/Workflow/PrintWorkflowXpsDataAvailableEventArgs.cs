// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowXpsDataAvailableEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  /// <summary>Contains information about a PrintWorkflowForegroundSession.XpsDataAvailable event that was raised.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PrintWorkflowXpsDataAvailableEventArgs : 
    IPrintWorkflowXpsDataAvailableEventArgs
  {
    /// <summary>Gets information about the current print task.</summary>
    /// <returns>Information about the print task.</returns>
    public extern PrintWorkflowSubmittedOperation Operation { [MethodImpl] get; }

    /// <summary>Gets a deferral object for managing the work done on the corresponding PrintWorkflowForegroundSession.XpsDataAvailable event.</summary>
    /// <returns>A deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
