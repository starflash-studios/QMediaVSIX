// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents the preconfigured animation that indicates that a **Swipe** gesture is now possible.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISwipeHintThemeAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SwipeHintThemeAnimation : Timeline, ISwipeHintThemeAnimation
  {
    /// <summary>Initializes a new instance of the SwipeHintThemeAnimation class.</summary>
    [MethodImpl]
    public extern SwipeHintThemeAnimation();

    /// <summary>Gets or sets the reference name of the control element being targeted.</summary>
    /// <returns>The reference name. This is typically the **x:Name** of the relevant element as declared in XAML.</returns>
    public extern string TargetName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance by which the target is translated in the horizontal direction when the animation is active.</summary>
    /// <returns>The horizontal offset translation, in pixels.</returns>
    public extern double ToHorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance by which the target is translated in the vertical direction when the animation is active.</summary>
    /// <returns>The vertical offset, in pixels.</returns>
    public extern double ToVerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the TargetName dependency property.</summary>
    /// <returns>The identifier for the TargetName dependency property.</returns>
    public static extern DependencyProperty TargetNameProperty { [MethodImpl] get; }

    /// <summary>Identifies the ToHorizontalOffset dependency property.</summary>
    /// <returns>The identifier for the ToHorizontalOffset dependency property.</returns>
    public static extern DependencyProperty ToHorizontalOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the ToVerticalOffset dependency property.</summary>
    /// <returns>The identifier for the ToVerticalOffset dependency property.</returns>
    public static extern DependencyProperty ToVerticalOffsetProperty { [MethodImpl] get; }
  }
}
