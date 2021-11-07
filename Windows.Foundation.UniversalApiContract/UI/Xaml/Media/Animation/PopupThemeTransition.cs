// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.PopupThemeTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Provides the animated transition behavior that applies to pop-in components of controls (for example, tooltip-like UI on an object) as they appear.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPopupThemeTransitionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PopupThemeTransition : Transition, IPopupThemeTransition
  {
    /// <summary>Initializes a new instance of the PopUpThemeTransition class.</summary>
    [MethodImpl]
    public extern PopupThemeTransition();

    /// <summary>Gets or sets the distance by which the target is translated in the horizontal direction when the animation is active.</summary>
    /// <returns>The horizontal offset translation, in pixels.</returns>
    public extern double FromHorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance by which the target is translated in the vertical direction when the animation is active.</summary>
    /// <returns>The vertical offset translation, in pixels.</returns>
    public extern double FromVerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the FromHorizontalOffset dependency property.</summary>
    /// <returns>The identifier for the FromHorizontalOffset dependency property.</returns>
    public static extern DependencyProperty FromHorizontalOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the FromVerticalOffset dependency property.</summary>
    /// <returns>The identifier for the FromVerticalOffset dependency property.</returns>
    public static extern DependencyProperty FromVerticalOffsetProperty { [MethodImpl] get; }
  }
}
