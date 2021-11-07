// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowJobStartingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Printers;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  [ExclusiveTo(typeof (PrintWorkflowJobStartingEventArgs))]
  [Guid(3822689192, 12717, 24073, 176, 215, 96, 27, 151, 241, 97, 173)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IPrintWorkflowJobStartingEventArgs
  {
    PrintWorkflowConfiguration Configuration { get; }

    IppPrintDevice Printer { get; }

    void SetSkipSystemRendering();

    Deferral GetDeferral();
  }
}
