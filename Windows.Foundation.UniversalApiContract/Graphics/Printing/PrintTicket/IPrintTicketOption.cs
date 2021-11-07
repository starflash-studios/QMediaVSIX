// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.IPrintTicketOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  [ExclusiveTo(typeof (PrintTicketOption))]
  [Guid(2961624976, 45927, 20043, 189, 72, 156, 120, 160, 187, 49, 206)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IPrintTicketOption
  {
    string Name { get; }

    string XmlNamespace { get; }

    IXmlNode XmlNode { get; }

    string DisplayName { get; }

    IXmlNode GetPropertyNode(string name, string xmlNamespace);

    IXmlNode GetScoredPropertyNode(string name, string xmlNamespace);

    PrintTicketValue GetPropertyValue(string name, string xmlNamespace);

    PrintTicketValue GetScoredPropertyValue(string name, string xmlNamespace);
  }
}
