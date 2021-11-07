// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowPdlDataAvailableEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(3568134992, 5447, 22929, 160, 239, 226, 238, 32, 33, 21, 24)]
  [ExclusiveTo(typeof (PrintWorkflowPdlDataAvailableEventArgs))]
  internal interface IPrintWorkflowPdlDataAvailableEventArgs
  {
    PrintWorkflowConfiguration Configuration { get; }

    PrintWorkflowPrinterJob PrinterJob { get; }

    PrintWorkflowPdlSourceContent SourceContent { get; }

    Deferral GetDeferral();
  }
}
