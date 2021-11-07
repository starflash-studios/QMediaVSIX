// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.EntranceThemeTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Provides the animated transition behavior on controls when they first appear. You can use this on individual objects or on containers of objects. In the latter case, child elements will animate into view in sequence rather than all at the same time.</summary>
  [Static(typeof (IEntranceThemeTransitionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EntranceThemeTransition : Transition, IEntranceThemeTransition
  {
    /// <summary>Initializes a new instance of the EntranceThemeTransition class.</summary>
    [MethodImpl]
    public extern EntranceThemeTransition();

    /// <summary>Gets or sets the distance by which the target is translated in the horizontal direction when the animation is active.</summary>
    /// <returns>The horizontal offset translation, in pixels.</returns>
    public extern double FromHorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance by which the target is translated in the vertical direction when the animation is active.</summary>
    /// <returns>The vertical offset translation, in pixels.</returns>
    public extern double FromVerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether the transition staggers rendering of multiple items, or renders all items at once.</summary>
    /// <returns>**true** if the animation staggers rendering of multiple items. **false** if the animation renders all items at once.</returns>
    public extern bool IsStaggeringEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the FromHorizontalOffset dependency property.</summary>
    /// <returns>The identifier for the FromHorizontalOffset dependency property.</returns>
    public static extern DependencyProperty FromHorizontalOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the FromVerticalOffset dependency property.</summary>
    /// <returns>The identifier for the FromVerticalOffset dependency property.</returns>
    public static extern DependencyProperty FromVerticalOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsStaggeringEnabled dependency property.</summary>
    /// <returns>The identifier for the IsStaggeringEnabled dependency property.</returns>
    public static extern DependencyProperty IsStaggeringEnabledProperty { [MethodImpl] get; }
  }
}
