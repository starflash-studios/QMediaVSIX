// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowPdlConverter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing.PrintTicket;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing.Workflow
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(1080052578, 2788, 20977, 129, 143, 115, 29, 192, 176, 5, 171)]
  [ExclusiveTo(typeof (PrintWorkflowPdlConverter))]
  internal interface IPrintWorkflowPdlConverter
  {
    [RemoteAsync]
    IAsyncAction ConvertPdlAsync(
      WorkflowPrintTicket printTicket,
      IInputStream inputStream,
      IOutputStream outputStream);
  }
}
