// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Animates the value of a Point property along a set of KeyFrames.</summary>
  [ContentProperty(Name = "KeyFrames")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IPointAnimationUsingKeyFramesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PointAnimationUsingKeyFrames : Timeline, IPointAnimationUsingKeyFrames
  {
    /// <summary>Initializes a new instance of the PointAnimationUsingKeyFrames class.</summary>
    [MethodImpl]
    public extern PointAnimationUsingKeyFrames();

    /// <summary>Gets the collection of PointKeyFrame objects that define the animation.</summary>
    /// <returns>The collection of PointKeyFrame objects that define the animation. The default is an empty collection.</returns>
    public extern PointKeyFrameCollection KeyFrames { [MethodImpl] get; }

    /// <summary>Gets or sets a value that declares whether animated properties that are considered dependent animations should be permitted to use this animation declaration.</summary>
    /// <returns>**true** if the animation can be used for a dependent animation case. **false** if the animation cannot be used for a dependent animation case. The default is **false**.</returns>
    public extern bool EnableDependentAnimation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the EnableDependentAnimation dependency property.</summary>
    /// <returns>The identifier for the EnableDependentAnimation dependency property.</returns>
    public static extern DependencyProperty EnableDependentAnimationProperty { [MethodImpl] get; }
  }
}
