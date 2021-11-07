// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Text.TextUnit
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Text
{
  /// <summary>Represents predefined units of text for the purposes of navigation within a document.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TextUnit
  {
    /// <summary>Specifies that the text unit is one character in length.</summary>
    Character,
    /// <summary>Specifies that the text unit is the length of a single, common format specification, such as bold, italic, or similar.</summary>
    Format,
    /// <summary>Specifies that the text unit is one word in length.</summary>
    Word,
    /// <summary>Specifies that the text unit is one line in length.</summary>
    Line,
    /// <summary>Specifies that the text unit is one paragraph in length.</summary>
    Paragraph,
    /// <summary>Specifies that the text unit is one document-specific page in length.</summary>
    Page,
    /// <summary>Specifies that the text unit is an entire document in length.</summary>
    Document,
  }
}
