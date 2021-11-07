// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationText
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
  /// <summary>Implements the ISyndicationText interface that encapsulates elements in *RSS 2.0* or *Atom 1.0* that can have either text, HTML, or XHTML. In *Atom 1.0*, this object maps to an **atomTextConstruct** in the schema, which can be **atom:title**, **atom:subtitle**, **atom:rights**, or **atom:summary** elements.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (ISyndicationTextFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  public sealed class SyndicationText : ISyndicationText, ISyndicationNode
  {
    /// <summary>Creates a new SyndicationText object with the specified **Text** property value.</summary>
    /// <param name="text">The content of a text content construct like **atom:title**.</param>
    [MethodImpl]
    public extern SyndicationText(string text);

    /// <summary>Creates a new SyndicationText object with the specified **Text** and **Type** property values.</summary>
    /// <param name="text">The content of a text content construct like **atom:title**.</param>
    /// <param name="type">The type of the content. This value can be "text", "html", and "xhtml".</param>
    [MethodImpl]
    public extern SyndicationText(string text, SyndicationTextType type);

    /// <summary>Creates a new SyndicationText object.</summary>
    [MethodImpl]
    public extern SyndicationText();

    /// <summary>Gets the content of a text content construct like **atom:title**.</summary>
    /// <returns>The text content.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the type of the content.</summary>
    /// <returns>This value can be "text", "html", "xhtml" or other media types.</returns>
    public extern string Type { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the XML content.</summary>
    /// <returns>The XML content within the **atom:content** element.</returns>
    public extern XmlDocument Xml { [MethodImpl] get; [MethodImpl] set; }

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
