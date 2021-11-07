// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.PrintTicketParameterDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  /// <summary>Represents the definition and value characteristics of a print parameter.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PrintTicketParameterDefinition : IPrintTicketParameterDefinition
  {
    /// <summary>Gets the canonical name of this print parameter</summary>
    /// <returns>The canonical name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the XML namespace of the print parameter.</summary>
    /// <returns>The XML namespace.</returns>
    public extern string XmlNamespace { [MethodImpl] get; }

    /// <summary>Get the XML node of the print parameter.</summary>
    /// <returns>The XML node.</returns>
    public extern IXmlNode XmlNode { [MethodImpl] get; }

    /// <summary>Gets the data type of this print parameter.</summary>
    /// <returns>The parameter data type.</returns>
    public extern PrintTicketParameterDataType DataType { [MethodImpl] get; }

    /// <summary>Gets the unit type associated with the value of this print parameter.</summary>
    /// <returns>A string indicating the unit type.</returns>
    public extern string UnitType { [MethodImpl] get; }

    /// <summary>Gets the minimum value that can be assigned to this print parameter (assuming an integer datatype) or the minimum length of string that can be assigned (assuming a string datatype).</summary>
    /// <returns>An `int` indicating the minimum value.</returns>
    public extern int RangeMin { [MethodImpl] get; }

    /// <summary>Gets the maximum value that can be assigned to this print parameter (assuming an integer datatype) or the maximum length of string that can be assigned (assuming a string datatype).</summary>
    /// <returns>An `int` indicating the maximum value.</returns>
    public extern int RangeMax { [MethodImpl] get; }
  }
}
