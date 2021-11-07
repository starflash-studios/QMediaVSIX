// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlDocument
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [Guid(4159939846, 7815, 17110, 188, 251, 184, 200, 9, 250, 84, 148)]
  [ExclusiveTo(typeof (XmlDocument))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IXmlDocument : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    XmlDocumentType Doctype { get; }

    XmlDomImplementation Implementation { get; }

    XmlElement DocumentElement { get; }

    XmlElement CreateElement(string tagName);

    XmlDocumentFragment CreateDocumentFragment();

    XmlText CreateTextNode(string data);

    XmlComment CreateComment(string data);

    XmlProcessingInstruction CreateProcessingInstruction(
      string target,
      string data);

    XmlAttribute CreateAttribute(string name);

    XmlEntityReference CreateEntityReference(string name);

    XmlNodeList GetElementsByTagName(string tagName);

    XmlCDataSection CreateCDataSection(string data);

    string DocumentUri { get; }

    XmlAttribute CreateAttributeNS([Variant] object namespaceUri, string qualifiedName);

    XmlElement CreateElementNS([Variant] object namespaceUri, string qualifiedName);

    XmlElement GetElementById(string elementId);

    IXmlNode ImportNode(IXmlNode node, bool deep);
  }
}
