// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.IPrintTicketParameterDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  [Guid(3602560228, 10594, 19457, 183, 243, 154, 146, 148, 235, 131, 53)]
  [ExclusiveTo(typeof (PrintTicketParameterDefinition))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IPrintTicketParameterDefinition
  {
    string Name { get; }

    string XmlNamespace { get; }

    IXmlNode XmlNode { get; }

    PrintTicketParameterDataType DataType { get; }

    string UnitType { get; }

    int RangeMin { get; }

    int RangeMax { get; }
  }
}
