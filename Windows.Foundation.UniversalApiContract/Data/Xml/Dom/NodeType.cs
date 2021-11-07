// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.NodeType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  /// <summary>The type of an IXmlNode, as returned by the NodeType property.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum NodeType
  {
    /// <summary>Default value. Never used by the API.</summary>
    Invalid,
    /// <summary>The node is an XmlElement type.</summary>
    ElementNode,
    /// <summary>The node is an XmlAttribute type.</summary>
    AttributeNode,
    /// <summary>The node is an XmlText type.</summary>
    TextNode,
    /// <summary>The node is an XmlCDataSection type.</summary>
    DataSectionNode,
    /// <summary>The node is an XmlEntityReference object.</summary>
    EntityReferenceNode,
    /// <summary>The node is an DtdEntity type.</summary>
    EntityNode,
    /// <summary>The node is an XmlProcessingInstruction type.</summary>
    ProcessingInstructionNode,
    /// <summary>The node is an XmlComment type.</summary>
    CommentNode,
    /// <summary>The node is an XmlDocument type.</summary>
    DocumentNode,
    /// <summary>The node is an XmlDocumentType type.</summary>
    DocumentTypeNode,
    /// <summary>The node is an XmlDocumentFragment type.</summary>
    DocumentFragmentNode,
    /// <summary>The node is a DtdNotation type.</summary>
    NotationNode,
  }
}
