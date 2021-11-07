// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.MarkerStyle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Specifies the style used to mark the item paragraphs in a list.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MarkerStyle
  {
    /// <summary>The marker style is not defined.</summary>
    Undefined,
    /// <summary>The item marker is followed by a parenthesis, as in 1).</summary>
    Parenthesis,
    /// <summary>The item marker is enclosed in parentheses, as in (1).</summary>
    Parentheses,
    /// <summary>The item marker is followed by a period.</summary>
    Period,
    /// <summary>The item marker appears by itself.</summary>
    Plain,
    /// <summary>The item marker is followed by a hyphen (-).</summary>
    Minus,
    /// <summary>The items have no markers.</summary>
    NoNumber,
  }
}
