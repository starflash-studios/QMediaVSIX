// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  /// <summary>Represents an item in the feed. This class encapsulates information in the **/rss/channel/item** element in *RSS 2.0* or the **atom:entry** element in *Atom 1.0*.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (ISyndicationItemFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SyndicationItem : ISyndicationItem, ISyndicationNode
  {
    [MethodImpl]
    public extern SyndicationItem(string title, SyndicationContent content, Uri uri);

    /// <summary>Creates a new SyndicationItem object.</summary>
    [MethodImpl]
    public extern SyndicationItem();

    /// <summary>Gets the authors of an item. This property represents the collection of all the **atom:author** elements under **atom:entry**.</summary>
    /// <returns>The collection of all the **atom:author** elements under **atom:entry**.</returns>
    public extern IVector<SyndicationPerson> Authors { [MethodImpl] get; }

    /// <summary>Gets a collection of categories of the feed. This property represents the collection of all the **atom:category** elements under **atom:feed**.</summary>
    /// <returns>The collection of all **atom:category** elements under **atom:feed**.</returns>
    public extern IVector<SyndicationCategory> Categories { [MethodImpl] get; }

    /// <summary>Gets a collection of the contributors of the feed. This property represents the collection of all the **atom:contributor** elements under **atom:feed**.</summary>
    /// <returns>The collection of all **atom:contributor** elements under **atom:feed**.</returns>
    public extern IVector<SyndicationPerson> Contributors { [MethodImpl] get; }

    /// <summary>Gets or sets the content of the item.</summary>
    /// <returns>The content of the item.</returns>
    public extern SyndicationContent Content { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the identifier for the syndication feed.</summary>
    /// <returns>The **atom:Id** element or the **guid** element in *RSS 2.0*.</returns>
    public extern string Id { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the most recent time the item was modified. This property represents the **atom:updated** element.</summary>
    /// <returns>The **atom:updated** element.</returns>
    public extern DateTime LastUpdatedTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the links contained in the item.</summary>
    /// <returns>The collection of all the **atom:link** elements under **atom:entry**.</returns>
    public extern IVector<SyndicationLink> Links { [MethodImpl] get; }

    /// <summary>Gets or sets the date the item was published.</summary>
    /// <returns>The **atom:published** element under **atom:entry** or the **pubDate** element under **item** element in *RSS 2.0*.</returns>
    public extern DateTime PublishedDate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets information about the rights of an item. This property represents the **atom:rights** element.</summary>
    /// <returns>The **atom:rights** element.</returns>
    public extern ISyndicationText Rights { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the source feed of the item. This property represents the **atom:source** element or the **source** element in *RSS 2.0*.</summary>
    /// <returns>The **atom:source** element or the **source** element in *RSS 2.0*.</returns>
    public extern SyndicationFeed Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a summary of the item.</summary>
    /// <returns>The **atom:summary** element or the **description** element in *RSS 2.0*.</returns>
    public extern ISyndicationText Summary { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the title of the item.</summary>
    /// <returns>The **atom:title** element.</returns>
    public extern ISyndicationText Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Uniform Resource Identifier (URI) of the comments for the item. This property represents the **/rss/channel/item/comments** element.</summary>
    /// <returns>The **/rss/channel/item/comments** element.</returns>
    public extern Uri CommentsUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the Uniform Resource Identifier (URI) of an editable resource.</summary>
    /// <returns>The **atom:link** element with **rel="edit"**.</returns>
    public extern Uri EditUri { [MethodImpl] get; }

    /// <summary>Gets the Uniform Resource Identifier (URI) of an editable media resource.</summary>
    /// <returns>The **atom:link** element with the attribute **rel=”edit-media”**.</returns>
    public extern Uri EditMediaUri { [MethodImpl] get; }

    /// <summary>Gets an ETag HTTP header.</summary>
    /// <returns>An Etag HTTP header.</returns>
    public extern string ETag { [MethodImpl] get; }

    /// <summary>Gets the Uniform Resource Identifier (URI) of this item. **AtomPubClient** creates this property after new resource is created.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the item.</returns>
    public extern Uri ItemUri { [MethodImpl] get; }

    /// <summary>Initializes the object from the given feed string, which can be in either *RSS 2.0* or *Atom 1.0* format.</summary>
    /// <param name="item">The feed string, which can be in either *RSS 2.0* or *Atom 1.0* format.</param>
    [MethodImpl]
    public extern void Load(string item);

    /// <summary>Initializes the object from the given DOM object, which can contain XML content in either *RSS 2.0* or *Atom 1.0* format.</summary>
    /// <param name="itemDocument">The DOM object, which can contain XML content in either *RSS 2.0* or *Atom 1.0* format.</param>
    [MethodImpl]
    public extern void LoadFromXml(XmlDocument itemDocument);

    /// <summary>Gets or sets the local name of the element.</summary>
    /// <returns>The local name of the element. Must be valid according to XML 1.0.</returns>
    public extern string NodeName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the namespace of the element.</summary>
    /// <returns>The namespace of the element.</returns>
    public extern string NodeNamespace { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text content of the element. If the element contains only child elements, this property is NULL.</summary>
    /// <returns>The text content of the element.</returns>
    public extern string NodeValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the language of the element. This property represents the **xml:lang** attribute on the element. It may be inherited from an ancestor element. It must be valid according to XML 1.0.</summary>
    /// <returns>The **xml:lang** attribute on the element.</returns>
    public extern string Language { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the base URI for the element. This property represents the **xml:base** attribute on the element. It may be inherited from an ancestor element.</summary>
    /// <returns>The **xml:base** attribute on the element.</returns>
    public extern Uri BaseUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the list of custom attributes of the element.</summary>
    /// <returns>A list of attributes of the element.</returns>
    public extern IVector<SyndicationAttribute> AttributeExtensions { [MethodImpl] get; }

    /// <summary>Gets the list of child elements within the element.</summary>
    /// <returns>The list of child elements within the element.</returns>
    public extern IVector<ISyndicationNode> ElementExtensions { [MethodImpl] get; }

    /// <summary>Generates the DOM object that represents this element, all the attributes and child elements including foreign markups. The only formats accepted by this method are *Atom 1.0* and *RSS 2.0*.</summary>
    /// <param name="format">The format of the data.</param>
    /// <returns>The DOM object that represents this element, and all the attributes and child elements, including foreign markups.</returns>
    [MethodImpl]
    public extern XmlDocument GetXmlDocument(SyndicationFormat format);
  }
}
