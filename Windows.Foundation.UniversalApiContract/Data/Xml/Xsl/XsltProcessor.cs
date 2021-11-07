// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Xsl.XsltProcessor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Xsl
{
  /// <summary>Provides the methods needed by the Xslt processor.</summary>
  [Activatable(typeof (IXsltProcessorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class XsltProcessor : IXsltProcessor, IXsltProcessor2
  {
    /// <summary>Creates a new XsltProcessor object from the document provided.</summary>
    /// <param name="document">The XSLT to process.</param>
    [MethodImpl]
    public extern XsltProcessor(XmlDocument document);

    /// <summary>Processes a node and its children and returns the resulting string transformation.</summary>
    /// <param name="inputNode">The node to process.</param>
    /// <returns>The resulting transformation.</returns>
    [MethodImpl]
    public extern string TransformToString(IXmlNode inputNode);

    /// <summary>Processes a node and its children and returns the resulting XmlDocument.</summary>
    /// <param name="inputNode">The node to process.</param>
    /// <returns>The resulting transformation.</returns>
    [MethodImpl]
    public extern XmlDocument TransformToDocument(IXmlNode inputNode);
  }
}
