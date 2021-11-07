// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.PrintTicketParameterInitializer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  /// <summary>Represents a the selected setting for a printing parameter. A printing parameter is a device capability that can be set to values within a range, unlike a feature which has an enumerable list of settings.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PrintTicketParameterInitializer : IPrintTicketParameterInitializer
  {
    /// <summary>Gets the canonical name of the print parameter.</summary>
    /// <returns>The canonical name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the XML namespace of the print parameter.</summary>
    /// <returns>The XML namespace.</returns>
    public extern string XmlNamespace { [MethodImpl] get; }

    /// <summary>Gets the XML node of the print parameter.</summary>
    /// <returns>The XML node.</returns>
    public extern IXmlNode XmlNode { [MethodImpl] get; }

    /// <summary>Gets or sets the value of the print parameter.</summary>
    /// <returns>The value.</returns>
    public extern PrintTicketValue Value { [MethodImpl] set; [MethodImpl] get; }
  }
}
