// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.HorizontalCharacterAlignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Specifies the horizontal position of a character relative to a bounding rectangle.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HorizontalCharacterAlignment
  {
    /// <summary>The character is at the left edge of the bounding rectangle.</summary>
    Left,
    /// <summary>The character is at the right edge of the bounding rectangle.</summary>
    Right,
    /// <summary>The character is at the center of the bounding rectangle.</summary>
    Center,
  }
}
