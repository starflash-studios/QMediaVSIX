// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.IWorkflowPrintTicket
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  [ExclusiveTo(typeof (WorkflowPrintTicket))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1104487045, 13800, 17550, 168, 197, 228, 182, 162, 207, 130, 108)]
  internal interface IWorkflowPrintTicket
  {
    string Name { get; }

    string XmlNamespace { get; }

    IXmlNode XmlNode { get; }

    PrintTicketCapabilities GetCapabilities();

    PrintTicketFeature DocumentBindingFeature { get; }

    PrintTicketFeature DocumentCollateFeature { get; }

    PrintTicketFeature DocumentDuplexFeature { get; }

    PrintTicketFeature DocumentHolePunchFeature { get; }

    PrintTicketFeature DocumentInputBinFeature { get; }

    PrintTicketFeature DocumentNUpFeature { get; }

    PrintTicketFeature DocumentStapleFeature { get; }

    PrintTicketFeature JobPasscodeFeature { get; }

    PrintTicketFeature PageBorderlessFeature { get; }

    PrintTicketFeature PageMediaSizeFeature { get; }

    PrintTicketFeature PageMediaTypeFeature { get; }

    PrintTicketFeature PageOrientationFeature { get; }

    PrintTicketFeature PageOutputColorFeature { get; }

    PrintTicketFeature PageOutputQualityFeature { get; }

    PrintTicketFeature PageResolutionFeature { get; }

    PrintTicketFeature GetFeature(string name, string xmlNamespace);

    [RemoteAsync]
    IAsyncAction NotifyXmlChangedAsync();

    [RemoteAsync]
    IAsyncOperation<WorkflowPrintTicketValidationResult> ValidateAsync();

    PrintTicketParameterInitializer GetParameterInitializer(
      string name,
      string xmlNamespace);

    PrintTicketParameterInitializer SetParameterInitializerAsInteger(
      string name,
      string xmlNamespace,
      int integerValue);

    PrintTicketParameterInitializer SetParameterInitializerAsString(
      string name,
      string xmlNamespace,
      string stringValue);

    WorkflowPrintTicket MergeAndValidateTicket(
      WorkflowPrintTicket deltaShemaTicket);
  }
}
