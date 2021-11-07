// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents the preconfigured animation that applies to the elements underneath an element being dragged.</summary>
  [Static(typeof (IDragOverThemeAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DragOverThemeAnimation : Timeline, IDragOverThemeAnimation
  {
    /// <summary>Initializes a new instance of the DragOverThemeAnimation class.</summary>
    [MethodImpl]
    public extern DragOverThemeAnimation();

    /// <summary>Gets or sets the reference name of the control element being targeted.</summary>
    /// <returns>The reference name. This is typically the **x:Name** of the relevant element as declared in XAML.</returns>
    public extern string TargetName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance by which the target is translated when the animation is active.</summary>
    /// <returns>The offset, in pixels.</returns>
    public extern double ToOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the direction that the target should translate, when the animation is active.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern AnimationDirection Direction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the TargetName dependency property.</summary>
    /// <returns>The identifier for the TargetName dependency property.</returns>
    public static extern DependencyProperty TargetNameProperty { [MethodImpl] get; }

    /// <summary>Identifies the ToOffset dependency property.</summary>
    /// <returns>The identifier for the ToOffset dependency property.</returns>
    public static extern DependencyProperty ToOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the Direction dependency property.</summary>
    /// <returns>The identifier for the Direction dependency property.</returns>
    public static extern DependencyProperty DirectionProperty { [MethodImpl] get; }
  }
}
