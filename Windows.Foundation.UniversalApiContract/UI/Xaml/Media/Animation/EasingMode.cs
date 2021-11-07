// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.EasingMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Specifies how the animation associated with an easing function interpolates.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum EasingMode
  {
    /// <summary>Interpolation follows 100% interpolation minus the output of the formula associated with the easing function.</summary>
    EaseOut,
    /// <summary>Interpolation follows the mathematical formula associated with the easing function.</summary>
    EaseIn,
    /// <summary>Interpolation uses **EaseIn** for the first half of the animation and **EaseOut** for the second half.</summary>
    EaseInOut,
  }
}
