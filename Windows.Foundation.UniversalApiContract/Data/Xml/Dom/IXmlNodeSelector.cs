// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlNodeSelector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  /// <summary>Encapsulates the methods needed to execute XPath queries on an XML DOM tree or subtree.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1675344523, 53467, 20449, 183, 69, 249, 67, 58, 253, 194, 91)]
  public interface IXmlNodeSelector
  {
    /// <summary>Applies the specified pattern-matching operation to this node's context and returns the first matching node.</summary>
    /// <param name="xpath">Specifies an XPath expression.</param>
    /// <returns>The first node that matches the given pattern-matching operation. If no nodes match the expression, the method returns a null value.</returns>
    IXmlNode SelectSingleNode(string xpath);

    /// <summary>Applies the specified pattern-matching operation to this node's context and returns the list of matching nodes as an XmlNodeList.</summary>
    /// <param name="xpath">Specifies an XPath expression.</param>
    /// <returns>The collection of nodes selected by applying the given pattern-matching operation. If no nodes are selected, this method returns an empty collection.</returns>
    XmlNodeList SelectNodes(string xpath);

    /// <summary>Applies the specified pattern-matching operation to this node's context and returns the first matching node.</summary>
    /// <param name="xpath">Specifies an XPath expression.</param>
    /// <param name="namespaces">Contains a string that specifies the namespaces to use in XPath expressions when it is necessary to define new namespaces externally. Namespaces are defined in the XML style, as a space-separated list of namespace declaration attributes. You can use this property to set the default namespace as well.</param>
    /// <returns>The first node that matches the given pattern-matching operation. If no nodes match the expression, this method returns a null value.</returns>
    IXmlNode SelectSingleNodeNS(string xpath, [Variant] object namespaces);

    /// <summary>Applies the specified pattern-matching operation to this node's context and returns the list of matching nodes as an XmlNodeList.</summary>
    /// <param name="xpath">Specifies an XPath expresssion.</param>
    /// <param name="namespaces">Contains a string that specifies namespaces for use in XPath expressions when it is necessary to define new namespaces externally. Namespaces are defined in the XML style, as a space-separated list of namespace declaration attributes. You can use this property to set the default namespace as well.</param>
    /// <returns>The collection of nodes selected by applying the given pattern-matching operation. If no nodes are selected, returns an empty collection.</returns>
    XmlNodeList SelectNodesNS(string xpath, [Variant] object namespaces);
  }
}
