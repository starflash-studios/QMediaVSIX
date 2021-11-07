// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlText
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  /// <summary>Represents the text content of an element or attribute.</summary>
  [Guid(4180780235, 12429, 18272, 161, 213, 67, 182, 116, 80, 172, 126)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IXmlText : IXmlCharacterData, IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    /// <summary>Splits this text node into two text nodes at the specified offset and inserts the new text node into the tree as a sibling that immediately follows this node.</summary>
    /// <param name="offset">The number of characters at which to split this text node into two nodes, starting from zero.</param>
    /// <returns>The new text node.</returns>
    IXmlText SplitText(uint offset);
  }
}
