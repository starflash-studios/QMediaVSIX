// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ElementCompositeMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Declares alternate composition and blending modes for elements in mixed XAML / Microsoft DirectX UI.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ElementCompositeMode
  {
    /// <summary>Uses values from successive parents in the visual tree. This is the default.</summary>
    Inherit,
    /// <summary>Uses standard XAML source-over-destination mode. This corresponds to D2D1_PRIMITIVE_BLEND_SOURCE_OVER.</summary>
    SourceOver,
    /// <summary>Uses the minimum of the source and destination value for each pixel. This corresponds to D2D1_PRIMITIVE_BLEND_MIN.</summary>
    MinBlend,
  }
}
