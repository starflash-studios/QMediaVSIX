// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  /// <summary>Represents contextual information about the triggering of a print workflow background task.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  public sealed class PrintWorkflowTriggerDetails : IPrintWorkflowTriggerDetails
  {
    /// <summary>Gets the print workflow session object that should manage the behavior of the background task that was triggered.</summary>
    /// <returns>The single print workflow background session.</returns>
    public extern PrintWorkflowBackgroundSession PrintWorkflowSession { [MethodImpl] get; }
  }
}
