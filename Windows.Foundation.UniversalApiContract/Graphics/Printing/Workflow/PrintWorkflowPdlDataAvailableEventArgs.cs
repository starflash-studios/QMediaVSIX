// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowPdlDataAvailableEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PrintWorkflowPdlDataAvailableEventArgs : 
    IPrintWorkflowPdlDataAvailableEventArgs
  {
    public extern PrintWorkflowConfiguration Configuration { [MethodImpl] get; }

    public extern PrintWorkflowPrinterJob PrinterJob { [MethodImpl] get; }

    public extern PrintWorkflowPdlSourceContent SourceContent { [MethodImpl] get; }

    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
