// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlNodeSerializer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  /// <summary>Encapsulates the methods needed to serialize a DOM tree or subtree to a string representation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1556460418, 59101, 18833, 171, 239, 6, 216, 210, 231, 189, 12)]
  public interface IXmlNodeSerializer
  {
    /// <summary>Returns the XML representation of the node and all its descendants.</summary>
    /// <returns>The XML representation of the node and all its descendants.</returns>
    string GetXml();

    /// <summary>Gets and sets the text from inside the XML.</summary>
    /// <returns>The text from inside the XML. Returns an empty string if there is no text.</returns>
    string InnerText { get; set; }
  }
}
