// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Animates the value of an Object property along a set of KeyFrames over a specified Duration.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IObjectAnimationUsingKeyFramesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "KeyFrames")]
  public sealed class ObjectAnimationUsingKeyFrames : Timeline, IObjectAnimationUsingKeyFrames
  {
    /// <summary>Initializes a new instance of the ObjectAnimationUsingKeyFrames class.</summary>
    [MethodImpl]
    public extern ObjectAnimationUsingKeyFrames();

    /// <summary>Gets the collection of ObjectKeyFrame objects that define the animation.</summary>
    /// <returns>The collection of ObjectKeyFrame objects that define the animation. The default is an empty collection.</returns>
    public extern ObjectKeyFrameCollection KeyFrames { [MethodImpl] get; }

    /// <summary>Gets or sets a value that declares whether animated properties that are considered dependent animations should be permitted to use this animation declaration.</summary>
    /// <returns>**true** if the animation can be used for a dependent animation case. **false** if the animation cannot be used for a dependent animation case. The default is **false**.</returns>
    public extern bool EnableDependentAnimation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the EnableDependentAnimation dependency property.</summary>
    /// <returns>The identifier for the EnableDependentAnimation dependency property.</returns>
    public static extern DependencyProperty EnableDependentAnimationProperty { [MethodImpl] get; }
  }
}
