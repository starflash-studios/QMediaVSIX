// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowPrinterJob
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Printers;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing.PrintTicket;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing.Workflow
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PrintWorkflowPrinterJob : IPrintWorkflowPrinterJob
  {
    public extern int JobId { [MethodImpl] get; }

    public extern IppPrintDevice Printer { [MethodImpl] get; }

    [MethodImpl]
    public extern PrintWorkflowPrinterJobStatus GetJobStatus();

    [MethodImpl]
    public extern WorkflowPrintTicket GetJobPrintTicket();

    [MethodImpl]
    public extern IBuffer GetJobAttributesAsBuffer(IIterable<string> attributeNames);

    [MethodImpl]
    public extern IMap<string, IppAttributeValue> GetJobAttributes(
      IIterable<string> attributeNames);

    [MethodImpl]
    public extern IppSetAttributesResult SetJobAttributesFromBuffer(
      IBuffer jobAttributesBuffer);

    [MethodImpl]
    public extern IppSetAttributesResult SetJobAttributes(
      IIterable<IKeyValuePair<string, IppAttributeValue>> jobAttributes);
  }
}
