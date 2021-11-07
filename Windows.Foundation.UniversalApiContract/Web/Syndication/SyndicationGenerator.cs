// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationGenerator
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
  /// <summary>Describes the agent or the tool used to generate the feed. This class encapsulates information in the **/rss/channel/generator** element in *RSS 2.0* or the **/atom:feed/atom:generator** element in *Atom 1.0*.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Activatable(typeof (ISyndicationGeneratorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class SyndicationGenerator : ISyndicationGenerator, ISyndicationNode
  {
    /// <summary>Creates a new SyndicationGenerator object with the specified **Text** property value.</summary>
    /// <param name="text">Identifies the generator. This parameter represents the text content in the **atom:generator** element or the **generator** element in *RSS 2.0*.</param>
    [MethodImpl]
    public extern SyndicationGenerator(string text);

    /// <summary>Creates a new SyndicationGenerator object.</summary>
    [MethodImpl]
    public extern SyndicationGenerator();

    /// <summary>Gets or sets the text that identifies the generator.</summary>
    /// <returns>The text content in the **atom:generator** element or the **generator** element in RSS 2.0.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Uniform Resource Identifier (URI) of the syndication generator.</summary>
    /// <returns>The **href** attribute on **atom:link**.</returns>
    public extern Uri Uri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the version of the generator.</summary>
    /// <returns>The **version** attribute on **atom:generator**.</returns>
    public extern string Version { [MethodImpl] get; [MethodImpl] set; }

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
