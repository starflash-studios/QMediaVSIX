// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.HandwritingPanelPlacementAlignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify where the handwriting view panel is anchored to the control.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  public enum HandwritingPanelPlacementAlignment
  {
    /// <summary>The system determines the best place to anchor the handwriting view panel.</summary>
    Auto,
    /// <summary>The handwriting view panel is anchored to the top left corner of the control.</summary>
    TopLeft,
    /// <summary>The handwriting view panel is anchored to the top right corner of the control.</summary>
    TopRight,
    /// <summary>The handwriting view panel is anchored to the bottom left corner of the control.</summary>
    BottomLeft,
    /// <summary>The handwriting view panel is anchored to the bottom right corner of the control.</summary>
    BottomRight,
  }
}
