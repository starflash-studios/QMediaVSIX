﻿// Decompiled with JetBrains decompiler
// Type: Windows.Web.AtomPub.Workspace
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Syndication;

namespace Windows.Web.AtomPub
{
  /// <summary>Encapsulates a workspace in a service document.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Workspace : IWorkspace, ISyndicationNode
  {
    /// <summary>Gets the **atom:title** element under the **app:workspace** element.</summary>
    /// <returns>The text of the title.</returns>
    public extern ISyndicationText Title { [MethodImpl] get; }

    /// <summary>Gets the read-only collection of **app:collection** elements within the **app:workspace** element.</summary>
    /// <returns>The collection of collection elements.</returns>
    public extern IVectorView<ResourceCollection> Collections { [MethodImpl] get; }

    /// <summary>Gets or sets the local name of the element. It must be valid according to XML 1.0.</summary>
    /// <returns>The name of the element.</returns>
    public extern string NodeName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the namespace of the element.</summary>
    /// <returns>The namespace of the element.</returns>
    public extern string NodeNamespace { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text content of the element. If the element contains only child elements, this attribute is NULL.</summary>
    /// <returns>The text of the element.</returns>
    public extern string NodeValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the language of the element. This property represents the **xml:lang** attribute on the element. It may be inherited from an ancestor element. It must be valid according to XML 1.0.</summary>
    /// <returns>The language of the element.</returns>
    public extern string Language { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Uniform Resource Identifier (URI) for the element. This property represents the **xml:base** attribute on the element. It may be inherited from an ancestor element.</summary>
    /// <returns>The base Uniform Resource Identifier (URI) for the element.</returns>
    public extern Uri BaseUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the list of attributes of the element.</summary>
    /// <returns>The list of attributes.</returns>
    public extern IVector<SyndicationAttribute> AttributeExtensions { [MethodImpl] get; }

    /// <summary>Gets the list of child elements within the element.</summary>
    /// <returns>The list of child elements.</returns>
    public extern IVector<ISyndicationNode> ElementExtensions { [MethodImpl] get; }

    /// <summary>Generates the DOM object that represents this element, and all the attributes and child elements including foreign markups.</summary>
    /// <param name="format">The format for the element. The only formats accepted by this method are Atom 1.0 and RSS 2.0.</param>
    /// <returns>The XML document.</returns>
    [MethodImpl]
    public extern XmlDocument GetXmlDocument(SyndicationFormat format);
  }
}