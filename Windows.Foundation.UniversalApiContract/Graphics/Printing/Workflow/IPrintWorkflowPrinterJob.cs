// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowPrinterJob
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Printers;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing.PrintTicket;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing.Workflow
{
  [Guid(302030740, 3348, 21571, 188, 9, 37, 3, 17, 206, 87, 11)]
  [ExclusiveTo(typeof (PrintWorkflowPrinterJob))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IPrintWorkflowPrinterJob
  {
    int JobId { get; }

    IppPrintDevice Printer { get; }

    PrintWorkflowPrinterJobStatus GetJobStatus();

    WorkflowPrintTicket GetJobPrintTicket();

    IBuffer GetJobAttributesAsBuffer(IIterable<string> attributeNames);

    IMap<string, IppAttributeValue> GetJobAttributes(
      IIterable<string> attributeNames);

    IppSetAttributesResult SetJobAttributesFromBuffer(
      IBuffer jobAttributesBuffer);

    IppSetAttributesResult SetJobAttributes(
      IIterable<IKeyValuePair<string, IppAttributeValue>> jobAttributes);
  }
}
