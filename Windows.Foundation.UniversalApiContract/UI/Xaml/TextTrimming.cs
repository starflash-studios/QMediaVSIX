// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.TextTrimming
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Describes how text is trimmed when it overflows the edge of its containing box.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum TextTrimming
  {
    /// <summary>Default.</summary>
    None,
    /// <summary>Text is trimmed at a character boundary. An ellipsis (...) is drawn in place of remaining text.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] CharacterEllipsis,
    /// <summary>Text is trimmed at a word boundary. An ellipsis (...) is drawn in place of remaining text.</summary>
    WordEllipsis,
    /// <summary>Text is trimmed at a pixel level, visually clipping the excess glyphs.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Clip,
  }
}
