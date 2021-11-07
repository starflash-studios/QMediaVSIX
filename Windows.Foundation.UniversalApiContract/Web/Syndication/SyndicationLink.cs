// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationLink
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
  /// <summary>Represents a link within a syndication feed or item. This class encapsulates information in the **/rss/channel/link** or /**rss/channel/item/link** element in *RSS 2.0* or the **atom:link** element in *Atom 1.0*.</summary>
  [DualApiPartition(version = 100794368)]
  [Activatable(typeof (ISyndicationLinkFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SyndicationLink : ISyndicationLink, ISyndicationNode
  {
    [MethodImpl]
    public extern SyndicationLink(Uri uri);

    [MethodImpl]
    public extern SyndicationLink(
      Uri uri,
      string relationship,
      string title,
      string mediaType,
      uint length);

    /// <summary>Creates a new SyndicationLink object.</summary>
    [MethodImpl]
    public extern SyndicationLink();

    /// <summary>Gets or sets the length of the linked resource, in bytes.</summary>
    /// <returns>The **length** attribute on **atom:length**.</returns>
    public extern uint Length { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the media type of the linked resource. The string must have the pattern ".+/.+".</summary>
    /// <returns>The **type** attribute on **atom:link**.</returns>
    public extern string MediaType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the relationship type of the link.</summary>
    /// <returns>The **rel** attribute on **atom:link**.</returns>
    public extern string Relationship { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the title of the syndication link.</summary>
    /// <returns>The **atom:title** element.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the URI of the linked resource.</summary>
    /// <returns>The **href** attribute on **atom:link**.</returns>
    public extern Uri Uri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the language of the resource pointed to by the **Uri** property. This property represents the **hreflang** attribute on **atom:link**. It must adhere to the pattern defined by .</summary>
    /// <returns>The language of the resource.</returns>
    public extern string ResourceLanguage { [MethodImpl] get; [MethodImpl] set; }

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
