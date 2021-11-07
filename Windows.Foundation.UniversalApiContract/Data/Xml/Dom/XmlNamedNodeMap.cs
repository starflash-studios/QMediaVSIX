// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.XmlNamedNodeMap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  /// <summary>Encapsulates iteration through the collection of attribute nodes.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class XmlNamedNodeMap : IXmlNamedNodeMap, IVectorView<IXmlNode>, IIterable<IXmlNode>
  {
    /// <summary>Gets the length of the list of nodes.</summary>
    /// <returns>The number of nodes in the list.</returns>
    public extern uint Length { [MethodImpl] get; }

    /// <summary>Allows random access to individual nodes within the collection.</summary>
    /// <param name="index">The index of the item within the collection. The first item is zero.</param>
    /// <returns>The object to access. This method returns **null** if the index is out of range.</returns>
    [MethodImpl]
    public extern IXmlNode Item(uint index);

    /// <summary>Retrieves the attribute with the specified name.</summary>
    /// <param name="name">The name of the attribute.</param>
    /// <returns>The returned attribute with the specified name. This method returns Null if the attribute node is not in this collection.</returns>
    [MethodImpl]
    public extern IXmlNode GetNamedItem(string name);

    /// <summary>Adds the specified node to the collection.</summary>
    /// <param name="node">The node to add to the collection.</param>
    /// <returns>The attribute successfully added to the collection. If Null, no object is created.</returns>
    [MethodImpl]
    public extern IXmlNode SetNamedItem(IXmlNode node);

    /// <summary>Removes the specified item.</summary>
    /// <param name="name">The name of the attribute to remove from the collection.</param>
    /// <returns>The node removed from the collection. This method returns Null if the named node is not an attribute.</returns>
    [MethodImpl]
    public extern IXmlNode RemoveNamedItem(string name);

    /// <summary>Retrieves the attribute with the specified namespace and name.</summary>
    /// <param name="namespaceUri">The namespace name of the attribute.</param>
    /// <param name="name">The name of the attribute.</param>
    /// <returns>The attribute with the specified namespace and name. This method returns Null if the attribute node is not in this collection.</returns>
    [MethodImpl]
    public extern IXmlNode GetNamedItemNS([Variant] object namespaceUri, string name);

    /// <summary>Removes an item that is specified by a namespace and local name.</summary>
    /// <param name="namespaceUri">The namespace name of the attribute.</param>
    /// <param name="name">The name of the attribute.</param>
    /// <returns>The node removed from the collection. This method returns Null if the named node is not an attribute.</returns>
    [MethodImpl]
    public extern IXmlNode RemoveNamedItemNS([Variant] object namespaceUri, string name);

    /// <summary>Adds the specified node to the collection in the specified namespace. If you are not using any namespaces, then use the SetNamedItem method.</summary>
    /// <param name="node">The node to add to the collection.</param>
    /// <returns>The attribute successfully added to the collection. If Null, no object is created.</returns>
    [MethodImpl]
    public extern IXmlNode SetNamedItemNS(IXmlNode node);

    [MethodImpl]
    public extern IXmlNode GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(IXmlNode value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] IXmlNode[] items);

    [MethodImpl]
    public extern IIterator<IXmlNode> First();
  }
}
