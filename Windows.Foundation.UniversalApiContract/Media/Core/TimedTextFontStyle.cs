// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextFontStyle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the font styles that can be used for the display timed text.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum TimedTextFontStyle
  {
    /// <summary>The timed text uses normal font style.</summary>
    Normal,
    /// <summary>The timed text uses oblique font style.</summary>
    Oblique,
    /// <summary>The timed text uses italic font style.</summary>
    Italic,
  }
}
