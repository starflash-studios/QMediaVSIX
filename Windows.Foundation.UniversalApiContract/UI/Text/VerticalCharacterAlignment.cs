// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.VerticalCharacterAlignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Specifies the vertical position of a character relative to a bounding rectangle.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VerticalCharacterAlignment
  {
    /// <summary>The character is positioned at the top edge of the bounding rectangle.</summary>
    Top,
    /// <summary>The character is positioned at the text baseline.</summary>
    Baseline,
    /// <summary>The character is positioned at the bottom edge of the bounding rectangle.</summary>
    Bottom,
  }
}
