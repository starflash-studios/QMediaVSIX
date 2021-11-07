// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkHighContrastAdjustment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Specifies how the InkPresenter object handles input (standard and modified) from the associated InkCanvas control when system is in high contrast mode.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum InkHighContrastAdjustment
  {
    /// <summary>For standard strokes, use selected color if contrast is sufficient against the background. Otherwise, use system color.</summary>
    UseSystemColorsWhenNecessary,
    /// <summary>For standard strokes, use system color.</summary>
    UseSystemColors,
    /// <summary>For standard strokes, use the selected color.</summary>
    UseOriginalColors,
  }
}
