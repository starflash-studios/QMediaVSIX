// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  /// <summary>Contains information for the entire Document Object Model. This interface represents a single node in the document tree. While all objects that implement this interface expose methods for dealing with children, not all objects that implement this interface may have children.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(477371737, 8482, 18389, 168, 86, 131, 243, 212, 33, 72, 117)]
  public interface IXmlNode : IXmlNodeSelector, IXmlNodeSerializer
  {
    /// <summary>Gets or sets the text associated with the node.</summary>
    /// <returns>The text associated with the node.</returns>
    object NodeValue { [return: Variant] get; [param: Variant] set; }

    /// <summary>Gets the XML Document Object Model (DOM) node type, which determines valid values and whether the node can have child nodes.</summary>
    /// <returns>The node type.</returns>
    NodeType NodeType { get; }

    /// <summary>Returns the qualified name for attribute, document type, element, entity, or notation nodes. Returns a fixed string for all other node types.</summary>
    /// <returns>The qualified node name, which varies depending on the node type.</returns>
    string NodeName { get; }

    /// <summary>Gets the parent node of the node instance.</summary>
    /// <returns>The parent node.</returns>
    IXmlNode ParentNode { get; }

    /// <summary>Gets a list of children in the current node.</summary>
    /// <returns>The list of child nodes.</returns>
    XmlNodeList ChildNodes { get; }

    /// <summary>Gets the first child node.</summary>
    /// <returns>The first child node. This property returns NULL if there are no children.</returns>
    IXmlNode FirstChild { get; }

    /// <summary>Gets the last child node.</summary>
    /// <returns>The last child node. This property is NULL if there are no children.</returns>
    IXmlNode LastChild { get; }

    /// <summary>Gets the previous sibling of the node in the parent's child list.</summary>
    /// <returns>The left sibling of this node.</returns>
    IXmlNode PreviousSibling { get; }

    /// <summary>Gets the next sibling of the node in the parent's child list.</summary>
    /// <returns>The right sibling of this node.</returns>
    IXmlNode NextSibling { get; }

    /// <summary>Gets the list of attributes of this node.</summary>
    /// <returns>The attributes for this node.</returns>
    XmlNamedNodeMap Attributes { get; }

    /// <summary>Determines whether a node has children.</summary>
    /// <returns>True if this node has children; otherwise false.</returns>
    bool HasChildNodes();

    /// <summary>Returns the root of the document that contains the node.</summary>
    /// <returns>The parent document that represents the root of the document.</returns>
    XmlDocument OwnerDocument { get; }

    /// <summary>Inserts a child node to the left of the specified node, or at the end of the list.</summary>
    /// <param name="newChild">The address of the new node to be inserted. The node passed here must be a valid child of the current XML DOM document node. For example, if the current node is an attribute, you cannot pass another attribute in the *newChild* parameter, because an attribute cannot have an attribute as a child. If *newChild* is a DOCUMENT_FRAGMENT node type, all its children are inserted in order before *referenceChild*.</param>
    /// <param name="referenceChild">The reference node. The node specified is where the *newChild* node is to be inserted to the left as the preceding sibling in the child list. The node passed here must be a either a child node of the current node or null. If the value is null, the *newChild* node is inserted at the end of the child list. If the *referenceChild* node is not a child of the current node, an error is returned.</param>
    /// <returns>On success, the child node that was inserted. If null, no object is created.</returns>
    IXmlNode InsertBefore(IXmlNode newChild, IXmlNode referenceChild);

    /// <summary>Replaces the specified old child node with the supplied new child node.</summary>
    /// <param name="newChild">The new child that is to replace the old child. If null, the *referenceChild* parameter is removed without a replacement.</param>
    /// <param name="referenceChild">The old child that is to be replaced by the new child.</param>
    /// <returns>The old child that is replaced. If null, no object is created.</returns>
    IXmlNode ReplaceChild(IXmlNode newChild, IXmlNode referenceChild);

    /// <summary>Removes the specified child node from the list of children and returns it.</summary>
    /// <param name="childNode">The child node to be removed from the list of children of this node.</param>
    /// <returns>The removed child node. If null, the *childNode* object is not removed.</returns>
    IXmlNode RemoveChild(IXmlNode childNode);

    /// <summary>Appends a new child node as the last child of the node.</summary>
    /// <param name="newChild">The new child node to be appended to the end of the list of children of this node.</param>
    /// <returns>The new child node successfully appended to the list. If null, no object is created.</returns>
    IXmlNode AppendChild(IXmlNode newChild);

    /// <summary>Clones a new node.</summary>
    /// <param name="deep">A flag that indicates whether to recursively clone all nodes that are descendants of this node. If true, this method creates a clone of the complete tree below this node. If false, this method clones this node and its attributes only.</param>
    /// <returns>The newly created clone node.</returns>
    IXmlNode CloneNode(bool deep);

    /// <summary>Returns the Uniform Resource Identifier (URI) for the namespace.</summary>
    /// <returns>The Uri for the namespace. This refers to the "uuu" portion of the namespace declaration xmlns:nnn="uuu".</returns>
    object NamespaceUri { [return: Variant] get; }

    /// <summary>Gets the local name, which is the local part of a qualified name. This is called the local part in Namespaces in XML.</summary>
    /// <returns>The local name.</returns>
    object LocalName { [return: Variant] get; }

    /// <summary>Gets or sets the namespace prefix.</summary>
    /// <returns>The namespace prefix specified on the element, attribute, or entity reference. For example, for the element &lt;xxx:yyy&gt;, this property returns xxx. It returns an empty string, "", if no prefix is specified.</returns>
    object Prefix { [return: Variant] get; [param: Variant] set; }

    /// <summary>Normalizes all descendant elements by combining two or more adjacent text nodes into one unified text node.</summary>
    void Normalize();
  }
}
