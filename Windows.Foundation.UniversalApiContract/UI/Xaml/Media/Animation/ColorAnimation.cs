// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ColorAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Animates the value of a Color property between two target values using linear interpolation over a specified Duration.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IColorAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ColorAnimation : Timeline, IColorAnimation
  {
    /// <summary>Initializes a new instance of the ColorAnimation class.</summary>
    [MethodImpl]
    public extern ColorAnimation();

    /// <summary>Gets or sets the animation's starting value.</summary>
    /// <returns>The starting value of the animation. The default is null.</returns>
    public extern IReference<Color> From { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the animation's ending value.</summary>
    /// <returns>The ending value of the animation. The default is null.</returns>
    public extern IReference<Color> To { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the total amount by which the animation changes its starting value.</summary>
    /// <returns>The total amount by which the animation changes its starting value. The default is null.</returns>
    public extern IReference<Color> By { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the easing function applied to this animation.</summary>
    /// <returns>The easing function applied to this animation.</returns>
    public extern EasingFunctionBase EasingFunction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that declares whether animated properties that are considered dependent animations should be permitted to use this animation declaration.</summary>
    /// <returns>**true** if the animation can be used for a dependent animation case. **false** if the animation cannot be used for a dependent animation case. The default is **false**.</returns>
    public extern bool EnableDependentAnimation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the From  dependency property.</summary>
    /// <returns>The identifier for the From  dependency property.</returns>
    public static extern DependencyProperty FromProperty { [MethodImpl] get; }

    /// <summary>Identifies the To  dependency property.</summary>
    /// <returns>The identifier for the To  dependency property.</returns>
    public static extern DependencyProperty ToProperty { [MethodImpl] get; }

    /// <summary>Identifies the By  dependency property.</summary>
    /// <returns>The identifier for the By  dependency property.</returns>
    public static extern DependencyProperty ByProperty { [MethodImpl] get; }

    /// <summary>Identifies the EasingFunction  dependency property.</summary>
    /// <returns>The identifier for the EasingFunction   dependency property.</returns>
    public static extern DependencyProperty EasingFunctionProperty { [MethodImpl] get; }

    /// <summary>Identifies the EnableDependentAnimation dependency property.</summary>
    /// <returns>The identifier for the EnableDependentAnimation dependency property.</returns>
    public static extern DependencyProperty EnableDependentAnimationProperty { [MethodImpl] get; }
  }
}
