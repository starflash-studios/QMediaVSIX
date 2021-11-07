// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationText
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  /// <summary>Represents text, HTML, or XHTML content. This interface encapsulates elements in *RSS 2.0* or *Atom 1.0* that can have either text, HTML, or XHTML content. In *Atom 1.0* this interface maps to an **atomTextConstruct** in the schema, which can be element **atom:title**, **atom:subtitle**, **atom:rights** or **atom:summary**.</summary>
  [Guid(3117178496, 12602, 16529, 162, 166, 36, 62, 14, 233, 35, 249)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ISyndicationText : ISyndicationNode
  {
    /// <summary>Gets or sets the content of a text content construct like **atom:title**.</summary>
    /// <returns>The text content.</returns>
    string Text { get; set; }

    /// <summary>Gets or sets the type of the content.</summary>
    /// <returns>This value can be "text", "html", "xhtml" or other media types.</returns>
    string Type { get; set; }

    /// <summary>Gets or sets the XML content.</summary>
    /// <returns>The XML content within the **atom:content** element.</returns>
    XmlDocument Xml { get; set; }
  }
}
