// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationPerson
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
  /// <summary>Represents an author or contributor of syndication content.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ISyndicationPersonFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SyndicationPerson : ISyndicationPerson, ISyndicationNode
  {
    /// <summary>Creates a SyndicationPerson object with the specified **Name** property value.</summary>
    /// <param name="name">The name of the SyndicationPerson. This parameter represents the **atom:name** element.</param>
    [MethodImpl]
    public extern SyndicationPerson(string name);

    [MethodImpl]
    public extern SyndicationPerson(string name, string email, Uri uri);

    /// <summary>Creates a SyndicationPerson object.</summary>
    [MethodImpl]
    public extern SyndicationPerson();

    /// <summary>Gets or sets the email address of the person.</summary>
    /// <returns>The **atom:email** element.</returns>
    public extern string Email { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the name of the syndication person.</summary>
    /// <returns>The **atom:name** element.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Uniform Resource Identifier (URI) of the person. This property represents the **atom:uri** element. It is the absolute Uniform Resource Identifier (URI) resolved against the **xml:base** attribute, if it is present.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the person.</returns>
    public extern Uri Uri { [MethodImpl] get; [MethodImpl] set; }

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
