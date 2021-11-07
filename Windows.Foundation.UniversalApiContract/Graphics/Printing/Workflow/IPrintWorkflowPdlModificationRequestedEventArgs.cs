// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.IPrintWorkflowPdlModificationRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Printers;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing.Workflow
{
  [Guid(439589473, 11795, 24285, 167, 7, 206, 236, 97, 215, 51, 59)]
  [ExclusiveTo(typeof (PrintWorkflowPdlModificationRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IPrintWorkflowPdlModificationRequestedEventArgs
  {
    PrintWorkflowConfiguration Configuration { get; }

    PrintWorkflowPrinterJob PrinterJob { get; }

    PrintWorkflowPdlSourceContent SourceContent { get; }

    PrintWorkflowUILauncher UILauncher { get; }

    PrintWorkflowPdlTargetStream CreateJobOnPrinter(
      string targetContentType);

    PrintWorkflowPdlTargetStream CreateJobOnPrinterWithAttributes(
      IIterable<IKeyValuePair<string, IppAttributeValue>> jobAttributes,
      string targetContentType);

    PrintWorkflowPdlTargetStream CreateJobOnPrinterWithAttributesBuffer(
      IBuffer jobAttributesBuffer,
      string targetContentType);

    PrintWorkflowPdlConverter GetPdlConverter(
      PrintWorkflowPdlConversionType conversionType);

    Deferral GetDeferral();
  }
}
