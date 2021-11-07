// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.PrintTicketCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  /// <summary>This class presents the configuration options that are supported by the printer. It contains read-only print feature objects with certain options available for each.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PrintTicketCapabilities : IPrintTicketCapabilities
  {
    /// <summary>Gets the canonical name of this object.</summary>
    /// <returns>The canonical name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the XML namespace for this capabilities object.</summary>
    /// <returns>The XML namespace.</returns>
    public extern string XmlNamespace { [MethodImpl] get; }

    /// <summary>Gets the XML node for this capabilities object.</summary>
    /// <returns>The XML node.</returns>
    public extern IXmlNode XmlNode { [MethodImpl] get; }

    /// <summary>Gets the available document binding feature for this print ticket.</summary>
    /// <returns>The document binding feature object.</returns>
    public extern PrintTicketFeature DocumentBindingFeature { [MethodImpl] get; }

    /// <summary>Gets the available document collation feature for this print ticket.</summary>
    /// <returns>The document collation feature object.</returns>
    public extern PrintTicketFeature DocumentCollateFeature { [MethodImpl] get; }

    /// <summary>Gets the available duplex printing feature for this print ticket.</summary>
    /// <returns>The duplex printing feature object.</returns>
    public extern PrintTicketFeature DocumentDuplexFeature { [MethodImpl] get; }

    /// <summary>Gets the available document hole-punch feature for this print ticket.</summary>
    /// <returns>The document hole-punch feature object.</returns>
    public extern PrintTicketFeature DocumentHolePunchFeature { [MethodImpl] get; }

    /// <summary>Gets the available printing input bin feature for this print ticket.</summary>
    /// <returns>The printing input bin feature object.</returns>
    public extern PrintTicketFeature DocumentInputBinFeature { [MethodImpl] get; }

    /// <summary>Gets the available N-up printing feature for this print ticket.</summary>
    /// <returns>The N-up printing feature object.</returns>
    public extern PrintTicketFeature DocumentNUpFeature { [MethodImpl] get; }

    /// <summary>Gets the available document staple feature for this print ticket.</summary>
    /// <returns>The document staple feature object.</returns>
    public extern PrintTicketFeature DocumentStapleFeature { [MethodImpl] get; }

    /// <summary>Gets the avilable job passcode feature for this print ticket.</summary>
    /// <returns>The job passcode feature object.</returns>
    public extern PrintTicketFeature JobPasscodeFeature { [MethodImpl] get; }

    /// <summary>Gets the available document borderless feature for this print ticket.</summary>
    /// <returns>The borderless feature object.</returns>
    public extern PrintTicketFeature PageBorderlessFeature { [MethodImpl] get; }

    /// <summary>Gets the available page media size feature for this print ticket.</summary>
    /// <returns>The page media size feature object.</returns>
    public extern PrintTicketFeature PageMediaSizeFeature { [MethodImpl] get; }

    /// <summary>Gets the available page media type feature for this print ticket.</summary>
    /// <returns>The page media type feature object.</returns>
    public extern PrintTicketFeature PageMediaTypeFeature { [MethodImpl] get; }

    /// <summary>Gets the available page orientation feature for this print ticket.</summary>
    /// <returns>The page orientation feature object.</returns>
    public extern PrintTicketFeature PageOrientationFeature { [MethodImpl] get; }

    /// <summary>Gets the available page color feature for this print ticket.</summary>
    /// <returns>The page color feature object.</returns>
    public extern PrintTicketFeature PageOutputColorFeature { [MethodImpl] get; }

    /// <summary>Gets the available page quality feature for this print ticket.</summary>
    /// <returns>The page quality feature object.</returns>
    public extern PrintTicketFeature PageOutputQualityFeature { [MethodImpl] get; }

    /// <summary>Gets the available page resolution feature for this print ticket.</summary>
    /// <returns>The page resolution feature object.</returns>
    public extern PrintTicketFeature PageResolutionFeature { [MethodImpl] get; }

    /// <summary>Gets the specified print feature object.</summary>
    /// <param name="name">The canonical name of the print feature.</param>
    /// <param name="xmlNamespace">The XML namespace of the print feature.</param>
    /// <returns>The specified print feature object.</returns>
    [MethodImpl]
    public extern PrintTicketFeature GetFeature(string name, string xmlNamespace);

    /// <summary>Gets the parameter definition object for the specified printing parameter.</summary>
    /// <param name="name">The canonical name of the printing parameter.</param>
    /// <param name="xmlNamespace">The XML namespace of the printing parameter.</param>
    /// <returns>The parameter definition object.</returns>
    [MethodImpl]
    public extern PrintTicketParameterDefinition GetParameterDefinition(
      string name,
      string xmlNamespace);
  }
}
