// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationFeed
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
  /// <summary>Contains information about a feed. This class encapsulates the information in the **/rss/channel** element in *RSS 2.0* or the **atom:feed** element in *Atom 1.0*.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ISyndicationFeedFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class SyndicationFeed : ISyndicationFeed, ISyndicationNode
  {
    [MethodImpl]
    public extern SyndicationFeed(string title, string subtitle, Uri uri);

    /// <summary>Creates a new SyndicationFeed object.</summary>
    [MethodImpl]
    public extern SyndicationFeed();

    /// <summary>Gets the authors of an item. This property represents the collection of all the **atom:author** elements under **atom:entry**.</summary>
    /// <returns>The collection of all the **atom:author** elements under **atom:entry**.</returns>
    public extern IVector<SyndicationPerson> Authors { [MethodImpl] get; }

    /// <summary>Gets a collection of categories of the feed. This property represents the collection of all the **atom:category** elements under **atom:feed**.</summary>
    /// <returns>The collection of all **atom:category** elements under **atom:feed**.</returns>
    public extern IVector<SyndicationCategory> Categories { [MethodImpl] get; }

    /// <summary>Gets a collection of the contributors of the feed. This property represents the collection of all the **atom:contributor** elements under **atom:feed**.</summary>
    /// <returns>The collection of all **atom:contributor** elements under **atom:feed**.</returns>
    public extern IVector<SyndicationPerson> Contributors { [MethodImpl] get; }

    /// <summary>Gets or sets the generator of the feed. This property represents the **atom:generator** element or the **generator** element in *RSS 2.0*.</summary>
    /// <returns>The **atom:generator** element or the **generator** element in *RSS 2.0*.</returns>
    public extern SyndicationGenerator Generator { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Uniform Resource Identifier (URI) for the image for the feed. This property represents the **atom:icon** element.</summary>
    /// <returns>The **atom:icon** element. It is the absolute Uniform Resource Identifier (URI) resolved against the **xml:base** attribute, if it is present. If the **href** attribute is a relative Uniform Resource Identifier (URI) string and there is no **xml:base** attribute, this property will be null because the relative Uniform Resource Identifier (URI) is not supported by the runtime Uniform Resource Identifier (URI) class.</returns>
    public extern Uri IconUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the identifier for the syndication feed.</summary>
    /// <returns>The **atom:Id** element or the **guid** element in *RSS 2.0*.</returns>
    public extern string Id { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of items in the feed. This property represents the collection of **atom:entry** elements or a collection of **item** elements in *RSS 2.0*.</summary>
    /// <returns>The collection of **atom:entry** elements or a collection of **item** elements in *RSS 2.0*.</returns>
    public extern IVector<SyndicationItem> Items { [MethodImpl] get; }

    /// <summary>Gets or sets the time the feed was last modified. This property represents the **/rss/channel/lastBuildDate** or **atom:updated** element.</summary>
    /// <returns>The **/rss/channel/lastBuildDate** or **atom:updated** element.</returns>
    public extern DateTime LastUpdatedTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the links associated with the feed. This property represents a collection of the **atom:link** elements under **atom:feed**. In *RSS 2.0*, this maps to the **link** element.</summary>
    /// <returns>A collection of the **atom:link** elements under **atom:feed**. In *RSS 2.0* this maps to the **link** element.</returns>
    public extern IVector<SyndicationLink> Links { [MethodImpl] get; }

    /// <summary>Gets or sets the Uniform Resource Identifier (URI) of the logo for the feed. This property represents the **atom:logo** element or **image/uri** element in *RSS 2.0*.</summary>
    /// <returns>The **atom:logo** element or **image/uri** element in *RSS 2.0*.</returns>
    public extern Uri ImageUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets information about the rights for the feed. This property represents the **atom:rights** element or the **copyright** element in *RSS 2.0*.</summary>
    /// <returns>The **atom:rights** element or the **copyright** element in *RSS 2.0*.</returns>
    public extern ISyndicationText Rights { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the subtitle of the feed. This property represents the **atom:subtitle** element or the **description** element in *RSS 2.0*.</summary>
    /// <returns>The **atom:subtitle** element or the **description** element in *RSS 2.0*.</returns>
    public extern ISyndicationText Subtitle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the title of the syndication feed.</summary>
    /// <returns>The **atom:title** element.</returns>
    public extern ISyndicationText Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the first Uniform Resource Identifier (URI) in a sequence. This property represents the **atom:link** element with attribute **rel=”first”**.</summary>
    /// <returns>The **atom:link** element with attribute **rel="first"**. This property is the absolute Uniform Resource Identifier (URI) resolved against the **xml:base** attribute, if it is present. If the **href** attribute is a relative Uniform Resource Identifier (URI) string and there is no **xml:base** attribute, this property will be null because the relative Uniform Resource Identifier (URI) is not supported by the runtime Uniform Resource Identifier (URI) class.</returns>
    public extern Uri FirstUri { [MethodImpl] get; }

    /// <summary>Gets the last Uniform Resource Identifier (URI) in the sequence. This property represents the **atom:link** element with attribute **rel=”last”**.</summary>
    /// <returns>The **atom:link** element with attribute **rel="last"**. It is the absolute Uniform Resource Identifier (URI) resolved against the **xml:base** attribute, if it is present. If the **href** attribute is a relative Uniform Resource Identifier (URI) string and there is no **xml:base** attribute, this property will be null because the relative Uniform Resource Identifier (URI) is not supported by the runtime Uniform Resource Identifier (URI) class.</returns>
    public extern Uri LastUri { [MethodImpl] get; }

    /// <summary>Gets the next Uniform Resource Identifier (URI) in the sequence. This property represents the **atom:link** element with attribute **rel="next"**.</summary>
    /// <returns>The **atom:link** element with attribute **rel=”next”**. It is the absolute Uniform Resource Identifier (URI) resolved against the **xml:base** attribute, if it is present. If the **href** attribute is a relative Uniform Resource Identifier (URI) string and there is no **xml:base** attribute, this property will be null because the relative Uniform Resource Identifier (URI) is not supported by the runtime Uniform Resource Identifier (URI) class.</returns>
    public extern Uri NextUri { [MethodImpl] get; }

    /// <summary>Gets the previous Uniform Resource Identifier (URI) in the sequence. This property represents the **atom:link** element with attribute **rel="previous"**.</summary>
    /// <returns>The **atom:link** element with attribute **rel=”previous”**. It is the absolute Uniform Resource Identifier (URI) resolved against the **xml:base** attribute, if it is present. If the **href** attribute is a relative Uniform Resource Identifier (URI) string and there is no **xml:base** attribute, this property will be null because the relative Uniform Resource Identifier (URI) is not supported by the runtime Uniform Resource Identifier (URI) class.</returns>
    public extern Uri PreviousUri { [MethodImpl] get; }

    /// <summary>Gets the format of the source document. If the object is not loaded from a document, this property will return **SyndicationFormat_Atom10**.</summary>
    /// <returns>The format of the source document or **SyndicationFormat_Atom10**.</returns>
    public extern SyndicationFormat SourceFormat { [MethodImpl] get; }

    /// <summary>Initializes the object from the given feed string, which can be in either *RSS 2.0* or *Atom 1.0* format.</summary>
    /// <param name="feed">The feed string, which can be in either *RSS 2.0* or *Atom 1.0* format.</param>
    [MethodImpl]
    public extern void Load(string feed);

    /// <summary>Initializes the SyndicationFeed object from the given DOM object, which can contain XML content in either *RSS 2.0 * or *Atom 1.0* format.</summary>
    /// <param name="feedDocument">The DOM object which contains XML content in either *RSS 2.0* or *Atom 1.0* format.</param>
    [MethodImpl]
    public extern void LoadFromXml(XmlDocument feedDocument);

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
