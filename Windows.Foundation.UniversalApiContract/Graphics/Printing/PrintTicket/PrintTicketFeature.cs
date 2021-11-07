// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.PrintTicketFeature
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  /// <summary>Represents a modifiable feature of the print ticket. A feature is a device capability that has an enumerable list of settings, unlike a parameter which can be set to values within a range.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class PrintTicketFeature : IPrintTicketFeature
  {
    /// <summary>Gets the canonical name of the print ticket feature.</summary>
    /// <returns>The canonical name string.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the XML namespace that this print feature belongs to.</summary>
    /// <returns>The XML namespace for this print feature.</returns>
    public extern string XmlNamespace { [MethodImpl] get; }

    /// <summary>Gets the XML node that this print feature belongs to.</summary>
    /// <returns>The XML node for this print feature.</returns>
    public extern IXmlNode XmlNode { [MethodImpl] get; }

    /// <summary>Gets the friendly name of the print ticket feature.</summary>
    /// <returns>The friendly name string.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the specified print feature option object.</summary>
    /// <param name="name">The canonical name of the print feature option.</param>
    /// <param name="xmlNamespace">The XML namespace of the print feature option.</param>
    /// <returns>The specified print feature option object.</returns>
    [MethodImpl]
    public extern PrintTicketOption GetOption(string name, string xmlNamespace);

    /// <summary>Gets a list of print ticket options available for this feature.</summary>
    /// <returns>A list of option objects.</returns>
    public extern IVectorView<PrintTicketOption> Options { [MethodImpl] get; }

    /// <summary>Gets the option that is currently selected for this print feature.</summary>
    /// <returns>The selected option.</returns>
    [MethodImpl]
    public extern PrintTicketOption GetSelectedOption();

    /// <summary>Sets the given option as the selected option for this print feature.</summary>
    /// <param name="value">The option to be set as selected.</param>
    [MethodImpl]
    public extern void SetSelectedOption(PrintTicketOption value);

    /// <summary>Gets the selection type for this print feature.</summary>
    /// <returns>The selection type.</returns>
    public extern PrintTicketFeatureSelectionType SelectionType { [MethodImpl] get; }
  }
}
