// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.AdvancedColorKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Describes what kind of Advanced Color the display supports.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum AdvancedColorKind
  {
    /// <summary>The display only supports standard dynamic range. In this case, it is safe to assume that OS composition is being done using an RGB:8 surface encoded as sRGB gamma. The actual wire signalling is usually done using sRGB.</summary>
    StandardDynamicRange,
    /// <summary>The display supports Wide Color Gamut. In this case, it is safe to assume that OS composition is being done using an RGB:FP16 surface encoded as scRGB gamma. The actual wire signalling is usually done using sRGB.</summary>
    WideColorGamut,
    /// <summary>The display supports high dynamic range. In this case, it is safe to assume that OS composition is being done using an RGB:FP16 surface encoded as scRGB gamma. The actual wire signalling is usually done using ST2084.</summary>
    HighDynamicRange,
  }
}
