// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (XmlElement))]
  [Guid(771459615, 27408, 20216, 159, 131, 239, 204, 232, 250, 236, 55)]
  internal interface IXmlElement : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    string TagName { get; }

    string GetAttribute(string attributeName);

    void SetAttribute(string attributeName, string attributeValue);

    void RemoveAttribute(string attributeName);

    XmlAttribute GetAttributeNode(string attributeName);

    XmlAttribute SetAttributeNode(XmlAttribute newAttribute);

    XmlAttribute RemoveAttributeNode(XmlAttribute attributeNode);

    XmlNodeList GetElementsByTagName(string tagName);

    void SetAttributeNS([Variant] object namespaceUri, string qualifiedName, string value);

    string GetAttributeNS([Variant] object namespaceUri, string localName);

    void RemoveAttributeNS([Variant] object namespaceUri, string localName);

    XmlAttribute SetAttributeNodeNS(XmlAttribute newAttribute);

    XmlAttribute GetAttributeNodeNS([Variant] object namespaceUri, string localName);
  }
}
