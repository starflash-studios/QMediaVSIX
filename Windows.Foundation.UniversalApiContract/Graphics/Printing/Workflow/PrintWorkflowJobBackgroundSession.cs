// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowJobBackgroundSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  public sealed class PrintWorkflowJobBackgroundSession : IPrintWorkflowJobBackgroundSession
  {
    public extern PrintWorkflowSessionStatus Status { [MethodImpl] get; }

    public extern event TypedEventHandler<PrintWorkflowJobBackgroundSession, PrintWorkflowJobStartingEventArgs> JobStarting;

    public extern event TypedEventHandler<PrintWorkflowJobBackgroundSession, PrintWorkflowPdlModificationRequestedEventArgs> PdlModificationRequested;

    [MethodImpl]
    public extern void Start();
  }
}
