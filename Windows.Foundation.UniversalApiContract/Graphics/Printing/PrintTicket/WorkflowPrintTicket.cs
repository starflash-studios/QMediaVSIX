// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.WorkflowPrintTicket
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  /// <summary>This class represents an XML *PrintTicket document* and allows it to be modified easily. The *PrintTicket document* contains instructions on how the printer should set its various features for a printing task.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WorkflowPrintTicket : IWorkflowPrintTicket
  {
    /// <summary>Gets the canonical name of this print ticket.</summary>
    /// <returns>The canonical name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the XML namespace for the print ticket.</summary>
    /// <returns>The XML namespace.</returns>
    public extern string XmlNamespace { [MethodImpl] get; }

    /// <summary>Gets the XML node for the print ticket.</summary>
    /// <returns>The XML node.</returns>
    public extern IXmlNode XmlNode { [MethodImpl] get; }

    /// <summary>Gets the print capabilities object for this print ticket.</summary>
    /// <returns>The print ticket capabilities.</returns>
    [MethodImpl]
    public extern PrintTicketCapabilities GetCapabilities();

    /// <summary>Gets the document binding configuration for this print ticket.</summary>
    /// <returns>The document binding feature object.</returns>
    public extern PrintTicketFeature DocumentBindingFeature { [MethodImpl] get; }

    /// <summary>Gets the document collation configuration for this print ticket.</summary>
    /// <returns>The document collation feature object.</returns>
    public extern PrintTicketFeature DocumentCollateFeature { [MethodImpl] get; }

    /// <summary>Gets the duplex printing configuration for this print ticket.</summary>
    /// <returns>The duplex printing feature object.</returns>
    public extern PrintTicketFeature DocumentDuplexFeature { [MethodImpl] get; }

    /// <summary>Gets the document hole-punch configuration for this print ticket.</summary>
    /// <returns>The document hole-punch feature object.</returns>
    public extern PrintTicketFeature DocumentHolePunchFeature { [MethodImpl] get; }

    /// <summary>Gets the printing input bin configuration for this print ticket.</summary>
    /// <returns>The printing input bin feature object.</returns>
    public extern PrintTicketFeature DocumentInputBinFeature { [MethodImpl] get; }

    /// <summary>Gets the N-up printing configuration for this print ticket.</summary>
    /// <returns>The N-up printing feature object.</returns>
    public extern PrintTicketFeature DocumentNUpFeature { [MethodImpl] get; }

    /// <summary>Gets the document staple configuration for this print ticket.</summary>
    /// <returns>The document staple feature object.</returns>
    public extern PrintTicketFeature DocumentStapleFeature { [MethodImpl] get; }

    /// <summary>Gets the job passcode configuration for this print ticket.</summary>
    /// <returns>The job passcode feature object.</returns>
    public extern PrintTicketFeature JobPasscodeFeature { [MethodImpl] get; }

    /// <summary>Gets the document borderless configuration for this print ticket.</summary>
    /// <returns>The borderless feature object.</returns>
    public extern PrintTicketFeature PageBorderlessFeature { [MethodImpl] get; }

    /// <summary>Gets the page media size configuration for this print ticket.</summary>
    /// <returns>The page media size feature object.</returns>
    public extern PrintTicketFeature PageMediaSizeFeature { [MethodImpl] get; }

    /// <summary>Gets the page media type configuration for this print ticket.</summary>
    /// <returns>The page media type feature object.</returns>
    public extern PrintTicketFeature PageMediaTypeFeature { [MethodImpl] get; }

    /// <summary>Gets the page orientation configuration for this print ticket.</summary>
    /// <returns>The page orientation feature object.</returns>
    public extern PrintTicketFeature PageOrientationFeature { [MethodImpl] get; }

    /// <summary>Gets the page color configuration for this print ticket.</summary>
    /// <returns>The page color feature object.</returns>
    public extern PrintTicketFeature PageOutputColorFeature { [MethodImpl] get; }

    /// <summary>Gets the page quality configuration for this print ticket.</summary>
    /// <returns>The page quality feature object.</returns>
    public extern PrintTicketFeature PageOutputQualityFeature { [MethodImpl] get; }

    /// <summary>Gets the page resolution configuration for this print ticket.</summary>
    /// <returns>The page resolution feature object.</returns>
    public extern PrintTicketFeature PageResolutionFeature { [MethodImpl] get; }

    /// <summary>Gets the specified print feature object.</summary>
    /// <param name="name">The canonical name of the print feature.</param>
    /// <param name="xmlNamespace">The XML namespace of the print feature.</param>
    /// <returns>The specified print feature object.</returns>
    [MethodImpl]
    public extern PrintTicketFeature GetFeature(string name, string xmlNamespace);

    /// <summary>Notifies the print system that the XML DOM object has changed.</summary>
    /// <returns>This method does not return a value.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction NotifyXmlChangedAsync();

    /// <summary>Checks that the given print ticket does not ask for any printing functionality that the printer does not support.</summary>
    /// <returns>An asynchronous operation with a validation result object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WorkflowPrintTicketValidationResult> ValidateAsync();

    /// <summary>Gets the parameter initializer object for a specified printing parameter.</summary>
    /// <param name="name">The canonical name of the printing parameter</param>
    /// <param name="xmlNamespace">The XML namespace of the printing parameter.</param>
    /// <returns>The parameter initializer object.</returns>
    [MethodImpl]
    public extern PrintTicketParameterInitializer GetParameterInitializer(
      string name,
      string xmlNamespace);

    /// <summary>Sets the parameter initializer object for a specified printing parameter. This can only be done if an initializer for the specified parameter doesn't yet exist.</summary>
    /// <param name="name">The canonical name of the printing parameter</param>
    /// <param name="xmlNamespace">The XML namespace of the printing parameter.</param>
    /// <param name="integerValue">The int value to set this parameter to.</param>
    /// <returns>The parameter initializer object for the newly set parameter.</returns>
    [MethodImpl]
    public extern PrintTicketParameterInitializer SetParameterInitializerAsInteger(
      string name,
      string xmlNamespace,
      int integerValue);

    /// <summary>Sets the given print parameter to the given string value. This can only be done if an initializer for the specified parameter doesn't yet exist.</summary>
    /// <param name="name">The canonical name of the printing parameter.</param>
    /// <param name="xmlNamespace">The XML namespace of the printing parameter.</param>
    /// <param name="stringValue">The value to set this parameter to.</param>
    /// <returns>The parameter initializer object for the newly set parameter.</returns>
    [MethodImpl]
    public extern PrintTicketParameterInitializer SetParameterInitializerAsString(
      string name,
      string xmlNamespace,
      string stringValue);

    /// <summary>Merges a newly configured print ticket onto the current print ticket and validates the merged ticket, guaranteeing that it does not ask for any printing functionality that the printer does not support.</summary>
    /// <param name="deltaShemaTicket">The print ticket object that has been configured.</param>
    /// <returns>The validated print ticket object.</returns>
    [MethodImpl]
    public extern WorkflowPrintTicket MergeAndValidateTicket(
      WorkflowPrintTicket deltaShemaTicket);
  }
}
