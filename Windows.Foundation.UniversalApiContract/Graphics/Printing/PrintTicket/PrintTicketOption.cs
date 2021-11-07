// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.PrintTicketOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  /// <summary>Represents a single possible setting for a print feature.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  public sealed class PrintTicketOption : IPrintTicketOption
  {
    /// <summary>Gets the canonical name of this print option.</summary>
    /// <returns>The canonical name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the XML namespace of this print option.</summary>
    /// <returns>The XML namespace.</returns>
    public extern string XmlNamespace { [MethodImpl] get; }

    /// <summary>Gets the XML node of this print option.</summary>
    /// <returns>The XML node.</returns>
    public extern IXmlNode XmlNode { [MethodImpl] get; }

    /// <summary>Gets the UI-friendly display name of this option.</summary>
    /// <returns>The display name.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the XML node of a property element of the current print option.</summary>
    /// <param name="name">The canonical name of the property.</param>
    /// <param name="xmlNamespace">The XML namespace of the property.</param>
    /// <returns>The XML node for the property element.</returns>
    [MethodImpl]
    public extern IXmlNode GetPropertyNode(string name, string xmlNamespace);

    /// <summary>Gets the XML node of a scored property element of the current print option.</summary>
    /// <param name="name">The canonical name of the scored property.</param>
    /// <param name="xmlNamespace">The XML namespace of the scored property.</param>
    /// <returns>The XML node for the property element.</returns>
    [MethodImpl]
    public extern IXmlNode GetScoredPropertyNode(string name, string xmlNamespace);

    /// <summary>Gets the value associated with a property element of the current print option.</summary>
    /// <param name="name">The canonical name of the property.</param>
    /// <param name="xmlNamespace">The XML namespace of the property.</param>
    /// <returns>The value associated with the property.</returns>
    [MethodImpl]
    public extern PrintTicketValue GetPropertyValue(
      string name,
      string xmlNamespace);

    /// <summary>Gets the value associated with a scored property element of the current print option.</summary>
    /// <param name="name">The canonical name of the scored property.</param>
    /// <param name="xmlNamespace">The XML namespace of the scored property.</param>
    /// <returns>The value associated with the scored property.</returns>
    [MethodImpl]
    public extern PrintTicketValue GetScoredPropertyValue(
      string name,
      string xmlNamespace);
  }
}
