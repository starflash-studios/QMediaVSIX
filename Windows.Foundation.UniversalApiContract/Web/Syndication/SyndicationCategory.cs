// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationCategory
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
  /// <summary>Represents the category of a feed or an item. This class encapsulates information in the **/rss/channel/item/category** element in *RSS 2.0* or the **atom:category** element in *Atom 1.0*.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Activatable(typeof (ISyndicationCategoryFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SyndicationCategory : ISyndicationCategory, ISyndicationNode
  {
    /// <summary>Creates a SyndicationCategory object with the specified **term** property.</summary>
    /// <param name="term">A string that identifies the category. This parameter represents the required **term** attribute on **atom:category** or the text content of the **category** element in *RSS 2.0*.</param>
    [MethodImpl]
    public extern SyndicationCategory(string term);

    /// <summary>Creates SyndicationCategory object with the specified property values.</summary>
    /// <param name="term">A string that identifies the category.</param>
    /// <param name="scheme">The scheme of the category.</param>
    /// <param name="label">A label for display in end-user applications.</param>
    [MethodImpl]
    public extern SyndicationCategory(string term, string scheme, string label);

    /// <summary>Creates a SyndicationCategory object.</summary>
    [MethodImpl]
    public extern SyndicationCategory();

    /// <summary>Gets or sets the label for the category. This property represents the **label** attribute on **atom:category**. It provides a label for display in end-user applications.</summary>
    /// <returns>The **label** attribute on **atom:category**.</returns>
    public extern string Label { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the scheme of the category. This property represents the **scheme** attribute on **atom:category** or the **domain** attribute on the **category** element in *RSS 2.0*.</summary>
    /// <returns>The **scheme** attribute on **atom:category** or the **domain** attribute on the **category** element in *RSS 2.0*.</returns>
    public extern string Scheme { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string that identifies the category. This property represents the required **term** attribute on **atom:category** or the text content of the **category** element in *RSS 2.0*.</summary>
    /// <returns>The required **term** attribute on **atom:category** or the text content of the **category** element in *RSS 2.0*.</returns>
    public extern string Term { [MethodImpl] get; [MethodImpl] set; }

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
