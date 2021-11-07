// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.PointAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Animates the value of a Point property between two target values using linear interpolation over a specified Duration.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPointAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class PointAnimation : Timeline, IPointAnimation
  {
    /// <summary>Initializes a new instance of the PointAnimation class.</summary>
    [MethodImpl]
    public extern PointAnimation();

    /// <summary>Gets or sets the animation's starting value.</summary>
    /// <returns>The starting value of the animation. The default is **null**.</returns>
    public extern IReference<Point> From { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the animation's ending value.</summary>
    /// <returns>The ending value of the animation. The default is **null**.</returns>
    public extern IReference<Point> To { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the total amount by which the animation changes its starting value.</summary>
    /// <returns>The total amount by which the animation changes its starting value. The default is **null**.</returns>
    public extern IReference<Point> By { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the easing function you are applying to the animation.</summary>
    /// <returns>The easing function you are applying to the animation. The default is null.</returns>
    public extern EasingFunctionBase EasingFunction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that declares whether animated properties that are considered dependent animations should be permitted to use this animation declaration.</summary>
    /// <returns>**true** if the animation can be used for a dependent animation case. **false** if the animation cannot be used for a dependent animation case. The default is **false**.</returns>
    public extern bool EnableDependentAnimation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the From dependency property.</summary>
    /// <returns>The identifier for the From dependency property.</returns>
    public static extern DependencyProperty FromProperty { [MethodImpl] get; }

    /// <summary>Identifies the To dependency property.</summary>
    /// <returns>The identifier for the To dependency property.</returns>
    public static extern DependencyProperty ToProperty { [MethodImpl] get; }

    /// <summary>Identifies the By dependency property.</summary>
    /// <returns>The identifier for the By  dependency property.</returns>
    public static extern DependencyProperty ByProperty { [MethodImpl] get; }

    /// <summary>Identifies the EasingFunction dependency property.</summary>
    /// <returns>The identifier for the EasingFunction  dependency property.</returns>
    public static extern DependencyProperty EasingFunctionProperty { [MethodImpl] get; }

    /// <summary>Identifies the EnableDependentAnimation dependency property.</summary>
    /// <returns>The identifier for the EnableDependentAnimation dependency property.</returns>
    public static extern DependencyProperty EnableDependentAnimationProperty { [MethodImpl] get; }
  }
}
