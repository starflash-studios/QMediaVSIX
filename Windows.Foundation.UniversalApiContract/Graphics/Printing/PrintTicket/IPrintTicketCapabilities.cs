// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.IPrintTicketCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (PrintTicketCapabilities))]
  [Guid(2353352843, 48092, 16982, 161, 66, 47, 214, 21, 236, 180, 22)]
  internal interface IPrintTicketCapabilities
  {
    string Name { get; }

    string XmlNamespace { get; }

    IXmlNode XmlNode { get; }

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

    PrintTicketParameterDefinition GetParameterDefinition(
      string name,
      string xmlNamespace);
  }
}
