// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlNamedNodeMap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3014041264, 43696, 19330, 166, 250, 177, 69, 63, 124, 2, 27)]
  [ExclusiveTo(typeof (XmlNamedNodeMap))]
  internal interface IXmlNamedNodeMap : IVectorView<IXmlNode>, IIterable<IXmlNode>
  {
    uint Length { get; }

    IXmlNode Item(uint index);

    IXmlNode GetNamedItem(string name);

    IXmlNode SetNamedItem(IXmlNode node);

    IXmlNode RemoveNamedItem(string name);

    IXmlNode GetNamedItemNS([Variant] object namespaceUri, string name);

    IXmlNode RemoveNamedItemNS([Variant] object namespaceUri, string name);

    IXmlNode SetNamedItemNS(IXmlNode node);
  }
}
