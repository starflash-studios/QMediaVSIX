// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.TextAlignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Specifies whether text is centered, left-aligned, or right-aligned.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum TextAlignment
  {
    /// <summary>Text is centered within the container.</summary>
    Center = 0,
    /// <summary>Text is aligned to the left edge of the container.</summary>
    Left = 1,
    /// <summary>The beginning of the text is aligned to the edge of the container.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] Start = 1,
    /// <summary>The end of the text is aligned to the edge of the container.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] End = 2,
    /// <summary>Text is aligned to the right edge of the container.</summary>
    Right = 2,
    /// <summary>Text is justified within the container.</summary>
    Justify = 3,
    /// <summary>Text alignment is inferred from the text content.</summary>
    DetectFromContent = 4,
  }
}
