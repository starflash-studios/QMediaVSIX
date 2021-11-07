// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowPdlModificationRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Printers;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing.Workflow
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  public sealed class PrintWorkflowPdlModificationRequestedEventArgs : 
    IPrintWorkflowPdlModificationRequestedEventArgs
  {
    public extern PrintWorkflowConfiguration Configuration { [MethodImpl] get; }

    public extern PrintWorkflowPrinterJob PrinterJob { [MethodImpl] get; }

    public extern PrintWorkflowPdlSourceContent SourceContent { [MethodImpl] get; }

    public extern PrintWorkflowUILauncher UILauncher { [MethodImpl] get; }

    [MethodImpl]
    public extern PrintWorkflowPdlTargetStream CreateJobOnPrinter(
      string targetContentType);

    [MethodImpl]
    public extern PrintWorkflowPdlTargetStream CreateJobOnPrinterWithAttributes(
      IIterable<IKeyValuePair<string, IppAttributeValue>> jobAttributes,
      string targetContentType);

    [MethodImpl]
    public extern PrintWorkflowPdlTargetStream CreateJobOnPrinterWithAttributesBuffer(
      IBuffer jobAttributesBuffer,
      string targetContentType);

    [MethodImpl]
    public extern PrintWorkflowPdlConverter GetPdlConverter(
      PrintWorkflowPdlConversionType conversionType);

    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
