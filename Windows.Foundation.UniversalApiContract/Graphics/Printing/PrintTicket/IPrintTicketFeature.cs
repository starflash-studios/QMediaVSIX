// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.IPrintTicketFeature
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3881860458, 23029, 16643, 136, 88, 185, 119, 16, 150, 61, 57)]
  [ExclusiveTo(typeof (PrintTicketFeature))]
  internal interface IPrintTicketFeature
  {
    string Name { get; }

    string XmlNamespace { get; }

    IXmlNode XmlNode { get; }

    string DisplayName { get; }

    PrintTicketOption GetOption(string name, string xmlNamespace);

    IVectorView<PrintTicketOption> Options { get; }

    PrintTicketOption GetSelectedOption();

    void SetSelectedOption(PrintTicketOption value);

    PrintTicketFeatureSelectionType SelectionType { get; }
  }
}
