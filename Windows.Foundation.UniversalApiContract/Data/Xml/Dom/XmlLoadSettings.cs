// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.XmlLoadSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  /// <summary>Contains settings that are used during loading and parsing of XML documents. The default settings are chosen for the highest security. This class can be instantiated and is accepted by LoadXml, LoadFromUriAsync, and LoadFromFileAsync.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class XmlLoadSettings : IXmlLoadSettings
  {
    /// <summary>Creates a new XmlLoadSettings object.</summary>
    [MethodImpl]
    public extern XmlLoadSettings();

    /// <summary>Gets and sets the limits of the element depth of an XML document to be loaded into a DOM object.</summary>
    /// <returns>The depth value. The default value is 256.</returns>
    public extern uint MaxElementDepth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether to prohibit or allow the inclusion of a DTD in the XML DOM document.</summary>
    /// <returns>True to prohibit the inclusion of a DTD in the XML DOM document; false to allow the inclusion. The default value is true.</returns>
    public extern bool ProhibitDtd { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether external definitions, resolvable namespaces, external subsets of document type definitions (DTDs), and external entity references are to be resolved at the time the document is parsed.</summary>
    /// <returns>True if external definitions, resolvable namespaces, external subsets of DTDs, and external entity references are resolved at the time the document is parsed; otherwise false. The default value is false.</returns>
    public extern bool ResolveExternals { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the XML parser should validate this document against the document type definition (DTD) on loading.</summary>
    /// <returns>If true, the internal or external DTD will be used to validate the document. The default value is false.</returns>
    public extern bool ValidateOnParse { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies whether default handling preserves white space.</summary>
    /// <returns>True if default processing preserves white space; otherwise false. The default value is true.</returns>
    public extern bool ElementContentWhiteSpace { [MethodImpl] get; [MethodImpl] set; }
  }
}
