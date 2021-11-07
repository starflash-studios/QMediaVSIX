// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.TickPlacement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Defines constants that specify the position of tick marks in a Slider in relation to the track that the control implements.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TickPlacement
  {
    /// <summary>No tick marks appear.</summary>
    None,
    /// <summary>Tick marks appear above the track for a horizontal Slider, or to the left of the track for a vertical Slider.</summary>
    TopLeft,
    /// <summary>Tick marks appear below the track for a horizontal Slider, or to the right of the track for a vertical Slider.</summary>
    BottomRight,
    /// <summary>Tick marks appear on both sides of either a horizontal or vertical track.</summary>
    Outside,
    /// <summary>Tick marks appear directly on the track.</summary>
    Inline,
  }
}
