// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.EasingPointKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Associates an easing function with a PointAnimationUsingKeyFrames key-frame animation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IEasingPointKeyFrameStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EasingPointKeyFrame : PointKeyFrame, IEasingPointKeyFrame
  {
    /// <summary>Initializes a new instance of the EasingPointKeyFrame class.</summary>
    [MethodImpl]
    public extern EasingPointKeyFrame();

    /// <summary>Gets or sets the easing function that is applied to the key frame.</summary>
    /// <returns>The easing function that is applied to the key frame.</returns>
    public extern EasingFunctionBase EasingFunction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the EasingFunction dependency property.</summary>
    /// <returns>The identifier for the EasingFunction dependency property.</returns>
    public static extern DependencyProperty EasingFunctionProperty { [MethodImpl] get; }
  }
}
