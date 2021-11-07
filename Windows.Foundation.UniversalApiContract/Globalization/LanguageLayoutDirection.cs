// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.LanguageLayoutDirection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  /// <summary>Defines constants that specify the content layout direction (for text and UI elements) most appropriate for a language.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum LanguageLayoutDirection
  {
    /// <summary>Indicates a content layout direction of left to right.</summary>
    Ltr,
    /// <summary>Indicates a content layout direction of right to left (for example, for Arabic or other RTL languages).</summary>
    Rtl,
    /// <summary>Indicates a content layout direction that flows from the top to the bottom of the page; the first top-to-bottom column of content is on the left, and columns are added from left to right.</summary>
    TtbLtr,
    /// <summary>Indicates a content layout direction that flows from the top to the bottom of the page; the first top-to-bottom column of content is on the right, and columns are added from right to left.</summary>
    TtbRtl,
  }
}
