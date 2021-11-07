// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.XmlElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  /// <summary>Encapsulates information specific to XML Element nodes.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class XmlElement : IXmlElement, IXmlNode, IXmlNodeSerializer, IXmlNodeSelector
  {
    /// <summary>Gets the element name.</summary>
    /// <returns>The tag for this element.</returns>
    public extern string TagName { [MethodImpl] get; }

    /// <summary>Returns the value of the attribute.</summary>
    /// <param name="attributeName">The name of the required attribute.</param>
    /// <returns>The string value of the attribute.</returns>
    [MethodImpl]
    public extern string GetAttribute(string attributeName);

    /// <summary>Sets the value of the named attribute.</summary>
    /// <param name="attributeName">The name of the required attribute.</param>
    /// <param name="attributeValue">The new value for the attribute.</param>
    [MethodImpl]
    public extern void SetAttribute(string attributeName, string attributeValue);

    /// <summary>Removes or replaces the named attribute.</summary>
    /// <param name="attributeName">The name of the attribute to be removed.</param>
    [MethodImpl]
    public extern void RemoveAttribute(string attributeName);

    /// <summary>Returns the attribute node.</summary>
    /// <param name="attributeName">The name of the required attribute.</param>
    /// <returns>The returned attribute pointer.</returns>
    [MethodImpl]
    public extern XmlAttribute GetAttributeNode(string attributeName);

    /// <summary>Sets or updates the supplied attribute node on this element.</summary>
    /// <param name="newAttribute">A pointer to the new attribute.</param>
    /// <returns>The returned pointer to the previous attribute (if any) with the same name.</returns>
    [MethodImpl]
    public extern XmlAttribute SetAttributeNode(XmlAttribute newAttribute);

    /// <summary>Removes the specified attribute from this element.</summary>
    /// <param name="attributeNode">The attribute to be removed.</param>
    /// <returns>The removed attribute, if any.</returns>
    [MethodImpl]
    public extern XmlAttribute RemoveAttributeNode(XmlAttribute attributeNode);

    /// <summary>Returns a list of all descendant elements that match the supplied name.</summary>
    /// <param name="tagName">The tag of the required elements.</param>
    /// <returns>The required elements. The list can be empty.</returns>
    [MethodImpl]
    public extern XmlNodeList GetElementsByTagName(string tagName);

    /// <summary>Sets the value of the named attribute in the given namespace.</summary>
    /// <param name="namespaceUri">The namespace of the attribute being set.</param>
    /// <param name="qualifiedName">The name of the attribute being set.</param>
    /// <param name="value">The new value for the attribute.</param>
    [MethodImpl]
    public extern void SetAttributeNS([Variant] object namespaceUri, string qualifiedName, string value);

    /// <summary>Returns the value of the attribute.</summary>
    /// <param name="namespaceUri">The namespace of the attribute to get.</param>
    /// <param name="localName">The name of the attribute without the namespace prefix.</param>
    /// <returns>The string value of the attribute.</returns>
    [MethodImpl]
    public extern string GetAttributeNS([Variant] object namespaceUri, string localName);

    /// <summary>Removes the specified attribute from this element in the specified namespace.</summary>
    /// <param name="namespaceUri">The namespace of attribute to be removed.</param>
    /// <param name="localName">The name of the attribute without the namespace prefix.</param>
    [MethodImpl]
    public extern void RemoveAttributeNS([Variant] object namespaceUri, string localName);

    /// <summary>Sets or updates the supplied attribute node on this element. If you are not using any namespaces, then use the SetAttributeNode method.</summary>
    /// <param name="newAttribute">The node to add to the collection.</param>
    /// <returns>The attribute successfully added to the collection. If Null, no object is created.</returns>
    [MethodImpl]
    public extern XmlAttribute SetAttributeNodeNS(XmlAttribute newAttribute);

    /// <summary>Returns the specified attribute from the specified namespace.</summary>
    /// <param name="namespaceUri">The namespace of the attribute to get.</param>
    /// <param name="localName">The name of the attribute without the namespace prefix.</param>
    /// <returns>The returned attribute pointer.</returns>
    [MethodImpl]
    public extern XmlAttribute GetAttributeNodeNS([Variant] object namespaceUri, string localName);

    /// <summary>Gets or sets the text associated with the node.</summary>
    /// <returns>The text associated with the node.</returns>
    public extern object NodeValue { [MethodImpl] [return: Variant] get; [MethodImpl] [param: Variant] set; }

    /// <summary>Gets the XML Document Object Model (DOM) node type, which determines valid values and whether the node can have child nodes.</summary>
    /// <returns>The node type.</returns>
    public extern NodeType NodeType { [MethodImpl] get; }

    /// <summary>Returns the qualified name for attribute, document type, element, entity, or notation nodes. Returns a fixed string for all other node types.</summary>
    /// <returns>The qualified node name, which varies depending on the node type.</returns>
    public extern string NodeName { [MethodImpl] get; }

    /// <summary>Gets the parent node of the node instance.</summary>
    /// <returns>The parent node.</returns>
    public extern IXmlNode ParentNode { [MethodImpl] get; }

    /// <summary>Gets a list of children in the current node.</summary>
    /// <returns>The list of child nodes.</returns>
    public extern XmlNodeList ChildNodes { [MethodImpl] get; }

    /// <summary>Gets the first child node.</summary>
    /// <returns>The first child node. This property returns NULL if there are no children.</returns>
    public extern IXmlNode FirstChild { [MethodImpl] get; }

    /// <summary>Gets the last child node.</summary>
    /// <returns>The last child node. This property is NULL if there are no children.</returns>
    public extern IXmlNode LastChild { [MethodImpl] get; }

    /// <summary>Gets the previous sibling of the node in the parent's child list.</summary>
    /// <returns>The left sibling of this node.</returns>
    public extern IXmlNode PreviousSibling { [MethodImpl] get; }

    /// <summary>Gets the next sibling of the node in the parent's child list.</summary>
    /// <returns>The right sibling of this node.</returns>
    public extern IXmlNode NextSibling { [MethodImpl] get; }

    /// <summary>Gets the list of attributes of this node.</summary>
    /// <returns>The attributes for this node.</returns>
    public extern XmlNamedNodeMap Attributes { [MethodImpl] get; }

    /// <summary>Determines whether a node has children.</summary>
    /// <returns>True if this node has children; otherwise false.</returns>
    [MethodImpl]
    public extern bool HasChildNodes();

    /// <summary>Returns the root of the document that contains the node.</summary>
    /// <returns>The parent document that represents the root of the document.</returns>
    public extern XmlDocument OwnerDocument { [MethodImpl] get; }

    /// <summary>Inserts a child node to the left of the specified node, or at the end of the list.</summary>
    /// <param name="newChild">The address of the new node to be inserted. The node passed here must be a valid child of the current XML DOM document node. For example, if the current node is an attribute, you cannot pass another attribute in the *newChild* parameter, because an attribute cannot have an attribute as a child. If *newChild* is a DOCUMENT_FRAGMENT node type, all its children are inserted in order before *referenceChild*.</param>
    /// <param name="referenceChild">The reference node. The node specified is where the *newChild* node is to be inserted to the left as the preceding sibling in the child list. The node passed here must be a either a child node of the current node or null. If the value is null, the *newChild* node is inserted at the end of the child list. If the *referenceChild* node is not a child of the current node, an error is returned.</param>
    /// <returns>On success, the child node that was inserted. If null, no object is created.</returns>
    [MethodImpl]
    public extern IXmlNode InsertBefore(IXmlNode newChild, IXmlNode referenceChild);

    /// <summary>Replaces the specified old child node with the supplied new child node.</summary>
    /// <param name="newChild">The new child that is to replace the old child. If null, the *referenceChild* parameter is removed without a replacement.</param>
    /// <param name="referenceChild">The old child that is to be replaced by the new child.</param>
    /// <returns>The old child that is replaced. If null, no object is created.</returns>
    [MethodImpl]
    public extern IXmlNode ReplaceChild(IXmlNode newChild, IXmlNode referenceChild);

    /// <summary>Removes the specified child node from the list of children and returns it.</summary>
    /// <param name="childNode">The child node to be removed from the list of children of this node.</param>
    /// <returns>The removed child node. If null, the *childNode* object is not removed.</returns>
    [MethodImpl]
    public extern IXmlNode RemoveChild(IXmlNode childNode);

    /// <summary>Appends a new child node as the last child of the node.</summary>
    /// <param name="newChild">The new child node to be appended to the end of the list of children of this node.</param>
    /// <returns>The new child node successfully appended to the list. If null, no object is created.</returns>
    [MethodImpl]
    public extern IXmlNode AppendChild(IXmlNode newChild);

    /// <summary>Clones a new node.</summary>
    /// <param name="deep">A flag that indicates whether to recursively clone all nodes that are descendants of this node. If true, this method creates a clone of the complete tree below this node. If false, this method clones this node and its attributes only.</param>
    /// <returns>The newly created clone node.</returns>
    [MethodImpl]
    public extern IXmlNode CloneNode(bool deep);

    /// <summary>Returns the Uniform Resource Identifier (URI) for the namespace.</summary>
    /// <returns>The Uri for the namespace. This refers to the "uuu" portion of the namespace declaration xmlns:nnn="uuu".</returns>
    public extern object NamespaceUri { [MethodImpl] [return: Variant] get; }

    /// <summary>Gets the local name, which is the local part of a qualified name. This is called the local part in Namespaces in XML.</summary>
    /// <returns>The local name.</returns>
    public extern object LocalName { [MethodImpl] [return: Variant] get; }

    /// <summary>Gets or sets the namespace prefix.</summary>
    /// <returns>The namespace prefix specified on the element, attribute, or entity reference. For example, for the element &lt;xxx:yyy&gt;, this property returns xxx. It returns an empty string, "", if no prefix is specified.</returns>
    public extern object Prefix { [MethodImpl] [return: Variant] get; [MethodImpl] [param: Variant] set; }

    /// <summary>Normalizes all descendant elements by combining two or more adjacent text nodes into one unified text node.</summary>
    [MethodImpl]
    public extern void Normalize();

    /// <summary>Applies the specified pattern-matching operation to this node's context and returns the first matching node.</summary>
    /// <param name="xpath">Specifies an XPath expression.</param>
    /// <returns>The first node that matches the given pattern-matching operation. If no nodes match the expression, the method returns a null value.</returns>
    [MethodImpl]
    public extern IXmlNode SelectSingleNode(string xpath);

    /// <summary>Applies the specified pattern-matching operation to this node's context and returns the list of matching nodes as an XmlNodeList.</summary>
    /// <param name="xpath">Specifies an XPath expression.</param>
    /// <returns>The collection of nodes selected by applying the given pattern-matching operation. If no nodes are selected, this method returns an empty collection.</returns>
    [MethodImpl]
    public extern XmlNodeList SelectNodes(string xpath);

    /// <summary>Applies the specified pattern-matching operation to this node's context and returns the first matching node.</summary>
    /// <param name="xpath">Specifies an XPath expression.</param>
    /// <param name="namespaces">Contains a string that specifies the namespaces to use in XPath expressions when it is necessary to define new namespaces externally. Namespaces are defined in the XML style, as a space-separated list of namespace declaration attributes. You can use this property to set the default namespace as well.</param>
    /// <returns>The first node that matches the given pattern-matching operation. If no nodes match the expression, this method returns a null value.</returns>
    [MethodImpl]
    public extern IXmlNode SelectSingleNodeNS(string xpath, [Variant] object namespaces);

    /// <summary>Applies the specified pattern-matching operation to this node's context and returns the list of matching nodes as an XmlNodeList.</summary>
    /// <param name="xpath">Specifies an XPath expression.</param>
    /// <param name="namespaces">Contains a string that specifies namespaces for use in XPath expressions when it is necessary to define new namespaces externally. Namespaces are defined in the XML style, as a space-separated list of namespace declaration attributes. You can use this property to set the default namespace as well.</param>
    /// <returns>The collection of nodes selected by applying the given pattern-matching operation. If no nodes are selected, returns an empty collection.</returns>
    [MethodImpl]
    public extern XmlNodeList SelectNodesNS(string xpath, [Variant] object namespaces);

    /// <summary>Returns the XML representation of the node and all its descendants.</summary>
    /// <returns>The XML representation of the node and all its descendants.</returns>
    [MethodImpl]
    public extern string GetXml();

    /// <summary>Gets the text from inside the XML.</summary>
    /// <returns>The text from inside the XML. Returns an empty string if there is no text.</returns>
    public extern string InnerText { [MethodImpl] get; [MethodImpl] set; }
  }
}
