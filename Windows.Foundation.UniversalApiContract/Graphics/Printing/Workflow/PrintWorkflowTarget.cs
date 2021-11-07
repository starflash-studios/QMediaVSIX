// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowTarget
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  /// <summary>Represents the output document to be sent to the printer driver.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PrintWorkflowTarget : IPrintWorkflowTarget
  {
    /// <summary>Gets the output document in the form of a data stream.</summary>
    /// <returns>The target document data stream.</returns>
    public extern PrintWorkflowStreamTarget TargetAsStream { [MethodImpl] get; }

    /// <summary>Gets the output document in the form of the COM-based XPS object model.</summary>
    /// <returns>The output document object model content.</returns>
    public extern PrintWorkflowObjectModelTargetPackage TargetAsXpsObjectModelPackage { [MethodImpl] get; }
  }
}
